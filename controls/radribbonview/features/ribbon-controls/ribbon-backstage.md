---
title: Ribbon Backstage
page_title: Ribbon Backstage
description: Ribbon Backstage
slug: radribbonview-ribbon-backstage
tags: ribbon,backstage
published: True
position: 2
---

# Ribbon Backstage

Telerik __RadRibbonView__ provides a simple and consistent way for building interfaces similar to the ribbon control used in Microsoft Office. The new __Ribbon__ __Backstage__ control allows you to achieve a more native Office 2010 look and feel of your application.

## RibbonBackstage Fundamentals

The __RibbonBackstage__ appears when a user __clicks__ the __Application Button__. It can be used to display controls, used to perform actions on the entire document, like Save, Print and Send. The __RibbonBackstage__ can also provide a list of recent documents, access to application options for changing user settings and preferences, and application exit.

By default the __Backstage__ isn't opened. In order to control its state you can set the __RadRibbonView__'s __IsBackstageOpen__ property.

#### __XAML__
{{region radribbonview-ribbon-backstage_0}}
	<telerik:RadRibbonView x:Name="radRibbonView" Title="My Title" ApplicationName="My Application" IsBackstageOpen="True">
	 ...
	</telerik:RadRibbonView>
{{endregion}}

## Adding Backstage to the RadRibbonView

In order to add a backstage to your __RadRibbonView__ control you need to set the __RadRibbonView__'s __Backstage__ property. The next several code-snippets show you how to do that in XAML, as well as in the code-behind.

#### __XAML__
{{region radribbonview-ribbon-backstage_1}}
	<telerik:RadRibbonView x:Name="radRibbonView" Title="My Title" ApplicationName="My Application">
	    <telerik:RadRibbonView.Backstage>
	        <telerik:RadRibbonBackstage />
	    </telerik:RadRibbonView.Backstage>
	</telerik:RadRibbonView>
{{endregion}}

#### __C#__
{{region radribbonview-ribbon-backstage_2}}
	this.radRibbonView.Backstage = new RadRibbonBackstage();
{{endregion}}

#### __VB.NET__
{{region radribbonview-ribbon-backstage_3}}
	Me.radRibbonView.Backstage = New RadRibbonBackstage()
{{endregion}}

![](images/RadRibbonView_Backstage_Empty.png)

## Adding Backstage Items

The __Backstage__ control derives from the __RadTabControl__. That fact allows you to easily customize it by adding/removing __BackstageItems__ (the __BackstageItem__ derives from a __RadTabItem__).

#### __XAML__
{{region radribbonview-ribbon-backstage_4}}
	<telerik:RadRibbonView x:Name="radRibbonView" 
	                        Title="My Title"
	                        ApplicationButtonContent="File"
	                        ApplicationName="My Application">
	    <telerik:RadRibbonView.Backstage>
	        <telerik:RadRibbonBackstage>
	            <telerik:RadRibbonBackstageItem Header="Save" />
	            <telerik:RadRibbonBackstageItem Header="Save As" />
	            <telerik:RadRibbonBackstageItem Header="Open" />
	            <telerik:RadRibbonBackstageItem Header="Recent" />
	            <telerik:RadRibbonBackstageItem Header="New" />
	            <telerik:RadRibbonBackstageItem Header="Options" />
	            <telerik:RadRibbonBackstageItem Header="Exit" />
	        </telerik:RadRibbonBackstage>
	    </telerik:RadRibbonView.Backstage>
	</telerik:RadRibbonView>
{{endregion}}

## BackstageItem Properties

The __BackstageItem__ exposes the following properties that allow you to further customize it:

* __IsSelectable__ - specifies whether an item can be selected. If you set this property to __False__, the item will behave like a __Button__. 

	>If the __BackstageItem__ __IsSelectable__ property is set to __False__, you will be able to take advantage of the __Click()__ event of the item, as well as its __Command__ property.

* __IsDefault__ - specifies whether the item should be selected when the __Backstage__ is opened. 

	>Please note that if you set the __IsDefault__ property of multiple __BackstageItems__ to __True__, the last one marked as default will be selected.

* __IsGroupSeparator__ - specifies whether an item is a group separator. Such items are used as a heading in order to differentiate a logical group of __BackstageItems__.

