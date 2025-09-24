---
title: Number of clicks in GridViewCheckBoxColumn
page_title: Clicks in the CheckBox Column
description: Check out how you can control the number of clicks needed to change the value of the CheckBox Column within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-checkbox-column-clicks
tags: number,of,clicks,checkbox,column
published: True
position: 2
---

# Number of clicks in the CheckBox column

__PROBLEM__

If you have a __GridViewCheckBox__ column by default you need to click three times in order to change the value of the checkbox - the first click selects the current cell, the second enters edit mode and the last one will change the value.

The following solutions will give you options to control the number of clicks needed to change the value of the checkbox column.

__SOLUTION__

##     First approach

__2 clicks solution__

By configuring __EditTriggers="CellClick"__ property of GridViewCheckBoxColumn the cells will enter edit mode with a single click only. Now you will need one more click to change the value of the underlying checkbox.

__1 clicks solution__

In addition to __EditTriggers="CellClick"__ property, you can set the __AutoSelectOnEdit="True"__ property of the column. This property will alter the checked state of the checkbox as soon as the cell enters edit mode, thus changing the value on a single click. Please note that the __GridView has to be focused__.

This could be done in __XAML__ or in __code behind__ when the columns are auto generated:        



```XAML
	<telerik:GridViewCheckBoxColumn Name="CheckBoxColumn"
	EditTriggers="CellClick"
	AutoSelectOnEdit="True"
	DataMemberBinding="{Binding IsChampion}" />
```




```C#
	private void gridView_AutoGeneratingColumn(object sender, GridViewAutoGeneratingColumnEventArgs e)
	{
	    var dataColumn = e.Column as GridViewDataColumn;
	
	    if (dataColumn != null)
	    {
	        if (dataColumn.UniqueName.ToString() == "IsChampion")
	        {
	            // create GridViewCheckBoxColumn
	            GridViewCheckBoxColumn newColumn = new GridViewCheckBoxColumn();
	            newColumn.DataMemberBinding = dataColumn.DataMemberBinding;
	            newColumn.Header = dataColumn.Header;
	            newColumn.UniqueName = dataColumn.UniqueName;
	            newColumn.EditTriggers = Telerik.Windows.Controls.GridView.GridViewEditTriggers.CellClick;
	            newColumn.AutoSelectOnEdit = true;
	            e.Column = newColumn;
	        }
	    }
	}
```



```VB.NET
	Private Sub gridView_AutoGeneratingColumn(sender As Object, e As GridViewAutoGeneratingColumnEventArgs)
	    Dim dataColumn = TryCast(e.Column, GridViewDataColumn)
	    If dataColumn IsNot Nothing Then
	        If dataColumn.UniqueName.ToString() = "IsChampion" Then
	            ' create GridViewCheckBoxColumn
	            Dim newColumn As New GridViewCheckBoxColumn()
	            newColumn.DataMemberBinding = dataColumn.DataMemberBinding
	            newColumn.Header = dataColumn.Header
	            newColumn.UniqueName = dataColumn.UniqueName
	            newColumn.EditTriggers = Telerik.Windows.Controls.GridView.GridViewEditTriggers.CellClick
	            newColumn.AutoSelectOnEdit = True
	            e.Column = newColumn
	        End If
	    End If
	End Sub
```

##     Second approach

Another approach would be to leverage the __CellTemplate__ of GridViewDataColumn and put a checkbox in it:



```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding IsActive}" 
	            IsReadOnly="True">
	    <telerik:GridViewDataColumn.CellTemplate>
	        <DataTemplate>
	            <CheckBox IsChecked="{Binding IsActive, Mode=TwoWay}"
	      telerik:StyleManager.Theme="Office_Black"/>
	        </DataTemplate>
	    </telerik:GridViewDataColumn.CellTemplate>
	</telerik:GridViewDataColumn>
```


The CheckBox is two-way bound to the IsActive boolean property so with single click you change it. The benefit here is that the CheckBox looks enabled, because it is in the CellTemplate while in the first approach the CheckBox looks disabled (because the cells are not in edit mode yet). 
>The column is read-only, since this is a CheckBox with two-way binding and there is no need to enter the edit mode at all.

## See Also

 * [CheckBox Column]({%slug gridview-checkbox-column%}) 
 
 * [Styling the CheckBoxColumn]({%slug gridview-columns-styling-checkboxcolumn%})

 * [CellTemplate and CellEditTemplate]({%slug radgridview-columns-celltemplate-and-celledittemplate%})
 

