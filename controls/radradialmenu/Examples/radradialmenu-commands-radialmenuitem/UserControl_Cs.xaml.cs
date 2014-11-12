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
#region radradialmenu-commands-radialmenuitem_0
public class CustomItemCommand : ICommand
{
    public bool CanExecute(object parameter)
    {
        var radialMenuItem = parameter as RadRadialMenuItem;
        if (radialMenuItem != null)
        {
           // perform custom logic here
        }
        return true;
    }

    public void Execute(object parameter)
    {
        var radialMenuItem = parameter as RadRadialMenuItem;
        if (radialMenuItem != null)
        {
           // perform custom logic here                
        }
    }

    public event EventHandler CanExecuteChanged;
}    
#endregion 
}
}