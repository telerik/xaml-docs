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




__RadSpellChecker__ supports Custom Controls. Internally it holds a dictionary matching a Type to an instance of a class deriving from __IControlSpellChecker__. These instances are loaded through MEF. Ultimately, if you implement this interface you can use __RadSpellChecker__ with your own controls.

##  __Implementing IControlSpellChecker__

* __Properties__:

Type __SupportedControlType__ { get; }: The Type of the control implementing IControlSpellChecker

Control __CurrentControl__ { get; set; }: A reference to the control

IIgnoredWordDictionary __IgnoredWords__ { get; set; }: A collection where all the ignored words are stored

ISpellChecker __SpellChecker__ { get; }: An instance of a class implementing ISpellChecker(you can use DocumentSpellChecker or a custom class of yours).  

> The __Telerik.Windows.Documents.Proofing__ assembly contains an abstract class named __ControlSpellCheckerBase__ which derives from __IControlSpellChecker__ and implements the last two properties (__IgnoredWords__ and __SpellChecker__). If the implementation in the abstract class proves to be fit for your control, you can derive from this class instead.

* __Methods:__

IWordInfo __MoveToNextError__() - searches the control for the next error(if there is one) and selects the wrong word.
void ChangeCurrentWord(string suggestion) - gets the selected word and replaces it with the right one selected by the user.

RadDocument __GetContentAsDocument__() - gets the text that has to be spellchecked from your control and imports it in the RadRichTextBox, which the window uses
void __SetContentFromDocument__(RadDocument document) - gets the spellchecked text from the RadRichTextBox and sets it back to your control

