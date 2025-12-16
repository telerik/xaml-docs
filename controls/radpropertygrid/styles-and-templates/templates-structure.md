---
title: Templates Structure
page_title: Templates Structure
description: Check our &quot;Templates Structure&quot; documentation article for the RadPropertyGrid {{ site.framework_name }} control.
slug: radpropertygrid-styles-and-templates-templates-structure
tags: templates,structure
published: True
position: 1
---

# Templates Structure

Like most UI controls, RadPropertyGrid allows you to template it in order to change the control from inside. Except for templating the whole control, you can template parts of it or even independent controls related to it. This topic will make you familiar with: 

* [RadPropertyGrid Template Structure](#radpropertygrid-template)

* [PropertyGridField Template Structure](#propertygridfield-template)

>tip For more information about templating and how to modify the default templates read the common topic on [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}).

Using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) gives you the ability to easily extract and edit the default ControlTemplates of the controls. You can follow [this article]({%slug styling-apperance-editing-control-templates%}) on two different approaches on how to extract the ControlTemplates.

## RadPropertyGrid Template

* __PART_RootElement__ - hosts the elements of the template. It represents the border of the RadPropertyGrid and is of type Border;

* __PART_PropertyGridContainer__- hosts the description panel, the items scroll viewer and the header;

* __PART_DescriptionPanel__- hosts the elements of RadPropertyGrid’s DescriptionPanel. It represents the border of this panel and is of type Border;

* __StackPanel__ - represents the DescriptionPanel and is of type StackPanel;

* __TextBlock__- represents the DisplayName of the Selected property definition;

* __TextBlock__ – represents the Description of the Selected property definition;

* __[Border]__ - represents the outer border of the ScrollViewer and is of type Border;

* __PART_ItemsScrollViewer__ - represents the control that handles the different types of presenters and is of type Border;

* __PropertyGridPresenter__-responsible for displaying PropertyGridFields and is of type PropertyGridPresenter;

* __Header__ - represents the outer border of the header and is of type Border;

* __[Border]__ - represents the inner border of the header and is of type Border;

* __[Grid]__ - hosts the elements of the Header of the header and is of type Grid;

* __[Path]__

* __SearchAsYouTypeTextBox__- represents the RadPropertyGrid’s SearchBox and is of type TextBox.

* __SortButton__- represents the RadPropertyGrid’s Sort Button and is of type RadRadioButton

* __GroupButton__- represents the RadPropertyGrid’s Group Button and is of type RadRadioButton
![{{ site.framework_name }} RadPropertyGrid Template Structure](images/RadPropertyGrid_RadProperyGridTemplate.png)

## PropertyGridField Template

* __PART_RootElement__ - hosts the elements of the template. It represents the border of the DataFormDataField and is of type Border;

* __PART_PropertyGridFieldGrid__ - provides columns for the template elements. It represents the background of the DataFormDataField and is of type Grid;

* __ColumnResizer__ - represents the PropertyGridField’s resizer and is of type Thumb;

* __[Border]__- represents the border around PropertyGridFields’s editor and is of type Border;

* __[ContentPresener]__ - displays the content and is of type ContentPresenter;

* __[Border]__- represents the border around PropertyGridFields’s TextBlock and is of type Border;

* __[TextBlock]__- displays the PropertyGridField’s DisplayName and is of type TextBlock;

* __[Border]__- represents the outer border of PropertyGridFields’s Indent and is of type Border;

* __[Border]__- represents the background of PropertyGrid’s Indent and is of type Border;

* __Background_Over__ - represents the outer border of the field, when the mouse is over it and is of type Border;

* __[Border]__ - represents the inner border and the background of the row, when the mouse is over it and is of type Border;

* __SelectionBackground__- represents the outer border of the field, when it is selected and is of type Border;

* __[Border]__ - represents the inner border and the background of the row, when the mouse is over it and is of type Border.

![{{ site.framework_name }} RadPropertyGrid PropertyGridField Template Structure](images/RadPropertyGrid_PropertyGridFieldTemplate.png)

## Modifying RadPropertyGrid Template with Blend

When extracting the control template with MS Blend some dependency properties of controls that are defined in DataTemplates, does not have their values extracted correctly. You have two options:

