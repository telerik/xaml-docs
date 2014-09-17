---
title: Hyperlink
page_title: Hyperlink
description: Hyperlink
slug: radspreadsheet-features-hyperlink
tags: hyperlink
published: False
position: 8
---

# Hyperlink



__Hyperlinks__ enable quick access to web pages, places in the workbook or email addresses. This article demonstrates how to
        use the feature in terms of the API exposed by the document model of __RadSpreadsheet__.
      

## HyperlinkCollection

Each worksheet object maintains a collection of the hyperlinks it contains. This collection can be reached through the
          __Hyperlinks__ property of the Worksheet class. This property is of type __HyperlinkCollection__ and
          facilitates the process of searching, adding and removing hyperlinks.
        

The __SpreadsheetHyperlink__ class is the representation of hyperlink in __RadSpreadsheet__'s document
          model. The class exposes the following properties:
        

* __Range__ - property of type CellRange; indicates the range of cells that holds the hyperlink info.
            

* __HyperlinkInfo__ - property of type __HyperlinkInfo__; indicates the type of the hyperlink (Url,
              MailTo, InDocument) and contains information about the target of the hyperlink.
            As the description of __HyperlinkInfo__ suggests, __RadSpreadsheet__ supports three types of hyperlinks:
            

* __Url__ - the Url hyperlink refers to a page on the internet;
                

* __MailTo__ - the MailTo hyperlink contains an e-mail address and, optionally, a subject;
                

* __InDocument__ - the InDocument hyperlink holds a reference to a cell range in string format, e.g. A1:B3.
                

Depending on the type of the hyperlink, the __HyperlinkInfo__ object may contain additional information about the target. The
          class exposes the string properties Address, EmailSubject, ScreenTip and SubAddress and each hyperlink type requires a set of these properties to be
          filled. Note, however, that some of them are mutually exclusive. For example, if you have a Url hyperlink, you do not need to specify the EmailSubject.
        

You can create instances of each of those types, using static methods of the __HyperlinkInfo__ class.
        

Create a hyperlink to a web address: 

#### __C#__

{{region radspreadsheet-features-hyperlink_0}}
	            HyperlinkInfo webAddres = HyperlinkInfo.CreateHyperlink("http://google.com", "Google");
	{{endregion}}



#### __VB__

{{region radspreadsheet-features-hyperlink_0}}
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



Create a hyperlink to a cell range somewhere in the document:
        

#### __C#__

{{region radspreadsheet-features-hyperlink_1}}
	            HyperlinkInfo inDocument = HyperlinkInfo.CreateInDocumentHyperlink("A1:B3", "Go to A1:B3");
	{{endregion}}



#### __VB__

{{region radspreadsheet-features-hyperlink_1}}
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



Create a hyperlink to an email address:
        

#### __C#__

{{region radspreadsheet-features-hyperlink_2}}
	            HyperlinkInfo mailto = HyperlinkInfo.CreateMailtoHyperlink("someOne@someCompany.com", "someSubject", "Mail to someOne");
	{{endregion}}



#### __VB__

{{region radspreadsheet-features-hyperlink_2}}
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



## Add hyperlink

To add a hyperlink, you need to specify a cell range that will contain the hyperlink and a hyperlink info that will determine the type of the
          hyperlink. For example, the following snippet creates a web address hyperlink and assigns it to A1:
        

#### __C#__

