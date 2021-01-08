---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadImageEditor {{ site.framework_name }} control.
slug: radimageeditor-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains __RadImageEditor__. 

## Assembly references 

In order to use __RadImageEditor__ in your projects, you have to add references to the following assemblies:	

* __Telerik.Windows.Controls__

* __Telerik.Windows.Controls.ImageEditor__

* __Telerik.Windows.Controls.Input__

## Adding RadImageEditor to the Project

The next few code examples will demonstrate how to add a __RadImageEditor__ in XAML, load a sample picture and execute a command on that picture. __Example 1__ showcases a __RadImageEditor__ and a Button defined in XAML.

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

In order to show a picture, you can set the __Image__ property of the __RadImageEditor__. It is of type [RadBitmap](https://docs.telerik.com/devtools/wpf/api/telerik.windows.media.imaging.radbitmap). __Example 3__ demonstrates how you can use the [ImageExampleHelper](https://github.com/telerik/xaml-sdk/blob/master/ImageEditor/RadImageEditorUIFirstLook/ImageExampleHelper.cs) class in order to load an Image. It assumes that there is a folder named "SampleImages" with an image named "RadImageEditor.png" inside the project. 

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

#### __[C#] Example 4: ImageExampleHelper used in Example 3__

{{region cs-radimageeditor-getting-started-4}}
    public class ImageExampleHelper
    {
        private static string SampleImageFolder = "SampleImages/";

        public static void LoadSampleImage(RadImageEditor imageEditor, string image)
        {
            using (Stream stream = Application.GetResourceStream(GetResourceUri(SampleImageFolder + image)).Stream)
            {
                imageEditor.Image = new Telerik.Windows.Media.Imaging.RadBitmap(stream);
                imageEditor.ApplyTemplate();
                imageEditor.ScaleFactor = 0;
            }
        }

        public static Uri GetResourceUri(string resource)
        {
            AssemblyName assemblyName = new AssemblyName(typeof(ImageExampleHelper).Assembly.FullName);
            string resourcePath = "/" + assemblyName.Name + ";component/" + resource;
            Uri resourceUri = new Uri(resourcePath, UriKind.Relative);

            return resourceUri;
        }
    }
{{endregion}}

#### __[VB.NET] Example 4: ImageExampleHelper used in Example 3__

{{region vb-radimageeditor-getting-started-5}}
    Public Class ImageExampleHelper
	Private Shared SampleImageFolder As String = "SampleImages/"

	Public Shared Sub LoadSampleImage(ByVal imageEditor As RadImageEditor, ByVal image As String)
		Using stream As Stream = Application.GetResourceStream(GetResourceUri(SampleImageFolder & image)).Stream
			imageEditor.Image = New Telerik.Windows.Media.Imaging.RadBitmap(stream)
			imageEditor.ApplyTemplate()
			imageEditor.ScaleFactor = 0
		End Using
	End Sub

	Public Shared Function GetResourceUri(ByVal resource As String) As Uri
		Dim assemblyName As New AssemblyName(GetType(ImageExampleHelper).Assembly.FullName)
		Dim resourcePath As String = "/" & assemblyName.Name & ";component/" & resource
		Dim resourceUri As New Uri(resourcePath, UriKind.Relative)

		Return resourceUri
	End Function
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
