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



__RadPropertyGrid__  allows you to navigate through the items without using the mouse. The keyboard can entirely replace the mouse by allowing you to perform navigation and editing.
      

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

#### [C#]Example 1: Creating custom command provider

	{{region radpropertygrid-features-keyboard-support_1}}
	    class CustomKeyboardCommandProvider : PropertyGridCommandProvider
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



Following up the code-snippet above, a press of Tab/ Shift + Tab keys will result in moving the focus to the property field above/ below and expanding it if possible. However, do not forget to remove the predefined commands for that particular key by calling the Clear() method.

The last thing to be done is to set CommandProvider Property of the RadPropertyGrid to be the newly-created CustomKeyboardCommandProvider class:

#### [XAML]Example 2: Defining the custom command provider in XAML

	{{region radpropertygrid-features-keyboard-support_0}}
	  <telerik:RadPropertyGrid.CommandProvider>
	          <my:CustomKeyboardCommandProvider PropertyGrid="{Binding ElementName=PropertyGrid1}" />
	  </telerik:RadPropertyGrid.CommandProvider>
	{{endregion}}



#### [C#]Example 3: Set the custom command provider to RadPropertyGrid

	{{region radpropertygrid-features-keyboard-support_2}}
	    this.RadPropertyGrid.CommandProvider = new CustomKeyboardCommandProvider(this.RadPropertyGrid);
	{{endregion}}



# See Also

 * [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%})

 * [Edit Modes]({%slug radpropertygrid-edit-modes%})
