---
title: Comment
page_title: Comment
description: Comment
slug: radwordsprocessing-model-comment
tags: comment
published: True
position: 14
---

# Comment



A __Comment__ holds annotation markers which specify for which range of document elements it refers. Every __Comment__ has a corresponding __CommentRangeStart__ and __CommentRangeEnd__, which are inline elements. These two elements specify the comment's location as follows.
      

* __CommentRangeStart__: Specifies the start of a comment annotation.

* __CommentRangeEnd__: Specifies the end of a comment annotation.
          

## Inserting a Comment

__Example 1__ shows how to create a __Comment__ and add its CommentRangeStart and CommentRangeEnd elements in a paragraph.
        

#### __[C#] Example 1: Add Comment to Paragraph__

{{region radwordsprocessing-model-comment_0}}
    Comment comment = document.Comments.AddComment();
    paragraph.Inlines.Add(comment.CommentRangeStart);
    paragraph.Inlines.AddRun("text");
    paragraph.Inlines.Add(comment.CommentRangeEnd);
{{endregion}}



The __AddComment()__ method of the __Comments__ collection of a document creates a new comment and return it. The location of the comment is around a run with text 'text'. Note, that the paragraph should belongs to the same document as the one passed to the constructor of the Comment or an exception is going to be thrown.
        

__Example 2__ showsh ow you can insert a previously created __Comment__ object in a document by using [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%}). The InsertComment() method will insert the comment's start and end elements.
        

#### __[C#] Example 2: Insert previously created Comment__

{{region radwordsprocessing-model-comment_1}}
    editor.InsertComment(comment);
{{endregion}}



__Example 3__ demonstrates how you can use another overload of __RadFlowDocumentEditor__'s __InsertComment()__ method. In this case a string representing the text of the Comment and two inline elements are passed. The two inline elements specify the element prior which the CommentRangeStart should be added and the element after which the CommentRangeEnd should be added.
        

#### __[C#] Example 3: Insert Comment around Run__

{{region radwordsprocessing-model-comment_2}}
    RadFlowDocumentEditor editor = new RadFlowDocumentEditor(new RadFlowDocument());

    Run run = editor.InsertText("text");
    editor.InsertComment("My sample comment.", run, run);
{{endregion}}



## Modifying a Comment

The __Comment__ class exposes several properties which allow you to customize information about it:
        

* __Author__: Property of type string specifying the author of the comment.

* __Initials__:  Property of type string specifying the author' initials.

* __Date__: DateTime property showing the moment the comment was created.
            

## Operating with a Comment

Comment derives BlockContainerBase [BlockContainerBase](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_documents_flow_model_blockcontainerbase.html), inheriting Blocks property of BlockCollection type. You can add [Paragraph]({%slug radwordsprocessing-model-paragraph%}) and [Table]({%slug radwordsprocessing-model-table%}) objects to that collection.
        

__Example 4__ shows how you can add a Table to a Comment.
        

#### __[C#] Example 4: Add Blocks to a Comment__

{{region radwordsprocessing-model-comment_3}}
    Paragraph paragraph = comment.Blocks.AddParagraph();
    Table table = comment.Blocks.AddTable();
{{endregion}}



# See Also

 * [RadFlowDocumentEditor]({%slug radwordsprocessing-editing-radflowdocumenteditor%})

 * [Paragraph]({%slug radwordsprocessing-model-paragraph%})

 * [Table]({%slug radwordsprocessing-model-table%})
