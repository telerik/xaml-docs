---
title:  Switching Icons at Runtime
page_title:  Switching Icons at Runtime
description: Check our &quot;Switching Icons at Runtime&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-ui-switching-icons-at-runtime
tags: switching,themes,icons,at,runtime
published: True
position: 7
---

# Switching Icons at Runtime


The __IconResource__ extension is a markup extension that allows you to switch icons in your application at runtime. More information on the approach is available [here]({%slug styling-apperance-switching-icons-at-runtime%}).


## Using Available IconSets

__RadPdfViewer__ comes with three separate sets of icons that can be used in its UI. They reside in the __Telerik.Windwos.Controls.FixedDocumentViewers.dll__ and defining an __IconSources__ resource for them is demonstrated in __Example 1__.


__Example 1: Creating IconSources__

```XAML
	<telerik:IconSources x:Key="IconPaths" LightBasePath="/Telerik.Windows.Controls.FixedDocumentViewers;component/Images/" 
										   DarkBasePath="/Telerik.Windows.Controls.FixedDocumentViewers;component/Images/Dark"
                                           ModernBasePath="/Telerik.Windows.Controls.FixedDocumentViewers;component/Images/Modern/" />
```


>tip To browse all icons you can download the source code of the controls from your Telerik account. The images are located at {%if site.site_name == 'WPF' %}\Telerik\_UI\_for\_WPF\_Source\_[Version]\Controls\PdfViewer\FixedDocumentViewers\Images{%endif%}{%if site.site_name == 'Silverlight' %}\Telerik\_UI\_for\_Silverlight\_Source\_[Version]Controls\PdfViewer\FixedDocumentViewers\Images{%endif%}.


## See Also

* [IconResource]({%slug styling-apperance-switching-icons-at-runtime%})
