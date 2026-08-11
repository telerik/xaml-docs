---
title: Customizing Commands
page_title: Customizing Commands
description: Check our &quot;Customizing Commands&quot; documentation article for the RadDataForm {{ site.framework_name }} control.
slug: raddataform-customize-commands
tags: customizing,commands
published: True
position: 3
---

# Customizing Commands

This article will demonstrate how to customize RadDataForm's commands in an MVVM-friendly way as well as how to execute them manually. 

* [The DataFormCommandProvider](#the-dataformcommandprovider)
* [Designing a Custom DataFormCommandProvider](#designing-a-custom-dataformcommandprovider)
* [Setting the Custom DataFormCommandProvider](#setting-the-custom-dataformcommandprovider)
* [Executing Commands Manually](#executing-commands-manually)

## The DataFormCommandProvider

The public __DataFormCommandProvider__ class exposes the "execute" and "can-execute" logic of all commands utilized by RadDataForm. RadDataForm processes these commands according to its current provider.

### Execute Logic Methods

The methods listed below identify the logic that is executed when a certain command's invocation takes place.

__Example 1: The IExecuteLogicMethods__

<snippet id='raddataform-features-customize-commands-example_1_the_iexecutelogicmethods-cs' />

<snippet id='raddataform-features-customize-commands-example_1_the_iexecutelogicmethods-vb' />


### Can-Execute Logic Methods

With the help of those methods you can identify whether a certain command can be executed or not.

__Example 2: The ICanExecuteLogicMethods__

<snippet id='raddataform-features-customize-commands-example_2_the_icanexecutelogicmethods-cs' />

<snippet id='raddataform-features-customize-commands-example_2_the_icanexecutelogicmethods-vb' />


A runnable demo that utilizes the code from this article can be found on {% if site.site_name == 'Silverlight' %}[this online demo](https://demos.telerik.com/silverlight/#DataForm/CustomCommandsProvider){% endif %}{% if site.site_name == 'WPF' %}[the DataForm's CustomCommandsProvider demo](https://demos.telerik.com/wpf/){% endif %}.

## Designing a Custom DataFormCommandProvider

The first step is to create your own class that inherits from **DataFormCommandProvider**:

__Example 3: Defining a Custom CommandProvider__

<snippet id='raddataform-features-customize-commands-example_3_defining_a_custom_commandprovider-cs' />

<snippet id='raddataform-features-customize-commands-example_3_defining_a_custom_commandprovider-vb' />


You need to override the methods of the commands that will be customized. In the following example we will customize: **MoveCurrentToNext**, **MoveCurrentToPrevious**, **BeginEdit** and **CancelEdit**.

### MoveCurrentToNext and MoveCurrentToPrevious

We aim at changing their execution logic, in order to start editing the item, as soon as it was set as a current one and bypass the logic in the same place. Here are the overridden methods:

__Example 4: Customizing MoveCurrentToNext and MoveCurrentToPrevious__

<snippet id='raddataform-features-customize-commands-example_4_customizing_movecurrenttonext_and_movecurrenttoprevious-cs' />

<snippet id='raddataform-features-customize-commands-example_4_customizing_movecurrenttonext_and_movecurrenttoprevious-vb' />


### CommitEdit and CancelEdit

A common requirement for data form is to add __confirmation message boxes when CRUD operations are executed__. Here we will do a similar thing with the CommitEdit/CancelEdit commands.

__Example 5: Customizing CommitEdit and CancelEdit__

<snippet id='raddataform-features-customize-commands-example_5_customizing_commitedit_and_canceledit-cs' />

<snippet id='raddataform-features-customize-commands-example_5_customizing_commitedit_and_canceledit-vb' />


## Setting the Custom DataFormCommandProvider

The last thing to be done is to set the **CommandProvider** property of the RadDataForm to the newly-created **CustomKeyboardCommandProvider** class:

__Example 6: Set the CommandProvider Property__

<snippet id='raddataform-features-customize-commands-example_6_set_the_commandprovider_property-xaml' />


__Example 6: Set the CommandProvider Property__

<snippet id='raddataform-features-customize-commands-example_6_set_the_commandprovider_property-cs' />

<snippet id='raddataform-features-customize-commands-example_6_set_the_commandprovider_property-vb' />


## Executing Commands Manually

Using the **RadDataFormCommands** class, you can set a sequence of commands to be performed one after another. So, for example, you may easily handle the click event of a button, move to the next item and put it in edit mode. However, when invoking the commands in such a manner a second parameter should be added, pointing out the target **UI Element** as shown in **Exapmle 7**.

__Example 7: Executing a sequence of commands__

<snippet id='raddataform-features-customize-commands-example_7_executing_a_sequence_of_commands-cs' />

<snippet id='raddataform-features-customize-commands-example_7_executing_a_sequence_of_commands-vb' />


## See Also

* [Getting Started]({%slug raddataform-getting-started%})
* [Developer Focused Examples]({%slug raddataform-sdk-examples%})
* [Add, Edit and Delete Operations]({%slug raddataform-add-edit-delete-buttons%})
