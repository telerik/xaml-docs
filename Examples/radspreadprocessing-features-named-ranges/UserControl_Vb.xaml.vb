Public Class Default_Vb

       Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
	    '#Region radspreadsheet-model-features-named-ranges_0
        Dim workbook As New Workbook()
        Dim sheet1 As Worksheet = workbook.Worksheets.Add()

        sheet1.Cells(0, 0).SetValue(23738)
        sheet1.Cells(1, 0).SetValue(19012)
        sheet1.Cells(2, 0).SetValue(22544)
        sheet1.Cells(3, 0).SetValue(27690)

        workbook.Names.Add("CorporateTax", "=0.16", New CellIndex(0, 0), "Corporate Tax for Canada")
        sheet1.Names.Add("GrossProfit", "=Sheet1!$A$1:$A$4", New CellIndex(0, 0), "Gross Profit")
        sheet1.Cells(4, 0).SetValue("=SUM(GrossProfit) * CorporateTax")

        workbook.Names.Remove("CorporateTax")
        sheet1.Names.Remove("GrossProfit")
        '#End Region
		
	   '#Region radspreadsheet-model-features-named-ranges_1
		workbook.Names.Remove("CorporateTax")
		sheet1.Names.Remove("GrossProfit")
	    '#End Region
    End Sub

    End Class
