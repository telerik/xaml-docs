---
title: Clone and Merge
page_title: Clone and Merge
description: Clone and Merge
slug: radwordsprocessing-editing-clone-and-merge
tags: clone,and,merge
published: True
position: 0
---

# Clone and Merge



* [Merging Documents](#merging-documents)

* [Cloning RadFlowDocument](#cloning-radflowdocument)

* [Cloning Document Elements](#cloning-document-elements)

## Merging Documents

__RadWordsProcessing__ allows you to merge two __RadFlowDocument__ instance using the __Merge()__ method overloads. The document to which you wish to add content is called *target* and the document from which you wish to take the content is called source.
        

#### __C#__

{{region radwordsprocessing-editing-clone-and-merge_0}}
    RadFlowDocument target = new RadFlowDocument();
    RadFlowDocument source = new RadFlowDocument();
    //...
    // target will contain merged content and styles.
    target.Merge(source);
{{endregion}}



Merge method performs two distinctive operations:
        

* Adds all sections from the source document after the sections of the target document.

* Adds all styles from the source StyleRepository to the target StyleRepository.
            

__MergeOptions__ parameter can be passed as an argument to the __Merge()__ method to better control the merge process. It provides the following customization options:

* __ConflictingStylesResolutionMode__: This option controls how conflicts between styles in target and source style repositories are resolved.  Styles are in conflict when they have the same ID (__Style.Id__). Possible values are:

    * __UseTargetStyle__: In case of conflict, the style from the target document stays in the target repository and the style from the source document is not added to the target repository.

    * __RenameSourceStyle__: In case of conflict, the style from the target document stays in the target repository and the style from the source document is added to the target repository with changed ID (with "_1" suffix).
                

The following snippet shows how to merge documents by specifying the used __MergeOptions__:
        

#### __C#__

{{region radwordsprocessing-editing-clone-and-merge_1}}
    RadFlowDocument target = new RadFlowDocument();
    RadFlowDocument source = new RadFlowDocument();
    //...
    MergeOptions mergeOptions = new MergeOptions()
    {
        ConflictingStylesResolutionMode = ConflictingStylesResolutionMode.RenameSourceStyle
    };
    target.Merge(source, mergeOptions);
{{endregion}}



## Cloning RadFlowDocument

__RadFlowDocument__ provides __Clone()__ method, which creates deep copy of the whole document structure, including all document elements and styles:
        

#### __C#__

{{region radwordsprocessing-editing-clone-and-merge_2}}
    RadFlowDocument clonedDocument = document.Clone();
{{endregion}}



## Cloning Document Elements

You can create a deep copy of most of the document elements using the __Clone()__ method overloads. Following is a list of document elements providing such methods:
        

* __RadFlowDocument__

* __Section__

* __Paragraph__

* __Run__

* __Table__

* __TableRow__

* __TableCell__

* __ImageInline__

* __FloatingImage__

__Clone()__ method has two overloads:

* __Clone()__: Create a deep copy of the document element and associates it with the same document.
            

* __Clone(RadFlowDocument)__: Creates a deep copy of the element and associates it with the provided __RadFlowDocument__. This allows cloned elements to be added in the element tree of the provided RadFlowDocument at later time and is convenient if you want to "move" an element from one document to another.
            

#### __C#__

{{region radwordsprocessing-editing-clone-and-merge_3}}
    Section clonedSection = section.Clone(radFlowDocument);
{{endregion}}



# See Also

 * [Document model]({%slug radwordsprocessing-model%})

 * [RadFlowDocument]({%slug radwordsprocessing-model-radflowdocument%})
