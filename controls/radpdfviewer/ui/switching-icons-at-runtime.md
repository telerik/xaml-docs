---
title:  Switching Icons at Runtime
page_title:  Switching Icons at Runtime
description:  Switching Icons at Runtime
slug: radpdfviewer-ui-switching-icons-at-runtime
tags: switching,themes,icons,at,runtime
published: True
position: 7
---

# Switching Icons at Runtime


The __IconResource__ extension is a markup extension that allows you to switch icons in your application at runtime. More information on the approach is available [here]({%slug styling-apperance-switching-icons-at-runtime%}).


## Using Available IconSets

__RadPdfViewer__ comes with two separate sets of icons that can be used in its UI. They reside in the __Telerik.Windwos.Controls.FixedDocumentViewers.dll__ and defining an __IconSources__ resource for them is demonstrated in __Example 1__.


#### __[XAML] Example 1: Creating IconSources__

{{region radpdfviewer-ui-switching-icons-at-runtime_0}}
	<telerik:IconSources x:Key="PdfViewerIconPaths" LightBasePath="/Telerik.Windows.Controls.FixedDocumentViewers;component/Images/Modern/"
                               DarkBasePath="/Telerik.Windows.Controls.FixedDocumentViewers;component/Images/" />
{{endregion}}


>tipTo browse all icons you can download the source code of the controls from your Telerik account. The images are located at \Telerik_UI_for_WPF_Source_[Version]\Documents\Fixed\FixedDocumentViewers\Images.


# See Also

* [IconResource]({%slug styling-apperance-switching-icons-at-runtime%})