---
title: Hierarchy
page_title: Hierarchical Navigation Menu
description: RadNavigationView allows you to define sub items in order to achieve hierarchical menu visualization.
slug: radnavigationview-features-hierarchy
tags: threshold, mode, display, pane, size
position: 0
---

# Hierarchy

RadNavigationView allows you to define sub-items in order to achieve hierarchical menu visualizаtion.

Each RadNavigationViewItem element has an Items collection that can be populated with RadNavigationViewItem elements, thus allowing multiple levels of items to be defined in the hierarchy.

#### __[XAML] Example 1: Setting up hierarchical navigation view in XAML__
{{region radnavigationview-features-hierarchy-0}}
	<telerik:RadNavigationView PaneHeader="Mail">
		<telerik:RadNavigationView.Items>
			<telerik:RadNavigationViewItem Content="Accounts">
				<telerik:RadNavigationViewItem.Items>
					<telerik:RadNavigationViewItem Content="Martin Ivanov (mi@prgs.com)" />
					<telerik:RadNavigationViewItem Content="Jon Doe (jd@prgs.com)" />                       
				</telerik:RadNavigationViewItem.Items>
			</telerik:RadNavigationViewItem>
			<telerik:RadNavigationViewItem Content="Folders">
				<telerik:RadNavigationViewItem.Items>
					<telerik:RadNavigationViewItem Content="Inbox"/>
					<telerik:RadNavigationViewItem Content="Drafts"/>
					<telerik:RadNavigationViewItem Content="Sent Items"/>
					<telerik:RadNavigationViewItem Content="Deleted Items"/>
				</telerik:RadNavigationViewItem.Items>
			</telerik:RadNavigationViewItem>             
		</telerik:RadNavigationView.Items>
	</telerik:RadNavigationView>
{{endregion}}

To control the current expand state of a RadNavigationViewItem, set its __IsExpanded__ property.

#### Figure 1: Hierarchical RadNavigationView
![](images/radnavigationview-features-hierarchy-0.png)

## Multiple Expanded Items

By default, multiple RadNavigationViewItem elements with child items can be expanded at once. To change this and allow only a single expanded item, set the __AllowMultipleExpandedItems__ property of RadNavigationView to False. 

#### __[XAML] Example 2: Disabling multiple expanded items at once__
{{region radnavigationview-features-hierarchy-1}}
	<telerik:RadNavigationView AllowMultipleExpandedItems="False" />
{{endregion}}

## Child Items Indentation

To change the default horizontal offset (indent) of the child items relative to their parent, set the __SubItemsIndentation__ property of RadNavigationView.

#### __[XAML] Example 3: Setting the indent of sub items__
{{region radnavigationview-features-hierarchy-2}}
	<telerik:RadNavigationView SubItemsIndentation="10" />
{{endregion}}

#### Figure 2: Sub items indentation set to 10
![](images/radnavigationview-features-hierarchy-1.png)

## Expand and Collapse Icon

RadNavigationViewItem has default expand and collapse icons shown in the right part of the item when it has children. To replace the icons, set the __ExpandedIcon__ and __CollapsedIcon__ properties of RadNavigationViewItem. The default icon template uses [RadGlyph]({%slug common-styling-appearance-radglyph%}) and you can set the properties to a glyph string from the [glyphs reference sheet]({%slug common-styling-appearance-glyphs-reference-sheet%}).

#### __[XAML] Example 4: Setting the expand and collapse icons__
{{region radnavigationview-features-hierarchy-3}}
	<telerik:RadNavigationViewItem ExpandedIcon="&#xe901;" CollapsedIcon="&#xe900;">
{{endregion}}

#### Figure 3: RadNaviationViewItems with folder glyphs as expand/collapse icons
![](images/radnavigationview-features-hierarchy-2.png)

To change this behavior and use other UI for the icons like a customized RadGlyph, an Image, or any other element, set the __ExpandedIconTemplate__ and __CollapsedIconTemplate__ properties. The properties expect DataTemplate values.

#### __[XAML] Example 5: Setting the expand and collapse icon templates__
{{region radnavigationview-features-hierarchy-4}}
	<Window.Resources>
		<DataTemplate x:Key="ExpandedCollapsedIconTemplate">
			<Image Source="{Binding}" Width="16" Height="16" />
		</DataTemplate>
	</Window.Resources>
	
	<telerik:RadNavigationViewItem ExpandedIcon="Images/expanded-icon.png" 
                                   CollapsedIcon="Images/collapsed-icon.png" 
                                   ExpandedIconTemplate="{StaticResource ExpandedCollapsedIconTemplate}"
                                   CollapsedIconTemplate="{StaticResource ExpandedCollapsedIconTemplate}" />                    
{{endregion}}

#### Figure 4: RadNavigationViewItems with folder images as expand/collapse icons
![](images/radnavigationview-features-hierarchy-3.png)

In data binding scenarios or when there are many items, you can use the __ItemContainerStyle__ property to set the icon properties.

## Flyout 

When RadNavigationView is collapsed and its current [DisplayMode]({%slug radnavigationview-display-mode%}) Compact, you can display the nested menu items by clicking on the collapsed RadNavigationViewItems.

#### Figure 5: Sub menu flyout visualization
![](images/radnavigationview-features-hierarchy-4.png)

## Events

The expanding and collapsing actions fire the __ItemExpanded__ and __ItemCollapsed__ events of RadNavigationView. 

Additionally, the RadNavigationViewItem exposes __Expanded__ and __Collapsed__ events.

#### __[XAML] Example 6: Subscribing to ItemExpanded event__
{{region radnavigationview-features-hierarchy-5}}
	<telerik:RadNavigationView ItemExpanded="RadNavigationView_ItemExpanded" />
{{endregion}}

#### __[C#] Example 7: ItemExpanded event handler__
{{region radnavigationview-features-hierarchy-6}}
	private void RadNavigationView_ItemExpanded(object sender, RoutedEventArgs e)
	{
		var expandedItem = (RadNavigationViewItem)e.OriginalSource;
	}
{{endregion}}

> The Expanded/Collapsed event of RadNavigationViewItem is fired before the ItemExpanded/ItemCollapsed event of RadNavigationView.

## Data Binding

RadNavigationViewItem exposes ItemsSource and few other data related properties that allow setting up the hierarchy in a data binding scenario. Read more about this in the [Hierarchical Data Binding]({%slug radnavigationview-populating-with-data-hierarchical-databinding%}) article.

## See Also  
* [Getting Started]({%slug radnavigationview-getting-started%})
* [Display Mode]({%slug radnavigationview-display-mode%})
* [Events]({%slug radnavigationview-events%})
* [Icon and IconTemplate]({%slug radnavigationview-icon-and-icontemplate%})
