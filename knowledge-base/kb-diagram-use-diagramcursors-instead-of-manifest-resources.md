---
title: Using DiagramCursors Instead of Loading .cur Files as Manifest Resources
description: Replace embedded RadDiagram cursor manifest-resource loading with public DiagramCursors properties, map each cursor file, and update WPF cursor assignments.
type: how-to
page_title: RadDiagram for WPF Cursor Migration - Replacing Manifest Resources with DiagramCursors
slug: kb-diagram-use-diagramcursors-instead-of-manifest-resources
position: 0
tags: raddiagram, diagramcursors, cursor, mouse cursor, manifest resource, embedded resource, cursor migration, pointer cursor, panning cursor, resize cursor
components: ["diagram"]
res_type: kb
---

## Environment

<table>
<tbody>
<tr>
<td>Product Version</td>
<td>2026.3.925</td>
</tr>
<tr>
<td>Product</td>
<td>RadDiagram for WPF</td>
</tr>
</tbody>
</table>

## Description

In older versions of Telerik UI for WPF, some applications may load cursor files such as `HandCursor.cur` from the `Telerik.Windows.Diagrams.Core` assembly with `Assembly.GetManifestResourceStream`. With versions after Q4 2026, these embedded resources are removed and the lookup will return `null`. Use the public `DiagramCursors` static class to assign the equivalent cursor instead.

## Solution

Replace code that loads a cursor from a manifest resource and constructs a `Cursor` with the corresponding `DiagramCursors` property. Make sure your project references `Telerik.Windows.Diagrams.Core`.

__Assign a diagram cursor using DiagramCursors__

```C#
using Telerik.Windows.Diagrams.Core;

this.myElement.Cursor = DiagramCursors.Panning;
```

Assign the property to the WPF element whose cursor you previously set from the resource stream. The following table maps each resource to its `DiagramCursors` property.

| Embedded resource | DiagramCursors property |
|---|---|
| `HandCursor.cur` | `DiagramCursors.Panning` |
| `MouseCursor.cur` | `DiagramCursors.Pointer` | 
| `MoveCursor.cur` | `DiagramCursors.Dragging` | 
| `SelectionCursor.cur` | `DiagramCursors.RectSelection` |
| `TextCursor.cur` | `DiagramCursors.Beam` | 
| `ResizeCursor_NWSE.cur` | `DiagramCursors.SizeNWSE` | 
| `ResizeCursorNESW.cur` | `DiagramCursors.SizeNESW` | 

## See Also

* [RadDiagram Overview]({%slug raddiagram-overview%})
* [RadDiagram Tools Overview]({%slug raddiagram-tools-overview%})
