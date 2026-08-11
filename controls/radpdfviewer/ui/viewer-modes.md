---
title: Viewer Modes
page_title: Viewer Modes
description: Check our &quot;Viewer Modes&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-viewer-modes
tags: viewer,modes
published: True
position: 3
---

# Viewer Modes



There are three __FixedDocumentViewerModes__ which specify the behavior of __RadPdfViewer__ when you left-click in the document and move the mouse around (without releasing the left button of the mouse):
      

* None – the control does nothing;

* Pan – the document is scrolled in the respective direction;

* TextSelection – selection is initiated, which stops when you release the button of the mouse.

## Specify the Viewer Mode Using UI

The viewer mode can be changed using the "default" UI that RadPdfViewer uses (as shown in the picture).

![Rad Pdf Viewer Viewer Modes 02](images/RadPdfViewer_ViewerModes_02.png)

The code of the buttons can be declared as follows:

{% if site.site_name == 'Silverlight' %}


<snippet id='radpdfviewer-ui-viewer-modes-block_1-xaml' />
{% endif %}
{% if site.site_name == 'WPF' %}


<snippet id='radpdfviewer-ui-viewer-modes-block_2-xaml' />
{% endif %}

Note that the RadToolBar control is bound to the CommandDescriptorss property of the PDF viewer.

The declarations of the namespaces used in the snippet above are:



<snippet id='radpdfviewer-ui-viewer-modes-block_3-xaml' />



## Specify Viewer Mode in Code

The mode of the viewer is set using the Mode property, e.g.:



<snippet id='radpdfviewer-ui-viewer-modes-block_4-cs' />



As the Mode property is a DependencyProperty, you could also bound it to different properties, depending on the logic of your application.
