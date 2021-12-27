Imports Steema.TeeChart.WPF

Class MainWindow

    Dim bar1 As New Steema.TeeChart.WPF.Styles.Bar
    Dim line1 As New Steema.TeeChart.WPF.Styles.Line
    Friend WithEvents lineAvg As New Steema.TeeChart.WPF.Styles.Line  'enable use of events

    Private Sub FillValues()
        Dim rand As New Random()

        bar1.Clear()
        line1.Clear()

        'line1.FillSampleValues()
        For i = 0 To 29
            bar1.Add(i, rand.Next(50))
            line1.Add(i, rand.Next(50))
        Next

        lineAvg.CheckDataSource()
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        Chart.Series.Add(bar1)
        Chart.Series.Add(line1)

        FillValues()

    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)

        Dim barAverage As New Steema.TeeChart.WPF.Functions.Average

        ' create  a Line to display the function values
        'Dim lineAvg As New Steema.TeeChart.WPF.Styles.Line  'set class scope
        lineAvg.Function = barAverage
        lineAvg.LinePen.Width = 2

        Chart.Series.Add(lineAvg)

        lineAvg.Marks.Visible = True
        lineAvg.Marks.Font.Size = 14


        'set the datasource
        lineAvg.DataSource = bar1

        'refresh data
        lineAvg.CheckDataSource()

    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)

        ' refresh data
        FillValues()

    End Sub

    Private Sub lineAvg_GetSeriesMark(series As Styles.Series, e As Styles.GetSeriesMarkEventArgs) Handles lineAvg.GetSeriesMark

        If e.ValueIndex = 0 Then
            e.MarkText = "bar1 avg"
        End If


    End Sub

End Class
