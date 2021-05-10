Public Class frm_AssignStudents
    Dim strSQL As String
    Dim strStudentCD As String

    Dim strSY As String
    Private Sub frm_AssignStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Month(Now) >= 5 Then
            strSY = Str(Year(Now)) & " -" & Str(Year(Now) + 1)
        Else
            strSY = Str(Year(Now) - 1) & " -" & Str(Year(Now))
        End If

        Call getStrand()
        Call setHeader()
        Call getStudents()
        strStudentCD = vbNullString
    End Sub
    Private Sub getStrand()
        Dim rsStrand As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT CourseName FROM Strand "
        rsStrand.Open(strSQL, conDB, 1, 4)

        cboStrand.Items.Add("ALL")
        Do While rsStrand.EOF = False
            cboStrand.Items.Add(rsStrand.Fields(0).Value)
            rsStrand.MoveNext()
        Loop
        cboStrand.SelectedIndex = 0
    End Sub
    Private Sub setHeader()
        Dim chkAssign As New DataGridViewCheckBoxColumn

        chkAssign.FlatStyle = FlatStyle.Flat
        With grdStudents
            .Columns.Clear()
            .Columns.Add("colCode", "CODE") : .Columns(0).Width = .Width * 0.2 : .Columns(0).ReadOnly = True
            .Columns.Add("colNAME", "SECTION NAME") : .Columns(1).Width = .Width * 0.65 : .Columns(1).ReadOnly = True
            .Columns.Add(chkAssign) : .Columns(2).Width = .Width * 0.14
        End With
    End Sub
    Private Sub getStudents()
        Dim rsStudents As New ADODB.Recordset

        strSQL = vbNullString
        strSQL &= "SELECT StudentID, LastName + ', ' + FirstName + ' ' +" & vbCrLf
        strSQL &= "CASE WHEN MiddleName='' OR MiddleName IS NULL THEN ' '" & vbCrLf
        strSQL &= "ELSE MiddleName END + ' ' +" & vbCrLf
        strSQL &= "CASE WHEN ExtName='' OR ExtName IS NULL THEN ''" & vbCrLf
        strSQL &= "ELSE ExtName END AS Name, Classification" & vbCrLf
        strSQL &= "FROM Students" & vbCrLf
        strSQL &= "WHERE StudentID NOT IN (SELECT StudentID FROM StudentSection WHERE SchoolYear = '" & Trim(strSY) & "')" & vbCrLf

        If cboStrand.Text <> "ALL" Then
            strSQL &= "AND StrandCode = '" & getStrandCode(cboStrand.Text) & "'" & vbCrLf
        End If

        If cboLevel.Text <> "" Then
            strSQL &= "AND GradeLevel =" & cboLevel.Text & vbCrLf
        End If

        rsStudents.Open(strSQL, conDB, 1, 4)

        If rsStudents.EOF = True Then
            MsgBox("No Student Enrolled in " & cboStrand.Text, vbExclamation)
            Call getAllStudents()
        Else
            grdStudents.RowCount = 0
            Do While rsStudents.EOF = False
                With grdStudents
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = rsStudents.Fields(0).Value
                    .Rows(.RowCount - 1).Cells(1).Value = UCase(rsStudents.Fields(1).Value)

                    If rsStudents.Fields(2).Value = 2 Then
                        .Rows(.RowCount - 1).Cells(0).Style.BackColor = Color.Orange
                        .Rows(.RowCount - 1).Cells(0).Style.SelectionBackColor = Color.OrangeRed
                        .Rows(.RowCount - 1).Cells(1).Style.BackColor = Color.Orange
                        .Rows(.RowCount - 1).Cells(1).Style.SelectionBackColor = Color.OrangeRed
                        .Rows(.RowCount - 1).Cells(2).Style.BackColor = Color.Orange
                        .Rows(.RowCount - 1).Cells(2).Style.SelectionBackColor = Color.OrangeRed
                    End If

                    rsStudents.MoveNext()
                End With
            Loop
        End If
    End Sub
    Private Sub getAllStudents()
        Dim rsStudents As New ADODB.Recordset

        strSQL = vbNullString
        strSQL &= "SELECT StudentID, LastName + ', ' + FirstName + ' ' +" & vbCrLf
        strSQL &= "CASE WHEN MiddleName='' OR MiddleName IS NULL THEN ' '" & vbCrLf
        strSQL &= "ELSE MiddleName END + ' ' +" & vbCrLf
        strSQL &= "CASE WHEN ExtName='' OR ExtName IS NULL THEN ''" & vbCrLf
        strSQL &= "ELSE ExtName END AS Name, Classification" & vbCrLf
        strSQL &= "FROM Students" & vbCrLf
        strSQL &= "WHERE StudentID NOT IN (SELECT StudentID FROM StudentSection WHERE SchoolYear = '" & Trim(strSY) & "')" & vbCrLf
        rsStudents.Open(strSQL, conDB, 1, 4)

        grdStudents.RowCount = 0
        Do While rsStudents.EOF = False
            With grdStudents
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = rsStudents.Fields(0).Value
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsStudents.Fields(1).Value)

                If rsStudents.Fields(2).Value = 2 Then
                    .Rows(.RowCount - 1).Cells(0).Style.BackColor = Color.Orange
                    .Rows(.RowCount - 1).Cells(0).Style.SelectionBackColor = Color.OrangeRed
                    .Rows(.RowCount - 1).Cells(1).Style.BackColor = Color.Orange
                    .Rows(.RowCount - 1).Cells(1).Style.SelectionBackColor = Color.OrangeRed
                    .Rows(.RowCount - 1).Cells(2).Style.BackColor = Color.Orange
                    .Rows(.RowCount - 1).Cells(2).Style.SelectionBackColor = Color.OrangeRed
                End If

                rsStudents.MoveNext()
            End With
        Loop
    End Sub
    Private Sub grdStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdStudents.CellContentClick
        If e.ColumnIndex = 2 Then
            strStudentCD &= grdStudents.Rows(e.RowIndex).Cells(0).Value() + ","
        End If
    End Sub
    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        Dim strCode() As String
        Dim rsInsert As New ADODB.Recordset

        If MsgBox("Are you sure you want to register these students to Section " & frm_ViewSection.lblSecyionName.Text & "?", vbYesNo) = vbYes Then
            strStudentCD = strStudentCD.Substring(0, strStudentCD.Length - 1)
            strCode = strStudentCD.Split(",")

            For i = 0 To UBound(strCode)
                strSQL = vbNullString
                strSQL &= "INSERT INTO StudentSection" & vbCrLf
                strSQL &= "VALUES (" & vbCrLf
                strSQL &= "'" & Trim(strSY) & "'" & vbCrLf
                strSQL &= ",'" & strCode(i) & "'" & vbCrLf
                strSQL &= ",'" & frm_ViewSection.lblSectionCode.Text & "'" & vbCrLf
                strSQL &= ",getDate()" & vbCrLf
                strSQL &= ",NULL" & vbCrLf
                strSQL &= ",getDate()" & vbCrLf
                strSQL &= ",'" & frm_Login.txtUserName.Text & "')" & vbCrLf
                rsInsert.Open(strSQL, conDB, 1, 4)
            Next
            MsgBox("Registration done!", vbInformation)
            Call frm_ViewSection.getStudents()
            Me.Close()
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim rsSearch As New ADODB.Recordset

        If txtSearch.Text = "Search Student Code and Student Name..." Then txtSearch.Text = ""
        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT StudentID, LastName + ', ' + FirstName + ' ' +" & vbCrLf
        strSQL &= "CASE WHEN MiddleName='' OR MiddleName IS NULL THEN ' '" & vbCrLf
        strSQL &= "ELSE MiddleName END + ' ' +" & vbCrLf
        strSQL &= "CASE WHEN ExtName='' OR ExtName IS NULL THEN ''" & vbCrLf
        strSQL &= "ELSE ExtName END AS Name, Classification" & vbCrLf
        strSQL &= "FROM Students" & vbCrLf
        strSQL &= "WHERE StudentID NOT IN (SELECT StudentID FROM StudentSection WHERE SchoolYear = '" & Trim(strSY) & "')" & vbCrLf
        strSQL &= "AND (StudentID LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        strSQL &= "OR FirstName LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        strSQL &= "OR MiddleName LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        strSQL &= "OR LastName LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        strSQL &= "OR ExtName LIKE '%" & txtSearch.Text & "%')" & vbCrLf
        rsSearch.Open(strSQL, conDB, 1, 4)

        grdStudents.RowCount = 0
        Do While rsSearch.EOF = False
            With grdStudents
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = rsSearch.Fields(0).Value
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSearch.Fields(1).Value)

                If rsSearch.Fields(2).Value = 2 Then
                    .Rows(.RowCount - 1).Cells(0).Style.BackColor = Color.Orange
                    .Rows(.RowCount - 1).Cells(0).Style.SelectionBackColor = Color.OrangeRed
                    .Rows(.RowCount - 1).Cells(1).Style.BackColor = Color.Orange
                    .Rows(.RowCount - 1).Cells(1).Style.SelectionBackColor = Color.OrangeRed
                    .Rows(.RowCount - 1).Cells(2).Style.BackColor = Color.Orange
                    .Rows(.RowCount - 1).Cells(2).Style.SelectionBackColor = Color.OrangeRed
                End If

                rsSearch.MoveNext()
            End With
        Loop
    End Sub
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim rsStudents As New ADODB.Recordset

        Call SQLConnect()
        rsStudents = New ADODB.Recordset
        strSQL = vbNullString
        strSQL &= "SELECT StudentID, LastName + ', ' + FirstName + ' ' +" & vbCrLf
        strSQL &= "CASE WHEN MiddleName='' OR MiddleName IS NULL THEN ' '" & vbCrLf
        strSQL &= "ELSE MiddleName END + ' ' +" & vbCrLf
        strSQL &= "CASE WHEN ExtName='' OR ExtName IS NULL THEN ''" & vbCrLf
        strSQL &= "ELSE ExtName END AS Name, Classification" & vbCrLf
        strSQL &= "FROM Students" & vbCrLf

        If cboStrand.Text <> "ALL" Then
            strSQL &= "WHERE StrandCode = '" & getStrandCode(cboStrand.Text) & "'" & vbCrLf
        End If

        If cboLevel.Text <> "" Then
            strSQL &= "AND GradeLevel = " & cboLevel.Text & vbCrLf
        End If

        rsStudents.Open(strSQL, conDB, 1, 4)

        If rsStudents.EOF = True Then
            MsgBox("No Student Enrolled in " & cboStrand.Text, vbExclamation)
            Call getAllStudents()
        Else
            grdStudents.RowCount = 0
            Do While rsStudents.EOF = False
                With grdStudents
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = rsStudents.Fields(0).Value
                    .Rows(.RowCount - 1).Cells(1).Value = UCase(rsStudents.Fields(1).Value)

                    If rsStudents.Fields(2).Value = 2 Then
                        .Rows(.RowCount - 1).Cells(0).Style.BackColor = Color.Orange
                        .Rows(.RowCount - 1).Cells(0).Style.SelectionBackColor = Color.OrangeRed
                        .Rows(.RowCount - 1).Cells(1).Style.BackColor = Color.Orange
                        .Rows(.RowCount - 1).Cells(1).Style.SelectionBackColor = Color.OrangeRed
                        .Rows(.RowCount - 1).Cells(2).Style.BackColor = Color.Orange
                        .Rows(.RowCount - 1).Cells(2).Style.SelectionBackColor = Color.OrangeRed
                    End If

                    rsStudents.MoveNext()
                End With
            Loop
        End If
    End Sub
End Class