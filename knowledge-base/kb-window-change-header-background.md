---
title: Change Header Background of RadWindow
description: Modify Color RadWindow Header Background.
page_title: Replace Window Header Brush in Office2016 Theme
type: how-to
slug: kb-window-change-header-background
position: 0
tags: window,close, mvvm, button, custom, template
ticketid: 313798
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.116</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadWindow for WPF</td>
	</tr>
</table>

## Description

How to change the header background of the RadWindow control in the Office2016 theme.

## Solution

This approach shows how to change the background in the Office2016 theme, but the basic principle is the same - extract the ControlTemplate of RadWindow for the corresponding theme and change the brush.

To change the background [extract the ControlTemplate]({%slug styling-apperance-editing-control-templates%}) of RadWindow and change the Background property of the Border control with x:Name set to Header.

__Example 1: Extracted default ControlTemplate of RadWindow for Office2016 theme__ 
```XAML
	<Application.Resources>
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
	</Application.Resources>
```

__Example 2: Modification of the Border Background that is applied to the header__ 
```XAML
	<!-- other XAML -->
	<Border x:Name="Header" Background="Red" CornerRadius="{telerik1:Office2016Resource ResourceKey=CornerRadiusTop}">
	<!-- other XAML -->
```

![{{ site.framework_name }} RadWindow Change Header Background](images/kb-window-change-header-background-0.png)