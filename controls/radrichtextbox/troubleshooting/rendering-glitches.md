---
title: Rendering Glitches
page_title: Rendering Glitches
description: A description of how you can setup RadRichTextBox to avoid glitches of the content rendering.
slug: radrichtextbox-troubleshooting-rendering-glitches
tags: troubleshooting,render,glitch,content
published: True
position: 1
---

# Rendering Glitches

RadRichTextBox supports two different rendering mechanisms. This topic explains what you can expect from them and how you can switch between the two options.

## Direct2D vs TextBlockWithPropertyCaching

The default rendering mechanism of RadRichTextBox uses the **Direct2D** technology and the [FormattedText](https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.formattedtext) class. Although it is **faster**, it can sometimes lead to unexpected behavior when rendering the contents of a document.

The legacy option is the **TextBlockWithPropertyCaching** rendering mechanism which uses draws a single [TextBlock](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.textblock) per line. The advantage here is that this mechanism prevents some rendering glitches which might occur while using the **Direct2D** technology. 

Something to note is that the Direct2D option is faster. You might experience some performance diminishments in the rendering when using the **TextBlockWithPropertyCaching**.

## Exposed Members

There are two options allowing you to control the rendering mode of RadRichTextBox. The first one is through the **DefaultTextRenderingMode** property of RadRichTextBox. This is a **static** property and affects all instances of the control. There is also an **instance** property called **TextRenderingMode** which changes the value only for the current instance.

#### **[C#] Example 1: Change the rendering mode for the current instance of RadRichTextBox**

```C#

    this.radRichTextBox.TextRenderingMode = TextBlockRenderingMode.TextBlockWithPropertyCaching;
```


## See Also

* [Data Providers Troubleshooting]({%slug radrichtextbox-features-data-providers%}#troubleshooting)
