---
title: Exposing RadGridView Header Cells and Filter Buttons to UI Automation Clients
description: Learn how to expose RadGridView header cells and filter buttons to UI Automation clients in Telerik UI for WPF applications targeting .NET 8.
components: ["gridview"]
type: how-to
page_title: Exposing RadGridView Header Cells and Filter Buttons to UI Automation
slug: kb-gridview-header-filter-buttons-ui-automation
tags: gridview, ui, automation, net8, header cells, filter buttons, peers
ticketid: 1719414
res_type: kb
---

## Environment
<table>
	<tr>
		<th scope="row">Product Version</th>
		<td>Current</td>
	</tr>
	<tr>
		<th scope="row">Product</th>
		<td>Progress® Telerik® UI for WPF</td>
	</tr>
	<tr>
		<th scope="row">Target Framework</th>
		<td>.NET 8</td>
	</tr>
</table>

## Description

When a UI Automation (UIA) client cannot find RadGridView header cells or their filter buttons, add a custom automation peer to the header cells presenter. The presenter returns the header-cell peers to UIA clients.

The existing [.NET 8 UI Automation peer article]({%slug kb-common-net8-automationpeers-issue%}) describes the general WPF issue and its workaround. Use the procedure in this article when you need a RadGridView-specific presenter peer.

## Solution

Add a custom presenter and automation peer to your WPF project. Then replace the presenter in the `GridViewHeaderRow` template for the theme used by your application.

1. Add the following types to a C# file in your application. Replace `WpfApp` with the namespace that you use for your custom presenter.

	```C#
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Automation;
    using System.Windows.Automation.Peers;
    using System.Windows.Media;
    using Telerik.Windows.Controls.GridView;

    namespace WpfApp
    {
        public class FixedDataCellsPresenterAutomationPeer : FrameworkElementAutomationPeer
        {
            public FixedDataCellsPresenterAutomationPeer(FixedDataCellsPresenter owner)
                : base(owner)
            {
            }

            protected override List<AutomationPeer> GetChildrenCore()
            {
                var children = new List<AutomationPeer>();
                CollectHeaderCellPeers(this.Owner, children);
                return children;
            }

            protected override AutomationControlType GetAutomationControlTypeCore()
            {
                return AutomationControlType.Header;
            }

            private static void CollectHeaderCellPeers(DependencyObject parent, List<AutomationPeer> result)
            {
                int childCount = VisualTreeHelper.GetChildrenCount(parent);
                for (int i = 0; i < childCount; i++)
                {
                    var child = VisualTreeHelper.GetChild(parent, i);
                    if (child is GridViewHeaderCell headerCell)
                    {
                        var peer = UIElementAutomationPeer.CreatePeerForElement(headerCell);
                        if (peer != null)
                        {
                            result.Add(peer);
                        }
                    }
                    else
                    {
                        CollectHeaderCellPeers(child, result);
                    }
                }
            }
        }

        public class FixedDataCellsPresenter : DataCellsPresenter
        {
            protected override AutomationPeer OnCreateAutomationPeer()
            {
                return new FixedDataCellsPresenterAutomationPeer(this);
            }
        }
    }
	```

2. Copy the full `GridViewHeaderRow` template and its resources for your theme. Follow the [control template instructions]({%slug styling-apperance-editing-control-templates%}) to copy the template and its theme resources. Set the template key to `FixedGridViewHeaderRowTemplate`. Replace the existing `grid:DataCellsPresenter` element with the custom presenter. Keep the remaining elements and their theme-specific attributes and layout values.

	Add or reuse the following namespace declarations on the root element of the resource dictionary that contains the template and style. Replace `WpfApp` with the namespace that contains the custom presenter.

	```XAML
	xmlns:grid="clr-namespace:Telerik.Windows.Controls.GridView;assembly=Telerik.Windows.Controls.GridView"
	xmlns:local="clr-namespace:WpfApp"
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	```

	The following fragment uses the Windows 11 theme's row and column values. Keep the values and other attributes from your theme's original presenter element if they differ.

	```XAML
	<local:FixedDataCellsPresenter
	    x:Name="PART_DataCellsPresenter"
	    AutomationProperties.Name="Header Cells Presenter"
	    Grid.Row="1"
	    Grid.Column="3"
	    telerik:StyleManager.Theme="{StaticResource Theme}"
	    MinHeight="{TemplateBinding MinHeight}" />
	```

3. Apply the modified template through the header-row style. Base the style on the theme's `GridViewHeaderRowStyle`, then set the style on the `RadGridView` through its `HeaderRowStyle` property.

	```XAML
	<Style x:Key="AccessibleHeaderRowStyle"
	       TargetType="{x:Type grid:GridViewHeaderRow}"
	       BasedOn="{StaticResource GridViewHeaderRowStyle}">
	    <Setter Property="Template" Value="{StaticResource FixedGridViewHeaderRowTemplate}" />
	</Style>

	<telerik:RadGridView HeaderRowStyle="{StaticResource AccessibleHeaderRowStyle}" />
	```

4. Inspect the UI Automation tree for the grid. Confirm that it contains the expected header-cell peers and filter controls.

The custom presenter returns peers for `GridViewHeaderCell` elements in its visual tree. The existing header-cell automation peer provides child peers for the controls inside each header cell.

## See Also

* [Styling the RadGridView header row]({%slug gridview-styling-header-row%})
* [General .NET 8 UI Automation peer issue and workaround]({%slug kb-common-net8-automationpeers-issue%})
