---
title: Keyboard Support
page_title: Keyboard Support
description: Keyboard Support
slug: radpropertygrid-features-keyboard-support
tags: keyboard,support
published: True
position: 12
---

# Keyboard Support

RadPropertyGrid  allows you to navigate through the items without using the mouse. The keyboard can entirely replace the mouse by allowing you to perform navigation and editing.

>Please note that the keyboard navigation is supported only when RadpropertyGrid's property - RenderMode is set to Flat.

Here is the list of the keys that are supported:

* __Tab / Shift + Tab__ - navigates through the items.

* __Ctrl + Shift + O__ - sorts by OrderIndex and DisplayName.

* __Ctrl + Shift + C__ - groups by GroupName.

* __Ctrl + Shift + Space__ - expands the field that represents the current property definition.

* __Ctrl + End__ - moves to the last field.

* __Ctrl + Home__ - moves to the first field.

* __PageDown__ - moves a page down.

* __PageUp__ - moves a page up.

## Custom Keyboard Command Provider

RadPropertyGrid provides an easy MVVM-friendly approach for customization of its default commands logic. If you want to modify the way RadPropertyGrid handles a particular key, you could create your own custom command provider and predefine the behaviour for that key.

The approach for accomplishing the purpose is to create a separate class, inherit __PropertyGridCommandProvider__ and override the __ProvideCommandsForKey(KeyEventArgs args)__ method. In this way, only the undesired behavior can be adjusted according to your requirements.

The class responsible for customizing the keyboard navigation should be similar to the one below:

#### __[C#] Example 1: Creating custom command provider__

	{{region cs-radpropertygrid-features-keyboard-support_1}}
	public class CustomKeyboardCommandProvider : PropertyGridCommandProvider
	{
	    public CustomKeyboardCommandProvider()
	        : base(null)
	    {
	    }
	    public CustomKeyboardCommandProvider(RadPropertyGrid propertyGrid)
	        : base(propertyGrid)
	    {
	        this.PropertyGrid = propertyGrid;
	    }
	    public override List<DelegateCommandWrapper> ProvideCommandsForKey(KeyEventArgs args)
	    {
	        List<DelegateCommandWrapper> actionsToExecute = base.ProvideCommandsForKey(args);
	        if (args.Key == Key.Tab)
	        {
	            actionsToExecute.Clear();
	            actionsToExecute.Add(new PropertyGridDelegateCommandWrapper(RadPropertyGridCommands.MoveToNext, this.PropertyGrid));
	            if (!this.PropertyGrid.SelectedPropertyDefinition.IsExpanded)
	            {
	                actionsToExecute.Add(new PropertyGridDelegateCommandWrapper(RadPropertyGridCommands.ExpandCurrentField, this.PropertyGrid));
	            }
	        }
	        if (args.Key == Key.Tab && Keyboard.Modifiers == ModifierKeys.Shift)
	        {
	            actionsToExecute.Clear();
	            actionsToExecute.Add(new PropertyGridDelegateCommandWrapper(RadPropertyGridCommands.MoveToPrevious, this.PropertyGrid));
	            if (!this.PropertyGrid.SelectedPropertyDefinition.IsExpanded)
	            {
	                actionsToExecute.Add(new PropertyGridDelegateCommandWrapper(RadPropertyGridCommands.ExpandCurrentField, this.PropertyGrid));
	            }
	        }
	        return actionsToExecute;
	    }
	}
{{endregion}}

