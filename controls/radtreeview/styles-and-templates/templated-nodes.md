---
title: Templated Nodes
page_title: Templated Nodes
description: Check our &quot;Templated Nodes&quot; documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-styles-and-templates-templated-nodes
tags: templated,nodes
published: True
position: 6
---

# Templated Nodes

The Telerik __RadTreeView__ is a lookless and completely stylable control. This tutorial will demonstrate how you can build a horizontal treeview by simply using __Styles__ and __ControlTemplates__.

Here is how the final result should look like: 
![{{ site.framework_name }} RadTreeView Horizontal Orientation with Styles and Templates](images/RadTreeView_TemplatingTemplatedNodes.PNG)

For the purpose of this tutorial will be used the following treeview declaration: 

<snippet id='radtreeview-styles-and-templates-templated-nodes-block_1-xaml' />

![{{ site.framework_name }} RadTreeView Sample Declaration](images/RadTreeView_TemplatingTemplatedNodes_001.PNG)

* The treeview has to be made horizontal. In order to do that you need to set the __ItemContainerStyle__ property of the __RadTreeView__ and __RadTreeViewItem__.

	Declare the following style in the resources of your application. It will set the __ItemsPanel__ to a __StackPanel__ with __Horizontal__ orientation: 

	<snippet id='radtreeview-styles-and-templates-templated-nodes-block_2-xaml' />
	
	<snippet id='radtreeview-styles-and-templates-templated-nodes-block_3-xaml' />

	Apply this style to the __ItemContainerStyle__ of the treeview and each treeview item. 

	<snippet id='radtreeview-styles-and-templates-templated-nodes-block_4-xaml' />

	Additionally you need to set the __ItemsPanel__ of the treeview: 

	<snippet id='radtreeview-styles-and-templates-templated-nodes-block_5-xaml' />

	So far you should have the following result: 
	![{{ site.framework_name }} RadTreeView Horizontal StackPanel](images/RadTreeView_TemplatingTemplatedNodes_010.PNG)

The next step is to make some visual enhancements in the tree. 

* Style the expander. If you want to read more information about how to style a treeview expander, see the main topic [Styling Expander]({%slug radtreeview-styling-and-appearance-styling-expander%}).

	Add the following style declaration in your resources and apply it on the __ExpanderStyle__ property of the treeview: 

	<snippet id='radtreeview-styles-and-templates-templated-nodes-block_6-xaml' />

	<snippet id='radtreeview-styles-and-templates-templated-nodes-block_7-xaml' />
	
	<snippet id='radtreeview-styles-and-templates-templated-nodes-block_8-xaml' />

	And the effect can be seen on the next snapshot:
	![{{ site.framework_name }} RadTreeView Horizontal Expander Style](images/RadTreeView_TemplatingTemplatedNodes_020.PNG)

* You need to create the template for the treeview nodes. Add the following __ControlTemplate__ declaration to your application resources: 

	<snippet id='radtreeview-styles-and-templates-templated-nodes-block_9-xaml' />

	<snippet id='radtreeview-styles-and-templates-templated-nodes-block_10-xaml' />

* In your __TreeViewItemStyle__ set the __Template__ property to the __ControlTemplate__ declared on the previous step: 

	<snippet id='radtreeview-styles-and-templates-templated-nodes-block_11-xaml' />

	<snippet id='radtreeview-styles-and-templates-templated-nodes-block_12-xaml' />

	We are one step closer to the desired result: 
	![{{ site.framework_name }} RadTreeView Score Table](images/RadTreeView_TemplatingTemplatedNodes_030.PNG)

In order to add animation to your treeview you need to use {% if site.site_name == 'WPF' %}triggers{% endif %}{% if site.site_name == 'Silverlight' %} the Visual State Manager{% endif %}. {% if site.site_name == 'Silverlight' %}Open your application in Expression Blend.{% endif %}
* __Selected__
	* Set the __SelectionVisual__'s __Visibility__ to __Visible__
* __Focused__
	* Set the __FocusVisual__'s __Visibility__ to __Visible__

<snippet id='radtreeview-styles-and-templates-templated-nodes-block_13-xaml' />

Add three triggers to your control template, which are activated when the treeview item is selected, focused and expanded.

* When the __IsSelected__ property is __True__, set the __SelectionVisual's__ visibility to __Visible__. Accordingly, when the __IsSelected__ property is __False__, set the __SelectionVisual's__ visibility to __Hidden__. 
* When the __IsFocused__ property is __True__, set the __FocusVisual's__ visibility to __Visible__. Accordingly, when the __IsFocused__ property is __False__, set the __FocusVisual's__ visibility to __Hidden__. 
* When the __IsExpanded__ property is __True__, set the __ItemHost's__ visibility to __Visible__. Accordingly, when the __IsExpanded__ property is __False__, set the __ItemHost's__ visibility to __Hidden__.

Here is the complete XAML for __ControlTemplate.Triggers__ section and the final result:

<snippet id='radtreeview-styles-and-templates-templated-nodes-block_14-xaml' />

And here is the final result:
![{{ site.framework_name }} RadTreeView Final Score Table](images/RadTreeView_TemplatingTemplatedNodes_060.PNG)

## See Also
 * [Styling the Expander]({%slug radtreeview-styling-and-appearance-styling-expander%})