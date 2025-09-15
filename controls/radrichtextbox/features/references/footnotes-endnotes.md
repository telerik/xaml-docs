---
title: Footnotes and Endnotes
page_title: Footnotes and Endnotes
description: Check our &quot;Footnotes and Endnotes&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-footnotes-endnotes
tags: footnotes,and,endnotes
published: True
position: 0
---

# Footnotes and Endnotes

Footnotes and endnotes (or just notes) are used in documents and books to show the source of borrowed material or to enter explanatory or supplementary information. Footnotes are positioned at the bottom of a page, containing the annotated text, and endnotes are placed at the end of a document or the section.

This topic will explain:

* [Note options](#note-options)

* [Creating and Inserting](#creating-and-inserting)

* [Navigating and Scrolling](#navigating-and-scrolling)

## Note options

There are various properties that control how notes are positioned and visualized in the document. All of these properties can be applied on the whole document and some of them (concerning the note numbering) can also be applied on sections individually.


### Footnote options

Here is the list of the available properties concerning footnotes:

* __FootnotesNumberingFormat__ - Gets or sets the footnotes numbering format.

* __FootnotesFirstNumber__ - Gets or sets the footnotes starting number.

* __FootnotesNumberingRestartType__ - Represents the type of the footnotes numbering restart. The available types are :

    * __Continuous__ - numbering is never restarted.

    * __EachPage__ - numbering is restarted on each page.

    * __EachSection__ - numbering is restarted on each section.

* __FootnotesPosition__ - __PageBottom__ is the only available option.


### Endnote options

Here is the list of the available properties concerning endnotes:

* __EndnotesNumberingFormat__ - Gets or sets the endnotes numbering format.

* __EndnotesFirstNumber__ - Gets or sets the endnotes starting number.

* __EndnotesNumberingRestartType__ - Represents the type of the endnotes numbering restart. The available types are :

    * __Continuous__ - same numbering is used for all endnotes in the document.

    * __EachSection__ - numbering is restarted on each section.

* __EndnotesPosition__ - Available options are:
 
    * __DocumentEnd__ - all endnotes are shown at the end of the document.

    * __SectionEnd__ - there is a list of endnotes for each section.
		        			

## Creating and Inserting

Footnotes and endnotes all contain the __Note__ class which defines the note body and weather a special symbol should be used when visualizing the note in the document. Notes can be inserted in __RadRichtextBox__ using the following methods:

#### __C#__

```C#
	public void InsertFootnote()
	public void InsertFootnote(Note footnote)
	public void InsertEndnote()
	public void InsertEndnote(Note endnote)
```



There is a set of document styles that are used inside notes content. It is recommended that when a note is created by code, these styles are used in the note body, so the document styling is persistent. There are some static helper methods that make the task of creating notes, that have the necessary styles applied, easier:

#### __C#__

```C#
	public static Note CreateCustomMarkFootnote(string symbol, FontFamily fontFamily = null)
	public static Note CreateCustomMarkEndnote(string symbol, FontFamily fontFamily = null)
	public static Note CreateDefaultFootnote()
	public static Note CreateDefaultEndnote()
```


Here is for example how to insert a footnote with a custom mark – dollar sign with Calibri font:

#### __C#__

```C#
	Note note = Note.CreateCustomMarkFootnote("$", new FontFamily("Calibri"));
	this.radRichtextBox.InsertFootnote(note);
```


## Navigating and Scrolling

You can programmatically navigate the document caret position through the notes in the document using the following methods of the __RadRichtextBox__:

#### __C#__

```C#
	public void GoToNextFootnote()
	public void GoToPreviousFootnote()
	public void GoToNextEndnote()
	public void GoToPreviousEndnote()
```



You can use the __ScrollToNote()__ method to scroll the viewport so that a note content is visible. A reference to the note object can be obtained through the __FootnoteRangeStart__ and __EndnoteRangeStart__ annotations. These annotations are contained inside the document and mark the beginning of the note symbol that acts like a reference to the note. Here is an example of how to scroll to the content of the first endnote in the document:

#### __C#__

```C#
	EndnoteRangeStart noteRangeStart = this.radRichtextBox.Document.EnumerateChildrenOfType<EndnoteRangeStart>().FirstOrDefault();
	
	if (noteRangeStart != null)
	{ 
	    this.radRichtextBox.ScrollToNote(noteRangeStart.Note);
	}
```


