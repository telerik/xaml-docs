---
title: Changes
page_title: Changes
description: Changes
slug: radwordsprocessing-changes
tags: changes
published: True
position: 0
---

# Changes



This topic will summarize the new functionality introduced in the library with helpful links to places in the documentation that describe in greater detail the new functionality and how it can be used.

## What's New in 2014 Q3

__What's New__

* Mail Merge support, which can be used to generate documents from a template document (containing merge fields) and data source. [Read more.]({%slug radwordsprocessing-editing-mail-merge%})

* Document Variables that enable users to define variables in the document and use document variable fields. [Read more.]({%slug radwordsprocessing-concepts-document-variables%})

* Export of table styles to HTML.
            

* Import/export HTML preserving white spaces through non-breaking spaces.
            

* Import and export document theme to DOCX file format.
            

* Introduced lists export/import to HTML.
            

__What's Fixed__

* Table border calculator is not working correctly for table with empty rows.
            

* 'Style' element is not correctly imported when it is outside the 'head' element.
            

* Incorrect export of nested table elements.
            

* Converted Border class to immutable type.
            

* Importing empty string causes exception.
            

* 'Class' attribute is exported when ExportSettings.StylesExportMode is None.
            

* NullReference exception is thrown when FieldResult is empty string or null.
            

* Properties of Paragraphs without StyleId are not exported when StylesExportMode is Inline.
            

* Importing HTML containing only an image causes exception.
            

* Line breaks are not exported to HTML.
            

* Underline is not exported to HTML.
            

* HtmlFormatProvider crashes when html element is present in the body.
            

* Support for negative indent.
            

* Table column's widths are not respected when importing from HTML and exporting to DOCX.
            

* Importing from HTML imports table borders as inside borders.
            

* StyleProperty.GetActualValue() throws exception when style is not added to a document.
            

* RestartAfterLevel property in ListLevel class has inappropriate default value.
            

* RestartAfterLevel does not work correctly when exported to RTF format.
            

* Style applied to div is applied over paragraphs after the div.
            

* Exporting to HTML document containing hyperlink with StylesExportMode Inline causes exception.
            

* When importing from HTML paragraph style is not respected.
            

* Default font size is not exported correctly to RTF.
            

## What's New in 2014 Q2

* [Html Import/Export]({%slug radwordsprocessing-formats-and-conversion-html%})

* [Lists]({%slug radwordsprocessing-concepts-lists%})

* [Break]({%slug radwordsprocessing-model-break%})

* [Lists]({%slug radwordsprocessing-concepts-lists%})

* [Bookmark]({%slug radwordsprocessing-model-bookmark%})

* [Comment]({%slug radwordsprocessing-model-comment%})
