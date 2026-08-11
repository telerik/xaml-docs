---
title: Speech-to-Text Button
page_title: SpeechToTextButton for WPF
description: Check our &quot;Speech Button&quot; documentation article for the RadButtons {{ site.framework_name }} control.
slug: radbuttons-features-speech-to-text-button
tags: toggle,button,switch
published: True
position: 4
---

# Speech-to-Text Button

The `RadSpeechToTextButton` control allows you to capture spoken input and convert it to text. 

The component has a built-in speech recognizer based on Web Speech API utilized via [WebView2](https://learn.microsoft.com/en-us/microsoft-edge/webview2/). The button automatically detects microphone input when it is in listening state and converts the audio to text. The default recognizer allows you to also set the language for speech recognition, ensuring accurate transcription of spoken words.

![Telerik UI for WPF RadSpeechToTextButton speech-to-text feature showing recognized voice input](images/radbuttons-features-speech-to-text-button-0.png)

## Basic Usage

To start using the `RadSpeechToTextButton` control, just define it in the view. To get the processed text, use the `SpeechRecognized` event.

The default speech recognizer of the button requires you to install the [Microsoft.Web.WebView2](https://www.nuget.org/packages/microsoft.web.webview2) NuGet package (minimum version: 1.0.3650.58). Also, when the button gets loaded, the WebView2 will prompt you to allow listening to microphone input.

__Setting up a RadSpeechToTextButton__

<snippet id='radbuttons-features-speech-to-text-button-setting_up_a_radspeechtotextbutton-xaml' />

__Using the SpeechRecognized event__

<snippet id='radbuttons-features-speech-to-text-button-using_the_speechrecognized_event-cs' />

## Processing Recognized Text

Each time when the speech recognizer manages to process audio input, it raises the `SpeechRecognized` event which contains information about the converted text. 

The `SpeechRecognizerSpeechRecognizedEventArgs` provides the recognized text and a confidence score. The score is a value between 0 and 1, indicating how confident the speech-to-text transcription is. A value of -1 indicates no score could be provided.
 
__Defining a SpeechRecognized event handler__

<snippet id='radbuttons-features-speech-to-text-button-defining_a_speechrecognized_event_handler-cs' />

> The default speech recognizer uses the Web Speech API via the WebView2 engine, which does not provide usable confidence score.

## Continuous vs. One-Time Recognition 

By default when the RadSpeechToTextButton is pressed this will start a continuous listening action which will process speech until the button is pressed again to stop listening. This behavior can be changed by setting the `IsContinuousRecognition` property to `false`. In this case, the recognizer will stop automatically after a single utterance or pause.

__Disabling continuous speech recognition__

<snippet id='radbuttons-features-speech-to-text-button-disabling_continuous_speech_recognition-xaml' />

## Recognizer States

The speech recognizer can be in few different states - read, listening, stop listening, etc. The current state can be acquired using the `State` property of `RadSpeechToTextButton`.

The recognizer can be in the following states:

* `NotInitialized`
* `Initializing`
* `Ready`
* `StartingListening`
* `Listening`
* `StoppingListening`
* `Faulted`
* `Resetting`
* `Disposing`
* `Disposed`

__Getting the current status of the recognizer__

<snippet id='radbuttons-features-speech-to-text-button-getting_the_current_status_of_the_recognizer-cs' />

The states lifecycle is shown in the [Architecture and States](#architecture-and-states) section of this article.


## Handling Speech Recognition Errors

To handle errors related to the speech recognition service, use the `ErrorOccurred` event. The `SpeechRecognizerErrorOccurredEventArgs` provide information about the error message via the `Message` and `Exception` properties.

__Defining a ErrorOccurred event handler__

<snippet id='radbuttons-features-speech-to-text-button-defining_a_erroroccurred_event_handler-cs' />

## Language Support

The service used by the default WebView2 speech recognizer supports multiple languages. The default language comes from the current culture of the system, but this can be changed via the `LanguageTag` property. The property works with the IETF language tags (e.g., "en-US", "de-DE", "fr-FR", etc.).

__Setting the language of the default speech recognizer to German__

<snippet id='radbuttons-features-speech-to-text-button-setting_the_language_of_the_default_speech_recognizer_to_german-xaml' />

## Customizing the ToolTip

`RadSpeechToTextButton` displays a tooltip (callout) on mouse over, which shows the current state of the button. By default the tooltip is displayed for the `Ready` and `Listening` [states](#recognizer-states).

![Picture showing RadSpeechToTextButton with its default tooltips for Ready and Listening states](images/radbuttons-features-speech-to-text-button-1.png)

The tooltip content and behavior can be customized using the `CalloutOpening` event.

__Replacing the tooltip content of the button when in Ready and Listening states__

<snippet id='radbuttons-features-speech-to-text-button-replacing_the_tooltip_content_of_the_button_when_in_ready_and_listening_states-cs' />

The event is invoked only for the [states](#recognizer-states) added in the `ToolTipStates` collection of `RadSpeechToTextButton`. By default the collection contains only the `Ready` and `Listening` states. If the recognizer is in another state the tooltip won't be displayed. 

To __show the tooltip for other states__ as well, add these in the `ToolTipStates` collection, and then use the `CalloutOpening` event handler to add content for the extra states.

__Adding extra states and adjust their content__

<snippet id='radbuttons-features-speech-to-text-button-adding_extra_states_and_adjust_their_content-cs' />

In the example above, only the content for the `StartingListening` and `Faulted` states is set in the event handler, because the internal logic of the control manages the only content for the `Ready` and `Listening` states by default.

To __prevent the tooltip from opening__, set the `e.Cancel` property of the event arguments to `true`.

__Using the CalloutOpening event to cancel the tooltip opening__

<snippet id='radbuttons-features-speech-to-text-button-using_the_calloutopening_event_to_cancel_the_tooltip_opening-cs' />

The tooltip visual is implemented with the [RadCallout]({%slug radcallout-overview%}) control. The `SpeechToTextTooltipOpeningEventArgs` provide [settings]({%slug radcallout-features-calloutpopupsettings%}) for customizing the callout via the `CalloutPopupSettings` property of the event args. 

__Using the CalloutOpening event to change the show/close animation__

<snippet id='radbuttons-features-speech-to-text-button-using_the_calloutopening_event_to_change_the_show_close_animation-cs' />

## Customizing the Button Content

The content of the button can be changed via the the `ContentTemplateSelector` property. This can be used to replace  the default icons displayed for `Ready`, `Listening` and `Faulted` states and to include extra content for other states like `StartingListening`, `StoppingListening`.

__Defining custom content template selector__

<snippet id='radbuttons-features-speech-to-text-button-defining_custom_content_template_selector-cs' />

__Defining custom content__

<snippet id='radbuttons-features-speech-to-text-button-defining_custom_content-xaml' />

![A picture showing customized speech to text button content](images/radbuttons-features-speech-to-text-button-2.png)

## Implementing Custom Speech Recognizer

The `RadSpeechToTextButton` allows you to implement custom speech recognizer in order to integrate a speech-to-text service or a library of your choice.

A custom recognizer is created by implementing the `IRadSpeechRecognizer` interface. The custom implementation can be enabled with the `SpeechRecognizerCreator` property of the control.

__Implementing custom speech recognizer__

<snippet id='radbuttons-features-speech-to-text-button-implementing_custom_speech_recognizer-cs' />

__Defining example view with RadSpeechToTextButton__

<snippet id='radbuttons-features-speech-to-text-button-defining_example_view_with_radspeechtotextbutton-xaml' />

__Assigning the custom speech recognizer and handling the result__

<snippet id='radbuttons-features-speech-to-text-button-assigning_the_custom_speech_recognizer_and_handling_the_result-cs' />

![A gif animation showing the behavior of the custom speech recognizer](images/radbuttons-features-speech-to-text-button-3.gif)

## Architecture and States

The image below explains how the control works and how the [states](#recognizer-states) are managed: 

![A picture describing the states and the behavior of RadSpeechToTextButton](images/radbuttons-features-speech-to-text-button-4.png)
