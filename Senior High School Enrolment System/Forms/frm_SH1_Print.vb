Imports Microsoft.Reporting.WinForms
Public Class frm_SH1_Print
    Dim strSQL As String
    Private Sub frm_SH1_Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loadStudents()
        Try
            Dim frmReport As New frm_SH1Report
            Dim dtStudents As New DataTable

            strSQL = ""
            strSQL += "SELECT LRN," & vbCrLf
            strSQL += "LastName + ', ' + FirstName + ' ' + ExtName + ' '+ MiddleName AS Name," & vbCrLf
            strSQL += "CASE WHEN Sex = 'Male' THEN 'M' ELSE 'F' END AS Sex," & vbCrLf
            strSQL += "Birthday," & vbCrLf
            strSQL += "Age," & vbCrLf
            strSQL += "Religion," & vbCrLf
            strSQL += "HouseNo," & vbCrLf
            strSQL += "BrgyNo," & vbCrLf
            strSQL += "City," & vbCrLf
            strSQL += "FatherLastName + ', ' + FatherFirstName + ' ' + FatherMiddleName AS FathersName," & vbCrLf
            strSQL += "MotherLastName + ', ' + MotherFirstName + ' ' + MotherMiddleName AS MothersName," & vbCrLf
            strSQL += "GuardianName," & vbCrLf
            strSQL += "F.ContactNo" & vbCrLf
            strSQL += "FROM Students S" & vbCrLf
            strSQL += "INNER JOIN FamilyBackground F ON S.LRN = F.StudentLRN" & vbCrLf
            dtStudents = SELECT_QUERY(strSQL).Tables(0)


            With frm_SH1Report
                .rpvSF1.LocalReport.Refresh()
                .rpvSF1.LocalReport.DataSources.Clear()
                .rpvSF1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("dsStudents", dtStudents))
                .rpvSF1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                .rpvSF1.ZoomMode = ZoomMode.Percent
                .rpvSF1.ZoomPercent = 100
            End With
            frmReport.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        loadStudents()
    End Sub


End Class