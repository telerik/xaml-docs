---
title: Backward Compatibility
page_title: Backward Compatibility
description: Check our &quot;Backward Compatibility&quot; documentation article for the RadTileList {{ site.framework_name }} control.
slug: radtilelist-changes-backward-compatibility
tags: backward,compatibility
published: True
position: 1
---

# Backward Compatibility



## Q3 2014
      

* Panel of __RadTileList__ is __TileListGroupPanel__ rather than __TileListPanel__
          

* Each group is represented by __TileGroupContainer__ rather than __ContentControl__
          

* Group property of Tile is now a __TileGroup__ type rather than just an object
          

* __Group__ property of Tile is __not settable__ and you can only read its value
          

Before:

__Example 1: RadTileList before Q3 2014__

```XAML
			<Grid.Resources>
			   <telerik:TileGroup Header="Continent" x:Key="Group1" />
			   <telerik:TileGroup Header="Country" x:Key="Group2" />
			</Grid.Resources>
			<!--<telerik:RadTileList x:Name="RadTileList"
			         GroupTemplate="{StaticResource GroupTemplate}">
			<telerik:Tile Group="{StaticResource Group1}" Content="Europe" />
			<telerik:Tile Group="{StaticResource Group2}" Content="Germany" />
			<telerik:Tile Group="{StaticResource Group1}" Content="Asia" />
			<telerik:Tile Group="{StaticResource Group2}" Content="Italy" />
			</telerik:RadTileList>-->
	```



After __Q3 2014__

__Example 2: RadTileList after Q3 2014__

```XAML
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
	```



*  __Group__ property of __Tile__ cannot be set through __Style__ since it can be only read. Since __Tile__ belongs to a group you need to add it in its __Items__ collection when they are manually generated or set __GroupMember__ property of __TileList__ when bound to data source.
          

*  Since each group is now represented of __TileGroupContainer__, if you have custom theme, you need to copy the style for this control in the template of RadTileList:
          

__Example 3: Setting a Style for TileGroupContainer__

```XAML
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
			  <Setter Property="UseLayoutRounding" Value="True"/>
			</Style>
	```



* If you have custom theme, you need to update the panel of RadTileList and it should be:
          

__Example 4: Updating the panel of RadTileList__

```XAML
			<ItemsPanelTemplate x:Key="RadTileListItemsPanelTemplate">
			  <telerik:TileListGroupPanel/>
			</ItemsPanelTemplate>
	```



* __HorizontalScrollBarVisibility__ property of __ScrollViewer__ is set to __Auto__ and there is no need to set it explicitly in the definition of __RadTileList__
          

* There is __GroupTemplate__ by default and it is not necessary to declare it explicitly in order to see the groups
          

* Default value of __TileListPanel__ property Padding is changed to new Thickness(0, 0, 0, 0) rather than Thickness(0, 30, 0, 0)
          
