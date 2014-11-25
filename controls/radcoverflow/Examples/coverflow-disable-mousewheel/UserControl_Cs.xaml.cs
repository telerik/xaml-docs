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

#region coverflow-disable-mousewheel_0
public class CoverFlow : RadCoverFlow
{
       protected override void OnMouseWheel(MouseWheelEventArgs e)
       {
              //base.OnMouseWheel(e);
       }
}

#endregion
}
