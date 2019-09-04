---
title: Getting Started
page_title: Getting Started
description: This article will walk you through the creation of a sample application that contains a RadSyntaxEditor control.
slug: radsyntaxeditor-getting-started
tags: getting,started,radsyntaxeditor
position: 2
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains a __RadSyntaxEditor__ control.
			
## Assembly References

In order to use __RadSyntaxEditor__, you will need to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__
* __Telerik.Windows.Controls.SyntaxEditor__
* __Telerik.Windows.SyntaxEditor.Core__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Defining RadSyntaxEditor

__Example 1__ demonstrates how you can define a RadSyntaxEditor in XAML.

#### __[XAML] Example 1: Defining RadSyntaxEditor__
{{region xaml-radsyntaxeditor-getting-started-0}}

    <telerik:RadSyntaxEditor x:Name="syntaxEditor" />
{{endregion}}

#### __Figure 1: Empty RadSyntaxEditor__
![Empty RadSyntaxEditor](images/syntaxeditor_getting-started-1.png)

## Opening a File

To load a file in the RadSyntaxEditor you need to use its **Document** property.

#### __[C#] Example 2: Opening a File__
{{region cs-radsyntaxeditor-getting-started-1}}

    public MainWindow()
    {
        InitializeComponent();

        using (StreamReader reader = new StreamReader("../../CS_File.txt"))
        {
            this.syntaxEditor.Document = new TextDocument(reader);
        }
    }
{{endregion}}

#### __Figure 2: RadSyntaxEditor with a loaded C# file__
![RadSyntaxEditor with a loaded CS file](images/syntaxeditor_getting-started-2.png)

## Enable Syntax Highlighting

Once you have loaded the code, you need to register an appropriate tagger to enable syntax highlighting for the particular language.

#### __[C#] Example 3: Enable C# code highlighting__
{{region cs-radsyntaxeditor-getting-started-2}}

    var cSharptagger = new CSharpTagger(this.syntaxEditor);
    this.syntaxEditor.TaggersRegistry.RegisterTagger(cSharptagger);
{{endregion}}

#### __Figure 3: RadSyntaxEditor with C# code highlighting__
![RadSyntaxEditor with C# code highlighting](images/syntaxeditor_getting-started-3.png)

## See Also 

* [Visual Structure]({%slug radsyntaxeditor-visual-structure%})