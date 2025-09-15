---
title: Required Parts
page_title: Required Parts
description: Check our &quot;Required Parts&quot; documentation article for the RadPanelBar {{ site.framework_name }} control.
slug: radpanelbar-required-template-parts
tags: required,parts
published: True
position: 1
---

# Required Parts

The __RadPanelBar__ control needs a set of two control templates - one for the overall look of the control and another one for the individual items.

Below you can see the default template:

{% if site.site_name == 'Silverlight' %}
#### __XAML__
```XAML
	<ControlTemplate x:Key="PanelBarControlTemplate" TargetType="telerik:RadPanelBar">
	    <Grid>
	        <VisualStateManager.VisualStateGroups>
	            <VisualStateGroup x:Name="OrientationStates">
	                <VisualState x:Name="Vertical">
	                    <Storyboard>
	                        <ObjectAnimationUsingKeyFrames Duration="00:00:00" 
	                                               Storyboard.TargetName="transformationRoot" 
	                                               Storyboard.TargetProperty="(LayoutTransformControl.LayoutTransform)">
	                            <DiscreteObjectKeyFrame KeyTime="00:00:00">
	                                <DiscreteObjectKeyFrame.Value>
	                                    <RotateTransform Angle="0" />
	                                </DiscreteObjectKeyFrame.Value>
	                            </DiscreteObjectKeyFrame>
	                        </ObjectAnimationUsingKeyFrames>
	                    </Storyboard>
	                </VisualState>
	                <VisualState x:Name="Horizontal">
	                    <Storyboard>
	                        <ObjectAnimationUsingKeyFrames Duration="00:00:00" 
	                                               Storyboard.TargetName="transformationRoot"
	                                               Storyboard.TargetProperty="(LayoutTransformControl.LayoutTransform)">
	                            <DiscreteObjectKeyFrame KeyTime="00:00:00">
	                                <DiscreteObjectKeyFrame.Value>
	                                    <RotateTransform Angle="-90" />
	                                </DiscreteObjectKeyFrame.Value>
	                            </DiscreteObjectKeyFrame>
	                        </ObjectAnimationUsingKeyFrames>
	                    </Storyboard>
	                </VisualState>
	            </VisualStateGroup>
	        </VisualStateManager.VisualStateGroups>
	        <telerik:LayoutTransformControl x:Name="transformationRoot">
	            <Border Background="{TemplateBinding Background}" 
	            BorderBrush="{TemplateBinding BorderBrush}"
	            BorderThickness="{TemplateBinding BorderThickness}">
	                <ScrollViewer x:Name="ScrollViewer" 
	                      HorizontalContentAlignment="{TemplateBinding HorizontalContentAlignment}"
	                      HorizontalScrollBarVisibility="Auto"
	                      IsTabStop="False"
	                      Padding="{TemplateBinding Padding}" 
	                      Telerik:ScrollViewerExtensions.EnableMouseWheel="True"
	                      telerik:StyleManager.Theme="{StaticResource Theme}"
	                      VerticalContentAlignment="{TemplateBinding VerticalContentAlignment}"
	                      VerticalScrollBarVisibility="Auto">
	                    <ItemsPresenter />
	                </ScrollViewer>
	            </Border>
	        </telerik:LayoutTransformControl>
	    </Grid>
	</ControlTemplate>
```
{% endif %}

