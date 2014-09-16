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

#region gridview-managing-data-editors_2
CheckBoxEditorSettings editor = new CheckBoxEditorSettings();
( ( GridViewDataColumn )this.EditorsGrid.Columns[ "Shipped" ] ).EditorSettings = editor;
#endregion

#region gridview-managing-data-editors_5
DatePickerEditorSettings editor = new DatePickerEditorSettings();
( ( GridViewDataColumn )this.EditorsGrid.Columns[ "OrderDate" ] ).EditorSettings = editor;
#endregion

#region gridview-managing-data-editors_8
ComboBoxEditorSettings editor = ( ( GridViewComboBoxColumn )this.EditorsGrid.Columns[ "Country" ] ).EditorSettings as ComboBoxEditorSettings;
editor.ItemsSource = RadGridViewSampleData.GetCountries();
#endregion

#region gridview-managing-data-editors_13
TextBoxEditorSettings editor = new TextBoxEditorSettings();
( ( GridViewDataColumn )this.EditorsGrid.Columns[ "OrederNo" ] ).EditorSettings = editor;
#endregion
}
