Public Class frm_AddStudent
    Dim rsStudent As New ADODB.Recordset
    Dim rsStrandName As New ADODB.Recordset

    Dim strSQL As String
    Public isUpdate As Boolean

    Private Sub frm_AddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getTrack()
        Call getStrands()

        If isUpdate = True Then
            btnUpdate.Visible = True
            btnAdd.Visible = False
            txtLRN.Enabled = False

            'STRAND
            cboTarck.SelectedIndex = CInt(rsStudent.Fields(19).Value) - 1
            cboStrand.Text = rsStrandName.Fields(0).Value
            cboSpecial.Text = rsStrandName.Fields(1).Value
        Else
            btnUpdate.Visible = False
            btnAdd.Visible = True
            txtLRN.Enabled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim rsInsertStudent As New ADODB.Recordset
        Dim rsInsertFamBG As New ADODB.Recordset
        Dim rsStudentID As New ADODB.Recordset
        Dim rsCheck As New ADODB.Recordset

        If txtLRN.Text = "" Or cboClassification.Text = "" Or txtFName.Text = "" Or txtLName.Text = "" _
            Or cboSex.Text = "" Or txtHouseNo.Text = "" Or txtSubdBrgy.Text = "" Or txtCity.Text = "" Then '//if any of the require info are not filled up

            MsgBox("Please complete all the required information!", vbExclamation) '//Show message
        Else
            If MsgBox("Are you sure you want to save?", vbYesNo) = vbYes Then '//ask user if want to save

                Call SQLConnect() '//call connection to database

                strSQL = vbNullString
                strSQL &= "SELECT * FROM Students" & vbCrLf
                strSQL &= "WHERE LRN ='" & txtLRN.Text & "'" & vbCrLf
                rsCheck.Open(strSQL, conDB, 1, 4)

                If rsCheck.EOF = False Then
                    MsgBox("Learner Reference Number (LRN) already exist! Please re-enter new Learner Reference Number (LRN)", vbExclamation)
                Else
                    '//INSERT QUERY (Students table)
                    strSQL = vbNullString
                    strSQL &= "SELECT RIGHT('000000'+CAST(COALESCE(MAX(StudentID) + 1, '1') AS VARCHAR(6)),6) FROM Students"
                    rsStudentID.Open(strSQL, conDB, 1, 4)

                    strSQL = vbNullString
                    strSQL = strSQL & "INSERT INTO Students " & vbCrLf
                    strSQL = strSQL & "VALUES (" & vbCrLf
                    strSQL = strSQL & "'" & rsStudentID.Fields(0).Value & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtLRN.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtFName.Text & "'," & vbCrLf

                    If lblMName.Text = "" Then
                        lblMName.Text = vbNullString '// null 
                    End If
                    If txtExtName.Text = "" Then

                        txtExtName.Text = vbNullString
                    End If

                    strSQL = strSQL & "'" & txtMName.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtLName.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtExtName.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & Format(dtpBirthday.Value, "yyyy/MM/dd") & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtAge.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & cboSex.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtReligion.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtHouseNo.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtSubdBrgy.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtCity.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtContactNo.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtZipCode.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & chkIP.Checked & "'," & vbCrLf
                    strSQL = strSQL & "'" & getStudentClass(cboClassification.Text) & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtPrevSchool.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & cboGradeLevel.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & getTrackCode(cboTarck.Text) & "'," & vbCrLf
                    strSQL = strSQL & "'" & getStrandCode(cboStrand.Text) & "'," & vbCrLf
                    strSQL = strSQL & "'" & getSpecialCode(cboSpecial.Text, getStrandCode(cboStrand.Text)) & "'," & vbCrLf
                    strSQL = strSQL & "'" & chkPSA.Checked & "'," & vbCrLf
                    strSQL = strSQL & "'" & chkReportCard.Checked & "'," & vbCrLf
                    strSQL = strSQL & "'" & chkTOR.Checked & "'," & vbCrLf
                    strSQL = strSQL & "getdate()," & vbCrLf
                    strSQL = strSQL & "NULL," & vbCrLf
                    strSQL = strSQL & "getdate()," & vbCrLf
                    strSQL = strSQL & "'" & frm_Login.txtUserName.Text & "')" & vbCrLf '//end of query
                    rsInsertStudent.Open(strSQL, conDB, 1, 4)


                    '// INSERT QUERY (FamilyBackground Table)
                    strSQL = vbNullString
                    strSQL = strSQL & "INSERT INTO FamilyBackground " & vbCrLf
                    strSQL = strSQL & "VALUES (" & vbCrLf
                    strSQL = strSQL & "'" & txtLRN.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtFLName.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtFFName.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtFMName.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtMLName.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtMFName.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtMMName.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtGuardianName.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtHomeAddress.Text & "'," & vbCrLf
                    strSQL = strSQL & "'" & txtFamContactNo.Text & "'," & vbCrLf
                    strSQL = strSQL & "getDate()," & vbCrLf
                    strSQL = strSQL & "null," & vbCrLf
                    strSQL = strSQL & "getDate()," & vbCrLf
                    strSQL = strSQL & "'" & frm_Login.txtUserName.Text & "')" & vbCrLf
                    rsInsertFamBG.Open(strSQL, conDB, 1, 4)

                    Call AuditTrail(1, "Register New Student")


                    MsgBox("STUDENT REGISTERED!", vbInformation)
                    Me.Close()
                End If

            End If
        End If
    End Sub
    Public Sub getStrands()
        Dim rsStrands As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL = strSQL & "SELECT CourseCode, CourseName FROM Strand"
        rsStrands.Open(strSQL, conDB, 1, 4)

        For i = 1 To rsStrands.RecordCount
            cboStrand.Items.Add(rsStrands.Fields(1).Value)

            rsStrands.MoveNext()
        Next
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cboClassification_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClassification.SelectedIndexChanged

        'If UCase(cboClassification.Text) = UCase("transferee") Then
        '    txtPrevSchool.Enabled = True
        'End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim rsUpdateStudent As New ADODB.Recordset
        Dim rsUpdateFamBG As New ADODB.Recordset

        If MsgBox("Are you sure you want to update?", vbYesNo + vbQuestion) = vbYes Then

            strSQL = vbNullString
            strSQL &= "UPDATE Students" & vbCrLf
            strSQL &= "SET FirstName = '" & txtFName.Text & "'" & vbCrLf
            strSQL &= ", MiddleName = '" & txtMName.Text & "'" & vbCrLf
            strSQL &= ", LastName ='" & txtLName.Text & "'" & vbCrLf
            strSQL &= ", ExtName ='" & txtExtName.Text & "'" & vbCrLf
            strSQL &= ", Birthday ='" & Format(dtpBirthday.Value, "yyyy/MM/dd") & "'" & vbCrLf
            strSQL &= ", Age =" & txtAge.Text & vbCrLf
            strSQL &= ", Sex = '" & cboSex.Text & "'" & vbCrLf
            strSQL &= ", Religion = '" & txtReligion.Text & "'" & vbCrLf
            strSQL &= ", HouseNo = '" & txtHouseNo.Text & "'" & vbCrLf
            strSQL &= ", BrgyNo = '" & txtSubdBrgy.Text & "'" & vbCrLf
            strSQL &= ", City  = '" & txtCity.Text & "'" & vbCrLf
            strSQL &= ", ContactNo = '" & txtContactNo.Text & "'" & vbCrLf
            strSQL &= ", ZipCode = '" & txtZipCode.Text & "'" & vbCrLf
            strSQL &= ", isIndigenous ='" & chkIP.Checked & "'" & vbCrLf
            strSQL &= ", Classification = '" & cboClassification.SelectedIndex + 1 & "'" & vbCrLf
            strSQL &= ", PreviousSchool = '" & txtPrevSchool.Text & "'" & vbCrLf
            strSQL &= ", GradeLevel = '" & cboGradeLevel.Text & "'" & vbCrLf
            strSQL &= ", TrackID = '" & getTrackCode(cboTarck.Text) & "'" & vbCrLf
            strSQL &= ", StrandCode = '" & getStrandCode(cboStrand.Text) & "'" & vbCrLf
            strSQL &= ", SpecializationCD = '" & getSpecialCode(cboSpecial.Text, getStrandCode(cboStrand.Text)) & "'" & vbCrLf
            strSQL &= ", havePSA = '" & chkPSA.Checked & "'" & vbCrLf
            strSQL &= ", haveReportCard = '" & chkReportCard.Checked & "'" & vbCrLf
            strSQL &= ", haveTOR = '" & chkTOR.Checked & "'" & vbCrLf
            strSQL &= ", UpdatedDate = getdate()" & vbCrLf
            strSQL &= ", UpdatedBy = NULL" & vbCrLf
            strSQL &= "WHERE LRN = '" & txtLRN.Text & "'" & vbCrLf
            rsUpdateStudent.Open(strSQL, conDB, 1, 4)

            strSQL = vbNullString
            strSQL &= "UPDATE FamilyBackground" & vbCrLf
            strSQL &= "SET FatherLastName = '" & txtFLName.Text & "'" & vbCrLf
            strSQL &= ", FatherFirstName = '" & txtFFName.Text & "'" & vbCrLf
            strSQL &= ", FatherMiddleName = '" & txtFMName.Text & "'" & vbCrLf
            strSQL &= ", MotherLastName = '" & txtMLName.Text & "'" & vbCrLf
            strSQL &= ", MotherFirstName = '" & txtMFName.Text & "'" & vbCrLf
            strSQL &= ", MotherMiddleName = '" & txtMMName.Text & "'" & vbCrLf
            strSQL &= ", GuardianName = '" & txtGuardianName.Text & "'" & vbCrLf
            strSQL &= ", Address = '" & txtHomeAddress.Text & "'" & vbCrLf
            strSQL &= ", ContactNo = '" & txtFamContactNo.Text & "'" & vbCrLf
            strSQL &= ", UpdatedDate = getdate()" & vbCrLf
            strSQL &= ", UpdatedBy = NULL" & vbCrLf
            strSQL &= "WHERE StudentLRN = '" & txtLRN.Text & "'" & vbCrLf
            rsUpdateFamBG.Open(strSQL, conDB, 1, 4)

            Call AuditTrail(2, "UPDATED STUDENT INFORMATION")

            Call frm_StudentRecords.getStudent()
            MsgBox("Student Record Updated!", vbInformation)
            Me.Close()

        End If
    End Sub

    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged

        txtAge.Text = DateDiff("YYYY", Format(dtpBirthday.Value, "yyyy/MM/dd"), Format(Date.Today, "yyyy/MM/dd"))
    End Sub

    Public Sub getTrack()
        Dim rsTrack As New ADODB.Recordset

        strSQL = vbNullString
        strSQL &= "SELECT * FROM Tracks "
        rsTrack.Open(strSQL, conDB, 1, 4)

        Do While rsTrack.EOF = False
            cboTarck.Items.Add(rsTrack.Fields(1).Value)
            rsTrack.MoveNext()
        Loop
    End Sub
    Public Sub getSpecialization()
        Dim rsSpecial As New ADODB.Recordset

        strSQL = vbNullString
        strSQL &= "SELECT * FROM Specialization " & vbCrLf
        strSQL &= "WHERE CourseCode='" & getStrandCode(cboStrand.Text) & "'" & vbCrLf
        rsSpecial.Open(strSQL, conDB, 1, 4)

        cboSpecial.Items.Clear()

        Do While rsSpecial.EOF = False
            cboSpecial.Items.Add(rsSpecial.Fields(2).Value)
            rsSpecial.MoveNext()
        Loop
    End Sub

    Private Sub cboStrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStrand.SelectedIndexChanged
        Call getSpecialization()
    End Sub

    Public Sub viewStudentRecord(strLRN As String)
        isUpdate = True

        rsStudent = New ADODB.Recordset
        Call SQLConnect()
        strSQL = vbNullString
        strSQL = strSQL & "SELECT * FROM Students S" & vbCrLf
        strSQL = strSQL & "INNER JOIN FamilyBackground F ON S.LRN = F.StudentLRN " & vbCrLf
        strSQL = strSQL & "WHERE S.LRN = '" & strLRN & "' " & vbCrLf
        rsStudent.Open(strSQL, conDB, 1, 4)

        'Student Information
        txtLRN.Text = rsStudent.Fields(1).Value
        txtFName.Text = rsStudent.Fields(2).Value
        txtMName.Text = rsStudent.Fields(3).Value
        txtLName.Text = rsStudent.Fields(4).Value
        txtExtName.Text = rsStudent.Fields(5).Value
        dtpBirthday.Text = rsStudent.Fields(6).Value
        txtAge.Text = rsStudent.Fields(7).Value
        cboSex.Text = rsStudent.Fields(8).Value
        txtReligion.Text = rsStudent.Fields(9).Value
        txtHouseNo.Text = rsStudent.Fields(10).Value
        txtSubdBrgy.Text = rsStudent.Fields(11).Value
        txtCity.Text = rsStudent.Fields(12).Value
        txtContactNo.Text = rsStudent.Fields(13).Value
        txtZipCode.Text = rsStudent.Fields(14).Value
        chkIP.Checked = rsStudent.Fields(15).Value
        cboClassification.Text = getStudentClassType(rsStudent.Fields(16).Value)
        txtPrevSchool.Text = rsStudent.Fields(17).Value
        cboGradeLevel.Text = rsStudent.Fields(18).Value
        cboTarck.Text = getTrackName(rsStudent.Fields(19).Value)
        cboStrand.Text = getStrandName(rsStudent.Fields(20).Value)
        cboSpecial.Text = getSpecialName(rsStudent.Fields(21).Value, rsStudent.Fields(20).Value)
        chkPSA.Checked = rsStudent.Fields(22).Value
        chkReportCard.Checked = rsStudent.Fields(23).Value
        chkTOR.Checked = rsStudent.Fields(24).Value

        'Family Background
        txtFLName.Text = rsStudent.Fields(30).Value
        txtFFName.Text = rsStudent.Fields(31).Value
        txtFMName.Text = rsStudent.Fields(32).Value
        txtMLName.Text = rsStudent.Fields(33).Value
        txtMFName.Text = rsStudent.Fields(34).Value
        txtMMName.Text = rsStudent.Fields(35).Value
        txtGuardianName.Text = rsStudent.Fields(36).Value
        txtHomeAddress.Text = rsStudent.Fields(37).Value
        txtFamContactNo.Text = rsStudent.Fields(38).Value

        'Strand 
        rsStrandName = New ADODB.Recordset
        strSQL = vbNullString
        strSQL &= "SELECT STR.CourseName, SPC.Specialization FROM Strand STR" & vbCrLf
        strSQL &= "INNER JOIN Specialization SPC ON STR.CourseCode = SPC.CourseCode" & vbCrLf
        strSQL &= "WHERE STR.CourseCode = '" & rsStudent.Fields(20).Value & "'" & vbCrLf
        strSQL &= "AND SPC.Code = '" & rsStudent.Fields(21).Value & "'" & vbCrLf
        rsStrandName.Open(strSQL, conDB, 1, 4)

        'SY
        Dim rsSY As New ADODB.Recordset
        strSQL = vbNullString
        strSQL = "SELECT SchoolYear FROM StudentSection WHERE StudentID = '" & rsStudent.Fields(0).Value & "'"
        rsSY.Open(strSQL, conDB, 1, 4)

        If rsSY.EOF = False Then lblSchoolYr.Text = rsSY.Fields(0).Value

        Me.ShowDialog()
    End Sub
End Class