{% if site.site_name == 'WPF' %}
#### __XAML__
```XAML
	<ControlTemplate x:Key="PanelBarControlTemplate" TargetType="{x:Type telerik:RadPanelBar}">
	    <Grid>
	        <telerik:LayoutTransformControl x:Name="transformationRoot" IsTabStop="False">
	            <Border Background="{TemplateBinding Background}" 
	                    BorderBrush="{TemplateBinding BorderBrush}"
	                    BorderThickness="{TemplateBinding BorderThickness}">
	                <ScrollViewer x:Name="ScrollViewer" 
	                              HorizontalContentAlignment="{TemplateBinding HorizontalContentAlignment}"
	                              HorizontalScrollBarVisibility="Auto"
	                              IsTabStop="False"
	                              Padding="{TemplateBinding Padding}"
	                              VerticalContentAlignment="{TemplateBinding VerticalContentAlignment}"
	                              VerticalScrollBarVisibility="Auto">
	                    <telerik:StyleManager.Theme>
	                        <telerik:Office_BlackTheme />
	                    </telerik:StyleManager.Theme>
	                    <ItemsPresenter />
	                </ScrollViewer>
	            </Border>
	        </telerik:LayoutTransformControl>
	    </Grid>
	    <ControlTemplate.Triggers>
	        <Trigger Property="Orientation" Value="Horizontal">
	            <Setter TargetName="transformationRoot" Property="LayoutTransform">
	                <Setter.Value>
	                    <RotateTransform Angle="-90" />
	                </Setter.Value>
	            </Setter>
	        </Trigger>
	    </ControlTemplate.Triggers>
	</ControlTemplate>
```
{% endif %}

We will now briefly describe the purpose of the main elements:

* __TransformationRoot__ - this element is needed for changing the orientation of the control.					

* __ScrollViewer__ - this element take care of the cases when there is not enough available space to render the panelbar items.					

The other control template required by the __RadPanelBar__ control is the one for the panelbar items. Below you can see the default template:

