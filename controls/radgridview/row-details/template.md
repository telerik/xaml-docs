---
title: Row Details Template
page_title: Row Details Template
description: Row Details Template
slug: radgridview-row-details-template
tags: row,details,template
publish: True
position: 1
---

# Row Details Template



The __Row Details__ template is defined through the __RowDetailsTemplate__ property of the __RadGridView__.
	  

>tipTo learn how to manage the displaying of the __Row Details__ read [this topic]({%slug radgridview-row-details-visibility%}).
		

## Basic RowDetails Template

Here is an example for a basic row details template (__Example 1__). You can observe the result in __Figure 1__.
		

#### __[XAML] Example 1: Definition of Basic RowDetails Template__

{{region radgridview-row-details-template_0}}
	<telerik:RadGridView x:Name="radGridView"
	                         RowDetailsVisibilityMode="VisibleWhenSelected">
	    <telerik:RadGridView.RowDetailsTemplate>
	        <DataTemplate>
	            <StackPanel Orientation="Horizontal"
	                        Margin="10,10,10,10">
					<TextBlock Text="Stadium Capacity: " />
					<TextBlock Text="{Binding StadiumCapacity}" />
				</StackPanel>
	        </DataTemplate>
	    </telerik:RadGridView.RowDetailsTemplate>
	    ...
	</telerik:RadGridView>
	{{endregion}}





__Figure 1:__ Displays the result of the applied __Basic RowDetails Template__.
			![gridview-row-details-template-basic](images/gridview-row-details-template-basic.png)

## Complex RowDetails Template

Here is an example for a complex row details template (__Example 2__). You can observe the result in __Figure 1__.
		

#### __[XAML] Example 2: Definition of Complex RowDetails Template__

{{region radgridview-row-details-template_1}}
	<Grid>
		<Grid.Resources>
			<my:MyViewModel x:Key="MyViewModel"/>
			<DataTemplate x:Key="RowDetailsTemplate">
				<telerik:RadGridView Name="playersGrid" 
	                                ItemsSource="{Binding Players}" 
	                                AutoGenerateColumns="False">
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
	{{endregion}}





__Figure 2:__ Displays the result of the applied __Complex RowDetails Template__.
			![gridview-row-details-template-complex](images/gridview-row-details-template-complex.png)

# See Also

 * [RowDetails Overview]({%slug radgridview-row-details-overview%})

 * [Toggle RowDetails Column]({%slug radgridview-columns-column-types-toggle-rowdetails-column%})

 * [Row Details Visibility]({%slug radgridview-row-details-visibility%})

 * [External Row Details]({%slug radgridview-row-details-external-row-details%})

 * [Customizing the Row Details]({%slug radgridview-row-details-customizing-the-row-details%})
