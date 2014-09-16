using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication2
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radpdfviewer-find-dialog
	ExtensibilityManager.RegisterFindDialog(new FindDialog());
#endregion

#region radpdfviewer-find-dialog-interface
    public class CustomFindDialog : Window, IFindDialog
    {
        public void ShowDialog(FindDialogContext context)
        {
            ...
        }
    }
#endregion

}
