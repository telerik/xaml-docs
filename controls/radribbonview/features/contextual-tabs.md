---
title: Contextual Tabs
page_title: Contextual Tabs
description: Contextual Tabs
slug: radribbonview-contextual-tabs
tags: contextual,tabs
published: True
position: 2
---

# Contextual Tabs

A contextual tab allows you to provide the users with a certain UI when they are in a specific context or they have selected a specific element. The contextual tabs are organized in groups, so that the user can see multiple tabs available for specific context.
![Rad Ribbon View Contextual Sample](images/RadRibbonView_Contextual_Sample.png)

The contextual groups are used to display tabs with a context-specific functionality. They get displayed only when this functionality is needed. This way the common UI in the __RadRibbonView__ becomes lighter while the specific functionality becomes easier to find as it is grouped and displayed on demand.	  

To define contextual tabs in the __RadRibbonView__ control you have to first define their groups. You can do that declaratively, programmatically or using data-binding through the following properties:	  

* __ContextualGroups__ - gets or sets a collection of __RadRibbonContextualGroups__ used to generate the contextual groups. This collection can be populated declaratively in XAML or programmatically in code-behind.		  

	#### __XAML__

	{{region radribbonview-contextual-tabs-3}}
		<telerik:RadRibbonView x:Name="radRibbonView" 
							   Title="Document1"
							   ApplicationName="Telerik Word">
					<telerik:RadRibbonView.ContextualGroups>
				<telerik:RadRibbonContextualGroup x:Name="ContextualGroup1" Header="Group 1"/>
				<telerik:RadRibbonContextualGroup x:Name="ContextualGroup2" Header="Group 2"/>
					</telerik:RadRibbonView.ContextualGroups>
		</telerik:RadRibbonView>
	{{endregion}}
	
* __ContextualGroupsItemsSource__ - gets or sets an __IEnumerable__ collection of business items used to generate the contextual groups. You can bind this property to a collection of data items in XAML or populate it in code-behind.

	#### __XAML__

	{{region radribbonview-contextual-tabs-4}}
		<telerik:RadRibbonView  ItemsSource="{Binding Tabs}" 
								ContextualGroupsItemsSource="{Binding ContextualGroups}" />
	{{endregion}}

## Adding Contextual RadRibbonTabs Declaratively

In order to add contextual tabs, you need to define __RadRibbonTabs__ associated with contextual groups. The __RadRibbonTab__ control exposes a __ContextualGroupName__ property that allows you to associate it with a __ContextualGroup__.

#### __XAML__

{{region radribbonview-contextual-tabs-1}}
	<Grid>
	        <Grid.RowDefinitions>
	            <RowDefinition Height="Auto" />
	            <RowDefinition Height="*" />
	        </Grid.RowDefinitions>
	<telerik:RadRibbonView x:Name="radRibbonView" 
						   ApplicationButtonImageSource="Images/IconMSOffice/AppIcon.png"
						   telerik:KeyTipService.IsKeyTipsEnabled="True">
		<telerik:RadRibbonTab Header="Home" telerik:KeyTipService.AccessText="H" />
		<telerik:RadRibbonTab Header="Insert" telerik:KeyTipService.AccessText="N" />
		<telerik:RadRibbonTab Header="Page Layout" telerik:KeyTipService.AccessText="P" />
		<telerik:RadRibbonTab Header="References" telerik:KeyTipService.AccessText="S" />
		<telerik:RadRibbonTab Header="Mailings" telerik:KeyTipService.AccessText="M" />
		<telerik:RadRibbonTab Header="Review" telerik:KeyTipService.AccessText="R" />
		<telerik:RadRibbonTab Header="View" telerik:KeyTipService.AccessText="W" />
		<telerik:RadRibbonTab ContextualGroupName="ContextualGroup1" Header="ContextualTab 1.1" />
		<telerik:RadRibbonTab ContextualGroupName="ContextualGroup1" Header="ContextualTab 1.2" />
		<telerik:RadRibbonTab ContextualGroupName="ContextualGroup2" Header="ContextualTab 2.1" />
		<telerik:RadRibbonTab ContextualGroupName="ContextualGroup2" Header="ContextualTab 2.2" />
		<telerik:RadRibbonView.ContextualGroups>
			<telerik:RadRibbonContextualGroup x:Name="ContextualGroup1" Header="Group 1"/>
			<telerik:RadRibbonContextualGroup x:Name="ContextualGroup2" Header="Group 2"/>
		</telerik:RadRibbonView.ContextualGroups>
	</telerik:RadRibbonView>
	</Grid>
{{endregion}}

