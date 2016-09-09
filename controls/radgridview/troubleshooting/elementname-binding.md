---
title: ElementName binding in column Header or CellTemplate
page_title: ElementName binding in column Header or CellTemplate
description: ElementName binding in column Header or CellTemplate
slug: gridview-troubleshooting-elementname-binding
tags: elementname,binding,in,column,header,or,celltemplate
published: True
position: 10
site_name: Silverlight
---

# ElementName binding in column Header or CellTemplate

__PROBLEM__

The ElementName binding does not work when used in column Header or CellTemplate. For example this will not work:

#### __XAML__


{{region xaml-gridview-troubleshooting-elementname-binding_0}}
	<TextBox x:Name="TextBox1" Text="Type something" />
	    <telerik:RadGridView ItemsSource="{Binding}" AutoGenerateColumns="False">
	        <telerik:RadGridView.Columns>
	            <telerik:GridViewColumn>
	                <telerik:GridViewColumn.Header>
	                    <TextBlock Text="{Binding Text, ElementName=TextBox1}" />
	                </telerik:GridViewColumn.Header>
	                <telerik:GridViewColumn.CellTemplate>
	                    <DataTemplate>
	                        <TextBlock Text="{Binding Text, ElementName=TextBox1}" />
	                    </DataTemplate>
	                </telerik:GridViewColumn.CellTemplate>
	            </telerik:GridViewColumn>
	        </telerik:RadGridView.Columns>
	    </telerik:RadGridView>
{{endregion}}

__CAUSE__

When you use the __ElementName__, the binding engine uses FindName method on FrameworkElement to find the target just once.
So when you load it with LoadContent (as we do in RadGridView) – the element is not yet in the visual tree and FindName fails.

__SOLUTION__

Use a Style to set the ContentTemplate as below:

#### __XAML__

{{region xaml-gridview-troubleshooting-elementname-binding_1}}

	<TextBox x:Name="TextBox1" Text="Type something" />
	
	    <telerik:RadGridView ItemsSource="{Binding}" AutoGenerateColumns="False">
	        <telerik:RadGridView.Columns>
	            <telerik:GridViewColumn>
	                <telerik:GridViewColumn.HeaderCellStyle>
	                    <Style TargetType="telerik:GridViewHeaderCell">
	                        <Setter Property="ContentTemplate">
	                            <Setter.Value>
	                                <DataTemplate>
	                                    <TextBlock Text="{Binding Text, ElementName=TextBox1}" />
	                                </DataTemplate>
	                            </Setter.Value>
	                        </Setter>
	                    </Style>
	                </telerik:GridViewColumn.HeaderCellStyle>
	                <telerik:GridViewColumn.CellStyle>
	                    <Style TargetType="telerik:GridViewCell">
	                        <Setter Property="ContentTemplate">
	                            <Setter.Value>
	                                <DataTemplate>
	                                    <TextBlock Text="{Binding Text, ElementName=TextBox1}" />
	                                </DataTemplate>
	                            </Setter.Value>
	                        </Setter>
	                    </Style>
	                </telerik:GridViewColumn.CellStyle>
	            </telerik:GridViewColumn>
	        </telerik:RadGridView.Columns>
	    </telerik:RadGridView>
{{endregion}}

# See Also

 * [UI Virtualization]({%slug radgridview-features-ui-virtualization%})