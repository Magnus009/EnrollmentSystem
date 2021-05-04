Public Class frm_StudentGrading
    Dim strSQL As String
    Private Sub frm_StudentGrading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setHeader()
        Call getStudents()
    End Sub

    Public Sub setHeader()


        With grdStudents
            .Columns.Add("colCode", "CODE") : .Columns(0).Width = .Width * 0.1
            .Columns.Add("colStudentName", "NAME") : .Columns(1).Width = .Width * 0.6
            .Columns.Add("colQ1", "Q1") : .Columns(2).Width = .Width * 0.1
            .Columns.Add("colQ2", "Q2") : .Columns(3).Width = .Width * 0.1
            .Columns.Add("colFinal", "FINAL GRADE") : .Columns(4).Width = .Width * 0.1

        End With
    End Sub

    Public Sub getStudents()
        Dim rsStudentList As New ADODB.Recordset

        'Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT SG.StudentID, " & vbCrLf
        strSQL &= "S.LastName + ', ' + S.FirstName + ' ' +" & vbCrLf
        strSQL &= "CASE WHEN S.MiddleName = '' THEN ''" & vbCrLf
        strSQL &= "ELSE S.MiddleName END + ' ' + " & vbCrLf
        strSQL &= "CASE WHEN s.ExtName = '' THEN ''" & vbCrLf
        strSQL &= "ELSE S.ExtName END AS Name, SG.Quarter1, SG.Quarter2, SG.FinalGrade FROM StudentGrades SG" & vbCrLf
        strSQL &= "INNER JOIN Students S ON SG.StudentID = S.StudentID" & vbCrLf
        strSQL &= "WHERE SchoolYear = '" & lblYear.Text & "'" & vbCrLf
        strSQL &= "AND TeacherID = '" & frm_GradingSections.strTeacherCode & "'" & vbCrLf
        strSQL &= "AND SectionCD = '" & getSectionCode(lblSection.Text) & "'" & vbCrLf
        strSQL &= "AND SubjectCD = '" & getSubjectCode(lblSubject.Text) & "'" & vbCrLf
        rsStudentList.Open(strSQL, conDB, 1, 4)


        grdStudents.RowCount = 0
        Do While rsStudentList.EOF = False
            With grdStudents
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Rows(.RowCount - 1).Cells(2).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Rows(.RowCount - 1).Cells(3).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Rows(.RowCount - 1).Cells(4).Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Rows(.RowCount - 1).Cells(0).Value = UCase(rsStudentList.Fields(0).Value)
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsStudentList.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = rsStudentList.Fields(2).Value
                .Rows(.RowCount - 1).Cells(3).Value = rsStudentList.Fields(3).Value
                .Rows(.RowCount - 1).Cells(4).Value = rsStudentList.Fields(4).Value


                rsStudentList.MoveNext()
            End With
        Loop
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim rsUpdate As New ADODB.Recordset


        If MsgBox("Are you sure you want to save changes?", vbYesNo) = vbYes Then
            With grdStudents
                For i = 0 To .RowCount

                    strSQL = vbNullString
                    strSQL &= "UPDATE dbo.StudentGrades" & vbCrLf
                    strSQL &= "SET Quarter1 ='" & .Rows(i).Cells(2).Value & "'" & vbCrLf
                    strSQL &= ", Quarter2 ='" & .Rows(i).Cells(3).Value & "'" & vbCrLf
                    strSQL &= ", FinalGrade ='" & .Rows(i).Cells(4).Value & "'" & vbCrLf
                    strSQL &= ", UpdatedDate = getdate()" & vbCrLf
                    strSQL &= ", UpdatedBy = '" & frm_Login.txtUserName.Text & "'" & vbCrLf
                    strSQL &= "WHERE SchoolYear = '" & lblYear.Text & "'" & vbCrLf
                    strSQL &= "AND StudentID = '" & .Rows(i).Cells(0).Value & "'" & vbCrLf
                    strSQL &= "AND TeacherID = '" & getTeacherCode(lblTeacherName.Text) & "'" & vbCrLf
                    strSQL &= "AND SectionCD = '" & getSectionCode(lblSection.Text) & "'" & vbCrLf
                    strSQL &= "AND SubjectCD = '" & getSubjectCode(lblSubject.Text) & "'" & vbCrLf
                    rsUpdate.Open(strSQL, conDB, 1, 4)

                    i += 1
                Next
                MsgBox("Grades evaluated!", vbInformation)
            End With
           

        End If
        


    End Sub
End Class