---
title: Custom Content
page_title: Custom Content
description: This article will show you how to customize the content of RadCircularProgressBar control.
slug: radcircularprogressbar-custom-content
tags: custom content, radcircularprogressbar
published: True
position: 6
---

# Custom Content

`RadCircularProgressBar` supports setting a complex structure of elements to the `ContentTemplate` property to represent the value set for the `Content` property. The Content property is of type `object` and can hold a value of any type.

__Setting the Content and ContentTemplate properties__
<snippet id='radcircularprogressbar-custom-content-setting_the_content_and_contenttemplate_properties-xaml' />


![RadCircularProgressBar with custom content](images/radcircularprogressbar-custom-content-0.png)

__Custom content with indeterminate state__
<snippet id='radcircularprogressbar-custom-content-custom_content_with_indeterminate_state-xaml' />


![RadCircularProgressBar with custom content and indeterminate state](images/radcircularprogressbar-custom-content-1.gif)

## ContentStringFormat

RadCircularProgressBar allows you to set a string format to the `ContentStringFormat` property. This format will be applied to the Content property.

__Custom ContentStringFormat__
<snippet id='radcircularprogressbar-custom-content-custom_contentstringformat-xaml' />


![RadCircularProgressBar with applied ContentStringFormat](images/radcircularprogressbar-custom-content-2.png)

>tip Check this [article](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings) for more information on the supported formats.

## See Also
* [Indeterminate State Animation Customization]({%slug radcircularprogressbar-animation-customization%})