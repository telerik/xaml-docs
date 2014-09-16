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

#region radmap-features-information-layer-shape-reder_1
this.informationLayer.Reader = new MapShapeReader();
#endregion

#region radmap-features-information-layer-shape-reder_4
this.informationLayer.Reader.ToolTipFormat = "CNTRY_NAME";
#endregion

#region radmap-features-information-layer-shape-reder_7
this.informationLayer.Reader.ToolTipFormat = "{SQKM|F2} sq.km.";
#endregion

#region radmap-features-information-layer-shape-reder_10
this.informationLayer.Reader.ToolTipFormat = "{CNTRY_NAME} - {SQKM|F2} sq.km.";
#endregion
}
