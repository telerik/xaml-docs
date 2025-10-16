---
title: Active Sections
page_title: Active Sections
description: Check our &quot;Active Sections&quot; documentation article for the RadColorEditor {{ site.framework_name }} control.
slug: radcoloreditor-activesections
tags: active,sections
published: True
position: 3
---

# Active Sections

The following article describes the __ActiveSections__ property / feature of the __RadColorEditor__. It gives you the ability to combine/remove different parts of the ColorEditor.

## ActiveSections

Since Q2 2012 SP, __RadColorEditor__ provides __ActiveSections__ property of type __ActiveSectionTypes__ which is a flag enum with the following possible values:        
			
* __SaturationValuePad [1]__

* __HueSaturationPad [2]__

* __HuePad [3]__

* __LuminancePad [4]__

* __ColorModesPanel [5]__

![active Sections](images/activeSections.png)

The default value of ActiveSections is SaturationValuePad | HuePad | ColorModesPanel.		

So How to use the ActiveSections property?		

In XAML , just list your ActiveSections with comma, for example like so:


```XAML
    <telerik:RadColorEditor  ActiveSections="HuePad, ColorModesPanel" />
```

This code produces the following result:

![active Sections 2](images/activeSections2.png)
    
In code behind you have to use the bitwise or:


```C#
    this.colorEditor.ActiveSections = ActiveSectionTypes.HueSaturationPad | ActiveSectionTypes.LuminancePad | ActiveSectionTypes.ColorModesPanel;
```
```VB.NET
    Me.colorEditor.ActiveSections = ActiveSectionTypes.HueSaturationPad Or ActiveSectionTypes.LuminancePad Or ActiveSectionTypes.ColorModesPanel		
```

![active Sections 3](images/activeSections3.png)

>An important note here is that you cannot use every combination of the 5 section types. The rule is: you can use one or none between [1,2] and/or one or none between[3, 4] and/or one or none of [5]. If you use both SaturationValuePad and HueSaturationPan __only the SaturationValuaPad will be visible__. If you use both HuePad and LuminancePad __only the HuePad will be visible__.