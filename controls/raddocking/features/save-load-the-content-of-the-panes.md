---
title: Save/Load the Content of the Panes
page_title: Save/Load the Content of the Panes
description: Save/Load the Content of the Panes
slug: raddocking-save-load-the-content-of-the-panes
tags: save/load,the,content,of,the,panes
publish: True
position: 11
---

# Save/Load the Content of the Panes



## 

This tutorial will walk you through the common tasks of saving the content of the panes.

__RadDocking__ cannot save the __Content__ of the panes itself. It only remembers the properties of the panes, the groups and the split containers and the way they are changed.

Tha Save/Load layout mechanism matches the __SerializationTag__of the saved pane with the __SerializationTag__of the pane that is already created. It works for the static panes, because when your application loads, the XAML parser creates correctly all the static panes and their contents. The dynamic panes are created by the __RadDocking__ control and it doesn't know what content to put in them.

For the purpose of this tutorial the following __RadDocking__ declaration will be used:

#### __XAML__

{{region raddocking-save-load-the-content-of-the-panes_0}}
	<telerik:RadDocking x:Name="radDocking">
	    <telerik:RadSplitContainer>
	        <telerik:RadPaneGroup x:Name="Group1"
	            telerik:RadDocking.SerializationTag="Group1">
	            <telerik:RadPane Header="static pane 1"
	                telerik:RadDocking.SerializationTag="staticpane1">
	                <TextBox Text="Some content" />
	            </telerik:RadPane>
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
	{{endregion}}






         
      ![](images/RadDocking_Features_SaveLoadPaneContent_010.png)

You can save the panes' content by handling the __ElementLoaded__event of the __RadDocking__ control and setting the content of the newly created pane yourself.

Attach to the __ElementLoaded__ event of the __RadDocking__ element.

#### __XAML__

{{region raddocking-save-load-the-content-of-the-panes_1}}
	<telerik:RadDocking x:Name="radDocking" ElementLoaded="radDocking_ElementLoaded">
	{{endregion}}



#### __C#__

{{region raddocking-save-load-the-content-of-the-panes_2}}
	private void radDocking_ElementLoaded( object sender, Telerik.Windows.Controls.LayoutSerializationLoadingEventArgs e )
	{
	    var pane = e.AffectedElement as RadPane;
	    if ( pane != null )
	    {
	        pane.Content = this.GetPaneContent( e.AffectedElementSerializationTag );
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region raddocking-save-load-the-content-of-the-panes_3}}
	    Private Sub radDocking_ElementLoaded(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.LayoutSerializationLoadingEventArgs)
	        Dim pane = TryCast(e.AffectedElement, RadPane)
	        If pane IsNot Nothing Then
	            pane.Content = Me.GetPaneContent(e.AffectedElementSerializationTag)
	        End If
	    End Sub
	{{endregion}}



>importantThe __GetPaneContent()__ method needs to be implemented with the specific user custom logic.
              

# See Also

 * [Save/Load Layout]({%slug raddocking-features-save-load-layout%})

 * [Drag and Drop]({%slug raddocking-features-drag-and-drop%})

 * [Compass]({%slug raddocking-features-compass%})
