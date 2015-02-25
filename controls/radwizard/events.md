---
title: Events
page_title: Events
description: Events
slug: wizard-events
tags: events
published: True
position: 3
---

# Events

## Selection events:
* __SelectionChanging__ - Occurs when the selected page is changing. The __SelectedPageChangingEventArgs__ class exposes the following specific properties:
	* __Cancel__ - a boolean property that enables the cancellation of the selection.
	* __Direction__ – a property, which gets the direction in which the user is navigating to. There are two possible directions specifying in which direction a user navigates between pages ___“Forward”___ and ___“Backward”___.
	* __OldPage__ - a __WizardPage__ property, which gets the current selected wizard page.
	* __NewPage__ - a __WizardPage__ property, which gets the wizard page to be selected.

* __SelectionChanged__ - Occurs when the selected page has changed. The __SelectedPageChangedEventArgs__ class exposes the following specific properties:
	* __Direction__ - an enumeration property, which gets the direction in which the user is navigating to. There are two possible directions specifying in which direction the user navigates between pages ___“Forward”___ and ___“Backward”___.
	* __OldPage__ - a __WizardPage__ property, which gets the current selected wizard page.
	* __NewPage__ - a __WizardPage__ property, which gets the wizard page to be selected.
	
## Navigation buttons events 
All of the event handlers for these events receive two arguments and are executed per wizard page. The sender argument contains __RadWizard__. This argument is of type object, but can be cast to the __RadWizard__ type. A __NavigationButtonsEventArgs__ object. This object has the __SelectedPageIndex__ property, which is used to get or set the selected page index.
	
* __Previous__ - Occurs when the __Previous__ button has been clicked.
* __Next__ - Occurs when the __Next__ button has been clicked.
* __Finish__ - Occurs when the __Finish__ button has been clicked.
* __Help__ - Occurs when the __Help__ button has been clicked.
* __Cancel__ - Occurs when the __Cancel__ button has been clicked.
	
## Other events:
* __PageLoaded__ - Occurs when a new page is loaded. The __PageEventArgs__ class exposes the __Page__ property, which gets the currently loaded page in the wizard.

* __Completing__ - Occurs when the operation is about to be completed. The	__WizardCompletingEventArgs__ class exposes the following specific properties:

	* __Cancel__ - a boolean property that enables the cancellation of the finish operation.
	* __SelectedPage__ - a __WizardPage__ property, which gets the page from which it was invoked.
	* __Action__ -a property, which gets the action which will be performed. There are two possible actions ___“Abort”___ and ___“Finish”___. The __Action__ property will be with value ___“Abort”___ when the user has clicked the __Cancel__ button and ___“Finish”___ when the __Finish__ button is clicked.
* __Completed__ - Occurs when the wizard has already finish. The	 __WizardCompletedEventArgs__ class exposes the following specific properties:
	* __SelectedPage__ - a __WizardPage__ property, which gets the page from which it was invoked.
	* __Action__ -an enumeration property, which gets the action which was performed. There are two possible actions ___“Abort”___ and ___“Finish”___. The __Action__ property will be with value ___“Abort”___ when the user had clicked the __Cancel__ button and ___“Finish”___ when the __Finish__ button was clicked.
