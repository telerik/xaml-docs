---
title: Overview
page_title: Overview
description: Overview
slug: radrichtextbox-overview
tags: overview
published: True
position: 0
---

# Overview

{% if site.site_name == 'Silverlight' %}![](images/RadRichTextBox_overview_sl_01.png){% endif %}{% if site.site_name == 'WPF' %}![](images/RadRichTextBox_overview_wpf_01.png){% endif %}

__RadRichTextBox__ is a control that can display and edit rich-text content including formatted text arranged in pages, paragraphs, spans (runs), tables, images, etc.

![Rad Rich Text Box Overview 03](images/RadRichTextBox_Overview_03.png)

## Key Features

* __Rich Text Formatting__
	Telerik RadRichTextBox control allows you to apply diffent rich formatting options. You can find some of them listed below.	
	* Bold, Italic
	* Underline, Strike Through, Superscript and Subscript
	* {% if site.site_name == 'Silverlight' %}Built-in Silverlight fonts and sizes{% endif %}{% if site.site_name == 'WPF' %}Usage of all available system fonts {% endif %}
	* Text color and background
	* Bullet and numbered lists
	* Paragraph alignment and indentation
	* Show/Hide formatting symbols
	* Clear Formatting 

* __Inserting pictures, symbols, hyperlinks and custom UI elements__
	For more information, see the [InlineUIContainer]({%slug radrichtextbox-features-document-elements-inlineuicontainer%}) article. You can also see the [InlineImage]({%slug radrichtextbox-features-document-elements-inlineimage%}) and [Hyperlink]({%slug radrichtextbox-features-document-elements-hyperlink%}) articles.

* __Table support__
	The control allows you to display and create tables. This feature includes also support for nested tables, merging cells, setting different __RowSpan__ and __ColumnSpan__, tables with auto width, header row repeating on new pages, and more. For more information, see the [Table]({%slug radrichtextbox-features-document-elements-tables%}) article.

* __Context menu__
	A standard context menu is provided out of the box, but it can be easily customized or replaced with a user-defined menu. For more information, see the [Context Menu]({%slug radrichtextbox-features-context-menu%}) article.

* __SelectionMiniToolbar__
	The rich text box component supports a floating toolbar that appears next to the selected element in the document. This feature is very similar to the one in MS Word, but can also be replaced with another mini toolbar. For more information, see the [Selection Mini Tool Bar]({%slug radrichtextbox-features-selection-mini-toolbar%}) article.

* __SpellChecker__
	An extensible spell checking for different languages, using the built-in or custom dictionaries. For more information, see the [Spellcheck]({%slug radrichtextbox-features-spellcheck%}) article.

* __Printing__
	{% if site.site_name == 'Silverlight' %}The printing feature allows you to choose between HTML printing for better performance and the Silverlight printing.{% endif %}{% if site.site_name == 'WPF' %}The printing feature allows you to use the native printing implementation of WPF{% endif %}. For more information, see the [Guidelines for Printing with RadDocument]({%slug radrichtextbox-guidelines-for-printing-with-raddocument%}) article.

* __Multi-level Undo/Redo Support__
	Telerik __RadRichTextBox__ provides multilevel Undo/Redo support which allows past actions to be reviewed and reversed.For more information, see the [History]({%slug radrichtextbox-features-history%}) article.

* __Three types of layout__
	There are three layout types supported by the rich text box conrol - Paged, Flow (as text in an HTML page viewed in a browser) and FlowNoWrap. For more information, see the [Layout Modes]({%slug radrichtextbox-features-layout-modes%}) help article.

* __Multi-region selection__
	The built-in multi-region support enables you to perform various operations for more than one selection simultaneously. For more information, see the [Selection]({%slug radrichtextbox-features-selection%}) article.

* {% if site.site_name == 'Silverlight' %}__Delete, Cut, Copy and Paste in plain text (using Silverlight 4.0 build-in clipboard). Copy/Paste in internal rich-text clipboard.__{% endif %}{% if site.site_name == 'WPF' %}__Rich-text clipboard__{% endif %}
	{% if site.site_name == 'WPF' %} The control allows rich text copy/paste from the clipboard. This includes rich text copied from applications like Word, OpenOffice etc.{% endif %} For more information, see the [Clipboard Support]({%slug radrichtextbox-features-clipboard-support%}) article.

* __Import/export__
	Telerik RadRichTextBox allows you to load XAML, HTML, RTF, DOCX (rich-text) or TXT (plain text) into the control, you can format and edit it and then export it back to any of the above formats. The control also supports export to PDF. For more information, see the [Import/Export]({%slug radrichtextbox-features-import-export%}) article.

* __Headers and Footers__ 
	RadRichTextBox supports headers and footers in its document. For more information, see the [Headers and Footers]({%slug radrichtextbox-features-headers-and-footers%}) article.

* __Track changes__
	Support for tracking changes as formatting changes, adding and removing text, images, hyperlinks, tables, etc. This feature is useful when different people are working on the same document. For more information, see the [Track Changes]({%slug radrichtextbox-features-track-changes%}) article.

* __Bookmarks__
	The control provides easy retrieval of previously marked parts of the document. For more information, see the [Bookmarks]({%slug radrichtextbox-features-document-elements-bookmarks%}) article.

* __Comments__ 
	RadRichTextBox offers the ability to add text to the document which is not inserted directly in the page. For more information, see the [Comments]({%slug radrichtextbox-features-comments%}) article.

* __Document protection__
	You can define editing restrictions in the document for a set of users and groups. For more information, see the [Document Protection]({%slug radrichtextbox-features-document-protection%}) article.

* __Mail merge__ 
	The control makes populating a template document with data easy. For more information, see the [Mail Merge]({%slug radrichtextbox-features-mail-merge%}) article.

* __Custom annotations__
	You can extend the document model in order to serve specific needs. For more information, see the [Annotations Overview]({%slug radrichtextbox-features-document-elements-annotations%}) article.

* __Footnotes and Endnotes__
	This feature is usually used to show the source of a material or add an explanation. For more information, see the [Footnotes and Endnotes]({%slug radrichtextbox-features-footnotes-endnotes%}) article.

* __Bibliographic references__
	This feature can be used for referencing a source in the form of text or pointing the source of a citation. For more information, see the [Bibliographic References]({%slug radrichtextbox-features-bibliographic-references%}) article.

* __Cross-references__
	References to a Heading, Caption or Bookmark can change along with their source. For more information, see the [Corss-Reference]({%slug radrichtextbox-features-cross-reference%}) article.

* __Captions for tables and figures__
	Images, tables, etc. can now be easily labeled. For more information, see the [Captions for Tables and Figures]({%slug radrichtextbox-features-captions-for-tables-and-figures%}) article.

* __Document variables__
	The control provides a mechanism used for storing information in the document. For more information, see the [Document Variables]({%slug radrichtextbox-features-document-variables%}) article.

* __Code blocks__
	This feature allows you to add source code fragments in a document. For more information, see the [Code Block]({%slug radrichtextbox-features-code-block%}) article.

## See Also
 * [Getting Started]({%slug radrichtextbox-getting-started%})
 * [Events]({%slug radrichtextbox-events-overview%})
 * [Styles and Templates]({%slug radrichtextbox-styles-and-tempaltes-overview%})
