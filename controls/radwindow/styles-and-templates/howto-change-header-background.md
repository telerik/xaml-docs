---
title: How To Change Header Background
page_title: How To Change Header Background
description: You can change RadWindow header background by extracting its default template
slug: radwindow-styles-and-templates-how-to-change-header-background
tags: styling,the,windows, header, default,template, change,extract
published: True
position: 4
---

# How To Change Header Background

>tipBefore reading this topic, you might find it useful to get familiar with the [Template Structure of the RadWindow control]({%slug radwindow-styles-and-templates-template-structure%}).

This article explains how you could customize the header of the RadWindow control by extracting its default template.

>tipThis article showcases the Office2016 theme.

To change the header background of the RadWindow you will need to extract and edit the default template of the control. __Example 1__ holds the default template of the RadWindow based on the Office2016 theme. We will place all resources in a separate ResourceDictionary which we will merge in the App.xaml file.

#### __[XAML] Example 1: Default RadWindow template based on the Office2016 theme__
{{region xaml-radwindow-styles-and-templates-how-to-change-header-background_0}}
	<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
						xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
						 xmlns:animation="clr-namespace:Telerik.Windows.Controls.Animation;assembly=Telerik.Windows.Controls"
						xmlns:telerik1="clr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls"
						xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
						xmlns:sys="clr-namespace:System;assembly=mscorlib"
						xmlns:navigation="clr-namespace:Telerik.Windows.Controls.Navigation;assembly=Telerik.Windows.Controls.Navigation"
						xmlns:telerikNavigation="clr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.Navigation">
		<SolidColorBrush x:Key="WindowModalBackground" Color="#FFCCE4FC"/>
		<sys:String x:Key="GlyphClose"></sys:String>
		<sys:String x:Key="GlyphMinimize"></sys:String>
		<telerik:InvertedBooleanToVisibilityConverter x:Key="InvertedBooleanToVisibilityConverter"/>
		<telerik1:BooleanToVisibilityConverter x:Key="BooleanToVisibilityConverter"/>
		<sys:String x:Key="GlyphWarning"></sys:String>
		<sys:String x:Key="GlyphWindow"></sys:String>
		<sys:String x:Key="GlyphWindowCollapse"></sys:String>
		<sys:String x:Key="GlyphQuestion"></sys:String>
		<FontFamily x:Key="TelerikWebUI">/Telerik.Windows.Controls;component/Themes/Fonts/TelerikWebUI.ttf#TelerikWebUI</FontFamily>
		<DataTemplate x:Key="AlertIconTemplate">
			<TextBlock
					FontSize="64"
					FontFamily="{StaticResource TelerikWebUI}"
					Foreground="{telerik1:Office2016Resource ResourceKey=IconBrush}"
					telerik:GlyphAdorner.ShowGlyphInDesignTime="True"
					FontWeight="Normal"
					FontStyle="Normal">
				<Run Text="{StaticResource GlyphWarning}"/>
			</TextBlock>
		</DataTemplate>
		<DataTemplate x:Key="ConfirmIconTemplate">
			<TextBlock
					FontSize="64"
					FontFamily="{StaticResource TelerikWebUI}"
					Foreground="{telerik1:Office2016Resource ResourceKey=IconBrush}"
					telerik:GlyphAdorner.ShowGlyphInDesignTime="True"
					FontWeight="Normal"
					FontStyle="Normal">
				<Run Text="{StaticResource GlyphQuestion}"/>
			</TextBlock>
		</DataTemplate>
		<Style x:Key="WindowButtonStyle" TargetType="telerik:RadButton">
			<Setter Property="Foreground" Value="{telerik1:Office2016Resource ResourceKey=IconBrush}"/>
			<Setter Property="Height" Value="30"/>
			<Setter Property="Width" Value="45"/>
			<Setter Property="VerticalAlignment" Value="Center"/>
			<Setter Property="VerticalContentAlignment" Value="Bottom"/>
			<Setter Property="IsTabStop" Value="False"/>
			<Setter Property="FocusVisualStyle" Value="{x:Null}"/>
			<Setter Property="UseLayoutRounding" Value="True"/>
			<Setter Property="Template">
				<Setter.Value>
					<ControlTemplate TargetType="telerik:RadButton">
						<Grid>
							<Border x:Name="BorderVisual" Background="Transparent" CornerRadius="{telerik1:Office2016Resource ResourceKey=CornerRadius}"/>
							<ContentPresenter x:Name="Content" Margin="{TemplateBinding Padding}"/>
						</Grid>
						<ControlTemplate.Triggers>
							<Trigger Property="IsMouseOver" Value="True">
								<Setter TargetName="BorderVisual" Property="Background" Value="{telerik1:Office2016Resource ResourceKey=MouseOverBrush}"/>
							</Trigger>
							<Trigger Property="IsPressed" Value="True">
								<Setter TargetName="BorderVisual" Property="Background" Value="{telerik1:Office2016Resource ResourceKey=PressedBrush}"/>
							</Trigger>
							<Trigger Property="IsEnabled" Value="False">
								<Setter TargetName="Content" Property="Opacity" Value="{telerik1:Office2016Resource ResourceKey=DisabledOpacity}"/>
							</Trigger>
						</ControlTemplate.Triggers>
					</ControlTemplate>
				</Setter.Value>
			</Setter>
		</Style>
		<Style x:Key="WindowCloseButtonStyle" TargetType="telerik:RadButton">
			<Setter Property="Foreground" Value="{telerik1:Office2016Resource ResourceKey=IconBrush}"/>
			<Setter Property="Height" Value="30"/>
			<Setter Property="Width" Value="45"/>
			<Setter Property="VerticalAlignment" Value="Center"/>
			<Setter Property="VerticalContentAlignment" Value="Bottom"/>
			<Setter Property="IsTabStop" Value="False"/>
			<Setter Property="FocusVisualStyle" Value="{x:Null}"/>
			<Setter Property="UseLayoutRounding" Value="True"/>
			<Setter Property="Template">
				<Setter.Value>
					<ControlTemplate TargetType="telerik:RadButton">
						<Grid>
							<Border x:Name="BorderVisual" Background="Transparent" CornerRadius="{telerik1:Office2016Resource ResourceKey=CornerRadius}"/>
							<Border x:Name="PressedVisual"
									Background="{telerik1:Office2016Resource ResourceKey=MainBrush}"
									CornerRadius="{telerik1:Office2016Resource ResourceKey=CornerRadius}"
									Opacity="0"/>
							<ContentPresenter x:Name="Content" Margin="{TemplateBinding Padding}"/>
						</Grid>
						<ControlTemplate.Triggers>
							<Trigger Property="IsMouseOver" Value="True">
								<Setter TargetName="BorderVisual" Property="Background" Value="{telerik1:Office2016Resource ResourceKey=ValidationBrush}"/>
								<Setter Property="Foreground" Value="{telerik1:Office2016Resource ResourceKey=MarkerInvertedBrush}"/>
							</Trigger>
							<Trigger Property="IsPressed" Value="True">
								<Setter TargetName="BorderVisual" Property="Background" Value="{telerik1:Office2016Resource ResourceKey=ValidationBrush}"/>
								<Setter TargetName="PressedVisual" Property="Opacity" Value="0.5"/>
								<Setter Property="Foreground" Value="{telerik1:Office2016Resource ResourceKey=MarkerInvertedBrush}"/>
							</Trigger>
							<Trigger Property="IsEnabled" Value="False">
								<Setter TargetName="Content" Property="Opacity" Value="{telerik1:Office2016Resource ResourceKey=DisabledOpacity}"/>
							</Trigger>
						</ControlTemplate.Triggers>
					</ControlTemplate>
				</Setter.Value>
			</Setter>
		</Style>
		<ControlTemplate x:Key="RadWindowTemplate" TargetType="telerikNavigation:RadWindow">
			<Grid x:Name="LayoutRoot">
				<Border x:Name="WindowOuterBorder"
						Grid.RowSpan="2"
						BorderBrush="{TemplateBinding BorderBrush}"
						BorderThickness="{TemplateBinding BorderThickness}"
						Background="{TemplateBinding Background}"
						CornerRadius="{telerik1:Office2016Resource ResourceKey=CornerRadius}">
					<AdornerDecorator>
						<Grid>
							<Grid.RowDefinitions>
								<RowDefinition Height="Auto" MinHeight="30"/>
								<RowDefinition Height="*"/>
							</Grid.RowDefinitions>
							<Border x:Name="Header" Background="{telerik1:Office2016Resource ResourceKey=MainBrush}" CornerRadius="{telerik1:Office2016Resource ResourceKey=CornerRadiusTop}">
								<Grid>
									<Grid.ColumnDefinitions>
										<ColumnDefinition Width="*"/>
										<ColumnDefinition Width="Auto"/>
									</Grid.ColumnDefinitions>
									<Grid Grid.Column="0">
										<Grid.ColumnDefinitions>
											<ColumnDefinition Width="Auto"/>
											<ColumnDefinition Width="*"/>
										</Grid.ColumnDefinitions>
										<ContentPresenter x:Name="IconContent"
												Grid.Column="0"
												HorizontalAlignment="Left"
												VerticalAlignment="Center"
												Content="{TemplateBinding Icon}"
												ContentTemplate="{TemplateBinding IconTemplate}"
												Margin="4 2 0 2"/>
										<ContentControl x:Name="HeaderContent"
												Grid.Column="1"
												Margin="4 0"
												IsTabStop="False"
												HorizontalAlignment="Stretch"
												VerticalAlignment="Center"
												HorizontalContentAlignment="Stretch"
												Content="{TemplateBinding Header}"
												ContentTemplate="{TemplateBinding HeaderTemplate}"
												SnapsToDevicePixels="True"
												ContentTemplateSelector="{TemplateBinding HeaderTemplateSelector}"
												FontSize="{TemplateBinding FontSize}"
												FontFamily="{TemplateBinding FontFamily}"/>
									</Grid>
									<Border x:Name="PART_HeaderButtonsBorder" Grid.Column="1">
										<StackPanel x:Name="HeaderButtons" Grid.Column="1" Orientation="Horizontal">
											<telerik:RadButton x:Name="PART_MinimizeButton"
													Command="{x:Static telerik:WindowCommands.Minimize}"
													Style="{StaticResource WindowButtonStyle}"
													Visibility="{Binding IsEnabled, RelativeSource={RelativeSource Self}, Converter={StaticResource BooleanToVisibilityConverter}}">
												<ToolTipService.ToolTip>
													<ToolTip telerik:LocalizationManager.ResourceKey="Minimize"/>
												</ToolTipService.ToolTip>
												<TextBlock
														telerik:GlyphAdorner.ShowGlyphInDesignTime="True"
														FontSize="16"
														FontFamily="{StaticResource TelerikWebUI}"
														Foreground="{Binding Foreground, RelativeSource={RelativeSource AncestorType={x:Type telerik:RadButton}}}"
														VerticalAlignment="Center"
														HorizontalAlignment="Center"
														FontWeight="Normal"
														FontStyle="Normal">
													<Run Text="{StaticResource GlyphMinimize}"/>
												</TextBlock>
											</telerik:RadButton>
											<telerik:RadButton x:Name="PART_RestoreButton"
													Command="{x:Static telerik:WindowCommands.Restore}"
													Style="{StaticResource WindowButtonStyle}"
													Visibility="{Binding IsEnabled, RelativeSource={RelativeSource Self}, Converter={StaticResource BooleanToVisibilityConverter}}">
												<ToolTipService.ToolTip>
													<ToolTip telerik:LocalizationManager.ResourceKey="Restore"/>
												</ToolTipService.ToolTip>
												<TextBlock
														telerik:GlyphAdorner.ShowGlyphInDesignTime="True"
														FontSize="16"
														FontFamily="{StaticResource TelerikWebUI}"
														Foreground="{Binding Foreground, RelativeSource={RelativeSource AncestorType={x:Type telerik:RadButton}}}"
														VerticalAlignment="Center"
														HorizontalAlignment="Center"
														FontWeight="Normal"
														FontStyle="Normal">
													<Run Text="{StaticResource GlyphWindowCollapse}"/>
												</TextBlock>
											</telerik:RadButton>
											<telerik:RadButton x:Name="PART_MaximizeButton"
													Command="{x:Static telerik:WindowCommands.Maximize}"
													Style="{StaticResource WindowButtonStyle}"
													Visibility="{Binding IsEnabled, RelativeSource={RelativeSource Self}, Converter={StaticResource BooleanToVisibilityConverter}}">
												<ToolTipService.ToolTip>
													<ToolTip telerik:LocalizationManager.ResourceKey="Maximize"/>
												</ToolTipService.ToolTip>
												<TextBlock
														telerik:GlyphAdorner.ShowGlyphInDesignTime="True"
														FontSize="16"
														FontFamily="{StaticResource TelerikWebUI}"
														Foreground="{Binding Foreground, RelativeSource={RelativeSource AncestorType={x:Type telerik:RadButton}}}"
														VerticalAlignment="Center"
														HorizontalAlignment="Center"
														FontWeight="Normal"
														FontStyle="Normal">
													<Run Text="{StaticResource GlyphWindow}"/>
												</TextBlock>
											</telerik:RadButton>
											<telerik:RadButton x:Name="PART_CloseButton"
													Command="{x:Static telerik:WindowCommands.Close}"
													Style="{StaticResource WindowCloseButtonStyle}"
													Visibility="{Binding IsEnabled, RelativeSource={RelativeSource Self}, Converter={StaticResource BooleanToVisibilityConverter}}">
												<ToolTipService.ToolTip>
													<ToolTip telerik:LocalizationManager.ResourceKey="Close"/>
												</ToolTipService.ToolTip>
												<TextBlock
														telerik:GlyphAdorner.ShowGlyphInDesignTime="True"
														FontSize="16"
														FontFamily="{StaticResource TelerikWebUI}"
														Foreground="{Binding Foreground, RelativeSource={RelativeSource AncestorType={x:Type telerik:RadButton}}}"
														VerticalAlignment="Center"
														HorizontalAlignment="Center"
														FontWeight="Normal"
														FontStyle="Normal">
													<Run Text="{StaticResource GlyphClose}"/>
												</TextBlock>
											</telerik:RadButton>
										</StackPanel>
									</Border>
								</Grid>
							</Border>
							<ContentPresenter x:Name="ContentElement" Grid.Row="1" Margin="{TemplateBinding Padding}" Content="{TemplateBinding Content}" ContentTemplate="{TemplateBinding ContentTemplate}"/>
						</Grid>
					</AdornerDecorator>
				</Border>
			</Grid>
			<ControlTemplate.Triggers>
				<Trigger Property="IsInActiveState" Value="False">
					<Setter Property="BorderBrush" Value="{telerik1:Office2016Resource ResourceKey=BasicBrush}"/>
					<Setter TargetName="HeaderContent" Property="Opacity" Value="0.7"/>
					<Setter TargetName="PART_HeaderButtonsBorder" Property="Opacity" Value="0.7"/>
				</Trigger>
				<Trigger Property="WindowState" Value="Maximized">
					<Setter TargetName="WindowOuterBorder" Property="BorderThickness" Value="0"/>
					<Setter TargetName="HeaderButtons" Property="Margin" Value="0"/>
				</Trigger>
				<Trigger Property="WindowState" Value="Minimized">
					<Setter TargetName="HeaderButtons" Property="Margin" Value="0"/>
					<Setter TargetName="LayoutRoot" Property="HorizontalAlignment" Value="Left"/>
					<Setter TargetName="LayoutRoot" Property="VerticalAlignment" Value="Top"/>
					<Setter TargetName="PART_MinimizeButton" Property="Width" Value="30"/>
					<Setter TargetName="PART_RestoreButton" Property="Width" Value="30"/>
					<Setter TargetName="PART_MaximizeButton" Property="Width" Value="30"/>
					<Setter TargetName="PART_CloseButton" Property="Width" Value="30"/>
				</Trigger>
				<MultiTrigger>
					<MultiTrigger.Conditions>
						<Condition Property="Content" SourceName="IconContent" Value="{x:Null}"/>
						<Condition Property="ContentTemplate" SourceName="IconContent" Value="{x:Null}"/>
					</MultiTrigger.Conditions>
					<Setter TargetName="IconContent" Property="Visibility" Value="Collapsed"/>
				</MultiTrigger>
			</ControlTemplate.Triggers>
		</ControlTemplate>
		
		<Style TargetType="telerikNavigation:RadWindow">
			<Setter Property="FontFamily" Value="{telerik1:Office2016Resource ResourceKey=FontFamily}"/>
			<Setter Property="FontSize" Value="{telerik1:Office2016Resource ResourceKey=FontSize}"/>
			<Setter Property="Foreground" Value="{telerik1:Office2016Resource ResourceKey=MarkerBrush}"/>
			<Setter Property="Background" Value="{telerik1:Office2016Resource ResourceKey=MainBrush}"/>
			<Setter Property="BorderBackground" Value="{telerik1:Office2016Resource ResourceKey=MainBrush}"/>
			<Setter Property="BorderBrush" Value="{telerik1:Office2016Resource ResourceKey=AccentBrush}"/>
			<Setter Property="BorderThickness" Value="1"/>
			<Setter Property="IsTabStop" Value="false"/>
			<Setter Property="KeyboardNavigation.IsTabStop" Value="False"/>
			<Setter Property="SnapsToDevicePixels" Value="True"/>
			<Setter Property="FocusVisualStyle" Value="{x:Null}"/>
			<Setter Property="MinHeight" Value="30"/>
			<Setter Property="MinWidth" Value="100"/>
			<Setter Property="HorizontalAlignment" Value="Left"/>
			<Setter Property="VerticalAlignment" Value="Top"/>
			<Setter Property="HorizontalContentAlignment" Value="Stretch"/>
			<Setter Property="VerticalContentAlignment" Value="Stretch"/>
			<Setter Property="Header" Value="RadWindow"/>
			<Setter Property="WindowStartupLocation" Value="Manual"/>
			<Setter Property="WindowState" Value="Normal"/>
			<Setter Property="CaptionHeight" Value="30"/>
			<Setter Property="ResizeBorder" Value="5"/>
			<Setter Property="Template" Value="{StaticResource RadWindowTemplate}"/>
			<Setter Property="ModalBackground" Value="{StaticResource WindowModalBackground}"/>
			<Setter Property="animation:AnimationManager.AnimationSelector">
				<Setter.Value>
					<animation:AnimationSelector>
						<animation:AnimationGroup AnimationName="Show">
							<animation:FadeAnimation Direction="In" TargetElementName="LayoutRoot"/>
							<animation:ScaleAnimation Direction="In" TargetElementName="LayoutRoot" MinScale="0.9"/>
						</animation:AnimationGroup>
						<animation:AnimationGroup AnimationName="Hide">
							<animation:FadeAnimation Direction="Out" TargetElementName="LayoutRoot"/>
							<animation:ScaleAnimation Direction="Out" TargetElementName="LayoutRoot" MinScale="0.9"/>
						</animation:AnimationGroup>
					</animation:AnimationSelector>
				</Setter.Value>
			</Setter>
			<Setter Property="navigation:RadWindowInteropHelper.OpaqueWindowBackground" Value="{telerik1:Office2016Resource ResourceKey=AccentBrush}"/>
			<Style.Triggers>
				<Trigger Property="navigation:RadWindowInteropHelper.AllowTransparency" Value="False">
					<Setter Property="animation:AnimationManager.IsAnimationEnabled" Value="False"/>
				</Trigger>
			</Style.Triggers>
		</Style>
	</ResourceDictionary>
{{endregion}}

