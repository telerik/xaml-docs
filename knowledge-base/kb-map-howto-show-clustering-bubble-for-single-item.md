---
title: Show Clustering Bubble For Single Item in RadMap
description: Display Single Item As Clustered.
type: how-to
page_title: Create a group of one item
slug: kb-map-howto-show-clustering-bubble-for-single-item
position: 0
tags: map, clustering, bubble, one, single, item
ticketid: 1408027
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product</td>
	    	<td>RadMap for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to show [clustering]({%slug radmap-heatures-visualization-layer-clustering%}) bubble for single item in RadMap.

## Solution

1. Create a class inheriting __DefaultClusterGenerator__ and set its __AutoExpandWhenSingle__ property to __False__.

	```C#
		public class CustomClusterGenerator : DefaultClusterGenerator
        {
            public CustomClusterGenerator()
            {
                this.AutoExpandWhenSingle = false;
            }
        }
	```

2. Set the CustomClusterGenerator to the __ClusterGenerator__ property of the RadMap.

	```XAML
		<telerik:RadMap >
            <telerik:RadMap.Resources>
                <local:CustomClusterGenerator x:Key="CustomClusterGenerator" />
            </telerik:RadMap.Resources>
            <telerik:VisualizationLayer ClusteringEnabled="True"
                                        ClusterGenerator="{StaticResource CustomClusterGenerator}">
            </telerik:VisualizationLayer>
        </telerik:RadMap>
	```

> The namespace "local" refers to the namespace, where the "CustomClusterGenerator" class is defined.

## See Also

* [Clustering]({%slug radmap-heatures-visualization-layer-clustering%})