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
#region radradialmenu-getting-started_2
var radialMenu = new RadRadialMenu();

radialMenu.Items.Add(new RadRadialMenuItem() { Header = "Item 1" });
radialMenu.Items.Add(new RadRadialMenuItem() { Header = "Item 2" });
radialMenu.Items.Add(new RadRadialMenuItem() { Header = "Item 3" });
#endregion 
}
}