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
#region radradialmenu-commands-radialmenu_1
public class CustomMenuCommand : RadialMenuCommand
{
    public CustomMenuCommand()
    {
        this.Id = CommandId.NavigateToView;
    }

    public override void Execute(object parameter)
    {
        base.Execute(parameter);
        var context = parameter as NavigateContext;
        var source = context.MenuItemSource; // parent menu item
        var target = context.MenuItemTarget; // current menu item

		// put your custom command logic here

        this.Owner.CommandService.ExecuteDefaultCommand(CommandId.NavigateToView, context);
    }

    public override bool CanExecute(object parameter)
    {
        return true;
    }
}
#endregion 
}
}