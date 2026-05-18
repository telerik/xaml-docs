---
title: Breaking Changes
page_title: Breaking Changes
description: This article lists the breaking changes introduced in the RadChat for WPF component through the releases.
slug: chat-breaking-changes
tags: breaking, changes, backward,compatibility
published: True
position: 7
---

# Breaking Changes

This article lists and describes the breaking changes introduced in the RadChat component. For a full list of changes, see the [Release History](https://www.telerik.com/support/whats-new/wpf/release-history) pages of the Telerik UI for WPF product.

## 2026 Q2 (2026.2.519)

With this release a visual revamp of the chat component and part of its features was introduced. 

* The input box where the messages appear is now using a more complex visual element which contains extra features, like speech-to-text-button and a drop-down button with multiple options (attachments and custom options). This means that any code that was customizing the previously used textbox element should be adapted to the new input box visual (`RadPromptInput`)

* The `ToolBarCommands` and `ToolBarCommandTemplateSelector` property of `RadChat` are no longer available. Instead, use the `MoreButtonActions` collection of the `RadPromptInput`.

	```C#
	private void RadChat_Loaded(object sender, RoutedEventArgs e)
	{
		var chat = (RadChat)sender;
		var promptInput = chat.FindChildByType<RadPromptInput>();
		promptInput.MoreButtonActions.Add(new PromptInputButtonAction() { Text = "Custom option", Icon = myIcon, Command = myCommand });
	}
	```