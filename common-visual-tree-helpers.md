---
title: Visual Tree Helpers
page_title: Visual Tree Helpers
description: Visual Tree Helpers
slug: common-visual-tree-helpers
tags: childrenoftype, parentoftype, visual, tree, helper
published: True
position: 18
---

# Visual Tree Helpers

The UI for {{ site.framework_name }} provides with several extension methods that allows you to enumerate the UI children of an element or find its parents. This way you can get a specific control from the visual tree interact with it.

The methods are available in the __ChildrenOfTypeExtensions__ and __ParentOfTypeExtensions__ static classes. They extend the DependencyObject class so you can call them on any UI element.

>important The extension methods would be able to enumerate the children/parents only if the visual tree of the control has been loaded. This is why you should call the methods after the Loaded event of the corresponding control was invoked.

>tip To call the method as an extension of DependencyObject you will need to add 'using' directive that points to Telerik.Windows.Controls - `using Telerik.Windows.Controls;`

## ChildrenOfTypeExtensions

This class exposes several methods that you can use to get the children of an element.

* __ChildrenOfType&lt;T&gt;__
	
	ChildrenOfType is a generic method that expects a type that derives from DependencyObject, and it searches the visual tree of the control for elements of the concrete type.
	
	#### __[C#] Example 1: Getting all children of type RadToggleButton from a RadExpander control__
	{{region common-visual-tree-helpers-0}}
		// Using the extension method via the DependencyObject
		IEnumerable<RadToggleButton> toggleButtons = radExpander.ChildrenOfType<RadToggleButton>();
		
		// Using the method via the static class 
		IEnumerable<RadToggleButton> toggleButtons = ChildrenOfTypeExtensions.ChildrenOfType<RadToggleButton>(radExpander);
	{{endregion}}
	
* __FindChildByType&lt;T&gt;__

	FindChildByType is a generic method that expects a type that derives from DependencyObject, and it searches the visual tree of the control for an element of the concrete type. The methods returns the first element it founds.
	
	#### __[C#] Example 2: Getting a child type RadToggleButton from a RadExpander control__
	{{region common-visual-tree-helpers-1}}	
		// Using the extension method via the DependencyObject
		RadToggleButton toggleButton = radExpander.FindChildByType<RadToggleButton>();
		
		// Using the method via the static class 
		RadToggleButton toggleButton = ChildrenOfTypeExtensions.FindChildByType<RadToggleButton>(radExpander);
	{{endregion}}	

## ParentOfTypeExtensions

This class exposes several methods that you can use to get the parents of an element.

* __ParentOfType&lt;T&gt;__
	
	ParentOfType is a generic method that expects a type that derives from DependencyObject, and it searches the visual tree of the application for parent elements of the concrete type. The method returns the first parent if founds.
	
	#### __[C#] Example 3: Getting the parent of type RadExpander from a RadToggleButton control__
	{{region common-visual-tree-helpers-2}}
		// Using the extension method via the DependencyObject
		RadExpander expander = radToggleButton.ParentOfType<RadExpander>();
		
		// Using the method via the static class 
		RadExpander expander = ParentOfTypeExtensions.ParentOfType<RadExpander>(radToggleButton);
	{{endregion}}
	
* __GetParents__: This method get all visual parents of the element. The method can be used the same way as in __Example 3__. 

* __GetVisualParent&lt;T&gt;__: This method gets the first visual parent of the element. The method can be used the same way as in __Example 3__. 

* __IsAncestorOf__: This method checks if an element is a parent of another element.

## See Also  
* [Attached Behaviors]({%slug common-mvvm-attached-behavior%})
* [Delegate Command]({%slug common-mvvm-delegate-command-implementation%})
* [Event to Command Behavior]({%slug common-event-to-command-behavior%})
