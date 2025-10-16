---
title: Visual Tree Helpers
page_title: Visual Tree Helpers
description: Telerik UI for {{ site.framework_name }} provides a few visual tree helper methods in the ChildrenOfTypeExtensions and ParentOfTypeExtensions classes.
slug: common-visual-tree-helpers
tags: childrenoftype, parentoftype, visual, tree, helper
published: True
position: 12
---

# Visual Tree Helpers

The UI for {{ site.framework_name }} provides with several extension methods that allows you to enumerate the UI children of an element or find its parents. This way you can get a specific control from the visual tree interact with it.

The methods are available in the __ChildrenOfTypeExtensions__ and __ParentOfTypeExtensions__ static classes. They extend the DependencyObject class so you can call them on any UI element.

To use the methods you will need to include the Telerik.Windows.Controls namespace. One way to do that is to add 'using' directive that points to - `using Telerik.Windows.Controls;`

>important The extension methods would be able to enumerate the children/parents only if the visual tree of the control has been loaded. This is why you should call the methods after the Loaded event of the corresponding control was invoked.

## ChildrenOfTypeExtensions

This class exposes several methods that you can use to get the children of an element.

* __ChildrenOfType&lt;T&gt;()__&mdash;A generic method that expects a type that derives from DependencyObject, and it searches the visual tree of the control for elements of the concrete type.
	
	__Example 1: Getting all children of type RadToggleButton from a RadExpander control__
	```C#
		// Using the extension method via the DependencyObject
		IEnumerable<RadToggleButton> toggleButtons = radExpander.ChildrenOfType<RadToggleButton>();
		
		// Using the method via the static class 
		IEnumerable<RadToggleButton> toggleButtons = ChildrenOfTypeExtensions.ChildrenOfType<RadToggleButton>(radExpander);
	```
	
* __FindChildByType&lt;T&gt;()__&mdash;A generic method that expects a type that derives from DependencyObject, and it searches the visual tree of the control for an element of the concrete type. The methods returns the first element it founds.
	
	__Example 2: Getting a child type RadToggleButton from a RadExpander control__
	```C#	
		// Using the extension method via the DependencyObject
		RadToggleButton toggleButton = radExpander.FindChildByType<RadToggleButton>();
		
		// Using the method via the static class 
		RadToggleButton toggleButton = ChildrenOfTypeExtensions.FindChildByType<RadToggleButton>(radExpander);
	```	

## ParentOfTypeExtensions

This class exposes several methods that you can use to get the parents of an element.

* __ParentOfType&lt;T&gt;()__&mdash;A generic method that expects a type that derives from DependencyObject, and it searches the visual tree of the application for parent elements of the concrete type. The method returns the first parent if founds.
	
	__Example 3: Getting the parent of type RadExpander from a RadToggleButton control__
	```C#
		// Using the extension method via the DependencyObject
		RadExpander expander = radToggleButton.ParentOfType<RadExpander>();
		
		// Using the method via the static class 
		RadExpander expander = ParentOfTypeExtensions.ParentOfType<RadExpander>(radToggleButton);
	```
	
* __GetParents()__&mdash;This method get all visual parents of the element. The method can be used the same way as in __Example 3__. 

* __GetVisualParent&lt;T&gt;()__&mdash;This method gets the first visual parent of the element. The method can be used the same way as in __Example 3__. 

* __IsAncestorOf()__&mdash;This method checks if an element is a parent of another element.

## See Also  
* [Attached Behaviors]({%slug common-mvvm-attached-behavior%})
* [Delegate Command]({%slug common-mvvm-delegate-command-implementation%})
* [Event to Command Behavior]({%slug common-event-to-command-behavior%})
