---
title: Add, Edit and Delete Operations
page_title: Add, Edit and Delete Operations
description: Check our &quot;Add, Edit and Delete Operations&quot; documentation article for the RadDataForm {{ site.framework_name }} control.
slug: raddataform-add-edit-delete-buttons
tags: add,delete,and,edit,operations
published: True
position: 0
---

# Add, Edit and Delete Operations

This article explains when the add, edit and remove operations of **RadDataForm** are available. We will cover the operations in the following order: 

* [Add](#add)
* [Remove](#remove)
* [Edit](#edit)

## Overview

To better understand how these operations work, we need to first examine how **RadDataForm's** source collection is set. **RadDataForm’s** Source property accepts **IEnumerable** values and manages them as follows: 

* If the underlying value implements **IEditableCollectionView**, the current implementation of its methods is used. 
* Otherwise, a new instance of Telerik’s **QueryableCollectionView** (which implements both aforementioned interfaces) is initialized, using the Source value as its source collection.

## Add

**RadDataForm's** Add operation will be available when one of the following conditions is met:

* The collection implements the **IEditableCollectionView** interface

* The collection is an **IList** without a fixed size and with a public default constructor

* The collection implements an **Add** method and has a public default constructor. The Add method needs to have a single parameter - the object you want to add to your collection.

In any other case, **RadDataForm** will not be able to add an item and the respective **Add** button will be disabled. 

#### __Figure 1: RadDataForm with disabled Add and Remove buttons__

![raddataform-crud-operations-1](images/raddataform-crud-operations-1.png)

## Remove

Similar to the Add operation, you will be able to remove items in any of the following cases:

* The collection implements the **IEditableCollectionView** interface

* The collection is an **IList** without a fixed size

* The collection implements a **Remove** method with a single parameter - the object to remove from the collection.

#### __Figure 2: RadDataForm with enabled Add and Remove buttons__

![raddataform-crud-operations-2](images/raddataform-crud-operations-2.png)


## Edit

If the current item is not null and **RadDataForm** is not in editing mode, the **Edit** button will be enabled and editing functionality will be available.

If the items of the data source implement the **IEditableObject** or the **INotifyPropertyChanged** interface, you will be able to revert any pending changes with the **Cancel** button. 

>Note that in the latter case, the **EnablePropertyChangedBasedCancel** property of **RadDataForm** needs to be set to **True**.

>**EnablePropertyChangedBasedCancel** is not supported when using custom data templates.

Please note that when an Edit is started, the Navigation and AddNew commands get disabled until the editing operation is committed or cancelled. 

>For more information on the behaviour of the **OK** and **Cancel** buttons, you could check the article on [AutoCommit Settings]({%slug raddataform-auto-commit%}).

**RadDataForm** supports editing of types that do not implement the **IEditableObject** or **INotifyPropertyChanged** interfaces. Still, please note that in this case you cannot take advantage of the cancel edit feature and the **Cancel** button will not be enabled.

>tip You can find a detailed explanation of how to implement the **IEditableObject** in this [MSDN article](http://msdn.microsoft.com/en-us/library/system.componentmodel.ieditableobject.aspx).

### AutoEdit

The **AutoEdit** property indicates whether **RadDataForm** should automatically enter Edit mode when loading or navigating items. The default value is **False**. If you need to have **RadDataForm** in Edit mode by default, instead of having to click the Edit button every time you need to edit a record, you can set **AutoEdit** to **True**. 

>Please note that setting **AutoEdit** to **True** will disable the **Add** button and you won't be able to add new entries.

## See Also

* [AutoCommit Settings]({%slug raddataform-auto-commit%})
