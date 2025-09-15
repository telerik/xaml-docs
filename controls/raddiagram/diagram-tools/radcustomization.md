---
title: Tools Customization
page_title: Tools Customization
description: Check our &quot;Tools Customization&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagram-tools-customization
tags: tools,customization
published: True
position: 4
---

# Tools Customization

__RadDiagram__ provides a list of all available tools, which you can easily change to better fit your applicaiton logic. You can remove built-in tools, create custom ones and add them to the list or replace existing ones with them.

In __RadDiagram__ the __ToolService__ keeps a collection of tools in its __ToolList__ property. This property is essentially a collection of objects implementing the {% if site.site_name == 'Silverlight' %}[ITool](https://docs.telerik.com/devtools/silverlight/api/telerik.windows.diagrams.core.itool){% else %}[ITool](https://docs.telerik.com/devtools/wpf/api/telerik.windows.diagrams.core.itool){% endif %} interface.

You can get the __ToolService__ currently used by a __RadDiagram__ instance through the __ServiceLocator.GetService()__ method. You can read more about the __ServiceLocator__ in the [Services]({%slug raddiagram-features-services%}) tutorial. 

By default there are 14 tools registered in the following order in the __ToolService ToolList__ collection:		

* __PointerTool__ - This is the default active tool in a diagram. It allows you to drag, select, resize items and etc.			

* __PathTool__ - A tool that allows you to draw polyline shapes.			

* __PencilTool__ - A tool that allows you to perform free hand drawing.			

* __TextTool__ -  A tool that allows you to position and add text to your diagram.			

* __PanningTool__ -  A tool that allows you to perform panning.			

* __ConnectionTool__ - A tool that allows to create connections. You can activate it by setting the __RadDiagram.ActiveTool__ to __ConnectorTool__.			

* __DraggingTool__ - A tool that handles the translation of items on the diagramming surface, such as dragging shapes across the diagram.			

* __ConnectionManipulationTool__ - A tool that handles the changes of a connection, such as translating the intermediate connection points, adding and removing intermediate connection points or connecting or detaching endpoints to/from a shape's connector.			

* __ResizingToolNESW__ - A tool that handles the item's resizing from NorthEast to SouthWest.			

* __ResizingToolNWSE__ - A tool that handles the item's resizing from NorthWest to SouthEast.			

* __ResizingToolSENW__ - A tool that handles the item's resizing from SouthEast to NorthWest.			

* __ResizingToolSWNE__ - A tool that handles the item's resizing from SouthWest to NorthEast.			

* __RotationTool__ - A tool that handles the items' rotation.			

* __RectangleSelectionTool__ - A tool that allows you to draw a selection rectangle thus selecting all items within its bounds.			

>tip In order to access the __ToolList__ collection, the object returned by the __ServiceLocator.GetService()__ method should be cast to __ToolService__.		  

You can easily add, remove or replace tools from the above collection. It is also important to note that all these tools handle user interactions - mouse and keyboard actions, originating from the __RadDiagram__. This is why they have to handle mouse and keyboard events. In order to do so the services implement one or both of the following interfaces:		

* __IMouseListener__ - this interface describes the four fundamental methods of a mouse handler object - __MouseDown__, __MouseDoubleClick__, __MouseMove__ and __MouseUp__. You can examine its members in {% if site.site_name == 'Silverlight' %}[the API reference](https://docs.telerik.com/devtools/silverlight/api/telerik.windows.diagrams.core.imouselistener){% else %}[the API reference](https://docs.telerik.com/devtools/wpf/api/telerik.windows.diagrams.core.imouselistener){% endif %}

* __IKeyboardListener__ - this interface describes the two fundamental methods of a keyboard handler object - __KeyUp__ and __KeyDown__. You can examine its members in {% if site.site_name == 'Silverlight' %}[the API reference](https://docs.telerik.com/DEVTOOLS/SILVERLIGHT/api/telerik.windows.diagrams.core.ikeyboardlistener){% else %}[the API reference](https://docs.telerik.com/devtools/wpf/api/telerik.windows.diagrams.core.ikeyboardlistener){% endif %}

>tip The order of the tools added to the __ToolList__ collection is important due to the fact that they all listen to the same mouse and keyboard events. As soon as an active tool detects a user interaction that it has to respond to, it notifies the __ToolService__ not to propagate this event any further. This is why the tools next in line in the __ToolList__ will not receive the inetraciton. This ensures that there is only one active tool at all times.		  

## Getting a Tool

A tool can be get from the Tools collection of the diagram's ToolService.

__Example 1: Getting a tool by name__
```C#
	ToolService toolService = xDiagram.ServiceLocator.GetService<IToolService>() as ToolService;
	PencilTool pencilTool  = (PencilTool)toolService.FindTool(PencilTool.ToolName);
```
```VB.NET
	Dim toolService As ToolService = TryCast(xDiagram.ServiceLocator.GetService(Of IToolService)(), ToolService)
    Dim pencilTool As PencilTool = CType(toolService.FindTool(PencilTool.ToolName), PencilTool)
```

__Example 2: Getting a tool by index__
```C#
	ToolService toolService = xDiagram.ServiceLocator.GetService<IToolService>() as ToolService;
	PencilTool pencilTool = (PencilTool)toolService.ToolList[2];
```
```VB.NET
	Dim toolService As ToolService = TryCast(xDiagram.ServiceLocator.GetService(Of IToolService)(), ToolService)
	Dim pencilTool As PencilTool = CType(toolService.ToolList(2), PencilTool)
```

## Registering a Tool

To register or replace a tool you can use the __Tools__ collection of the diagram's ToolService.

__Example 3: Replace an existing tool__
```C#
	ToolService toolService = xDiagram.ServiceLocator.GetService<IToolService>() as ToolService;
	toolService.ToolList[2] = new MyPencilTool("MyPencilTool");	
```
```VB.NET
	Dim toolService As ToolService = TryCast(xDiagram.ServiceLocator.GetService(Of IToolService)(), ToolService)
    toolService.ToolList(2) = New MyPencilTool("MyPencilTool")
```

__Example 4: Register a new tool__
```C#
	ToolService toolService = xDiagram.ServiceLocator.GetService<IToolService>() as ToolService;
	MyCustomTool myCustomTool = new MyCustomTool("MyCustomTool");
	toolService.ToolList.Add(myCustomTool);
```
```VB.NET
	Dim toolService As ToolService = TryCast(xDiagram.ServiceLocator.GetService(Of IToolService)(), ToolService)
    Dim myCustomTool As MyCustomTool = New MyCustomTool("MyCustomTool")
    toolService.ToolList.Add(myCustomTool)
```

## Creating a Custom Tool

In order to create a custom tool, you can create a new class using one of the following approaches:		

* Create a class that derives from one of the built-in tools described above.

* Create a class that derives from the __ToolBase__ class and implements the __IMouseListener__ and/or __IKeyboardListener__ interfaces.			

* Create a class that implements the {% if site.site_name == 'Silverlight' %}[ITool](https://docs.telerik.com/devtools/silverlight/api/telerik.windows.diagrams.core.itool){% else %}[ITool](https://docs.telerik.com/devtools/wpf/api/telerik.windows.diagrams.core.itool){% endif %} interface and one or both of the __IMouseListener__ and __IKeyboardListener__ interfaces.

>tip See the [CustomTools](https://github.com/telerik/xaml-sdk/tree/master/Diagram/CustomTools) SDK example which demonstrates how to implement a custom tool. See also, the [Customize the Path and Pencil Tools]({%slug raddiagram-howto-customize-path-pencil-tools%}) article.
