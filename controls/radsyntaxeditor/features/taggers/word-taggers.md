---
title: Word Taggers
page_title: Word Taggers
description: This article explains the use of word taggers in the RadSyntaxEditor control.
slug: radsyntaxeditor-features-word-taggers
tags: word,taggers,radsyntaxeditor
position: 1
---

# Word Taggers

A common requirement when using the RadSyntaxEditor is to highlight words which belong to a specific language classification type - such as keywords, operators and comments. Such predefined taggers include the **CSharpTagger**, **VisualBasicTagger**, **JavaScriptTagger** and **SqlTagger**. All of these taggers share a common base class - the **WordTaggerBase** class.

## WordTaggerBase

The **WordTaggerBase** class works with the **ClassificationTag** and can be used when a certain word needs to be classified to one of the available classification types. Here's a list of the supported types:

* **Comment**
* **Identifier**
* **Keyword**
* **PreprocessorKeyword**
* **Operator**
* **Literal**
* **CharacterLiteral**
* **NumberLiteral**
* **StringLiteral**
* **ExcludedCode**
* **WhiteSpace**

## TextFormatDefinition

Each of these types has a specified **TextFormatDefinition** which is used to display the matched words with a certain highlighting - foreground, background, border, underline, font style or font weight.

For example, you can highlight keywords in red and have the text appear bold and italic by adding the following definition:

__Custom TextFormatDefinition__
```C#
    this.syntaxEditor.TextFormatDefinitions.AddLast(ClassificationTypes.Keyword, new TextFormatDefinition(new SolidColorBrush(Colors.Red), FontWeights.Bold, FontStyle = FontStyles.Italic));
```

## WordTaggerBase API

The WordTaggerBase class exposes the following virtual methods:

* **bool TryGetClassificationType(string word, out ClassificationType classificationType)**: Tries to get the classification type for the given string word.
* **Dictionary&lt;string, ClassificationType> GetWordsToClassificationTypes()**: Gets a dictionary which assigns a classification type to a given word.
* **IList&lt;string> SplitIntoWords(string value)**: Splits the current line into a collection of words. These processed words are then assigned proper classification types in the **GetTags** method.
* **int GetCharType(char character)**: Defines the different char types which are used when splitting words. A word is considered a sequence of chars with the same type. By default, the types are as follows: 1 - whitespace, 2 - punctuation or symbol, 0 - letters and all other characters.
* **void OnWordSplit(int wordCharType, string word)**: Called when a word is split during the processing of a line string. You can use this method to assign a classification type to the split word, for example.

By inheriting the WordTaggerBase class you can create a tagger for your own custom language and specify custom words to be assigned to the list of available classification types. You can also define your own classification types if the default ones are not sufficient for you.

>A practical example of how to define a tagger for your own custom language can be found [here]({%slug radsyntaxeditor-features-custom-language%}).

## Multiline Tags

As of **R3 2020**, the WordTaggerBase class allows you to handle multiline tags by exposing the following members:

* **EnableMultilineTags**: A boolean property indicating whether multiline tags are collected by this tagger instance. Its default value is **true**.
* **MultilineTags**: A collection of type **IList&lt;TagSpan&lt;ClassificationTag&gt;&gt;** holding the multiline tags.
* **RebuildMultilineTags**: A method which rebuilds the MultilineTags collection.
* **InvalidateMultilineTags**: A method which clears all multiline tags and rebuilds them.

## See Also

* [UI Layers]({%slug radsyntaxeditor-features-layers%})
* [Custom Language]({%slug radsyntaxeditor-features-custom-language%})
