---
title: Manipulating Annotations
page_title: Manipulating Annotations
description: Manipulating Annotations
slug: radrichtextbox-features-document-elements-manipulating-annotations
tags: manipulating,annotations
published: True
position: 1
---

# Manipulating Annotations



This article outlines the most commonly used manipulations with regard to Annotations.

The types of manipulations that can be performed on annotations include:

* Presentation in the document;

* Retrieving annotations;

* Inserting an annotation;

* Deleting an annotation;

* Splitting an annotation at a given position.

## Presentation

By default all annotations are markup-only in the sense that they do not have any appearance. If you want to display a highlight, range brackets or anything else, you can use the UI layers feature of RadRichTextBox. You can read more about them in [this article]({%slug radrichtextbox-features-custom-ui-layers%}).
        

## Methods for Retrieving Annotations

* RadDocument and DocumentSelection expose the following general methods for retrieving annotation markers or checking if such exist in the document/selection at all:

#### __C#__

{{region radrichtextbox-features-document-elements-annotations_0}}
	/// <summary>
	/// Determines whether the document contains annotation markers of type T.
	/// </summary>
	public bool ContainsAnnotationMarkersOfType<T>()
	    where T : AnnotationMarkerBase
	
	/// <summary>
	/// Gets all annotation markers of type T in the document.
	/// </summary>
	public IEnumerable<T> GetAnnotationMarkersOfType<T>()
	    where T : AnnotationMarkerBase
{{endregion}}



* Methods for retrieving the containing annotations around a particular inline. This is particularly convenient if you would like to perform checks against the position where the caret is at.First, you can obtain the current inline like this:

#### __C#__

{{region radrichtextbox-features-document-elements-annotations_3}}
	Inline currentInline = this.editor.Document.CaretPosition.GetCurrentInline();
{{endregion}}

and then, check if this inline is contained in a range using one of the methods below:

#### __C#__

{{region radrichtextbox-features-document-elements-annotations_1}}
	/// <summary>
	/// Determines whether the specified inline is in annotation range of type TRangeStart.
	/// </summary>
	/// <param name="inline">The inline.</param>
	/// <param name="inclusive">Specifies whether to return the inline itself if it is a TRangeStart.</param>
	public bool IsInAnnotationRange<TRangeStart>(Inline inline, bool inclusive = false)
	    where TRangeStart : AnnotationRangeStart
	
	/// <summary>
	/// Gets the annotation ranges of type TRangeStart surrounding an inline.
	/// </summary>
	/// <param name="inline">The inline.</param>
	/// <param name="inclusive">Specifies whether to return the inline itself if it is a TRangeStart.</param>
	public IEnumerable<TRangeStart> GetContainingAnnotationRanges<TRangeStart>(Inline inline, bool inclusive = false)
	    where TRangeStart : AnnotationRangeStart
{{endregion}}



* More finely tuned methods that filter the annotation ranges at the time of their retrieval include:

#### __C#__

{{region radrichtextbox-features-document-elements-annotations_2}}
	/// <summary>
	/// Determines whether the specified inline is in annotation range of type TRangeStart that matches a condition.
	/// </summary>
	/// <param name="inline">The inline.</param>
	/// <param name="filter">The filter.</param>
	/// <param name="inclusive">Specifies whether to return the inline itself if it is a TRangeStart.</param>
	public bool IsInAnnotationRange<TRangeStart>(Inline inline, Predicate<TRangeStart> filter, bool inclusive = false)
	    where TRangeStart : AnnotationRangeStart
	
	/// <summary>
	/// Gets the annotation ranges of type TRangeStart surrounding an inline that match a condition.
	/// </summary>
	/// <param name="inline">The inline.</param>
	/// <param name="filter">The filter.</param>
	/// <param name="inclusive">Specifies whether to return the inline itself if it is a TRangeStart.</param>
	public IEnumerable<TRangeStart> GetContainingAnnotationRanges<TRangeStart>(Inline inline, Predicate<TRangeStart> filter, bool inclusive = false)
	    where TRangeStart : AnnotationRangeStart
{{endregion}}



## Inserting Annotations

Annotations can be inserted in the document using the following method of [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}).
        

#### __C#__

{{region radrichtextbox-features-document-elements-annotations_4}}
	/// <summary>
	/// Inserts an annotation range.
	/// </summary>
	/// <param name="rangeStart">The annotation range start.</param>
	/// <param name="rangeEnd">The annotation range end.</param>
	public void InsertAnnotationRange(AnnotationRangeStart rangeStart, AnnotationRangeEnd rangeEnd)
{{endregion}}



There are also some methods that insert specific types of annotations for the commonly used types, such as Hyperlinks, Comments, etc. For more information, check the respective article.

## Deleting Annotations

In order to delete an annotation, you need to obtain a reference to its range start first. After that, you can use the following method of [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}) to remove it.
        

#### __C#__

{{region radrichtextbox-features-document-elements-annotations_5}}
	/// <summary>
	/// Deletes an annotation range.
	/// </summary>
	/// <param name="rangeStart">The start of the range that is to be deleted.</param>
	public void DeleteAnnotationRange(AnnotationRangeStart rangeStart)
{{endregion}}



Note that this method will remove the annotation, but will keep its contents. In order to delete the contents as well, you can select it and use the Delete method of the editor:

#### __C#__

{{region radrichtextbox-features-document-elements-annotations_6}}
	editor.Document.Selection.SelectAnnotationRange(start);
	editor.Delete(false);
{{endregion}}



There are also some methods that that remove specific types of annotations for the commonly used types, such as Hyperlinks, Comments, etc. For more information, check the respective article.

## Splitting Annotations

Some user scenarios require that there would be an easy way to split annotation ranges. In such cases, one can use the following methods:
        

#### __C#__

{{region radrichtextbox-features-document-elements-annotations_7}}
	/// <summary>
	/// Splits an annotation range at the caret position, resulting in two new ranges.
	/// </summary>
	/// <param name="rangeStart">The annotation range start to be split.</param>
	public void SplitAnnotationRange(AnnotationRangeStart rangeStart)
	
	/// <summary>
	/// Splits an annotation range at the specified position, resulting in two new ranges.
	/// </summary>
	/// <param name="rangeStart">The annotation range start to be split.</param>
	/// <param name="position">The position where the range start should be split.</param>
	public void SplitAnnotationRange(AnnotationRangeStart rangeStart, DocumentPosition position)       
{{endregion}}



# See Also

 * [Annotations Overview]({%slug radrichtextbox-features-document-elements-annotations%})

 * [Custom Annotations]({%slug radrichtextbox-features-document-elements-custom-annotations%})
