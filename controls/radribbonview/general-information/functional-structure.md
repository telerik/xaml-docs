---
title: Functional Structure
page_title: Functional Structure
description: Check our &quot;Functional Structure&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-functional-structure
tags: functional,structure
published: True
position: 2
---

# Functional Structure

This topic aims to explain the controls' structure needed to create a fully functional __RadRibbonView__ control.			

>Before proceeding with this topic, it is recommended to get familiar with the [Visual Structure]({%slug radribbonview-visual-structure%}) of the __RadRibbonView__ control.

<!-- -->
>This section defines the functional structure of the __RadRibbonView__ which you have to get familiar with before you continue reading the other topics of this help.				

## Fundamentals

The root level container is the __RadRibbonView__ itself. It is separated in two main areas: the __title bar__ and the __tabs container__. The __title bar__ contains the application menu button, the Quick Access Toolbar and the application title, while the __tabs container__ is the place where all of your __RadRibbonTabs__ are hosted just like the tabs of the standard tab control. One single __RadRibbonView__ can contain as many tabs as needed. The only restriction here is the visual area of your application.				

Here is how a sample XAML declaration of these elements looks like:



```XAML
	<telerik:RadRibbonView x:Name="radRibbonView" Title="My Title" ApplicationName="My Application">
	    <telerik:RadRibbonView.Backstage>
	        <telerik:RadRibbonBackstage />
	    </telerik:RadRibbonView.Backstage>
	    <telerik:RadRibbonView.QuickAccessToolBar>
	        <telerik:QuickAccessToolBar />
	    </telerik:RadRibbonView.QuickAccessToolBar>
	    <telerik:RadRibbonTab Header="Home" />
	    <telerik:RadRibbonTab Header="View" />
	    <telerik:RadRibbonTab Header="Text" />
	</telerik:RadRibbonView>
```

As you can see, the declared structure is pretty staright-forward. You have an empty Backstage menu, an empty Quick Access Toolbar and three empty tabs added as children to the __RadRibbonView__. The title and the application name are defined as attributes of the __RadRibbonView__.				

## Backstage menu

The Backstage control is basically an ItemsControl that can be used to display controls, used to perform actions on the entire document, like Save, Print and Send. The __RibbonBackstage__ can also provide a list of recent documents, access to application options for changing user settings and preferences, and application exit.				

Here is how a sample XAML declaration of these elements looks like:



