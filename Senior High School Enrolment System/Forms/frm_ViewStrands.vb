Public Class frm_ViewStrands
    Dim strSQL As String
    Private Sub frm_ViewStrands_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setHeader()
        Call getStrands()
    End Sub

    Private Sub setHeader()
        Dim btnView As New DataGridViewButtonColumn()

        With grdStrands
            .Columns.Add("colCode", "CODE") : .Columns(0).Width = .Width * 0.2
            .Columns.Add("colDescrptn", "STRAND") : .Columns(1).Width = .Width * 0.72
            .Columns.Add(btnView) : .Columns(2).Width = .Width * 0.07
        End With
    End Sub

    Private Sub getStrands()
        Dim rsStrands As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT * FROM Strand "
        rsStrands.Open(strSQL, conDB, 1, 4)

        'grdStrands.RowCount = 0
        Do While rsStrands.EOF = False
            With grdStrands
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Rows(.RowCount - 1).Cells(0).Value = UCase(rsStrands.Fields(0).Value)
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsStrands.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = "..."

                rsStrands.MoveNext()
            End With
        Loop
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim rsSearch As New ADODB.Recordset

        strSQL = vbNullString
        strSQL &= "SELECT * FROM Strand " & vbCrLf
        strSQL &= "WHERE CourseCode LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        strSQL &= "OR CourseName LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        rsSearch.Open(strSQL, conDB, 1, 4)

        grdStrands.RowCount = 0
        Do While rsSearch.EOF = False
            With grdStrands
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Rows(.RowCount - 1).Cells(0).Value = UCase(rsSearch.Fields(0).Value)
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSearch.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = "..."

                rsSearch.MoveNext()
            End With
        Loop
    End Sub

    Private Sub grdStrands_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdStrands.CellContentClick
        Dim rsDes As New ADODB.Recordset
        Dim strDescription As String

        If e.ColumnIndex = 2 Then


            strSQL = vbNullString
            strSQL &= "SELECT * FROM Strand " & vbNullString
            strSQL &= "WHERE CourseCode = '" & grdStrands.Rows(e.RowIndex).Cells(0).Value() & "'" & vbCrLf
            rsDes.Open(strSQL, conDB, 1, 4)

            strDescription = IIf(IsDBNull(rsDes.Fields(2).Value) = True, "", rsDes.Fields(2).Value)
            frm_AddStrand.strCode = grdStrands.Rows(e.RowIndex).Cells(0).Value()
            frm_AddStrand.txtStrandCode.Text = grdStrands.Rows(e.RowIndex).Cells(0).Value()
            frm_AddStrand.txtStrandName.Text = grdStrands.Rows(e.RowIndex).Cells(1).Value()
            frm_AddStrand.txtDescription.Text = strDescription

            frm_AddStrand.btnAdd.Visible = False
            frm_AddStrand.btnUpdate.Visible = True
            frm_AddStrand.ShowDialog()
        End If
    End Sub
End Class