Module M_Connect
    Public strQuery As String
    Public conDB As New ADODB.Connection
    Public rsDB As New ADODB.Recordset

    Public Sub SQLConnect()
        Dim strConString As String

        If conDB.State = 0 Then
            'strConString = "Provider=SQLOLEDB;Data Source=PHANTOM\SQLEXPRESS;Persist Security Info=False;Integrated Security=SSPI;Initial Catalog=SHSEnrollmentSystem"
            strConString = "Provider=SQLOLEDB;Data Source=ROLLAMAS\SQL_ROLLAMAS;Persist Security Info=False;Integrated Security=SSPI;Initial Catalog=SHSEnrollmentSystem"
            conDB.CommandTimeout = 0
            conDB.ConnectionString = 0
            'conDB.Open(strConString, "admin", "admin")
            conDB.Open(strConString)
        End If


    End Sub

    Public Function SELECT_QUERY(sqlQuery As String) As DataSet 'public functin na nag-rereturn ng dataset, na may parameter ng query
        Dim dsReturn As New DataSet 'Local Dataset (dapat laging NEW)
        Try
            Dim sqlConn As New SqlClient.SqlConnection(My.Resources.ConString) 'SQL Connection -- para maka-connect tayo sa server
            Dim sqlAdapter As New SqlClient.SqlDataAdapter(sqlQuery, sqlConn) 'sql Data Adapter-- pang hold ng data

            sqlConn.Open() 'open mo lang yung connection
            sqlAdapter.Fill(dsReturn) 'yung laman ng datasetm isasalin natin sa local dataset
            sqlConn.Close() 'close mo na
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return dsReturn 'return mo na yung dataset
    End Function
End Module
