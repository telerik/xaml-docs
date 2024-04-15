---
title: AIPrompt Button
page_title: AIPrompt Button
description: Check our &quot;AIPrompt Button&quot; documentation article for the RadAIPrompt control.
slug: radaiprompt-prompt-button
tags: prompt button, button, radaiprompt
published: True
position: 5
---

# AIPrompt Button

The AIPrompt component can also be displayed as a button that will show a `RadAIPrompt` when interacted with it. To display the component as a button, create a new `RadAIPromptButton` instance.

The RadAIPromptButton provides the following properties:

* `AIPrompt`&mdash;This property allows you to set an RadAIPrompt instance that will be displayed when the RadAIPromptButton is open.
* `PopupWidth`&mdash;This property provides the ability to specify the width of the popup of RadAIPromptButton.
* `PopupHeight`&mdash;This property provides the ability to specify the height of the popup of RadAIPromptButton.
* `IsPopupOpen`&mdash;This property provides information about the state of the popup of RadAIPromptButton.

#### __[XAML] Creating a RadAIPromptButton__
{{region radaiprompt-prompt-button-0}}
    <telerik:RadAIPromptButton x:Name="aiPromptButton">
    	<telerik:RadAIPromptButton.AIPrompt>
    		<telerik:RadAIPrompt x:Name="aiPrompt" 
                                 Commands="{Binding MyCommands}"
                                 Suggestions="{Binding MySuggestions}">
    			<telerik:RadAIPromptInputItem />
    			<telerik:RadAIPromptOutputItem />
    			<telerik:RadAIPromptCommandsItem />
    		</telerik:RadAIPrompt>
    	</telerik:RadAIPromptButton.AIPrompt>
    </telerik:RadAIPromptButton>
{{endregion}}

__RadAIPromptButton__

![WPF RadAIPromptButton](images/radaiprompt-prompt-button-0.png)

## See Also
* [Suggestions]({%slug radaiprompt-suggestions%})
* [Commands]({%slug radaiprompt-commands%})
* [Paging]({%slug radaiprompt-paging%})
* [Events]({%slug radaiprompt-events%})