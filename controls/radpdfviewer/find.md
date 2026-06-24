---
title: Find
page_title: Find Text in RadPdfViewer
description: Learn how to search PDF text programmatically in RadPdfViewer with Find, FindAll, FindPrevious, TextSearchOptions, and SearchResult.
slug: radpdfviewer-find
tags: find, findall, findprevious
published: True
position: 10
---

# Find Text in RadPdfViewer

Use `RadPdfViewer` to search the text content of a loaded PDF document. This article explains when to use `Find`, `FindAll`, and `FindPrevious`, how to configure `TextSearchOptions`, and how to work with the returned `SearchResult` values.

>note If you want to let users search through the built-in viewer UI, see [Find Dialog]({%slug radpdfviewer-find-dialog%}).

## Find Programmatically

To search programmatically:

1. Load a document in `RadPdfViewer`.
2. Choose the search method that matches your scenario.
3. Optionally create a `TextSearchOptions` instance.
4. Check the returned `SearchResult` value or enumerate all matches.

The programmatic API exposes three main methods:

* `Find(string text)` and `Find(string text, TextSearchOptions options)` find the next match.
* `FindPrevious(string text)` and `FindPrevious(string text, TextSearchOptions options)` find the previous match.
* `FindAll(string text)` and `FindAll(string text, TextSearchOptions options)` return all matches in the current document.

## Choose the Right Search Method

Use the search method that matches the navigation behavior you need:

* Use `Find` to move forward to the next match.
* Use `FindPrevious` to move backward through existing matches.
* Use `FindAll` when you need the full set of results, for example to build your own results list or count all occurrences.

## Find the Next Match

Use `Find` when you want the next occurrence of a string, optionally with custom search options.

__Example 1: Find the next match with custom options__

```csharp
string sampleText = "sample text";
TextSearchOptions textSearchOptions =
    new TextSearchOptions(caseSensitive: false, useRegularExpression: false, wholeWordsOnly: true);

SearchResult searchResult = this.pdfViewer.Find(sampleText, textSearchOptions);
```
```vbnet
Dim sampleText As String = "sample text"
Dim textSearchOptions As TextSearchOptions =
    New TextSearchOptions(caseSensitive:=False, useRegularExpression:=False, wholeWordsOnly:=True)

Dim searchResult As SearchResult = Me.pdfViewer.Find(sampleText, textSearchOptions)
```

## Find All Matches

Use `FindAll` when you need every match in the current document instead of only the next or previous one.

__Example 2: Find all matches with custom options__

```csharp
string sampleText = "sample text";
TextSearchOptions textSearchOptions =
    new TextSearchOptions(caseSensitive: false, useRegularExpression: false, wholeWordsOnly: true);

IEnumerable<SearchResult> searchResults = this.pdfViewer.FindAll(sampleText, textSearchOptions);
```
```vbnet
Dim sampleText As String = "sample text"
Dim textSearchOptions As TextSearchOptions =
    New TextSearchOptions(caseSensitive:=False, useRegularExpression:=False, wholeWordsOnly:=True)

Dim searchResults As IEnumerable(Of SearchResult) = Me.pdfViewer.FindAll(sampleText, textSearchOptions)
```

## Find the Previous Match

Use `FindPrevious` when the current user flow needs to go back to an earlier occurrence.

__Example 3: Find the previous match with custom options__

```csharp
string sampleText = "sample text";
TextSearchOptions textSearchOptions =
    new TextSearchOptions(caseSensitive: false, useRegularExpression: false, wholeWordsOnly: true);

SearchResult searchResult = this.pdfViewer.FindPrevious(sampleText, textSearchOptions);
```
```vbnet
Dim sampleText As String = "sample text"
Dim textSearchOptions As TextSearchOptions =
    New TextSearchOptions(caseSensitive:=False, useRegularExpression:=False, wholeWordsOnly:=True)

Dim searchResult As SearchResult = Me.pdfViewer.FindPrevious(sampleText, textSearchOptions)
```

### SearchResult

The `SearchResult` class describes a single search hit. After calling `Find` or `FindPrevious`, compare the returned value with `SearchResult.NotFound` before accessing its properties.

Use these members most often:

* `NotFound` returns the default result when no match exists.
* `Range` returns a [TextRange](https://www.telerik.com/document-processing-libraries/documentation/api/telerik.windows.documents.fixed.text.textrange) that describes where the match starts and ends.
* `Result` returns the matched text.
* `ToString()` returns a string representation of the current result.

__Example 4: Check whether a match was found__

```csharp
SearchResult searchResult = this.pdfViewer.Find("sample text");

if (searchResult != SearchResult.NotFound)
{
    TextRange searchResultRange = searchResult.Range;
    string searchResultAsText = searchResult.Result;
}
```
```vbnet
Dim searchResult As SearchResult = Me.pdfViewer.Find("sample text")

If searchResult <> SearchResult.NotFound Then
    Dim searchResultRange As TextRange = searchResult.Range
    Dim searchResultAsText As String = searchResult.Result
End If
```

## Configure TextSearchOptions

Use `TextSearchOptions` to control how the search engine interprets the input text.

The class provides the following constructors:

* `TextSearchOptions(bool caseSensitive)`
* `TextSearchOptions(bool caseSensitive, bool useRegularExpression)`
* `TextSearchOptions(bool caseSensitive, bool useRegularExpression, bool wholeWordsOnly)`

Use the options as follows:

* Set `CaseSensitive` to `true` when letter casing must match exactly.
* Set `UseRegularExpression` to `true` when the search text is a regular expression pattern.
* Set `WholeWordsOnly` to `true` when partial-word matches must be excluded.

The class also exposes the static `Default` property, which returns the default search configuration.

__Example 5: Create the default search options explicitly__

```csharp
TextSearchOptions textSearchOptions =
    new TextSearchOptions(caseSensitive: false, useRegularExpression: false, wholeWordsOnly: false);
```
```vbnet
Dim textSearchOptions As TextSearchOptions =
    New TextSearchOptions(caseSensitive:=False, useRegularExpression:=False, wholeWordsOnly:=False)
```

__Example 6: Use the default search options__

```csharp
TextSearchOptions textSearchOptions = TextSearchOptions.Default;
```
```vbnet
Dim textSearchOptions As TextSearchOptions = TextSearchOptions.Default
```

The main instance properties are:

* `UseRegularExpression`: Gets or sets whether the search uses a regular expression.
* `CaseSensitive`: Gets or sets whether the search respects letter casing.
* `WholeWordsOnly`: Gets or sets whether only whole-word matches are returned.

The class also exposes the `PropertyChanged` event, which occurs when a property value changes.

## Common Search Workflow

The following example shows a typical search flow:

1. Define the search text.
2. Create search options.
3. Call `Find`.
4. Check whether a result was found.

__Example 7: Run a complete search flow__

```csharp
string sampleText = "invoice";
TextSearchOptions options = new TextSearchOptions(false, false, true);
SearchResult result = this.pdfViewer.Find(sampleText, options);

if (result == SearchResult.NotFound)
{
    return;
}

string matchedText = result.Result;
TextRange matchedRange = result.Range;
```
```vbnet
Dim sampleText As String = "invoice"
Dim options As New TextSearchOptions(False, False, True)
Dim result As SearchResult = Me.pdfViewer.Find(sampleText, options)

If result = SearchResult.NotFound Then
    Return
End If

Dim matchedText As String = result.Result
Dim matchedRange As TextRange = result.Range
```

## See Also

* [Find Dialog]({%slug radpdfviewer-find-dialog%})
