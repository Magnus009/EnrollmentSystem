Public Class frm_IrregAssignSection

    Dim strStudentLRN As String
    Dim strStudentID As String

    Private Sub frm_IrregAssignSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ViewSched()
    End Sub

    Public Sub getStudentID(strLRN As String)
        Call SQLConnect()
        rsDB = New ADODB.Recordset
        strQuery = "SELECT StudentID FROM Students WHERE LRN = '" & strLRN & "'"
        rsDB.Open(strQuery, conDB, 2, 1)
        strStudentID = rsDB.Fields(0).Value
        strStudentLRN = strLRN

        Me.ShowDialog()
    End Sub

    Private Sub ViewSched()
        Dim rsSched As New ADODB.Recordset
        Dim strSQL As String

        Call SQLConnect()
        strSQL = vbNullString
        strSQL = "SELECT SC.ScheduleCode, SB.Description, SC.SectionCode, SC.TimeFrom, SC.TimeTo, SB.Units FROM Schedules SC" & vbCrLf
        strSQL &= "INNER JOIN Subject SB ON SB.SubjectCode = SC.SubjectCode" & vbCrLf
        strSQL &= "WHERE SC.ScheduleCode NOT IN (" & vbCrLf
        strSQL &= "	SELECT IR.ScheduleCode FROM IrregSchedules IR" & vbCrLf
        strSQL &= "	INNER JOIN Students S ON IR.StudentID = S.StudentID" & vbCrLf
        strSQL &= "	WHERE S.LRN = '" & strStudentLRN & "')"

        If txtSearch.Text <> "" Then
            strSQL &= " AND (SC.SectionCode LIKE '%" & txtSearch.Text & "%'" & vbCrLf
            strSQL &= " OR SB.Description LIKE '%" & txtSearch.Text & "%'" & vbCrLf
            strSQL &= " OR SC.ScheduleCode LIKE '%" & txtSearch.Text & "%')" & vbCrLf
        End If
        rsSched.Open(strSQL, conDB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly)

        With grdSched
            .RowCount = 0
            Do While rsSched.EOF = False
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(1).Value = rsSched.Fields(0).Value 'SchedCD
                .Rows(.RowCount - 1).Cells(2).Value = rsSched.Fields(1).Value 'Description
                .Rows(.RowCount - 1).Cells(3).Value = rsSched.Fields(2).Value 'Section
                .Rows(.RowCount - 1).Cells(4).Value = Format(rsSched.Fields(3).Value, "Short Time") & " - " & Format(rsSched.Fields(4).Value, "Short Time") ' TIME
                .Rows(.RowCount - 1).Cells(5).Value = rsSched.Fields(5).Value 'UNITS

                rsSched.MoveNext()
            Loop
        End With
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        MsgBox("Do you want to add this Subject(s)?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ASSIGN SUBJECT")
        If vbYes Then
            With grdSched
                For i As Integer = 0 To .RowCount - 1
                    If CBool(DirectCast(.Rows(i).Cells(0), DataGridViewCheckBoxCell).Value) = True Then
                        strQuery = vbNullString
                        strQuery = "INSERT INTO IrregSchedules" & vbCrLf
                        strQuery &= "VALUES ('" & .Rows(i).Cells(1).Value & "'," & vbCrLf
                        strQuery &= "'" & strStudentID & "'," & vbCrLf
                        strQuery &= "getdate(), NULL, NULL, getdate()," & vbCrLf
                        strQuery &= "'" & UserName & "')"
                        conDB.Execute(strQuery)
                    End If
                Next

                MsgBox("Section(s) Assigned!", MsgBoxStyle.Information)
                Me.Close()
                frm_IrregSchedule.getSubjects()
            End With
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Call ViewSched()
    End Sub
End Class