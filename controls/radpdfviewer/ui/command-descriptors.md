---
title: Command Descriptors
page_title: Command Descriptors
description: Check our &quot;Command Descriptors&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-command-descriptors
tags: command,descriptors
published: True
position: 1
---

# Command Descriptors



__RadPdfViewer__'s command descriptors are wrappers of its predefined set of commands. They were introduced as a way to easily enable/disable the commands based on the current document state. This comes in handy in the creation of UI for the viewer such as a toolbar, context menu, etc.
      

The __CommandDescriptor__ class contains 2 public properties:
      

* __IsEnabled__(Boolean): Gets or sets if the command is enabled.
          

* __Command__(ICommand): The command to be executed.
          

## Creating Custom Command Descriptors

The following section demonstrates how you can create a custom command along with the respective command descriptor.
        

This example creates a custom command by inheriting from the __FixedDocumentViewerCommandBase__ class.
        

#### __C#__

```C#
	    public class FitToWidthCommand : FixedDocumentViewerCommandBase
	    {
	        private const double PageMargin = 20;
	
	        public FitToWidthCommand(FixedDocumentViewerBase fixedDocumentViewerBase)
	            : base(fixedDocumentViewerBase)
	        {
	        }
	
	        public override void Execute(object parameter)
	        {
	            double width = this.Viewer.ActualWidth - 2 * PageMargin;
	            double pageWidth = this.Viewer.CurrentPage.ActualWidth;
	            this.Viewer.ScaleFactor = width / pageWidth;
	        }
	    }
```



#### __VB__

```VB
	    Public Class FitToWidthCommand
	        Inherits FixedDocumentViewerCommandBase
	        Private Const PageMargin As Double = 20
	
	        Public Sub New(fixedDocumentViewerBase As FixedDocumentViewerBase)
	            MyBase.New(fixedDocumentViewerBase)
	        End Sub
	
	        Public Overrides Sub Execute(parameter As Object)
	            Dim width As Double = Me.Viewer.ActualWidth - 2 * PageMargin
	            Dim pageWidth As Double = Me.Viewer.CurrentPage.ActualWidth
	            Me.Viewer.ScaleFactor = width / pageWidth
	        End Sub
	    End Class
```



Further, you can create a respective command descriptor with the custom command and use it for the purposes of your application. This can be achieved in one of the following ways:
        

* Create a class inheriting from the __DefaultCommandDescriptors__ class which implements the default command descriptors and add a property of type __CommandDescriptor__ to it.
            

* Create a class inheriting from the __CommandDescriptors__ class which does not implement the default command descriptors and implement them yourself.
            

The below snippet demosntrates how you can use the first of the mentioned methods of creating a command descriptor.
        

#### __C#__

```C#
	    public class CustomCommandDescriptors : DefaultCommandDescriptors
	    {
	        private readonly CommandDescriptor fitToWidthCommandDescriptor;
	
	        public CommandDescriptor FitToWidthCommandDescriptor
	        {
	            get
	            {
	                return this.fitToWidthCommandDescriptor;
	            }
	        }
	
	        public CustomCommandDescriptors(FixedDocumentViewerBase fixedDocumentViewerBase)
	            : base(fixedDocumentViewerBase)
	        {
	            this.fitToWidthCommandDescriptor = new CommandDescriptor(new FitToWidthCommand(fixedDocumentViewerBase));
	        }
	    }
```



#### __VB__

```VB
	    Public Class FitToWidthCommand
	        Inherits FixedDocumentViewerCommandBase
	        Private Const PageMargin As Double = 20
	
	        Public Sub New(fixedDocumentViewerBase As FixedDocumentViewerBase)
	            MyBase.New(fixedDocumentViewerBase)
	        End Sub
	
	        Public Overrides Sub Execute(parameter As Object)
	            Dim width As Double = Me.Viewer.ActualWidth - 2 * PageMargin
	            Dim pageWidth As Double = Me.Viewer.CurrentPage.ActualWidth
	            Me.Viewer.ScaleFactor = width / pageWidth
	        End Sub
	    End Class
```



Once the custom command descriptors are implemented you just need to set __RadPdfViewer__'s __CommandDescriptors__ property.
        

#### __C#__

```C#
	      this.customCommandDescriptors = new CustomCommandDescriptors(this.viewer);
```



#### __VB__

```VB
	    Me.customCommandDescriptors = New CustomCommandDescriptors(Me.viewer)
```

>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/PdfViewer/CustomCommandDescriptor).          
