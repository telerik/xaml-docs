---
title: Breaking Changes
page_title: Breaking Changes
description: Review RadChat for WPF breaking changes and update input box customizations, speech-to-text dependencies, and toolbar commands.
components: ["chat"]
slug: chat-breaking-changes
tags: breaking, changes, backward,compatibility
published: True
position: 4
---

# Breaking Changes

This article describes breaking changes in the `RadChat` control and the updates required for existing applications. For a full list of changes, see the [Telerik UI for WPF release history](https://www.telerik.com/support/whats-new/wpf/release-history).

## 2026 Q2 (2026.2.519)

The 2026 Q2 release redesigns the `RadChat` input box and changes how you add custom actions. Review the following changes when you upgrade from an earlier release:

* The input box where you type messages now uses `RadPromptInput` instead of the previous text box element. It includes a speech-to-text button and a dropdown button for attachments and custom actions. Update code or templates that customize the previous text box to target `RadPromptInput`. For the available settings, see [configuring the RadChat input box]({%slug chat-input-box-settings%}).

* The new input box includes a `RadSpeechToTextButton` by default. Install the [`Microsoft.Web.WebView2` NuGet package](https://www.nuget.org/packages/Microsoft.Web.WebView2) explicitly in your application project for its default speech recognizer. Without this package, the recognizer throws an exception when the button initializes.

	See the [speech-to-text button requirements]({%slug radbuttons-features-speech-to-text-button%}#basic-usage) for the minimum package version. To hide the button, set `RadChat.IsSpeechToTextButtonVisible` to `False`, as described in the [RadChat speech-to-text settings]({%slug chat-input-box-settings%}#speech-to-text-button).

* The `ToolBarCommands` and `ToolBarCommandTemplateSelector` properties of `RadChat` are no longer available. Add custom actions to the `MoreButtonActions` collection of `RadPromptInput` instead. Set `RadChat.IsMoreButtonVisible` to `True` to show the more-options button, which is hidden by default.

	Connect the following code-behind fragment to the `Loaded` event of your `RadChat` instance. Replace `myIcon` and `myCommand` with your application's icon and command. The example adds a **Custom option** item to the more-options menu:

	```C#
	private void RadChat_Loaded(object sender, RoutedEventArgs e)
	{
		var chat = (RadChat)sender;
		var promptInput = chat.FindChildByType<RadPromptInput>();
		promptInput.MoreButtonActions.Add(new PromptInputButtonAction() { Text = "Custom option", Icon = myIcon, Command = myCommand });
	}
	```

## See Also

* [Setting up a RadChat application]({%slug chat-getting-started%})
* [Configuring the more-options button]({%slug chat-input-box-settings%}#more-options-button)
* [Attaching files in RadChat]({%slug chat-attachments%})
