---
title: Drill-Down
page_title: Drill-Down
description: Drill-Down
slug: radexpressioneditor-expressions-drill-down
tags: drill,down
published: True
position: 6
---

# Drill-Down

As of **R1 2019**, the RadExpressionEditor control allows users to expand complex objects and access their sub-properties. This functionality is controlled by the new **IsFieldsDrillDownEnabled** property.

#### __[XAML] Example 1: Enabling drill-down in XAML__

{{region xaml-radexpressioneditor-expressions-drill-down-1}}
    <telerik:RadExpressionEditor IsFieldsDrillDownEnabled="True" />
{{endregion}}

#### __[C#] Example 2: Enabling drill-down in code-behind__

{{region cs-radexpressioneditor-expressions-drill-down-2}}
    this.radExpressionEditor.IsFieldsDrillDownEnabled = true;
{{endregion}}

#### __[VB] Example 2: Enabling drill-down in code-behind__

{{region vb-radexpressioneditor-expressions-drill-down-2}}
    Me.radExpressionEditor.IsFieldsDrillDownEnabled = True
{{endregion}}

**Figure 1** illustrates the difference between the functionality being disabled and enabled.

{% figure 1, "Drill-down functionality", "drill-down.png" %}

>important If you have defined a custom [ExpressionEditorViewModel]({%slug radexpressioneditor-expressions-custom-functions-and-categories%}), you should set the **IsFieldsDrillDownEnabled** property after you set the control's **ViewModel** property for the drill-down functionality to work.

## See Also

* [Lambdas]({%slug radexpressioneditor-expressions-lambdas%})
* [Custom Categories and Functions]({%slug radexpressioneditor-expressions-custom-functions-and-categories%})