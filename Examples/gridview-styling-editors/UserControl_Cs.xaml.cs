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
#region gridview-styling-editors_3
 private void clubsGrid_FieldFilterEditorCreated(object sender, Telerik.Windows.Controls.GridView.EditorCreatedEventArgs e)
    {
        if (e.Column.UniqueName == "StadiumCapacity")
        {
            TextBox txtBox = e.Editor as TextBox;
            if (txtBox != null)
            {
                txtBox.Background = new SolidColorBrush(Colors.Yellow);
            }
        }     
    }
#endregion
}
