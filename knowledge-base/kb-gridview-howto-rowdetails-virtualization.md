---
title: Virtualization of GridView in RowDetails
description: How to turn on virtualization in RowDetails RadGridView.
type: how-to
page_title: Improve Nested RadGridView Performance
slug: kb-gridview-howto-rowdetails-virtualization
position: 0
tags: slow, scrolling, performance, rowdetails, radgridview
ticketid: 1427423
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product</td>
			<td>RadGridView for WPF</td>
		</tr>
	</tbody>
</table>

## Description

How to make sure that the virtualization of a RadGridView inside the [RowDetailsTemplate]({%slug radgridview-row-details-template%}) of another RadGridView is enabled.

## Solution 

Set the __Height__ property of the RadGridView in the RowDetails. This will ensure that it is not measured with infinity and enable the virtualization. Since the element that hosts the RowDetails is inside a RowDefinition with its Height set to Auto, by default the [UI Virtualization]({%slug radgridview-features-ui-virtualization%}) will be disabled.


```C#
    <Grid> 
        <Grid.Resources> 
            <my:MyViewModel x:Key="MyViewModel"/> 
            <DataTemplate x:Key="RowDetailsTemplate"> 
                <telerik:RadGridView Name="playersGrid"  
                            ItemsSource="{Binding Players}"  
                            AutoGenerateColumns="False"
                            Height="400"> 
                    <telerik:RadGridView.Columns> 
                        <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"/> 
                        <telerik:GridViewDataColumn DataMemberBinding="{Binding Number}"/> 
                        <telerik:GridViewDataColumn DataMemberBinding="{Binding Position}"/> 
                        <telerik:GridViewDataColumn DataMemberBinding="{Binding Country}"/> 
                    </telerik:RadGridView.Columns> 
                </telerik:RadGridView> 
            </DataTemplate> 
        </Grid.Resources> 
        <telerik:RadGridView Grid.Row="0"  
                    Name="clubsGrid"  
                    ItemsSource="{Binding Clubs, Source={StaticResource MyViewModel}}" 
                    AutoGenerateColumns="False" 
                    RowDetailsTemplate="{StaticResource RowDetailsTemplate}" 
                    Margin="5"> 
            <telerik:RadGridView.Columns> 
                <telerik:GridViewToggleRowDetailsColumn/> 
                <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"/> 
                <telerik:GridViewDataColumn DataMemberBinding="{Binding Established}" 
                                Header="Est."  
                                DataFormatString="{}{0:yyyy}"/> 
                <telerik:GridViewDataColumn DataMemberBinding="{Binding StadiumCapacity}"  
                                Header="Stadium"  
                                DataFormatString="{}{0:N0}"/> 
            </telerik:RadGridView.Columns> 
        </telerik:RadGridView> 
    </Grid> 
```
