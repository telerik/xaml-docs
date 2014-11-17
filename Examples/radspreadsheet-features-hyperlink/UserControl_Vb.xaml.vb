Public Class Default_Vb

    ' #Region radspreadsheet-features-hyperlink_0
		Dim webAddres As HyperlinkInfo = HyperlinkInfo.CreateHyperlink("http://google.com", "Google")
    '#End Region

    ' #Region radspreadsheet-features-hyperlink_1
		Dim inDocument As HyperlinkInfo = HyperlinkInfo.CreateInDocumentHyperlink("A1:B3", "Go to A1:B3")
    '#End Region

	' #Region radspreadsheet-features-hyperlink_2
		Dim mailto As HyperlinkInfo = HyperlinkInfo.CreateMailtoHyperlink("someOne@someCompany.com", "someSubject", "Mail to someOne")
    '#End Region
	
		' #Region radspreadsheet-features-hyperlink_3
	Dim workbook As New Workbook()
	Dim worksheet As Worksheet = workbook.Worksheets.Add()
	Dim webAddres As HyperlinkInfo = HyperlinkInfo.CreateHyperlink("http://google.com", "Google")
	Dim a1Index As New CellIndex(0, 0)
	Dim spreadsheetHyperlink As SpreadsheetHyperlink = worksheet.Hyperlinks.Add(a1Index, webAddres)
	    '#End Region
		
		' #Region radspreadsheet-features-hyperlink_4
            Dim a1Index As New CellIndex(0, 0)
            Dim b3Index As New CellIndex(2, 1)
            Dim a1b3Range As New CellRange(a1Index, b3Index)
	    '#End Region
		
		' #Region radspreadsheet-features-hyperlink_5
            Dim containingHyperlinks As IEnumerable(Of SpreadsheetHyperlink) = worksheet.Hyperlinks.GetContainingHyperlinks(a1b3Range)
	    '#End Region
		
		' #Region radspreadsheet-features-hyperlink_6
            Dim intersectingHyperlinks As IEnumerable(Of SpreadsheetHyperlink) = worksheet.Hyperlinks.GetIntersectingHyperlinks(a1b3Range)
	    '#End Region
		
		' #Region radspreadsheet-features-hyperlink_7
            Dim canGetHyperlink As Boolean = worksheet.Hyperlinks.TryGetHyperlink(a1Index, spreadsheetHyperlink)
	    '#End Region
		
		' #Region radspreadsheet-features-hyperlink_8
            Dim canGetHyperlinkExact As Boolean = worksheet.Hyperlinks.TryGetHyperlinkExact(a1b3Range, spreadsheetHyperlink)
	    '#End Region
		
		' #Region radspreadsheet-features-hyperlink_9
            Dim spreadsheetHyperlink As SpreadsheetHyperlink
            If worksheet.Hyperlinks.TryGetHyperlink(a1Index, spreadsheetHyperlink) Then
                worksheet.Hyperlinks.Remove(spreadsheetHyperlink)
            End If
	    '#End Region
End Class
