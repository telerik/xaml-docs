---
title: HTML Support
page_title: HTML Support
description: HTML Support
slug: radrichtextbox-features-html-support
tags: html,support
published: True
position: 2
---

# HTML Support



A major requirement for providing rich text editing capabilities is support for HTML. The __RadRichTextBox__ control is designed to offer [import/export]({%slug radrichtextbox-features-import-export%}) functionality for __HTML__ out of the box – through the __HtmlFormatProvider__. However, as __HTML__ is a diverse and complicated standard, supporting it comes with certain limitations. __HtmlFormatProvider__ is designed to handle slightly malformed __HTML__ (missing closing tags, missing quotes around attributes), however in this case correct parsing cannot be guaranteed. For best results we recommend importing valid __XHTML__ content.

The purpose of this article is to outline which parts of the __HTML__ are supported.

## Importing

When the __HtmlFormatProvider__ imports an __HTML__ document, it parses it and converts the HTML element tree to [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%}). Importing is basically made up of two parts – content and styling.
        

## Content

HTML content is mapped to several types of __RadDocument__ elements – paragraphs, spans and tables.
        

Tags mapped to paragraphs are:
        

* __&lt;p&gt;__

* __&lt;h1&gt;__ through __&lt;h6&gt;__

* __&lt;ul&gt;, &lt;ol&gt;, &lt;li&gt;__

* __&lt;tr&gt;__

Tags generating table content:
        

* __&lt;table&gt;__

* __&lt;tr&gt;__

* __&lt;th&gt;__

* __&lt;td&gt;__

>The content of the __&lt;th&gt;__ tags will be bold, as they are treated as table headers.

Tags mapped to spans are:
        

• __formatting tags, &lt;span&gt;, &lt;font&gt;__

>Additionally, line breaks are inserted between consequent block elements (__&lt;div&gt;__).
          

## Styling

Styling is supported through CSS styles (classes or inline) and a number of formatting tags (including __&lt;font&gt;__). Although the __&lt;font&gt;__ tag has been deprecated, legacy software and markup requires support for it.
        

Supported formatting tags are:
        

* __&lt;b&gt;, &lt;strong&gt;__ – turn on bold

* __&lt;i&gt;, &lt;em&gt;__ – turn on italic

* __&lt;u&gt;__ – turn on underline

* __&lt;h1&gt;__ through &lt;h6&gt; – apply heading

* __&lt;sub&gt;__ – turn on subscript

* __&lt;sup&gt;__ – turn on superscript

Supported CSS properties are:
        

* __text-align__

* __margin-left__

* __margin-right__

* __color__

* __background-color__

* __font-family__

* __font-size__

* __font-style__

* __font-weight__

* __text-decoration (underline, line-through)__

* __vertical-align (sub, super)__

Supported __&lt;font&gt;__ tag attributes are:
        

* __face__ – equivalent to CSS property __font-family__

* __size__ – equivalent to CSS property __font-size__

* __color__ – equivalent to CSS property __color__

## Exporting

When exporting to __HTML__, the __HtmlFormatProvider__ iterates through the __RadDocument__ tree and generates __HTML__ nodes. It is designed to generate valid __XHTML__ document in order to preserve the formatting as much as possible. Styles are exported as CSS classes in the head of the document and used through the body. The structure of the __HTML__ document closely resembles that of __RadDocument__ – paragraphs and spans.

        
