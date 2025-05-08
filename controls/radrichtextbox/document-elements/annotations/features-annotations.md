---
title: Annotations Overview
page_title: Annotations Overview
description: Check our &quot;Annotations Overview&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-document-elements-annotations
tags: annotations,overview
published: True
position: 0
---

# Annotations Overview

The structure of a RadDocument is normally determined by the content in it, i.e. the text is distributed in Paragraphs and Sections depending on the layout desired by the end user. The same applies to the presence of Hyperlinks and Images.      

When it comes to how the text is split in Spans, this depends on the formatting of the document and cannot be explicitly controlled, i.e. it is not possible to split some text in two spans if the formatting of the two parts is identical or to have text with different formatting be part of one span.      

Since the life cycle of Spans is determined by the document, embedding custom semantic information in Spans is inappropriate. This is what Annotations are made for.      

This article will list the types of annotations that are included in the document model. If you would like to implement custom ones in order to suit application-specific scenarios, you can follow the guidelines in [this article]({%slug radrichtextbox-features-document-elements-custom-annotations%}).

>tip To modify the document content at runtime we recommend using the [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}) class when possible, instead of working with `RadDocument` directly. The document editor ensures that the document will be measured and arranged properly on each change.      

## AnnotationMarkerBase

__AnnotationMarkerBase__ is the base class of all annotation markers. It inherits from Inline and as an inline element can be included to the Inlines of a Paragraph in a document.        

Its immediate successors in the document model hierarchy are FloatingBlocks (FloatingImageBlocks and FloatingUIContainers) - used for adding floating single items in the document.        

The functionality of AnnotationMarkerBase is extended by its inheritors __AnnotationRangeStart__ and __AnnotationRangeEnd__. The idea behind these elements is to be paired together to mark a part of the document. This is what enables "annotating" pieces of the document.        

For a picture of the document hierarchy please see [this topic]({%slug radrichtextbox-features-document-elements-hierarchy%}).        

__AnnotationMarkerBase__ and __AnnotationRangeStart__ and __AnnotationRangeEnd__ consequently have the following members:        

* __AnnotationID__ - each annotation has a unique ID. In the case of annotation ranges, the IDs of the range start and range end elements are the same.            

* __SkipPositionBefore__ - this property is related to the implementation of the "walk of the caret" - i.e. the positions which the caret can occupy. As annotation ranges are normally not taken into account when traversing the document with the arrow keys of the keyboard, placing the cursor at the place of an annotation marker should also move the caret at this place in the document. This property determines if the caret will be put before or after the annotation marked. If the value of this property is true for an annotation range start, then if you move the caret to the annotation start and start typing, the newly inserted text will be considered as part of the annotation. Vice versa, if it is set to false, the typed text will be inserted before the annotation. Needless to say, the behavior of AnnotationRangeEnds is also controlled in the same manner.            

* __SkipPositionAfter__ - a negation of the SkipPositionBefore property. If the position before the marker is skipped, then the one after it must not be skipped. Exactly one of the positions must be skipped.            

* __IsCopyable__ - determines if the range marker can be copy/pasted. Note that the value for annotation range starts and their respective ends must be the same. Otherwise, if only one of the markers is copied, the structure of the document will become invalid once the range is pasted.            

* __DeleteBehavior__, __BackspaceBehavior__, __DeleteSelectedBehavior__ - these behaviors determine the behavior of the annotations when a delete is initiated. They are of type __AnnotationMarkerDeleteBehavior__ and can obtain values from the AnnotationMarkerDeleteBehavior enum:            

    * __PreserveAnnotation__ - preserves the annotation, but the content can be modified. Can be used for Backspace and DeleteBehavior;                

    * __SelectAnnotation__ - selects the annotation. Can be used for Backspace and DeleteBehavior;                

    * __RemoveAnnotation__ - removes the annotation, but leaves its content. Can be used for Backspace, Delete and DeleteSelectedBehavior;                

* __SelectAnnotationMarker__ - selects the annotation marker. Can be used for Backspace and DeleteBehavior.

## Annotation Types

RadDocument has implementations of the following annotation range types (each annotation start class has a corresponding ~End element):

* __BookmarkRangeStart__ - specifies a place in the document where a bookmark has been inserted. More information can be found [here]({%slug radrichtextbox-features-document-elements-bookmarks%});            

* __CodeAnnotationRangeStart__ - these type of ranges surround code blocks. More information can be found [here]({%slug radrichtextbox-features-code-block%});

* __CommentRangeStart__ - used for inserting comments in the document;  More information can be found [here]({%slug radrichtextbox-features-comments%});            

* __FieldRangeStartBase__ - a base class for the following FieldRange annotations:            

    * __FieldRangeStart__ - the type of annotations inserted along with Fields. More information on fields can be found [here]({%slug radrichtextbox-features-fields%});                

    * __HyperlinkRangeStart__ - the annotations that surround hyperlinks. The hyperlink functionality is a topic of discussion in [this article]({%slug radrichtextbox-features-document-elements-hyperlink%});                

    * __MarkRangeStartBase__ - a base class for the following annotation starts:                

        * __NoteRangeStartBase__ - a base class for the following annotations:                    

            * __EndnoteRangeStart__ - the annotations that specify the place in the document where an end note occurs;                        

            * __FootnoteRangeStart__ - the annotations that specify the place in the document where a footnote is inserted;                        

        * __NoteReferenceMarkStart__ - the annotation that fulfill the link from a note to the main document.                    

    * __ReadOnlyRangeStart__ - a type of annotations that can be inserted in the document in order to make their content read only.                

* __PermissionRangeStart__ - the annotation ranges used in [document protection]({%slug radrichtextbox-features-document-protection%}).            

* __RevisionRangeStart__ - the annotations used in [track changes]({%slug radrichtextbox-features-track-changes%}). A base class for the following annotations:            

    * __DeleteRangeStart__ - denotes content that has been deleted when TrackChanges is enabled;                

    * __InsertRangeStart__ - surround content inserted at a time when TrackChanges has been turned on.                

## Serialization

| Format | Persistence of Annotations |
| --- | --- |
| XAML | All annotations are persisted |
| Docx | All annotations are persisted with the exception of ReadOnlyRangeStart/End and CodeAnnotationRangeStart/End |
| RTF | HyperlinkRangeStart/End, PermissionRangeStart/End and FieldRangeStart/End are persisted |
| HTML | HyperlinkRangeStart/End are persisted |              

## See Also  
 * [Manipulating Annotations]({%slug radrichtextbox-features-document-elements-manipulating-annotations%})
 * [Custom Annotations]({%slug radrichtextbox-features-document-elements-custom-annotations%})
