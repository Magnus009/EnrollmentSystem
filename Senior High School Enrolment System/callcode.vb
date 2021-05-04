Imports MySql.Data.MySqlClient


Module callcode
    Public cn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader

    Sub conn()
        cn = New MySqlConnection("Server=LocalHost;UserID=root;password=;database=enrollment_system")
        cn.Open()

    End Sub
    Public LN As String
    Public userlevel As String
    Public detail, activity As String
    Public oras As String
    Sub audit()

        conn()
        Dim data_tbl As New DataTable
        Dim data_adptr As New MySqlDataAdapter("insert into tbl_audit_trail (user_level,username,date,time_in,Details,Activities) values ('" & userlevel & "','" & LN & "','" & Format(Today, "yyyy-MM-dd") & "','" & Format(Now, "hh:m:s") & "','" & detail & "','" & activity & "')", cn)
        data_adptr.Fill(data_tbl)
        cn.Close()

     
    End Sub

End Module
