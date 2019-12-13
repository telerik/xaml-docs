---
title: Overview
page_title: Taggers Overview
description: This article explains the taggers functionality provided by the RadSyntaxEditor control.
slug: radsyntaxeditor-features-taggers
tags: taggers,radsyntaxeditor
position: 0
---

# Taggers

The RadSyntaxEditor control works with the underlying document with the help of **taggers**. Taggers are used to identify spans of text and assign them a specific tag if they match a specific condition. The identification process occurs in the **GetTags** method which can be overridden in a [custom tagger]({%slug radsyntaxeditor-features-custom-tagger%}).

The matched tags are then processed by the [UI layers]({%slug radsyntaxeditor-features-layers%}) which color the text or draw additional elements on screen.

#### Figure 1: RadSyntaxEditor with a registered CSharpTagger

![RadSyntaxEditor with a registered CSharpTagger](../../images/syntaxeditor_getting-started-3.png)

## Predefined Taggers

The RadSyntaxEditor comes with a number of predefined taggers:

* **CSharpTagger**: A tagger responsible for the syntax-highlighting in the **C#** programming language.
* **VisualBasicTagger**: A tagger responsible for the syntax-highlighting in the **Visual Basic** programming language.
* **JavaScriptTagger**: A tagger responsible for the syntax-highlighting in the **JavaScript** programming language.
* **XmlTagger**: A tagger responsible for the syntax-highlighting in the **XML** programming language.
* **SqlTagger**: A tagger responsible for the syntax-highlighting in the **T-SQL (Transact-SQL)** programming language.
* **BracketFoldingTagger**: A tagger responsible for creating collapsible (folding) regions in the code. Can be used for the **JavaScript** language.
* **CSharpFoldingTagger**: A tagger responsible for creating **folding regions** in **C#** code.
* **VisualBasicFoldingTagger**: A tagger responsible for creating **folding regions** in **Visual Basic** code.
* **TextSearchHighlightTagger**: A tagger which prepares collection of **TextHighlightTag** for all occurrences of a given search word.
* **TextSearchUnderlineTagger**: A tagger which prepares collection of **UnderlineTag** for all occurrences of a given search word.

## Register a Tagger

To be able to use these taggers in the RadSyntaxEditor control, you first need to register them in its **TaggersRegistry**. This registry keeps track of all the registered taggers. Through the **IsTaggerRegistered** method you can check whether a specific tagger is already registered.

#### __[C#] Example 1: Registering taggers__
{{region cs-radsyntaxeditor-features-taggers-1}}
    
    var cSharpTagger = new CSharpTagger(this.syntaxEditor);            
    if (!this.syntaxEditor.TaggersRegistry.IsTaggerRegistered(cSharpTagger))
    {
        this.syntaxEditor.TaggersRegistry.RegisterTagger(this.cSharpTagger);
    }

    var textSearchTagger = new TextSearchHighlightTagger(this.syntaxEditor, TextSearchHighlightTagger.SearchFormatDefinition);
    if (!this.syntaxEditor.TaggersRegistry.IsTaggerRegistered(textSearchTagger))
    {
        this.syntaxEditor.TaggersRegistry.RegisterTagger(this.textSearchTagger);
    }
{{endregion}}

## See Also

* [UI Layers]({%slug radsyntaxeditor-features-layers%})
* [Word Taggers]({%slug radsyntaxeditor-features-word-taggers%})
* [Folding Taggers]({%slug radsyntaxeditor-features-folding-taggers%})