#### __[VB.NET] Example 1: Creating custom command provider__

	{{region vb-radpropertygrid-features-keyboard-support_1}}
	Public Class CustomKeyboardCommandProvider
	    Inherits PropertyGridCommandProvider
	    Public Sub New()
	        MyBase.New(Nothing)
	    End Sub
	    Public Sub New(ByVal propertyGrid As RadPropertyGrid)
	        MyBase.New(propertyGrid)
	        Me.PropertyGrid = propertyGrid
	    End Sub
	    Public Overrides Function ProvideCommandsForKey(ByVal args As KeyEventArgs) As List(Of DelegateCommandWrapper)
	        Dim actionsToExecute As List(Of DelegateCommandWrapper) = MyBase.ProvideCommandsForKey(args)
	        If args.Key = Key.Tab Then
	            actionsToExecute.Clear()
	            actionsToExecute.Add(New PropertyGridDelegateCommandWrapper(RadPropertyGridCommands.MoveToNext, Me.PropertyGrid))
	            If Not Me.PropertyGrid.SelectedPropertyDefinition.IsExpanded Then
	                actionsToExecute.Add(New PropertyGridDelegateCommandWrapper(RadPropertyGridCommands.ExpandCurrentField, Me.PropertyGrid))
	            End If
	        End If
	        If args.Key = Key.Tab AndAlso Keyboard.Modifiers = ModifierKeys.Shift Then
	            actionsToExecute.Clear()
	            actionsToExecute.Add(New PropertyGridDelegateCommandWrapper(RadPropertyGridCommands.MoveToPrevious, Me.PropertyGrid))
	            If Not Me.PropertyGrid.SelectedPropertyDefinition.IsExpanded Then
	                actionsToExecute.Add(New PropertyGridDelegateCommandWrapper(RadPropertyGridCommands.ExpandCurrentField, Me.PropertyGrid))
	            End If
	        End If
	        Return actionsToExecute
	    End Function
	End Class
{{endregion}}

Following up the code-snippet above, a press of Tab/ Shift + Tab keys will result in moving the focus to the property field above/ below and expanding it if possible. However, do not forget to remove the predefined commands for that particular key by calling the Clear() method.

The last thing to be done is to set CommandProvider Property of the RadPropertyGrid to be the newly-created CustomKeyboardCommandProvider class:

#### __[XAML]Example 2: Defining the custom command provider in XAML__

	{{region xaml-radpropertygrid-features-keyboard-support_0}}
	<telerik:RadPropertyGrid x:Name="RadPropertyGrid">
	    <telerik:RadPropertyGrid.CommandProvider>
	        <my:CustomKeyboardCommandProvider PropertyGrid="{Binding ElementName=PropertyGrid1}" />
	    </telerik:RadPropertyGrid.CommandProvider>
	</telerik:RadPropertyGrid>
{{endregion}}

#### __[C#] Example 3: Set the custom command provider to RadPropertyGrid__

	{{region cs-radpropertygrid-features-keyboard-support_2}}
	this.RadPropertyGrid.CommandProvider = new CustomKeyboardCommandProvider(this.RadPropertyGrid);
{{endregion}}

#### __[VB.NET] Example 3: Set the custom command provider to RadPropertyGrid__

	{{region vb-radpropertygrid-features-keyboard-support_2}}
	Me.RadPropertyGrid.CommandProvider = New CustomKeyboardCommandProvider
{{endregion}}

## Disabling Navigation

As of __Q1 2015__ PropertyGridCommandProvider exposes a new property: __EnableBuiltInNavigation__. By default its value is set to "True". In order to disable the navigation which comes from "Flat" RenderMode, you can set its value to "False".

#### __[C#] Example 4: Disabling navigation__

	{{region cs-radpropertygrid-features-keyboard-support_3}}
	public class CustomKeyboardCommandProviderWithoutNavigation : PropertyGridCommandProvider
	{
	    public CustomKeyboardCommandProviderWithoutNavigation()
	        : base(null)
	    {
	    }
	    public CustomKeyboardCommandProviderWithoutNavigation(RadPropertyGrid propertyGrid)
	        : base(propertyGrid)
	    {
	        this.PropertyGrid = propertyGrid;
	        this.EnableBuiltInNavigation = false;
	    }
	}
{{endregion}}

#### __[VB.NET] Example 4: Disabling navigation__

	{{region vb-radpropertygrid-features-keyboard-support_3}}
	Public Class CustomKeyboardCommandProviderWithoutNavigation
	    Inherits PropertyGridCommandProvider
	    Public Sub New()
	        MyBase.New(Nothing)
	    End Sub
	    Public Sub New(ByVal propertyGrid As RadPropertyGrid)
	        MyBase.New(propertyGrid)
	        Me.PropertyGrid = propertyGrid
	        Me.EnableBuiltInNavigation = False
	    End Sub
	End Class
{{endregion}}

## See Also

 * [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%})

 * [Edit Modes]({%slug radpropertygrid-edit-modes%})
