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

#region radrichtextbox-features-headers-and-footers_0
Header header = new Header() { Body = radDocument, IsLinkedToPrevious = false }; //radDocument is an instance of RadDocument, representing the content of a Header, 
                                                                                 //typically contains a few paragraphs
#endregion

#region radrichtextbox-features-headers-and-footers_1
section.Headers.Default = header;
#endregion

#region radrichtextbox-features-headers-and-footers_2
this.editor.UpdateHeader(this.editor.Document.Sections.First, HeaderFooterType.Default, header);
#endregion

#region radrichtextbox-features-headers-and-footers_3
this.editor.Document.Sections.First.HasDifferentFirstPageHeaderFooter = true;
//or
this.editor.Document.HasDifferentEvenAndOddHeadersFooters = true;
#endregion

#region radrichtextbox-features-headers-and-footers_4
Footer header = new Footer() { Body = radDocument, IsLinkedToPrevious = false }; //radDocument is an instance of RadDocument, representing the content of the footer, 
#endregion

#region radrichtextbox-features-headers-and-footers_5
section.Footers.Default = footer;
#endregion

#region radrichtextbox-features-headers-and-footers_6
this.editor.UpdateFooter(this.editor.Document.Sections.First, HeaderFooterType.Default, footer);
#endregion

#region radrichtextbox-features-headers-and-footers_7
class CustomUILayerBuilder : UILayersBuilder
{
    protected override void BuildUILayersOverride(IUILayerContainer uiLayerContainer)
    {
        this.BuildUILayersOverride(uiLayerContainer);
        uiLayerContainer.UILayers.Remove(DefaultUILayers.HeaderFooterLayer);
    }
}
#endregion

}
