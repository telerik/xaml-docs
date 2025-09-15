---
title: Find
page_title: Find
description: Check our &quot;Find&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-find
tags: find, findall, findprevious
published: True
position: 6
---

# Find

__RadPdfViewer__ allows flexible searching in a loaded PDF document. The following article describes the available find methods, as well as how to use the respective for the feature API.

>note Using the UI of the **Find** functionality is described in detail in the [Find Dialog]({%slug radpdfviewer-find-dialog%}) article.

## Find Programmatically

You can search by taking advantage of the **Find**, **FindAll** and **FindPrevious** methods with their overloads exposed by RadPdfViewer. These methods could receive  [TextSearchOptions](#textsearchoptions) as optional parameter in their constructor. The result of the search is hold by an instance of [SearchResult](#searchresult) class.

The **Find** method has two overloads:
* **Find(string text)**: Finds next mach for the specified text in the current document.
* **Find(string text, TextSearchOptions options)**: Finds next match for the specified text in the current document using specified options.

__Example 1: Find specified text using specified options__

```C#

    string sampleText = "sample text";
    TextSearchOptions textSearchOptions = 
        new TextSearchOptions(caseSensitive: false, useRegularExpression: false, wholeWordsOnly: true);

    SearchResult searchResult = this.pdfViewer.Find(sampleText, textSearchOptions);
```
```VB.NET

    Dim sampleText As String = "sample text"
    Dim textSearchOptions As TextSearchOptions = 
        New TextSearchOptions(caseSensitive:=False, useRegularExpression:=False, wholeWordsOnly:=True)
        
    Dim searchResult As SearchResult = Me.pdfViewer.Find(sampleText, textSearchOptions)
```

The **FindAll** method has two overloads:
* **FindAll(string text)**: Finds all matches for the specified text in the current document.
* **FindAll(string text, TextSearchOptions options)**: Finds all matches for the specified text in the current document using specified options.

__Example 2: Find all matches for the specified text using specified options__

```C#

    IEnumerable<SearchResult> searchResult = this.pdfViewer.FindAll(sampleText, textSearchOptions);
```
```VB.NET

    Dim searchResult As IEnumerable(Of SearchResult) = Me.pdfViewer.FindAll(sampleText, textSearchOptions)
```

The **FindPrevious** method has two overloads:
* **FindPrevious(string text)**: Finds the previous text in the current document.
* **FindPrevious(string text, TextSearchOptions options)**: Finds the previous text in the current document using specified options.

__Example 3: Finds the previous text in the current document using specified options__

```C#

    SearchResult searchResult = this.pdfViewer.FindPrevious(sampleText, textSearchOptions);
```
```VB.NET

    Dim searchResult As SearchResult = Me.pdfViewer.FindPrevious(sampleText, textSearchOptions)
```

### SearchResult

The **SearchResult** class holds the result from a specific search command. This class exposes several properties and methods:
* **NotFound**: A static property which gets a default SearchResult instance when there is no search result found.
* **Range**: Gets a [TextRange](https://docs.telerik.com/devtools/document-processing/api/Telerik.Windows.Documents.Fixed.Text.TextRange.html) object describing the start and end positions of the match.
* **Result**: Gets the result as text.
* **ToString**: Returns a string that represents the current object.

__Example 4: Check if a match was found__

```C#

    if (searchResult != SearchResult.NotFound)
    {
        TextRange searchResultRange = searchResult.Range;
        string searchResultAsText = searchResult.Result;
    }
```
```VB.NET

    If searchResult <> SearchResult.NotFound Then
        Dim searchResultRange As TextRange = searchResult.Range
        Dim searchResultAsText As String = searchResult.Result
    End If
```

### TextSearchOptions

The **TextSearchOptions** class holds all possible search options when invoking one of the Find methods. The class has various constructors that can be used depending on the necessities. Their main difference is they are receiving different amount of parameters according to the selected options.
* **TextSearchOptions(bool caseSensitive)**
* **TextSearchOptions(bool caseSensitive, bool useRegularExpression)**
* **TextSearchOptions(bool caseSensitive, bool useRegularExpression, bool wholeWordsOnly)**

This class exposes a static property:
* **Default**: Gets the default text search options.

    __Example 5: The default search options__
    ```C#
    
        TextSearchOptions textSearchOptions = 
            new TextSearchOptions(caseSensitive: false, useRegularExpression: false, wholeWordsOnly: false);
    ```
```VB.NET
    
        Dim textSearchOptions As TextSearchOptions = 
            New TextSearchOptions(caseSensitive:=False, useRegularExpression:=False, wholeWordsOnly:=False)
    ```

several non-static boolean properties:
* **UseRegularExpression**: Gets or sets a value indicating whether a regular expression should be used for searching.
* **CaseSensitive**: Gets or sets a value indicating whether the search should be case sensitive.
* **WholeWordsOnly**: Gets or sets a value indicating whether only whole words should be matched.

and events:
* **PropertyChanged**: Occurs when a property value changes.

## See Also

 * [Find Dialog]({%slug radpdfviewer-find-dialog%})
