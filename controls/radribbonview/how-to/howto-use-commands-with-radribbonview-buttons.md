---
title: Use Commands with RadRibbonView Buttons
page_title: Use Commands with RadRibbonView Buttons
description: Check our &quot;Use Commands with RadRibbonView Buttons&quot; documentation article for the RadRibbonView {{ site.framework_name }} control.
slug: radribbonview-howto-use-commands-with-radribbonview-buttons
tags: use,commands,with,radribbonview,buttons
published: True
position: 12
---

# Use Commands with RadRibbonView Buttons

All __RadRibbonView__ buttons provide a standard __ICommandSource__ implementation. This is why you can bind the __RadRibbonButtons__ to commands that will get executed when a button is clicked. For this purpose you can use the following properties.		

* __Command__ - gets the command that will be executed when the command source is invoked.

* __CommandParameter__ - represents a user defined data value that can be passed to the command when it is executed.

* __CommandTarget__ - the object on which the command is being executed.			

>tip As all butons implement the __ICommandSource__ interface, you can use them with any command that implements the __ICommand__ interface, for example the __DelegateCommands__.		  

Here is an example of a command usage in a MVVM scenario. The command is located in the __ButtonViewModel__ class.		


```C#
	public class ButtonViewModel
    {
        public ButtonViewModel()
        {
            this.MyCommand = new DelegateCommand(p => Execute(p), p => CanExecute(p));
        }

        public DelegateCommand MyCommand { get; set; }

        private bool CanExecute(object p)
        {
            if (p != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Execute(object p)
        {
            MessageBox.Show("Executed: \n" + p.ToString());
        }
    }
```


```VB.NET
    Public Class ButtonViewModel
        Public Sub New()
            Me.MyCommand = New DelegateCommand(Function(p) Execute(p), Function(p) CanExecute(p))
        End Sub

        Public Property MyCommand() As DelegateCommand
            Get
                Return m_MyCommand
            End Get
            Set(value As DelegateCommand)
                m_MyCommand = Value
            End Set
        End Property
        Private m_MyCommand As DelegateCommand

        Private Function CanExecute(p As Object) As Boolean
            If p IsNot Nothing Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Sub Execute(p As Object)
            MessageBox.Show("Executed: " & vbLf + p.ToString())
        End Sub
    End Class
```

Set the __ButtonViewModel__ as the __DataContext__ of your __UserControl__.	  


```C#
	public Example()
	{
	    InitializeComponent();
	    this.DataContext = new ButtonViewModel();
	}
```


```VB.NET
    Public Sub New()
        InitializeComponent()
        Me.DataContext = New ButtonViewModel()
    End Sub
```

In the XAML provide the bindings for the command and set the command parameter.		

>tip This can be applied to each of the __RadRibbonButtons__. To learn more about them read [here]({%slug radribbonview-buttons-overview%}). Commands can be used with any control, placed in the __RadRibbonView__, that implements the __ICommandSource__ interface.		  


```XAML
	<telerik:RadRibbonView x:Name="xRibbonView">
        <telerik:RadRibbonTab Header="Home">
            <telerik:RadRibbonGroup Header="Home Group">
                <telerik:RadRibbonButton Width="Auto"
                                         Height="20"
                                         Command="{Binding MyCommand}"
                                         CommandParameter="ParameterValue"
                                         Content="Execute Command" />
            </telerik:RadRibbonGroup>
        </telerik:RadRibbonTab>
    </telerik:RadRibbonView>
```

## See Also
 * [RibbonButtons]({%slug radribbonview-buttons-overview%})