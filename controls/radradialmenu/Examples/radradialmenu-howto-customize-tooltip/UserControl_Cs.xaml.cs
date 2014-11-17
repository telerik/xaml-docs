using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using Telerik.Windows.Controls;

namespace RadialMenuExample
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
	
public class DummyClass
{
#region radradialmenu-howto-customize-tooltip_4
private void RadRadialMenu_PreviewToolTipOpen(object sender, MenuToolTipEventArgs e)
{
    e.Placement = System.Windows.Controls.Primitives.PlacementMode.Left;
}
#endregion 
}
}