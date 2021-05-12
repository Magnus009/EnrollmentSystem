Public Class frm_AddStudent
    Dim strSQL As String
    Public isUpdate As Boolean
    Public strLRN As String

    Private Sub frm_AddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getTrack()
        getStrands()
        getStudentClassification()

        If isUpdate = True Then
            btnUpdate.Visible = True
            btnAdd.Visible = False
            txtLRN.Enabled = False
            viewStudentRecord(strLRN)
            'STRAND
            'cboTrack.SelectedIndex = CInt(rsStudent.Fields(19).Value) - 1
            'cboStrand.Text = rsStrandName.Fields(0).Value
            'cboSpecial.Text = rsStrandName.Fields(1).Value
        Else
            btnUpdate.Visible = False
            btnAdd.Visible = True
            txtLRN.Enabled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim intCheck As Integer
            Dim strID As String
            Dim blnResult As Boolean

            If checkRequire(Me) = True Then '//if any of the require info are not filled up
                MsgBox("Please complete all the required information!", vbExclamation) '//Show message
            Else
                If MsgBox("Are you sure you want to save?", vbYesNo) = vbYes Then '//ask user if want to save

                    strSQL = "SELECT count(*) FROM Students" & vbCrLf
                    strSQL &= "WHERE LRN ='" & txtLRN.Text & "'" & vbCrLf
                    intCheck = SELECT_SHS(strSQL).Rows(0)(0)

                    If intCheck <> 0 Then
                        MsgBox("Learner Reference Number (LRN) already exist! Please re-enter new Learner Reference Number (LRN)", vbExclamation)
                    Else
                        '//INSERT QUERY (Students table)
                        strSQL = "SELECT RIGHT('000000'+CAST(COALESCE(MAX(StudentID) + 1, '1') AS VARCHAR(6)),6) FROM Students"
                        strID = SELECT_SHS(strSQL).Rows(0)(0)

                        strSQL += "INSERT INTO Students " & vbCrLf
                        strSQL += "VALUES (" & vbCrLf
                        strSQL += "'" & strID & "'," & vbCrLf
                        strSQL += "'" & txtLRN.Text & "'," & vbCrLf
                        strSQL += "'" & txtFName.Text & "'," & vbCrLf
                        If lblMName.Text = "" Then
                            lblMName.Text = vbNullString '// null 
                        End If
                        If txtExtName.Text = "" Then

                            txtExtName.Text = vbNullString
                        End If
                        strSQL += "'" & txtMName.Text & "'," & vbCrLf
                        strSQL += "'" & txtLName.Text & "'," & vbCrLf
                        strSQL += "'" & txtExtName.Text & "'," & vbCrLf
                        strSQL += "'" & Format(dtpBirthday.Value, "yyyy/MM/dd") & "'," & vbCrLf
                        strSQL += "'" & txtAge.Text & "'," & vbCrLf
                        strSQL += "'" & cboSex.Text & "'," & vbCrLf
                        strSQL += "'" & txtReligion.Text & "'," & vbCrLf
                        strSQL += "'" & txtHouseNo.Text & "'," & vbCrLf
                        strSQL += "'" & txtSubdBrgy.Text & "'," & vbCrLf
                        strSQL += "'" & txtCity.Text & "'," & vbCrLf
                        strSQL += "'" & txtProvince.Text & "'," & vbCrLf
                        strSQL += "'" & txtContactNo.Text & "'," & vbCrLf
                        strSQL += "'" & txtZipCode.Text & "'," & vbCrLf
                        strSQL += "'" & chkIP.Checked & "'," & vbCrLf
                        strSQL += "'" & getStudentClass(cboClassification.Text) & "'," & vbCrLf
                        strSQL += "'" & txtPrevSchool.Text & "'," & vbCrLf
                        strSQL += "'" & cboGradeLevel.Text & "'," & vbCrLf
                        strSQL += "'" & cboTrack.SelectedValue.ToString & "'," & vbCrLf
                        strSQL += "'" & cboStrand.SelectedValue.ToString & "'," & vbCrLf
                        strSQL += "'" & cboSpecial.SelectedValue.ToString & "'," & vbCrLf
                        strSQL += "'" & chkPSA.Checked & "'," & vbCrLf
                        strSQL += "'" & chkReportCard.Checked & "'," & vbCrLf
                        strSQL += "'" & chkTOR.Checked & "'," & vbCrLf
                        strSQL += "getdate()," & vbCrLf
                        strSQL += "NULL," & vbCrLf
                        strSQL += "getdate()," & vbCrLf
                        strSQL += "'" & frm_Login.txtUserName.Text & "')" & vbCrLf '//end of query
                        blnResult = EXEC_SHS(strSQL)


                        If blnResult = True Then
                            '// INSERT QUERY (FamilyBackground Table)
                            strSQL = vbNullString
                            strSQL += "INSERT INTO FamilyBackground " & vbCrLf
                            strSQL += "VALUES (" & vbCrLf
                            strSQL += "'" & txtLRN.Text & "'," & vbCrLf
                            strSQL += "'" & txtFLName.Text & "'," & vbCrLf
                            strSQL += "'" & txtFFName.Text & "'," & vbCrLf
                            strSQL += "'" & txtFMName.Text & "'," & vbCrLf
                            strSQL += "'" & txtMLName.Text & "'," & vbCrLf
                            strSQL += "'" & txtMFName.Text & "'," & vbCrLf
                            strSQL += "'" & lblProvince.Text & "'," & vbCrLf
                            strSQL += "'" & txtGuardianName.Text & "'," & vbCrLf
                            strSQL += "'" & txtRelationship.Text & "'," & vbCrLf
                            strSQL += "'" & txtHomeAddress.Text & "'," & vbCrLf
                            strSQL += "'" & txtFamContactNo.Text & "'," & vbCrLf
                            strSQL += "getDate()," & vbCrLf
                            strSQL += "null," & vbCrLf
                            strSQL += "getDate()," & vbCrLf
                            strSQL += "'" & frm_Login.txtUserName.Text & "')" & vbCrLf
                            blnResult = EXEC_SHS(strSQL)
                        End If

                        If blnResult = True Then
                            Call AuditTrail(1, "Register New Student")
                            MsgBox("STUDENT REGISTERED!", vbInformation)
                            Me.Close()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Public Sub getStrands()
        strSQL = "SELECT CourseCode, CourseName FROM Strand"
        cboDataBind(cboStrand, strSQL, "--SELECT STRAND--")
    End Sub
    Public Sub getStudentClassification()
        strSQL = "SELECT TypeID, Description FROM StudentType"
        cboDataBind(cboClassification, strSQL)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim blnResult As Boolean

            If MsgBox("Are you sure you want to update?", vbYesNo + vbQuestion) = vbYes Then
                strSQL = "UPDATE Students" & vbCrLf
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
                strSQL &= ", Province  = '" & txtProvince.Text & "'" & vbCrLf
                strSQL &= ", ContactNo = '" & txtContactNo.Text & "'" & vbCrLf
                strSQL &= ", ZipCode = '" & txtZipCode.Text & "'" & vbCrLf
                strSQL &= ", isIndigenous ='" & chkIP.Checked & "'" & vbCrLf
                strSQL &= ", Classification = '" & cboClassification.SelectedIndex + 1 & "'" & vbCrLf
                strSQL &= ", PreviousSchool = '" & txtPrevSchool.Text & "'" & vbCrLf
                strSQL &= ", GradeLevel = '" & cboGradeLevel.Text & "'" & vbCrLf
                strSQL &= ", TrackID = '" & cboTrack.SelectedValue.ToString & "'" & vbCrLf
                strSQL &= ", StrandCode = '" & cboStrand.SelectedValue.ToString & "'" & vbCrLf
                strSQL &= ", SpecializationCD = '" & cboSpecial.SelectedValue.ToString & "'" & vbCrLf
                strSQL &= ", havePSA = '" & chkPSA.Checked & "'" & vbCrLf
                strSQL &= ", haveReportCard = '" & chkReportCard.Checked & "'" & vbCrLf
                strSQL &= ", haveTOR = '" & chkTOR.Checked & "'" & vbCrLf
                strSQL &= ", UpdatedDate = getdate()" & vbCrLf
                strSQL &= ", UpdatedBy = NULL" & vbCrLf
                strSQL &= "WHERE LRN = '" & txtLRN.Text & "'" & vbCrLf
                blnResult = EXEC_SHS(strSQL)

                If blnResult = True Then
                    strSQL = "UPDATE FamilyBackground" & vbCrLf
                    strSQL &= "SET FatherLastName = '" & txtFLName.Text & "'" & vbCrLf
                    strSQL &= ", FatherFirstName = '" & txtFFName.Text & "'" & vbCrLf
                    strSQL &= ", FatherMiddleName = '" & txtFMName.Text & "'" & vbCrLf
                    strSQL &= ", MotherLastName = '" & txtMLName.Text & "'" & vbCrLf
                    strSQL &= ", MotherFirstName = '" & txtMFName.Text & "'" & vbCrLf
                    strSQL &= ", MotherMiddleName = '" & lblProvince.Text & "'" & vbCrLf
                    strSQL &= ", GuardianName = '" & txtGuardianName.Text & "'" & vbCrLf
                    strSQL &= ", Relationship = '" & txtRelationship.Text & "'" & vbCrLf
                    strSQL &= ", Address = '" & txtHomeAddress.Text & "'" & vbCrLf
                    strSQL &= ", ContactNo = '" & txtFamContactNo.Text & "'" & vbCrLf
                    strSQL &= ", UpdatedDate = getdate()" & vbCrLf
                    strSQL &= ", UpdatedBy = NULL" & vbCrLf
                    strSQL &= "WHERE StudentLRN = '" & txtLRN.Text & "'" & vbCrLf
                    blnResult = EXEC_SHS(strSQL)
                End If

                If blnResult = True Then
                    Call AuditTrail(2, "UPDATED STUDENT INFORMATION")
                    Call frm_StudentRecords.getStudent()
                    MsgBox("Student Record Updated!", vbInformation)
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        txtAge.Text = DateDiff("YYYY", Format(dtpBirthday.Value, "yyyy/MM/dd"), Format(Date.Today, "yyyy/MM/dd"))
    End Sub

    Public Sub getTrack()
        strSQL = "SELECT TrackID,Track FROM Tracks"
        cboDataBind(cboTrack, strSQL, "--SELECT TRACK--")
    End Sub
    Public Sub getSpecialization()
        strSQL = "SELECT Code, Specialization FROM Specialization " & vbCrLf
        strSQL &= "WHERE CourseCode='" & cboStrand.SelectedValue.ToString & "'" & vbCrLf
        cboDataBind(cboSpecial, strSQL, "--SELECT SPECIALIZATION--")
        AddHandler cboStrand.SelectedIndexChanged, AddressOf cboStrand_Changed
    End Sub

    Private Sub cboStrand_Changed(sender As Object, e As EventArgs)
        If cboStrand.SelectedIndex <> 0 Then
            Call getSpecialization()
            cboSpecial.Enabled = True
        Else
            cboSpecial.Enabled = False
        End If

    End Sub

    Public Sub viewStudentRecord(strLRN As String)
        Try
            Dim dtStudent As New DataTable

            strSQL = vbNullString
            strSQL += "SELECT * FROM Students S" & vbCrLf
            strSQL += "INNER JOIN FamilyBackground F ON S.LRN = F.StudentLRN " & vbCrLf
            strSQL += "WHERE S.LRN = '" & strLRN & "' " & vbCrLf
            dtStudent = SELECT_SHS(strSQL)

            'Student Information
            txtLRN.Text = dtStudent.Rows(0)("LRN")
            txtFName.Text = dtStudent.Rows(0)("FirstName")
            txtMName.Text = dtStudent.Rows(0)("MiddleName")
            txtLName.Text = dtStudent.Rows(0)("LastName")
            txtExtName.Text = dtStudent.Rows(0)("ExtName")
            dtpBirthday.Text = dtStudent.Rows(0)("Birthday")
            txtAge.Text = dtStudent.Rows(0)("Age")
            cboSex.Text = dtStudent.Rows(0)("Sex")
            txtReligion.Text = dtStudent.Rows(0)("Religion")
            txtHouseNo.Text = dtStudent.Rows(0)("HouseNo")
            txtSubdBrgy.Text = dtStudent.Rows(0)("BrgyNo")
            txtCity.Text = dtStudent.Rows(0)("City")
            txtProvince.Text = IIf(IsDBNull(dtStudent.Rows(0)("Province")) = True, "", dtStudent.Rows(0)("Province"))
            txtContactNo.Text = dtStudent.Rows(0)("ContactNo")
            txtZipCode.Text = dtStudent.Rows(0)("ZipCode")
            chkIP.Checked = dtStudent.Rows(0)("isIndigenous")
            cboClassification.SelectedValue = dtStudent.Rows(0)("Classification")
            txtPrevSchool.Text = dtStudent.Rows(0)("PreviousSchool")
            cboGradeLevel.Text = dtStudent.Rows(0)("GradeLevel")
            cboTrack.SelectedValue = dtStudent.Rows(0)("TrackID")
            cboStrand.SelectedValue = dtStudent.Rows(0)("StrandCode")
            getSpecialization()
            cboSpecial.SelectedValue = dtStudent.Rows(0)("SpecializationCD")
            chkPSA.Checked = dtStudent.Rows(0)("havePSA")
            chkReportCard.Checked = dtStudent.Rows(0)("haveReportCard")
            chkTOR.Checked = dtStudent.Rows(0)("haveTOR")

            'Family Background
            txtFLName.Text = dtStudent.Rows(0)("FatherLastName")
            txtFFName.Text = dtStudent.Rows(0)("FatherFirstName")
            txtFMName.Text = dtStudent.Rows(0)("FatherMiddleName")
            txtMLName.Text = dtStudent.Rows(0)("MotherLastName")
            txtMFName.Text = dtStudent.Rows(0)("MotherFirstName")
            lblProvince.Text = dtStudent.Rows(0)("MotherMiddleName")
            txtGuardianName.Text = dtStudent.Rows(0)("GuardianName")
            txtRelationship.Text = IIf(IsDBNull(dtStudent.Rows(0)("Relationship")) = True, "", dtStudent.Rows(0)("Relationship"))
            txtHomeAddress.Text = dtStudent.Rows(0)("Address")
            txtFamContactNo.Text = dtStudent.Rows(0)("ContactNo")

            ''Strand 
            'rsStrandName = New ADODB.Recordset
            'strSQL = vbNullString
            'strSQL &= "SELECT STR.CourseName, SPC.Specialization FROM Strand STR" & vbCrLf
            'strSQL &= "INNER JOIN Specialization SPC ON STR.CourseCode = SPC.CourseCode" & vbCrLf
            'strSQL &= "WHERE STR.CourseCode = '" & rsStudent.Fields(20).Value & "'" & vbCrLf
            'strSQL &= "AND SPC.Code = '" & rsStudent.Fields(21).Value & "'" & vbCrLf
            'rsStrandName.Open(strSQL, conDB, 1, 4)

            ''SY
            'Dim rsSY As New ADODB.Recordset
            'strSQL = vbNullString
            'strSQL = "SELECT SchoolYear FROM StudentSection WHERE StudentID = '" & rsStudent.Fields(0).Value & "'"
            'rsSY.Open(strSQL, conDB, 1, 4)

            'If rsSY.EOF = False Then lblSchoolYr.Text = rsSY.Fields(0).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
End Class