```XAML
	<telerik:RadRibbonView.Backstage>
	    <telerik:RadRibbonBackstage>
	        <telerik:RadRibbonBackstageItem CloseOnClick="False" Header="Save" Icon="Images/Save.png"
	                IsSelectable="False" />
	        <telerik:RadRibbonBackstageItem Header="Save As" Icon="Images/SaveAs.png" IsSelectable="False" />
	        <telerik:RadRibbonBackstageItem Header="Open" Icon="Images/Open.png" IsSelectable="False" />
	        <telerik:RadRibbonBackstageItem Header="Separator" IsGroupSeparator="True" />
	        <telerik:RadRibbonBackstageItem Header="Recent" IsDefault="True">
	            <Grid>
	                <Grid.ColumnDefinitions>
	                    <ColumnDefinition Width="*" />
	                    <ColumnDefinition Width="Auto" />
	                    <ColumnDefinition Width="*" />
	                </Grid.ColumnDefinitions>
	                <StackPanel Margin="15 15 0 0">
	                    <TextBlock Margin="0 0 0 2" FontSize="14" FontWeight="Bold" Text="Recent Documents" />
	                    <Rectangle Height="1">
	                        <Rectangle.Fill>
	                            <LinearGradientBrush MappingMode="Absolute" SpreadMethod="Repeat"
	                                    StartPoint="0,0.5" EndPoint="4,0.5">
	                                <GradientStop Offset="0" Color="#40000000" />
	                                <GradientStop Offset="0.5" Color="#40000000" />
	                                <GradientStop Offset="0.501" Color="Transparent" />
	                            </LinearGradientBrush>
	                        </Rectangle.Fill>
	                    </Rectangle>
	                    <ItemsControl Margin="0 4 0 0">
	                        <telerik:RadRibbonButton Width="285">
	                            <StackPanel Orientation="Horizontal">
	                                <Image Source="Images/Document.png" />
	                                <StackPanel Margin="3 0 0 0" HorizontalAlignment="Left">
	                                    <TextBlock Margin="0 0 0 2" Text="RadRibbonViewSpecifications" />
	                                    <TextBlock Foreground="DimGray" Text="c:\Users\afuller\Documents" />
	                                </StackPanel>
	                            </StackPanel>
	                        </telerik:RadRibbonButton>
	                        <telerik:RadRibbonButton Width="285">
	                            <StackPanel Orientation="Horizontal">
	                                <Image Source="Images/Document.png" />
	                                <StackPanel Margin="3 0 0 0" HorizontalAlignment="Left">
	                                    <TextBlock Margin="0 0 0 2" Text="RadRibbonBackstageSpecifications" />
	                                    <TextBlock Foreground="DimGray" Text="c:\Users\afuller\Documents" />
	                                </StackPanel>
	                            </StackPanel>
	                        </telerik:RadRibbonButton>
	                        <telerik:RadRibbonButton Width="285">
	                            <StackPanel Orientation="Horizontal">
	                                <Image Source="Images/Document.png" />
	                                <StackPanel Margin="3 0 0 0" HorizontalAlignment="Left">
	                                    <TextBlock Margin="0 0 0 2" Text="RadRibbonBackstageItemSpecifications" />
	                                    <TextBlock Foreground="DimGray" Text="c:\Users\afuller\Documents" />
	                                </StackPanel>
	                            </StackPanel>
	                        </telerik:RadRibbonButton>
	                        <telerik:RadRibbonButton Width="285">
	                            <StackPanel Orientation="Horizontal">
	                                <Image Source="Images/Document.png" />
	                                <StackPanel Margin="3 0 0 0" HorizontalAlignment="Left">
	                                    <TextBlock Margin="0 0 0 2" Text="DevReach 2010" />
	                                    <TextBlock Foreground="DimGray" Text="c:\My Documents" />
	                                </StackPanel>
	                            </StackPanel>
	                        </telerik:RadRibbonButton>
	                    </ItemsControl>
	                </StackPanel>
	                <Rectangle Grid.Column="1" Width="1" Margin="10, 5">
	                    <Rectangle.Fill>
	                        <LinearGradientBrush StartPoint="0.5,0" EndPoint="0.5,1">
	                            <GradientStop Offset="0" Color="#10000000" />
	                            <GradientStop Offset="0.15" Color="#40000000" />
	                            <GradientStop Offset="0.95" Color="#40000000" />
	                            <GradientStop Offset="1" Color="#10000000" />
	                        </LinearGradientBrush>
	                    </Rectangle.Fill>
	                </Rectangle>
	                <StackPanel Grid.Column="2" Margin="5 15 7 0">
	                    <TextBlock Margin="0 0 0 2" FontSize="14" FontWeight="Bold" Text="Recent Places" />
	                    <Rectangle Height="1">
	                        <Rectangle.Fill>
	                            <LinearGradientBrush MappingMode="Absolute" SpreadMethod="Repeat"
	                                    StartPoint="0,0.5" EndPoint="4,0.5">
	                                <GradientStop Offset="0" Color="#40000000" />
	                                <GradientStop Offset="0.5" Color="#40000000" />
	                                <GradientStop Offset="0.501" Color="Transparent" />
	                            </LinearGradientBrush>
	                        </Rectangle.Fill>
	                    </Rectangle>
	                    <ItemsControl Margin="0 4 0 0">
	                        <telerik:RadRibbonButton Width="285">
	                            <StackPanel Orientation="Horizontal">
	                                <Image Source="Images/Document.png" />
	                                <StackPanel Margin="3 0 0 0" HorizontalAlignment="Left">
	                                    <TextBlock Margin="0 0 0 2" Text="My Documents" />
	                                    <TextBlock Foreground="DimGray" Text="c:\Users\afuller\Documents" />
	                                </StackPanel>
	                            </StackPanel>
	                        </telerik:RadRibbonButton>
	                        <telerik:RadRibbonButton Width="285">
	                            <StackPanel Orientation="Horizontal">
	                                <Image Source="Images/Document.png" />
	                                <StackPanel Margin="3 0 0 0" HorizontalAlignment="Left">
	                                    <TextBlock Margin="0 0 0 2" Text="Downloads" />
	                                    <TextBlock Foreground="DimGray" Text="c:\Users\afuller\Downloads" />
	                                </StackPanel>
	                            </StackPanel>
	                        </telerik:RadRibbonButton>
	                    </ItemsControl>
	                </StackPanel>
	            </Grid>
	        </telerik:RadRibbonBackstageItem>
	        <telerik:RadRibbonBackstageItem Header="New" IsSelected="True">
	            <StackPanel Margin="15 15 0 0">
	                <TextBlock Margin="0 0 0 2" FontSize="14" FontWeight="Bold" Text="Available Templates" />
	                <Rectangle Height="1">
	                    <Rectangle.Fill>
	                        <LinearGradientBrush MappingMode="Absolute" SpreadMethod="Repeat" StartPoint="0,0.5"
	                                EndPoint="4,0.5">
	                            <GradientStop Offset="0" Color="#40000000" />
	                            <GradientStop Offset="0.5" Color="#40000000" />
	                            <GradientStop Offset="0.501" Color="Transparent" />
	                        </LinearGradientBrush>
	                    </Rectangle.Fill>
	                </Rectangle>
	                <ItemsControl>
	                    <ItemsControl.ItemsPanel>
	                        <ItemsPanelTemplate>
	                            <telerik:RadWrapPanel />
	                        </ItemsPanelTemplate>
	                    </ItemsControl.ItemsPanel>
	                    <telerik:RadRibbonButton>
	                        <Grid Width="80">
	                            <Grid.RowDefinitions>
	                                <RowDefinition Height="Auto" />
	                                <RowDefinition />
	                            </Grid.RowDefinitions>
	                            <Image Source="Images/DocTemplateNew.png" Stretch="None" />
	                            <TextBlock Grid.Row="1" Margin="2" HorizontalAlignment="Center"
	                                    Text="Blank Document" TextWrapping="Wrap" />
	                        </Grid>
	                    </telerik:RadRibbonButton>
	                    <telerik:RadRibbonButton>
	                        <Grid Width="80">
	                            <Grid.RowDefinitions>
	                                <RowDefinition Height="Auto" />
	                                <RowDefinition />
	                            </Grid.RowDefinitions>
	                            <Image Source="Images/DocTemplateBlogPost.png" Stretch="None" />
	                            <TextBlock Grid.Row="1" Margin="2" HorizontalAlignment="Center" Text="Blog Post"
	                                    TextWrapping="Wrap" />
	                        </Grid>
	                    </telerik:RadRibbonButton>
	                    <telerik:RadRibbonButton>
	                        <Grid Width="80">
	                            <Grid.RowDefinitions>
	                                <RowDefinition Height="Auto" />
	                                <RowDefinition />
	                            </Grid.RowDefinitions>
	                            <Image Source="Images/DocTemplateRecent.png" Stretch="None" />
	                            <TextBlock Grid.Row="1" Margin="2" HorizontalAlignment="Center"
	                                    Text="Recent Templates" TextWrapping="Wrap" />
	                        </Grid>
	                    </telerik:RadRibbonButton>
	                    <telerik:RadRibbonButton>
	                        <Grid Width="80">
	                            <Grid.RowDefinitions>
	                                <RowDefinition Height="Auto" />
	                                <RowDefinition />
	                            </Grid.RowDefinitions>
	                            <Image Source="Images/DocTemplateSamples.png" Stretch="None" />
	                            <TextBlock Grid.Row="1" Margin="2" HorizontalAlignment="Center"
	                                    Text="Sample Templates" TextWrapping="Wrap" />
	                        </Grid>
	                    </telerik:RadRibbonButton>
	                    <telerik:RadRibbonButton>
	                        <Grid Width="80">
	                            <Grid.RowDefinitions>
	                                <RowDefinition Height="Auto" />
	                                <RowDefinition />
	                            </Grid.RowDefinitions>
	                            <Image Source="Images/DocTemplateMy.png" Stretch="None" />
	                            <TextBlock Grid.Row="1" Margin="2" HorizontalAlignment="Center"
	                                    Text="My Templates" TextWrapping="Wrap" />
	                        </Grid>
	                    </telerik:RadRibbonButton>
	                    <telerik:RadRibbonButton>
	                        <Grid Width="80">
	                            <Grid.RowDefinitions>
	                                <RowDefinition Height="Auto" />
	                                <RowDefinition />
	                            </Grid.RowDefinitions>
	                            <Image Source="Images/DocTemplateNewBasedOn.png" Stretch="None" />
	                            <TextBlock Grid.Row="1" Margin="2" HorizontalAlignment="Center"
	                                    Text="New from Existing" TextWrapping="Wrap" />
	                        </Grid>
	                    </telerik:RadRibbonButton>
	                </ItemsControl>
	            </StackPanel>
	        </telerik:RadRibbonBackstageItem>
	        <telerik:RadRibbonBackstageItem Header="Exit" Icon="Images/Exit.png" IsSelectable="False" />
	    </telerik:RadRibbonBackstage>
	</telerik:RadRibbonView.Backstage>
```

