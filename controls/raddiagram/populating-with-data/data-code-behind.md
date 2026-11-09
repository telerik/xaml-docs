---
title: In Code-Behind
page_title: In Code-Behind
description: Learn how to create a RadDiagram and add shapes and connections in code-behind with Telerik UI for WPF, using ShapeFactory helpers.
components: ["diagram"]
slug: raddiagram-data-code-behind
tags: in,code-behind
published: True
position: 3
---

# In Code-Behind

This article shows how to define a `RadDiagram`, shapes, and connections in code-behind with Progress® Telerik® UI for WPF.

>note The examples use the Telerik Windows8 theme. See [setting an application-wide theme]({%slug styling-apperance-implicit-styles-overview%}) for the Xaml and NoXaml theme setup options.

## Adding Items In Code Behind

Before using the examples, configure a WPF project with the package or assembly references described in [RadDiagram Getting Started]({%slug raddiagram-getting-started%}). Complete the [license activation]({%slug installing-license-key%}) required for your Telerik release and configure the theme for your Xaml or NoXaml assemblies.

The following C# and VB.NET examples create a `RadDiagram` and add two shapes and a connection:

<snippet id='raddiagram-populating-with-data-data-code-behind-block_1-cs' />

<snippet id='raddiagram-populating-with-data-data-code-behind-block_1-vb' />


The examples use the static `ShapeFactory` class from the `Telerik.Windows.Controls.Diagrams` assembly. The following C# and VB.NET examples list its static methods for creating an `EllipseShape`, `RectangleShape`, or `Geometry`:

<snippet id='raddiagram-populating-with-data-data-code-behind-block_2-cs' />

<snippet id='raddiagram-populating-with-data-data-code-behind-block_2-vb' />


Here you see a snapshot of the defined `RadDiagram`:
![RadDiagram with a cloud labeled Cloud connected to a database shape labeled DB](images/raddiagrams-populating-with-data-in-code-behind.png)

## See Also
 * [Structure]({%slug raddiagram-structure%})
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Declaratively Populating with Data]({%slug raddiagram-data-declaratively%})
 * [DataBinding]({%slug raddiagram-data-databinding%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Removing Items]({%slug raddiagrams-features-delete%})