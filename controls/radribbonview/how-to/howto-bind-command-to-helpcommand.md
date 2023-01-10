---
title: Bind Command to the HelpCommand property
page_title: Bind Command to the HelpCommand property
description: This article demonstrates how to bind a Command to the HelpCommand property.
slug: radribbonview-howto-bind-command-to-helpcommand
tags: bind,command,to,the,helpcommand,property
published: True
position: 13
---

# {{ site.framework_name }} RadRibbonView Bind Command to the HelpCommand property

The "Help" button of the RadRibbonView is not visible by default. To learn how to show it and change its icon, read the [Show Help Button and Change its Image]({%slug radribbonview-howto-show-help-icon-and-change-its-image%}).

## Bind Command to the HelpCommand property

The __RadRibbonView__ exposes a property called __HelpCommand__ which can be bound to an object of type __ICommand__. This command will be executed when the built-in help button is clicked.In this section we will demonstrate how to create a custom command and bind it to the __HelpCommand__ property.

First, let’s define a __RadRibbonView__ in our view and set the __HelpButtonVisibility__ to True.

#### __[XAML] Example 1: Defining a RadRibbonView__
{{region radribbonview-howto-bind-command-to-helpcommand-02}}
	<telerik:RadRibbonView HelpButtonVisibility="Visible" ApplicationButtonImageSource="Backstage_Icon.png">
		<telerik:RadRibbonTab Header="Home">
			<telerik:RadRibbonGroup>
				<telerik:RadRibbonButton SmallImage="paste.png" Text="Paste" />
				<telerik:RadOrderedWrapPanel VerticalAlignment="Top">
				<telerik:RadRibbonButton SmallImage="copy.png" Text="Copy" />
				<telerik:RadRibbonButton SmallImage="cut.png" Text="Cut" />
				</telerik:RadOrderedWrapPanel>
			</telerik:RadRibbonGroup>
		</telerik:RadRibbonTab>
		<telerik:RadRibbonTab Header="Insert" />
		<telerik:RadRibbonTab Header="References" />
	</telerik:RadRibbonView>
{{endregion}}

Next, we will create a __DelegateCommand__ object.

{% if site.site_name == 'WPF' %}

#### __[C#] Example 2: Define a DelegateCommand__
{{region radribbonview-howto-bind-command-to-helpcommand-01}}
    public DelegateCommand OpenHelpPageCommand { get; set; }
    public MainWindow()
    {
        InitializeComponent();
        OpenHelpPageCommand = new DelegateCommand(ExecuteCommandHandler, CanExecuteCommandHandler);
        this.DataContext = OpenHelpPageCommand;
    }
{{endregion}}

{% endif %}
{% if site.site_name == 'Silverlight' %}

#### __[C#] Example 2: Define a DelegateCommand__
{{region radribbonview-howto-bind-command-to-helpcommand-03}}
	public DelegateCommand OpenHelpPageCommand { get; set; }
	public MainPage()
    {
        InitializeComponent(); 
        
        OpenHelpPageCommand = new DelegateCommand(ExecuteOpenHelpPage);
        this.DataContext = OpenHelpPageCommand;
        InputBindingCollection inputBindCollection = new InputBindingCollection();
        inputBindCollection.Add(new KeyBinding(this.OpenHelpPageCommand, new KeyGesture(Key.F1)));
        CommandManager.SetInputBindings(this, inputBindCollection);
    }
{{endregion}}

{% endif %}
{% if site.site_name == 'WPF' %}

#### __[VB.NET] Example 2: Define a DelegateCommand__
{{region radribbonview-howto-bind-command-to-helpcommand-01}}
    Public Property OpenHelpPageCommand() As DelegateCommand
        Get
            Return m_OpenHelpPageCommand
        End Get
        Set(value As DelegateCommand)
            m_OpenHelpPageCommand = Value
        End Set
    End Property
    Private m_OpenHelpPageCommand As DelegateCommand

    Public Sub New()
        InitializeComponent()
        OpenHelpPageCommand = New DelegateCommand(ExecuteCommandHandler, CanExecuteCommandHandler)
        Me.DataContext = OpenHelpPageCommand
    End Sub
{{endregion}}

{% endif %}
{% if site.site_name == 'Silverlight' %}

#### __[VB.NET] Example 2: Define a DelegateCommand__
{{region radribbonview-howto-bind-command-to-helpcommand-03}}
    Public Property OpenHelpPageCommand() As DelegateCommand
        Get
            Return m_OpenHelpPageCommand
        End Get
        Set(value As DelegateCommand)
            m_OpenHelpPageCommand = Value
        End Set
    End Property
    Private m_OpenHelpPageCommand As DelegateCommand
    Public Sub New()
        InitializeComponent()

        OpenHelpPageCommand = New DelegateCommand(ExecuteOpenHelpPage)
        Me.DataContext = OpenHelpPageCommand
        Dim inputBindCollection As New InputBindingCollection()
        inputBindCollection.Add(New KeyBinding(Me.OpenHelpPageCommand, New KeyGesture(Key.F1)))
        CommandManager.SetInputBindings(Me, inputBindCollection)
    End Sub
{{endregion}}

{% endif %}

>The __HelpCommand__ property will accept every object that implements the [ICommand](http://msdn.microsoft.com/en-us/library/system.windows.input.icommand(v=vs.110).aspx) interface. The __DelegateCommand__ class is one such implementation.          

You can implement your logic in the __Execute__ and __CanExecute__ handlers of the __DelegateCommand__.

#### __[C#] Example 3: Implement the Execute and CanExecute methods__
{{region radribbonview-howto-bind-command-to-helpcommand-02}}
	private bool CanExecuteCommandHandler(object obj)
	{
	    // Implement logic that checks if the button command can be executed
	    return true;
	}
	
	private void ExecuteCommandHandler(object obj)
	{
	    // Implement the logic that should be executed when the button is clicked
	    MessageBox.Show("Help Command Executed");
	}
{{endregion}}

#### __[VB.NET] Example 3: Implement the Execute and CanExecute methods__
{{region radribbonview-howto-bind-command-to-helpcommand-02}}
    Private Function CanExecuteCommandHandler(obj As Object) As Boolean
        ' Implement logic that checks if the button command can be executed'
        Return True
    End Function

    Private Sub ExecuteCommandHandler(obj As Object)
        ' Implement the logic that should be executed when the button is clicked'
        MessageBox.Show("Help Command Executed")
    End Sub
{{endregion}}

Finally, you can bind the command as demonstrated in __Example 4__.

#### __[XAML] Example 4: Binding the HelpCommand property to the custom command__
{{region radribbonview-howto-bind-command-to-helpcommand-03}}
	<telerik:RadRibbonView HelpButtonVisibility="Visible" HelpCommand="{Binding}" />
{{endregion}}

>tip In addition you can use the __HelpCommandParameter__ and the __HelpCommandTarget__ properties of the __RadRibbonView__ in order to pass additional data to the command.        

>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/RibbonView/HelpFunctionality).          

## See Also
 * [Show Help Button and Change its Image]({%slug radribbonview-howto-show-help-icon-and-change-its-image%})
 * [Getting Started]({%slug radribbonview-gettingstarted%})
 * [Visual Structure]({%slug radribbonview-visual-structure%})