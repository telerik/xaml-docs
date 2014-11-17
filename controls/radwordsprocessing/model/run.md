---
title: Run
page_title: Run
description: Run
slug: radwordsprocessing-model-run
tags: run
published: True
position: 3
---

# Run



__Run__ element is an inline-level flow content element intended to contain a run of formatted text.
      

* [Inserting a Run](#inserting-a-run)

* [Modifying a Run](#modifying-a-run)

## Inserting a Run

The following code snippet creates a __Run__ elements and adds it to a
          [Paragraph]({%slug radwordsprocessing-model-paragraph%}).
        

#### __C#__

{{region radwordsprocessing-model-run_0}}
	            Run run = new Run(document);
	            paragraph.Inlines.Add(run);
	
	{{endregion}}



>tipThe parent __Paragraph__ should belong to the same document that is passed to the constructor of the __Run__.
          

You can add a run at a specific index in the __Inlines__ collection of a paragraph using the __Insert()__
          method. Here is how to add a run at the beginning of a paragraph:
        

#### __C#__

{{region radwordsprocessing-model-run_1}}
	            Run run = new Run(document);
	            paragraph.Inlines.Insert(0, run);
	{{endregion}}



You can also use the __AddRun()__ method of the __Inlines__ collection of a paragraph.
          The method creates a new __Run__ instance, adds it to the container and returns it:
        

#### __C#__

{{region radwordsprocessing-model-run_2}}
	            // Adds an empty run.
	            Run run1 = paragraph.Inlines.AddRun();
	
	            // Adds a run and set the text to the text property.
	            Run run2 = paragraph.Inlines.AddRun("The text.");
	{{endregion}}



Inserting text in the document can also be achieved with the [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%}) class:
        

#### __C#__

{{region radwordsprocessing-model-run_3}}
	            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());
	
	            // Adds new run to the document
	            Run run1 = editor.InsertText("First run ");
	
	            // Adds new run and starts new paragraph
	            Run run2 = editor.InsertLine("Second run");
	{{endregion}}



## Modifying a Run

The Run exposes several properties that allow you to customize how it is rendered and formatted.
        

* __Properties__: Retrieves all __CharacterProperties__ for this element. For more information about
              the CharacterProperties see [this article]({%slug radwordsprocessing-concepts-style-properties%}).
            

* __Text__: Specifies the text for the run.
            

* __StyleId__: Represents the ID of the style that is applied to this run.
            

* __FontFamily__: Specifies the font family that is used to render the text. *Style property. The value is themable object.*

* __FontSize__: Specifies the size of the font. *Style property.*

* __Shading__: Represents the shading applied to the run. It is a composite object and is read-only.
              You can obtain the following properties from it:
            

* __BackgroundColor__: Specifies the background color for the shading. *
                    Style property. The value is
                    themable object.
                  *

* __PatternColor__: Specifies the pattern color for the shading. *
                    Style property. The value is themable
                    object.
                  *

* __Pattern__: Specifies the pattern which is used to lay the pattern color over the background color for the shading.
                  *Style property.*

* __FontStyle__: Specifies the font style. *Style property.*

* __FontWeight__:  Specifies the font weight. *Style property.*

* __ForegroundColor__:  Specifies the foreground color. *Style property. The value is themable object.*

* __HighlightColor__: Specifies the highlight color. *Style property.*

* __BaselineAlignment__: Specifies how the baseline is positioned on the vertical axis, relative to the established
              baseline for text. *Style property.*

* __Strikethrough__: Specifies if the text is stroked trough. *Style property.*

* __Underline__: Specifies the underline for the run. It is composite object and is read-only. You can obtain the following
              properties from it:
            

* __Color__: Indicates the underline color. *Style property.*

* __Pattern__: Indicates the underline pattern. *Style property.*

>tipStyle properties are properties that can be inherited from a style. For more information about styles see
            [this article]({%slug radwordsprocessing-concepts-style-properties%}).
          

>tipThemable objects are objects that can be inherited from a theme. For more information about themes check
            [this article]({%slug radwordsprocessing-concepts-document-themes%}).
          

# See Also[Run API Reference](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_documents_flow_model_run.html)

 * [Paragraph]({%slug radwordsprocessing-model-paragraph%})

 * [Style Properties]({%slug radwordsprocessing-concepts-style-properties%})

 * [Document Themes]({%slug radwordsprocessing-concepts-document-themes%})