For more information take a look at the [Backstage]({%slug radribbonview-ribbon-backstage%}) topic.				

## Quick Access Toolbar

The Quick Access Toolbar is composed of two parts: 
* __Toolbar__ - used to host some commonly used actions.
* __Menu__ - contains menu items for minimization or changing the position of the __RadRibbonView__.					

Currently you can only add or remove buttons to the toolbar but cannot modify its menu.

Here is how a sample XAML declaration of these elements looks like:



```XAML
	<telerik:RadRibbonView.QuickAccessToolBar>
	    <telerik:QuickAccessToolBar>
	        <telerik:RadRibbonButton Content="Save" Foreground="Gray" />
	        <telerik:RadRibbonButton Content="Undo" Foreground="Gray" />
	        <telerik:RadRibbonButton Content="Redo" Foreground="Gray" />
	    </telerik:QuickAccessToolBar>
	</telerik:RadRibbonView.QuickAccessToolBar>
```

As you can see the declaration of the Quick Access Toolbar contains three buttons: "Save", "Undo" and "Redo".

For more information take a look at the [Quick Access ToolBar]({%slug radribbonview-qat%}) topic.				

## RadRibbonTab

The __RadRibbonTab__ is the main container control of the __RadRibbonView__. It is actually a tab page that's ment to host your buttons, check boxes, combo boxes, galleries and all the other types of controls that you need. The __RadRibbonTab__ consists of two parts:				
* __Header__ - used to display informational text (i.e. "Formatting") that describes the kind of actions it contains.
* __Content Area__ - this is the area where all your controls are going to be placed in.					

