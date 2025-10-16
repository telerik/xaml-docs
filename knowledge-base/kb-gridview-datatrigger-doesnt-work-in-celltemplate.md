---
title: DataTrigger Defined in CellTemplate of RadGridView Column Doesn't Work.
description: A DataTrigger defined in a column's CellTemplate or CellEditTemplate of RadGridView doesn't get executed.
type: troubleshooting
page_title: DataTrigger Added in CellTemplate of GridViewColumn of DataGrid won't work
slug: kb-gridview-datatrigger-doesnt-work-in-celltemplate
position: 0
tags: gridview, celltemplate, datatrigger,trigger
ticketid: 1495519
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.3.1109</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

A `DataTrigger` defined in a `GridViewColumn`'s `CellTemplate` or `CellEditTemplate` of `RadGridView` doesn't work.

## Solution

Several alternative options can be used instead of `DataTrigger`. The following trigger definition will serve as a reference on how to replace it with another approach.

__DataTrigger definition__
```XAML
	<telerik:GridViewDataColumn DataMemberBinding="{Binding PersonName}"> 
		<telerik:GridViewDataColumn.CellTemplate> 
			<DataTemplate> 
				<TextBlock x:Name="textBlock" Text="{Binding PersonName}" /> 
				<DataTemplate.Triggers> 
					<DataTrigger Binding="{Binding IsPersonAvailable}" Value="False" > 
						<Setter TargetName="textBlock" Property="Background" Value="Red" /> 
					</DataTrigger> 
				</DataTemplate.Triggers>
			</DataTemplate> 
		</telerik:GridViewDataColumn.CellTemplate> 
	</telerik:GridViewDataColumn> 
```

Instead, use one of the following ideas:

* __Using a direct data binding for the property targeted by the trigger.__

	In that case an additional property in the row's data model should be defined and updated accordingly.
	
	
	```XAML
		<telerik:GridViewDataColumn DataMemberBinding="{Binding PersonName}"> 
			<telerik:GridViewDataColumn.CellTemplate> 
				<DataTemplate> 
					<TextBlock x:Name="textBlock" Text="{Binding PersonName}" Background="{Binding PersonBackground}" /> 
				</DataTemplate> 
			</telerik:GridViewDataColumn.CellTemplate> 
		</telerik:GridViewDataColumn> 
	```
	
* __Using an `IValueConverter`.__

	In that case the converter can return red color if the bound boolean value is false, and black (or other) color when true.

	
	```XAML
		<telerik:GridViewDataColumn DataMemberBinding="{Binding PersonName}"> 
			<telerik:GridViewDataColumn.CellTemplate> 
				<DataTemplate> 
					<TextBlock x:Name="textBlock" Text="{Binding PersonName}" Background="{Binding IsPersonAvailable, Converter={StaticResource MyBooleanToBrushConverter}}" /> 
				</DataTemplate> 
			</telerik:GridViewDataColumn.CellTemplate> 
		</telerik:GridViewDataColumn> 
	```
	
* __Using the `ContentTemplate` of `GridViewCell` instead of the `CellTemplate`.__

	To utilize this idea, use the `CellStyle` property of the column.
	
	```XAML
		<telerik:GridViewDataColumn DataMemberBinding="{Binding PersonName}"> 
			<telerik:GridViewDataColumn.CellStyle> 
				<Style TargetType="telerik:GridViewCell">
					<Setter Property="ContentTemplate">
						<Setter.Value>
							<DataTemplate>
								<TextBlock x:Name="textBlock" Text="{Binding PersonName}" /> 
								<DataTemplate.Triggers> 
									<DataTrigger Binding="{Binding IsPersonAvailable}" Value="False" > 
										<Setter TargetName="textBlock" Property="Background" Value="Red" /> 
									</DataTrigger> 
								</DataTemplate.Triggers>
							</DataTemplate>
						</Setter.Value>
					</Setter>
				</Style>
			</telerik:GridViewDataColumn.CellTemplate> 
		</telerik:GridViewDataColumn> 
	```
