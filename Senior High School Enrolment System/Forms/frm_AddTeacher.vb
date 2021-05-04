Public Class frm_AddTeacher
    Public isUpdate As Boolean
    Dim strSQL As String
    Public strTeacherCode As String


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim rsInsert As New ADODB.Recordset
        Dim rsTeacherCode As New ADODB.Recordset

        If MsgBox("Are you sure you want to register?", vbYesNo, vbQuestion) = vbYes Then

            strSQL = vbNullString
            strSQL &= "SELECT RIGHT('000000'+CAST(COALESCE(MAX(TeacherCode) + 1, '1') AS VARCHAR(6)),6) FROM Teachers"
            rsTeacherCode.Open(strSQL, conDB, 1, 4)

            strSQL = vbNullString
            strSQL &= "INSERT INTO Teachers " & vbCrLf
            strSQL &= "VALUES (" & vbCrLf
            strSQL &= "'" & rsTeacherCode.Fields(0).Value & "'" & vbCrLf
            strSQL &= ",'" & txtLastName.Text & "'" & vbCrLf
            strSQL &= ",'" & txtFirstName.Text & "'" & vbCrLf
            strSQL &= ",'" & txtMiddleNAme.Text & "'" & vbCrLf
            strSQL &= ",'" & IIf(IsDBNull(txtSuffix.Text), "NULL", txtSuffix.Text) & "'" & vbCrLf
            strSQL &= ",'" & getDeptCode(cboDepartment.Text) & "'" & vbCrLf
            strSQL &= ",'" & txtContactNo.Text & "'" & vbCrLf
            strSQL &= ",'" & txtEmail.Text & "'" & vbCrLf
            strSQL &= ", getdate()" & vbCrLf
            strSQL &= ", NULL" & vbCrLf
            strSQL &= ", getdate()" & vbCrLf
            strSQL &= ",'" & frm_Login.txtUserName.Text & "')" & vbCrLf
            rsInsert.Open(strSQL, conDB, 1, 4)

            Call AuditTrail(1, "Registered a Teacher with code" & rsTeacherCode.Fields(0).Value)
            MsgBox("Registered!", vbInformation)
            Me.Close()

        End If

    End Sub

    Public Sub getDepartment()
        Dim rsDepartment As New ADODB.Recordset

        Call SQLConnect()
        strSQL = ""
        strSQL = strSQL & "SELECT DeptCode, DeptName FROM Department"
        rsDepartment.Open(strSQL, conDB, 1, 4)

        For i = 1 To rsDepartment.RecordCount
            cboDepartment.Items.Add(rsDepartment.Fields(1).Value)

            rsDepartment.MoveNext()
        Next
    End Sub

    Private Sub frm_AddTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getDepartment()

        If isUpdate = True Then
            btnAdd.Visible = False
            btnUpdate.Visible = True
        Else
            btnAdd.Visible = True
            btnUpdate.Visible = False
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frm_TeacherRecords.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim rsUpdate As New ADODB.Recordset
        If MsgBox("Are you sure you want to save changes?", vbYesNo, vbQuestion) = vbYes Then

            Call SQLConnect()
            strSQL = vbNullString
            strSQL &= "UPDATE Teachers" & vbCrLf
            strSQL &= "SET LastName ='" & txtLastName.Text & "'" & vbCrLf
            strSQL &= ", FirstName ='" & txtFirstName.Text & "'" & vbCrLf
            strSQL &= ", MiddleName ='" & txtMiddleNAme.Text & "'" & vbCrLf
            strSQL &= ", ExtName ='" & txtSuffix.Text & "'" & vbCrLf
            strSQL &= ", DeptCode = '" & getDeptCode(cboDepartment.Text) & "'" & vbCrLf
            strSQL &= ", ContactNo = '" & txtContactNo.Text & "'" & vbCrLf
            strSQL &= ", EmailAddress = '" & txtEmail.Text & "'" & vbCrLf
            strSQL &= ", UpdatedDate = getDate()" & vbCrLf
            strSQL &= ", UpdatedBy = '" & frm_Login.txtUserName.Text & "'" & vbCrLf
            strSQL &= "WHERE TeacherCode =  '" & strTeacherCode & "'" & vbCrLf
            rsUpdate.Open(strSQL, conDB, 1, 4)

            Call AuditTrail(2, "Updated Teacher information with code: " & strTeacherCode)
            MsgBox("Changes Saved!")

            Call frm_TeacherRecords.getTeacher()
            Me.Close()
            frm_TeacherRecords.Show()



        End If
    End Sub
End Class