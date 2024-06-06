---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-getting-started
tags: getting,started
published: True
position: 0
---

# Getting Started with {{ site.framework_name }} RichTextBox

`RadRichTextBox` is a control that allows you to display and edit rich text content including sections, paragraphs, spans, italic text, bold text, inline images, tables etc. This topic will help you to quickly get started using the control. It will focus on the following:      

* [Assembly References](#assembly-references)
* [Adding RadRichTextBox to the Project](#adding-radrichtextbox-to-the-project)
* [Using the predefined UI of RadRichTextBox](#using-the-predefined-ui-of-radrichtextbox)
* [Showing a Document in RadRichTextBox](#showing-a-document-in-radrichtextbox)
* [Tables, Track Changes and Document Protection](#tables-track-changes-and-document-protection)

## Assembly References

{% if site.framework_name == 'WPF' %}
>The references required to use RadRichTextBox in __.NET__ 6 or later projects have been united. Check the [.NET Support]({%slug radrichtextbox-getting-started-net-core-support%}) help topic for the full list of dependencies.
{% endif %}

The minimal set of references you need to have in your application in order to have a RadRichTextBox are as follows:

* __Telerik.Windows.Controls__
* __Telerik.Windows.Data__
* __Telerik.Windows.Documents__ 
* __Telerik.Windows.Documents.Core__
* __System.ComponentModel.Composition__
* __System.Drawing.Common NuGet package__&mdash;Required only for __.NET 6__ and later and only if the Telerik assemblies are referenced manually in the project. In case you install the dlls using NuGet or the Telerik Visual Studio Extension, this package is included automatically.

In order to use the built-in pop-ups (SelectionMiniToolBar, ContextMenu, all dialogs), you should add references to the following assemblies:

* __Telerik.Windows.Controls.RichTextBoxUI__
* __Telerik.Windows.Controls.ImageEditor__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Controls.RibbonView__

For more information on using RadRichTextBox with `RadRichTextBoxRibbonUI`, please refer to [this article]({%slug radrichtextbox-features-radrichtextboxribbonui%}).        

If you are not using the SelectionMiniToolbar, the ContextMenu and RadRichTextBoxRibbonUI, you can omit the last five assemblies.

For import from/ export to different file formats, you would need references to:

* __Telerik.Windows.Documents.FormatProviders.OpenXml__ and __Telerik.Windows.Zip__ for DOCX.
* __Telerik.Windows.Documents.FormatProviders.Html__ for HTML.
* __Telerik.Windows.Documents.FormatProviders.Xaml__ for XAML.
* __Telerik.Windows.Documents.FormatProviders.Rtf__ for RTF.
* __Telerik.Windows.Documents.FormatProviders.Pdf__ and __Telerik.Windows.Zip__ for PDF (export only).

The default en-US dictionary for SpellChecking is located in:

* __Telerik.Windows.Documents.Proofing.Dictionaries.En-US__.

{% if site.site_name == 'Silverlight' %}
>A reference to __Telerik.Windows.Documents.FormatProviders.Html__ has to be added in order to use HTML printing.{% endif %}

{% if site.site_name == 'WPF' %}
>In order to be able to __copy/paste rich text__ from desktop applications, you have to add references to __Telerik.Windows.Documents.FormatProviders.Rtf__ and __Telerik.Windows.Documents.FormatProviders.Html__.{% endif %}

### Adding Telerik Assemblies Using NuGet

To use __RadRichTextBox__ when working with NuGet packages in __.NET Framework 4.6.2__, install the `Telerik.Windows.Documents.for.Wpf.Xaml` package. In .NET Framework 4.6.2 you will need to install packages also for the format providers and the RichTextBoxUI component. In .NET 6 these components are merged in the RichTextBox package mentioned below.

To use __RadRichTextBox__ when working with NuGet packages in __.NET 6__ and later, install the `Telerik.Windows.Controls.RichTextBox.for.Wpf.Xaml` package. 

The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

## Adding RadRichTextBox to the Project

After adding references to the aforementioned assemblies, you can declare RadRichTextBox manually by writing the XAML code as in the following example or add the control by dragging it from the Visual Studio Toolbox and dropping it over the XAML view.        

#### __[XAML] Adding RadRichTextBox in XAML__
{{region radrichtextbox-getting-started_0}}
    <telerik:RadRichTextBox x:Name="radRichTextBox" />
{{endregion}}


>In order to use RadRichTextBox in XAML, you have to add the following namespace declaration:
>
>#### __[XAML] Declaring Telerik Namespace__
>{{region telerik-schemas}}
>    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
>{{endregion}}

When you run the application, you will see an empty RadRichTextBox.

__Empty RadRichTextBox__

![{{ site.framework_name }} RadRichTextBox Empty RadRichTextBox](images/RadRichTextBox_GettingStarted_01.png)


>tip RadRichTextBox uses __UI Virtualization__ by creating UI elements only for the parts of the document currently visible in the viewport. For this purpose, the control __should not be measured in infinity__, so avoid placing it in containers that might cause this (e.g. `StackPanel`, `ScrollViewer`).
          
## Using the Predefined UI of RadRichTextBox

In addition to its API, RadRichTextBox has a rich set of commands, exposed through its `Commands` property. In order to use them with a UI element which supports commanding, you have to bind the `Command` property of the element to the respective command of the RadRichTextBox.
        

>tipTo learn more about Commands read [this topic]({%slug radrichtextbox-features-commands%}).
          

These commands can also be used with the predefined UI that comes with RadRichTextBox - RadRichTextBoxRibbonUI, which is a ribbon control based on [RadRibbonView]({%slug radribbonview-overview%}). You can use the predefined and customizable `ContextMenu` and `SelectionMiniToolBar` as well. In order to do so, make sure your project references the following assemblies:        

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Controls.RibbonView__
* __Telerik.Windows.Controls.RichTextBoxUI__

__Predefined RadRichTextBoxRibbonUI__

![{{ site.framework_name }} RadRichTextBox RadRichTextBoxRibbonUI](images/RadRichTextBox_GettingStarted_02.png)

>tip You can read more about the predefined UI by following these links - [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}), [ContextMenu]({%slug radrichtextbox-features-context-menu%}), [SelectionMiniToolBar]({%slug radrichtextbox-features-selection-mini-toolbar%}).

## Showing a Document in RadRichTextBox

You can bind a document in XAML or directly set the Document property of RadRichTextBox in code-behind.

### Binding in XAML

With the DataProvider classes you can easily bind RTF, HTML or XAML documents represented as strings to a RadRichTextBox. The DocxDataProvider works with documents represented as a byte array. 

The next example shows the implementation of a sample class that will be later used as data context for RadRichTextBox.

<a name="example3"><a/>
#### __[C#] Sample DataContext class__
{{region radrichtextbox-getting-started_1}}

    public class ExampleDataContext : INotifyPropertyChanged
    {
        private string xamlData;

        public string XamlData
        {
            get
            {
                return this.xamlData;
            }
            set
            {
                if (value != this.xamlData)
                {
                    this.xamlData = value;
                    OnPropertyChanged("XamlData");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
{{endregion}}

#### __[VB.NET] Sample DataContext class__
{{region radrichtextbox-getting-started_2}}

	Public Class ExampleDataContext
    	Implements INotifyPropertyChanged

    	Private _xamlData As String

    	Public Property XamlData() As String
    	    Get
    	        Return Me._xamlData
    	    End Get
    	    Set(value As String)
    	        If value <> Me._xamlData Then
    	            Me._xamlData = value
    	            OnPropertyChanged("XamlData")
    	        End If
    	    End Set
    	End Property
    	
    	Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
	
    	Private Sub OnPropertyChanged(propertyName As String)
    	    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    	End Sub
	End Class
{{endregion}}

>The ExampleDataContext class implements the `INotifyPropertyChanged` interface and raises the `PropertyChanged` event every time a property value changes, in order to __support two-way binding__.

When you already have prepared the sample data, you can bind it to RadRichTextBox. This is done through the corresponding DataProvider.

The following example shows how to bind the XamlData property from [the above example](#example3) to a XamlDataProvider and a RadRichTextBox.

#### __[XAML] Using a DataProvider__
{{region radrichtextbox-getting-started_3}}
    <Grid>
        <Grid.Resources>
            <local:ExampleDataContext x:Key="ExampleDataContext"/>
        </Grid.Resources>
        <telerik:XamlDataProvider RichTextBox="{Binding ElementName=radRichTextBox}" 
								  DataContext="{StaticResource ExampleDataContext}" 
								  Xaml="{Binding Path=XamlData, Mode=TwoWay}" />
        <telerik:RadRichTextBox Name="radRichTextBox" />
    </Grid>
{{endregion}}

>tip More details on using data providers in RadRichTextBox are available [here]({%slug radrichtextbox-features-data-providers%}).

>tip You can download the complete runnable project demonstrating __Data Binding__ in RadRichTextBox from our [SDK Repository](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/DataBinding).

### Setting the Document in Code-Behind

The RadRichTextBox class exposes the `Document` property of type [`RadDocument`]({%slug radrichtextbox-features-document-elements-raddocument%}) that allows you to assign a document to the control in code-behind. You can import an existing document and show it in RadRichTextBox using a format provider as the next shows.

#### __[C#] Showing an Existing Document in RadRichTextBox__
{{region radrichtextbox-getting-started_4}}
    RadDocument document;
    Telerik.Windows.Documents.FormatProviders.OpenXml.Docx.DocxFormatProvider provider = new Telerik.Windows.Documents.FormatProviders.OpenXml.Docx.DocxFormatProvider();

    using (Stream stream = Application.GetResourceStream(GetResourceUri("sampleDocument.docx")).Stream)
    {
        document = provider.Import(stream);
    }

    this.radRichTextBox.Document = document;
{{endregion}}

#### __[VB.NET] Showing an Existing Document in RadRichTextBox__
{{region radrichtextbox-getting-started_5}}
	Dim document As RadDocument
	Dim provider As New Telerik.Windows.Documents.FormatProviders.OpenXml.Docx.DocxFormatProvider()

	Using stream As Stream = Application.GetResourceStream(GetResourceUri("sampleDocument.docx")).Stream
		document = provider.Import(stream)
	End Using

	Me.radRichTextBox.Document = document
{{endregion}}

>tip All the supported document formats and the corresponding format providers are described in the [Import/Export section]({%slug radrichtextbox-features-import-export%}). 

## Tables, Track Changes and Document Protection

RadRichTextBox comes with many built-in features. Here are some of them:

* You can create, modify and delete tables. For more details you can refer to [this topic]({%slug radrichtextbox-features-document-elements-tables%}).

* The [Track Changes]({%slug radrichtextbox-features-track-changes%}) functionality by default is disabled. To enable it, set the `IsTrackChangesEnabled` property to __True__.

* You can enable the [Document Protection]({%slug radrichtextbox-features-document-protection%}) with the `ProtectDocument()` method.

## See Also
 * [Document Elements]({%slug radrichtextbox-features-document-elements-hierarchy%})
 * [Import/Export]({%slug radrichtextbox-features-import-export%})
 * [Events]({%slug radrichtextbox-events-overview%})
 * [Styles and Templates]({%slug radrichtextbox-styles-and-tempaltes-overview%})
