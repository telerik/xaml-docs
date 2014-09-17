---
title: Windows8 Theme Brushes
page_title: Windows8 Theme Brushes
description: Windows8 Theme Brushes
slug: common-styles-appearance-troubleshooting-metro-theme
tags: windows8,theme,brushes
published: True
position: 0
site_name: WPF
---

# Windows8 Theme Brushes



## 

The color scheme applied in the Windows8 theme has its drawbacks as the brushes could not be auto frozen in WPF and one should freeze them manually if he is about to open multiple threads with UI. Also every single item that has a color applied is actually bound and listen for changes.
          
        

__Exception:__

System.InvalidOperationException was unhandled by user code
          Message=Cannot access Freezable 'System.Windows.Media.SolidColorBrush' across threads because it cannot be frozen.
        

__Solution:__

To fix the issue, you should just call the Freeze method on the PalleteInstance of the Windows8Colors.
          Telerik.Windows.Controls.Windows8Palette.Palette.Freeze();
          

# See Also

 * [Colorizing Windows8 Theme]({%slug common-styles-appearance-colorizing-metro-theme%})
