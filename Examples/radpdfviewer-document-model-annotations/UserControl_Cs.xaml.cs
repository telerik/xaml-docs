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


#region radpdfviewer-document-model-annotations_0
private void viewer_AnnotationClicked(object sender, AnnotationEventArgs e)
{
    Link l = e.Annotation as Link;
    if (l == null)
    {
        return;
    }
    UriAction a = l.Action as UriAction;
    if (a == null)
    {
        return;
    }
    MessageBox.Show(a.Uri.ToString());
    e.Handled = true;
}       
#endregion

#region radpdfviewer-document-model-annotations_1
private IEnumerable<Link> GetAllLinks(RadFixedDocument document) 
{ 
    foreach (Annotation a in document.Annotations) 
    { 
        Link l = a as Link; 
        if (l != null) 
        { 
            yield return l; 
        } 
    } 
} 
#endregion

#region radpdfviewer-document-model-annotations_2
private IEnumerable<Destination> GetAllBookmarks(RadFixedDocument document) 
{ 
    foreach (Annotation a in document.Annotations) 
    { 
        Link l = a as Link; 
        if (l != null && l.Destination != null) 
        { 
            yield return l.Destination; 
        } 
    } 
}
#endregion

#region radpdfviewer-document-model-annotations_3
private void GoToDestination(Destination destination) 
{ 
    this.viewer.GoToDestination(destination); 
}
#endregion

#region radpdfviewer-document-model-annotations_4
Destination myDestination = new Destination(this.pdfViewer.Document.Pages[2], 0, 0);
#endregion

}
