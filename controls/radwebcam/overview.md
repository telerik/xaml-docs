---
title: Overview
page_title: Overview
description: The RadWebCam control allows you to display the stream provided by a web camera.
slug: radwebcam-overview
tags: overview
published: True
position: 0
CTAControlName: RadWebCam
---

# {{ site.framework_name }} WebCam Overview

The `RadWebCam` control allows you to display the stream provided by a web camera. You can easily start recording or take snapshot of the stream and save it to a file.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

![{{ site.framework_name }} RadWebCam Overview](images/radwebcam-getting-started-0.png)

>tip Get started with the control with its [Getting Started]({%slug radwebcam-getting-started%}) help article that shows how to use it in a basic scenario.

## Key Features

* `Recording capabilities`&mdash;RadWebCam allows you to easily capture the media stream from the connected camera. Read more about this in the [Commands]({%slug radwebcam-features-recording-video%}) article.

* `Snapshot support`&mdash;You can take a snapshot of the current moment of the camera stream, and save it for later. Read more about this in the [Commands]({%slug radwebcam-features-snapshots%}) article.

* `Customizeable commands`&mdash;The control gives you the ability to customize the available commands. Read more about this in the [Commands]({%slug radwebcam-features-commands%}) article.

* `Image flip`&mdash;You can easily flip the video feed from the camera by setting the flip properties. Read more about this in the [Video Flip]({%slug radwebcam-features-video-flip%}) article.

* `Errors handling`&mdash;You can customize the content shown when there is no camera or the camera is unavailable using the `CameraErrorContentTemplate` property and the `CameraError` event. Read more about this in the [Errors]({%slug radwebcam-features-errors%}) article.

> Check out the [WPF Demo application](https://demos.telerik.com/wpf/) for examples with RadWebCam.

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Support and Learning Resources

* [Telerik UI for WPF WebCam Homepage](https://www.telerik.com/products/wpf/webcam.aspx)
* [Get Started with the Telerik UI for WPF WebCam]({%slug radwebcam-getting-started%})
* [Telerik UI for WPF API Reference](https://docs.telerik.com/devtools/wpf/api/)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF WebCam Forums](https://www.telerik.com/forums/wpf)
* [Telerik UI for WPF Knowledge Base](https://docs.telerik.com/devtools/wpf/knowledge-base)
{% endif %}

## See Also  
* [Events]({%slug radwebcam-events%})
* [Save Snapshot to File]({%slug radwebcam-save-snapshot-to-file%})
