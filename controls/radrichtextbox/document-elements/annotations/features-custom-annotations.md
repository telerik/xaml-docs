---
title: Custom Annotations
page_title: Custom Annotations
description: Custom Annotations
slug: radrichtextbox-features-document-elements-custom-annotations
tags: custom,annotations
published: True
position: 2
---

# Custom Annotations



Custom annotation ranges provide an approach for extending the document model to serve specific purposes such as persisting semantic information in the document. This article will list the steps which should be followed in order to create a custom AnnotationRange with a specific behavior.
      

For general information on Annotations, please refer to these articles:

* [Annotations Overview]({%slug radrichtextbox-features-document-elements-annotations%})

* [Manipulating Annotations]({%slug radrichtextbox-features-document-elements-manipulating-annotations%})

This topic explains:
      

* [Creating Custom Annotation](#creating-a-custom-annotation)

* [Customizing Annotations](#customizing-annotations)

* [Serialization](#serialization)

## Creating a Custom Annotation

The most common scenarios for the use of custom annotations is for associating semantic data to a part of the document. In order to fulfill this task, you can implement custom annotation ranges. The steps to do so are:
        

* Create two classes deriving from AnnotationRangeStart and AnnotationRangeEnd respectively. Depending on the behavior you would like to achieve, you can also inherit from some of the already implemented annotation ranges, such as FieldRangeStart/FieldRangeEnd.
            

* Override the CreateNewElementInstance method and have it return an instance of your annotation range start/end in both classes. Override the required CopyContentFromOverride method as well. In most cases, it should be left empty.
            

#### __CS__

{{region radrichtextbox-features-document-elements-custom-annotations_0}}
	protected override DocumentElement CreateNewElementInstance()
	{
	    return new CustomRangeStart();
	}
	
	protected override void CopyContentFromOverride(DocumentElement fromElement)
	{
	}
{{endregion}}



* Override the CreateRangeStartInstance in the RangeEnd class.

#### __CS__

{{region radrichtextbox-features-document-elements-custom-annotations_1}}
	protected override AnnotationRangeStart CreateRangeStartInstance()
	{
	    return new CustomRangeStart();
	}
{{endregion}}



At this point, you will have the basic functionality working and can continue to customize the behavior of the ranges, i.e. if it will be possible to edit the content in them, what will be the behavior when you hit backspace or delete, if it will be possible to copy the ranges, etc. 

## Customizing Annotations

The behavior of the annotations when edited, copied and deleted is determined by the following properties and methods which you can override:

* __IsCopyable__ - specifies if the inline can be copied and pasted somewhere else in the document. The start and end must have the same value in order to have proper behavior. For example, BookmarkRangeStart and End are not copyable, while CommentRangeStart and End are copyable.
            

* __CopyPropertiesFromOverride__ - this method should be used when you have custom properties you would like to have copied. This should be done as follows:
            

#### __CS__

{{region radrichtextbox-features-document-elements-custom-annotations_2}}
	protected override void CopyPropertiesFromOverride(DocumentElement fromElement)
	{
	    base.CopyPropertiesFromOverride(fromElement);
	    this.Name = ((CustomRangeStart)fromElement).Name;
	}
{{endregion}}



* __SkipPositionBefore__ - specifies where text will appear if you position the caret next to the range start/end. For example, if it returns true in the range start and false in the range end, the text you enter when you position the caret next to the start/end, will appear in the range.
            

* __SkipPositionsInRange__ of AnnotationRangeStart - you can set this property to false, which will disable the option to edit the content of the range, i.e. it may be possible to delete the range altogether, but it will not be possible to position the caret in the range, select or edit only part of the range.
            

* __DeleteBehavior, BackspaceBehavior, DeleteSelectedBehavior__ - you can customize these behaviors by choosing from the options in the enum AnnotationMarkerDeleteBehavior: PreserveAnnotation, SelectAnnotation, RemoveAnnotation, SelectAnnotationMarker. For example hyperlinks keep the default settings in FieldRangeStart and FieldRangeEnd, which are: 

HyperlinkRangeStart:

#### __CS__

{{region radrichtextbox-features-document-elements-custom-annotations_3}}
	public override AnnotationMarkerDeleteBehavior DeleteBehavior
	{
	    get { return AnnotationMarkerDeleteBehavior.SelectAnnotation; }
	}
	
	public override AnnotationMarkerDeleteBehavior BackspaceBehavior
	{
	    get { return AnnotationMarkerDeleteBehavior.SelectAnnotation; }
	}
	
	public override AnnotationMarkerDeleteBehavior DeleteSelectedBehavior
	{
	    get { return AnnotationMarkerDeleteBehavior.RemoveAnnotation; }
	}
{{endregion}}

HyperlinkRangeEnd:

#### __CS__

{{region radrichtextbox-features-document-elements-custom-annotations_4}}
	public override AnnotationMarkerDeleteBehavior DeleteBehavior
	{
	    get { return AnnotationMarkerDeleteBehavior.PreserveAnnotation; }
	}
	
	public override AnnotationMarkerDeleteBehavior BackspaceBehavior
	{
	    get { return AnnotationMarkerDeleteBehavior.RemoveAnnotation; }
	}
	
	public override AnnotationMarkerDeleteBehavior DeleteSelectedBehavior
	{
	    get { return AnnotationMarkerDeleteBehavior.RemoveAnnotation; }
	}
{{endregion}}



* You can also define custom properties in your annotation range start/end. If you want to be able to serialize them, you can just mark them with the XamlSerializable attribute:
            

#### __CS__

{{region radrichtextbox-features-document-elements-custom-annotations_5}}
	[XamlSerializable]
	public string Name { get; set; } 
{{endregion}}



For additional reading, you can refer to [this blog post](http://blogs.telerik.com/xamlteam/posts/12-03-06/structured-content-editing-with-richtextbox-for-silverlight-wpf.aspx) or check out the online demo at [http://demos.telerik.com/silverlight/#RichTextBox/StructuredContentEditing](http://demos.telerik.com/silverlight/#RichTextBox/StructuredContentEditing).
        

## Serialization

Of the default document format providers, custom annotations are supported only in XAML. The other formats do not offer such extensibility. When exporting to XAML, the exporter will generate prefixes for each custom annotation namespace (custom1, custom2, etc.). Serialization is handled by XamlFormatProvider which looks for properties with the appropriate attributes: XamlSerializable (as inline properties) and XamlCompositePropertySerializable (as XAML composite properties).
        

# See Also

 * [Annotations Overview]({%slug radrichtextbox-features-document-elements-annotations%})

 * [Manipulating Annotations]({%slug radrichtextbox-features-document-elements-manipulating-annotations%})