Next step is to locate a __Border__ element with x:Name="Header" which hold the header part and change its __Background__ property.

#### __[XAML] Example 2: Change Border background__

{{region xaml-radwindow-styles-and-templates-how-to-change-header-background_1}}
	. . . .
	 <Grid.RowDefinitions>
		<RowDefinition Height="Auto" MinHeight="30"/>
		<RowDefinition Height="*"/>
	</Grid.RowDefinitions>
	<Border x:Name="Header" Background="Red" CornerRadius="{telerik1:Office2016Resource ResourceKey=CornerRadiusTop}">
		<Grid>
	. . . . 	
{{endregion}}

Now we need to merge the custom ResourceDictionary in the App.xaml file, so that the modified style will be applied to all RadWindow elements inside the application. In case you are using RadWindow as MainWindow, please refer to the [Use RadWindow as User Control]({%slug radwindow-how-to-use-radwindow-as-user-control%}) for more information on how to apply the custom style to the main window.

#### __[C#] Example 3: Merged the custom ResourceDictionary__

{{region cs-radwindow-styles-and-templates-how-to-change-header-background_2}}
	<Application x:Class="Wpf_App1.App"
				 xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
				 xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
		<Application.Resources>
			<ResourceDictionary>
				<ResourceDictionary.MergedDictionaries>
					<ResourceDictionary Source="MyWindowStyleResourceDictionary.xaml"/>                
				</ResourceDictionary.MergedDictionaries>
			</ResourceDictionary>
		</Application.Resources>
	</Application>
{{endregion}}

#### __Figure 1: RadWindow with custom style__
![](images/RadWindow_Styles_and_Templates_HowTo_Change_Header_Background.png)

## See Also

 * [Template Structure]({%slug radwindow-styles-and-templates-template-structure%})

 * [Styling the RadWindow]({%slug radwindow-styles-and-templates-styling-the-radwindow%})

 * [Change the Default Theme]({%slug radwindow-how-to-change-the-default-theme%})
