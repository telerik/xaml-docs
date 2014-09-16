Public Class Default_Vb


' #region radchart-populating-with-data-data-binding-to-many-chart-areas_2
'Creating new instance of RadChart control
Dim radChart As New Telerik.Windows.Controls.RadChart()
....
'Creating Grid with two rows and two columns to host two ChartTitles and two ChartAreas
Dim chartLayout As New Grid()
chartLayout.Margin = New Thickness(10, 10, 0, 20)
chartLayout.RowDefinitions.Add(New RowDefinition())
chartLayout.RowDefinitions(0).Height = New GridLength(0, GridUnitType.Auto)
chartLayout.RowDefinitions.Add(New RowDefinition())
radChart.Content = chartLayout
chartLayout.ColumnDefinitions.Add(New ColumnDefinition())
chartLayout.ColumnDefinitions.Add(New ColumnDefinition())
'Creating ChartTitle for the left chart
Dim chartTitle As New Telerik.Windows.Controls.Charting.ChartTitle()
chartTitle.Margin = New Thickness(0, 0, 0, 10)
chartTitle.HorizontalAlignment = HorizontalAlignment.Center
chartTitle.Content = "Year 2008"
chartLayout.Children.Add(chartTitle)
'Creating ChartArea of for the left chart
Dim chartArea1 As New Telerik.Windows.Controls.Charting.ChartArea()
chartArea1.Name = "webBrowsersShare2008Chart"
chartLayout.Children.Add(chartArea1)
Grid.SetRow(chartArea1, 1)
'Creating ChartTitle for the right chart
chartTitle = New Telerik.Windows.Controls.Charting.ChartTitle()
chartTitle.Margin = New Thickness(0, 0, 0, 10)
chartTitle.HorizontalAlignment = HorizontalAlignment.Center
chartTitle.Content = "Year 2009"
chartLayout.Children.Add(chartTitle)
Grid.SetColumn(chartTitle, 1)
'Creating ChartArea of for the right chart
Dim chartArea2 As New Telerik.Windows.Controls.Charting.ChartArea()
chartArea2 = New Telerik.Windows.Controls.Charting.ChartArea()
chartArea2.Name = "webBrowsersShare2009Chart"
chartLayout.Children.Add(chartArea2)
Grid.SetRow(chartArea2, 1)
Grid.SetColumn(chartArea2, 1)
'Creating series mapping for the first chart and link it to the left ChartArea
Dim seriesMapping As New SeriesMapping()
seriesMapping.CollectionIndex = 0
seriesMapping.ChartAreaName = "webBrowsersShare2008Chart"
seriesMapping.SeriesDefinition = New DoughnutSeriesDefinition()
seriesMapping.ItemMappings.Add(New ItemMapping("Value", DataPointMember.YValue))
seriesMapping.ItemMappings.Add(New ItemMapping("Description", DataPointMember.Label))
radChart.SeriesMappings.Add(seriesMapping)
'Creating series mapping for the first chart and link it to the right ChartArea
seriesMapping = New SeriesMapping()
seriesMapping.CollectionIndex = 1
seriesMapping.ChartAreaName = "webBrowsersShare2009Chart"
seriesMapping.SeriesDefinition = New DoughnutSeriesDefinition()
seriesMapping.ItemMappings.Add(New ItemMapping("Value", DataPointMember.YValue))
seriesMapping.ItemMappings.Add(New ItemMapping("Description", DataPointMember.Label))
radChart.SeriesMappings.Add(seriesMapping)
....
' #endregion
End Class