You never add your controls to the __RadRibbonTab__ directly. Instead they should be always placed inside of __RadRibbonGroups__. The __RadRibbonGroup__ container is used to organize your controls in groups and to re-arrange them correctly when the parent container is resized. Additionally you can group your buttons in __RadButtonGroup,__ while all other controls can be hosted in any other container.				

Here is how a sample XAML declaration of these elements looks like:



```XAML
	<telerik:RadRibbonTab Header="Home">
	    <telerik:RadRibbonGroup Header="Text">
	        <telerik:RadButtonGroup>
	            <telerik:RadRibbonButton SmallImage="Images/IconMSOffice/16/bold.png" />
	            <telerik:RadRibbonButton SmallImage="Images/IconMSOffice/16/italic.png" />
	            <telerik:RadRibbonButton SmallImage="Images/IconMSOffice/16/underline.png" />
	        </telerik:RadButtonGroup>
	        <telerik:RadRibbonGallery Title="Styles" ItemWidth="72" ItemHeight="56">
	            <telerik:RadGalleryItem Image="Images/IconMSOffice/paragraph.png" />
	            <telerik:RadGalleryItem Image="Images/IconMSOffice/paragraph1.png" />
	            <telerik:RadGalleryItem Image="Images/IconMSOffice/paragraph2.png" />
	            <telerik:RadGalleryItem Image="Images/IconMSOffice/paragraph3.png" />
	            <telerik:RadGalleryItem Image="Images/IconMSOffice/paragraph4.png" />
	            <telerik:RadGalleryItem Image="Images/IconMSOffice/paragraph5.png" />
	        </telerik:RadRibbonGallery>
	    </telerik:RadRibbonGroup>
	    <telerik:RadRibbonGroup Header="Page">
	        <telerik:RadRibbonRadioButton Size="Large" LargeImage="Images/IconMSOffice/32/Footer.png" />
	        <telerik:RadRibbonRadioButton Size="Large" LargeImage="Images/IconMSOffice/32/PageBreak.png" />
	    </telerik:RadRibbonGroup>
	</telerik:RadRibbonTab>
```

