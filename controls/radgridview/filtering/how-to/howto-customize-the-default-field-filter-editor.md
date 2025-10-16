---
title: Customize the Default Field Filter Editor
page_title: Customize the Default Field Filter Editor
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to customize the default field filter editor.
slug: gridview-filtering-howto-customize-the-default-field-filter-editor
tags: customize,the,default,field,filter,editor
published: True
position: 9
---

# Customize the Default Field Filter Editor

In case you need to slightly modify the default field filter editor that we have provided, you need to attach to the FieldFilterEditorCreated event. The event arguments provide the respective column instance and the editor that we have created in our factory. This event is fired after we have created and configured the editor in the factory and before displaying it in the UI so you get the chance to change its appearance.

Depending on the column DataType the editor will be different. For String columns you will get the StringFilterEditor, for DateTime columns you will get a RadDateTimePicker, for Enum columns you will get a RadComboBox, and for all other types you will get a plain TextBox. Here is an example of how to achieve that:



```C#
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
```
```VB.NET
	Private Sub OnRadGridViewFieldFilterEditorCreated(sender As System.Object, e As Telerik.Windows.Controls.GridView.EditorCreatedEventArgs)
	    If e.Column.UniqueName = "HireDate" Then
	        Dim picker As Telerik.Windows.Controls.RadDateTimePicker = TryCast(e.Editor, Telerik.Windows.Controls.RadDateTimePicker)
	        If picker IsNot Nothing Then
	            picker.InputMode = Telerik.Windows.Controls.InputMode.DateTimePicker
	        End If
	    End If
	End Sub
```


You can adjust anything on the stock field filter editor like this. If the default field filter editor control does not suit your needs you can replace it with a completely different control by following this [article]({%slug gridview-filtering-howto-create-a-custom-field-filter-editor%}).

## Filter as user types

In case you need the filtering to be re-applied on every character entered, you may consider using the following approach:



```C#
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
```
```VB.NET
	Private Sub OnRadGridViewFieldFilterEditorCreated(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.GridView.EditorCreatedEventArgs)
	    Dim stringFilterEditor = TryCast(e.Editor, StringFilterEditor)
	
	    If stringFilterEditor IsNot Nothing Then
	        AddHandler e.Editor.Loaded, Sub(s1, e1)
	                                        Dim textBox = e.Editor.ChildrenOfType(Of TextBox)().Single()
	                                        AddHandler textBox.TextChanged, Sub(s2, e2)
	                                                                            textBox.GetBindingExpression(TextBox.TextProperty).UpdateSource()
	                                                                        End Sub
	                                    End Sub
	    End If
	End Sub
```