{% if site.site_name == 'Silverlight' %}
#### __XAML__
```XAML
	<ControlTemplate x:Key="PanelBarItemTopLevelTemplate" TargetType="telerik:RadPanelBarItem">
	    <Grid x:Name="RootElement">
	        <Grid.RowDefinitions>
	            <RowDefinition Height="Auto" />
	            <RowDefinition Height="\*" />
	        </Grid.RowDefinitions>
	        <VisualStateManager.VisualStateGroups>
	            <VisualStateGroup x:Name="CommonStates">
	                <VisualState x:Name="Normal" />
	                <VisualState x:Name="Disabled">
	                    <Storyboard>
	                        <DoubleAnimation Duration="0" 
	                                 Storyboard.TargetName="NormalVisual"
	                                 Storyboard.TargetProperty="Opacity"
	                                 To="0" />
	                        <DoubleAnimation Duration="0" 
	                                 Storyboard.TargetName="DisabledVisual"
	                                 Storyboard.TargetProperty="Opacity"
	                                 To="1" />
	                        <DoubleAnimation Duration="0" 
	                                 Storyboard.TargetName="arrow"
	                                 Storyboard.TargetProperty="Opacity"
	                                 To="0.5" />
	                        <DoubleAnimation Duration="0" 
	                                 Storyboard.TargetName="Header"
	                                 Storyboard.TargetProperty="Opacity"
	                                 To="0.5" />
	                    </Storyboard>
	                </VisualState>
	                <VisualState x:Name="MouseOver">
	                    <Storyboard>
	                        <DoubleAnimation Duration="0" 
	                                 Storyboard.TargetName="MouseOverVisual"
	                                 Storyboard.TargetProperty="Opacity"
	                                 To="1" />
	                    </Storyboard>
	                </VisualState>
	                <VisualState x:Name="MouseOut" />
	            </VisualStateGroup>
	            <VisualStateGroup x:Name="SelectionStates">
	                <VisualState x:Name="Unselected" />
	                <VisualState x:Name="Selected">
	                    <Storyboard>
	                        <DoubleAnimation Duration="0" 
	                                 Storyboard.TargetName="SelectVisual"
	                                 Storyboard.TargetProperty="Opacity"
	                                 To="1" />
	                    </Storyboard>
	                </VisualState>
	            </VisualStateGroup>
	            <VisualStateGroup x:Name="ExpandStates">
	                <VisualState x:Name="Expanded">
	                    <Storyboard>
	                        <DoubleAnimation Duration="0" 
	                                 Storyboard.TargetName="directionRotation"
	                                 Storyboard.TargetProperty="Angle"
	                                 To="180" />
	                        <ObjectAnimationUsingKeyFrames Duration="0" 
	                                               Storyboard.TargetName="ItemsContainer"
	                                               Storyboard.TargetProperty="Visibility">
	                            <DiscreteObjectKeyFrame KeyTime="0" Value="Visible" />
	                        </ObjectAnimationUsingKeyFrames>
	                        <DoubleAnimation Duration="0:0:0.2" 
	                                 From="0.0"
	                                 Storyboard.TargetName="ItemsContainer"
	                                 Storyboard.TargetProperty="Opacity"
	                                 To="1.0" />
	                    </Storyboard>
	                </VisualState>
	                <VisualState x:Name="Collapsed" />
	            </VisualStateGroup>
	            <VisualStateGroup x:Name="FocusStates">
	                <VisualState x:Name="Focused">
	                    <Storyboard>
	                        <ObjectAnimationUsingKeyFrames Duration="0" 
	                                               Storyboard.TargetName="FocusVisual"
	                                               Storyboard.TargetProperty="Visibility">
	                            <DiscreteObjectKeyFrame KeyTime="0" Value="Visible" />
	                        </ObjectAnimationUsingKeyFrames>
	                    </Storyboard>
	                </VisualState>
	                <VisualState x:Name="Unfocused">
	                    <Storyboard>
	                        <ObjectAnimationUsingKeyFrames Duration="0" 
	                                               Storyboard.TargetName="FocusVisual"
	                                               Storyboard.TargetProperty="Visibility">
	                            <DiscreteObjectKeyFrame KeyTime="0" Value="Collapsed" />
	                        </ObjectAnimationUsingKeyFrames>
	                    </Storyboard>
	                </VisualState>
	            </VisualStateGroup>
	        </VisualStateManager.VisualStateGroups>
	        <Grid x:Name="HeaderRow">
	            <Grid.ColumnDefinitions>
	                <ColumnDefinition Width="Auto" />
	                <ColumnDefinition Width="Auto" />
	                <ColumnDefinition Width="Auto" />
	                <ColumnDefinition Width="\*" />
	                <ColumnDefinition Width="Auto" />
	            </Grid.ColumnDefinitions>
	            <Border x:Name="NormalVisual" 
	            Grid.ColumnSpan="5"
	            BorderBrush="{TemplateBinding BorderBrush}"
	            BorderThickness="{TemplateBinding BorderThickness}">
	                <Border Background="{TemplateBinding Background}" 
	                BorderBrush="{StaticResource ControlItem_InnerBorder_Normal}"
	                BorderThickness="1" />
	            </Border>
	            <Border x:Name="MouseOverVisual" 
	            Grid.ColumnSpan="5"
	            BorderBrush="{StaticResource ControlItem_OuterBorder_MouseOver}"
	            BorderThickness="1"
	            Opacity="0">
	                <Border Background="{StaticResource ControlItem_Background_MouseOver}" 
	                BorderBrush="{StaticResource ControlItem_InnerBorder_MouseOver}"
	                BorderThickness="1" />
	            </Border>
	            <Border x:Name="SelectVisual" 
	            Grid.ColumnSpan="5"
	            BorderBrush="{StaticResource ControlItem_OuterBorder_Selected}"
	            BorderThickness="1"
	            Opacity="0">
	                <Border Background="{StaticResource ControlItem_Background_Selected}" 
	                BorderBrush="{StaticResource ControlItem_InnerBorder_Selected}"
	                BorderThickness="1" />
	            </Border>
	            <Border x:Name="DisabledVisual" 
	            Grid.ColumnSpan="5"
	            BorderBrush="{StaticResource ControlOuterBorder_Disabled}"
	            BorderThickness="1"
	            Opacity="0">
	                <Border Background="{StaticResource ControlBackground_Disabled}" 
	                BorderBrush="{StaticResource ControlInnerBorder_Disabled}"
	                BorderThickness="1" />
	            </Border>
	            <Path x:Name="arrow" 
	          Grid.Column="5"
	          Margin="7 0"
	          HorizontalAlignment="Right"
	          VerticalAlignment="Center"
	          Data="M 1,1.5 L 4.5,5 L 8,1.5"
	          Opacity="1"
	          RenderTransformOrigin="0.5 0.5"
	          Stretch="None"
	          Stroke="{StaticResource ControlElement_Normal}"
	          StrokeThickness="2">
	                <Path.RenderTransform>
	                    <RotateTransform x:Name="directionRotation" Angle="0" />
	                </Path.RenderTransform>
	            </Path>
	            <ContentPresenter x:Name="Header" 
	                      Grid.ColumnSpan="4"
	                      Margin="{TemplateBinding Padding}"
	                      HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
	                      VerticalAlignment="{TemplateBinding VerticalContentAlignment}"
	                      ContentTemplate="{TemplateBinding HeaderTemplate}" />
	            <Rectangle x:Name="FocusVisual" 
	               Grid.Column="0"
	               Grid.ColumnSpan="5"
	               IsHitTestVisible="False"
	               Stroke="{StaticResource FocusBrushBlack}"
	               StrokeDashArray="1 2"
	               StrokeThickness="1"
	               Visibility="Collapsed" />
	        </Grid>
	        <Grid x:Name="ItemsContainer" 
	      Grid.Row="1"
	      Visibility="Collapsed">
	            <telerik:LayoutTransformControl x:Name="transformationRoot">
	                <ItemsPresenter />
	            </telerik:LayoutTransformControl>
	        </Grid>
	    </Grid>
	</ControlTemplate>
```
{% endif %}