{{region radspreadsheet-features-hyperlink_3}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            HyperlinkInfo webAddres = HyperlinkInfo.CreateHyperlink("http://google.com", "Google");
	            CellIndex a1Index = new CellIndex(0, 0);
	            SpreadsheetHyperlink spreadsheetHyperlink = worksheet.Hyperlinks.Add(a1Index, webAddres);
	{{endregion}}



#### __VB__

{{region radspreadsheet-features-hyperlink_3}}
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



## Search for hyperlink

There are several ways you can retrieve hyperlinks from the __HyperlinkCollection__ depending on their position relative to a
          given cell range.
        

Here we define two indexes and then a cell range out of those indexes.
        

#### __C#__

{{region radspreadsheet-features-hyperlink_4}}
	            CellIndex a1Index = new CellIndex(0, 0);
	            CellIndex b3Index = new CellIndex(2, 1);
	            CellRange a1b3Range = new CellRange(a1Index, b3Index);
	{{endregion}}



#### __VB__

{{region radspreadsheet-features-hyperlink_4}}
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



1. Get all hyperlinks which ranges are contained in the A1:B3 cell range:
            

#### __C#__

{{region radspreadsheet-features-hyperlink_5}}
	            IEnumerable<SpreadsheetHyperlink> containingHyperlinks = worksheet.Hyperlinks.GetContainingHyperlinks(a1b3Range);
	{{endregion}}



#### __VB__

{{region radspreadsheet-features-hyperlink_5}}
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



>The __GetContainingHyperlinks()__ method has an overload which accepts a collection of cell ranges.
              

1. Get all hyperlinks  the ranges of which intersect with the A1:B3 cell range:
            

#### __C#__

{{region radspreadsheet-features-hyperlink_6}}
	            IEnumerable<SpreadsheetHyperlink> intersectingHyperlinks = worksheet.Hyperlinks.GetIntersectingHyperlinks(a1b3Range);
	{{endregion}}



#### __VB__

{{region radspreadsheet-features-hyperlink_6}}
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



1. Get the last added hyperlink that intersects with the A1:B3 cell range:
            

#### __C#__

{{region radspreadsheet-features-hyperlink_7}}
	            bool canGetHyperlink = worksheet.Hyperlinks.TryGetHyperlink(a1Index, out spreadsheetHyperlink);
	{{endregion}}



#### __VB__

{{region radspreadsheet-features-hyperlink_7}}
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



>The __TryGetHyperlink__ method has an overload that accepts a CellIndex instead of __CellRange__.

1. Get the hyperlink which range matches A1:B3 cell range:
            

#### __C#__

{{region radspreadsheet-features-hyperlink_8}}
	            bool canGetHyperlinkExact = worksheet.Hyperlinks.TryGetHyperlinkExact(a1b3Range, out spreadsheetHyperlink);
	{{endregion}}



#### __VB__

{{region radspreadsheet-features-hyperlink_8}}
	            Dim canGetHyperlinkExact As Boolean = worksheet.Hyperlinks.TryGetHyperlinkExact(a1b3Range, spreadsheetHyperlink)
		    '#End Region
			
			' #Region radspreadsheet-features-hyperlink_9
	            Dim spreadsheetHyperlink As SpreadsheetHyperlink
	            If worksheet.Hyperlinks.TryGetHyperlink(a1Index, spreadsheetHyperlink) Then
	                worksheet.Hyperlinks.Remove(spreadsheetHyperlink)
	            End If
		    '#End Region
	End Class



## Remove hyperlink

To remove a hyperlink you need to retrieve a __SpreadsheetHyperlink__ object and then remove it from the hyperlinks collection.
        

#### __C#__

{{region radspreadsheet-features-hyperlink_9}}
	            SpreadsheetHyperlink spreadsheetHyperlink;
	            if (worksheet.Hyperlinks.TryGetHyperlink(a1Index, out spreadsheetHyperlink))
	            {
	                worksheet.Hyperlinks.Remove(spreadsheetHyperlink);
	            }
	{{endregion}}



#### __VB__

{{region radspreadsheet-features-hyperlink_9}}
	            Dim spreadsheetHyperlink As SpreadsheetHyperlink
	            If worksheet.Hyperlinks.TryGetHyperlink(a1Index, spreadsheetHyperlink) Then
	                worksheet.Hyperlinks.Remove(spreadsheetHyperlink)
	            End If
		    '#End Region
	End Class



# See Also
