Public Class frm_ViewSubjectRecords
    Dim strSQL As String
    Dim strCode As String

    Private Sub frm_ViewSubjectRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setHeader()
        Call getSubjects()

    End Sub


    Public Sub setHeader()
        Dim btnView As New DataGridViewButtonColumn()

        With grdResult
            .Columns.Add("colCode", "CODE") : .Columns(0).Width = .Width * 0.18
            .Columns.Add("colDescrptn", "DESCRIPTION") : .Columns(1).Width = .Width * 0.62
            .Columns.Add("colUnits", "UNITS") : .Columns(2).Width = .Width * 0.1
            .Columns.Add(btnView) : .Columns(3).Width = .Width * 0.07
        End With
    End Sub

    Public Sub getSubjects()
        Dim rsSubjects As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT * FROM Subject"
        rsSubjects.Open(strSQL, conDB, 1, 4)

        grdResult.RowCount = 0
        Do While rsSubjects.EOF = False
            With grdResult
                .Rows.Add()
                .Rows(.RowCount - 1).Cells(0).Value = rsSubjects.Fields(0).Value
                .Rows(.RowCount - 1).Cells(1).Value = UCase(rsSubjects.Fields(1).Value)
                .Rows(.RowCount - 1).Cells(2).Value = UCase(rsSubjects.Fields(2).Value)
                .Rows(.RowCount - 1).Cells(3).Value = "VIEW"

                rsSubjects.MoveNext()
            End With
        Loop



    End Sub

    Private Sub grdResult_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdResult.CellContentClick
        Dim rsPre As New ADODB.Recordset
        Dim rsType As New ADODB.Recordset
        Dim intCounter As Integer


        If e.ColumnIndex() = 3 Then

            strCode = grdResult.Rows(e.RowIndex).Cells(0).Value()

            frm_AddSubjects.isUpdate = True
            frm_AddSubjects.strCode = grdResult.Rows(e.RowIndex).Cells(0).Value()

            strSQL = vbNullString
            strSQL &= "SELECT SubjectType FROM Subject S" & vbCrLf
            strSQL &= "INNER JOIN SubjectType ST ON S.SubjectType = ST.TypeCode " & vbCrLf
            strSQL &= "WHERE  SubjectCode = '" & grdResult.Rows(e.RowIndex).Cells(0).Value() & "'"
            rsType.Open(strSQL, conDB, 1, 4)

            strSQL = vbNullString
            strSQL &= "SELECT Description FROM Subject S" & vbCrLf
            strSQL &= "INNER JOIN SubjectRelation SR ON S.SubjectCode = SR.PreRequisiteCode" & vbCrLf
            strSQL &= "WHERE  SR.SubjectCode = '" & grdResult.Rows(e.RowIndex).Cells(0).Value() & "'"
            rsPre.Open(strSQL, conDB, 1, 4)

            frm_AddSubjects.txtSubCode.Text = grdResult.Rows(e.RowIndex).Cells(0).Value()
            frm_AddSubjects.txtSubDescription.Text = grdResult.Rows(e.RowIndex).Cells(1).Value
            frm_AddSubjects.txtUnit.Text = grdResult.Rows(e.RowIndex).Cells(2).Value
            frm_AddSubjects.cboType.Text = rsType.Fields(0).Value

            intCounter = 0
            frm_AddSubjects.chklstPrerequisite.Items.Clear()
            Do While rsPre.EOF = False

                With frm_AddSubjects.chklstPrerequisite
                    .Items.Add(rsPre.Fields(0).Value, False)
                    .SetItemChecked(intCounter, True)
                End With

                intCounter = intCounter + 1
                rsPre.MoveNext()
            Loop


            frm_AddSubjects.ShowDialog()

        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim rsSearch As New ADODB.Recordset

        Call SQLConnect()
        strSQL = vbNullString
        strSQL &= "SELECT * FROM Subject S" & vbCrLf
        strSQL &= "INNER JOIN SubjectType ST ON S.SubjectType = ST.TypeCode " & vbCrLf
        strSQL &= "WHERE S.SubjectCode LIKE '%" & txtSearch.Text & "%' OR  " & vbCrLf
        strSQL &= "S.Description LIKE '%" & txtSearch.Text & "%' OR  " & vbCrLf
        strSQL &= "S.Units LIKE '%" & txtSearch.Text & "%' OR  " & vbCrLf
        strSQL &= "ST.Description LIKE '%" & txtSearch.Text & "%' " & vbCrLf
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
End Class