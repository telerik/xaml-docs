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

#region gridview-how-to-hide-match-case_0
void gridView_FieldFilterEditorCreated(object sender, Telerik.Windows.Controls.GridView.EditorCreatedEventArgs e)
{
 //get the StringFilterEditor in your RadGridView
 var stringFilterEditor = e.Editor as StringFilterEditor;
 if (stringFilterEditor != null)
 {
  stringFilterEditor.Loaded += new RoutedEventHandler(stringFilterEditor_Loaded);
 }
}

void stringFilterEditor_Loaded(object sender, RoutedEventArgs e)
{
 //Hide the Match case toogle button in its Loaded event
 ((StringFilterEditor) sender).ChildrenOfType<ToggleButton>().FirstOrDefault().Visibility = Visibility.Collapsed;
}
#endregion

#region gridview-how-to-hide-match-case_2
void gridView_FieldFilterEditorCreated(object sender, Telerik.Windows.Controls.GridView.EditorCreatedEventArgs e)
{
 //get the StringFilterEditor in your RadGridView
 var stringFilterEditor = e.Editor as StringFilterEditor;
 if (stringFilterEditor != null)
 {
    stringFilterEditor.MatchCaseVisibility = Visibility.Hidden;
 }
}
#endregion

}
