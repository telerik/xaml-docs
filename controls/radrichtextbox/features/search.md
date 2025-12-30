---
title: Search
page_title: Search
description: Check our &quot;Search&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-search
tags: search
published: True
---

# Search



## 

__RadRichTextBox__ supports searching the contents of the document along with providing some methods for manipulating the selection. Used in combination, they become quite a powerful tool enabling scenarios like highlighting of specific parts of the document or replacing words and collocations.

>tip To learn more about the selection API read the [Selection]({%slug radrichtextbox-features-selection%}) topic.

The simplest scenario – finding a string in the content of the document can be implemented with the following code:



```C#
	private void SelectAllMatches(string toSearch)
	{
	    this.radRichTextBox.Document.Selection.Clear(); // this clears the selection before processing
	    DocumentTextSearch search = new DocumentTextSearch(this.radRichTextBox.Document);
	    foreach (var textRange in search.FindAll(toSearch))
	    {
	        this.radRichTextBox.Document.Selection.AddSelectionStart(textRange.StartPosition);
	        this.radRichTextBox.Document.Selection.AddSelectionEnd(textRange.EndPosition);
	    }
	}
```
```VB.NET
	Private Sub SelectAllMatches(ByVal toSearch As String)
	 Me.radRichTextBox.Document.Selection.Clear() ' this clears the selection before processing
	 Dim search As New DocumentTextSearch(Me.radRichTextBox.Document)
	 For Each textRange In search.FindAll(toSearch)
	  Me.radRichTextBox.Document.Selection.AddSelectionStart(textRange.StartPosition)
	  Me.radRichTextBox.Document.Selection.AddSelectionEnd(textRange.EndPosition)
	 Next textRange
	End Sub
```



Note that the __FindAll()__ method of the DocumentTextSearch class takes a string as an argument, but regards it as a regular expression. For example, searching __“[a-z]*control[a-z]*”__ will find all words that contain the word “control” as a substring. Thus, if you have the word “Telerik UI” in the document, executing the __SelectAllMatches(“control”)__ will result in only these six letters being selected, as opposed to the whole word “Telerik UI” being selected when __SelectAllMatches(“[a-z]*control[a-z]*”)__.

You can use all kind of regular expressions, such as __“(asp|silverlight)\s*control(s)?”__ (which would match both “ASP Controls” and “SilverlightControl”), __[a-z]*(.)\1[a-z]*__ (which finds all words that have a doubled letter), and basically everything else you can come up with. Make sure to use correct expressions if you want to utilize this functionality, or escape the string in case you want a simple search for a word that can contain special symbols like “?”, “+”, “{“ etc. This can be automatically done by invoking the following code before proceeding with the search.



```C#
	toSearch = Regex.Escape(toSearch);
```
```VB.NET
	toSearch = Regex.Escape(toSearch)
```

> You should have in mind that performing these actions in __DocumentContentChanged__ event handler will not only raise performance issues, but will also produce an infinite loop, as the changes of the formatting are also considered document changes.


Selecting the results of the search is particularly useful, as most formatting commands that are executed on __RadRichTextBox__ (or its document) are selection-based, i.e. they operate on the currently selected parts of the document. You can use that fact by invoking one of these commands after having selected the words in the document. Here is an example.



```C#
	this.radRichTextBox.ChangeTextHighlightColor(Colors.LightGray);  // will highlight all selected words in LightGray
	this.radRichTextBox.ChangeFontSize(Unit.PointToDip(32));   // will increase the font size of the words to 30 DIP
	this.radRichTextBox.ChangeFontFamily(new FontFamily("Comic Sans MS")); // will change the font family of the spans, containing these words.
```
```VB.NET
	Me.radRichTextBox.ChangeTextHighlightColor(Colors.LightGray) \' will highlight all selected words in LightGray
	Me.radRichTextBox.ChangeFontSize(Unit.PointToDip(32)) \' will increase the font size of the words to 30 DIP
	Me.radRichTextBox.ChangeFontFamily(New FontFamily("Comic Sans MS")) \' will change the font family of the spans, containing these words.
```



Most of the time, you would like to remove the selection at the end of the operations, which is done by calling the __Clear()__ method of the  __DocumentSelection__ object.



```C#
	this.radRichTextBox.Document.Selection.Clear();
```
```VB.NET
	Me.radRichTextBox.Document.Selection.Clear()
```



On a side note, the find and select functionality can be extended in order to implement a replace of all occurrences matching the searched string with another string. Here is a sample code:



```C#
	private void ReplaceAllMatches(string toSearch, string toReplaceWith)
	{
	    this.radRichTextBox.Document.Selection.Clear(); // this clears the selection before processing
	    DocumentTextSearch search = new DocumentTextSearch(this.radRichTextBox.Document);
	    List<TextRange> rangesTrackingDocumentChanges = new List<TextRange>();
	    foreach (var textRange in search.FindAll(toSearch))
	    {
	        TextRange newRange = new TextRange(new DocumentPosition(textRange.StartPosition, true), new DocumentPosition(textRange.EndPosition, true));
	        rangesTrackingDocumentChanges.Add(newRange);
	    }
	    foreach (var textRange in rangesTrackingDocumentChanges)
	    {
	        this.radRichTextBox.Document.Selection.AddSelectionStart(textRange.StartPosition);
	        this.radRichTextBox.Document.Selection.AddSelectionEnd(textRange.EndPosition);
	        this.radRichTextBox.Insert(toReplaceWith);
	        textRange.StartPosition.Dispose();
	        textRange.EndPosition.Dispose();
	    }
	}
```
```VB.NET
	Private Sub ReplaceAllMatches(ByVal toSearch As String, ByVal toReplaceWith As String)
	 Me.radRichTextBox.Document.Selection.Clear() \' this clears the selection before processing
	 Dim search As New DocumentTextSearch(Me.radRichTextBox.Document)
	 Dim rangesTrackingDocumentChanges As New List(Of TextRange)()
	 For Each textRange In search.FindAll(toSearch)
	  Dim newRange As New TextRange(New DocumentPosition(textRange.StartPosition, True), New DocumentPosition(textRange.EndPosition, True))
	  rangesTrackingDocumentChanges.Add(newRange)
	 Next textRange
	 For Each textRange In rangesTrackingDocumentChanges
	  Me.radRichTextBox.Document.Selection.AddSelectionStart(textRange.StartPosition)
	  Me.radRichTextBox.Document.Selection.AddSelectionEnd(textRange.EndPosition)
	  Me.radRichTextBox.Insert(toReplaceWith)
	  textRange.StartPosition.Dispose()
	  textRange.EndPosition.Dispose()
	 Next textRange
	End Sub
```



There is a need to create new __TextRanges__ with document positions that track the changes to the document, because the deletion and insertion affects the document positions. The document positions created using the 2-parameter constructor with the second parameter set to “true” keep their relative position as the document changes. They, however, have to be manually disposed of, as they subscribe to events in order to track the changes to the document and must detach their handlers at the end of their use. This is done using the __Dispose()__ method. If you skip that step, there will be memory leaks in your application.
