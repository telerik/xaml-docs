---
title: Commands Support
page_title: Commands Support
description: Commands Support
slug: radribbonview-features-commands-support
tags: commands,support
published: True
position: 0
---

# Commands Support

The __RadRibbonView__ control and its components expose several command properties that can be used for customizing their actions.

### RadRibbonView Command Properties

* __HelpCommand__: The property accepts an [ICommand](https://msdn.microsoft.com/en-us/library/system.windows.input.icommand%28v=vs.110%29.aspx) and executes it when the ribbon view’s Help button is clicked. The RadRibbonView control exposes two additional properties that are related to the HelpCommand - __HelpCommandParameter__ and __HelpCommandTarget__.

### RadRibbonBackstageItem Command Properties

* __Command__: The property accepts an ICommand and executes it when the item is clicked. The RadRibbonBackstageItem control exposes two additional properties that are related to the command - __CommandParameter__ and __CommandTarget__.

	>The command will be executed only if the backstage item’s IsSelectable property is set to False.

### RadRibbonGroup Command Properties

* __DialogLauncherCommand__: The property accepts an ICommand and executes it when dialog launcher button of the group is clicked. The RadRibbonGroup control expose two additional properties that are related to the command - __DialogLauncherCommandParameter__ and __DialogLauncherCommandTarget__.

>tip The __RadRibbonButtons__ derive from controls from the RadButtons suite and each ribbon button inherits a Command property that accepts a command that is executed when the button is clicked. You can read more about the command support in RadButtons in the [Commands]({%slug radbuttons-features-commands%}) help article.

## RibbonCommands

RadRibbonView provides a __RibbonCommands__ class that contains several __RoutedUICommand__ properties which are used by the ribbon view components. You can read more about the routed commands in the [RoutedUICommand](https://msdn.microsoft.com/en-us/library/system.windows.input.routeduicommand(v=vs.110).aspx) MSDN article.

You can find the following properties in the RibbonCommands class:
* __RibbonCommands.CloseBackstage__ - executes when the application button is clicked in order to close the ribbon's backstage
* __RibbonCommands.MinimizeRibbonCommand__ - executes when the minimize button is clicked in order to minimize the ribbon
* __RibbonCommands.ToggleQATPositionCommand__ - executes when the position of the ribbon's QuickAccessToolBar is toggled by clicking on its toggle button

# See Also
* [Functional Structure]({%slug radribbonview-functional-structure%})
* [Visual Structure]({%slug radribbonview-visual-structure%})
* [RibbonCommands class](http://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_controls_ribboncommands.htm)
* [Ribbon Backstage]({%slug radribbonview-ribbon-backstage%})
* [Use Commands with RadRibbonView Buttons]({%slug radribbonview-howto-use-commands-with-radribbonview-buttons%})