Module M_Functions
    Public UserName As String
    Public UserLevelID As Integer
    Public UserLevel As String

    Public Sub getUserLevel(intUserLevelID As Integer)
        Call SQLConnect()

        rsDB = New ADODB.Recordset
        strQuery = vbNullString
        strQuery = "SELECT * FROM UserLevel" & vbCrLf
        strQuery &= "WHERE ID = " & intUserLevelID
        rsDB.Open(strQuery, conDB, 1, 4)

        UserLevelID = rsDB.Fields(0).Value
        UserLevel = rsDB.Fields(1).Value
    End Sub

    Public Function getStrandCode(strStrandName As String) As String
        Dim strSQL As String
        Dim rsStrandCD As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL = strSQL & "SELECT * FROM Strand" & vbCrLf
        strSQL = strSQL & "WHERE CourseName LIKE '%" & strStrandName & "%'" & vbCrLf
        rsStrandCD.Open(strSQL, conDB, 1, 4)

        Return rsStrandCD.Fields(0).Value
    End Function

    Public Function getSubjectTypeCode(strTypeDesc As String) As String
        Dim strSQL As String
        Dim rsTypeCode As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT TypeCode FROM SubjectType" & vbCrLf
        strSQL &= "WHERE Description LIKE '%" & strTypeDesc & "%'" & vbCrLf
        rsTypeCode.Open(strSQL, conDB, 1, 4)


        Return rsTypeCode.Fields(0).Value
    End Function

    Public Function getDeptCode(strDeptName As String) As String
        Dim strSQL As String
        Dim rsDeptCode As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL = strSQL & "SELECT * FROM Department " & vbCrLf
        strSQL = strSQL & "WHERE DeptName LIKE '%" & strDeptName & "%'" & vbCrLf
        rsDeptCode.Open(strSQL, conDB, 1, 4)

        Return rsDeptCode.Fields(0).Value
    End Function

    Public Function getDepartment(strDeptCode As String) As String
        Dim strSQL As String
        Dim rsDeptName As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL = strSQL & "SELECT * FROM Department " & vbCrLf
        strSQL = strSQL & "WHERE DeptCode LIKE '%" & strDeptCode & "%'" & vbCrLf
        rsDeptName.Open(strSQL, conDB, 1, 4)

        Return rsDeptName.Fields(1).Value
    End Function

    Public Function getSubjectCode(strSubDesp As String) As String
        Dim strSQL As String
        Dim rsSubjCode As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT SubjectCode FROM Subject " & vbCrLf
        strSQL = strSQL & "WHERE Description LIKE '%" & strSubDesp & "%'" & vbCrLf
        rsSubjCode.Open(strSQL, conDB, 1, 4)

        Return rsSubjCode.Fields(0).Value
    End Function
    Public Function getSubjectName(strSubCode As String) As String
        Dim strSQL As String
        Dim rsSubjName As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT Description FROM Subject " & vbCrLf
        strSQL = strSQL & "WHERE SubjectCode LIKE '%" & strSubCode & "%'" & vbCrLf
        rsSubjName.Open(strSQL, conDB, 1, 4)

        Return rsSubjName.Fields(0).Value
    End Function


    Public Function getTeacherCode(strTeacherName As String) As String
        Dim strSQL As String
        Dim rsTeacherCode As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT TeacherCode FROM Teachers " & vbCrLf
        strSQL = strSQL & "WHERE LastName + ', ' + FirstName + ' ' +  MiddleName  LIKE '%" & RTrim(strTeacherName) & "%'" & vbCrLf
        rsTeacherCode.Open(strSQL, conDB, 1, 4)

        Return rsTeacherCode.Fields(0).Value

    End Function

    Public Function getTeacherName(strTeacherCode As String) As String
        Dim strSQL As String
        Dim rsTeacherName As New ADODB.Recordset


        strSQL = vbNullString
        strSQL &= "SELECT LastName + ', ' + FirstName + ' ' +  MiddleName FROM Teachers  " & vbCrLf
        strSQL = strSQL & "WHERE TeacherCode  LIKE '%" & strTeacherCode & "%'" & vbCrLf
        rsTeacherName.Open(strSQL, conDB, 1, 4)

        Return rsTeacherName.Fields(0).Value

    End Function

    Public Function getStrandName(strStrandCode As String) As String
        Dim strSQL As String
        Dim rsStrand As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL = strSQL & "SELECT * FROM Strand" & vbCrLf
        strSQL = strSQL & "WHERE CourseCode LIKE '%" & strStrandCode & "%'" & vbCrLf
        rsStrand.Open(strSQL, conDB, 1, 4)

        Return rsStrand.Fields(1).Value
    End Function

    Public Function getSectionCode(strSectionName As String) As String
        Dim strSQL As String
        Dim rsSecCode As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL = strSQL & "SELECT * FROM Sections" & vbCrLf
        strSQL = strSQL & "WHERE SectionName LIKE '%" & strSectionName & "%'" & vbCrLf
        rsSecCode.Open(strSQL, conDB, 1, 4)

        Return rsSecCode.Fields(0).Value
    End Function
    Public Function getSectionName(strSectionCode As String) As String
        Dim strSQL As String
        Dim rsSecName As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL = strSQL & "SELECT * FROM Sections" & vbCrLf
        strSQL = strSQL & "WHERE SectionCode LIKE '%" & strSectionCode & "%'" & vbCrLf
        rsSecName.Open(strSQL, conDB, 1, 4)

        Return rsSecName.Fields(3).Value
    End Function

    Public Function getStudentClass(strTypeCode As String) As String
        Dim strSQL As String
        Dim rsClass As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL = strSQL & "SELECT TypeID FROM StudentType" & vbCrLf
        strSQL = strSQL & "WHERE Description LIKE '%" & strTypeCode & "%'" & vbCrLf
        rsClass.Open(strSQL, conDB, 1, 4)

        Return rsClass.Fields(0).Value
    End Function
    Public Function getStudentClassType(strType As String) As String
        Dim strSQL As String
        Dim rsClassType As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL = strSQL & "SELECT Description FROM StudentType" & vbCrLf
        strSQL = strSQL & "WHERE TypeID LIKE '%" & strType & "%'" & vbCrLf
        rsClassType.Open(strSQL, conDB, 1, 4)

        Return rsClassType.Fields(0).Value
    End Function
    Public Function getTrackCode(strTrackName As String) As String
        Dim strSQL As String
        Dim rsTrackCode As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT TrackID FROM Tracks  " & vbCrLf
        strSQL = strSQL & "WHERE Track LIKE '%" & RTrim(strTrackName) & "%'" & vbCrLf
        rsTrackCode.Open(strSQL, conDB, 1, 4)

        Return rsTrackCode.Fields(0).Value

    End Function
    Public Function getTrackName(strTrackCode As String) As String
        Dim strSQL As String
        Dim rsTrackName As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT Track FROM Tracks  " & vbCrLf
        strSQL = strSQL & "WHERE TrackID LIKE '%" & RTrim(strTrackCode) & "%'" & vbCrLf
        rsTrackName.Open(strSQL, conDB, 1, 4)

        Return rsTrackName.Fields(0).Value

    End Function
    Public Function getSpecialCode(strSpecialName As String, strCourseCode As String) As String
        Dim strSQL As String
        Dim rsSpecialCode As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT Code FROM Specialization" & vbCrLf
        strSQL = strSQL & "WHERE Specialization LIKE '%" & RTrim(strSpecialName) & "%'" & vbCrLf
        strSQL = strSQL & "AND CourseCode = '" & RTrim(strCourseCode) & "'" & vbCrLf
        rsSpecialCode.Open(strSQL, conDB, 1, 4)

        Return rsSpecialCode.Fields(0).Value

    End Function
    Public Function getSpecialName(strSpecialCode As String, strCourseCode As String) As String
        Dim strSQL As String
        Dim rsSpecialNAme As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT Specialization FROM Specialization" & vbCrLf
        strSQL = strSQL & "WHERE Code LIKE '%" & RTrim(strSpecialCode) & "%'" & vbCrLf
        strSQL = strSQL & "AND CourseCode = '" & RTrim(strCourseCode) & "'" & vbCrLf
        rsSpecialNAme.Open(strSQL, conDB, 1, 4)

        Return rsSpecialNAme.Fields(0).Value

    End Function
    Public Sub AuditTrail(intAction As Integer, strRemarks As String)
        '//1=Add
        '//2=Update
        '//3=Delete
        '//4=Login
        '//5=Logout

        Dim strSQL As String
        Dim rsInsert As New ADODB.Recordset


        strSQL = vbNullString
        If intAction = 1 Then
            strSQL &= "INSERT INTO AudtTrail " & vbCrLf
            strSQL &= "VALUES ( " & vbCrLf
            strSQL &= "'" & frm_Login.txtUserName.Text & "'" & vbCrLf
            strSQL &= ",'ADD'" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",'" & Format(Now, "HH:MM") & "'" & vbCrLf
            strSQL &= ",'" & strRemarks & "'" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",Null" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",'" & frm_Login.txtUserName.Text & "')" & vbCrLf
        ElseIf intAction = 2 Then
            strSQL &= "INSERT INTO AudtTrail " & vbCrLf
            strSQL &= "VALUES ( " & vbCrLf
            strSQL &= "'" & frm_Login.txtUserName.Text & "'" & vbCrLf
            strSQL &= ",'UPDATE'" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",'" & Format(Now, "HH:MM") & "'" & vbCrLf
            strSQL &= ",'" & strRemarks & "'" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",Null" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",'" & frm_Login.txtUserName.Text & "')" & vbCrLf
        ElseIf intAction = 3 Then
            strSQL &= "INSERT INTO AudtTrail " & vbCrLf
            strSQL &= "VALUES ( " & vbCrLf
            strSQL &= "'" & frm_Login.txtUserName.Text & "'" & vbCrLf
            strSQL &= ",'DELETE'" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",'" & Format(Now, "HH:MM") & "'" & vbCrLf
            strSQL &= ",'" & strRemarks & "'" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",Null" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",'" & frm_Login.txtUserName.Text & "')" & vbCrLf
        ElseIf intAction = 4 Then
            strSQL &= "INSERT INTO AudtTrail " & vbCrLf
            strSQL &= "VALUES ( " & vbCrLf
            strSQL &= "'" & frm_Login.txtUserName.Text & "'" & vbCrLf
            strSQL &= ",'LOGIN'" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",'" & Format(Now, "HH:MM") & "'" & vbCrLf
            strSQL &= ",'" & strRemarks & "'" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",Null" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",'" & frm_Login.txtUserName.Text & "')" & vbCrLf
        Else
            strSQL &= "INSERT INTO AudtTrail " & vbCrLf
            strSQL &= "VALUES ( " & vbCrLf
            strSQL &= "'" & frm_Login.txtUserName.Text & "'" & vbCrLf
            strSQL &= ",'LOGOUT'" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",'" & Format(Now, "HH:MM") & "'" & vbCrLf
            strSQL &= ",'" & strRemarks & "'" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",Null" & vbCrLf
            strSQL &= ",getDate()" & vbCrLf
            strSQL &= ",'" & frm_Login.txtUserName.Text & "')" & vbCrLf
        End If
        rsInsert.Open(strSQL, conDB, 1, 4)

    End Sub

End Module
