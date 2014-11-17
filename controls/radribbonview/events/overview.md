---
title: Events Overview
page_title: Events Overview
description: Events Overview
slug: radribbonview-events-overview
tags: events,overview
published: True
position: 0
---

# Events Overview



This topic covers the specific events exposed by the __RadRibbonView__ control and its sub elements. The events are first grouped by control and then by their general purpose.
			

## RadRibbonView

__RadRibbonView__ provides a couple of useful events that can be used for customization purposes.
				

* __ApplicationButtonDoubleClick__ - occurs when the user double clicks on the application button. The __ApplicationButtonDoubleClick__ event handler receives two arguments:
						

* The sender argument contains the __RadRibbonView__. This argument is of type __object__, but can be cast to the __RadRibbonView__ type.
							

* A __RadRoutedEventArgs__ object.
							

* __ApplicationMenuOpenStateChanged__ - occurs when the user opens or closes the __ApplicationMenu__. The __ApplicationMenuOpenStateChanged__ event handler receives two arguments:
						

* The sender argument contains the __RadRibbonView__. This argument is of type __object__, but can be cast to the __RadRibbonView__ type.
							

* A __RadRoutedEventArgs__ object.
							

* __ToolBarPositionChanged__ - occurs when the location of the toolbar has changed. The __ToolBarPositionChanged__ event handler receives two arguments:
						

* The sender argument contains the __RadRibbonView__. This argument is of type __object__, but can be cast to the __RadRibbonView__ type.
							

* A __RadRoutedEventArgs__ object.
							

* __HelpRequested__ - occurs when the user clicks on the help button. The __HelpRequested__ event handler receives two arguments:
						

* The sender argument contains the __RadRibbonView__. This argument is of type __object__, but can be cast to the __RadRibbonView__ type.
							

* A __RadRoutedEventArgs__ object.
							

* __CollapsedChanged__ - occurs when the ribbon bar collapsed state has changed. The __CollapsedChanged__ event handler receives two arguments:
						

* The sender argument contains the __RadRibbonView__. This argument is of type __object__, but can be cast to the __RadRibbonView__ type.
							

* A __RadRoutedEventArgs__ object.
							

## Selection

* __PreviewSelectionChanged__- occurs when the selected tab is going to be changed. The __PreviewSelectionChanged__ event handler receives two arguments:
						

* The sender argument contains the __RadRibbonView__. This argument is of type __object__, but can be cast to the __RadRibbonView__ type.
							

* The second argument is __RadSelectionChangedEventArgs__ containing all additional information about the event:
								

* __AddedItems__ - an __IList__ collection of the selected items
									

* __RemovedItems__ - an __IList__ collection of the unselected items
									

* __SelectionChanged__ - occurs when the selected tab has changed. The __SelectedTabChanged__ event handler receives two arguments:
						

>tipWhen a __RadRibbonTab__ is selected the lifecycle of the raised events is:<br/>* __PreviewSelectionChanged__<br/>* __SelectionChanged__

>tipYou could __cancel__ the selection process by setting the __RadSelectionChangedEventArgs__'s __Handled__ property to __True__ in the __PreviewSelectionChanged__ event handler.
				

>tipWhen your application is started the __PreviewSelectionChanged__ and __SelectionChanged__ events are always raised.
				

## Minimization

* The __MinimizedChanged__ event is raised when the the ribbon is changing its minimized state. The __MinimizedChanged__ event handler receives two arguments:
						

* The __sender__ argument contains the __RadRibbonView__. This argument is of type __object__, but can be cast to the __RadRibbonView__ type.
							

* A __Telerik.Windows.RadRoutedEventArgs__ object containing all the additional information about the event
							

* The __MinimizedPopupOpenStateChanged__ event is raised when the minimized popup changes its open state. The __MinimizedPopupOpenStateChanged__ event handler receives two arguments:
						

* The __sender__ argument contains the __RadRibbonView__. This argument is of type __object__, but can be cast to the __RadRibbonView__ type.
							

* A __Telerik.Windows.RadRoutedEventArgs__ object containing all the additional information about the event.
							

* The __PreviewPopupOpened__ event is raised when the minimized popup is about to be opened. The __PreviewPopupOpened__ event handler receives two arguments:
						

* The __sender__ argument contains the __RadRibbonView__. This argument is of type __object__, but can be cast to the __RadRibbonView__ type.
							

* A __Telerik.Windows.RadRoutedEventArgs__ object containing all the additional information about the event.
							

>tipYou can cancel the opening of the minimized popup by setting the __RadRoutedEventArgs__'s __Handled__ property to __True__.
						

* The __PopupOpened__ event is raised when the minimized popup changes its open state. The __PopupOpened__ event handler receives two arguments:
						

* The __sender__ argument contains the __RadRibbonView__. This argument is of type __object__, but can be cast to the __RadRibbonView__ type.
							

* A __Telerik.Windows.RadRoutedEventArgs__ object containing all the additional information about the event.
							

## RadGallery

* __ActivatePreview__ - occurs when the mouse cursor is over a gallery item. The __ActivatePreview__ event handler receives two arguments:
						

* The sender argument contains the __RadGallery__. This argument is of type __object__, but can be cast to the __RadGallery__ type.
							

* A __RadRoutedEventArgs__ object.
							

* __DeactivatePreview__- occurs when the mouse cursor leaves the gallery item. The __DeactivatePreview__ event handler receives two arguments:
						

* The sender argument contains the __RadGallery__. This argument is of type __object__, but can be cast to the __RadGallery__ type.
							

* A __RadRoutedEventArgs__ object.
							

>tipWhen a preview should be activated for a gallery item, the lifecycle of the raised events is:<br/>* __ActivatePreview__<br/>* __DeactivatePreview__

## RadRibbonGroup

* __LaunchDialog__- occurs when ribbon bar collapsed state has changed. The __LaunchDialog__ event handler receives two arguments:
						

* The sender argument contains the __RadRibbonGroup__. This argument is of type __object__, but can be cast to the __RadRibbonGroup__ type.
							

* A __RadRoutedEventArgs__ object.
							
