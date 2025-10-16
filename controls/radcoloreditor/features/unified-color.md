---
title: Unified Color
page_title: Unified Color
description: Check our &quot;Unified Color&quot; documentation article for the RadColorEditor {{ site.framework_name }} control.
slug: radcoloreditor-features-unified-color
tags: unified,color
published: True
position: 2
---

# Unified Color

__RadColorEditor’s UnifiedColor__ property represents an entity that exposes all the values of a color in the different color models.

If the __RadColorEditor SelectedColor__ is set to __Magenta__, the __UnifiedColor__ property will expose the value of the __Magenta__ color in each color model. 


```XAML
	<telerik:RadColorEditor x:Name="colorEditor1" SelectedColor="Magenta" />
```

![radcoloreditor-features-unified-color](images/radcoloreditor-features-unified-color.png)

>If you set the __UnifiedColor__ property its value will immediately reflect on the __SelectedColor__ property value.

![radcoloreditor-features-set-unified-color](images/radcoloreditor-features-set-unified-color.png)

## See Also
 * [Structure]({%slug radcoloreditor-structure%})
 * [Getting Started]({%slug radcoloreditor-getting-started%})
 * [Color Mode]({%slug radcoloreditor-features-color-mode%})
 * [Color History]({%slug radcoloreditor-features-color-history%})