---
title: Backward Compatibility
page_title: Backward Compatibility
description: Backward Compatibility
slug: radtilelist-changes-backward-compatibility
tags: backward,compatibility
published: True
position: 1
---

# Backward Compatibility



## Q3 2014
      

* Panel of RadTileList is TileListGroupPanel rather than TileListPanel
          

* Each group is represented by TileGroupContainer rather than ContentControl
          

* Group property of Tile is now a TileGroup type rather than just an object
          

* Group property of Tile is not settable and you can only read its value
          

Before:

#### __XAML__

{{region radtilelist-changes-backward-compatibility-0}}

			<telerik:TileGroup Header="Continent" x:Key="Group1" />
			<telerik:TileGroup Header="Country" x:Key="Group2" />
			<telerik:RadTileList x:Name="RadTileList"
								 GroupTemplate="{StaticResource GroupTemplate}">
				<telerik:Tile Group="{StaticResource Group1}" Content="Europe" />
				<telerik:Tile Group="{StaticResource Group2}" Content="Germany" />
				<telerik:Tile Group="{StaticResource Group1}" Content="Asia" />
				<telerik:Tile Group="{StaticResource Group2}" Content="Italy" />
			</telerik:RadTileList>
{{endregion}}



Now __Q3 2014__
#### __XAML__

{{region radtilelist-changes-backward-compatibility-1}}

			<telerik:RadTileList x:Name="RadTileList">
				<telerik:RadTileList.Groups>
					<telerik:TileGroup Header="Continent">
	                    <telerik:TileGroup.Items>
							<telerik:Tile Content="Asia"/>
							<telerik:Tile Content="Europe"/>
						</telerik:TileGroup.Items>
					</telerik:TileGroup>
					<telerik:TileGroup Header="Country">
						<telerik:TileGroup.Items>
							<telerik:Tile Content="Italy"/>
							<telerik:Tile Content="Germany"/>
						</telerik:TileGroup.Items>
					</telerik:TileGroup>
				</telerik:RadTileList.Groups>
			</telerik:RadTileList>
{{endregion}}



*  Group property of Tile cannot be set through Style since it can be only read. Since Tile belongs to a group you need to add it in its Items collection when they are manually generated or set GroupMember property of TileList when bound to data source.
          

*  Since each group is now represented of TileGroupContainer, if you have custom theme, you need to copy the style for this control in the template of RadTileList:
          

#### __XAML__

{{region radtilelist-changes-backward-compatibility-2}}

			<DataTemplate x:Key="GroupTemplate">
				<ContentPresenter Content="{Binding Header}"/>
			</DataTemplate>
			<ItemsPanelTemplate x:Key="GroupPanelTemplate">
				<telerik:TileListPanel x:Name="groupPanelTemplatePanel" VerticalAlignment="{Binding VerticalTilesAlignment, RelativeSource={RelativeSource AncestorType=telerik:RadTileList}}"/>
			</ItemsPanelTemplate>
			<ControlTemplate x:Key="TileGroupContainerTemplate" TargetType="telerik:TileGroupContainer">
				<Grid>
					<Grid.RowDefinitions>
						<RowDefinition Height="{Binding GroupHeaderHeight, RelativeSource={RelativeSource AncestorType=telerik:RadTileList}}"/>
						<RowDefinition />
					</Grid.RowDefinitions>
					<ContentPresenter Content="{Binding Header}" Margin="{TemplateBinding Padding}" VerticalAlignment="{TemplateBinding VerticalContentAlignment}" HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
									  Visibility="{Binding GroupHeaderVisibility, RelativeSource={RelativeSource AncestorType=telerik:RadTileList}}"
									  ContentTemplate="{TemplateBinding HeaderTemplate}"/>
					<ItemsPresenter Grid.Row="1" />
				</Grid>
			</ControlTemplate>
			<Style x:Key="TileGroupContainerStyle" TargetType="telerik:TileGroupContainer">
				<Setter Property="Template" Value="{StaticResource TileGroupContainerTemplate}" />
				<Setter Property="HeaderTemplate" Value="{Binding GroupTemplate, RelativeSource={RelativeSource AncestorType=telerik:RadTileList}}" />
				<Setter Property="ItemsPanel" Value="{StaticResource GroupPanelTemplate}" />
				<Setter Property="ItemsSource" Value="{Binding Items}" />
				<Setter Property="Padding" Value="5,0,0,0"/>
				<Setter Property="Header" Value="{Binding Header}" />
				<Setter Property="VerticalContentAlignment" Value="Center"/>
				<Setter Property="HorizontalContentAlignment" Value="Stretch"/>
				<c:If Condition="WPF">
					<Setter Property="SnapsToDevicePixels" Value="True"/>
					<Setter Property="FocusVisualStyle" Value="{x:Null}"/>
				</c:If>
				<Setter Property="UseLayoutRounding" Value="True"/>
			</Style>
	
{{endregion}}



* If you have custom theme, you need to update the panel of RadTileList and it should be:
          

#### __XAML__

{{region radtilelist-changes-backward-compatibility-3}}

			<ItemsPanelTemplate x:Key="RadTileListItemsPanelTemplate">
				<telerik:TileListGroupPanel/>
			</ItemsPanelTemplate>
	
{{endregion}}



* HorizontalScrollBarVisibility property of ScrollViewer is set to Auto and there is no need to set it explicitly in the definition of RadTileList
          

* There is GroupTemplate by default and it is not necessary to declare it explicitly in order to see the groups
          

* Default value of TileListPanel property Padding is changed to new Thickness(0, 0, 0, 0) rather than Thikness(0, 30, 0, 0)
          
