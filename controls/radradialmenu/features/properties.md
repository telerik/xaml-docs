---
title: Properties
page_title: Properties
description: Properties
slug: radradialmenu-features-properties
tags: properties
published: False
position: 0
---

# Properties

This topic describes all properties of __RadRadialMenu__ control and its elements.
        For more information about the structure of the menu you can take a look at the [Visual Structure]({%slug radradialmenu-visual-structure%}) article.
      

## RadRadialMenu Properties

* __IsOpen__ (bool) - Gets or sets a value that indicates whether __RadRadialMenu__ is open.
            

* __StartAngle__ (double) - Gets or sets the angle in radians at which the first __RadRadialMenuItem__ will be positioned.
              The default value of the property is *67.5d*.
            

* __InnerRadiusFactor__ (double) - Gets or sets the factor that defines the inner radius of the panel holding all __RadRadialMenuItems__ as a
              fraction of the size of __RadRadialMenu__ control. The value should be between 0 and 1. 
              If the passed value lies outside this range, it is automatically set to the nearest boundary value.
              The default value of the property is *0.3d*.
            

* __InnerNavigationRadiusFactor__ (double) - Gets or sets the factor that defines the inner radius of the panel holding the __NavigationItemButton__ items as a 
              fraction of the size of __RadRadialMenu__ control. The value should be between 0 and 1. If the passed value lies outside this range, it is automatically set to the nearest boundary value.
              The default value of the property is *0.85d*.
            

* __OuterRadiusFactor__ (double) - Gets or sets the factor that defines the outer radius of the panel holding the __NavigationItemButton__ items as a 
              fraction of the size of __RadRadialMenu__ control. The value should be between 0 and 1. If the passed value lies outside this range, it is automatically set to the nearest boundary value.
              The default value of the property is *1d*.
            

* __ContentMenuBackgroundStyle__ (Style) - Gets or sets a value that defines the appearance of the panel that holds the menu items. The Style should target the Rectangle type.
            

* __NavigationMenuBackgroundStyle__ (Style) - Gets or sets a value that defines the appearance of the panel that holds the __NavigationItemButton__ items.
              The Style should target the Rectangle type.
            

* __Items__ (ObservableCollection<RadRadialMenuItem>) - Gets the collection of all __RadRadialMenuItems__.
            

* __ShowToolTip__ (bool) - Gets or sets a value that indicates whether a tooltip, displaying the currently hovered __RadRadialMenuItem__ header text, will be displayed.
            

* __CommandService__ (CommandService) - Gets the __CommandService__ instance that manages the commanding behavior of __RadRadialMenu__.
            

* __Commands__ (CommandCollection<RadRadialMenu>) - Gets the collection that contains all custom commands registered with the __CommandService__.
              Custom commands have higher priority than the built-in (default) ones.
            

* __TargetElement__ (FrameworkElement) - Gets the target FrameworkElement instance that __RadRadialMenu__ is assigned to.
              Before the menu is attached to the element via the __RadialMenuTriggerBehavior__ this property has *null* value.
            

## RadRadialMenuItem Properties

* __IsEnabled__ (bool) -  Gets or sets a value indicating whether the visual representation of the menu item is enabled.
              The default value of the property is *true*.
            

* __IsSelected__ (bool) - Gets or sets a value indicating whether the visual representation of the menu item is selected.
              The default value of the property is *false*.
            

* __Selectable__ (bool) - Gets or sets a value indicating whether the menu item can be selected.
              The default value of the property is *true*.
            

* __Deselectable__ (bool) - Gets or sets a value indicating whether the menu item can be deselected.
              The default value of the property is *true*.
            

* __GroupName__ (string) - Gets or sets a value specifying the name of the group this item belongs to.
              All items in a group behave like radio buttons when selected.
              The default value of the property is *null*.
            

* __Header__ (object) - Gets or sets a value specifying the visual representation of the title of the menu item.
              The default value of the property is *null*.
            

* __IconContent__ (object) - Gets or sets a value specifying the visual representation of the icon associated with the menu item.
              The default value of the property is *null*.
            

* __ToolTipContent__ (object) - Gets or sets the content that will be visualized in the tooltip for the current __RadRadialMenuItem__.
              If this value is not set, the tooltip will display the Header content.
            

* __ContentSectorBackground__ (Brush) - Gets or sets the Brush that defines the background of the menu item.
              The default value of the property is *null*.
            

* __ParentItem__ (RadRadialMenuItem) - Gets the parent of the current __RadRadialMenuItem__.
            

* __ChildItems__ (ObservableCollection<RadRadialMenuItem>) - Gets the menu items collection associated with the current __RadRadialMenuItem__.
            

* __Command__ (ICommand) - Gets or sets the ICommand instance associated the current __RadRadialMenuItem__.
            

* __CommandParameter__ (object) - Gets or sets command parameter that will be used by the command associated with the menu item.
            

## VisualStatesItemPresenter Properties

* __ThicknessFactor__ (double) -  Gets or sets the factor defining the thickness of the __VisualStatesItemPresenter__ as a fraction of the size of the
              __NavigationItemButton__. The value should be between 0 and 1. If the passed value lies outside this range, it is automatically set to the nearest boundary value.
              The default value of the property is *0.2d*.
            

* __ArrowThicknessFactor__ (double) -  Gets or sets the factor defining the thickness of the arrow part of the __VisualStatesItemPresenter__ as a fraction of the size of the
              __NavigationItemButton__. The value should be between 0 and 1. If the passed value lies outside this range, it is automatically set to the nearest boundary value.
              The default value of the property is *0.2d*.
            

## See Also

 * [Getting Started]({%slug radradialmenu-getting-started%})

 * [Visual Structure]({%slug radradialmenu-visual-structure%})
