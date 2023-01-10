---
title: Backward Compatibility
page_title: Backward Compatibility
description: Check our &quot;Backward Compatibility&quot; documentation article for the RadMediaPlayer {{ site.framework_name }} control.
slug: radmediaplayer-backward-compatibility
tags: backward,compatibility
publish: True
position: 0
---

# {{ site.framework_name }} RadMediaPlayer Backward Compatibility

## Telerik RadMediaPlayer - Q3 2011 

With the Q3 2011 release the __ControlTemplate__ of the __RadMediaPlayer__ is changed.  The __FullScreenPopup__ element type is changed to a __System.Windows.Controls.Primitives.Popup__. If you have created a custom style for the __RadMediaPlayer__, please change the type of the  __FullScreenPopup__ element accordingly.