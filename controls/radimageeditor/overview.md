---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadImageEditor {{ site.framework_name }} control.
slug: radimageeditor-overview
tags: overview
published: True
position: 0
CTAControlName: RadImageEditor
---

# Overview

__RadImageEditor__ is a control that can be used to preview and edit images in different file formats. It is meant to be used as a stand-alone control, but has also been integrated in __RadRichTextBox__.  

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}       

![WPF RadImageEditor Overview](images/radimageeditor-overview-1.png)

## Key Features

* __Rich image editing features set__: The control comes with a bunch of tools that applies different effects to the loaded image. For example, __crop, canvas resize, hue shift, saturation, contrast, rotations, adding text, drawing__, etc. Read more about this in the [Commands and Tools]({%slug radimageeditor-features-commands-and-tools%}) article.

* __Support for various image formats__: The control allows you to import and export different image formats. The following formats could be imported - __JPEG, PNG{% if site.site_name == 'WPF' %}, TIFF, GIF, ICO{%endif%}__. The following formats can be exported - __PNG, BMP{% if site.site_name == 'WPF' %}, JPEG, TIFF, GIF{%endif%}__. Read more about this in the [Import/Export]({%slug radimageeditor-features-import-export%}) article.

* __Custom tools__: __RadImageEditor__ is highly extensible, so you can implement and utilize additional image editing tools, as well as import and export in other formats. Read more about this in the [How to]({%slug radimageeditor-howto-custom-tool%}) section of the documentation.

* __History__: The control keeps an undo/redo stack with the changes applied to the image. This means that you can reverse and re-apply actions. Read more about this in the [History]({%slug radimageeditor-features-history%}) article.

* __RadImageEditorUI__: An additional control that wraps the RadImageEditor and enriches it with a UI that allows you to easily edit the image without manually executing the different tools. Read more about this in the [RadImageEditorUI]({%slug radimageeditor-features-radimageeditorui%}) article.

>tip Get started with the control with its [Getting Started]({%slug radimageeditor-getting-started%}) help article that shows how to use it in a basic scenario.

> Check out the online demo at {% if site.site_name == 'Silverlight' %}[demos.telerik.com](https://demos.telerik.com/silverlight/#ImageEditor/FirstLook){% else %}[demos.telerik.com](https://demos.telerik.com/wpf/){% endif %}

## See Also   
 * [Zooming]({%slug radimageeditor-features-zooming%})
 * [Panning]({%slug radimageeditor-tools-panning%})
 * [Developer Focused Examples]({%slug radimageeditor-sdk-examples%})