This is why it is important to set the __x:Name__ property of all __RadRibbonContextualGroups__ in the __RadRibbonView ContextualGroups__ collection, otherwise you won't be able to associate any __RibbonTabs__ with them.

## Data-Binding Contextual Groups and Tabs

In order to data-bind the __RadRibbonView__ to a collection of business items, you need to set its __ItemsSource__ property. This property is used to dynamically generate __RadRibbonTabs__. As the contextual tabs are __RadRibbonTabs__ associated with contextual groups, they are also generated through the data items in that collection. However, in order to make a dynamically generated __RadRibbonTab__ contextual, you need to define a style that sets the value of the __ContextualGroupName__ property.
		
{% if site.site_name == 'Silverlight' %}
You can bind the __RadRibbonTab ContextualGroupName__ to a business property utilizing the __RadRibbonView ContextualTabsStyle__. This property is exposed to allow you to apply a style specifically targeting the contextual tabs.		  

>tip When you're using implicit styles, as described in the {% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/styling-apperance-implicit-styles-overview.html){% endif %}{% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/styling-apperance-implicit-styles-overview.html){% endif %} tutorial, you need to base the custom __ContextualTabs__ style on the default __ContextualTabsStyle__.			

#### __XAML__

{{region radribbonview-contextual-tabs-5}}
	<UserControl.Resources>
		<Style x:Key="ContextualTabsStyle" TargetType="telerik:RadRibbonTab" BasedOn="{StaticResource ContextualTabsStyle}">
			<Setter Property="Header" Value="{Binding Header}" />
			<Setter Property="ContextualGroupName" Value="{Binding ContextualGroupName}" />
			<Setter Property="Margin" Value="0" />
		</Style>
	</UserControl.Resources>
	<telerik:RadRibbonView ContextualTabsStyle="{StaticResource ContextualTabsStyle}" 
							ItemsSource="{Binding Tabs}" 
							ContextualGroupsItemsSource="{Binding ContextualGroups}" />
{{endregion}}
{% endif %}

{% if site.site_name == 'WPF' %}
You can bind the __RadRibbonTab ContextualGroupName__ to a business property using a style setter. The __Style__ should target the __RadRibbonTab__ type.		  

#### __XAML__

{{region radribbonview-contextual-tabs-9}}
	<Style TargetType="telerik:RadRibbonTab">
		<Setter Property="Header" Value="{Binding Header}" />
		<Setter Property="ContextualGroupName" Value="{Binding ContextualGroupName}" />
	</Style>
{{endregion}}

{% endif %}

Once you have the __ItemsSource__ collection properly data-bound, you will need to also bind the __ContextualGroupsItemsSource__.		

>Please note that the __Name__ property of the __RadRibbonContextualGroups__ cannot be data-bound in a style setter. This is why we exposed an attached property - __RadRibbonContextualGroup.GroupName__, which internally sets the __Name__ so that a tab can be associated to a contextual group.		  

In order to data-bind the __ContextualGroups__ properties you can also use style bindings.		

#### __XAML__

{{region radribbonview-contextual-tabs-6}}
	<Style TargetType="telerik:RadRibbonContextualGroup">
		<Setter Property="telerik:RadRibbonContextualGroup.GroupName" Value="{Binding GroupName}" />
	</Style>
{{endregion}}

