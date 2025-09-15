---
title: Improve Load Performance
page_title: Improve Load Performance
description: Check our &quot;Improve Load Performance&quot; documentation article for the RadFileDialogs {{ site.framework_name }} control.
slug: radfiledialogs-how-to-improve-load-performance
tags: performance, load
published: True
position: 0
---

# Improve Load Performance

In order to achieve optimal load performance with RadFileDialogs controls, you should be familiar with the following performance tips:

* Whenever possible, you should use a single instance of a dialog for multiple openings. This will reduce the opening time for every open after the initial one.

* Using the [No XAML]({%slug xaml-vs-noxaml%}#noxaml-assemblies) binaries along with [implicit styles]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-implicit-styles) as a styling mechanism will improve the loading time of the dialogs compared to using the [StyleManager]({%slug styling-apperance-implicit-styles-overview%}#setting-a-theme-using-stylemanager).

* Setting the [ExpandToCurrentDirectory]({%slug radfiledialogs-features-common%}#disable-the-automatic-expanding-to-current-directory) to __False__ will improve the loading time.

* Setting an [InitialDirectory]({%slug radfiledialogs-features-common%}#setting-initial-directory) that has fewer directories and files will reduce the loading time.

* When developing an application that contains RadFileDialogs, run it in __Release__ mode, instead of in __Debug__ mode. This way you will avoid the caught exceptions while traversing the file system, which will improve performance.

* Setting the __LoadDrivesInBackground__ property to __true__ will force the file dialogs to load all drives in a background thread. This will improve the loading time of the controls.

* Disabling the animations in the dialogs also leads to better performance. This can be done via the attached **AnimationManager.IsAnimationEnabled** property:

	__Example 1: Disable animations in the file dialogs__
	```C#
		AnimationManager.SetIsAnimationEnabled(fileDialog, false);
	```

* Due to the UI virtualization feature of the dialogs, the fewer elements which are loaded in the view, the faster the load time of the dialogs. Thus, you can reduce the default size of the dialogs or use a [layout type]({%slug radfiledialogs-features-common%}#setting-the-initial-layout-of-the-tiles) which renders fewer items in the view (LargeIcons or Tiles, for example) to improve performance.
            
## See Also

 * [Getting Started]({%slug radfiledialogs-getting-started%})
 * [Error Handling]({%slug radfiledialogs-features-error-handling%})