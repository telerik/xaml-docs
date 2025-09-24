---
title: Supported Fields
page_title: Supported Fields
description: Check our &quot;Supported Fields&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-fields-supported-fields
tags: fields
published: True
position: 1
---

# Supported Fields

This topic describes the field types that are supported out of the box in RadRichTextBox as well as the switches which can be used in combination with them.

## Field Types

In the model of RadDocument, the base class for all fields is __CodeBasedField__. It is an abstract class that can be inherited from. The implemented and ready-to-use field types are:

### AUTHOR

{ AUTHOR *["Name"]* }

**Class name: AuthorField**

The type of field is related to track changes, specifies the name of the user that has modified the document part. Read more here: [Track Changes]({%slug radrichtextbox-features-track-changes%}).


### BIBLIOGRAPHY

{ BIBLIOGRAPHY }

**Class name: BibliographyField**

Inserted in the document when you want to add information about the bibliographic sources used in the document. Read more here: [Bibliographic References]({%slug radrichtextbox-features-bibliographic-references%}).

### CITATION

{ CITATION *Tag* }

**Class name: CitationField**

Inserted when you add a citation to the document.

### DATE

{ DATE *[\@ "Date-Time Format"] [Switches]* }

**Class name: DateField**

Inserts the current date in one of the specified formats.

**Supported switches:**

* \h: Specifies use of the Hijri/Lunar calendar. This switch can be controlled through the **CalendarType** property of DateField.
* \s: Specifies use of the Saka Era calendar. This switch can be controlled through the **CalendarType** property of DateField.


### DOCVARIABLE

{ DOCVARIABLE *"Name"* }

**Class name: DocumentVariableField**

A field which uses DocumentVariables. More information can be found here: [Document Variables]({%slug radrichtextbox-features-document-variables%}).

### HYPERLINK

{ HYPERLINK *"Destination" [Switches]* }

**Class name: HyperlinkField**

Inserted in hyperlinks to store information about the navigation URI.

**Supported switches:**

- \l: Specifies a location in the file, such as a bookmark, where the hyperlink will jump. This switch can be controlled through the **LocationInFile** property of HyperlinkField.

- \n: Specifies that the destination site should be opened in a new window. This switch can be controlled through the **Target** property of HyperlinkField.

- \t: Specifies the target that the link should be redirected into. Use this switch to link from a frames page to a page that you want to appear outside of the frames page. This switch can be controlled through the **Target** property of HyperlinkField.

	Options for the \t switch are:
	
	- \t "_top": Whole page
	- \t "_self": Same frame
	- \t "_blank": New window
	- \t "_parent": Parent frame		
	

### INCLUDEPICTURE

{ INCLUDEPICTURE *"FileName"* }

**Class name: IncludePictureField**

Specifies the URI from which an image must be retrieved.

### MERGEFIELD

{ MERGEFIELD *FieldName [Switches]*}

**Class name: MergeField**

Used in mail-merge scenarios. You can read more here: [Mail Merge]({%slug radrichtextbox-features-mail-merge%}).

**Supported switches:**

* \b: Specifies the text to be inserted before the MergeField field if the field is not blank. This switch can be controlled through the **TextBeforeIfNotEmpty** property of MergeField.

* \f: Specifies the text to be inserted after the MergeField field if the field is not blank. This switch can be controlled through the **TextAfterIfNotEmpty** property of MergeField.

### NUMPAGES

{ NUMPAGES }

**Class name: NumPagesField**

Shows the number of pages in the document.

### PAGE

{ PAGE }

**Class name: PageField**

Shows the current page number.


### PAGEREF

{ PAGEREF *Bookmark* }

**Class name: PageReferenceField**

Inserts the page number of a referenced bookmark.

### REF

{ REF *Bookmark* }

**Class name: ReferenceField**

Used to refer to a bookmark or other type of field. It is inserted when a cross-reference to a table or figure caption is added to the document. Find more here: [Cross-Reference]({%slug radrichtextbox-features-cross-reference%}).

### SEQ

{ SEQ *Identifier [Bookmark] [Switches]* }


**Class name: SequentialField**

Tracks the number of tables and figures inserted in the document before a place in the document, so that the __InsertCaption()__ method would use the correct number. Find more here: [Captions for Tables and Figures]({%slug radrichtextbox-features-captions-for-tables-and-figures%}).

**Supported switches:**

* \s: Restarts the sequence number at the heading level specified after the "s". For example, { SEQ figure \s 3 } starts numbering at the Heading 3 style. This switch can be controlled through the **RestartCountingOnHeadingLevel** property of SequentialField.


### STYLEREF

{ STYLEREF *StyleIdentifier* }


**Class name: StyleReferenceField**

The type of field that a reference field refers to when a cross-reference to a Heading style is inserted.


### SYMBOL

{ SYMBOL *CharNum [Switches]* }

**Class name: SymbolField**

Used to insert a symbol in the document.

**Supported switches:**

* \a: Treats the specified code as an ANSI character. This switch can be controlled through the **IsAnsi** property of SymbolField.
* \s: Specifies the font size in points. This switch can be controlled through the **FontSize** property of SymbolField.
* \f: The font that contains the character you want to insert; the font name must be enclosed in quotation marks. Without this switch, the character is from the font applied to the Symbol field codes. This switch can be controlled through the **FontName** property of SymbolField.
* \u: Specifies that the characters are Unicode. This switch can be controlled through the **IsUnicode** property of SymbolField.


### TOC

{ TOC *[Switches]* }


**Class name: TableOfContentsField**

Shows a table of contents including headings and other specially marked parts of the document. Also can be configured to show table of figures or table of tables.

**Supported switches:**

* \o: Builds a table of contents from paragraphs formatted with styles that include outline levels (most commonly, heading styles). For example, { TOC \o "1-3" } lists only paragraphs formatted with styles that include outline levels 1 through 3. If no range of outline levels is specified, all outline levels used in the document are listed. Enclose the range numbers in quotation marks. This switch can be controlled through the **IsUnicode** property of TableOfContentsField.
* \u: Builds a table of contents from paragraphs whose formatting includes outline levels applied locally. This switch can be controlled through the **UseParagraphsOutlineLevels** property of TableOfContentsField.
* \c: Lists figures, tables, charts, or other items that are numbered by a SEQ field. This switch can be controlled through the **IncludeCaptions** property of TableOfContentsField.
* \f: Builds a table from TC fields. This switch can be controlled through the **IncludeTCEntries** property of TableOfContentsField.
* \l: Builds a table of contents from TC fields that assign entries to one of the specified levels. This switch can be controlled through the **UseTCLevelsInRange** property of TableOfContentsField.
* \p: Specifies the character that separates an entry and its page number.  Just one character is allowed; it must be enclosed in quotation marks. This switch can be controlled through the **AlignPageNumbers** property of TableOfContentsField.
* \n: Omits page numbers from the table of contents. This switch can be controlled through the **DontShowPageNumbers** property of TableOfContentsField.
* \h: Inserts TOC entries as hyperlinks. This switch can be controlled through the **HyperlinkEntries** property of TableOfContentsField.



## See Also

* [Fields Overview]({%slug radrichtextbox-features-fields%})
* [Custom Fields]({%slug radrichtextbox-features-custom-fields%})
* [Mail Merge]({%slug radrichtextbox-features-mail-merge%})
* [CustomField SDK example](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/CustomField)
