---
title: Appearance
page_title: Appearance
description: Check our &quot;Appearance&quot; documentation article for the RadColorPicker {{ site.framework_name }} control.
slug: paletteview-appearance
tags: appearance
published: True
position: 2
---

# {{ site.framework_name }} RadColorPicker Appearance

You can customize the appearance of the palettes using the __ItemsPanel__ property:

#### __XAML__

{{region paletteview-appearance_0}}
	<telerik:RadColorPaletteView>
	 <telerik:RadColorPaletteView.ItemsPanel>
	  <ItemsPanelTemplate>
	   <StackPanel Orientation="Horizontal" />
	  </ItemsPanelTemplate>
	 </telerik:RadColorPaletteView.ItemsPanel>
	</telerik:RadColorPaletteView>
{{endregion}}