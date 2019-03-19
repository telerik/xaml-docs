---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radimageeditor-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains __RadImageEditor__. 

## Assembly references 

In order to use__RadImageEditor__ in your projects, you have to add references to the following assemblies:	

* __Telerik.Windows.Controls__

* __Telerik.Windows.Controls.ImageEditor__

* __Telerik.Windows.Controls.Input__

## Adding RadImageEditor to the Project

The next few code examples will demonstrate how a __RadImageEditor__ can be defined in xaml, a sample picture can be loaded and a command can be executed on that picture. __Example 1__ showcases a __RadImageEditor__ and a Button defined in xaml.

#### __[XAML] Example 1: Defining a RadImageEditor in xaml__

{{region xaml-radimageeditor-getting-started-0}}
	<Grid>
        <Grid.RowDefinitions>
            <RowDefinition />
            <RowDefinition Height="Auto" />
        </Grid.RowDefinitions>
        <telerik:RadImageEditor x:Name="ImageEditor"/>
        <Button Click="Button_Click" Content="Rotate picture" Grid.Row="1" />
    </Grid>
{{endregion}}

__Example 2__ shows the telerik namespace used in __Example 1__:

#### __[XAML] Example 2: Telerik Namespace declaration__
{{region xaml-radimageeditor-getting-started-1}}
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation" 
{{endregion}}

In order to show a picture, you can set the __Image__ property of the __RadImageEditor__. It is of type [RadBitMap](https://docs.telerik.com/devtools/wpf/api/telerik.windows.media.imaging.radbitmap). __Example 3__ demonstrates how you can use the [ImageExampleHelper](https://github.com/telerik/xaml-sdk/blob/master/ImageEditor/RadImageEditorUIFirstLook/ImageExampleHelper.cs) class in order to load an Image. It assumes that there is a folder named "SampleImages" with an image named "RadImageEditor.png" inside the project. 

#### __[C#] Example 3: Load image in RadImageEditor__

{{region cs-radimageeditor-getting-started-2}}
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ImageExampleHelper.LoadSampleImage(this.ImageEditor, "RadImageEditor.png");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.ImageEditor.Commands.Rotate180.Execute(this.ImageEditor);
        }
    }
{{endregion}}

#### __[VB.NET] Example 3: Load image in RadImageEditor__

{{region vb-radimageeditor-getting-started-3}}
    Partial Public Class MainWindow
    Inherits Window

		Public Sub New()
			InitializeComponent()

			ImageExampleHelper.LoadSampleImage(Me.ImageEditor, "RadImageEditor.png")
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Me.ImageEditor.Commands.Rotate180.Execute(Me.ImageEditor)
		End Sub
    End Class
{{endregion}}

#### __Figure 1: Result from the above examples__
![RadImageEditor rotating image](images/RadImageEditor_GettingStarted.gif)

## Commands and Tools

__Example 3__ demonstrates the usage of a single command over the loaded image. However, the __RadImageEditor__ provides many more [Commands and Tools]({%slug radimageeditor-features-commands-and-tools%}), which can be executed both in code-behind or XAML. 

## RadImageEditorUI

__RadImageEditor__ is easy to integrate with all kinds of UI thanks to the commanding mechanism that it employs. It has a good-to-go UI that comes out of the box. That is [__RadImageEditorUI__]({%slug radimageeditor-features-radimageeditorui%}), which is quite easily wired to work with the commands and tools that __RadImageEditor__ exposes. As both controls follow closely the command pattern, they can be set up to work with little to no code-behind. However, you can implement and wire custom UI, too.


## See Also

* [RadImageEditorUI]({%slug radimageeditor-features-radimageeditorui%})
* [Import and Export]({%slug radimageeditor-features-import-export%})