---
title: Use the RadRichTextBox as Rich Content Viewer
page_title: Use the RadRichTextBox as Rich Content Viewer
description: Check our &quot;Use the RadRichTextBox as Rich Content Viewer&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-how-to-use-radrichtextbox-as-rich-content-viewer
tags: use,the,radrichtextbox,as,rich,content,viewer
published: True
position: 7
---

# Use the RadRichTextBox as Rich Content Viewer



## 

To use __RadRichTextBox__ as a rich content viewer you have to disable the user from editing its content. This is done via the __IsReadOnly__ property. You just have to set it to true.
        

__Example 1: Disable editing__

```XAML
	<telerik:RadRichTextBox x:Name="radRichTextBox" IsReadOnly="True" />
```



In addition to the __ReadOnly__ property, there are several other properties that can be used to control the response of __RadRichTextBox__ towards the user actions against it:
        

* __IsEnabled__ - setting this property to __False__ will disable the entire control. The user won't be able to enter any input in it and to scroll the contents.
          

* __IsSelectionEnabled__ - setting this property to __False__ will disable the user to perform any selection inside the __RadRichTextBox__ control.
          

* __IsFocusable__ - setting this property to __False__ will exclude the __RadRichTextBox__ control from the tab navigation.
          
