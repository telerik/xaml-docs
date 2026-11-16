---
title: Does Telerik UI for WPF Provide a RadGroupBox Control?
description: Find out whether Telerik UI for WPF provides a dedicated RadGroupBox control and which Telerik class provides group box functionality.
components: ["general"]
type: how-to
page_title: RadGroupBox Support in Telerik UI for WPF
slug: kb-common-radgroupbox-control
position: 0
tags: radgroupbox, groupbox, controls, wpf
res_type: kb
---

## Environment

| Version | Product | Author | 
| ---- | ---- | ---- | 
| 2026.4.1111| GroupBox |[Desislava Yordanova](https://www.telerik.com/blogs/author/desislava-yordanova)| 

## Description

Determine whether Telerik UI for WPF provides a dedicated `RadGroupBox` control and identify the Telerik group box control.

## Solution

Telerik UI for WPF provides a `GroupBox` control in the `Telerik.Windows.Controls` namespace. The class derives from the WPF `System.Windows.Controls.GroupBox` class. Use the Telerik control in XAML as follows:

```XAML
<telerik:GroupBox Header="Options">
    <TextBlock Text="Group content" />
</telerik:GroupBox>
```

The `telerik` prefix must map to the `http://schemas.telerik.com/2008/xaml/presentation` namespace. The Telerik control's class name is `GroupBox`, not `RadGroupBox`.

## See Also

* [Telerik UI for WPF API Reference](https://docs.telerik.com/devtools/wpf/api/)