* Manually extract the template template from the Themes.Implicit files we ship with every installation. You can find it together with all the other templates used for the PropertyGrid inside "Telerik.Windows.Controls.Data.xaml" file browsing to "C:\Program Files (x86)\Progress\Telerik UI for [product][version]\Themes.Implicit\OfficeBlack\Themes" folder. Please note there is a different folder for each Theme and you should browse to the one you use.
            
*  Extract the template with Blend and manually add the missing __ItemsSource Bindings__ for the ItemsControl defined for the four templates.
You can find instructions on how to fix the missing Bindings bellow:
              
*  Under __FlatRenderingTemplate__:

```XAML
	<ItemsControl IsTabStop="False" VirtualizingStackPanel.VirtualizationMode="Standard">
	    <ItemsControl.Style>
	        <Style TargetType="{x:Type ItemsControl}">
	            <Setter Property="ItemsPanel">
	                <Setter.Value>
	                    <ItemsPanelTemplate>
	                        <VirtualizingStackPanel IsItemsHost="True"/>
	                    </ItemsPanelTemplate>
	                </Setter.Value>
	            </Setter>
	            <Setter Property="ScrollViewer.CanContentScroll" Value="True"/>
	            <Style.BasedOn>
	                <Style TargetType="{x:Type ItemsControl}">
	                    <Setter Property="Template">
	                        <Setter.Value>
	                            <ControlTemplate TargetType="{x:Type ItemsControl}">
	                                <ScrollViewer FocusVisualStyle="{x:Null}" Margin="0,-1,0,0">
	                                    <ItemsPresenter/>
	                                </ScrollViewer>
	                            </ControlTemplate>
	                        </Setter.Value>
	                    </Setter>
	                </Style>
	            </Style.BasedOn>
	        </Style>
	    </ItemsControl.Style>
	</ItemsControl>
```

*   Under __FlatTemplate__:

```XAML
	<ItemsControl IsTabStop="False">
	    <ItemsControl.ItemTemplate>
	        <DataTemplate>
	            <telerik:PropertyGridField Content="{Binding}" Visibility="{Binding Visibility}"/>
	        </DataTemplate>
	    </ItemsControl.ItemTemplate>
	    <ItemsControl.Style>
	        <Style TargetType="{x:Type ItemsControl}">
	            <Setter Property="Template">
	                <Setter.Value>
	                    <ControlTemplate TargetType="{x:Type ItemsControl}">
	                        <ScrollViewer FocusVisualStyle="{x:Null}" Margin="0,-1,0,0">
	                            <ItemsPresenter/>
	                        </ScrollViewer>
	                    </ControlTemplate>
	                </Setter.Value>
	            </Setter>
	        </Style>
	    </ItemsControl.Style>
	</ItemsControl>
```

*  Under __GroupTemplate__:

```XAML
	<ItemsControl>
	    <ItemsControl.ItemTemplate>
	        <DataTemplate>
	            <Border BorderBrush="#FF848484" BorderThickness="0,1,0,0" Margin="0,-1,0,0">
	                <Grid>
	                    <Grid.RowDefinitions>
	                        <RowDefinition Height="Auto"/>
	                        <RowDefinition Height="*"/>
	                    </Grid.RowDefinitions>
	                    <telerik:RadToggleButton x:Name="expandCollapseButton" BorderBrush="{x:Null}" Content="{Binding Key}" IsChecked="True" InnerCornerRadius="0">
	                        <telerik:RadToggleButton.Style>
	                            <Style TargetType="{x:Type telerik:RadToggleButton}">
	                                <Setter Property="VerticalContentAlignment" Value="Center"/>
	                                <Setter Property="HorizontalContentAlignment" Value="Left"/>
	                                <Setter Property="MinHeight" Value="25"/>
	                                <Setter Property="FontWeight" Value="Bold"/>
	                                <Setter Property="SnapsToDevicePixels" Value="True"/>
	                                <Setter Property="BorderBrush" Value="#FF848484"/>
	                                <Setter Property="Template">
	                                    <Setter.Value>
	                                        <ControlTemplate TargetType="{x:Type telerik:RadToggleButton}">
	                                            <Grid UseLayoutRounding="True">
	                                                <Grid.ColumnDefinitions>
	                                                    <ColumnDefinition Width="Auto"/>
	                                                    <ColumnDefinition Width="*"/>
	                                                </Grid.ColumnDefinitions>
	                                                <VisualStateManager.VisualStateGroups>
	                                                    <VisualStateGroup x:Name="CommonStates">
	                                                        <VisualState x:Name="Normal"/>
	                                                        <VisualState x:Name="MouseOver"/>
	                                                        <VisualState x:Name="Disabled"/>
	                                                    </VisualStateGroup>
	                                                    <VisualStateGroup x:Name="CheckStates">
	                                                        <VisualState x:Name="Checked">
	                                                            <Storyboard>
	                                                                <DoubleAnimationUsingKeyFrames BeginTime="0" Storyboard.TargetProperty="(UIElement.RenderTransform).(RotateTransform.Angle)" Storyboard.TargetName="ExpanderButton">
	                                                                    <EasingDoubleKeyFrame KeyTime="0:0:0.2" Value="180"/>
	                                                                </DoubleAnimationUsingKeyFrames>
	                                                                <ObjectAnimationUsingKeyFrames Storyboard.TargetProperty="BorderThickness" Storyboard.TargetName="IconOuterBorder">
	                                                                    <DiscreteObjectKeyFrame KeyTime="0">
	                                                                        <DiscreteObjectKeyFrame.Value>
	                                                                            <Thickness>0</Thickness>
	                                                                        </DiscreteObjectKeyFrame.Value>
	                                                                    </DiscreteObjectKeyFrame>
	                                                                </ObjectAnimationUsingKeyFrames>
	                                                                <ObjectAnimationUsingKeyFrames Storyboard.TargetProperty="BorderThickness" Storyboard.TargetName="IconInnerBorder">
	                                                                    <DiscreteObjectKeyFrame KeyTime="0">
	                                                                        <DiscreteObjectKeyFrame.Value>
	                                                                            <Thickness>1,1,0,0</Thickness>
	                                                                        </DiscreteObjectKeyFrame.Value>
	                                                                    </DiscreteObjectKeyFrame>
	                                                                </ObjectAnimationUsingKeyFrames>
	                                                            </Storyboard>
	                                                        </VisualState>
	                                                        <VisualState x:Name="Unchecked"/>
	                                                    </VisualStateGroup>
	                                                    <VisualStateGroup x:Name="FocusStates">
	                                                        <VisualState x:Name="Focused"/>
	                                                        <VisualState x:Name="Unfocused"/>
	                                                    </VisualStateGroup>
	                                                </VisualStateManager.VisualStateGroups>
	                                                <Border x:Name="IconOuterBorder" BorderBrush="#FF848484" BorderThickness="0,0,0,1" HorizontalAlignment="Stretch" VerticalAlignment="Stretch" Width="25">
	                                                    <Border x:Name="IconInnerBorder" BorderBrush="White" BorderThickness="1,1,0,1" Background="#FFE4E4E4">
	                                                        <Path x:Name="ExpanderButton" Data="M0,0L1,0 2,0 2,0.99999991 3,0.99999991 3,2 4,2 4,0.99999991 5,0.99999991 5,0 5.9999999,0 7,0 7,0.99999991 5.9999999,0.99999991 5.9999999,2 5,2 5,3 4,3 4,4 3,4 3,3 2,3 2,2 1,2 1,0.99999991 0,0.99999991z" Fill="Black" HorizontalAlignment="Center" Height="5" RenderTransformOrigin="0.5,0.5" VerticalAlignment="Center" Width="7">
	                                                            <Path.RenderTransform>
	                                                                <RotateTransform/>
	                                                            </Path.RenderTransform>
	                                                        </Path>
	                                                    </Border>
	                                                </Border>
	                                                <Border BorderBrush="#FF848484" BorderThickness="0,0,0,1" Grid.ColumnSpan="2" Grid.Column="1" Margin="-2,0,0,0">
	                                                    <Border BorderBrush="White" BorderThickness="0,1,1,1" Background="#FFE4E4E4">
	                                                        <ContentPresenter x:Name="PART_ContentPresenter" ContentTemplate="{TemplateBinding ContentTemplate}" Content="{TemplateBinding Content}" HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}" Margin="{TemplateBinding Padding}" VerticalAlignment="{TemplateBinding VerticalContentAlignment}"/>
	                                                    </Border>
	                                                </Border>
	                                                <Border x:Name="ExpandBorder" BorderBrush="#FF848484" BorderThickness="0,0,0,1" Grid.ColumnSpan="2" Margin="0,-1,0,0" VerticalAlignment="Top"/>
	                                            </Grid>
	                                        </ControlTemplate>
	                                    </Setter.Value>
	                                </Setter>
	                            </Style>
	                        </telerik:RadToggleButton.Style>
	                    </telerik:RadToggleButton>
	                    <ContentPresenter x:Name="PART_ContentPresenter" Content="{Binding Items}" Grid.Row="1">
	                        <ContentPresenter.ContentTemplate>
	                            <DataTemplate>
	                                <ItemsControl IsTabStop="False">
	                                    <ItemsControl.ItemTemplate>
	                                        <DataTemplate>
	                                            <telerik:PropertyGridField Content="{Binding}" Visibility="{Binding Visibility}"/>
	                                        </DataTemplate>
	                                    </ItemsControl.ItemTemplate>
	                                </ItemsControl>
	                            </DataTemplate>
	                        </ContentPresenter.ContentTemplate>
	                        <ContentPresenter.Visibility>
	                            <Binding ElementName="expandCollapseButton" Path="IsChecked">
	                                <Binding.Converter>
	                                    <telerik:BooleanToVisibilityConverter/>
	                                </Binding.Converter>
	                            </Binding>
	                        </ContentPresenter.Visibility>
	                    </ContentPresenter>
	                </Grid>
	            </Border>
	        </DataTemplate>
	    </ItemsControl.ItemTemplate>
	    <ItemsControl.Style>
	        <Style TargetType="{x:Type ItemsControl}">
	            <Setter Property="Template">
	                <Setter.Value>
	                    <ControlTemplate TargetType="{x:Type ItemsControl}">
	                        <ScrollViewer FocusVisualStyle="{x:Null}" Margin="0,-1,0,0">
	                            <ItemsPresenter/>
	                        </ScrollViewer>
	                    </ControlTemplate>
	                </Setter.Value>
	            </Setter>
	        </Style>
	    </ItemsControl.Style>
	</ItemsControl>
```

