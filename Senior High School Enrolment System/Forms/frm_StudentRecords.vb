Public Class frm_StudentRecords
    Dim strSQL As String
    Dim strLRN As String
    
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim rsSearch As New ADODB.Recordset

        strSQL = vbNullString
        strSQL = strSQL & "SELECT LRN, " & vbCrLf
        strSQL = strSQL & "LastName + ', ' + FirstName + ' ' + MiddleName AS Name, " & vbCrLf
        strSQL = strSQL & "'Grade ' + CAST(GradeLevel AS VARCHAR(2)) + ' ' + StrandCode  AS StrandName FROM Students  " & vbCrLf
        strSQL = strSQL & "WHERE LRN LIKE '%" & txtSearch.Text & "%' OR FirstName LIKE '%" & txtSearch.Text & "%' OR MiddleName LIKE '%" & txtSearch.Text & "%'  " & vbCrLf
        strSQL = strSQL & "OR LastName LIKE '%" & txtSearch.Text & "%' OR CAST(GradeLevel AS VARCHAR(2))LIKE '%" & txtSearch.Text & "%' OR StrandCode  LIKE '%" & txtSearch.Text & "%'" & vbCrLf
        rsSearch.Open(strSQL, conDB, 1, 4)


        grdResult.RowCount = 0
        Do While rsSearch.EOF = False
            With grdResult
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = rsSearch.Fields(0).Value
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSearch.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = UCase(rsSearch.Fields(2).Value)
                .Rows(.RowCount - 1).Cells(3).Value = "VIEW"

                rsSearch.MoveNext()
            End With
        Loop
    End Sub

    Private Sub frm_StudentRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
 
        Call setHeader()
        Call getStudent()
    End Sub


    Public Sub setHeader()
        Dim btnView As New DataGridViewButtonColumn()

        btnView.FlatStyle = FlatStyle.Flat
        btnView.DefaultCellStyle.BackColor = Color.Green
        btnView.DefaultCellStyle.ForeColor = Color.White
        btnView.DefaultCellStyle.SelectionBackColor = Color.Green
        btnView.DefaultCellStyle.SelectionForeColor = Color.White
        With grdResult
            .Columns.Add("colLRN", "LRN") : .Columns(0).Width = .Width * 0.25
            .Columns.Add("colName", "NAME") : .Columns(1).Width = .Width * 0.475
            .Columns.Add("colStrand", "GRADE/STRAND") : .Columns(2).Width = .Width * 0.2
            .Columns.Add(btnView) : .Columns(3).Width = .Width * 0.07
        End With
    End Sub

    Public Sub getStudent()
        Dim rsStudents As New ADODB.Recordset

        Call SQLConnect() '//CALL CONNECTION 

        '//START OF QUERY 
        strSQL = vbNullString
        strSQL = strSQL & "SELECT TOP 100" & vbCrLf
        strSQL = strSQL & "LRN, " & vbCrLf
        strSQL = strSQL & "LastName + ', ' + FirstName + ' ' + MiddleName AS Name, " & vbCrLf
        strSQL = strSQL & "'Grade ' + CAST(GradeLevel AS VARCHAR(2)) + ' ' + StrandCode AS StrandName FROM Students " & vbCrLf
    
        rsStudents.Open(strSQL, conDB, 1, 4)


        grdResult.RowCount = 0
        Do While rsStudents.EOF = False
            With grdResult
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = rsStudents.Fields(0).Value
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsStudents.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = UCase(rsStudents.Fields(2).Value)
                .Rows(.RowCount - 1).Cells(3).Value = "VIEW"

                rsStudents.MoveNext()
            End With
        Loop
    End Sub

    Private Sub grdResult_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdResult.CellContentClick
        If e.ColumnIndex() = 3 Then
            strLRN = grdResult.Rows(e.RowIndex).Cells(0).Value()
            frm_AddStudent.viewStudentRecord(strLRN)
        End If
    End Sub
End Class