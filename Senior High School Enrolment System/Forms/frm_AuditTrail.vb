Imports MySql.Data.MySqlClient

Public Class frm_AuditTrail
    Dim strSQL As String

    Private Sub frm_AuditTrail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setHeader()
        Call getLogs()
    End Sub

    Public Sub setHeader()
        Dim btnView As New DataGridViewButtonColumn()

        With grdLogs
            .Columns.Add("colSeq", "SEQ") : .Columns(0).Width = .Width * 0.05
            .Columns.Add("colUserID", "USER") : .Columns(1).Width = .Width * 0.6
            .Columns.Add("colAction", "ACTION") : .Columns(2).Width = .Width * 0.4
            .Columns.Add("colDate", "DATE") : .Columns(3).Width = .Width * 0.3
            .Columns.Add("colTime", "TIME") : .Columns(4).Width = .Width * 0.2
            .Columns.Add("colRemarks", "REMARKS") : .Columns(5).Width = .Width * 0.6
        End With
    End Sub
    Public Sub getLogs()
        Dim rsLogs As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT * FROM AudtTrail" & vbCrLf
        rsLogs.Open(strSQL, conDB, 1, 4)

        grdLogs.RowCount = 0
        Do While rsLogs.EOF = False
            With grdLogs
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = rsLogs.Fields(0).Value
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsLogs.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = UCase(rsLogs.Fields(2).Value)
                .Rows(.RowCount - 1).Cells(3).Value = UCase(rsLogs.Fields(3).Value)
                .Rows(.RowCount - 1).Cells(4).Value = UCase(TimeValue(rsLogs.Fields(4).Value).ToShortTimeString)
                .Rows(.RowCount - 1).Cells(5).Value = UCase(rsLogs.Fields(5).Value)


                rsLogs.MoveNext()
            End With
        Loop

    End Sub

    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus
        txtSearch.Text = vbNullString
        txtSearch.ForeColor = Color.Black
    End Sub



    'Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
    '    Dim rsSearch As New ADODB.Recordset

    '    Call SQLConnect()
    '    If txtSearch.Text <> "Enter User Name.." Then
    '        strSQL = vbNullString
    '        strSQL &= "SELECT * FROM AudtTrail AT" & vbCrLf
    '        strSQL &= "INNER JOIN ACCOUNTS A ON AT.UserID = A.ID " & vbCrLf
    '        strSQL &= "WHERE A.UserName LIKE '%" & txtSearch.Text & "%'" & vbCrLf
    '        strSQL &= "AND AT.Action LIKE '%" & cboAction.Text & "%'" & vbCrLf
    '        strSQL &= "AND AT.DateOfAction BETWEEN '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' AND '" & Format(dtpTo.Value, "MM/dd/yyyy") & "'" & vbCrLf
    '        rsSearch.Open(strSQL, conDB, 1, 4)

    '        If rsSearch.EOF = True Then
    '            MsgBox("No Record Found!", vbExclamation)
    '        Else
    '            grdLogs.RowCount = 0
    '            Do While rsSearch.EOF = False
    '                With grdLogs
    '                    .Rows.Add()
    '                    .Rows(.RowCount - 1).Cells(0).Value = rsSearch.Fields(0).Value
    '                    .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSearch.Fields(1).Value)
    '                    .Rows(.RowCount - 1).Cells(2).Value = UCase(rsSearch.Fields(2).Value)
    '                    .Rows(.RowCount - 1).Cells(3).Value = UCase(rsSearch.Fields(3).Value)
    '                    .Rows(.RowCount - 1).Cells(4).Value = UCase(TimeValue(rsSearch.Fields(4).Value).ToShortTimeString)
    '                    .Rows(.RowCount - 1).Cells(5).Value = UCase(rsSearch.Fields(5).Value)


    '                    rsSearch.MoveNext()
    '                End With
    '            Loop
    '        End If
    '    End If
    'End Sub

    'Private Sub cboAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAction.SelectedIndexChanged
    '    Dim rsSearch As New ADODB.Recordset

    '    Call SQLConnect()
    '    If txtSearch.Text <> "Enter User Name.." Then
    '        strSQL = vbNullString
    '        strSQL &= "SELECT * FROM AudtTrail AT" & vbCrLf
    '        strSQL &= "INNER JOIN ACCOUNTS A ON AT.UserID = A.ID " & vbCrLf
    '        strSQL &= "WHERE A.UserName LIKE '%" & txtSearch.Text & "%'" & vbCrLf
    '        strSQL &= "AND AT.Action LIKE '%" & cboAction.Text & "%'" & vbCrLf
    '        strSQL &= "AND AT.DateOfAction BETWEEN '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' AND '" & Format(dtpTo.Value, "MM/dd/yyyy") & "'" & vbCrLf
    '        rsSearch.Open(strSQL, conDB, 1, 4)

    '        If rsSearch.EOF = True Then
    '            MsgBox("No Record Found!", vbExclamation)
    '        Else
    '            grdLogs.RowCount = 0
    '            Do While rsSearch.EOF = False
    '                With grdLogs
    '                    .Rows.Add()
    '                    .Rows(.RowCount - 1).Cells(0).Value = rsSearch.Fields(0).Value
    '                    .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSearch.Fields(1).Value)
    '                    .Rows(.RowCount - 1).Cells(2).Value = UCase(rsSearch.Fields(2).Value)
    '                    .Rows(.RowCount - 1).Cells(3).Value = UCase(rsSearch.Fields(3).Value)
    '                    .Rows(.RowCount - 1).Cells(4).Value = UCase(TimeValue(rsSearch.Fields(4).Value).ToShortTimeString)
    '                    .Rows(.RowCount - 1).Cells(5).Value = UCase(rsSearch.Fields(5).Value)


    '                    rsSearch.MoveNext()
    '                End With
    '            Loop
    '        End If
    '    End If
    'End Sub

    'Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
    '    Dim rsSearch As New ADODB.Recordset

    '    Call SQLConnect()
    '    If txtSearch.Text <> "Enter User Name.." Then
    '        strSQL = vbNullString
    '        strSQL &= "SELECT * FROM AudtTrail AT" & vbCrLf
    '        strSQL &= "INNER JOIN ACCOUNTS A ON AT.UserID = A.ID " & vbCrLf
    '        strSQL &= "WHERE A.UserName LIKE '%" & txtSearch.Text & "%'" & vbCrLf
    '        strSQL &= "AND AT.Action LIKE '%" & cboAction.Text & "%'" & vbCrLf
    '        strSQL &= "AND AT.DateOfAction BETWEEN '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' AND '" & Format(dtpTo.Value, "MM/dd/yyyy") & "'" & vbCrLf
    '        rsSearch.Open(strSQL, conDB, 1, 4)

    '        If rsSearch.EOF = True Then
    '            MsgBox("No Record Found!", vbExclamation)
    '        Else
    '            grdLogs.RowCount = 0
    '            Do While rsSearch.EOF = False
    '                With grdLogs
    '                    .Rows.Add()
    '                    .Rows(.RowCount - 1).Cells(0).Value = rsSearch.Fields(0).Value
    '                    .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSearch.Fields(1).Value)
    '                    .Rows(.RowCount - 1).Cells(2).Value = UCase(rsSearch.Fields(2).Value)
    '                    .Rows(.RowCount - 1).Cells(3).Value = UCase(rsSearch.Fields(3).Value)
    '                    .Rows(.RowCount - 1).Cells(4).Value = UCase(TimeValue(rsSearch.Fields(4).Value).ToShortTimeString)
    '                    .Rows(.RowCount - 1).Cells(5).Value = UCase(rsSearch.Fields(5).Value)


    '                    rsSearch.MoveNext()
    '                End With
    '            Loop
    '        End If
    '    End If
    'End Sub

    'Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
    '    Dim rsSearch As New ADODB.Recordset

    '    Call SQLConnect()
    '    If txtSearch.Text <> "Enter User Name.." Then
    '        strSQL = vbNullString
    '        strSQL &= "SELECT * FROM AudtTrail AT" & vbCrLf
    '        strSQL &= "INNER JOIN ACCOUNTS A ON AT.UserID = A.ID " & vbCrLf
    '        strSQL &= "WHERE A.UserName LIKE '%" & txtSearch.Text & "%'" & vbCrLf
    '        strSQL &= "AND AT.Action LIKE '%" & cboAction.Text & "%'" & vbCrLf
    '        strSQL &= "AND AT.DateOfAction BETWEEN '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' AND '" & Format(dtpTo.Value, "MM/dd/yyyy") & "'" & vbCrLf
    '        rsSearch.Open(strSQL, conDB, 1, 4)

    '        If rsSearch.EOF = True Then
    '            MsgBox("No Record Found!", vbExclamation)
    '        Else
    '            grdLogs.RowCount = 0
    '            Do While rsSearch.EOF = False
    '                With grdLogs
    '                    .Rows.Add()
    '                    .Rows(.RowCount - 1).Cells(0).Value = rsSearch.Fields(0).Value
    '                    .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSearch.Fields(1).Value)
    '                    .Rows(.RowCount - 1).Cells(2).Value = UCase(rsSearch.Fields(2).Value)
    '                    .Rows(.RowCount - 1).Cells(3).Value = UCase(rsSearch.Fields(3).Value)
    '                    .Rows(.RowCount - 1).Cells(4).Value = UCase(TimeValue(rsSearch.Fields(4).Value).ToShortTimeString)
    '                    .Rows(.RowCount - 1).Cells(5).Value = UCase(rsSearch.Fields(5).Value)


    '                    rsSearch.MoveNext()
    '                End With
    '            Loop
    '        End If
    '    End If
    'End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim rsSearch As New ADODB.Recordset

        Call SQLConnect()

        strSQL = vbNullString
        strSQL &= "SELECT * FROM AudtTrail AT" & vbCrLf
        strSQL &= "INNER JOIN ACCOUNTS A ON AT.UserID = A.ID " & vbCrLf
        strSQL &= "WHERE A.UserName LIKE '%" & IIf(txtSearch.Text = "Enter User Name..", "", txtSearch.Text) & "%'" & vbCrLf
        strSQL &= "AND AT.Action LIKE '%" & cboAction.Text & "%' AND"
        'strSQL &= "AND AT.DateOfAction BETWEEN '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' AND '" & Format(dtpTo.Value, "MM/dd/yyyy") & "'" & vbCrLf

        If dtpFrom.Checked = True Then
            strSQL &= " AT.DateOfAction >= '" & Format(dtpFrom.Value, "MM/dd/yyyy") & "' AND"
        End If

        If dtpTo.Checked = True Then
            strSQL &= " AT.DateOfAction <= '" & Format(dtpFrom.Value, "MM/dd/yyyy") & " 23:59:00' AND"
        End If
        strSQL = Strings.Left(Trim(strSQL), Len(Trim(strSQL)) - 3)
        rsSearch.Open(strSQL, conDB, 1, 4)


        If rsSearch.EOF = True Then
            MsgBox("No Record Found!", vbExclamation)
        Else
            grdLogs.RowCount = 0
            Do While rsSearch.EOF = False
                With grdLogs
                    .Rows.Add()
                    .Rows(.RowCount - 1).Cells(0).Value = rsSearch.Fields(0).Value
                    .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSearch.Fields(1).Value)
                    .Rows(.RowCount - 1).Cells(2).Value = UCase(rsSearch.Fields(2).Value)
                    .Rows(.RowCount - 1).Cells(3).Value = UCase(rsSearch.Fields(3).Value)
                    .Rows(.RowCount - 1).Cells(4).Value = UCase(TimeValue(rsSearch.Fields(4).Value).ToShortTimeString)
                    .Rows(.RowCount - 1).Cells(5).Value = UCase(rsSearch.Fields(5).Value)


                    rsSearch.MoveNext()
                End With
            Loop
        End If

    End Sub

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        If txtSearch.Text = "" Then
            txtSearch.Text = "Enter User Name.."
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub
End Class