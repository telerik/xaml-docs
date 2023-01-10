---
title: Commands
page_title: Commands
description: Check our &quot;Commands&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagrams-features-commands
tags: commands
published: True
position: 9
---

# {{ site.framework_name }} RadDiagram Commands

__RadDiagram__ provides a powerful set of __RoutedUICommands__ that help you work with your __RadDiagram__ and its Items easily and build better MVVM applications.	  

* [RadDiagram Commands](#raddiagram-commands)
* [ExtensionsCommands](#extensionscommands)
* [Using Diagram Commands](#using-diagram-commands)
* [Overriding Commands](#overriding-commands)

## RadDiagram Commands

The static __DiagramCommands__ class is located in __Telerik.Windows.Controls.Diagrams__ assembly and defines 22 RoutedUICommands:		

* __Align__ - Aligns the selected shapes.[(Read more)]({%slug raddiagrams-features-snap%})

* __Snap__ - Snaps the selected shapes.[(Read more)]({%slug raddiagrams-features-snap%})

* __AutoFit__ - Centers and zooms the diagram to display all items.			  

* __Layout__ - Organizes the diagram automatically.[(Read more)]({%slug raddiagram-features-diagram-layout%})

* __Copy__ - Copies selected diagram items.[(Read More)]({%slug raddiagrams-features-clipboard%})

* __Paste__ - Pastes selected diagram items.[(Read More)]({%slug raddiagrams-features-clipboard%})

* __Delete__ - Deletes selected diagram items.[(Read More)]({%slug raddiagrams-features-delete%})

* __Cut__ - Cut selected diagram items.[(Read More)]({%slug raddiagrams-features-clipboard%})

* __Duplicate__ - Duplicates selected item/s.			  

* __Undo__ - Undoes the last action.[(Read More)]({%slug raddiagrams-features-undo-redo%})

* __Redo__ - Redoes the last action.[(Read More)]({%slug raddiagrams-features-undo-redo%})

* __BringToFront__ - Brings to front selected diagram items.[(Read More)]({%slug raddiagrams-features-zorder%})

* __BringForward__ - Brings forward selected diagram items.[(Read More)]({%slug raddiagrams-features-zorder%})

* __SendToBack__ - Sends to back selected diagram items.[(Read More)]({%slug raddiagrams-features-zorder%})

* __SendBackward__ - Sends backward selected diagram items.[(Read More)]({%slug raddiagrams-features-zorder%})

* __Save__ - Saves the current diagram.[(Read More)]({%slug raddiagrams-features-serialization%})

* __Clear__ - Clears the diagram.[(Read More)]({%slug raddiagrams-features-delete%})

* __Open__ - Opens a saved diagram.[(Read More)]({%slug raddiagrams-features-serialization%})

* __BeginEdit__ - Begins editing diagram item.[(Read More)]({%slug raddiagrams-features-edit%})

* __CommitEdit__ - Commit the edited changes.[(Read More)]({%slug raddiagrams-features-edit%})

* __CancelEdit__ - Cancel the edited changes.[(Read More)]({%slug raddiagrams-features-edit%})

* __SelectAll__ - Selects all shapes in the diagram.[(Read More)]({%slug raddiagrams-features-selection%})

* __Nudge__ - Moves selected item/s in a specific direction. You can pass more specifics about the nudge operation through the __CommandParameter__. 
	This parameter can be a single string representing the direction of the nudge:
	* __"Left"__
	* __"Right"__
	* __"Up"__
	* __"Down"__
	It can also be a string in the form of __"direction; amount"__, the __'direction'__ being a value from the above list of direction strings. The __'amount'__ options are:
	* __"Small"__ - if the __RadDiagram IsSnapToGridEnabled__ property is set to __true__ then this amount would mean that the nudge should happen once to the appointed direction using the __SnapX/Y__ value as a step. The snap settings can be applied in the  __RadDiagram__ definition. If the __RadDiagram IsSnapToGridEnabled__ property is __false__, a __"Small"__ amount indicates a step of __5__ pixels;				  

	* __"Large"__ - if the __RadDiagram IsSnapToGridEnabled__ property is set to __true__ then this amount would mean that the nudge should happen once to the appointed direction using __5*SnapX/Y__ value as a step. The snap settings can be applied in the  __RadDiagram__ definition. If the __RadDiagram IsSnapToGridEnabled__ property is false, a __"Large"__ amount indicates a step of __10__ pixels;				  

	* __any number__ - if you provide a number in the __CommandParameter__, this number would indicate the number of pixels to be used as a step for the __Nudge__ command.				  

* __Group__ - Groups the selected items.[(Read More)]({%slug raddiagram-features-grouping%})

* __Ungroup__ - Ungroups the selected groups.[(Read More)]({%slug raddiagram-features-grouping%})

* __SwitchGridVisibility__ - Hides or shows the background grid.			  

* __Load__ - Loads a diagram.			  

* __Export__ - Exports a diagram.[(Read More)]({%slug raddiagram-features-image-export%})

## ExtensionsCommands	  

In the __Telerik.Windows.Controls.Diagrams.Extensions__ namespace you can find another set of commands described in the __ExtensionsCommands__ class. This class describes the __Print__ command that allows you to print a diagramming structure. You can use this command in XAML to print the content of a __RadDiagram__ instance as follows:		

#### __XAML__
{{region radiagram-commands_0}}
    <telerik:RadButton xmlns:extensions="clr-namespace:Telerik.Windows.Controls.Diagrams.Extensions;assembly=Telerik.Windows.Controls.Diagrams.Extensions"
					Content="Print" 
					Command="extensions:DiagramExtensionCommands.Print" 
					CommandTarget="{Binding ElementName=diagram}" 
					HorizontalAlignment="Center" 
					VerticalAlignment="Center"/>	
{{endregion}}

## Using Diagram Commands

A possible way to use __DiagramCommands__ in __XAML__ is to bind the __Command__ property of a __RadButton__ to a DiagramCommand and set the RadDiagram as a CommandTarget of the button:		

Below is shown how you can use some of the Diagram Commands in an application Note that this syntax is common for every Diagram Command.

#### __XAML__
{{region radiagram-commands_1}}
    <StackPanel Orientation="Horizontal" HorizontalAlignment="Center" x:Name="buttonsStack">
            <telerik:RadGeometryButton Height="55" Width="55" Command="telerik:DiagramCommands.AutoFit"
                    ToolTipService.ToolTip="Autofit" CommandTarget="{Binding ElementName=diagram}" Content="Autofit"
                    Foreground="Black"
                    Background="White"
                    Geometry="M8,0 L11,3 L9,3 L9,7 L13,7 L13,5 L16,8.1666641 L13,11 L13,9 L9,9 L9,13 L11,13 L8,16 L5,13 L7,13 L7,9 L3,9 L3,11 L0,7.9999971 L3,5 L3,7 L7,7 L7,3 L5,3 z" />
            <telerik:RadGeometryButton Height="55" Width="55" Command="telerik:DiagramCommands.Layout"
                    ToolTipService.ToolTip="Layout" CommandTarget="{Binding ElementName=diagram}" Content="Layout"
                    HorizontalContentAlignment="Stretch" VerticalContentAlignment="Stretch" Foreground="Black"
                    Background="White"
                    Geometry="M8.9999962,0 L12.999996,0 C14.104566,3.8743019E-07 14.999996,0.89543086 14.999996,2 L14.999996,5 C14.999996,6.1045694 14.104566,7 12.999996,7 L12,7 L12,9 L19,9 L19,11 L19,12 L20,12 C21.10457,12 22,12.895431 22,14 L22,17 C22,18.10457 21.10457,19 20,19 L16,19 C14.895432,19 14,18.10457 14,17 L14,14 C14,12.895431 14.895432,12 16,12 L17,12 L17,11 L5,11 L5,12 L6,12 C7.1045694,12 8,12.895431 8,14 L8,17 C8,18.10457 7.1045694,19 6,19 L2,19 C0.89543056,19 0,18.10457 0,17 L0,14 C0,12.895431 0.89543056,12 2,12 L3,12 L3,11 L3,9 L10,9 L10,7 L8.9999962,7 C7.8954268,7 6.9999962,6.1045694 6.9999962,5 L6.9999962,2 C6.9999962,0.89543086 7.8954268,3.8743019E-07 8.9999962,0 z" />
            <telerik:RadGeometryButton Height="55" Width="55" ToolTipService.ToolTip="Export As Png" Foreground="Black" Background="White" Content="Export" Command="telerik:DiagramCommands.Export"
                    CommandParameter="Png" CommandTarget="{Binding ElementName=diagram}"					
                    Geometry="M6.7093377,5.0820007 C10.505837,5.0813236 12.205385,8.5835428 13.709369,8.4989958 C15.616847,8.3917685 16.999527,6.8087606 16.999527,6.8087606 L17.000025,13.080002 L3.0000243,13.080002 L3.0000243,7.9753876 C3.0000243,7.9753876 4.842936,5.0823336 6.7093377,5.0820007 z M1.9999999,2.0000048 L1.9999999,13.999995 L18,13.999995 L18,2.0000048 z M1.1920929E-06,0 L20,0 L20,16 L0,16 z" />
        </StackPanel>
{{endregion}}

![raddiagram-features-commands](images/raddiagram-features-commands.png)

__Commands Parameters__

You can customize the functionality of the Delete, Export and Align Commands currently.		

* __Align__ - you can pass Top, Left, Right, Center, Middle, Bottom as CommandParameter.			  

* __Export__- you can pass Bmp or Png. The default export format is Png.			  

* __Delete__ - you can pass the item you wish to delete.			  

## Overriding Commands

You can see how to replace the default behavior of a command in the [Override Diagram Command]({%slug raddiagrams-howto-override-command%}) help article.

## See Also
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Keyboard Support]({%slug raddiagrams-features-shortcuts%})
 * [Selection]({%slug raddiagrams-features-selection%})
 * [Pan and Zoom]({%slug raddiagrams-features-pan-zoom%})
 * [Removing Items]({%slug raddiagrams-features-delete%})
 * [Clipboard Operations]({%slug raddiagrams-features-clipboard%})
 * [Align and Snap ]({%slug raddiagrams-features-snap%})
 * [Diagram Events]({%slug raddiagrams-events-diagram%})
 * [Items Events]({%slug raddiagrams-events-item%})