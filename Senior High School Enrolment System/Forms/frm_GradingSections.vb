Public Class frm_GradingSections
    Dim strSQL As String
    Public strTeacherCode As String

    Private Sub frm_GradingSections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSchoolYear.Text = Format(Now, "yyyy") & "-" & Format(Now, "yyyy") + 1
        cboSemester.Text = "First"
        Call setHeader()
        Call getSection()
        Call getYear()
    End Sub

    Public Sub setHeader()
        Dim btnView As New DataGridViewButtonColumn()

        btnView.FlatStyle = FlatStyle.Flat
        btnView.DefaultCellStyle.BackColor = Color.DarkGreen
        btnView.DefaultCellStyle.ForeColor = Color.White
        btnView.DefaultCellStyle.SelectionBackColor = Color.DarkGreen
        btnView.DefaultCellStyle.SelectionForeColor = Color.White
        With grdSection
            .Columns.Add("colSecCode", "SECTION") : .Columns(0).Width = .Width * 0.14
            .Columns.Add("colSubCode", "SUBJECT CODE") : .Columns(1).Width = .Width * 0.15
            .Columns.Add("colCourseCode", "COURSE") : .Columns(2).Width = .Width * 0.14
            .Columns.Add("colLevel", "GRADE") : .Columns(3).Width = .Width * 0.12
            .Columns.Add("colName", "DESCRIPTION") : .Columns(4).Width = .Width * 0.382
            .Columns.Add(btnView) : .Columns(5).Width = .Width * 0.06
        End With
    End Sub

    Public Sub getSection()
        Dim rsSection As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT SC.SectionCode,SC.SubjectCode,SC.CourseCode, S.GradeLevel, S.SectionName FROM Schedules SC" & vbCrLf
        strSQL &= "INNER JOIN Sections S ON S.SectionCode = SC.SectionCode " & vbCrLf
        strSQL &= "WHERE SC.TeacherCode = '" & strTeacherCode & "'" & vbCrLf
        strSQL &= "AND SC.SchoolYear='" & cboSchoolYear.Text & "'" & vbCrLf
        rsSection.Open(strSQL, conDB, 1, 4)

        grdSection.RowCount = 0
        Do While rsSection.EOF = False
            With grdSection
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Rows(.RowCount - 1).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Rows(.RowCount - 1).Cells(2).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Rows(.RowCount - 1).Cells(3).Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Rows(.RowCount - 1).Cells(0).Value = UCase(rsSection.Fields(0).Value)
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSection.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = UCase(rsSection.Fields(2).Value)
                .Rows(.RowCount - 1).Cells(3).Value = UCase(rsSection.Fields(3).Value)
                .Rows(.RowCount - 1).Cells(4).Value = UCase(rsSection.Fields(4).Value)
                .Rows(.RowCount - 1).Cells(5).Value = "..."

                rsSection.MoveNext()
            End With
        Loop
    End Sub
    
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim rsSearch As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT SC.SectionCode,SC.CourseCode, S.GradeLevel, S.SectionName   FROM Schedules SC" & vbCrLf
        strSQL &= "INNER JOIN Sections S ON S.SectionCode = SC.SectionCode " & vbCrLf
        strSQL &= "WHERE SC.TeacherCode = '" & strTeacherCode & "'" & vbCrLf
        strSQL &= "AND SC.SectionCode LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        strSQL &= "OR SC.CourseCode LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        strSQL &= "OR S.GradeLevel LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        strSQL &= "OR S.SectionName LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        rsSearch.Open(strSQL, conDB, 1, 4)

        grdSection.RowCount = 0
        Do While rsSearch.EOF = False
            With grdSection
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = UCase(rsSearch.Fields(0).Value)
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSearch.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = UCase(rsSearch.Fields(2).Value)
                .Rows(.RowCount - 1).Cells(3).Value = UCase(rsSearch.Fields(3).Value)
                .Rows(.RowCount - 1).Cells(4).Value = UCase(rsSearch.Fields(4).Value)
                .Rows(.RowCount - 1).Cells(5).Value = "..."

                rsSearch.MoveNext()
            End With
        Loop
    End Sub

    Public Sub getYear()
        Dim strPrevYear As String
        Dim strFutYear As String
        Dim strYear As String

        strPrevYear = Format(Now, "yyyy") - 5
        strFutYear = Format(Now, "yyyy") + 15

        For i As Integer = strPrevYear To strFutYear
            strYear = i & "-" & i + 1

            cboSchoolYear.Items.Add(strYear)
        Next
    End Sub

    Private Sub grdSection_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdSection.CellContentClick
        Dim rsCheck As New ADODB.Recordset
        Dim rsStudents As New ADODB.Recordset
        Dim rsInsert As New ADODB.Recordset

        If e.ColumnIndex = 5 Then

            '//Get all students in the section
            strSQL = vbNullString
            strSQL &= "SELECT * FROM StudentSection " & vbCrLf
            strSQL &= "WHERE SectionCode = '" & grdSection.Rows(e.RowIndex).Cells(0).Value() & "'" & vbCrLf
            strSQL &= "AND schoolyear = '" & cboSchoolYear.Text & "'" & vbCrLf
            rsStudents.Open(strSQL, conDB, 1, 4)

            If rsStudents.EOF = False Then

                Do While rsStudents.EOF = False
                    '//checks if studentID is already in the StudentGrades table
                    strSQL = vbNullString
                    strSQL &= "SELECT * FROM StudentGrades" & vbCrLf
                    strSQL &= "WHERE SchoolYear = '" & cboSchoolYear.Text & "'" & vbCrLf
                    strSQL &= "AND StudentID = '" & rsStudents.Fields(1).Value & "'" & vbCrLf
                    strSQL &= "AND TeacherID = '" & strTeacherCode & "'" & vbCrLf
                    strSQL &= "AND SectionCD = '" & grdSection.Rows(e.RowIndex).Cells(0).Value() & "'" & vbCrLf
                    strSQL &= "AND SubjectCD = '" & grdSection.Rows(e.RowIndex).Cells(1).Value() & "'" & vbCrLf
                    rsCheck.Open(strSQL, conDB, 1, 4)

                    If rsCheck.EOF = True Then
                        '//if studentID does not exist in StudentGrades table then Insert
                        strSQL = vbNullString
                        strSQL &= "INSERT INTO StudentGrades " & vbCrLf
                        strSQL &= "VALUES (" & vbCrLf
                        strSQL &= "'" & cboSchoolYear.Text & "'" & vbCrLf
                        strSQL &= ",'" & rsStudents.Fields(1).Value & "'" & vbCrLf
                        strSQL &= ",'" & strTeacherCode & "'" & vbCrLf
                        strSQL &= ",'" & grdSection.Rows(e.RowIndex).Cells(0).Value() & "'" & vbCrLf
                        strSQL &= ",'" & grdSection.Rows(e.RowIndex).Cells(1).Value() & "'" & vbCrLf
                        strSQL &= ",'" & IIf(cboSemester.Text = "First", 1, 2) & "'" & vbCrLf
                        strSQL &= ",NULL" & vbCrLf
                        strSQL &= ",NULL" & vbCrLf
                        strSQL &= ",NULL" & vbCrLf
                        strSQL &= ",getDate()" & vbCrLf
                        strSQL &= ",getDate()" & vbCrLf
                        strSQL &= ",NULL" & vbCrLf
                        strSQL &= ",'" & frm_Login.txtUserName.Text & "')" & vbCrLf
                        rsInsert.Open(strSQL, conDB, 1, 4)
                    End If

                    rsStudents.MoveNext()
                Loop

            End If

            frm_StudentGrading.lblYear.Text = cboSchoolYear.Text
            frm_StudentGrading.lblSection.Text = grdSection.Rows(e.RowIndex).Cells(4).Value()
            frm_StudentGrading.lblTeacherName.Text = getTeacherName(strTeacherCode)
            frm_StudentGrading.lblSubject.Text = getSubjectName(grdSection.Rows(e.RowIndex).Cells(1).Value())
            frm_StudentGrading.lblSem.Text = cboSemester.Text

            frm_StudentGrading.ShowDialog()
        End If
    End Sub
End Class