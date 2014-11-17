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

#region raddataform-features-keyboard-support_1
    class CustomKeyboardCommandProvider : DataFormCommandProvider
    {
        public CustomKeyboardCommandProvider()
            : base(null)
        {

        }

        public CustomKeyboardCommandProvider(RadDataForm dataForm)
            : base(dataForm)
        {
            this.DataForm = dataForm;
        }
        public override List<DelegateCommandWrapper> ProvideCommandsForKey(KeyEventArgs args)
        {
            List<DelegateCommandWrapper> actionsToExecute = base.ProvideCommandsForKey(args);
            if (args.Key == Key.Right)
            {
                actionsToExecute.Clear();
                actionsToExecute.Add(new DataFormDelegateCommandWrapper(RadDataFormCommands.MoveCurrentToNext, this.DataForm));
                actionsToExecute.Add(new DataFormDelegateCommandWrapper(RadDataFormCommands.BeginEdit, this.DataForm));
            }
            if (args.Key == Key.Left)
            {
                actionsToExecute.Clear();
                actionsToExecute.Add(new DataFormDelegateCommandWrapper(RadDataFormCommands.MoveCurrentToPrevious, this.DataForm));
                actionsToExecute.Add(new DataFormDelegateCommandWrapper(RadDataFormCommands.BeginEdit, this.DataForm));
            }
            if (actionsToExecute.Count > 0)
            {
                actionsToExecute.Add(new DataFormDelegateCommandWrapper(new Action(() => { this.DataForm.AcquireFocus(); }), 100, this.DataForm));
                args.Handled = true;
            }
            return actionsToExecute;
        }
    }
#endregion
    #region raddataform-features-keyboard-support_2
    this.RadDataForm1.CommandProvider = new CustomKeyboardCommandProvider(this.RadDataForm1);
    #endregion
}