>tip You can download a runnable project demonstrating this approach from our online SDK repository. Please open [this link](https://github.com/telerik/xaml-sdk) and navigate to RibbonView/ContextualGroups-DataBinding.		  

__RadRibbonView__ exposes two methods that allow you to work with the __ContextualGroups ContainerGenerator__:		

* __ContainerFromContextualGroupItem()__ - returns the __RadRibbonContextualGroup__ corresponding to the given item.			

* __ItemFromContextualGroupContainer()__ - returns the item that corresponds to the specified, generated __RadRibbonContextualGroup__.			

## RibbonContextualGroup Properties

The __RadRibbonContextualGroup__ exposes a __Color__ property, which allows you to specify a color for the group. This color will not only be applied to the group's header, but to the header's of the tabs in this group.		

To make the __RadRibbonContextualGroup__ visible you have to set its __IsActive__ property to __True__. This should be done when a certain requirement is met by the user. This requirement should specify whether the specific functionality in the contextual tab is needed. For example if you have a contextual tab that should manipulate images, you'd want to show this tab only when the user has selected an image.		

You can set these properties in the definition of declaratively defined __RadRibbonContextualGroups:__

#### __XAML__

{{region radribbonview-contextual-tabs-7}}
	<telerik:RadRibbonView x:Name="radRibbonView" 
						   ApplicationButtonImageSource="Images/IconMSOffice/AppIcon.png">
		<telerik:RadRibbonView.ContextualGroups>
			<telerik:RadRibbonContextualGroup x:Name="ContextualGroup1" 
											  Header="Group 1"
											  IsActive="False"
											  Color="Coral" />
			<telerik:RadRibbonContextualGroup x:Name="ContextualGroup2" 
											  Header="Group 2"
											  IsActive="True"
											  Color="Orchid" />
		</telerik:RadRibbonView.ContextualGroups>
	</telerik:RadRibbonView>
{{endregion}}

or in an implicit style targeting the contextual groups:

#### __XAML__

{{region radribbonview-contextual-tabs-8}}
	<Style TargetType="telerik:RadRibbonContextualGroup">
	    <Setter Property="telerik:RadRibbonContextualGroup.GroupName" Value="{Binding Name}" />
	    <Setter Property="Color" Value="{Binding Color}" />
	    <Setter Property="Header" Value="{Binding Header}" />
	    <Setter Property="IsActive" Value="{Binding IsActive}" />
	</Style>
{{endregion}}

You can easily control the active groups from code-behind. For instance, the __IsActive__ property of the declaratively defined contextual groups demonstrated above can be easily changed when clicking a button:

#### __XAML__

{{region radribbonview-contextual-tabs-2}}
	<StackPanel Orientation="Horizontal" Grid.Row="1" VerticalAlignment="Top">
	    <Button x:Name="Group1Button"
	            Content="Activate Group 1"
	            Click="Group1Button_Click"
	            Margin="0,0,10,0" />
	    <Button x:Name="Group2Button"
	            Content="Activate Group 2"
	            Click="Group2Button_Click" />
	</StackPanel>
{{endregion}}

#### __C#__

{{region radribbonview-contextual-tabs_3}}
	private void Group1Button_Click( object sender, RoutedEventArgs e )
	{
	    if ( !this.ContextualGroup1.IsActive )
	        this.ContextualGroup1.IsActive = true;
	    if ( this.ContextualGroup2.IsActive )
	        this.ContextualGroup2.IsActive = false;
	}
	private void Group2Button_Click( object sender, RoutedEventArgs e )
	{
	    if ( !this.ContextualGroup2.IsActive )
	        this.ContextualGroup2.IsActive = true;
	    if ( this.ContextualGroup1.IsActive )
	        this.ContextualGroup1.IsActive = false;
	}
{{endregion}}

#### __VB.NET__

{{region radribbonview-contextual-tabs_4}}
	Private Sub Group1Button_Click(sender As Object, e As RoutedEventArgs)
		If Not Me.ContextualGroup1.IsActive Then
			Me.ContextualGroup1.IsActive = True
		End If
	
		If Me.ContextualGroup2.IsActive Then
			Me.ContextualGroup2.IsActive = False
		End If
	End Sub
	
	Private Sub Group2Button_Click(sender As Object, e As RoutedEventArgs)
		If Not Me.ContextualGroup2.IsActive Then
			Me.ContextualGroup2.IsActive = True
		End If
	
		If Me.ContextualGroup1.IsActive Then
			Me.ContextualGroup1.IsActive = False
		End If
	End Sub
{{endregion}}

![Rad Ribbon View Contextual Groups Activate 1](images/RadRibbonView_ContextualGroups_Activate1.png)
![Rad Ribbon View Contextual Groups Activate 2](images/RadRibbonView_ContextualGroups_Activate2.png)

## See Also
 * [Ribbon Tab]({%slug radribbonview-ribbon-tab%})
 * [Controlling Appearance]({%slug radribbonview-styling-controlling-appearance%})