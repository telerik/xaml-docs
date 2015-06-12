---
title: Find and Replace
page_title: Find and Replace
description: Find and Replace
slug: radwordsprocessing-editing-find-and-replace
tags: find,replace
published: True
position: 3
---

# Find and Replace


__RadWordsProcessing__ gives you the ability to search for a string in a [RadFlowDocument]({%slug radwordsprocessing-model-radflowdocument%}) instance and replace all matches. The library also allows you to replace the styling of the matches alone.


Replacing can be achieved with the help of the [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%}) class exposed by the library which works with a specific document. 


## Replace Text


Finding all instances of a string and replacing it with another can be achieved with the __ReplaceText()__ method of __RadFlowDocumentEditor__. The editor exposes three methods accepting different parameters.


* __void ReplaceText(string oldText, string newText):__ Replaces all occurrences of the *oldText* string with the *newText* string. Matches the casing of the old text and replaces occurrences within a word as well.
* __void ReplaceText(string oldText, string newText, bool matchCase, bool matchWholeWord):__ Replaces all occurrences of a string with another string. Accepts Boolean parameters which specify whether the casing should be matched and only whole words should be replaces.
* __void ReplaceText(Regex regex, string newText):__ Replaces all matches of the passed __Regex__ with the new text.


__Example 1__ shows how to create a __RadFlowDocumentEditor__ instance and use it to replace all matches of the word "code" with the phrase "source code".


#### __[C#] Example 1: Replace Text__

{{region radwordsprocessing-editing-mail-merge_0}}
    RadFlowDocumentEditor editor = new RadFlowDocumentEditor(document);
    editor.ReplaceText("code", "source code", true, true);
{{endregion}}


## Replace Styling

__RadFlowDocumentEditor__ gives you the ability to format all occurrences of a string in a document. This can be achieved by using one of the overloads of the __ReplaceStyling()__ method. The overloads accept an Action delegate that allows to modify the [CharacterProperties]({%slug radwordsprocessing-concepts-style-properties%}) of the matches.


* __void ReplaceStyling(string searchedText, Action&lt;CharacterProperties&gt; replacePropertiesAction):__ Applies the character property changes from the Action delegate to all matches with the casing of the string.
* __void ReplaceStyling(string searchedText, bool matchCase, bool matchWholeWord, Action&lt;CharacterProperties&gt; replacePropertiesAction):__ Applies the character property changes from the Action delegate to all matches. Accepts Boolean parameters which specify whether the casing should be matched and only whole words should be styled.
* __void ReplaceStyling(Regex regex, Action&lt;CharacterProperties&gt; replacePropertiesAction):__ Applies the character property changes from the Action delegate to all matches of the __Regex__.


__Example 2__ shows how to apply red highlight color to all occurrences of the word "alert".


#### __[C#] Example 2: Replace Character Properties__

{{region radwordsprocessing-editing-mail-merge_0}}
    RadFlowDocumentEditor editor = new RadFlowDocumentEditor(document);
    editor.ReplaceStyling("text", new Action<CharacterProperties>((properties) =>
    {
        properties.HighlightColor.LocalValue = Colors.Red;
    }));
{{endregion}}



# See Also

 * [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%})
 * [CharacterProperties]({%slug radwordsprocessing-concepts-style-properties%}) 
 * [RadFlowDocument]({%slug radwordsprocessing-model-radflowdocument%}) 
 * [RadFlowDocumentEditor API Reference](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Documents_Flow_Model_Editing_RadFlowDocumentEditor.htm)