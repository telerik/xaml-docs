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

#region gridview-filtering-howto-customize-the-default-field-filter-editor_0
private void OnRadGridViewFieldFilterEditorCreated(object sender, Telerik.Windows.Controls.GridView.EditorCreatedEventArgs e)
{
	if (e.Column.UniqueName == "HireDate")
	{
		Telerik.Windows.Controls.RadDateTimePicker picker = e.Editor as Telerik.Windows.Controls.RadDateTimePicker;
		if (picker != null)
		{
			picker.InputMode = Telerik.Windows.Controls.InputMode.DateTimePicker;
		}
	}
}
#endregion

#region gridview-filtering-howto-customize-the-default-field-filter-editor_1
private void OnRadGridViewFieldFilterEditorCreated(object sender, Telerik.Windows.Controls.GridView.EditorCreatedEventArgs e)
{
    var stringFilterEditor = e.Editor as StringFilterEditor;

    if (stringFilterEditor != null)
    {
        e.Editor.Loaded += (s1, e1) =>
        {
            var textBox = e.Editor.ChildrenOfType<TextBox>().Single();
            textBox.TextChanged += (s2, e2) =>
            {
                textBox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            };
        };
    }
}
#endregion
}
