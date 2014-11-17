---
title: Printing
page_title: Printing
description: Printing
slug: raddiagram-features-printing
tags: printing
published: True
position: 14
---

# Printing



This tutorial describes the Diagramming framework printing functionality.

The __RadDiagram__ exposes a method and command that allow you to print its content.
	  

## RadDiagram Print Support

###  RadDiagram.Print() method
		  

The __RadDiagram.Print()__ method allows you to print the content of the Diagramming canvas. The __Print()__ method has one optional argument of type __RadDiagramPrintSettings__, which exposes the following members:
			

* __Title__ - this property is of type __string__ and it determines the name of the printing job in the print queue of a printer
				

* __PageMargin__ - this property is of type __Thickness__ and it provides control over the size of the document's page margins when printed.
				{% if site.site_name == 'WPF' %}

>You can take advantage of the __RadDiagramPrintPreview__ to see the __RadDiagram__ print document's page margins before printing.
					{% endif %}
#### __C#__
    xDiagram.Print(new RadDiagramPrintSettings("My Diagramming Solution",new Thickness(22,15,22,15)));		  
#### __VB.NET__
    xDiagram.Print(New RadDiagramPrintSettings("My Diagramming Solution", New Thickness(22, 15, 22, 15)))		  

If you don't define any __RadDiagramPrintSettings__ when invoking the __Print()__ method, by default the Diagramming framework will name your printing job *"RadDiagram Print Document"* and it will set the __PageMargin__ to *15*.
			

### Print() Method Example

For the purpose of this tutorial we will try to print the sample Diagramming solution demonstrated in the [DataBinding]({%slug raddiagram-data-databinding%}) section of this documentation:

![raddiagrams populating with data data binding](images/raddiagrams_populating_with_data_data_binding.png)

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.
			  

Now let's add a Print __RadButton__ in our layout and handle its __Click__ event to invoke the __RadDiagram.Print()__ method:
			
#### __XAML__
    <Grid x:Name="LayoutRoot">
        <Grid.Resources>
          ...
        </Grid.Resources>
        <Grid.RowDefinitions>
            <RowDefinition Height="50" />
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>
        <telerik:RadButton Content="Print" Click="Print" HorizontalAlignment="Center" VerticalAlignment="Center"/>
        <telerik:RadDiagram x:Name="diagram" Grid.Row="1"
                            ConnectionStyle="{StaticResource pascalEdgeStyle}"
                            ShapeStyle="{StaticResource pascalNodeStyle}" />
    </Grid>				  


#### __C#__
    private void Print(object sender, RoutedEventArgs e)
    {
        this.diagram.Print();
    }				  


#### __VB.NET__
    Private Sub Print(sender As Object, e As RoutedEventArgs)
        Me.diagram.Print()
    End Sub				  


Now if you run your solution and hit the *Print* button:
![Rad Diagram Features Printing Print](images/RadDiagram_Features_Printing_Print.png)

A PrintDialog will be opened, allowing you to set up the printing operation:

![Rad Diagram Features Printing Print Dialog](images/RadDiagram_Features_Printing_PrintDialog.png)

### Print Command

Telerik Diagramming Framework provides a __Print__ command as well. It is part of the __DiagramExtensionCommands__ class implementation defined in the __Telerik.Windows.Controls.Diagrams.Extensions__ namespace and  you can apply it on your buttons and use it to invoke the print dialog:
			

#### __XAML__
    <telerik:RadButton xmlns:extensions="clr-namespace:Telerik.Windows.Controls.Diagrams.Extensions;assembly=Telerik.Windows.Controls.Diagrams.Extensions"
					Content="Print" 
					Command="extensions:DiagramExtensionCommands.Print" 
					CommandTarget="{Binding ElementName=diagram}" 
					HorizontalAlignment="Center" 
					VerticalAlignment="Center"/>			  

>You need to keep in mind that the __Print__ command can only be executed on a __RadDiagram__, populated with __DiagramItems__.
			

## Pages Preview Canvas

With the Q1 2013 release, __RadDiagram__ supports pages preview canvas. The pages background is enabled by default but you can control its visibility and appearance through the following set of attached properties:
		

* __BackgroundPageGrid.IsGridVisible__ - this is a __Boolean__ property that controls the visibility of the page preview canvas. Its default value is __True__.
			

* __BackgroundPageGrid.PageSize__ - this property is of type __Size__ and it determines the size that describes a single page in the __RadDiagram__ surface. The default value of the property is a size of 1092x763 units - the size of an A4 page format.
			

* __BackgroundPageGrid.LineStroke__ - this property is of type __Brush__ and it specifies how the pages outline is painted.
			

* __BackgroundPageGrid.LineStrokeDashArray__ - this property gets or sets a collection of __Double__ values that indicate the pattern of dashes and gaps that is used to outline the pages.
			

* __BackgroundPageGrid.LineStrokeThickness__ - this property is of type __double__ and it gets or sets the thickness of the lines that visualize the pages.
			

>tipThe __BackgroundPageGrid__ attached properties are defined in the __Telerik.Windows.Controls.Diagrams.Primitives__ namespace. This is why in order to use them you need to add a using statement for that namespace in code-behind or define an alias in XAML:

#### __XAML__ 
    xmlns:primitives="clr-namespace:Telerik.Windows.Controls.Diagrams.Primitives;assembly=Telerik.Windows.Controls.Diagrams".
		  

The default look and size of the page preview canvas is demonstrated in the next snapshot:
		

The PagesPreview canvas in a zoomed RadDiagram

![Rad Diagram Features Zoomed Pages](images/RadDiagram_Features_ZoomedPages.png)

And in order to modify it, you can change some or all of the previously described properties: 

#### __XAML__
    <telerik:RadDiagram primitives:BackgroundPageGrid.LineStroke="Red"
                        primitives:BackgroundPageGrid.LineStrokeDashArray="2 2"
                        primitives:BackgroundPageGrid.LineStrokeThickness="4"
                        primitives:BackgroundPageGrid.PageSize="200 200"/>		  

Customized PagesPreview canvas

![Rad Diagram Features Custom Pages](images/RadDiagram_Features_CustomPages.png)

>tipThe __RadDiagram__ exposes an __IsBackgroundSurfaceVisible__ property that determines the visibility of the background surface and the pages preview canvas at the same time. It is important to have this in mind when considering whether to set the __IsBackgroundSurfaceVisible__ to __False__.