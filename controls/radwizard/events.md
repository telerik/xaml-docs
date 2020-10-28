---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadWizard {{ site.framework_name }} control.
slug: wizard-events
tags: events
published: True
position: 3
---

# Events

This article lists the events specific to RadWizard control. 

## Selection events:

* __SelectionChanging__: Occurs when the selected page is about to be changed. The type of the passed event arguments is __SelectedPageChangingEventArgs__. Through this class, you can access the following properties:

	* __Cancel__: A boolean property that enables the cancellation of the selection.
	* __Direction__: A property, which gets the direction in which the user is navigating to. There are two possible directions specifying in which direction a user navigates between pages ___“Forward”___ and ___“Backward”___.
	* __OldPage__: A __WizardPage__ property, which gets the current selected wizard page.
	* __NewPage__: A __WizardPage__ property, which gets the wizard page to be selected.

#### __[C#] Example 1: Subscribe to SelectionChanging Events__  
{{region csharp-wizard-events_0}}
	private void wizard_SelectionChanging(object sender, SelectedPageChangingEventArgs e)
	{
		var cancel = e.Cancel;
		var selectionDirection = e.Direction;
		var newPage = e.NewPage;
		var oldPage = e.OldPage;
	}
{{endregion}}
	
* __SelectionChanged__: Occurs when the selected page has changed. The type of the passed event arguments is __SelectedPageChangedEventArgs__. Through this class, you can access the following properties:

	* __Direction__: An enumeration property, which gets the direction in which the user is navigating to. There are two possible directions specifying in which direction the user navigates between pages ___“Forward”___ and ___“Backward”___.
	* __OldPage__: A __WizardPage__ property, which gets the current selected wizard page.
	* __NewPage__: A __WizardPage__ property, which gets the wizard page to be selected.

#### __[C#] Example 2: Subscribe to SelectionChanged Events__  
{{region csharp-wizard-events_1}}
	private void wizard_SelectionChanged(object sender, SelectedPageChangedEventArgs e)
	{
		var selectionDirection = e.Direction;
		var newPage = e.NewPage;
		var oldPage = e.OldPage;
	}
{{endregion}}
	
## Navigation buttons events 

All of the event handlers for these events receive two arguments and are executed per wizard page. The sender argument contains __RadWizard__. This argument is of type object, but can be cast to the __RadWizard__ type. A __NavigationButtonsEventArgs__ object. This object has the __SelectedPageIndex__ property, which is used to get or set the selected page index.
	
* __Previous__: Occurs when the __Previous__ button has been clicked.
* __Next__: Occurs when the __Next__ button has been clicked.
* __Finish__: Occurs when the __Finish__ button has been clicked.
* __Help__: Occurs when the __Help__ button has been clicked.
* __Cancel__: Occurs when the __Cancel__ button has been clicked.

#### __[C#] Example 3: Navigation buttons event handlers__  
{{region csharp-wizard-events_2}}
	private void wizard_Previous(object sender, NavigationButtonsEventArgs e)
	{
		var selectedPageIndex = e.SelectedPageIndex;
	}

	private void wizard_Next(object sender, NavigationButtonsEventArgs e)
	{
		var selectedPageIndex = e.SelectedPageIndex;
	}

	private void wizard_Finish(object sender, NavigationButtonsEventArgs e)
	{
		var selectedPageIndex = e.SelectedPageIndex;
	}

	private void wizard_Help(object sender, NavigationButtonsEventArgs e)
	{
		var selectedPageIndex = e.SelectedPageIndex;
	}

	private void wizard_Cancel(object sender, NavigationButtonsEventArgs e)
	{
		var selectedPageIndex = e.SelectedPageIndex;
	}	
{{endregion}}
	
## Other events:

* __PageLoaded__: Occurs when a new page is loaded. The __PageEventArgs__ class exposes the __Page__ property, which gets the currently loaded page in the wizard.

* __Completing__: Occurs when the operation is about to be completed. The __WizardCompletingEventArgs__ class exposes the following specific properties:

	* __Cancel__: A boolean property that enables the cancellation of the finish operation.
	* __SelectedPage__: A __WizardPage__ property, which gets the page from which it was invoked.
	* __Action__: A property, which gets the action which will be performed. There are two possible actions ___“Abort”___ and ___“Finish”___. The __Action__ property will be with value ___“Abort”___ when the user has clicked the __Cancel__ button and ___“Finish”___ when the __Finish__ button is clicked.
	
#### __[C#] Example 4: Subscribe to Completing Event__  
{{region csharp-wizard-events_3}}
	private void wizard_Completing(object sender, WizardCompletingEventArgs e)
	{
		var cancel = e.Cancel;
		var action = e.Action;
		var selectedPage = e.SelectedPage;
	}
{{endregion}}	
	
* __Completed__: Occurs when the wizard has already finish. The	 __WizardCompletedEventArgs__ class exposes the following specific properties:

	* __SelectedPage__ - a __WizardPage__ property, which gets the page from which it was invoked.
	* __Action__ -an enumeration property, which gets the action which was performed. There are two possible actions ___“Abort”___ and ___“Finish”___. The __Action__ property will be with value ___“Abort”___ when the user had clicked the __Cancel__ button and ___“Finish”___ when the __Finish__ button was clicked.
	
#### __[C#] Example 5: Subscribe to Completed Event__  
{{region csharp-wizard-events_3}}
	private void wizard_Completed(object sender, WizardCompletedEventArgs e)
	{
		var action = e.Action;
		var selectedPage = e.SelectedPage;
	}
{{endregion}}	
	
## See Also  
 * [Getting Started]({%slug carousel-getting-started%})
	