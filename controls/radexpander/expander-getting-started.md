---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: expander-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started



## Declaring a RadExpander

The __RadExpander__ is a __HeaderedContentControl__ and we can initialize both its __Header__ and __Content__ properties.
                {% if site.site_name == 'Silverlight' %}

>In order to use __RadExpander__ in your projects you need to add reference to the following assemblies:<br/>* __Telerik.Windows.Controls__<br/>* __Telerik.Windows.Controls.Navigation__ <br/>You can find more info [here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).
                            

#### __XAML__
    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
                        

{% endif %}{% if site.site_name == 'WPF' %}

>In order to use __RadExpander__ in your projects you need to add reference to the following assemblies:<br/>* __Telerik.Windows.Controls__<br/>* __Telerik.Windows.Controls.Navigation__<br/>* __Telerik.Windows.Data__<br/> You can find more info [here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).
                            

#### __XAML__
    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
                        

{% endif %}

#### __XAML__

{{region expander-getting-started-0}}
	<telerik:RadExpander Header="My Expander">
	    <ListBox>
	        <ListBoxItem Content="Option 1" />
	        <ListBoxItem Content="Option 2" />
	        <ListBoxItem Content="Option 3" />
	        <ListBoxItem Content="Option 4" />
	        <ListBoxItem Content="Option 5" />
	    </ListBox>
	</telerik:RadExpander>
	{{endregion}}

![](images/RadExpander_GettingStarted.png)

## Declaring more complex Header and Content

If the information in the __Header__ and/or the __Content__ is more complex then we can rely on the XML Element initializing technique. Below is the sample xaml-code:
                

#### __XAML__

