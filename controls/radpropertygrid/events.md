---
title: Events
page_title: Events
description: This article lists and explains the events exposed by the RadPropertyGrid control.
slug: radpropertygrid-events
tags: events
published: True
position: 4
---

# Events

This article provides more detailed information about the events exposed by the __RadPropertyGrid__ control. As it inherits from the **Control** class, it also inherits all of its public events. A full list of the inherited events can be found [here](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.control#events). 

In addition, the __RadPropertyGrid__ control raises the following specific events:


* **Filtering**: Occurs when filtering RadPropertyGrid. Through the **PropertyGridFilteringEventArgs**, you can access the following properties:

	* **Cancel**: A boolean value indicating whether the event should be canceled.

        #### __[C#] Example 1: Filtering event__
        {{region cs-propertygrid-events_0}}
            private void PropertyGrid_Filtering(object sender, Telerik.Windows.Controls.Data.PropertyGrid.PropertyGridFilteringEventArgs e)
            {
                e.Cancel = true;
            }
        {{endregion}}
	
	* **FilterText**: The value that has been typed in the search TextBox.

* **Filtered**: Occurs after filtering is applied to RadPropertyGrid. Does not get fired if the **Filtering** event is canceled.


* **ItemChanged**: Occurs when an item gets changed. Through the **PropertyGridItemChangedEventArgs**, you can access the following properties:

    * **NewItem**: Gets or sets the new item.
	
	* **OldItem**: Gets or sets the old item.
    
    * **ShouldUpdateContent**: Gets or sets a boolean value that indicates whether the change of the item should force an update on the list of property definitions.


* **AutoGeneratingPropertyDefinition**: Occurs when a property definition is being generated. Through the **AutoGeneratingPropertyDefinitionEventArgs**, you can access the **PropertyDefinition** property which is of type [PropertyDefinition](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.data.propertygrid.propertydefinition). It gets or sets the property definition for each of the properties. You may edit the following properties of each property definition:

	* **Binding**: Points to the data member to display/edit in the field.
	
	* **Description**: The description of a property.
	
	* **DisplayName**: The displayed name.
	
	* **EditorTemplate**: The DataTemplate for the editor of the property. If left unset, a default editor will be generated.
	
	* **GroupName**: The group name used to organize properties in categories.
	
	* **HasNestedProperties**: Indicates whether this property definition has nested property definitions.
	
	* **NestedProperties**: The collection of nested properties.
	
	* **OrderIndex**: The index of the order.
	
	* **ParentProperty**: The parent property of this property definition.


* **BeginningEdit**: Occurs when a new edit operation is initiated. Through the **PropertyGridBeginningEditEventArgs**, you can access the **Field** property which is of type [PropertyGridField](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.data.propertygrid.propertygridfield). It gets or sets the field of the current context.

    #### __[C#] Example 2: BeginningEdit event__

    {{region cs-propertygrid-events_1}}
        private void PropertyGrid_BeginningEdit(object sender, Telerik.Windows.Controls.Data.PropertyGrid.PropertyGridBeginningEditEventArgs e)
        {
            e.Field.Content = "Test";
        }
    {{endregion}}

    >The **BeginningEdit** event is raised only if the [EditMode](https://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/edit-modes) property of the **RadPropertyGrid** is set to **Single**. 


* **EditEnded**: Occurs when an edit operation is finished. Through the **PropertyGridEditEndedEventArgs**, you can access the following properties:
    * **EditAction**: Gets the edit action. It is of type [PropertyGridEditEndedAction](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.data.propertygrid.propertygrideditendedaction) and has a **Cancel** and **Commit** actions.

    #### __[C#] Example 3: EditEnded event__
    {{region cs-propertygrid-events_2}}
        private void PropertyGrid_EditEnded(object sender,Telerik.Windows.Controls.Data.PropertyGrid.PropertyGridEditEndedEventArgs e)
        {
            if (e.EditAction ==       Telerik.Windows.Controls.Data.PropertyGrid.PropertyGridEditEndedAction.Commit)
            {
                // submit changes to database
            }
        }
    {{endregion}}

    * **Field**: Gets or sets the field. It is of type [PropertyGridField](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.data.propertygrid.propertygridfield).

    * **OldValue**: Gets the old value.
    
    * **NewValue**: Gets the new value.

    >The **EditEnded** event is raised only if the [EditMode](https://docs.telerik.com/devtools/wpf/controls/radpropertygrid/features/edit-modes) property of the **RadPropertyGrid** is set to **Single**. 


* **Validating**: Occurs when new content is about to be committed. Through the **PropertyGridValidatingEventArgs**, you can access the following properties:
    * **Field**: Gets or sets the field of the current context. 

    * **IsValid**: Gets or sets a boolean value that indicates whether the changes are valid.

    * **ValidationResults**: Gets a collection of validation results which contain а user-friendly message.


* **Validated**: Occurs when new content is committed. Through the **PropertyGridValidatedEventArgs**, you can access the following properties:
    * **Field**: Gets or sets the field of the current context.

    * **ValidationResults**: Gets a collection of validation results which contain а user-friendly message.


* **PreparedEditor**: Occurs when the field editor gets prepared. Through the **PropertyGridPreparedEditorEventHandler**, you can access the following properties:
    * **Field**: Gets or sets the field of the current context.

    * **Editor**: Gets or sets the editor of the current context.


* **FieldLoaded**: Occurs when a new field is loaded. Through the **FieldEventArgs**, you can access the **Field** property which gets or sets the field of the current context.


* **Sorted**: Occurs after the property definitions are sorted alphabetically by clicking the [Sort button](https://docs.telerik.com/devtools/wpf/controls/radpropertygrid/visualstructure).


* **Grouped**: Occurs after the property definitions are grouped alphabetically by clicking the [Group button](https://docs.telerik.com/devtools/wpf/controls/radpropertygrid/visualstructure).


* **SelectionChanged**: Occurs when the selected property definition has changed. Through the **SelectionChangeEventArgs**, you can access the following properties:
    * **RemovedItems**: Gets a list that contains the items that were unselected.

    * **AddedItems**: Gets a list that contains the items that were selected.

    >Both properties are of type **ReadOnlyCollection**.

* **PropertySetValueChanged**: This event occurs when the value of a property from the PropertySet is changed. Through the **PropertySetValueChangedEventArgs**, you can access the following properties:	
	* **Items**: Gets a list that contains the items which properties have been changed.
	* **PropertyName**: A property of type string that gets or sets the name of the property.
	* **Value**: A property of type object that gets or sets the name of the property.
	
#### __[C#] Example 4: PropertySetValueChanged event__
    {{region cs-propertygrid-events_3}}
        private void RadPropertyGrid_PropertySetValueChanged(object sender, Telerik.Windows.Controls.Data.PropertyGrid.PropertySetValueChangedEventArgs e)
        {
            var items = e.Items;
            var name = e.PropertyName;
            var newValue = e.Value;
        }
    {{endregion}}

  >The **PropertySetValueChanged** event is raised only if the [PropertySetMode]({%slug radpropertygrid-defining-propertysets%}) property of the **RadPropertyGrid** is set to **Union** or **Intersection**.
	
## See Also

 * [Getting Started]({%slug radpropertygrid-getting-started-getting-started%})

 * [Styles and Templates]({%slug radpropertygrid-styles-and-templates-overview%})

 * [Autogenerated Property Definitions]({%slug radpropertygrid-getting-started-autogenerated-property-definitions%})
