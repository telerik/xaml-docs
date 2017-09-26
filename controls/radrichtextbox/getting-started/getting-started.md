---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radrichtextbox-getting-started
tags: getting,started
published: True
position: 0
---

# Getting Started



__RadRichTextBox__ is a control that allows you to display and edit rich text content including sections, paragraphs, spans, italic text, bold text, inline images, tables etc. This topic will help you to quickly get started using the control. It will focus on the following:
      

* [Assembly References](#assembly-references)
* [Adding RadRichTextBox to the Project](#adding-radrichtextbox-to-the-project)
* [Using the predefined UI of RadRichTextBox](#using-the-predefined-ui-of-radrichtextbox)
* [Showing a Document in RadRichTextBox](#showing-a-document-in-radrichtextbox)
* [Tables, Track Changes and Document Protection](#tables-track-changes-and-document-protection)


## Assembly References

The minimal set of references you need to have in your application in order to have a **RadRichTextBox** are as follows:

* **Telerik.Windows.Controls**
* **Telerik.Windows.Data**
* **Telerik.Windows.Documents**
* **Telerik.Windows.Documents.Core**
{% if site.site_name == 'WPF' %}* **Telerik.Windows.Documents.Flow**{% endif %}
* **System.ComponentModel.Composition**

In order to use the built-in pop-ups (SelectionMiniToolBar, ContextMenu, all dialogs), you should add references to the following assemblies:

* **Telerik.Windows.Controls.RichTextBoxUI**
* **Telerik.Windows.Controls.ImageEditor**
* **Telerik.Windows.Controls.Input**
* **Telerik.Windows.Controls.Navigation**
* **Telerik.Windows.Controls.RibbonView**


For more information on using **RadRichTextBox** with **RadRichTextBoxRibbonUI**, please refer to [this article]({%slug radrichtextbox-features-radrichtextboxribbonui%}).
        

If you are not using the SelectionMiniToolbar, the ContextMenu and **RadRichTextBoxRibbonUI**, you can omit the last five assemblies.

For import from/ export to different file formats, you would need references to:

* **Telerik.Windows.Documents.FormatProviders.OpenXml** and **Telerik.Windows.Zip** for DOCX.
* **Telerik.Windows.Documents.FormatProviders.Html** for HTML.
* **Telerik.Windows.Documents.FormatProviders.Xaml** for XAML.
* **Telerik.Windows.Documents.FormatProviders.Rtf** for RTF.
* **Telerik.Windows.Documents.FormatProviders.Pdf** and **Telerik.Windows.Zip** for PDF (export only).


The default en-US dictionary for SpellChecking is located in:

* **Telerik.Windows.Documents.Proofing.Dictionaries.En-US**.

{% if site.site_name == 'Silverlight' %}
>A reference to **Telerik.Windows.Documents.FormatProviders.Html** has to be added in order to use HTML printing.{% endif %}


{% if site.site_name == 'WPF' %}
>In order to be able to **copy/paste rich text** from desktop applications, you have to add references to **Telerik.Windows.Documents.FormatProviders.Rtf** and **Telerik.Windows.Documents.FormatProviders.Html**.{% endif %}

## Adding RadRichTextBox to the Project

After adding references to the aforementioned assemblies, you can declare __RadRichTextBox__ manually by writing the XAML code in **Example 1** or add the control by dragging it from the Visual Studio Toolbox and dropping it over the XAML view.
        

#### __[XAML] Example 1: Adding RadRichTextBox in XAML__

{{region radrichtextbox-getting-started_0}}
    <telerik:RadRichTextBox x:Name="radRichTextBox" />
{{endregion}}


>In order to use **RadRichTextBox** in XAML, you have to add the following namespace declaration:
>
>#### __[XAML] Example 2: Declaring Telerik Namespace__
>{{region telerik-schemas}}
>    xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
>{{endregion}}

When you run the application, you will see an empty **RadRichTextBox** as the one in **Figure 1**.

#### Figure 1: Empty RadRichTextBox
![](images/RadRichTextBox_GettingStarted_01.png)


>tip**RadRichTextBox** uses **UI Virtualization** by creating UI elements only for the parts of the document currently visible in the viewport. For this purpose, the control **should not be measured in infinity**, so avoid placing it in containers that might cause this (e.g. StackPanel, ScrollViewer).
          
## Using the Predefined UI of RadRichTextBox

In addition to its API, __RadRichTextBox__ has a rich set of commands, exposed through its __Commands__ property. In order to use them with a UI element which supports commanding, you have to bind the __Command__ property of the element to the respective command of the __RadRichTextBox__.
        

>tipTo learn more about __Commands__ read [this topic]({%slug radrichtextbox-features-commands%}).
          

These commands can also be used with the predefined UI that comes with __RadRichTextBox__ - __RadRichTextBoxRibbonUI__, which is a ribbon control based on [RadRibbonView]({%slug radribbonview-overview%}). You can use the predefined and customizable __ContextMenu__ and __SelectionMiniToolBar__ as well. In order to do so, make sure your project references the following assemblies:        

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Controls.Navigation__
* __Telerik.Windows.Controls.RibbonView__
* __Telerik.Windows.Controls.RichTextBoxUI__

**Figure 2** shows what the predefined UI looks like.

#### Figure 2: RadRichTextBoxRibbonUI
![](images/RadRichTextBox_GettingStarted_02.png)

>tipYou can read more about the predefined UI by following these links - [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}), [ContextMenu]({%slug radrichtextbox-features-context-menu%}), [SelectionMiniToolBar]({%slug radrichtextbox-features-selection-mini-toolbar%}).



## Showing a Document in RadRichTextBox

You can bind a document in XAML or directly set the Document property of RadRichTextBox in code-behind.

### Binding in XAML

With the **DataProvider** classes you can easily bind RTF, HTML or XAML documents represented as strings to a RadRichTextBox. The DocxDataProvider works with documents represented as a byte array. **Example 3** shows the implementation of a sample class that will be later used as data context for RadRichTextBox.

<a name="example3"><a/>
#### **[C#] Example 3: Sample DataContext class**

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

#### **[VB.NET] Example 3: Sample DataContext class**

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

>The ExampleDataContext class implements the **INotifyPropertyChanged** interface and raises the **PropertyChanged** event every time a property value changes in order to **support two-way binding**.

When you already have prepared the sample data, you can bind it to **RadRichTextBox**. This is done through the corresponding DataProvider. **Example 4** shows how to bind the XamlData property from [Example 3](#example3) to a XamlDataProvider and a RadRichTextBox.

#### **[XAML] Example 4: Using a DataProvider**
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

>tipMore details on using data providers in **RadRichTextBox** are available [here]({%slug radrichtextbox-features-data-providers%}).

>tipYou can download the complete runnable project demonstrating **Data Binding** in **RadRichTextBox** from our [SDK Repository](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/DataBinding).
### Setting the Document in Code-Behind

The **RadRichTextBox** class exposes the **Document** property of type [**RadDocument**]({%slug radrichtextbox-features-document-elements-raddocument%}) that allows you to assign a document to the control in code-behind. You can import an existing document and show it in RadRichTextBox using a format provider as **Example 5** shows.

#### **[C#] Example 5: Showing an Existing Document in RadRichTextBox**

{{region radrichtextbox-getting-started_4}}

    RadDocument document;
    DocxFormatProvider provider = new DocxFormatProvider();

    using (Stream stream = Application.GetResourceStream(GetResourceUri("sampleDocument.docx")).Stream)
    {
        document = provider.Import(stream);
    }

    this.radRichTextBox.Document = document;
{{endregion}}


#### **[VB.NET] Example 5: Showing an Existing Document in RadRichTextBox**

{{region radrichtextbox-getting-started_5}}

	Dim document As RadDocument
	Dim provider As New DocxFormatProvider()

	Using stream As Stream = Application.GetResourceStream(GetResourceUri("sampleDocument.docx")).Stream
		document = provider.Import(stream)
	End Using

	Me.radRichTextBox.Document = document
{{endregion}}


>tipAll the supported document formats and the corresponding format providers are described in the [Import/Export section]({%slug radrichtextbox-features-import-export%}). 


## Tables, Track Changes and Document Protection

**RadRichTextBox** comes with many built-in features. Here are some of them:

* You can create, modify and delete tables. For more details you can refer to [this topic]({%slug radrichtextbox-features-document-elements-tables%}).

* The [Track Changes]({%slug radrichtextbox-features-track-changes%}) functionality by default is disabled. To enable it, set the **IsTrackChangesEnabled** property to **True**.

* You can enable the [Document Protection]({%slug radrichtextbox-features-document-protection%}) with the **ProtectDocument()** method.


## See Also

 * [Document Elements]({%slug radrichtextbox-features-document-elements-hierarchy%})

 * [Import/Export]({%slug radrichtextbox-features-import-export%})

 * [Events]({%slug radrichtextbox-events-overview%})

 * [Styles and Templates]({%slug radrichtextbox-styles-and-tempaltes-overview%})
