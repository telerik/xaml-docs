---
title: Does Telerik UI for WPF Provide a RadLabel Control?
page_title: RadLabel Support in Telerik UI for WPF
description: Find out whether Telerik UI for WPF provides a dedicated RadLabel control and which Telerik label class to use in your XAML application.
components: ["general"]
type: how-to
slug: kb-common-radlabel-control
position: 0
tags: radlabel, label, wpf, controls
res_type: kb
---

## Environment

| Version | Product | Author | 
| ---- | ---- | ---- | 
| 2026.4.1111| Label |[Desislava Yordanova](https://www.telerik.com/blogs/author/desislava-yordanova)| 

## Description

Determine whether Telerik UI for WPF provides a dedicated `RadLabel` control and identify the Telerik control for displaying label content.

## Solution

Telerik UI for WPF provides a `Label` control in the `Telerik.Windows.Controls` namespace. The class derives from the WPF `System.Windows.Controls.Label` class. Its class name is `Label`, not `RadLabel`.

Map the `telerik` prefix to the `http://schemas.telerik.com/2008/xaml/presentation` namespace and use the control in XAML:

```XAML
<telerik:Label Content="User name" />
```

## See Also

* [Telerik UI for WPF API Reference](https://docs.telerik.com/devtools/wpf/api/)
* [Theming Support for WPF Native Controls]({%slug styling-apperance-themes-mscontrols%})
