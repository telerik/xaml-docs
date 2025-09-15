---
title: Exclude Columns from Column Chooser
description: Remove columns from the column chooser in the control panel.
type: how-to
page_title: Provide a Limited Set of Columns in the Control Panel
slug: kb-gridview-exclude-columns-from-column-chooser
position: 0
tags: exclude,columns,control,panel,column,chooser
ticketid: 1407940
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.220</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadGridView for WPF</td>
	</tr>
</table>

## Description

How to exclude columns from the [column chooser in the control panel]({%slug gridview-overview-controlpanel%}).

## Solution

1. Create an **IValueConverter** with your custom predicate to filter the columns.

	__Example 1: Exclude the columns bound to the IsDeleted property from the column chooser__
	```XAML
		public class ColumnsConverter : IValueConverter
		{
			public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
			{
				var columns = value as Telerik.Windows.Controls.GridViewColumnCollection;
				var filteredColumns = columns.OfType<GridViewBoundColumnBase>().Where(c => c.DataMemberBinding.Path.Path != "IsDeleted");
				return filteredColumns;
			}
		
			public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
			{
				throw new NotImplementedException();
			}
		}
	```

2. Use the converter in the binding to the **Columns** property.
	
	
	```XAML
		<telerik:ControlPanelItem ButtonTooltip="Column chooser">
			<telerik:ControlPanelItem.ContentTemplate>
				<DataTemplate>
					<DataTemplate.Resources>
						<local:ColumnsConverter x:Key="ColumnsConverter" />
					</DataTemplate.Resources>
					<ListBox ItemsSource="{Binding Columns, Converter={StaticResource ColumnsConverter}}" BorderThickness="0">
						<ListBox.ItemTemplate>
							<DataTemplate>
								<CheckBox Content="{Binding Header, Mode=OneWay}" IsChecked="{Binding IsVisible, Mode=TwoWay}" />
							</DataTemplate>
						</ListBox.ItemTemplate>
					</ListBox>
				</DataTemplate>
			</telerik:ControlPanelItem.ContentTemplate>
		</telerik:ControlPanelItem>
	```

## See Also  

* [Control Panel]({%slug gridview-overview-controlpanel%})
