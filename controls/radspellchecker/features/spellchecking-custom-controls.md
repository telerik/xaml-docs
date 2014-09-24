---
title: SpellChecking Custom Controls
page_title: SpellChecking Custom Controls
description: SpellChecking Custom Controls
slug: radspellchecker-spellchecking-custom-controls
tags: spellchecking,custom,controls
published: True
position: 2
---

# SpellChecking Custom Controls



## 

__RadSpellChecker__ supports Custom Controls. Internally it holds a dictionary matching a Type to an instance of a class deriving from __IControlSpellChecker__. These instances are loaded through MEF. So if you implement this interface you can use RadSpellChecker with your own controls.

__Implementing IControlSpellChecker__

1. __Properties:__Type __SupportedControlType__ { get; } – the Type of the control implementing IControlSpellCheckerControl __CurrentControl__ { get; set; } – a reference to the controlIIgnoredWordDictionary __IgnoredWords__ { get; set; } – a collection where all the ignored words are storedISpellChecker __SpellChecker__ { get; } – an instance of a class implementing ISpellChecker(you can use DocumentSpellChecker or a custom class of yours).  

>

The __Telerik.Windows.Documents.Proofing__assembly contains an abstract class named __ControlSpellCheckerBase__which derives from __IControlSpellChecker__and implements the last two properties (__IgnoredWords__and __SpellChecker__). If the implementation in the abstract class proves to be fit for your control, you can derive from this class instead.

1. 

__Methods:__

IWordInfo __MoveToNextError__() - searches the control for the next error(if there is one) and selects the wrong word.
void ChangeCurrentWord(string suggestion) - gets the selected word and replaces it with the right one selected by the user.

RadDocument __GetContentAsDocument__() - gets the text that has to be spellchecked from your control and imports it in the RadRichTextBox, which the window uses
void __SetContentFromDocument__(RadDocument document) - gets the spellchecked text from the RadRichTextBox and sets it back to your control

