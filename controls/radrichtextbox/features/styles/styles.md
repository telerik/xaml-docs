---
title: Styles
page_title: Styles
description: Styles
slug: radrichtextbox-features-styles
tags: styles
published: True
position: 0
---

# Styles



__RadRichTextBox__ supports Styles similar to the ones in Microsoft Office.
      

Styles can be created and added to a document programmatically or via the __Styles__ dialog.
        In addition, styles can be instantiated from a docx or XAML document on import, to provide for a consistent look of the document and richer editing capabilities.
      

This topic covers:

* [Style Definition Overview](#styledefinition-overview)

* [Types Of Styles](#types-of-styles)

* [Declaring New Styles](#declaring-new-styles)

* [Applying a Style](#applying-a-style)

* [Default Styles](#default-styles)

* [Style Evaluation](#style-evaluation)

## StyleDefinition Overview

The class that contains the logic behind the styles feature is __StyleDefinition__.
        

Each __StyleDefinition__ has the following properties:
        

* __Name__ - the name of the style. All styles in a document have a unique name, which is used as an identifier when applying the style.
            

* __DisplayName__ - a name that will be shown in the UI.
            

* __Type__ - specifies which document elements the style will target, e.g. a Paragraph, a Table, a Span.
            

* __BasedOn__ - specifies that the current style inherits the StyleDefinition set to this property.
              This is how hierarchical Styles can be defined.
            

* __BasedOnName__ - the same as above, the only difference being in the way the style is set - using its Name.
            

* __LinkedStyle__ - provides a relation between a Paragraph and Character style.
            

## Types of Styles

The style types that are most commonly used are Character styles and styles for Paragraph. 

The former styles set values for the properties of Span, such as FontSize, ForeColor and FontWeight.
          These values are contained in the __SpanProperties__ of the style.
          When such a style is applied to a document, it changes the formatting of the text in the selection or (if there is no selection) the formatting of the word that the Caret is positioned in.
        

Paragraph Styles include properties of a Paragraph, such as Background, TextAlignment, LineSpacing, SpacingAfter, etc.
          The values of these properties are kept in the __ParagraphProperties__ of the StyleDefinition object.
          This type of styles can also contain values of Character styles in the __SpanProperties__ property.
          When applied, the values of the ParagraphProperties will be applied to the Paragraphs and the values of the SpanProperties - to all Spans in these Paragraphs.
        

You can have a Paragraph style linked to a Character style using the __LinkedStyle__ property.
          In this way, you can apply Paragraph and Span properties at the same time. The difference between this case and the Paragraph Styles that also set SpanProperties is the way they are applied.
          With linked styles, if you have selection which includes text in only one Paragraph the Paragraph Style is not applied.
          In that case, the Character style is applied only on the selected part of the document.
        

Table styles include properties of Table, such as Borders and Background. They are contained in the __TableProperties__ of the style.When such style is applied to a document, it changes the formatting of the tables.
        

## Declaring New Styles

New Styles can be declared and added to the StylesRepository of the document. In this way they will be discovered by the default UI and could be applied to parts of the document.

### Declaring a Character Style

This is how a Character style can be defined and registered:

#### __C#__

{{region radrichtextbox-features-styles_0}}
	StyleDefinition charStyle = new StyleDefinition();
	charStyle.Type = StyleType.Character;
	charStyle.SpanProperties.FontFamily = new FontFamily("Calibri");
	charStyle.SpanProperties.FontSize = Unit.PointToDip(20);
	charStyle.SpanProperties.ForeColor = Colors.Orange;
	charStyle.DisplayName = "charStyle";
	charStyle.Name = "charStyle";
	
	this.editor.Document.StyleRepository.Add(charStyle);
	{{endregion}}



This style will set "Calibri" as a FontFamily to the part of the document it is applied to, 20 dip as a FontSize and Orange as a ForeColor.

### Declaring a Paragraph Style

A paragraph style can be defined as follows:

#### __C#__

{{region radrichtextbox-features-styles_1}}
	StyleDefinition paragraphStyle = new StyleDefinition();
	paragraphStyle.Type = StyleType.Paragraph;
	paragraphStyle.ParagraphProperties.Background = Colors.Red;
	paragraphStyle.ParagraphProperties.TextAlignment = RadTextAlignment.Center;
	paragraphStyle.DisplayName = "paragraphStyle";
	paragraphStyle.Name = "paragraphStyle";
	
	this.editor.Document.StyleRepository.Add(paragraphStyle);
	{{endregion}}



When applied to a Paragraph, this style will set the Background color of the Paragraph to Red and the TextAlignment to Center.

### Declaring a Linked Style

Linked styles should be used when both properties of Paragraph and Span should be set by the same style. They can be declared like this:

#### __C#__

{{region radrichtextbox-features-styles_2}}
	StyleDefinition linkedParagraphStyle = new StyleDefinition();
	linkedParagraphStyle.Type = StyleType.Paragraph;
	linkedParagraphStyle.ParagraphProperties.Background = Colors.Yellow;
	linkedParagraphStyle.DisplayName = "linkedParagraphStyle";
	linkedParagraphStyle.Name = "linkedParagraphStyle";
	
	StyleDefinition linkedCharStyle = new StyleDefinition();
	linkedCharStyle.Type = StyleType.Character;
	linkedCharStyle.SpanProperties.FontWeight = FontWeights.Bold;
	linkedCharStyle.SpanProperties.FontSize = Unit.PointToDip(30);
	linkedCharStyle.SpanProperties.ForeColor = Colors.Purple;
	linkedCharStyle.DisplayName = "linkedCharStyle";
	linkedCharStyle.Name = "linkedCharStyle";
	linkedParagraphStyle.LinkedStyle = linkedCharStyle;
	
	this.editor.Document.StyleRepository.Add(linkedParagraphStyle);
	this.editor.Document.StyleRepository.Add(linkedCharStyle);
	{{endregion}}



>Only styles of type __Paragraph__ and __Character__ can be linked.
              

## Applying a Style

Styles are applied using the __ChangeStyleName__ method of __RadRichTextBox__ or the __ChangeStyleNameCommand__.
          In both cases, the parameter that has to be passed is the __Name__ of the StyleDefinition.
        

Styles of type Character get applied to the currently selected part of the document. If there is no selection, the values that will be changed are those of the word that the Caret is positioned in.

Styles of type Paragraph follow the same logic and are applied to all paragraphs in the selection or the current paragprah. 

For example, the following line will apply the "linkedParagraphStyle" to the current Paragraph and the parts of the text which are selected:

#### __C#__

{{region radrichtextbox-features-styles_3}}
	this.editor.ChangeStyleName("linkedParagraphStyle");
	{{endregion}}



Styles of type LinkedStyle change the values of the paragraph when there is no selection and apply both their Paragraph and Span properties. When there is selection, LinkedStyle changes only the Span properties of the selected text.

## Default Styles

The default style for span and paragraph properties is __Normal__. It internally inherits the default style of the document located in __RadDocument.Style__

>The document's default style is only for the current instance of the document and if you create a new document, those settings will not be copied. For this purpose you can use the __DocumentInheritsDefaultStyleSettings__ property of __RadRichTextBox__. When set to true it will copy each property you set in __RadRichTextBox.DefaultStyleSettings__ to newly created documents. You can find more information on setting default style setings on the document     [here](76CD496F-6D98-49E5-A700-F5B9AE4CEECE#Setting_Default_Style_Settings_on_the_Document)

The default style for table properties is __TableNormal__, which does not inherit any other styles. It has an inheritor - __TableGrid__, which contains predefined borders and is the one applied when inserting a table from the UI of __RadRichTextBox__.
        

All default styles as well as some other predefined styles can be applied using the members exposed by the __RadDocumentDefaultStyles__
          class. The set of properties provided by the class are of type *string* and should be applied using the __StyleName__
          property of the respective document element.
        

For example the __TableGrid__ style can be applied to a table as follows:
        

#### __C#__

{{region radrichtextbox-features-styles_4}}
	table.StyleName = RadDocumentDefaultStyles.DefaultTableGridStyleName;
	{{endregion}}



And a paragraph can have __Heading 1__ style applied to it like this:
        

#### __C#__

{{region radrichtextbox-features-styles_5}}
	paragraph.StyleName = RadDocumentDefaultStyles.GetHeadingStyleNameByIndex(1);
	{{endregion}}



## Style Evaluation

Each style first checks its local value for the property that is being evaluated and then turns to its base style. If no local value is found, it turns to its default style. If no local value is found, the evaluation system turns to the default style of the document. 

Here is how style properties for different styles are inherited: Span style

Span styles can only be based on other span styles.  The inheritance is as follows:

* Span properties are inherited from the base span style.Paragraph style

Paragraph styles can be based on other paragraph styles or on linked styles.

* When a paragraph style is based on another paragraph style the inheritance of the properties is as follows:

* Paragraph properties are inherited from the base paragraph style.

* Span properties are inherited from the base paragraph style.

* When a paragraph style is based on a linked style the inheritance of the properties is as follows:

* Paragraph properties are inherited from the paragraph style part in its base linked style.

* Span properties are inherited from the span style part in its base linked style.Linked style

Linked styles are composite styles and their components are a paragraph and a span style with link between them.  When paragraph properties need to be applied they are taken from the linked paragraph style and accordingly when span properties need to be applied they are taken from the linked span style.

Linked styles can be based on other linked styles or on paragraph styles.

* When a linked style is based on a paragraph style the inheritance of the properties is as follows:

* Paragraph properties are inherited from the base paragraph style.

* Span properties are inherited from the base paragraph style.

* When a linked style is based on another linked style the inheritance of the properties is as follows:

* Paragraph properties are inherited from the paragraph style part in its base linked style.

* Span properties are inherited from the span style part in its base linked style.Table style

Table styles can only be based on other table styles. The inheritance is as follows:

* Span properties are inherited from the base table style.

* Paragraph properties are inherited from the base table style.

* Table cell properties are inherited from the base table style.

* Table properties are inherited from the base table style.