* __Icon__ - gets or sets __BackstageItem__ icon 

* __CloseOnClick__ - specifies whether the __Backstage__ will be closed when the item is clicked. 

	>If the __BackstageItem__ is not selectable the __CloseOnClick__ property is set to __True__ by default. However, if the item is selectable, then the __CloseOnClick__ property won't affect its behavior.

#### __XAML__
{{region radribbonview-ribbon-backstage_5}}
	<telerik:RadRibbonView x:Name="radRibbonView" 
	                        Title="My Title"
	                        ApplicationName="My Application">
	    <telerik:RadRibbonView.Backstage>
	        <telerik:RadRibbonBackstage>
	            <telerik:RadRibbonBackstageItem CloseOnClick="False" 
	                                            Header="Save"
	                                            Icon="Images/Save.png"
	                                            IsSelectable="False" />
	            <telerik:RadRibbonBackstageItem Header="Save As" 
	                                            Icon="Images/SaveAs.png"
	                                            IsSelectable="False" />
	            <telerik:RadRibbonBackstageItem Header="Open" 
	                                            Icon="Images/Open.png"
	                                            IsSelectable="False" />
	            <telerik:RadRibbonBackstageItem Header="Separator" IsGroupSeparator="True" />
	            <telerik:RadRibbonBackstageItem Header="Recent" IsDefault="True">
	                <Grid>
	                    <Grid.ColumnDefinitions>
	                        <ColumnDefinition Width="*" />
	                        <ColumnDefinition Width="Auto" />
	                        <ColumnDefinition Width="*" />
	                    </Grid.ColumnDefinitions>
	                    <StackPanel Margin="15 15 0 0">
	                        <TextBlock Margin="0 0 0 2" 
	                                    FontSize="14"
	                                    FontWeight="Bold"
	                                    Text="Recent Documents" />
	                        <Rectangle Height="1">
	                            <Rectangle.Fill>
	                                <LinearGradientBrush MappingMode="Absolute" SpreadMethod="Repeat" StartPoint="0,0.5" EndPoint="4,0.5">
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
	                    <Rectangle Grid.Column="1" 
	                                Width="1"
	                                Margin="10, 5">
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
	                        <TextBlock Margin="0 0 0 2" 
	                                    FontSize="14"
	                                    FontWeight="Bold"
	                                    Text="Recent Places" />
	                        <Rectangle Height="1">
	                            <Rectangle.Fill>
	                                <LinearGradientBrush MappingMode="Absolute" SpreadMethod="Repeat" StartPoint="0,0.5" EndPoint="4,0.5">
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
	                    <TextBlock Margin="0 0 0 2" 
	                                FontSize="14"
	                                FontWeight="Bold"
	                                Text="Available Templates" />
	                    <Rectangle Height="1">
	                        <Rectangle.Fill>
	                            <LinearGradientBrush MappingMode="Absolute" SpreadMethod="Repeat" StartPoint="0,0.5" EndPoint="4,0.5">
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
	                                <TextBlock Grid.Row="1" 
	                                            Margin="2"
	                                            HorizontalAlignment="Center"
	                                            Text="Blank Document"
	                                            TextWrapping="Wrap" />
	                            </Grid>
	                        </telerik:RadRibbonButton>
	                        <telerik:RadRibbonButton>
	                            <Grid Width="80">
	                                <Grid.RowDefinitions>
	                                    <RowDefinition Height="Auto" />
	                                    <RowDefinition />
	                                </Grid.RowDefinitions>
	                                <Image Source="Images/DocTemplateBlogPost.png" Stretch="None" />
	                                <TextBlock Grid.Row="1" 
	                                            Margin="2"
	                                            HorizontalAlignment="Center"
	                                            Text="Blog Post"
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
	                                <TextBlock Grid.Row="1" 
	                                            Margin="2"
	                                            HorizontalAlignment="Center"
	                                            Text="Recent Templates"
	                                            TextWrapping="Wrap" />
	                            </Grid>
	                        </telerik:RadRibbonButton>
	                        <telerik:RadRibbonButton>
	                            <Grid Width="80">
	                                <Grid.RowDefinitions>
	                                    <RowDefinition Height="Auto" />
	                                    <RowDefinition />
	                                </Grid.RowDefinitions>
	                                <Image Source="Images/DocTemplateSamples.png" Stretch="None" />
	                                <TextBlock Grid.Row="1" 
	                                            Margin="2"
	                                            HorizontalAlignment="Center"
	                                            Text="Sample Templates"
	                                            TextWrapping="Wrap" />
	                            </Grid>
	                        </telerik:RadRibbonButton>
	                        <telerik:RadRibbonButton>
	                            <Grid Width="80">
	                                <Grid.RowDefinitions>
	                                    <RowDefinition Height="Auto" />
	                                    <RowDefinition />
	                                </Grid.RowDefinitions>
	                                <Image Source="Images/DocTemplateMy.png" Stretch="None" />
	                                <TextBlock Grid.Row="1" 
	                                            Margin="2"
	                                            HorizontalAlignment="Center"
	                                            Text="My Templates"
	                                            TextWrapping="Wrap" />
	                            </Grid>
	                        </telerik:RadRibbonButton>
	                        <telerik:RadRibbonButton>
	                            <Grid Width="80">
	                                <Grid.RowDefinitions>
	                                    <RowDefinition Height="Auto" />
	                                    <RowDefinition />
	                                </Grid.RowDefinitions>
	                                <Image Source="Images/DocTemplateNewBasedOn.png" Stretch="None" />
	                                <TextBlock Grid.Row="1" 
	                                            Margin="2"
	                                            HorizontalAlignment="Center"
	                                            Text="New from Existing"
	                                            TextWrapping="Wrap" />
	                            </Grid>
	                        </telerik:RadRibbonButton>
	                    </ItemsControl>
	                </StackPanel>
	            </telerik:RadRibbonBackstageItem>
	            <telerik:RadRibbonBackstageItem Header="Exit" 
	                                            Icon="Images/Exit.png"
	                                            IsSelectable="False" />
	        </telerik:RadRibbonBackstage>
	    </telerik:RadRibbonView.Backstage>
	    <telerik:RadRibbonTab Header="Home" />
	    <telerik:RadRibbonTab Header="View" />
	    <telerik:RadRibbonTab Header="Text" />
	</telerik:RadRibbonView>
{{endregion}}

