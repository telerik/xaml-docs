---
title: Customize the Path and Pencil tools
page_title: Customize the Path and Pencil tools
description: Check our &quot;Customize the Path and Pencil tools&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagram-howto-customize-path-pencil-tools
tags: how,to,customize,path,pencil,tools
published: True
position: 3
---

# Customizing Tools

The purpose of this article is to guide you through the steps that you need to take in order to customize some of the built in mouse tools. In particular, the [Drawing Tools]({%slug raddiagram-features-drawing%}) of the RadDiagram.
The steps that you need to take to customize the **Drawing** tools are:

* Create your custom tool deriving from the default one.
* Replace the default tool in the RadDiagram with your custom one.
* Use your tool.

## Create Custom Tool

In order to create a custom tool you need to create a class and derive it from your default tool. For the purpose of this article we will customize the __Path__ and __Pencil__ tools of the RadDiagram.

Here is how this can be done with both tools:

#### **[C#] Example 1: Defining a custom tool**
```C#
    public class MyPathTool : PathTool
    {
    }

    public class MyPencilTool : PencilTool
    {
    }
```

#### **[VB.NET] Example 1: Defining a custom tool**
```VB.NET
	Public Class MyPathTool
	Inherits PathTool

	End Class

	Public Class MyPencilTool
	Inherits PencilTool

	End Class
```

You will also need to create a constructor for those tools which receives and assigns a string to the __Name__ property of the tool. Based on this Name, RadDiagram (de)selects the tools. 

#### **[C#] Example 2: Defining constructor for the custom tool** 
```C#
	public class MyPathTool : PathTool
    {
		public MyPathTool(string name): base()
        {
            this.Name = name;
        }
	}

	public class MyPencilTool : PencilTool
    {
		public MyPencilTool(string name):base()
        {
            this.Name = name;
        }
	}
```

#### **[VB.NET] Example 2: Defining constructor for the custom tool**
```VB.NET
	Public Class MyPathTool
		Inherits PathTool
		Public Sub New(name As String)
			MyBase.New()
			Me.Name = name
		End Sub
	End Class
	
	Public Class MyPencilTool
		Inherits PencilTool
		Public Sub New(name As String)
			MyBase.New()
			Me.Name = name
		End Sub
	End Class
```

## Replace the Default Tools

Now you are ready to replace the existing tool in the RadDiagram. To do this, you can take advantage of the __ToolService__ of the framework. You can find additional information about the Services exposed by the diagram in our [Services]({%slug raddiagram-features-services%}) article. You should first get a reference to the __ToolService__ and then you will be able to replace the default tools. To make sure that all the services are initialized and ready to use, subscribe to the **Loaded** event of the RadDiagram and replace the tools in its handler.

>You need to always replace the default tools if you need to customize some of the existing functionality. For this you need to use the exact same names to create your customized tools. Otherwise, the RadDiagram will not replace the default ones.

#### **[C#] Example 3: Replacing the default tool**
```C#
	void diagram_Loaded(object sender, RoutedEventArgs e)
	{
	    IToolService iservice = this.diagram.ServiceLocator.GetService<IToolService>();
	    ToolService service = iservice as ToolService;
	    if (service != null)
	    {
	        //create the custom tools
	        var path = new MyPathTool("PathTool");
	        var pencil = new MyPencilTool("PencilTool");
	
	        //replace the default tools
	        service.ToolList[1] = path;
	        service.ToolList[2] = pencil;
	
	        //activate the custom tools
	        service.ActivateTool("PencilTool");
	    }
	}
```

#### **[VB.NET] Example 3: Replacing the default tool**
```VB.NET
	Private Sub diagram_Loaded(sender As Object, e As RoutedEventArgs)
		Dim iservice As IToolService = Me.diagram.ServiceLocator.GetService(Of IToolService)()
		Dim service As ToolService = TryCast(iservice, ToolService)
		If service IsNot Nothing Then
			'create the custom tools'
			Dim path = New MyPathTool("PathTool")
			Dim pencil = New MyPencilTool("PencilTool")
	
			'replace the default tools'
			service.ToolList(1) = path
			service.ToolList(2) = pencil
	
			'activate the custom tools'
			service.ActivateTool("PencilTool")
		End If
	End Sub
```

>tip If you need to extend the list of available tools, you should add them to the **ToolList** collection of the ToolService.

## Customizing the Tools

If you attempt to use the custom tools at this point, they will act just like the default ones because they are not yet customized. The customization that we will implement is that the RadDiagram will switch back the __Pointer__ tool right after the **Path** or **Pencil** tools are used. In other words, right after a shape is created with the custom tools, the __RadDiagram.ActiveTool__ will be switched back to the Pointer tool so that the user will be able to interact with the new shape without the need to change the tool to do so.

To accomplish this, override the __CompleteTool()__ method of the Drawing tools like shown in **Example 4**.

#### **[C#] Example 4: Override the CompleteTool() method**
```C#
	public override void CompleteTool()
	{
	    base.CompleteTool();
	
	    var service = (this.Graph as RadDiagram).ServiceLocator.GetService<IToolService>();
	    service.ActivateTool(PointerTool.ToolName);
	}
```

#### **[VB.NET] Example 4: Override the CompleteTool() method**
```VB.NET
	Public Overrides Sub CompleteTool()
		MyBase.CompleteTool()
	
		Dim service = TryCast(Me.Graph, RadDiagram).ServiceLocator.GetService(Of IToolService)()
		service.ActivateTool(PointerTool.ToolName)
	End Sub
```

In **Example 4**, the **ToolService** of the RadDiagram is used to switch the active tool. Invoking **ActivateTool()** after the **base()** method ensures that the tool will be switched after the new shape is created.

## See Also
[Tools Customization]({%slug raddiagram-tools-customization%})
[Services]({%slug raddiagram-features-services%})