{% if site.site_name == 'WPF' %}
#### __XAML__
```XAML
	<ControlTemplate x:Key="PanelBarItemTopLevelTemplate" TargetType="{x:Type telerik:RadPanelBarItem}">
	    <Grid x:Name="RootElement" SnapsToDevicePixels="True">
	        <Grid.RowDefinitions>
	            <RowDefinition Height="Auto" />
	            <RowDefinition Height="\*" />
	        </Grid.RowDefinitions>
	        <Grid x:Name="HeaderRow">
	            <Grid.ColumnDefinitions>
	                <ColumnDefinition Width="Auto" />
	                <ColumnDefinition Width="Auto" />
	                <ColumnDefinition Width="Auto" />
	                <ColumnDefinition Width="\*" />
	                <ColumnDefinition Width="Auto" />
	            </Grid.ColumnDefinitions>
	            <Border x:Name="NormalVisual" 
	                    Grid.ColumnSpan="5"
	                    BorderBrush="{TemplateBinding BorderBrush}"
	                    BorderThickness="{TemplateBinding BorderThickness}">
	                <Border Background="{TemplateBinding Background}" 
	                        BorderBrush="White"
	                        BorderThickness="1" />
	            </Border>
	            <Border x:Name="MouseOverVisual" 
	                    Grid.ColumnSpan="5"
	                    BorderBrush="#FFFFC92B"
	                    BorderThickness="1"
	                    Opacity="0">
	                <Border BorderBrush="White" BorderThickness="1">
	                    <Border.Background>
	                        <LinearGradientBrush StartPoint="0.5,0" EndPoint="0.5,1">
	                            <GradientStop Offset="1" Color="#FFFFFBA3" />
	                            <GradientStop Offset="0" Color="#FFFFFBDA" />
	                            <GradientStop Offset="0.43" Color="#FFFFD25A" />
	                            <GradientStop Offset="0.42" Color="#FFFEEBAE" />
	                        </LinearGradientBrush>
	                    </Border.Background>
	                </Border>
	            </Border>
	            <Border x:Name="SelectVisual" 
	                    Grid.ColumnSpan="5"
	                    BorderThickness="1"
	                    Opacity="0">
	                <Border.BorderBrush>
	                    <LinearGradientBrush StartPoint="0.5,0" EndPoint="0.5,1">
	                        <GradientStop Color="#FF282828" />
	                        <GradientStop Offset="1" Color="#FF5F5F5F" />
	                    </LinearGradientBrush>
	                </Border.BorderBrush>
	                <Border BorderThickness="1">
	                    <Border.BorderBrush>
	                        <LinearGradientBrush StartPoint="0.5,0" EndPoint="0.5,1">
	                            <GradientStop Color="#FFB69A78" />
	                            <GradientStop Offset="0.126" Color="#FFFFE17A" />
	                        </LinearGradientBrush>
	                    </Border.BorderBrush>
	                    <Border.Background>
	                        <LinearGradientBrush StartPoint="0.5,0" EndPoint="0.5,1">
	                            <GradientStop Offset="0.996" Color="#FFFFD74E" />
	                            <GradientStop Offset="0.17" Color="#FFFFDCAB" />
	                            <GradientStop Offset="0.57" Color="#FFFFB062" />
	                            <GradientStop Offset="0.56" Color="#FFFFD18F" />
	                            <GradientStop Color="#FFFFBA74" />
	                        </LinearGradientBrush>
	                    </Border.Background>
	                </Border>
	            </Border>
	            <Border x:Name="DisabledVisual" 
	                    Grid.ColumnSpan="5"
	                    BorderBrush="#FF989898"
	                    BorderThickness="1"
	                    Opacity="0">
	                <Border Background="#FFE0E0E0" 
	                        BorderBrush="Transparent"
	                        BorderThickness="1" />
	            </Border>
	            <Path x:Name="arrow" 
	                  Grid.Column="5"
	                  Margin="7,0"
	                  HorizontalAlignment="Right"
	                  VerticalAlignment="Center"
	                  Data="M1,1.5L4.5,5 8,1.5"
	                  Opacity="1"
	                  RenderTransformOrigin="0.5,0.5"
	                  Stretch="None"
	                  Stroke="Black"
	                  StrokeThickness="2">
	                <Path.RenderTransform>
	                    <RotateTransform Angle="0" />
	                </Path.RenderTransform>
	            </Path>
	            <ContentControl x:Name="Header" 
	                            Grid.ColumnSpan="4"
	                            Margin="{TemplateBinding Padding}"
	                            HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
	                            VerticalAlignment="{TemplateBinding VerticalContentAlignment}"
	                            ContentTemplate="{TemplateBinding HeaderTemplate}"
	                            FontSize="{TemplateBinding FontSize}"
	                            Foreground="{TemplateBinding Foreground}" />
	            <Rectangle x:Name="FocusVisual" 
	                       Grid.Column="0"
	                       Grid.ColumnSpan="5"
	                       IsHitTestVisible="False"
	                       Stroke="Black"
	                       StrokeDashArray="1 2"
	                       StrokeThickness="1"
	                       Visibility="Collapsed" />
	        </Grid>
	        <Grid x:Name="ItemsContainer" 
	              Grid.Row="1"
	              Visibility="Collapsed">
	            <telerik:LayoutTransformControl x:Name="transformationRoot" IsTabStop="False">
	                <ItemsPresenter />
	            </telerik:LayoutTransformControl>
	        </Grid>
	    </Grid>
	    <ControlTemplate.Triggers>
	        <Trigger Property="IsSelected" Value="True">
	            <Setter TargetName="SelectVisual" Property="Opacity" Value="1" />
	        </Trigger>
	        <Trigger Property="IsFocused" Value="True">
	            <Setter TargetName="FocusVisual" Property="Visibility" Value="Visible" />
	        </Trigger>
	        <Trigger Property="IsExpanded" Value="True">
	            <Setter TargetName="arrow" Property="LayoutTransform">
	                <Setter.Value>
	                    <TransformGroup>
	                        <RotateTransform Angle="180" />
	                    </TransformGroup>
	                </Setter.Value>
	            </Setter>
	            <Setter TargetName="ItemsContainer" Property="Visibility" Value="Visible" />
	        </Trigger>
	        <Trigger Property="IsEnabled" Value="False">
	            <Setter TargetName="DisabledVisual" Property="Opacity" Value="1" />
	            <Setter TargetName="NormalVisual" Property="Opacity" Value="0" />
	        </Trigger>
	        <Trigger Property="IsMouseOver" Value="True">
	            <Setter TargetName="MouseOverVisual" Property="Opacity" Value="1" />
	        </Trigger>
	    </ControlTemplate.Triggers>
	</ControlTemplate>
```
{% endif %}

