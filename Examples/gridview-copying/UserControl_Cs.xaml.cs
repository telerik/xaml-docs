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

#region gridview-copying_0
this.radGridView.ClipboardCopyMode = GridViewClipboardCopyMode.Cells | 
GridViewClipboardCopyMode.Header;
#endregion

#region gridview-copying_2
private void radGridView_CopyingCellClipboardContent(object sender, GridViewCellClipboardEventArgs e)
{
     if (e.Cell.Column.UniqueName == "FullName")
     {
          var person = e.Cell.Item as Person;
          e.Value = string.Format("{0} {1} {2}", person.FirstName, person.MiddleName, person.MiddleName);
     }
}
#endregion
}
