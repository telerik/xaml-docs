---
title: CollectionEditors
page_title: CollectionEditors
description: CollectionEditors
slug: radpropertygrid-collectioneditor
tags: collectioneditors
publish: True
position: 5
---

# CollectionEditors





## Overview

__CollectionEditor__ and __CollectionEditorPicker__ are editor controls that provide UI for editing collections and their items. Currently they are used in the domain of RadPropertyGrid as default editors for IEnumerable type-compatible properties, but they can be successfully used out of this context as standalone editors:



#### __XAML__

{{region radpropertygrid-collectioneditor_0}}
	  <telerik:CollectionEditor Source="{Binding Players}" 
	                                  Header="Players" />
	
	
	{{endregion}}



![Rad Property Grid Collection Editor](images/RadPropertyGrid_CollectionEditor.png)

![Rad Property Grid Collection Editor Picker](images/RadPropertyGrid_CollectionEditorPicker.png)

>importantIf you want CollectionEditor to work with a __custom collection__, then the edited collection type should implement __ICollectionView__ and __IEditableCollectionView__ interfaces.

## Dependencies

Both of them are located in the Telerik.Windows.Controls.Data assembly (Telerik.Windows.Controls.Data.PropertyGrid namespace) and depend on the following RadControls assemblies
        

* 
              Telerik.Windows.Data
            

* 
              Telerik.Windows.Controls
            

* 
              Telerik.Windows.Controls.Data
            

* 
              Telerik.Windows.Control.Input
            

The mentioned namespace is mapped to the Telerik Uri namespace
          

#### __XAML__

{{region radpropertygrid-collectioneditor_1}}
	   http://schemas.telerik.com/2008/xaml/presentation
	{{endregion}}



## Internal Structure

CollectionEditor relies on the IEditableCollectionView interface. In case that the edited collection type implements ICollectionView and IEditableCollectionView, its custom implementation is utilized and if it does not, an instance of QueryableCollectionView is used instead.
        

The following listed commands, defined in the CollectionEditorCommands class, invoke their IEditableCollectionView method counterparts, when they are executed:
        

* 
            MoveCurrentToNext
          

* 
            MoveCurrentToPrevious
          

* 
            AddNew
          

* 
            Delete
          

# See Also
