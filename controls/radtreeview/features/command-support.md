---
title: Command Support
page_title: Command Support
description: Check our Command Support documentation article for the RadTreeView {{ site.framework_name }} control.
slug: radtreeview-features-command-support
tags: command,support
published: True
position: 5
site_name: WPF
---

# Command Support

The purpose of this article is to introduce you the command support of the __RadTreeViewItems__.
	  
## Overview

The __RadTreeViewItem__ exposes a __Command__ property of type __ICommand__. You can use this property to trigger custom logic defined in your business object. Furthermore, you can set the __CommandExecutionTrigger__ property. This property is an enumeration that controls whether the command should be executed after a __Click__ or a __DoubleClick__ on the corresponding __RadTreeViewItem__.
		

## Demonstration

In this section, we will demonstrate how you can trigger custom logic implemented in your business object using the __Command Support__ of the __RadTreeViewItem__. Hence, we will need to create a custom class implementing the __INotifyPropertyChanged__ interface and exposing the following properties:
		

* __Header__ of type __string__
* __Children__ of type __ObservableCollection<ItemModel>__
* __EditCommand__ of type __DelegateCommand__
* __IsInEditMode__ of type __bool__

>The __ViewModelBase__ class implements the __INotifyPropertyChanged__ interface.
		  



<snippet id='radtreeview-features-command-support-block_1-cs' />
<snippet id='radtreeview-features-command-support-block_2-vb' />

Furthermore, we can create a __ViewModel__ class which will fill and expose an __Items__ collection of type __ObservableCollection<ItemModel>__. Also, this class will hold the custom logic which will be triggered by the command of the __RadTreeViewItem__



<snippet id='radtreeview-features-command-support-block_3-cs' />
<snippet id='radtreeview-features-command-support-block_4-vb' />

In MVVM scenarios it is best to use a __Style__ to set the __Command__ and __CommandExecutionTrigger__ properties of the __RadTreeViewItems__. For this purpose we will also allow the editing of items and we will use the boolean __IsInEditMode__ property defined in the custom __ItemModel__ class to set the corresponding __RadTreeViewItem__ in edit mode. This will be done in the __OnEditCommandExecute()__ method implemented in the __ViewModel__ class. In order to differ the item that invokes the command we can pass each __RadTreeViewItem's DataContext__ as __CommandParameter__ to the method where custom logic will be implemented. In order to achieve this we can use the __RelativeSource__ binding.

<snippet id='radtreeview-features-command-support-block_5-xaml' />
