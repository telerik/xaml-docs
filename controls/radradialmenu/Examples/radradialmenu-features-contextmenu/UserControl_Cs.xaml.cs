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
#region radradialmenu-features-contextmenu_3
//show the RadialContextMenu
RadialMenuCommands.Show.Execute(null, textBox1);

//hide the RadialContextMenu
RadialMenuCommands.Hide.Execute(null, textBox1);
#endregion 
}
}