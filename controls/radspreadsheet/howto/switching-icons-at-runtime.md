---
title:  Switching Icons at Runtime
page_title:  Switching Icons at Runtime
description: Check our &quot;Switching Icons at Runtime&quot; documentation article for the RadSpreadsheet {{ site.framework_name }} control.
slug: radspreadsheet-howto-switching-icons-at-runtime
tags: switching,themes,icons,at,runtime
published: True
position: 4
---

# Switching Icons at Runtime


The __IconResource__ extension is a markup extension that allows you to switch icons in your application at runtime. More information on the approach is available [here]({%slug styling-apperance-switching-icons-at-runtime%}).


## Using Available IconSets

__RadSpreadsheet__ comes with two separate sets of icons that can be used in its UI. They reside in the __Telerik.Windwos.Controls.Spreadsheet.dll__ and defining an __IconSources__ resource for them is demonstrated in __Example 1__.


__Example 1: Creating IconSources__

```XAML
	<telerik:IconSources x:Key="SpreadsheetIconPaths" LightBasePath="/Telerik.Windows.Controls.Spreadsheet;component/Images/Light/"
                               DarkBasePath="/Telerik.Windows.Controls.Spreadsheet;component/Images/Dark/"/>
```


>tipTo browse all icons you can download the source code of the controls from your Telerik account. The images are located at {%if site.site_name == 'WPF' %}\Telerik\_UI\_for\_WPF\_Source\_[Version]\Controls\Spreadsheet\Controls\Images\Light.{%endif%} {%if site.site_name == 'Silverlight' %} \Telerik\_UI\_for\_Silverlight\_Source\_[Version]\Controls\Spreadsheet\Controls\Images\Light.{%endif%}


## See Also

* [IconResource]({%slug styling-apperance-switching-icons-at-runtime%})