Following is a short description of the major elements in the template:

* __RootElement__ - as the name suggests, this is the root element wrapping all other parts of the template.					  

* __HeaderRow__ - this Grid element contains all elements that comprise the header of a panelbar item i.e. what is visible when the item is collapsed.					  

* __MouseOverVisual__ - this element is displayed when the mouse cursor moves over an item.					  

* __SelectVisual__ - this element is displayed whenever an item gets selected.					  

* __Arrow__ and __ArrowSelect__  - the expander arrow displayed in the right-hand corner of the item header.					  

* __ExpandedVisual__ - this element is displayed when an item is expanded.					  

* __Header__ - this element is responsible for rendering the value of the Header property.					  

* __DisabledVisual__ - this element is displayed when an item's IsEnabled property is set to false.					  

* __FocusVisual__ - this element is displayed when an item is focused.					  

* __ItemsContainer__ - this Grid element contains an item's child items.					  

* __TransformationRoot__ - this element is used when the Orientation property of the parent panelbar is changed.					  

And the default ControlTemplate of the RadPanelBarItem.Items is:

{% if site.site_name == 'Silverlight' %}
#### __XAML__
```XAML
	<ControlTemplate x:Key="PanelBarItemSecondLevelTemplate" TargetType="telerik:RadPanelBarItem">
	    <Grid x:Name="RootElement">
	        <Grid.RowDefinitions>
	            <RowDefinition Height="Auto" />
	            <RowDefinition Height="*" />
	        </Grid.RowDefinitions>
	        <VisualStateManager.VisualStateGroups>
	            <VisualStateGroup x:Name="CommonStates">
	                <VisualState x:Name="Normal" />
	                <VisualState x:Name="Disabled">
	                    <Storyboard>
	                        <DoubleAnimation Duration="0" 
	                                 Storyboard.TargetName="DisabledVisual"
	                                 Storyboard.TargetProperty="Opacity"
	                                 To="1.0" />
	                    </Storyboard>
	                </VisualState>
	                <VisualState x:Name="MouseOver">
	                    <Storyboard>
	                        <DoubleAnimation Duration="0:0:0.2" 
	                                 Storyboard.TargetName="MouseOverVisual"
	                                 Storyboard.TargetProperty="Opacity"
	                                 To="1.0" />
	                    </Storyboard>
	                </VisualState>
	                <VisualState x:Name="MouseOut">
	                    <Storyboard>
	                        <DoubleAnimation Duration="0:0:0.2" 
	                                 Storyboard.TargetName="MouseOverVisual"
	                                 Storyboard.TargetProperty="Opacity"
	                                 To="0.0" />
	                    </Storyboard>
	                </VisualState>
	            </VisualStateGroup>
	            <VisualStateGroup x:Name="SelectionStates">
	                <VisualState x:Name="Unselected" />
	                <VisualState x:Name="Selected">
	                    <Storyboard>
	                        <DoubleAnimation Duration="0" 
	                                 Storyboard.TargetName="SelectionVisual"
	                                 Storyboard.TargetProperty="Opacity"
	                                 To="1" />
	                    </Storyboard>
	                </VisualState>
	            </VisualStateGroup>
	            <VisualStateGroup x:Name="ExpandStates">
	                <VisualState x:Name="Expanded">
	                    <Storyboard>
	                        <ObjectAnimationUsingKeyFrames Duration="0" 
	                                               Storyboard.TargetName="ItemsContainer"
	                                               Storyboard.TargetProperty="Visibility">
	                            <DiscreteObjectKeyFrame KeyTime="0" Value="Visible" />
	                        </ObjectAnimationUsingKeyFrames>
	                        <DoubleAnimation Duration="0:0:0.2" 
	                                 From="0.0"
	                                 Storyboard.TargetName="ItemsContainer"
	                                 Storyboard.TargetProperty="Opacity"
	                                 To="1.0" />
	                    </Storyboard>
	                </VisualState>
	                <VisualState x:Name="Collapsed" />
	            </VisualStateGroup>
	            <VisualStateGroup x:Name="FocusStates">
	                <VisualState x:Name="Focused">
	                    <Storyboard>
	                        <ObjectAnimationUsingKeyFrames Duration="0" 
	                                               Storyboard.TargetName="FocusVisual"
	                                               Storyboard.TargetProperty="Visibility">
	                            <DiscreteObjectKeyFrame KeyTime="0" Value="Visible" />
	                        </ObjectAnimationUsingKeyFrames>
	                    </Storyboard>
	                </VisualState>
	                <VisualState x:Name="Unfocused">
	                    <Storyboard>
	                        <ObjectAnimationUsingKeyFrames Duration="0" 
	                                               Storyboard.TargetName="FocusVisual"
	                                               Storyboard.TargetProperty="Visibility">
	                            <DiscreteObjectKeyFrame KeyTime="0" Value="Collapsed" />
	                        </ObjectAnimationUsingKeyFrames>
	                    </Storyboard>
	                </VisualState>
	            </VisualStateGroup>
	        </VisualStateManager.VisualStateGroups>
	        <Grid x:Name="HeaderRow" Background="Transparent">
	            <Border x:Name="MouseOverVisual" 
	            BorderBrush="{StaticResource ControlSubItem_OuterBorder_MouseOver}"
	            BorderThickness="{StaticResource ControlSubItem_OuterBorderThickness}"
	            CornerRadius="{StaticResource ControlSubItem_OuterCornerRadius}"
	            Opacity="0">
	                <Border Background="{StaticResource ControlSubItem_Background_MouseOver}" 
	                BorderBrush="{StaticResource ControlSubItem_InnerBorder_MouseOver}"
	                BorderThickness="{StaticResource ControlSubItem_InnerBorderThickness}"
	                CornerRadius="{StaticResource ControlSubItem_InnerCornerRadius}" />
	            </Border>
	            <Border x:Name="SelectionVisual" 
	            BorderBrush="{StaticResource ControlSubItem_OuterBorder_Selected}"
	            BorderThickness="{StaticResource ControlSubItem_OuterBorderThickness}"
	            CornerRadius="{StaticResource ControlSubItem_OuterCornerRadius}"
	            Opacity="0">
	                <Border Background="{StaticResource ControlSubItem_Background_Selected}" 
	                BorderBrush="{StaticResource ControlSubItem_InnerBorder_Selected}"
	                BorderThickness="{StaticResource ControlSubItem_InnerBorderThickness}"
	                CornerRadius="{StaticResource ControlSubItem_InnerCornerRadius}" />
	            </Border>
	            <Border x:Name="DisabledVisual" 
	            BorderBrush="{StaticResource ControlOuterBorder_Disabled}"
	            BorderThickness="{StaticResource ControlSubItem_OuterBorderThickness}"
	            CornerRadius="{StaticResource ControlSubItem_OuterCornerRadius}"
	            Opacity="0">
	                <Border Background="{StaticResource ControlBackground_Disabled}" 
	                BorderBrush="{StaticResource ControlInnerBorder_Disabled}"
	                BorderThickness="{StaticResource ControlSubItem_InnerBorderThickness}"
	                CornerRadius="{StaticResource ControlSubItem_InnerCornerRadius}" />
	            </Border>
	            <ContentPresenter x:Name="Header" 
	                      Margin="{TemplateBinding Padding}"
	                      HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
	                      VerticalAlignment="{TemplateBinding VerticalContentAlignment}"
	                      ContentTemplate="{TemplateBinding HeaderTemplate}" />
	            <Rectangle x:Name="FocusVisual" 
	               IsHitTestVisible="False"
	               RadiusX="2"
	               RadiusY="2"
	               Stroke="{StaticResource FocusBrushBlack}"
	               StrokeDashArray="1 2"
	               StrokeThickness="1"
	               Visibility="Collapsed" />
	        </Grid>
	        <Grid x:Name="ItemsContainer" 
	      Grid.Row="1"
	      Visibility="Collapsed">
	            <ItemsPresenter />
	        </Grid>
	    </Grid>
	</ControlTemplate>
```
{% endif %}

