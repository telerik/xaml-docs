---
title: Keyboard Support
page_title: Keyboard Support
description: Check our &quot;Keyboard Support&quot; documentation article for the RadPropertyGrid {{ site.framework_name }} control.
slug: radpropertygrid-features-keyboard-support
tags: keyboard,support
published: True
position: 12
---

# Keyboard Support

RadPropertyGrid  allows you to navigate through the items without using the mouse. The keyboard can entirely replace the mouse by allowing you to perform navigation and editing.

>Please note that the keyboard navigation is supported only when RadPropertyGrid's property - __RenderMode__ is set to __Flat__.

Here is the list of the keys that are supported:

* __Tab / Shift + Tab__: Navigates through the items.

* __Ctrl + Shift + O__: Sorts by OrderIndex and DisplayName.

* __Ctrl + Shift + C__: Groups by GroupName.

* __Ctrl + Shift + Space__: Expands the field that represents the current property definition.

* __Ctrl + End__: Moves to the last field.

* __Ctrl + Home__: Moves to the first field.

* __PageDown__: Moves a page down.

* __PageUp__: Moves a page up.

## Custom Keyboard Command Provider

RadPropertyGrid provides an easy MVVM-friendly approach for customization of its default commands logic. If you want to modify the way RadPropertyGrid handles a particular key, you could create your own custom command provider and predefine the behaviour for that key.

The approach for accomplishing the purpose is to create a separate class, inherit __PropertyGridCommandProvider__ and override the __ProvideCommandsForKey(KeyEventArgs args)__ method. In this way, only the undesired behavior can be adjusted according to your requirements.

The class responsible for customizing the keyboard navigation should be similar to the one below:

#### __[C#] Example 1: Creating custom command provider__

	{{region cs-radpropertygrid-features-keyboard-support_0}}
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

	{{region xaml-radpropertygrid-features-keyboard-support_2}}
	<telerik:RadPropertyGrid x:Name="RadPropertyGrid">
	    <telerik:RadPropertyGrid.CommandProvider>
	        <my:CustomKeyboardCommandProvider PropertyGrid="{Binding ElementName=PropertyGrid1}" />
	    </telerik:RadPropertyGrid.CommandProvider>
	</telerik:RadPropertyGrid>
{{endregion}}

#### __[C#] Example 3: Set the custom command provider to RadPropertyGrid__

	{{region cs-radpropertygrid-features-keyboard-support_3}}
	this.RadPropertyGrid.CommandProvider = new CustomKeyboardCommandProvider(this.RadPropertyGrid);
{{endregion}}

#### __[VB.NET] Example 3: Set the custom command provider to RadPropertyGrid__

	{{region vb-radpropertygrid-features-keyboard-support_4}}
	Me.RadPropertyGrid.CommandProvider = New CustomKeyboardCommandProvider
{{endregion}}

## Text Search Navigation

With the __R2 2020__ release, the __RadPropertyGrid__ allows you to navigate to a specific property by pressing its first letter from the keyboard or starting to type the first couple letters from its name. This functionality is disabled by default. To enable it you need to set the __IsTextSearchEnabled__ property to __true__.

> Searching for a property by typing its first letter requires the __RadPropertyGrid control to be focused__.

#### __[XAML]Example 4: Enabling keyboard search navigation__

	{{region xaml-radpropertygrid-features-keyboard-support_5}}
	<telerik:RadPropertyGrid x:Name="RadPropertyGrid" IsTextSearchEnabled="True"/>
{{endregion}}

### Text Search Mode

When the user searches for a property by pressing a letter from the keyboard, the control will select the first property, which starts with the typed letter. This is the default behavior of the text search functionality. This behavior is controlled from the __TextSearchMode__ property of the RadPropertyGrid. The supported modes of this enumeration property are: __StartsWith and Contains__.

#### __[XAML]Example 5: Contains Text Search Mode__

	{{region xaml-radpropertygrid-features-keyboard-support_6}}
	<telerik:RadPropertyGrid x:Name="RadPropertyGrid" IsTextSearchEnabled="True" TextSearchMode="Contains"/>
{{endregion}}

### Text Searh With Case Sensitive

By default, text search navigation is case-insensitive. You can make your search case-sensitive by using the __IsTextSearchCaseSensitive__ property.

#### __[XAML]Example 6: Search with Case-Sensitive__

	{{region xaml-radpropertygrid-features-keyboard-support_7}}
	<telerik:RadPropertyGrid x:Name="RadPropertyGrid" IsTextSearchEnabled="True" TextSearchMode="Contains" IsTextSearchCaseSensitive="True"/>
{{endregion}}

### Text Search Timeout

In a scenario with a larger text for a property name, you may need to increase the time for typing more letters. The keyboard search text navigation functionality allows you to increase the timeout for resetting the typed text. This can be done through the __TextSearch.AutoCompleteTimeout__ static property of the RadPropertyGrid. This property is of type __TimeSpan__.

#### __[XAML]Example 8: Increase the timeout for resetting the typed text__

	{{region xaml-radpropertygrid-features-keyboard-support_9}}
	public MainWindow()
	{
		InitializeComponent();
		Telerik.Windows.Controls.TextSearch.AutoCompleteTimeout = new TimeSpan(1500);
	}
{{endregion}}

## Disabling Navigation

As of __Q1 2015__ PropertyGridCommandProvider exposes a new property: __EnableBuiltInNavigation__. By default its value is set to "True". In order to disable the navigation which comes from "Flat" RenderMode, you can set its value to "False".

#### __[C#] Example 10: Disabling navigation__

	{{region cs-radpropertygrid-features-keyboard-support_11}}
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

#### __[VB.NET] Example 10: Disabling navigation__

	{{region vb-radpropertygrid-features-keyboard-support_12}}
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
