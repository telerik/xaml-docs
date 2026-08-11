---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadAIPrompt control.
slug: radaiprompt-events
tags: events, radaiprompt
published: True
position: 7
---

# Events

This topic covers the specific events exposed by the RadAIPrompt control.

## PromptRequest

The PromptRequest event is raised when the user clicks on the input button. The event arguments are of the type of `PromptRequestEventArgs` and expose the following properties:

* `InputText`&mdash;Gets the text, with which the prompt was initiated. Can be the text in the input textbox or the InputText property of an already generated item in case of retry.
* `IsRetry`&mdash;Gets a boolean value indicating whether the event was initiated to retry for an already generated response.

__Using the PromptRequest event to add a new response in the AIPrompt control__
<snippet id='radaiprompt-events-using_the_promptrequest_event_to_add_a_new_response_in_the_aiprompt_control-cs' />

## See Also
* [Suggestions]({%slug radaiprompt-suggestions%})
* [RadAIPromptButon]({%slug radaiprompt-prompt-button%})
* [Commands]({%slug radaiprompt-commands%})
* [Paging]({%slug radaiprompt-paging%})