{{region expander-getting-started-1}}
    <telerik:RadExpander x:Name="radExpander"
                         VerticalContentAlignment="Top"
                         IsExpanded="True">
        <telerik:RadExpander.Header>
            <TextBlock Text="Header" />
        </telerik:RadExpander.Header>
        <telerik:RadExpander.Content>
            <Grid>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition />
                    <ColumnDefinition />
                </Grid.ColumnDefinitions>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto" />
                    <RowDefinition Height="Auto" />
                </Grid.RowDefinitions>
                <Border Height="131"
                        Margin="5"
                        BorderBrush="#FFDADADA"
                        BorderThickness="0,0,1,1"
                        CornerRadius="3">
                    <Border BorderBrush="#B2ADBDD1"
                            BorderThickness="1"
                            CornerRadius="2">
                        <StackPanel Orientation="Horizontal">
                            <Border Width="108"
                                    Height="108"
                                    Margin="10 0 0 0"
                                    BorderBrush="#FFE0E0E0"
                                    BorderThickness="1">
                                <Image Source="/Images/item1.png" Stretch="None" />
                            </Border>
                            <StackPanel Margin="10 25 10 0">
                                <TextBlock Margin="0 0 0 5"
                                           FontFamily="Segoe UI"
                                           FontSize="16"
                                           Foreground="#FF0099CC"
                                           Text="Bob Smiil" />
                                <TextBlock Margin="0 0 0 5"
                                           FontFamily="Segoe UI"
                                           FontSize="11"
                                           Text="BobSmiil@mail.com" />
                                <TextBlock FontFamily="Segoe UI"
                                           FontSize="10.667"
                                           Text="Phone: 333 2334" />
                            </StackPanel>
                        </StackPanel>
                    </Border>
                </Border>
                <Border Grid.Row="1"
                        Height="131"
                        Margin="5"
                        BorderBrush="#FFDADADA"
                        BorderThickness="0,0,1,1"
                        CornerRadius="3">
                    <Border BorderBrush="#B2ADBDD1"
                            BorderThickness="1"
                            CornerRadius="2">
                        <StackPanel Orientation="Horizontal">
                            <Border Width="108"
                                    Height="108"
                                    Margin="10 0 0 0"
                                    BorderBrush="#FFE0E0E0"
                                    BorderThickness="1">
                                <Image Source="/Images/item2.png" Stretch="None" />
                            </Border>
                            <StackPanel Margin="10 25 15 0">
                                <TextBlock Margin="0 0 0 5"
                                           FontFamily="Segoe UI"
                                           FontSize="16"
                                           Foreground="#FF0099CC"
                                           Text="Anne Dodsworth" />
                                <TextBlock Margin="0 0 0 5"
                                           FontFamily="Segoe UI"
                                           FontSize="11"
                                           Text="Anne Dodsworth@mail.com" />
                                <TextBlock FontFamily="Segoe UI"
                                           FontSize="10.667"
                                           Text="Phone: 333 2334" />
                            </StackPanel>
                        </StackPanel>
                    </Border>
                </Border>
                <Border Grid.Column="1"
                        Height="131"
                        Margin="5"
                        BorderBrush="#FFDADADA"
                        BorderThickness="0,0,1,1"
                        CornerRadius="3">
                    <Border BorderBrush="#B2ADBDD1"
                            BorderThickness="1"
                            CornerRadius="2">
                        <StackPanel Orientation="Horizontal">
                            <Border Width="108"
                                    Height="108"
                                    Margin="10 0 0 0"
                                    BorderBrush="#FFE0E0E0"
                                    BorderThickness="1">
                                <Image Source="/Images/item3.png" Stretch="None" />
                            </Border>
                            <StackPanel Margin="10 25 10 0">
                                <TextBlock Margin="0 0 0 5"
                                           FontFamily="Segoe UI"
                                           FontSize="16"
                                           Foreground="#FF0099CC"
                                           Text="Andrew Fuller" />
                                <TextBlock Margin="0 0 0 5"
                                           FontFamily="Segoe UI"
                                           FontSize="11"
                                           Text="AndrewFuller@mail.com" />
                                <TextBlock FontFamily="Segoe UI"
                                           FontSize="10.667"
                                           Text="Phone: 333 2334" />
                            </StackPanel>
                        </StackPanel>
                    </Border>
                </Border>
                <Border Grid.Row="1"
                        Grid.Column="1"
                        Height="131"
                        Margin="5"
                        BorderBrush="#FFDADADA"
                        BorderThickness="0,0,1,1"
                        CornerRadius="3">
                    <Border BorderBrush="#B2ADBDD1"
                            BorderThickness="1"
                            CornerRadius="2">
                        <StackPanel Orientation="Horizontal">
                            <Border Width="108"
                                    Height="108"
                                    Margin="10 0 0 0"
                                    BorderBrush="#FFE0E0E0"
                                    BorderThickness="1">
                                <Image Source="/Images/item4.png" Stretch="None" />
                            </Border>
                            <StackPanel Margin="10 25 15 0">
                                <TextBlock Margin="0 0 0 5"
                                           FontFamily="Segoe UI"
                                           FontSize="16"
                                           Foreground="#FF0099CC"
                                           Text="Emily Smile" />
                                <TextBlock Margin="0 0 0 5"
                                           FontFamily="Segoe UI"
                                           FontSize="11"
                                           Text="EmilySmile@mail.com" />
                                <TextBlock FontFamily="Segoe UI"
                                           FontSize="10.667"
                                           Text="Phone: 333 2334" />
                            </StackPanel>
                        </StackPanel>
                    </Border>
                </Border>
            </Grid>
        </telerik:RadExpander.Content>
    </telerik:RadExpander>
	{{endregion}}

![](images/RadExpander_GettingStarted_Demo.png)

# See Also

 * [Expand Direction]({%slug radexpander-features-expand_direction%})

 * [Alignment]({%slug radexpander-features-alignment%})

 * [Expander Animation]({%slug radexpander-howto-animation%})

 * [How To Change the Action Trigering an Expand]({%slug radexpander-howto-change-expand-action%})
