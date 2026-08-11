---
title: Implement custom commands for MapCommandBar UI
page_title: Implement custom commands for MapCommandBar UI
description: Check our &quot;Implement custom commands for MapCommandBar UI&quot; documentation article for the RadMap control.
slug: radmap-howto-customize-commands
tags: implement,custom,commands,for,mapcommandbar,ui
published: True
position: 0
---

# Implement custom commands for MapCommandBar UI

The `MapCommandBar` element that by default displays the predefined view modes for every map provider, can be customized with additional commands.

## Customization of the commands in the MapCommandBar

Every custom command should be described by a `CommandDescription` instance that you need to add to the respective `Commands` collection of the used map provider (if your custom command is RoutedCommand / RoutedUICommand, you can add the associated `CommandBinding` to the `CommandBindingCollection` collection).

The CommandDescription class exposes the following properties:

* `Command`&mdash;Gets or sets the command that will be executed in response to UI action.
* `CommandParameter`&mdash;Gets or sets the command parameter associated with the respective command.
* `DataTemplate`&mdash;Gets or sets the data template that will be used to represent the command in CommandBar UI.
* `ImageUri`&mdash;Gets or sets the uniform resource identifier (URI) of the image that is used in the map source button data template.
* `IsAllowed`&mdash;Gets or sets a value indicating whether this command is allowed.
* `IsSelected`&mdash;Gets or sets a value indicating whether this command is selected initially.

Here is a sample code snippet that demonstrates custom `RoutedUICommand` usage:


<snippet id='radmap-how-to-howto-customize-commands-block_1-xaml' />


<snippet id='radmap-how-to-howto-customize-commands-block_2-cs' />
<snippet id='radmap-how-to-howto-customize-commands-block_2-vb' />

Here is a sample code snippet that demonstrates custom `DelegateCommand` usage:


<snippet id='radmap-how-to-howto-customize-commands-block_3-xaml' />


<snippet id='radmap-how-to-howto-customize-commands-block_4-cs' />
<snippet id='radmap-how-to-howto-customize-commands-block_4-vb' />