![](images/RadRibbonView_Backstage_Sample.png)

The __RadRibbonView__ exposes the __BackstageClippingElement__ property, that allows you to define the area over which the __Backstage__ will be displayed:

#### __XAML__
     <Grid x:Name="LayoutRoot" Background="White">
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto" />
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*" />
            <ColumnDefinition Width="*" />
        </Grid.ColumnDefinitions>
        <Grid x:Name="ribbonContainer">
            <Grid.RowDefinitions>
                <RowDefinition Height="*" />
                <RowDefinition Height="*" />
            </Grid.RowDefinitions>
            <telerik:RadRibbonView x:Name="radRibbonView" 
                                   Title="My Title"
                                   ApplicationName="My Application"
                                   BackstageClippingElement="{Binding ElementName=ribbonContainer}">

                <telerik:RadRibbonView.Backstage>
                    <telerik:RadRibbonBackstage>...</telerik:RadRibbonBackstage>
                </telerik:RadRibbonView.Backstage>
                ...
            </telerik:RadRibbonView>
        </Grid>
    </Grid>

The __RadRibbonView__ is a complex control and the __backstage menu__ is only a small part of it. The __RadRibbonView__ consists of various elements such as:
* [Application Menu]({%slug radribbonview-applicationmenu%})
* [Quick Access ToolBar]({%slug radribbonview-qat%})
* [Ribbon Tab]({%slug radribbonview-ribbon-tab%})
* [Ribbon Group]({%slug radribbonview-ribbon-group%})
* [Ribbon Gallery]({%slug radribbonview-ribbon-gallery%})
* [RibbonButtons Overview]({%slug radribbonview-buttons-overview%})
* [Ribbon ComboBox]({%slug radribbonview-ribbon-combobox%})
* [Screen Tips]({%slug radribbonview-screentips%})

Additional features that you may find interesting are:
* [Selection]({%slug radribbonview-selection%})
* [Resizing]({%slug radribbonview-resizing%})
* [Minimization]({%slug radribbonview-minimization%})
* [Localization]({%slug radribbonview-localization%})