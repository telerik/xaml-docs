---
title: UI Layers
page_title: UI Layers
description: Check our &quot;UI Layers&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-ui-layers
tags: ui, layer, visualization
published: True
---

# UI Layers

RadRichTextBox uses separate layers to render the different parts of a document. This topic describes which layers are used and the parts they are responsible to visualize.

## Default Layers

The default layers provide the default visual representation of the elements they support. **Table 1** lists all the layers used in RadRichTextBox with information about the part they are responsible for.

#### Table 1: UI layers in RadRichTextBox

| Position | Class                                | Layer Name                     | Description                                                                                                                                       |
|----------|--------------------------------------|--------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------|
| 1        | PagesUILayer                         | PagesLayer                     | Generates the page area with the size specified in the section properies.                                                                         |
| 2        | HeaderFooterLayer                    | HeaderFooterLayer              | Responsible to render the header and footer areas of the page.                                                                                    |
| 3        | WatermarkUILayer                     | WatermarkLayer                 | Renders the watermarks on a page.                                                                                                                 |
| 4        | BackgroundsUILayer                   | BackgroundsLayer               | Renders the background of Table, TableCell and Paragraph elements.                                                                                |
| 5        | FloatingBlocksUILayer                | FloatingBlocksBackLayer        | Visualizes the floating elements in a document that should be rendered below the other contents.                                                  |
| 6        | RevisionChangedLinesDecoration       | RevisionChangedLinesDecoration | Adds decorations for the modified inline content when using Track Changes.                                                                        |
| 7        | TableRevisionRangesDecoration        | TableRevisionRangesDecoration  | Adds decorations for the modified Table elements when using Track Changes.                                                                        |
| 8        | HighlightingFieldsDecorationUILayer  | HighlightFieldsDecoration      | Renders highlight on the fields inside a document when RadRichTextBox.FieldShadingMode is different than Never.                                   |
| 9        | HighlightingTextDecorationUILayer    | HighlightDecoration            | Visualizes the highlight of a Span, if such is applied.                                                                                           |
| 10       | StrikethroughTextDecorationUILayer   | StrikethroughDecoration        | Visualizes the strikethrough of a Span, if such is applied.                                                                                       |
| 11       | ProofingErrorsDecorationUILayer      | ProofingErrorsDecoration       | Shows the marks for misspelled words.                                                                                                             |
| 12       | UnderlineTextDecorationUILayer       | UnderlineDecoration            | Renders the underline of text, if such is applied.                                                                                                |
| 13       | DocumentListDecoration               | DocumentListDecoration         | Takes care of rendering the bullets and numberings for lists.                                                                                     |
| 14       | BordersUILayer                       | BordersDecoration              | Responsible for rendering the table borders.                                                                                                      |
| 15       | AnchorFloatingBlockDecorationUILayer | FloatingBlockAnchorDecoration  | Renders the anchor of the floating blocks.                                                                                                        |
| 16       | FormattingSymbolsUILayer             | FormattingSymbolsLayer         | Shows the formatting symbols.                                                                                                                     |
| 17       | TabLeaderUILayer                     | TabLeaderUILayer               | Generates the UI for the tab leaders.                                                                                                             |
| 19       | LineDocumentUILayer                  | LinesDocumentLayer             | Renders the lines of text content.                                                                                                                |
| 20       | SectionColumnsSeparatorLayer         | SectionColumnsSeparatorLayer   | Draws the separator between two section columns.                                                                                                  |
| 21       | RevisionsToolTipLayer                | ToolTipLayer                   | Shows a tooltip with information about a specific revision.                                                                                       |
| 22       | NotesTooltipLayer                    | NotesTooltipLayer              | Creates UI for the tooltips of footnotes and endnotes in a document.                                                                              |
| 23       | HyperlinksUILayer                    | HyperlinksLayer                | Takes care of presenting the hyperlinks.                                                                                                          |
| 24       | ImagesUILayer                        | ImagesLayer                    | Renders images.                                                                                                                                   |
| 25       | UIContainerUILayer                   | UIContainerLayer               | Takes care for the rendering of UIContainer elements.                                                                                             |
| 26       | NotesSeparatorLayer                  | NotesSeparatorLayer            | Shows the separator line between footnotes and endnotes.                                                                                          |
| 27       | FootnotesUILayer                     | FootnotesLayer                 | Renders the footnotes.                                                                                                                            |
| 28       | EndnotesUILayer                      | EndnotesLayer                  | Renders the endnotes.                                                                                                                             |
| 29       | FloatingBlocksUILayer                | FloatingBlocksFrontLayer       | Creates the UI for the floating blocks that should be rendered on top of the other content.                                                       |
| 30       | TableColumnBordersResizeLayer        | TableColumnBordersResizeLayer  | Creates the UI that enable the users to resize columns of a table.                                                                                |
| 31       | TableRowBordersResizeLayer           | TableRowBordersResizeLayer     | Creates the UI that enable the users to resize rows of a table.                                                                                   |
| 32       | CommentsUILayer                      | CommentsLayer                  | Visualizes the comments inside a document.                                                                                                        |
| 33       | AdornerLayer                         | AdornerLayer                   | Shows the image adorner allowing users to modify an image.                                                                                        |
| 34       | ForegroundLayer                      | ForegroundLayer                | Takes care of applying the correct foreground.                                                                                                    |
| 35       | SelectionLayer                       | SelectionLayer                 | Visualizes the selection.                                                                                                                         |
| 36       | HeaderFooterOverlayLayer             | HeaderFooterOverlayLayer       | Adds an additional UI when the user is editing inside headers/footers. Makes it easier to see which part of the document is edited at the moment. |
| 37       | TableMovementUILayer                 | TableMovementLayer             | Initializes and shows the table adorner. Allows moving and selecting a whole table.                                                               |
{% if site.site_name == 'WPF' %}| 38       | ContentControlsUILayer               | ContentControlsLayer           | Shows the content controls.                                                                                                                       |{% endif %}


### Ordering Layers

The position a layer is added to the collection of layers in the control specifies its stack order. UI layer that is added as the last item in the collection is always rendered in front of all previously added layers. On the counterpart, the first UI layer in the collection visualizes its elements beneath all others. 

The default order of the built-in layers corresponds to the specific layer position in **Table 1**.

### Customizing UI Layers

The API of RadRichTextBox enables you to remove an existing layer or create a brand new one to customize the presentation of different parts of the document. These operations can be performed through a custom implementation of the **UILayersBuilder** class to register the desired remove and/or add operation.

>note For more details on customizing the visualization of the document elements, check the [Customize Presentation through UI Layers]({%slug radrichtextbox-features-custom-ui-layers%}) help topic.

## See Also

* [Customize Presentation through UI Layers]({%slug radrichtextbox-features-custom-ui-layers%})

