using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radrichtextbox-features-document-elements-annotations_0
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
#endregion

#region radrichtextbox-features-document-elements-annotations_1
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
#endregion

#region radrichtextbox-features-document-elements-annotations_2
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

#endregion

#region radrichtextbox-features-document-elements-annotations_3
Inline currentInline = this.editor.Document.CaretPosition.GetCurrentInline();
#endregion

#region radrichtextbox-features-document-elements-annotations_4
/// <summary>
/// Inserts an annotation range.
/// </summary>
/// <param name="rangeStart">The annotation range start.</param>
/// <param name="rangeEnd">The annotation range end.</param>
public void InsertAnnotationRange(AnnotationRangeStart rangeStart, AnnotationRangeEnd rangeEnd)
#endregion

#region radrichtextbox-features-document-elements-annotations_5
/// <summary>
/// Deletes an annotation range.
/// </summary>
/// <param name="rangeStart">The start of the range that is to be deleted.</param>
public void DeleteAnnotationRange(AnnotationRangeStart rangeStart)
#endregion

#region radrichtextbox-features-document-elements-annotations_6
editor.Document.Selection.SelectAnnotationRange(start);
editor.Delete(false);
#endregion

#region radrichtextbox-features-document-elements-annotations_7
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
#endregion


}
