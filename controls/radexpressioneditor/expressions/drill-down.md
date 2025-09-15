---
title: Drill-Down
page_title: Drill-Down
description: Check our &quot;Drill-Down&quot; documentation article for the RadExpressionEditor {{ site.framework_name }} control.
slug: radexpressioneditor-expressions-drill-down
tags: drill,down
published: True
position: 6
---

# Drill-Down

As of **R1 2019**, the RadExpressionEditor control allows users to expand complex objects and access their sub-properties. This functionality is controlled by the new **IsFieldsDrillDownEnabled** property.

__Example 1: Enabling drill-down in XAML__

```XAML
    <telerik:RadExpressionEditor IsFieldsDrillDownEnabled="True" />
```

__Example 2: Enabling drill-down in code-behind__

```C#
    this.radExpressionEditor.IsFieldsDrillDownEnabled = true;
```

__Example 2: Enabling drill-down in code-behind__

```VB
    Me.radExpressionEditor.IsFieldsDrillDownEnabled = True
```

**Figure 1** illustrates the difference between the functionality being disabled and enabled.

{% figure 1, "Drill-down functionality", "drill-down.png" %}

## See Also

* [Lambdas]({%slug radexpressioneditor-expressions-lambdas%})
* [Custom Categories and Functions]({%slug radexpressioneditor-expressions-custom-functions-and-categories%})