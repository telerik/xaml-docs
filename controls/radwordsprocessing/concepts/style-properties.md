---
title: Style Properties
page_title: Style Properties
description: Style Properties
slug: radwordsprocessing-concepts-style-properties
tags: style,properties
published: True
position: 5
---

# Style Properties



__Style property__ is part of the style system, used to hold information about a formatting value of the document elements. It can be used to check if the value is local or it is inherited from base style. Information about how the style system works and how values are inherited from base styles can be found in the Style Evaluation and Inheritance section of the [Styles]({%slug radwordsprocessing-concepts-styles%}) article.
      

* [Style Property Implementation Overview](#style-property-implementation-overview)

* [Style Property Definitions](#style-property-definitions)

* [Using Style Properties](#using-style-properties)

* [Style Properties Default Values](#style-properties-default-values)

## Style Property Implementation Overview

Style properties are exposed through [IStyleProperty<T>]( http://www.telerik.com/help/wpf/t_telerik_windows_documents_flow_model_styles_core_istyleproperty.html ) interface, which contains the following properties and methods:
        

* __LocalValue__: Used to get or set the local value. If it is not set, the value is __null__.
            

* __HasLocalValue__: Returns value indicating whether the style property has local value.
            

* __GetActualValue()__: Returns the actual value of the property. This value is evaluated on every call by the style system using the evaluation rules described [Styles]({%slug radwordsprocessing-concepts-styles%}).
            

* __ClearValue()__: Clears the local value.
            

* __PropertyDefinition__: The [property definition](#style-property-definitions) is exposed through the [IStylePropertyDefinition]( http://www.telerik.com/help/wpf/t_telerik_windows_documents_flow_model_styles_core_istylepropertydefinition.html) interface and specifies some details for the style property as:
            

    * __PropertyName__: Returns the name of the style property.
                

    * __StylePropertyType__: Returns the type of the style property.
                

    * __Validation__: Used to determine if a value is valid for this style property.
                

    * __GetDefaultValueAsObject()__: This method returns the default value as object.
                

Some of the style properties always contain local value and are normally referred to as local style properties. They are used only by the document elements and their values are not respected by styles and style inheritance .
        

## Style Property Definitions

Style property definition is represented from the __StylePropertyDefinition<T>__ class and can be accessed from the style property itself (through its base interface __IStylePropertyDefinition__) or as a static member of [Run]({%slug radwordsprocessing-model-run%}), [Paragraph]({%slug radwordsprocessing-model-paragraph%}), [Table]({%slug radwordsprocessing-model-table%}), [TableRow]({%slug radwordsprocessing-model-tablerow%}) and [TableCell]({%slug radwordsprocessing-model-tablecell%}) document elements. Style property definitions specify the following details of the style property:
        

* __PropertyName__: Specifies the name of the style property.
            

* __DefaultValue__: Specifies the default value of the style property.
            

* __StylePropertyType__: Specifies the type of the style property as [StylePropertyType](http://www.telerik.com/help/wpf/t_telerik_windows_documents_flow_model_styles_core_stylepropertytype.html) enumeration.
            

* __Validation__: Used to determine if a value is valid for the style property associated with this style property definition.
            

## Using Style Properties

### Style properties in document elements

Document elements expose sets of style properties through the __Properties__ property. For convenience style properties can be also used through CLR shorthand properties exposed directly from the document elements. Shorthand property getter gets the *actual value* of the property, while property setter sets the *local* value of the property.
            

Here is example for equivalent getting of a value with CLR property and style property:
            

#### __C#__

{{region radwordsprocessing-concepts-style-properties_0}}
    bool keepOnOnePageActualValueShorthand = paragraph.KeepOnOnePage;
    bool keepOnOnePageActualValue = paragraph.Properties.KeepOnOnePage.GetActualValue().Value;
{{endregion}}



Here is example for equivalent setting of a value with CLR property and style property:
            

#### __C#__

{{region radwordsprocessing-concepts-style-properties_1}}
    paragraph.KeepOnOnePage = true;
    paragraph.Properties.KeepOnOnePage.LocalValue = true;
{{endregion}}



### Style properties in styles

The style properties in a style are accessible through the following property sets: __CharacterProperties__, __ParagraphProperties__, __TableProperties__, __TableRowProperties__ and __TableCellProperties__.
            

Here is a code snippet illustrating how to get the local value of a style property in style:
            

#### __C#__

{{region radwordsprocessing-concepts-style-properties_2}}
	            bool? keepOnOnePage = style.ParagraphProperties.KeepOnOnePage.LocalValue;
	{{endregion}}



Here is a code snippet illustrating how to get the actual value of style property in style:
            

#### __C#__

{{region radwordsprocessing-concepts-style-properties_3}}
    bool keepOnOnePage = style.ParagraphProperties.KeepOnOnePage.GetActualValue().Value;
{{endregion}}



## Style Properties Default Values

The default values of all style properties are available in their [StylePropertyDefinitions](Style_Property_Definitions) and cannot be changed. To set the default values of properties for particular document you can change the default styles for the document.
        

The following code snippet illustrates how to get the default value for a style property:
        

#### __C#__

{{region radwordsprocessing-concepts-style-properties_4}}
    bool keepOnOnePageDefaultValue = Paragraph.KeepOnOnePagePropertyDefinition.DefaultValue.Value;
{{endregion}}



Following is a list of all available style properties and their default values:
        
<table><tr><th>

Name</th><th>

Description</th><th>

Default Value</th></tr><tr><td>

<b>CharacterProperties</b></td><td></td><td></td></tr><tr><td>

FontFamily</td><td>

The font family.</td><td>

Verdana</td></tr><tr><td>

FontSize</td><td>

The size of the font.</td><td>

13.3333333333333</td></tr><tr><td>

FontStyle</td><td>

The font style.</td><td>

Normal</td></tr><tr><td>

FontWeight</td><td>

The font weight.</td><td>

Normal</td></tr><tr><td>

ForegroundColor</td><td>

The foreground color.</td><td>

Black</td></tr><tr><td>

HighlightColor</td><td>

The color of the highlight.</td><td>

Transparent</td></tr><tr><td>

BaselineAlignment</td><td>

The baseline alignment.</td><td>

Baseline</td></tr><tr><td>

Strikethrough</td><td>

The strikethrough.</td><td>

False</td></tr><tr><td>

BackgroundColor</td><td>

The color of the background.</td><td>

Transparent</td></tr><tr><td>

ShadingPatternColor</td><td>

A value indicating the color for any foreground pattern used in this shading.</td><td>

Transparent</td></tr><tr><td>

ShadingPattern</td><td>

A value indicating the pattern which shall be used to lay the pattern color over the background color for this shading.</td><td>

Clear</td></tr><tr><td>

UnderlineColor</td><td>

The color for the underlining.</td><td>

Transparent</td></tr><tr><td>

UnderlinePattern</td><td>

A value indicating the pattern which shall be used to create the underlining applied beneath the text.</td><td>

None</td></tr><tr><td>

<b>ParagraphProperties</b></td><td></td><td></td></tr><tr><td>

FlowDirection</td><td>

The flow direction.</td><td>

LeftToRight</td></tr><tr><td>

TextAlignment</td><td>

The paragraph text alignment.</td><td>

Left</td></tr><tr><td>

SpacingBefore</td><td>

The spacing that should be added above the first line in a paragraph.</td><td>

0</td></tr><tr><td>

AutomaticSpacingBefore</td><td>

A value indicating whether a consumer shall automatically determine the spacing
                before the paragraph based on its contents the automatic spacing after.
              </td><td>

False</td></tr><tr><td>

SpacingAfter</td><td>

The spacing that should be added after the last line in a paragraph.</td><td>

0</td></tr><tr><td>

AutomaticSpacingAfter</td><td>

A value indicating whether a consumer shall automatically determine the spacing
                after the paragraph based on its contents the automatic spacing after.
              </td><td>

False</td></tr><tr><td>

LineSpacing</td><td>

The value indicating the amount of vertical spacing between lines of text within a paragraph.</td><td>

1.15</td></tr><tr><td>

LineSpacingType</td><td>

The value indicating how the spacing between lines is calculated.</td><td>

Auto</td></tr><tr><td>

KeepOnOnePage</td><td>

A value indicating if this paragraph should be rendered on one page when the document is shown in page view mode.</td><td>

False</td></tr><tr><td>

KeepWithNextParagraph</td><td>

A value indicating if this paragraph should be rendered at least partly on the one page with
                the following paragraph when this is possible and when the document is shown in page view mode.
              </td><td>

False</td></tr><tr><td>

OutlineLevel</td><td>

A value indicating the outline level. The outline level defines the level of this paragraph in TOC field.</td><td>

None</td></tr><tr><td>

ApplyEastAsianLineBreakingRules</td><td>

A value indicating whether East-Asian line breaking rules are applied to this paragraph.</td><td>

True</td></tr><tr><td>

PageBreakBefore</td><td>

A value indicating if this paragraph should be rendered on new page when the document is shown in page view mode.</td><td>

False</td></tr><tr><td>

Borders</td><td>

The paragraph borders.</td><td>

None</td></tr><tr><td>

ContextualSpacing</td><td>

A value indicating whether spacing before/after are ignored
                when preceding/following paragraph has same paragraph style.
              </td><td>

False</td></tr><tr><td>

MirrorIndents</td><td>

A value indicating whether left and right indents should be swapped on odd pages.</td><td>

False</td></tr><tr><td>

BackgroundColor</td><td>

The color of the background.</td><td>

Transparent</td></tr><tr><td>

ShadingPatternColor</td><td>

A value indicating the color for any foreground pattern used in this shading.</td><td>

Transparent</td></tr><tr><td>

ShadingPattern</td><td>

A value indicating the pattern which shall be used to lay the pattern color over the background color for this shading.</td><td>

Clear</td></tr><tr><td>

FirstLineIndent</td><td>

A value indicating the additional indentation which shall be applied to the first line of the paragraph.</td><td>

0</td></tr><tr><td>

HangingIndent</td><td>

A value which shall be removed from the indentation of the first line of the paragraph, by moving the indentation on the first line back towards the beginning of the direction of text flow. </td><td>

0</td></tr><tr><td>

LeftIndent</td><td>

A value indicating the indentation which shall be applied to the left side of the whole paragraph.</td><td>

0</td></tr><tr><td>

RightIndent</td><td>

A value indicating the indentation which shall be applied to the right side of the whole paragraph.</td><td>

0</td></tr><tr><td>

AllowOverflowPunctuation</td><td>

A value indicating whether the last punctuation character on a line can overflow in paragraph margin/indent.</td><td>

True</td></tr><tr><td>

<b>TableProperties</b></td><td></td><td></td></tr><tr><td>

Alignment</td><td>

The alignment of the table.</td><td>

Left</td></tr><tr><td>

BackgroundColor</td><td>

The color of the background.</td><td>

Transparent</td></tr><tr><td>

ShadingPatternColor</td><td>

A value indicating the color for any foreground pattern used in this shading.</td><td>

Transparent</td></tr><tr><td>

ShadingPattern</td><td>

A value indicating the pattern which shall be used to lay the pattern color over the background color for this shading.</td><td>

Clear</td></tr><tr><td>

Borders</td><td>

The table borders.</td><td>

None</td></tr><tr><td>

TableCellPadding</td><td>

Default padding of the cells inside the table.</td><td>

0, 0, 0, 0</td></tr><tr><td>

TableCellSpacing</td><td>

A value indicating the spacing between adjacent cells and the edges of the table.</td><td>

0</td></tr><tr><td>

Indent</td><td>

A value which shall be added before the leading edge of the table.</td><td>

0</td></tr><tr><td>

RowBanding</td><td>

The number of banded rows.</td><td>

0</td></tr><tr><td>

ColumnBanding</td><td>

The number of banded columns.</td><td>

0</td></tr><tr><td>

FlowDirection</td><td>

The flow direction of cells inside the table.</td><td>

LeftToRight</td></tr><tr><td>

PreferredWidth</td><td>

The preferred width.</td><td>

Auto</td></tr><tr><td>

Looks</td><td>

The value indicating which components of the conditional style should be applied if such exists.</td><td>

BandedRows, BandedColumns</td></tr><tr><td>

LayoutType</td><td>

A value indicating which algorithm shall be used to lay out the content of the table.</td><td>

AutoFit</td></tr><tr><td>

Overlap</td><td>

A value indicating whether this floating table shall allow other floating tables to overlap its extents.</td><td>

True</td></tr><tr><td>

<b>TableRowProperties</b></td><td></td><td></td></tr><tr><td>

TableCellSpacing</td><td>

A value indicating the spacing between adjacent cells and the edges of the table.</td><td>

0</td></tr><tr><td>

RepeatOnEveryPage</td><td>

A value indicating whether this row should be repeated on every new page.</td><td>

False</td></tr><tr><td>

CanSplit</td><td>

A value indicating whether the content of the row can be split across multiple pages.</td><td>

True</td></tr><tr><td>

Height</td><td>

The height.</td><td>

Auto</td></tr><tr><td>

<b>TableCellProperties</b></td><td></td><td></td></tr><tr><td>

Borders</td><td>

The borders.</td><td>

None</td></tr><tr><td>

BackgroundColor</td><td>

The color of the background.</td><td>

Transparent</td></tr><tr><td>

ShadingPatternColor</td><td>

A value indicating the color for any foreground pattern used in this shading.</td><td>

Transparent</td></tr><tr><td>

ShadingPattern</td><td>

A value indicating the pattern which shall be used to lay the pattern color over the background color for this shading.</td><td>

Clear</td></tr><tr><td>

Padding</td><td>

The padding.</td><td>

0, 0, 0, 0</td></tr><tr><td>

ColumnSpan</td><td>

The column span.</td><td>

1</td></tr><tr><td>

RowSpan</td><td>

The row span.</td><td>

1</td></tr><tr><td>

IgnoreCellMarkerInRowHeightCalculation</td><td>

A value indicating whether cell marker will be ignored when row height is calculated.</td><td>

False</td></tr><tr><td>

CanWrapContent</td><td>

A value indicating whether the content can be wrapped during the table layout.</td><td>

True</td></tr><tr><td>

PreferredWidth</td><td>

The preferred width.</td><td>

Auto</td></tr><tr><td>

VerticalAlignment</td><td>

The vertical alignment.</td><td>

Top</td></tr><tr><td>

<b>SectionProperties</b></td><td></td><td></td></tr><tr><td>

HasDifferentFirstPageHeaderFooter</td><td>

Has different first page header footer.</td><td>

False</td></tr><tr><td>

PageOrientation</td><td>

Page orientation property.</td><td>

Portrait</td></tr><tr><td>

PageSize</td><td>

Page size property.</td><td>

816,1056</td></tr><tr><td>

PageMargins</td><td>

Page margins property.</td><td>

96, 96, 96, 96</td></tr><tr><td>

HeaderTopMargin</td><td>

Header top margin property.</td><td>

48</td></tr><tr><td>

FooterBottomMargin</td><td>

Footer bottom margin property.</td><td>

48</td></tr><tr><td>

SectionType</td><td>

Section type property.</td><td>

NextPage</td></tr><tr><td>

<b>DocumentProperties</b></td><td></td><td></td></tr><tr><td>

HasDifferentEvenOddPageHeadersFooters</td><td>

A value indicating whether pages in this document will have different headers and footers for even and odd pages.</td><td>

False</td></tr><tr><td>

ViewType</td><td>

A value indicating the view type of the document.</td><td>

PrintLayout</td></tr></table>

# See Also

 * [Styles]({%slug radwordsprocessing-concepts-styles%})
 * [IStyleProperty<T> API Reference](http://www.telerik.com/help/wpf/t_telerik_windows_documents_flow_model_styles_core_istyleproperty.html)
 * [IStylePropertyDefinition API Reference](http://www.telerik.com/help/wpf/t_telerik_windows_documents_flow_model_styles_core_istylepropertydefinition.html)
