---
title: Commands Support
page_title: Commands Support
description: Commands Support
slug: radribbonview-features-commands-support
tags: Commands Support
published: True
position: 0
---

# Commands Support

The RadRibbonView control and its components expose several commands that could be used for customizing their actions.

## RadRibbonView Commands

RadRibbonView expose a single command that is executed when its Help button is clicked. The command is called HelpCommand and it is related with two additional properties – HelpCommandParameter and HelpCommandTarget.

## RadRibbonBackstageItem Commands

RadRibbonBackstageItem expose a single command that is executed when the item is clicked. The command property is called Command and it is related with two additional properties – CommandParameter and CommandTarget.

>The command will be executed only if the backstage item’s IsSelectable property is set to False.

## RadRibbonGroup Commands

RadRibbonGroup exposes a single command that is executed when the dialog launcher button of the group is clicked. The command is called DialogLauncherCommand and it its related with two additional properties – DialogLauncherCommandParameter and DialogLauncherCommandTarget

> The RadRibbonButtons derive from controls from the RadButtons suit and each ribbon button inherits a Command property that accepts a command that is executed when the button is clicked. You can read more about the command support in RadButtons in the [Commands](%slug radbuttons-features-commands%) help article.