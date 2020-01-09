---
title: Find
page_title: Find
description: Find
slug: radpdfviewer-find
tags: find, findall, findprevious
published: True
position: 6
---

# Find

__RadPdfViewer__ allows flexible searching in a loaded PDF document. The following article describes the available find methods, as well as how to use the respective for the feature API.

## Using UI

Using the UI of the **Find** functionality is described in details in [Find Dialog]({%slug radpdfviewer-find-dialog%}) article.

## Find Programmatically

You can search by taking advantage of the **Find**, **FindAll** and **FindPrevious** methods (with their overloads) of the RadPdfViewer.

The **Find** method has two overloads:
* **Find(string text)**: Finds next mach for the specified text in the current document.
* **Find(string text, TextSearchOptions options)**: Finds next match for the specified text in the current document using specified options.

#### __[C#] Example 1: Find specified text using specified options__

{{region radpdfviewer-find_0}}

    string sampleText = "sample text";
    TextSearchOptions textSearchOptions = 
        new TextSearchOptions(caseSensitive: false, useRegularExpression: false, wholeWordsOnly: true);

    SearchResult searchResult = this.pdfViewer.Find(sampleText, textSearchOptions);
{{endregion}}

#### __[VB.NET] Example 1: Find specified text using specified options__

{{region radpdfviewer-find_0}}

    Dim sampleText As String = "sample text"
    Dim textSearchOptions As TextSearchOptions = 
        New TextSearchOptions(caseSensitive:=False, useRegularExpression:=False, wholeWordsOnly:=True)
        
    Dim searchResult As SearchResult = Me.pdfViewer.Find(sampleText, textSearchOptions)
{{endregion}}

The **FindAll** method has two overloads:
* **FindAll(string text)**: Finds all matches for the specified text in the current document.
* **FindAll(string text, TextSearchOptions options)**: Finds all matches for the specified text in the current document using specified options.

#### __[C#] Example 2: Find all matches for the specified text using specified options__

{{region radpdfviewer-find_1}}

    IEnumerable<SearchResult> searchResult = this.pdfViewer.FindAll(sampleText, textSearchOptions);
{{endregion}}

#### __[VB.NET] Example 2: Find all matches for the specified text using specified options__

{{region radpdfviewer-find_1}}

    Dim searchResult As IEnumerable(Of SearchResult) = Me.pdfViewer.FindAll(sampleText, textSearchOptions)
{{endregion}}

The **FindPrevious** method has two overloads:
* **FindPrevious(string text)**: Finds the previous text in the current document.
* **FindPrevious(string text, TextSearchOptions options)**: Finds the previous text in the current document using specified options.

#### __[C#] Example 3: Finds the previous text in the current document using specified options__

{{region radpdfviewer-find_2}}

    SearchResult searchResult = this.pdfViewer.FindPrevious(sampleText, textSearchOptions);
{{endregion}}

#### __[VB.NET] Example 3: Finds the previous text in the current document using specified options__

{{region radpdfviewer-find_2}}

    Dim searchResult As SearchResult = Me.pdfViewer.FindPrevious(sampleText, textSearchOptions)
{{endregion}}

The **SearchResult** class holds the result from a specific search command. This class exposes several properties:
* **NotFound**: A static property which gets a default SearchResult instance when there is no search result found.
* **Range**: Gets the text range.
* **Result**: Gets the result as text.
and methods:
* **ToString**: Returns a string that represents the current object.

#### __[C#] Example 4: Check if search result is different from NotFound__

{{region radpdfviewer-find_3}}

    if (searchResult != SearchResult.NotFound)
    {
        TextRange searchResultRange = searchResult.Range;
        string searchResultAsText = searchResult.Result;
    }
{{endregion}}

#### __[VB.NET] Example 4: Check if search result is different from NotFound__

{{region radpdfviewer-find_3}}

    If searchResult <> SearchResult.NotFound Then
        Dim searchResultRange As TextRange = searchResult.Range
        Dim searchResultAsText As String = searchResult.Result
    End If
{{endregion}}

The **TextSearchOptions** class holds all possible search options when invoking finding. The class has various constructors that can be used depending on the necessities. Their main difference is they are receiving different amount of parameters according to the selected options. 
constructors:
* **TextSearchOptions(bool caseSensitive)**
* **TextSearchOptions(bool caseSensitive, bool useRegularExpression)**
* **TextSearchOptions(bool caseSensitive, bool useRegularExpression, bool wholeWordsOnly)**

This class exposes a static property:
* **Default**: Gets the default text search options.

    #### __[C#] Example 5: The default search options__
    {{region radpdfviewer-find_4}}
    
        TextSearchOptions textSearchOptions = 
            new TextSearchOptions(caseSensitive: false, useRegularExpression: false, wholeWordsOnly: false);
    {{endregion}}
    
    #### __[VB.NET] Example 5: The default search options__
    
    {{region radpdfviewer-find_4}}
    
        Dim textSearchOptions As TextSearchOptions = 
            New TextSearchOptions(caseSensitive:=False, useRegularExpression:=False, wholeWordsOnly:=False)
    {{endregion}}

several non-static properties: 
* **UseRegularExpression**: Gets or sets the use regular expression option.
* **CaseSensitive**: Gets or sets the case sensitive option.
* **WholeWordsOnly**: Gets or sets the whole words only.

and events:
* **PropertyChanged**: Occurs when a property value changes.

## See Also

 * [Find Dialog]({%slug radpdfviewer-find-dialog%})
