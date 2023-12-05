---
title: Using ItemTemplateSelector for ControlPanelItems in RadGridView for WPF
description: This article explains how to use an ItemTemplateSelector instead of the default ItemTemplate for ControlPanelItems in RadGridView for WPF.
type: how-to
page_title: Using ItemTemplateSelector for ControlPanelItems in RadGridView for WPF
slug: gridview-using-itemtemplateselector-for-controlpanelitems-radgridview-wpf
tags: radgridview, wpf, itemtemplateselector, controlpanelitems
res_type: kb
---

## Environment
| Property | Value |
|----------|-------|
| Product  | RadGridView for WPF |
| Version  | 2023.2.718 |

## Description
I want to use an `ItemTemplateSelector` instead of the default `ItemTemplate` for `ControlPanelItems` in RadGridView for WPF. Currently, the `ControlPanelItems` are populated using the `ItemTemplate` defined in the `ItemsControl`. I would like to have the flexibility to customize the `ControlPanelItems` based on the type of control specified in a derived `ControlPanelItem`.

## Solution
To achieve this requirement, you can customize the `ControlTemplate` of RadGridView. Follow these steps:

1. [Find and open the Telerik.Windows.Controls.GridView.xaml file]({%slug styling-apperance-editing-control-templates%}) for the corresponding Telerik theme.
2. Locate the `RadGridViewTemplate` element and copy it to your project.
3. Replace the `ItemTemplate` of the `PART_ControlPanelItemsControl` with an `ItemTemplateSelector`.
4. Assign the updated `ControlTemplate` to the `RadGridView` instance via its `Template` property.

## Notes
- Make sure to test any modifications to the `ControlTemplate` thoroughly.
- The provided sample project can serve as a starting point for your customization.

## See Also
- [Customizing Control Templates]({%slug styling-apperance-editing-control-templates%})
