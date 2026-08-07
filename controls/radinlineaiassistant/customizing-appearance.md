---
title: Customizing Appearance
page_title: Customizing Appearance
description: Check our &quot;Customizing Appearance&quot; documentation article for the RadInlineAIAssistant control.
slug: radinlineaiassistant-customizing-appearance
tags: appearance, customizing appearance, radinlineaiassistant
published: True
position: 7
---

# Customizing Appearance

This article describes how to customize the appearance of `RadInlineAIAssistant`, beyond the standard `Background`, `BorderBrush`, `BorderThickness`, and `Padding` inherited from `Control`.

## Customizing the Watermark Content

The `WatermarkContent` property sets the content shown in the prompt input while it is empty, guiding the end user on what to type.

__Setting a custom watermark__
```C#
this.assistant.WatermarkContent = "Ask AI to edit the selected text...";
```

__RadInlineAIAssistant with a Customized Watermark Content__

![WPF RadInlineAIAssistant with a Customized Watermark Content](images/radinlineaiassistant-customizing-appearance-001.png)

<!-- TODO: attach screenshot showing the customized watermark content -->

## Customizing the Input Area

The `InputAreaBorderStyle` and `InputAreaPadding` properties control the border and the inner spacing of the input area that hosts the commands button and the prompt input (see [Visual Structure]({%slug radinlineaiassistant-visual-structure%})).

__Defining a custom input area border style__
```XAML
<Window.Resources>
    <Style x:Key="CustomInputAreaBorderStyle" TargetType="Border">
        <Setter Property="CornerRadius" Value="12" />
    </Style>
</Window.Resources>
```

__Customizing the input area border and padding__
```C#
this.assistant.InputAreaBorderStyle = (Style)this.Resources["CustomInputAreaBorderStyle"];
this.assistant.InputAreaPadding = new Thickness(8);
```

__RadInlineAIAssistant with a Customized Input Area__

![WPF RadInlineAIAssistant with a Customized Input Area](images/radinlineaiassistant-customizing-appearance-002.png)

## See Also
* [Handling Responses]({%slug radinlineaiassistant-handling-responses%})
* [Visual Structure]({%slug radinlineaiassistant-visual-structure%})