*  Under __VirtualizedFlatTemplate__:

```XAML
	<ItemsControl IsTabStop="False">
	    <ItemsControl.ItemTemplate>
	        <DataTemplate>
	            <telerik:PropertyGridField Content="{Binding}" Visibility="{Binding Visibility}"/>
	        </DataTemplate>
	    </ItemsControl.ItemTemplate>
	    <ItemsControl.Style>
	        <Style TargetType="{x:Type ItemsControl}">
	            <Setter Property="ItemsPanel">
	                <Setter.Value>
	                    <ItemsPanelTemplate>
	                        <VirtualizingStackPanel IsItemsHost="True"/>
	                    </ItemsPanelTemplate>
	                </Setter.Value>
	            </Setter>
	            <Setter Property="ScrollViewer.CanContentScroll" Value="True"/>
	            <Style.BasedOn>
	                <Style TargetType="{x:Type ItemsControl}">
	                    <Setter Property="Template">
	                        <Setter.Value>
	                            <ControlTemplate TargetType="{x:Type ItemsControl}">
	                                <ScrollViewer FocusVisualStyle="{x:Null}" Margin="0,-1,0,0">
	                                    <ItemsPresenter/>
	                                </ScrollViewer>
	                            </ControlTemplate>
	                        </Setter.Value>
	                    </Setter>
	                </Style>
	            </Style.BasedOn>
	        </Style>
	    </ItemsControl.Style>
	</ItemsControl>
```

Using [Implicit Styles]({%slug styling-apperance-implicit-styles-overview%}) gives you the ability to easily extract and edit the default ControlTemplates of the controls. You can follow [this article]({%slug styling-apperance-editing-control-templates%}) on two different approaches on how to extract the ControlTemplates.