{% if site.site_name == 'WPF' %}
#### __XAML__
```XAML
	<ControlTemplate x:Key="PanelBarItemSecondLevelTemplate" TargetType="{x:Type telerik:RadPanelBarItem}">
	    <Grid x:Name="RootElement">
	        <Grid.RowDefinitions>
	            <RowDefinition Height="Auto" />
	            <RowDefinition Height="*" />
	        </Grid.RowDefinitions>
	        <Grid x:Name="HeaderRow" Background="Transparent">
	            <Border x:Name="MouseOverVisual" 
	                    BorderBrush="#FFFFC92B"
	                    BorderThickness="1"
	                    CornerRadius="1"
	                    Opacity="0">
	                <Border BorderBrush="White" 
	                        BorderThickness="1"
	                        CornerRadius="0">
	                    <Border.Background>
	                        <LinearGradientBrush StartPoint="0.5,0" EndPoint="0.5,1">
	                            <GradientStop Offset="1" Color="#FFFFFBA3" />
	                            <GradientStop Offset="0" Color="#FFFFFBDA" />
	                        </LinearGradientBrush>
	                    </Border.Background>
	                </Border>
	            </Border>
	            <Border x:Name="SelectionVisual" 
	                    BorderBrush="#FFFFC92B"
	                    BorderThickness="1"
	                    CornerRadius="1"
	                    Opacity="0">
	                <Border BorderBrush="White" 
	                        BorderThickness="1"
	                        CornerRadius="0">
	                    <Border.Background>
	                        <LinearGradientBrush StartPoint="0.5,0" EndPoint="0.5,1">
	                            <GradientStop Offset="1" Color="#FFFCE79F" />
	                            <GradientStop Color="#FFFDD3A8" />
	                        </LinearGradientBrush>
	                    </Border.Background>
	                </Border>
	            </Border>
	            <Border x:Name="DisabledVisual" 
	                    BorderBrush="#FF989898"
	                    BorderThickness="1"
	                    CornerRadius="1"
	                    Opacity="0">
	                <Border Background="#FFE0E0E0" 
	                        BorderBrush="Transparent"
	                        BorderThickness="1"
	                        CornerRadius="0" />
	            </Border>
	            <ContentControl x:Name="Header" 
	                            Margin="{TemplateBinding Padding}"
	                            HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
	                            VerticalAlignment="{TemplateBinding VerticalContentAlignment}"
	                            ContentTemplate="{TemplateBinding HeaderTemplate}"
	                            Foreground="{TemplateBinding Foreground}" />
	            <Rectangle x:Name="FocusVisual" 
	                       IsHitTestVisible="False"
	                       RadiusX="2"
	                       RadiusY="2"
	                       Stroke="Black"
	                       StrokeDashArray="1 2"
	                       StrokeThickness="1"
	                       Visibility="Collapsed" />
	        </Grid>
	        <Grid x:Name="ItemsContainer" 
	              Grid.Row="1"
	              Visibility="Collapsed">
	            <ItemsPresenter />
	        </Grid>
	    </Grid>
	    <ControlTemplate.Triggers>
	        <Trigger Property="IsSelected" Value="True">
	            <Setter TargetName="SelectionVisual" Property="Opacity" Value="1" />
	        </Trigger>
	        <Trigger Property="IsFocused" Value="True">
	            <Setter TargetName="FocusVisual" Property="Visibility" Value="Visible" />
	        </Trigger>
	        <Trigger Property="IsExpanded" Value="True">
	            <Setter TargetName="ItemsContainer" Property="Visibility" Value="Visible" />
	        </Trigger>
	        <Trigger Property="IsEnabled" Value="False">
	            <Setter TargetName="DisabledVisual" Property="Opacity" Value="1" />
	        </Trigger>
	        <EventTrigger RoutedEvent="Mouse.MouseEnter" SourceName="HeaderRow">
	            <BeginStoryboard>
	                <Storyboard>
	                    <DoubleAnimation Duration="0:0:0.2" 
	                                     Storyboard.TargetName="MouseOverVisual"
	                                     Storyboard.TargetProperty="Opacity"
	                                     To="1" />
	                </Storyboard>
	            </BeginStoryboard>
	        </EventTrigger>
	        <EventTrigger RoutedEvent="Mouse.MouseLeave" SourceName="HeaderRow">
	            <BeginStoryboard>
	                <Storyboard>
	                    <DoubleAnimation Duration="0:0:0.2" 
	                                     Storyboard.TargetName="MouseOverVisual"
	                                     Storyboard.TargetProperty="Opacity"
	                                     To="0" />
	                </Storyboard>
	            </BeginStoryboard>
	        </EventTrigger>
	    </ControlTemplate.Triggers>
	</ControlTemplate>
```
{% endif %}
