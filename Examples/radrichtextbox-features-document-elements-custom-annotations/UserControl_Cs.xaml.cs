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

#region radrichtextbox-features-document-elements-custom-annotations_0
protected override DocumentElement CreateNewElementInstance()
{
    return new CustomRangeStart();
}

protected override void CopyContentFromOverride(DocumentElement fromElement)
{
}
#endregion

#region radrichtextbox-features-document-elements-custom-annotations_1
protected override AnnotationRangeStart CreateRangeStartInstance()
{
    return new CustomRangeStart();
}
#endregion

#region radrichtextbox-features-document-elements-custom-annotations_2
protected override void CopyPropertiesFromOverride(DocumentElement fromElement)
{
    base.CopyPropertiesFromOverride(fromElement);
    this.Name = ((CustomRangeStart)fromElement).Name;
}
#endregion

#region radrichtextbox-features-document-elements-custom-annotations_3
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
#endregion

#region radrichtextbox-features-document-elements-custom-annotations_4
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
#endregion

#region radrichtextbox-features-document-elements-custom-annotations_5
[XamlSerializable]
public string Name { get; set; } 
#endregion
}
