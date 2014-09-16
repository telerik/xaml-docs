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

#region radrichtextbox-features-custom-ui-layers_0
public override void UpdateUIViewPortOverride(UILayerUpdateContext context)
#endregion
   
#region radrichtextbox-features-custom-ui-layers_1
public override string Name
{
    get
    {
        return this.customLayerName;
    }
}
#endregion

#region radrichtextbox-features-custom-ui-layers_2
[CustomUILayersBuilder]
public class CustomLayersBuilder : UILayersBuilder
#endregion

#region radrichtextbox-features-custom-ui-layers_3
this.editor.UILayersBuilder = new CustomLayersBuilder();
#endregion

#region radrichtextbox-features-custom-ui-layers_4
protected override void BuildUILayersOverride(IUILayerContainer uiLayerContainer)
{
    uiLayerContainer.UILayers.AddAfter(DefaultUILayers.HighlightDecoration, new MyCustomLayer());
}
#endregion



}
