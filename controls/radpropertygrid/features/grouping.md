---
title: Grouping Support
page_title: Grouping Support
description: Grouping Support
slug: radpropertygrid-grouping
tags: grouping,support
published: True
position: 13
---

# Grouping Support



RadPropertyGrid supports grouping. Its __IsGrouped__ property controls the current RadPropertyGrid's state. You can set it to __true__ and you will have RadPropertyGrid __initially grouped__. If you set it to __false__, then you will have RadProperty __sorted__. By default the control is shown as sorted.
      

>Please note all the groups will be auto expanded. In case you want to initially collapse a group, you can do this once RadPropertyGrid is loaded using a Dispatcher. Please refer to the [Expand/Collapse Groups](#expandcollapse-groups) section below.
        

Another property you can configure is __SortAndGroupButtonsVisibility__. It sets the visibility mode of the sort and group buttons. By default the buttons will be visible.
      

For example, lets have the following declaration of the RadPropertyGrid control:
      

#### [XAML]Example 1: Declaring RadPropertyGrid

{{region radpropertygrid-grouping_0}}

	<telerik:RadPropertyGrid Grid.Row="0" x:Name="PropertyGrid1"
	                                  RenderMode="Flat"
	                                  AutoGeneratePropertyDefinitions="False"
	                                  IsGrouped="True">
	  <telerik:RadPropertyGrid.PropertyDefinitions>
	    <telerik:PropertyDefinition Binding="{Binding FirstName}" GroupName="Group Name" DisplayName="First Name"/>
	    <telerik:PropertyDefinition Binding="{Binding LastName}" GroupName="Group Name" DisplayName="Last Name"/>
	    <telerik:PropertyDefinition Binding="{Binding Title}" GroupName="Group Title" DisplayName="Title"/>
	    <telerik:PropertyDefinition Binding="{Binding HomePhone}" GroupName="Group Phone" DisplayName="HomePhone"/>
	  </telerik:RadPropertyGrid.PropertyDefinitions>
	</telerik:RadPropertyGrid>
{{endregion}}



Its Item is set like so:
      

#### [C#]Example 2: Setting RadPropertyGrid Item

{{region radpropertygrid-grouping_0}}

	Employee Employee = new Employee()
	{
	    FirstName = "Nancy",
	    LastName = "Davolio",
	    Title = "Sales Representative",
	    HomePhone = "(206) 555-9857"
	};
	this.PropertyGrid1.Item = Employee;
	
{{endregion}}



Now, if you run your application, you will see this result:

![Rad Property Grid Grouping](images/RadPropertyGrid_Grouping.png)

## Expand/Collapse Groups

The user can control the group state from the UI.
        

He can also collapse and expand groups in RadPropertyGrid in code using its methods:
        

* __ExpandGroup(object GroupKey)__ - sets expand state for the given GroupDefinition
            

#### [C#]Example 3: Expanding RadPropertyGrid Group

	{{region radpropertygrid-grouping_1}}
	this.PropertyGrid1.ExpandGroup("Group Name");
	{{endregion}}



* __CollapseGroup(object GroupKey)__ - collapses the visual group for the given GroupDefinition
            

#### [C#]Example 4: Collapsing RadPropertyGrid Group

{{region radpropertygrid-grouping_2}}

	this.PropertyGrid1.CollapseGroup("Group Name");
{{endregion}}



* __ExpandAllGroups()__ - expands all groups recursively
            

#### [C#] Example 5: Expanding all RadPropertyGrid Groups

{{region radpropertygrid-grouping_3}}

	this.PropertyGrid1.ExpandAllGroups();
{{endregion}}



* __CollapseAllGroups()__ - collapses all groups recursively.
            

#### [C#] Example 6: Collapsing all RadPropertyGrid Groups

{{region radpropertygrid-grouping_4}}

	this.PropertyGrid1.CollapseAllGroups();
{{endregion}}



>importantYou need to set __RenderMode="Flat"__ in order to be able to execute the methods above. For more information check [Layout Rendering Modes]({%slug radpropertygrid-features-layout-rendering-modes%}).
          

## GroupDefinitions

The GroupDefinitions property gets a collection of GroupDefinition objects used to group RadPropertyGrid.
        

It has two methods:

* __SuspendNotifications()__ - suspends the notifications
            

* __ResumeNotifications()__ - resumes the notifications.
            

#### [C#]Example 7: Suspending and Resuming notifications

{{region radpropertygrid-grouping_5}}

	this.PropertyGrid1.GroupDefinitions.SuspendNotifications();
	
	// Execute additional logic
	
	this.PropertyGrid1.GroupDefinitions.ResumeNotifications();
{{endregion}}



>importantYou need to set __RenderMode="Flat"__ in order to be able to work with the GroupDefinitions collection. For more information check [Layout Rendering Modes]({%slug radpropertygrid-features-layout-rendering-modes%}).
          

# See Also

 * [Getting Started with RadPropertyGrid]({%slug radpropertygrid-getting-started-getting-started%})

 * [Edit Modes]({%slug radpropertygrid-edit-modes%})

 * [Scrolling into View]({%slug radpropertygrid-scrolling%})
