---
title: Break
page_title: Break
description: Break
slug: radwordsprocessing-model-break
tags: break
publish: True
position: 11
---

# Break



__Break__ element is an inline-level flow content element which specifies that a break should be placed at the current location. There are three types of breaks:
      

* __Line Break__: The break restarts the document content on the next line in the document.
          

* __Page Break__: The break restarts the document content on the next page of the document.
          

* __Column Break__: The break restarts the document content on the next column available on the current page of the document.
          

## Inserting a Break

All inline-level elements in a __RadFlowDocument__ need to be placed within another element.
        

__Example 1__ shows how to create a __Break__ element and add it to a [Paragraph]({%slug radwordsprocessing-model-paragraph%}).
        

#### __[C#] Example 1: Create Break__

{{region radwordsprocessing-model-break_0}}
	            Break br = new Break(document);
	            paragraph.Inlines.Add(br);
	{{endregion}}



Note, that the paragraph should belong to the same document that is passed to the constructor of the __Break__ element. The code in __Example 1__ inserts a Break element of the default break type – Line break. You can change the type of a Break through its __BreakType__ property.
        

__Example 2__ shows how you can change the type of the break created in __Example 1__.
        

#### __[C#] Example 2: Change BreakType__

{{region radwordsprocessing-model-break_1}}
	            br.BreakType = BreakType.PageBreak;
	{{endregion}}



Inserting a break in the document can also be done with the __InsertBreak()__ method of the [RadFlowDocument]({%slug radwordsprocessing-model-radflowdocument%}) class.
        

__Example 3__ shows how you can insert a break through __RadFlowDocumentEditor__.
        

#### __[C#] Example 3: Insert break using RadFlowDocumentEditor__

{{region radwordsprocessing-model-break_2}}
	            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());
	            Break br = editor.InsertBreak(BreakType.PageBreak);
	{{endregion}}



## Modifying a Break

The __Break__ element exposes several properties that allow you to customize it.
        

* __BreakType__: Specifies the type of the break.
            

* __TextWrappingRestartLocation__: Specifies the text wrapping restart location. This property affects the restart location only if __BreakType__ is set to __LineBreak__, otherwise it is ignored. The possible values are:
            

* __NextLine__: Specifies that the line break advances the text to the next line in the document.
                

* __NextFullLine__: Specifies that the line break advances the text to the next line in the document which is not interrupted by any floating objects.
                

* __NextTextRegionUnblockedOnLeft__: Specifies that the line break advances the text to the next line in the document which is not interrupted by any floating objects on the left.
                

* __NextTextRegionUnblockedOnRight__: Specifies that the line break advances the text to the next line in the document which is not interrupted by any floating objects on the right.
                

__Example 4__ shows how you can insert a Break through __RadFlowDocumentEditor__ and modify it later.
        

#### __[C#] Example 4: Customize a break__

{{region radwordsprocessing-model-break_3}}
	            RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());
	
	            Break br = editor.InsertBreak(BreakType.PageBreak);
	            br.BreakType = BreakType.LineBreak;
	            br.TextWrappingRestartLocation = TextWrappingRestartLocation.NextFullLine;
	{{endregion}}



# See Also

 * [Model]({%slug radwordsprocessing-model%})

 * [Paragraph]({%slug radwordsprocessing-model-paragraph%})

 * [RadFlowDocument]({%slug radwordsprocessing-model-radflowdocument%})