As you can see two __RadRibbonGroups__ - "Text" and "Page", have been declared. The first one - "Text", contains a button group with three buttons inside, plus a __RadRibbonGallery__ with 6 gallery items. The second group - "Page", contains two radio buttons with their size set to __Large__.

Here you can see how the whole XAML declaration of the __RadRibbonView__ looks like:



```XAML
	<telerik:RadRibbonView x:Name="radRibbonView" Title="My Title" ApplicationName="My Application">
	    <telerik:RadRibbonView.Backstage>
	        <telerik:RadRibbonBackstage>
	            <telerik:RadRibbonBackstageItem CloseOnClick="False" Header="Save" Icon="Images/Save.png"
	                    IsSelectable="False" />
	            <telerik:RadRibbonBackstageItem Header="Save As" Icon="Images/SaveAs.png" IsSelectable="False" />
	            <telerik:RadRibbonBackstageItem Header="Open" Icon="Images/Open.png" IsSelectable="False" />
	            <telerik:RadRibbonBackstageItem Header="Separator" IsGroupSeparator="True" />
	            <telerik:RadRibbonBackstageItem Header="Recent" IsDefault="True">
	                <Grid>
	                    <Grid.ColumnDefinitions>
	                        <ColumnDefinition Width="*" />
	                        <ColumnDefinition Width="Auto" />
	                        <ColumnDefinition Width="*" />
	                    </Grid.ColumnDefinitions>
	                    <StackPanel Margin="15 15 0 0">
	                        <TextBlock Margin="0 0 0 2" FontSize="14" FontWeight="Bold" Text="Recent Documents" />
	                        <Rectangle Height="1">
	                            <Rectangle.Fill>
	                                <LinearGradientBrush MappingMode="Absolute" SpreadMethod="Repeat"
	                                        StartPoint="0,0.5" EndPoint="4,0.5">
	                                    <GradientStop Offset="0" Color="#40000000" />
	                                    <GradientStop Offset="0.5" Color="#40000000" />
	                                    <GradientStop Offset="0.501" Color="Transparent" />
	                                </LinearGradientBrush>
	                            </Rectangle.Fill>
	                        </Rectangle>
	                        <ItemsControl Margin="0 4 0 0">
	                            <telerik:RadRibbonButton Width="285">
	                                <StackPanel Orientation="Horizontal">
	                                    <Image Source="Images/Document.png" />
	                                    <StackPanel Margin="3 0 0 0" HorizontalAlignment="Left">
	                                        <TextBlock Margin="0 0 0 2" Text="RadRibbonViewSpecifications" />
	                                        <TextBlock Foreground="DimGray" Text="c:\Users\afuller\Documents" />
	                                    </StackPanel>
	                                </StackPanel>
	                            </telerik:RadRibbonButton>
	                            <telerik:RadRibbonButton Width="285">
	                                <StackPanel Orientation="Horizontal">
	                                    <Image Source="Images/Document.png" />
	                                    <StackPanel Margin="3 0 0 0" HorizontalAlignment="Left">
	                                        <TextBlock Margin="0 0 0 2" Text="RadRibbonBackstageSpecifications" />
	                                        <TextBlock Foreground="DimGray" Text="c:\Users\afuller\Documents" />
	                                    </StackPanel>
	                                </StackPanel>
	                            </telerik:RadRibbonButton>
	                            <telerik:RadRibbonButton Width="285">
	                                <StackPanel Orientation="Horizontal">
	                                    <Image Source="Images/Document.png" />
	                                    <StackPanel Margin="3 0 0 0" HorizontalAlignment="Left">
	                                        <TextBlock Margin="0 0 0 2" Text="RadRibbonBackstageItemSpecifications" />
	                                        <TextBlock Foreground="DimGray" Text="c:\Users\afuller\Documents" />
	                                    </StackPanel>
	                                </StackPanel>
	                            </telerik:RadRibbonButton>
	                            <telerik:RadRibbonButton Width="285">
	                                <StackPanel Orientation="Horizontal">
	                                    <Image Source="Images/Document.png" />
	                                    <StackPanel Margin="3 0 0 0" HorizontalAlignment="Left">
	                                        <TextBlock Margin="0 0 0 2" Text="DevReach 2010" />
	                                        <TextBlock Foreground="DimGray" Text="c:\My Documents" />
	                                    </StackPanel>
	                                </StackPanel>
	                            </telerik:RadRibbonButton>
	                        </ItemsControl>
	                    </StackPanel>
	                    <Rectangle Grid.Column="1" Width="1" Margin="10, 5">
	                        <Rectangle.Fill>
	                            <LinearGradientBrush StartPoint="0.5,0" EndPoint="0.5,1">
	                                <GradientStop Offset="0" Color="#10000000" />
	                                <GradientStop Offset="0.15" Color="#40000000" />
	                                <GradientStop Offset="0.95" Color="#40000000" />
	                                <GradientStop Offset="1" Color="#10000000" />
	                            </LinearGradientBrush>
	                        </Rectangle.Fill>
	                    </Rectangle>
	                    <StackPanel Grid.Column="2" Margin="5 15 7 0">
	                        <TextBlock Margin="0 0 0 2" FontSize="14" FontWeight="Bold" Text="Recent Places" />
	                        <Rectangle Height="1">
	                            <Rectangle.Fill>
	                                <LinearGradientBrush MappingMode="Absolute" SpreadMethod="Repeat"
	                                        StartPoint="0,0.5" EndPoint="4,0.5">
	                                    <GradientStop Offset="0" Color="#40000000" />
	                                    <GradientStop Offset="0.5" Color="#40000000" />
	                                    <GradientStop Offset="0.501" Color="Transparent" />
	                                </LinearGradientBrush>
	                            </Rectangle.Fill>
	                        </Rectangle>
	                        <ItemsControl Margin="0 4 0 0">
	                            <telerik:RadRibbonButton Width="285">
	                                <StackPanel Orientation="Horizontal">
	                                    <Image Source="Images/Document.png" />
	                                    <StackPanel Margin="3 0 0 0" HorizontalAlignment="Left">
	                                        <TextBlock Margin="0 0 0 2" Text="My Documents" />
	                                        <TextBlock Foreground="DimGray" Text="c:\Users\afuller\Documents" />
	                                    </StackPanel>
	                                </StackPanel>
	                            </telerik:RadRibbonButton>
	                            <telerik:RadRibbonButton Width="285">
	                                <StackPanel Orientation="Horizontal">
	                                    <Image Source="Images/Document.png" />
	                                    <StackPanel Margin="3 0 0 0" HorizontalAlignment="Left">
	                                        <TextBlock Margin="0 0 0 2" Text="Downloads" />
	                                        <TextBlock Foreground="DimGray" Text="c:\Users\afuller\Downloads" />
	                                    </StackPanel>
	                                </StackPanel>
	                            </telerik:RadRibbonButton>
	                        </ItemsControl>
	                    </StackPanel>
	                </Grid>
	            </telerik:RadRibbonBackstageItem>
	            <telerik:RadRibbonBackstageItem Header="New" IsSelected="True">
	                <StackPanel Margin="15 15 0 0">
	                    <TextBlock Margin="0 0 0 2" FontSize="14" FontWeight="Bold" Text="Available Templates" />
	                    <Rectangle Height="1">
	                        <Rectangle.Fill>
	                            <LinearGradientBrush MappingMode="Absolute" SpreadMethod="Repeat" StartPoint="0,0.5"
	                                    EndPoint="4,0.5">
	                                <GradientStop Offset="0" Color="#40000000" />
	                                <GradientStop Offset="0.5" Color="#40000000" />
	                                <GradientStop Offset="0.501" Color="Transparent" />
	                            </LinearGradientBrush>
	                        </Rectangle.Fill>
	                    </Rectangle>
	                    <ItemsControl>
	                        <ItemsControl.ItemsPanel>
	                            <ItemsPanelTemplate>
	                                <telerik:RadWrapPanel />
	                            </ItemsPanelTemplate>
	                        </ItemsControl.ItemsPanel>
	                        <telerik:RadRibbonButton>
	                            <Grid Width="80">
	                                <Grid.RowDefinitions>
	                                    <RowDefinition Height="Auto" />
	                                    <RowDefinition />
	                                </Grid.RowDefinitions>
	                                <Image Source="Images/DocTemplateNew.png" Stretch="None" />
	                                <TextBlock Grid.Row="1" Margin="2" HorizontalAlignment="Center"
	                                        Text="Blank Document" TextWrapping="Wrap" />
	                            </Grid>
	                        </telerik:RadRibbonButton>
	                        <telerik:RadRibbonButton>
	                            <Grid Width="80">
	                                <Grid.RowDefinitions>
	                                    <RowDefinition Height="Auto" />
	                                    <RowDefinition />
	                                </Grid.RowDefinitions>
	                                <Image Source="Images/DocTemplateBlogPost.png" Stretch="None" />
	                                <TextBlock Grid.Row="1" Margin="2" HorizontalAlignment="Center" Text="Blog Post"
	                                        TextWrapping="Wrap" />
	                            </Grid>
	                        </telerik:RadRibbonButton>
	                        <telerik:RadRibbonButton>
	                            <Grid Width="80">
	                                <Grid.RowDefinitions>
	                                    <RowDefinition Height="Auto" />
	                                    <RowDefinition />
	                                </Grid.RowDefinitions>
	                                <Image Source="Images/DocTemplateRecent.png" Stretch="None" />
	                                <TextBlock Grid.Row="1" Margin="2" HorizontalAlignment="Center"
	                                        Text="Recent Templates" TextWrapping="Wrap" />
	                            </Grid>
	                        </telerik:RadRibbonButton>
	                        <telerik:RadRibbonButton>
	                            <Grid Width="80">
	                                <Grid.RowDefinitions>
	                                    <RowDefinition Height="Auto" />
	                                    <RowDefinition />
	                                </Grid.RowDefinitions>
	                                <Image Source="Images/DocTemplateSamples.png" Stretch="None" />
	                                <TextBlock Grid.Row="1" Margin="2" HorizontalAlignment="Center"
	                                        Text="Sample Templates" TextWrapping="Wrap" />
	                            </Grid>
	                        </telerik:RadRibbonButton>
	                        <telerik:RadRibbonButton>
	                            <Grid Width="80">
	                                <Grid.RowDefinitions>
	                                    <RowDefinition Height="Auto" />
	                                    <RowDefinition />
	                                </Grid.RowDefinitions>
	                                <Image Source="Images/DocTemplateMy.png" Stretch="None" />
	                                <TextBlock Grid.Row="1" Margin="2" HorizontalAlignment="Center"
	                                        Text="My Templates" TextWrapping="Wrap" />
	                            </Grid>
	                        </telerik:RadRibbonButton>
	                        <telerik:RadRibbonButton>
	                            <Grid Width="80">
	                                <Grid.RowDefinitions>
	                                    <RowDefinition Height="Auto" />
	                                    <RowDefinition />
	                                </Grid.RowDefinitions>
	                                <Image Source="Images/DocTemplateNewBasedOn.png" Stretch="None" />
	                                <TextBlock Grid.Row="1" Margin="2" HorizontalAlignment="Center"
	                                        Text="New from Existing" TextWrapping="Wrap" />
	                            </Grid>
	                        </telerik:RadRibbonButton>
	                    </ItemsControl>
	                </StackPanel>
	            </telerik:RadRibbonBackstageItem>
	            <telerik:RadRibbonBackstageItem Header="Exit" Icon="Images/Exit.png" IsSelectable="False" />
	        </telerik:RadRibbonBackstage>
	    </telerik:RadRibbonView.Backstage>
	    <telerik:RadRibbonView.QuickAccessToolBar>
	        <telerik:QuickAccessToolBar>
	            <telerik:RadRibbonButton Content="Save" Foreground="Gray" />
	            <telerik:RadRibbonButton Content="Undo" Foreground="Gray" />
	            <telerik:RadRibbonButton Content="Redo" Foreground="Gray" />
	        </telerik:QuickAccessToolBar>
	    </telerik:RadRibbonView.QuickAccessToolBar>
	    <telerik:RadRibbonTab Header="Home">
	        <telerik:RadRibbonGroup Header="Text">
	            <telerik:RadButtonGroup>
	                <telerik:RadRibbonButton SmallImage="Images/IconMSOffice/16/bold.png" />
	                <telerik:RadRibbonButton SmallImage="Images/IconMSOffice/16/italic.png" />
	                <telerik:RadRibbonButton SmallImage="Images/IconMSOffice/16/underline.png" />
	            </telerik:RadButtonGroup>
	            <telerik:RadRibbonGallery Title="Styles" ItemWidth="72" ItemHeight="56">
	                <telerik:RadGalleryItem Image="Images/IconMSOffice/paragraph.png" />
	                <telerik:RadGalleryItem Image="Images/IconMSOffice/paragraph1.png" />
	                <telerik:RadGalleryItem Image="Images/IconMSOffice/paragraph2.png" />
	                <telerik:RadGalleryItem Image="Images/IconMSOffice/paragraph3.png" />
	                <telerik:RadGalleryItem Image="Images/IconMSOffice/paragraph4.png" />
	                <telerik:RadGalleryItem Image="Images/IconMSOffice/paragraph5.png" />
	            </telerik:RadRibbonGallery>
	        </telerik:RadRibbonGroup>
	        <telerik:RadRibbonGroup Header="Page">
	            <telerik:RadRibbonRadioButton Size="Large" LargeImage="Images/IconMSOffice/32/Footer.png" />
	            <telerik:RadRibbonRadioButton Size="Large" LargeImage="Images/IconMSOffice/32/PageBreak.png" />
	        </telerik:RadRibbonGroup>
	    </telerik:RadRibbonTab>
	    <telerik:RadRibbonTab Header="View" />
	    <telerik:RadRibbonTab Header="Text" />
	</telerik:RadRibbonView>
```

![{{ site.framework_name }} RadRibbonView Example Functional Structure](images/RibbonView_Functional_Structure.png)

This RibbonView is far from being ready but at least it illustrates the element's structure you have to follow in order to have a fully functional __RadRibbonView__.

## References

The __RadRibbonView__ consists of various elements, for more information on each of them take a look at the topics below:
* [Application Menu]({%slug radribbonview-applicationmenu%})
* [Backstage]({%slug radribbonview-ribbon-backstage%})
* [Quick Access ToolBar]({%slug radribbonview-qat%})
* [Ribbon Tab]({%slug radribbonview-ribbon-tab%})
* [Ribbon Group]({%slug radribbonview-ribbon-group%})
* [Ribbon Buttons]({%slug radribbonview-buttons-overview%})
* [Ribbon ComboBox]({%slug radribbonview-ribbon-combobox%})
* [Screen Tips]({%slug radribbonview-screentips%})

Additional features that you may find interesting are:
* [Selection]({%slug radribbonview-selection%})
* [Resizing]({%slug radribbonview-resizing%})
* [Minimization]({%slug radribbonview-minimization%})
* [Localization]({%slug radribbonview-localization%})
* [Styling and Appearance]({%slug radribbonview-styling-overview%})