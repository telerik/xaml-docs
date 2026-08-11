---
title: Use Commands with the RadContextMenu
page_title: Use Commands with the RadContextMenu
description: Check our &quot;Use Commands with the RadContextMenu&quot; documentation article for the RadContextMenu {{ site.framework_name }} control.
slug: radcontextmenu-how-to-use-commands-with-the-radcontextmenu
tags: use,commands,with,the,radcontextmenu
published: True
position: 3
---

# Use Commands with the RadContextMenu


As the __RadMenuItem__ implements the __ICommandSource__ interface, you are able to use any kind of commands that inherit from the __ICommand__ interface with it. This tutorial will show you how to use the __RadContextMenu__ with __RoutedUICommands__ combined with the __MVVM__ pattern. Two commands are going to be exposed - one for moving an item in a ListBox up and one for moving an item down. The following things will come in focus:      

* [Attaching a RadContextMenu to a ListBox control](#attaching-a-radcontextmenu-to-a-listbox-control)

* [Populating the ListBox with data via a ViewModel](#populating-the-listbox-with-data-via-a-viewmodel)

* [Selecting the right-clicked ListBoxItem](#selecting-the-right-clicked-listboxitem)

* [Preparing the RoutedUICommands](#preparing-the-routeduicommands)

* [Creating the CommandBindings](#creating-the-commandbindings)

* [Setting the CommandBindings](#setting-the-commandbindings)

## Attaching a RadContextMenu to a ListBox control

Before getting to the commands, you have to prepare the UI on which they will get executed. In this tutorial a __ListBox__ and a __RadContextMenu__ are used.
        



<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_1-xaml' />


Having the UI prepared, you have to add some data to it.

## Populating the ListBox with data via a ViewModel

As the __MVVM__ pattern should be used, you have to create a __ViewModel__ for your __UserControl__, which will control its behavior. In it you will store the data which the __View__ is using. Here is the declaration of the ViewModel class. It has a constructor, a method that initializes the items for the __ListBox__ and an __Items__ property, that stores them. Additionally create a __SelectedItem__ property that will hold the selected item of the __ListBox__.        



<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_2-cs' />

<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_2-vb' />


In the constructor of the __UserControl__ you have to create an instance of the __ViewModel__, store it in a field and pass it as a __DataContext__ of the entire __UserControl__.        



<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_3-cs' />

<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_3-vb' />


In the XAML you have to set the __SelectedItem__, the __DisplayMemberPath__ and the __ItemsSource__ properties of the __ListBox__ in order to visualize the data.        



<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_4-xaml' />


## Selecting the right-clicked ListBoxItem

Before continuing, there is one more thing to be done. When right-clicking to open the __RadContextMenu__, the clicked item should get selected, or if no item was clicked, the selection should be removed. This is done by handling the __Opened__ event of the __RadContextMenu__.        



<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_5-xaml' />





<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_6-cs' />

<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_6-vb' />


## Preparing the RoutedUICommands

The next step is to create your commands. They will be host by the __ViewModel__.        



<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_7-cs' />

<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_7-vb' />


Initialize them in the constructor of the __ViewModel__:        



<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_8-cs' />

<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_8-vb' />


Bind them in the __View__.
        



<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_9-xaml' />


You will also need methods that will get called when the command is executed. In the next section is explained how to connect the methods to the command. Here are sample methods for the two commands.



<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_10-cs' />

<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_10-vb' />


## Creating the CommandBindings

In order to use the commands in the UI you have to provide a __CommandBinding__ for each of the commands. The __CommandBinding__ binds the command to a method that is called when the command gets executed. The __CommandBidnings__ get set via the __CommandManager__. As the __CommandManager__ is called by the __View__ you have to expose a method in your __ViewModel__ that returns a collection of its __CommandBindings__.
        



<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_11-cs' />

<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_11-vb' />


## Setting the CommandBindings

In the __View__ get the __CommandBindingsCollection__ and set it through the __CommandManager__.

{% if site.site_name == 'Silverlight' %}


<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_12-cs' />

<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_12-vb' />

{% endif %}

{% if site.site_name == 'WPF' %}


<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_13-cs' />

<snippet id='radcontextmenu-how-to-use-commands-with-the-radcontextmenu-block_13-vb' />

{% endif %}

## See Also

 * [Working with the RadContextMenu]({%slug radcontextmenu-features-working-with-radcontext-menu%})

 * [Binding to Dynamic Data]({%slug radcontextmenu-populating-with-data-binding-to-dynamic-data%})

 * [Use RadContextMenu with a RadGridView]({%slug radcontextmenu-how-to-use-radcontextmenu-with-radgridview%})

 * [Select  the clicked Item of a RadTreeView]({%slug radcontextmenu-how-to-select-the-clicked-item-of-radtreeview%})

 * [Create Menu Button with RadContextMenu and ToggleButton]({%slug radcontextmenu-how-to-create-menu-button-with-radcontextmenu-and-togglebutton%})

 * [Handle Item Clicks]({%slug radcontextmenu-how-to-handle-item-clicks%})
