---
title: Document Ruler
page_title: Document Ruler
description: Check our &quot;Document Ruler&quot; documentation article for the RadRichTextBox control.
slug: radrichtextbox-features-document-ruler
tags: document ruler, ruler, richtextbox, document editor, editor
published: True
---

# Document Ruler

The `DocumentRuler` element allows you to visualize a guide that will assist you in aligning text, tables, graphics, and other elements via the thumbs of the horizontal and vertical rulers. To display the document ruler, wrap it around a `RadRichTextBox` instance.

__Displaying the DocumentRuler__
<snippet id='radrichtextbox-features-document-ruler-block_1-xaml' />

__RadRichTextBox with DocumentRuler__

![RadRichTextBox with DocumentRuler](images/radrichtextbox-features-document-ruler-0.png)

## Customizing the Appearance of the Document Ruler

The DocumentRuler object derives from the `DocumentRulerBase` class, which exposes the following API for customizing the appearance:

* `ThumbBackgroundStyle`&mdash;This property provides the functionality to set a `Style` for the background thumbs.
* `VerticalThumbStyle`&mdash;Gets or sets a `Style` the vertical thumb.
* `HorizontalThumbStyle`&mdash;Gets or sets a `Style` for the horizontal thumb.
* `MarkersBrush`&mdash;Allows you to specify a value of the type of `Brush` for the markers of the vertical and horizontal rulers.
* `MeasurementUnit`&mdash;Allows you to specify the unit used for measurement. The property is of the type of `UnitTypes` and provides the following options:
  * `DIP`   
  * `Point`
  * `Pica`
  * `Inch`
  * `Mm`
  * `Cm`
  * `Twip`
* `SectionColumnThumbStyle`&mdash;This property provides the functionality to specify a style for the section column thumb.
* `TableColumnThumbStyle`&mdash;This property allows you to specify a style for the table column thumb.
* `DefaultRulerThumbType`&mdash;This property provides you with the ability to set a style for the default ruler thumb.

__Customizing the Appearance of the Document Ruler__
<snippet id='radrichtextbox-features-document-ruler-block_2-xaml' />

__Customized appearance of the DocumentRuler element__

![Customized appearance of the DocumentRuler element](images/radrichtextbox-features-document-ruler-1.png)

## Hiding Vertical/Horizontal Ruler of the Document Ruler

You can change the visibility of the vertical/horizontal ruler of the DocumentRuler control. To do so, you can utilize its `CreateHorizontalRuler` and `CreateVerticalRuler` properties. These properties will be taken into account if the DocumentRuler instance has been loaded.

__Hiding the vertical ruler of the DocumentRuler__
<snippet id='radrichtextbox-features-document-ruler-block_3-cs' />

__DocumentRuler with hidden vertical ruler__

![DocumentRuler with hidden vertical ruler](images/radrichtextbox-features-document-ruler-2.png)

## Read-Only Support

The DocumentRuler control exposes the `IsReadOnly` property. You can use it to prevent/allow the user to make changes to the document via the vertical and horizontal rulers. This property will be taken into account if the DocumentRuler control has been loaded.

__Setting the IsReadOnly property__
<snippet id='radrichtextbox-features-document-ruler-block_4-cs' />

## Customizing the Behavior of the DocumentRuler

You can customize the DocumentRuler's behavior by providing a custom implementation for the [IDocumentRulerController](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.richtextboxui.idocumentrulercontroller) interface to the `Controller` property. You can either create your own implementation of this interface or extend the default [RadRichTextBoxRulerController](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.richtextboxui.radrichtextboxrulercontroller) class.

## See Also
* [TabStop]({%slug radrichtextbox-features-raddocumenteditor%}#raddocumenteditor-methods)
* [Section Columns]({%slug radrichtextbox-features-section-columns%})