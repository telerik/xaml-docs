---
title: Using DiagramCursors Instead of Manifest Resources
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

Some applications load cursor files such as `HandCursor.cur` from the `Telerik.Windows.Diagrams.Core` assembly with `Assembly.GetManifestResourceStream`. If the embedded resources are removed, the lookup returns `null`. Use the public `DiagramCursors` static class to assign the equivalent cursor instead.

## Solution

Replace code that loads a cursor from a manifest resource and constructs a `Cursor` with the corresponding `DiagramCursors` property. Make sure your project references `Telerik.Windows.Diagrams.Core`.

__Assign a diagram cursor using DiagramCursors__

```C#
using Telerik.Windows.Diagrams.Core;

this.myElement.Cursor = DiagramCursors.Panning;
```

Assign the property to the WPF element whose cursor you previously set from the resource stream. The following table maps each resource to its `DiagramCursors` property and equivalent WPF cursor.

| Embedded resource | DiagramCursors property | Equivalent WPF cursor |
|---|---|---|
| `HandCursor.cur` | `DiagramCursors.Panning` | `Cursors.Hand` |
| `MouseCursor.cur` | `DiagramCursors.Pointer` | `Cursors.Arrow` |
| `MoveCursor.cur` | `DiagramCursors.Dragging` | `Cursors.SizeAll` |
| `SelectionCursor.cur` | `DiagramCursors.RectSelection` | `Cursors.Cross` |
| `TextCursor.cur` | `DiagramCursors.Beam` | `Cursors.IBeam` |
| `ResizeCursor_NWSE.cur` | `DiagramCursors.SizeNWSE` | `Cursors.SizeNWSE` |
| `ResizeCursorNESW.cur` | `DiagramCursors.SizeNESW` | `Cursors.SizeNESW` |

## See Also

* [RadDiagram Overview]({%slug raddiagram-overview%})
* [RadDiagram Tools Overview]({%slug raddiagram-tools-overview%})
