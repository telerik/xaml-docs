---
title: Commands
page_title: Commands
description: Commands
slug: radrichtextbox-features-commands
tags: commands
published: True
position: 6
---

# Commands



## 

The __RadRichTextBox__ control exposes a full set of commands that that provide an alternative to its API methods, exposed through its __Commands__ property. For each of the [Formatting API]({%slug radrichtextbox-features-formatting-api%}) methods there is a respective command. In order to use the command with an UI Element that supports commanding, you have to bind the __Command__ property of the element to the respective command of the __RadRichTextBox__.
        

>tip
          To see a list of all the commands exposed by __RadRichTextBox__, visit
          {% if site.site_name == 'Silverlight' %}[this topic](http://www.telerik.com/help/silverlight/allmembers_t_telerik_windows_documents_richtextboxcommands_richtextboxcommands.html){% endif %}{% if site.site_name == 'WPF' %}[this topic](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_documents_richtextboxcommands_richtextboxcommands.html){% endif %}.
        

Here is an example with a __RadToggleButtonControl__.
        

#### __XAML__

{{region radrichtextbox-features-commands_0}}
	<telerik:RadToggleButton x:Name="BoldButton"
	                            Content="Bold"
	                            DataContext="{Binding Commands, ElementName=radRichTextBox}"
	                            Command="{Binding ToggleBoldCommand}" />
	<telerik:RadRichTextBox x:Name="radRichTextBox"
	                                    Height="500"
	                                    Width="500">
	    <telerik:RadDocument LayoutMode="Paged" />
	</telerik:RadRichTextBox>
	{{endregion}}



Now every time the button is clicked it will toggle the boldness of the current selection. The thing it won't do is to response to the current state of the selection. For example if the context of the caret is a bold text, the button won't get automatically toggled. In order to implement this behavior you have to handle the __ToggleStateChanged__ event of the __ToggleBoldCommand__. Here is an example.
        

#### __C#__

{{region radrichtextbox-features-commands_1}}
	public CommandsSample()
	{
	    InitializeComponent();
	    this.radRichTextBox.Commands.ToggleBoldCommand.ToggleStateChanged += this.ToggleBoldCommand_ToggleStateChanged;
	}
	public void ToggleBoldCommand_ToggleStateChanged( object sender, StylePropertyChangedEventArgs<bool> e )
	{
	    this.BoldButton.IsChecked = e.NewValue;
	}
	{{endregion}}



#### __VB.NET__

{{region radrichtextbox-features-commands_2}}
	    Public Sub New()
	        InitializeComponent()
	        Me.radRichTextBox.Commands.ToggleBoldCommand.ToggleStateChanged += Me.ToggleBoldCommand_ToggleStateChanged
	    End Sub
	    Public Sub ToggleBoldCommand_ToggleStateChanged(sender As Object, e As StylePropertyChangedEventArgs(Of Boolean))
	        Me.BoldButton.IsChecked = e.NewValue
	    End Sub
	{{endregion}}



Now the button will respond to the current state of the selection.![Rad Rich Text Box Features Commands 01](images/RadRichTextBox_Features_Commands_01.png)

You can also use the functionality provided by the __RadRichTextBoxRibbonUI__ class in order to get the event handling out of the box.
        

>tip
          The __RadRichTextBoxRibbonUI__ provides you with a fully predefined UI for the RadRichtextBox. To learn how to use it read [this topic]({%slug radrichtextbox-features-radrichtextboxribbonui%}).
        

If you are building your UI manually ,for example using a RadRibbonView control, you have to only bind the command to the __RadRichTextBoxRibbonUI__.__RichTextCommand__ attached property of the desired __RadRibbonView__ control. Here is an example with a __RadRibbonToggleButton__.
        

#### __XAML__

{{region radrichtextbox-features-commands_3}}
	<telerik:RadRibbonToggleButton x:Name="ItalicButton"
	                                Content="Italic"
	                                DataContext="{Binding Commands, ElementName=radRichTextBox}"
	                                telerik:RadRichTextBoxRibbonUI.RichTextCommand="{Binding ToggleItalicCommand}" />
	{{endregion}}



The __RadRibbonToggleButton__ will get automatically toggled whenever the context of the caret is an italic text.
        

>tip
          More about the specific buttons introduced with __RadRibbonView__ you can find
          [here](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_documents_richtextboxcommands_richtextboxcommands.html)![Rad Rich Text Box Features Commands 02](images/RadRichTextBox_Features_Commands_02.png)
