---
title: Keyboard Support
page_title: Keyboard Support
description: Check our &quot;Keyboard Support&quot; documentation article for the RadDataForm {{ site.framework_name }} control.
slug: raddataform-features-keyboard-support
tags: keyboard,support
published: True
position: 4
---

# Keyboard Support

__RadDataForm__ allows you to navigate through the items without using the mouse. The keyboard can entirely replace the mouse by allowing you to perform navigation and editing. This article will walk you through the following sections.

* [Keys List](#keys-list)
* [Custom Keyboard Command Provider](#custom-keyboard-command-provider)
* [Disable the Built-in Navigation](#disable-the-built-in-navigation)
* [Control the Processing of Handled Events](#control-the-processing-of-handled-events)

## Keys List 

Below is the list of the keys that are supported:

1. __Left and Right arrow keys__: Navigate through the items.

1. __Ctrl + Home / Ctrl + Left arrow__: Move the current item to the first position.

1. __Ctrl + End / Ctrl + Right arrow__: Move the current item to the last position.

1. __F2__: Start edit mode.

1. __Insert__: Add new item.

1. __Enter__: Commit the edit operation.

1. __Escape__: Cancel the edit operation.

1. __Delete__: Delete the current item.

## Custom Keyboard Command Provider

RadDataForm provides an easy MVVM-friendly approach for customization of its default commands' logic. You can find more information in the [Customizing Commands help article]({%slug raddataform-customize-commands%}). However, if you want to extend the way RadDataForm handles a particular key, you could create your own custom command provider and predefine the behaviour for that key.

The approach for accomplishing this is to create a separate class, inherit the DataFormCommandProvider and override the ProvideCommandsForKey(KeyEventArgs args) method. In this way, only the undesired behavior can be adjusted according to your requirements.

The class responsible for customizing the keyboard navigation should to be similar to Example 1:

__Example 1: Creating a custom KeyboardCommandProvider__

<snippet id='raddataform-features-keyboard-support-example_1_creating_a_custom_keyboardcommandprovider-cs' />

<snippet id='raddataform-features-keyboard-support-example_1_creating_a_custom_keyboardcommandprovider-vb' />


Following up the code-snippet above, a press of Left/ Right keys will result in moving to the Next/ Previous item and editing it. However, do not forget to remove the predefined commands for that particular key by calling the Clear() method.

The last thing to be done is to set the CommandProvider property of the RadDataForm to be the newly-created CustomKeyboardCommandProvider class:

__Example 2: Set the CommandProvider property__

<snippet id='raddataform-features-keyboard-support-example_2_set_the_commandprovider_property-xaml' />



__Example 2: Set the CommandProvider property__

<snippet id='raddataform-features-keyboard-support-example_2_set_the_commandprovider_property-cs' />

<snippet id='raddataform-features-keyboard-support-example_2_set_the_commandprovider_property-vb' />


## Disable the Built-in Navigation

As of Q1 2015, __DataFormCommandProvider__ exposed the __EnableBuiltInNavigation__ property. Its default value is __True__. In order to __disable the built-in navigation__, you can set its value to __False__.

__Example 3: Setting the EnableBuiltInNavigation property to False__ 

<snippet id='raddataform-features-keyboard-support-example_3_setting_the_enablebuiltinnavigation_property_to_false-cs' />

<snippet id='raddataform-features-keyboard-support-example_3_setting_the_enablebuiltinnavigation_property_to_false-vb' />


## Control the Processing of Handled Events

As of Q1 2015, the new boolean property __ShouldProcessHandledEvents__ of __DataFormCommandProvider__ is exposed. Its default value is __True__. If you want to manually process handled events, you can set its value to __False__.

__Example 4: Setting the ShouldProcessHandledEvents to False__

<snippet id='raddataform-features-keyboard-support-example_4_setting_the_shouldprocesshandledevents_to_false-cs' />

<snippet id='raddataform-features-keyboard-support-example_4_setting_the_shouldprocesshandledevents_to_false-vb' />


## See Also

[Customizing Commands]({%slug raddataform-customize-commands%})
