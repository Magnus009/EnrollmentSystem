Public Class frm_dashboard
    Dim rsChart As New ADODB.Recordset
    Dim intRecords, intStrandRecs As Integer
    Dim strSQl As String
    Dim isShow As Boolean
    Dim intPos As Integer

    Private Sub setChartData()
        rsChart = New ADODB.Recordset
        Call SQLConnect()
        strSQl = vbNullString
        strSQl &= "SELECT upper(Str.CourseCode), " & vbCrLf
        strSQl &= "count(CASE WHEN Stu.Classification = 1 THEN 1 END) AS 'REGULAR'," & vbCrLf
        strSQl &= "count(CASE WHEN Stu.Classification = 2 THEN 1 END) AS 'IRREGULAR'," & vbCrLf
        strSQl &= "count(CASE WHEN Stu.Classification = 3 THEN 1 END) AS 'DROPPED' FROM Strand Str" & vbCrLf
        strSQl &= "LEFT JOIN Students Stu ON Str.CourseCode = Stu.StrandCode" & vbCrLf
        strSQl &= "GROUP BY Str.CourseCode"
        rsChart.Open(strSQl, conDB, 1, 1)

        With chrtDashBoard
            rsChart.MoveFirst()
            Dim x As Integer
            For i As Integer = 1 To intRecords
                If rsChart.EOF = False Then
                    If i >= (intStrandRecs - 4) And i <= intStrandRecs Then
                        .Series(0).Points.AddXY(rsChart.Fields(0).Value, rsChart.Fields(1).Value) 'Regulars
                        .Series(0).Points(x).Label = rsChart.Fields(1).Value.ToString.Replace("0", "")
                        .Series(1).Points.AddXY(rsChart.Fields(0).Value, rsChart.Fields(2).Value) 'Irregulars
                        .Series(1).Points(x).Label = rsChart.Fields(2).Value.ToString.Replace("0", "")
                        .Series(2).Points.AddXY(rsChart.Fields(0).Value, rsChart.Fields(3).Value) 'Dropped
                        .Series(2).Points(x).Label = rsChart.Fields(3).Value.ToString.Replace("0", "")
                        x += 1
                    End If
                    rsChart.MoveNext()
                End If
            Next
            lblRecord.Text = "STRAND RECORD (" & Str(intStrandRecs - 4) & "-" & Str(IIf(intStrandRecs > intRecords, intRecords, intStrandRecs)) & ") of " & intRecords
        End With
        rsChart = Nothing
    End Sub

    Private Function fn_getRecordCount() As Integer
        rsDB = New ADODB.Recordset
        Call SQLConnect()
        strSQl = vbNullString
        strSQl &= "SELECT count(*) FROM Strand"
        rsDB.Open(strSQl, conDB, 1, 4)

        Return rsDB.Fields(0).Value
    End Function

    Private Sub frm_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intStrandRecs = 5
        intRecords = fn_getRecordCount()
        chrtDashBoard.Legends(0).Enabled = False
        btnPrev.Visible = False
        setChartData()

        Me.Left = lblDash.Width * -1
        Me.Height = 350
        intPos = Me.Left
        isShow = False
        With lblDash
            .Width = Me.Width - btnHide.Width
            .Height = Me.Height
            btnHide.Left = .Width
        End With
        Call subShow()
    End Sub

    Public Sub subHide()
        If isShow = True Then
            Do Until Me.Left = intPos
                Me.Left = Me.Left - 1
                isShow = False
            Loop
            btnHide.Text = "›"
            btnHide.Height = 40
            btnHide.Font = New Font("Calibi", 11)
        End If
    End Sub

    Public Sub subShow()
        If isShow = False Then
            Do Until Me.Left = 0
                Me.Left = Me.Left + 1
                isShow = True
            Loop
            btnHide.Text = "‹"
            btnHide.Height = Me.Height
            btnHide.Font = New Font("Calibi", 24)
        End If
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        If isShow = False Then
            Call subShow()
        Else
            Call subHide()
        End If
    End Sub

    Private Sub btnShowLegend_MouseDown(sender As Object, e As MouseEventArgs) Handles btnShowLegend.MouseDown
        chrtDashBoard.Legends(0).Enabled = True
    End Sub

    Private Sub btnShowLegend_MouseUp(sender As Object, e As MouseEventArgs) Handles btnShowLegend.MouseUp
        chrtDashBoard.Legends(0).Enabled = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        intStrandRecs += 5
        Call subBtnVisibility()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        intStrandRecs -= 5
        Call subBtnVisibility()
    End Sub

    Private Sub subBtnVisibility()
        If intStrandRecs <= 5 Then
            btnNext.Visible = True
            btnPrev.Visible = False
        ElseIf intStrandRecs >= intRecords Then
            btnNext.Visible = False
            btnPrev.Visible = True
        Else
            btnNext.Visible = True
            btnPrev.Visible = True
        End If
        chrtDashBoard.Series(0).Points.Clear()
        chrtDashBoard.Series(1).Points.Clear()
        chrtDashBoard.Series(2).Points.Clear()
        Call setChartData()
    End Sub
End Class