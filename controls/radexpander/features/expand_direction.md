---
title: Expand Direction
page_title: Expand Direction
description: Expand Direction
slug: radexpander-features-expand_direction
tags: expand,direction
publish: True
position: 1
---

# Expand Direction



The __ExpandDirection__ property gets or sets the direction in which the content would expand.
			

## 

The grid below contains four __RadExpander__ controls, each with a different __ExpandDirection__:
				

#### __XAML__

{{region radexpander-features-expand_direction_0}}
	        <Grid x:Name="LayoutRoot" 
	              Width="555"
	              Height="444"
	              Background="White"
	              ShowGridLines="True">
	            <Grid.RowDefinitions>
	                <RowDefinition Height="*" />
	                <RowDefinition Height="*" />
	            </Grid.RowDefinitions>
	            <Grid.ColumnDefinitions>
	                <ColumnDefinition Width="*" />
	                <ColumnDefinition Width="*" />
	            </Grid.ColumnDefinitions>
	            <telerik:RadExpander Grid.Row="0" 
	                                 Grid.Column="0"
	                                 VerticalAlignment="Top"
	                                 ExpandDirection="Down"
	                                 Header="Down">
	                <StackPanel Orientation="Vertical">
	                    <Ellipse Width="99" 
	                             Height="99"
	                             Margin="5"
	                             Fill="Yellow" />
	                </StackPanel>
	            </telerik:RadExpander>
	            <telerik:RadExpander Grid.Row="0" 
	                                 Grid.Column="1"
	                                 VerticalAlignment="Bottom"
	                                 ExpandDirection="Up"
	                                 Header="Up">
	                <StackPanel Orientation="Vertical">
	                    <Ellipse Width="99" 
	                             Height="99"
	                             Margin="5"
	                             Fill="Blue" />
	                </StackPanel>
	            </telerik:RadExpander>
	            <telerik:RadExpander Grid.Row="1" 
	                                 Grid.Column="0"
	                                 HorizontalAlignment="Left"
	                                 ExpandDirection="Right"
	                                 Header="Right">
	                <StackPanel Orientation="Horizontal">
	                    <Ellipse Width="99" 
	                             Height="99"
	                             Margin="5"
	                             Fill="Red" />
	                </StackPanel>
	            </telerik:RadExpander>
	            <telerik:RadExpander Grid.Row="1" 
	                                 Grid.Column="1"
	                                 HorizontalAlignment="Right"
	                                 ExpandDirection="Left"
	                                 Header="Left">
	                <StackPanel Orientation="Horizontal">
	                    <Ellipse Width="99" 
	                             Height="99"
	                             Margin="5"
	                             Fill="Green" />
	                </StackPanel>
	            </telerik:RadExpander>
	        </Grid>
	{{endregion}}

![](images/RadExpander_Features_ExpandDirection.png)
