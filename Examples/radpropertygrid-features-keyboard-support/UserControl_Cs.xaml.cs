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
#region radpropertygrid-features-keyboard-support_1
    class CustomKeyboardCommandProvider : PropertyGridCommandProvider
    {
        public CustomKeyboardCommandProvider()
            : base(null)
        {

        }

        public CustomKeyboardCommandProvider(RadPropertyGrid propertyGrid)
            : base(propertyGrid)
        {
            this.PropertyGrid = propertyGrid;
        }
        public override List<DelegateCommandWrapper> ProvideCommandsForKey(KeyEventArgs args)
        {
            List<DelegateCommandWrapper> actionsToExecute = base.ProvideCommandsForKey(args);
            if (args.Key == Key.Tab)
            {
                actionsToExecute.Clear();
                actionsToExecute.Add(new PropertyGridDelegateCommandWrapper(RadPropertyGridCommands.MoveToNext, this.PropertyGrid));
                if (!this.PropertyGrid.SelectedPropertyDefinition.IsExpanded)
                {
                    actionsToExecute.Add(new PropertyGridDelegateCommandWrapper(RadPropertyGridCommands.ExpandCurrentField, this.PropertyGrid));
                }
            }
            if (args.Key == Key.Tab && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                actionsToExecute.Clear();
                actionsToExecute.Add(new PropertyGridDelegateCommandWrapper(RadPropertyGridCommands.MoveToPrevious, this.PropertyGrid));
                if (!this.PropertyGrid.SelectedPropertyDefinition.IsExpanded)
                {
                    actionsToExecute.Add(new PropertyGridDelegateCommandWrapper(RadPropertyGridCommands.ExpandCurrentField, this.PropertyGrid));
                }
            }

            return actionsToExecute;
        }
    }
#endregion
    #region radpropertygrid-features-keyboard-support_2
    this.RadPropertyGrid.CommandProvider = new CustomKeyboardCommandProvider(this.RadPropertyGrid);
    #endregion
}
