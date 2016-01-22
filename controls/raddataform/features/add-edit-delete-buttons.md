---
title: Insert, Delete and Editing Operations
page_title: Insert, Delete and Editing Operations
description: Insert, Delete and Editing Operations
slug: raddataform-add-edit-delete-buttons
tags: insert,delete,and,editing,operations
published: True
position: 0
---

# Insert, Delete and Editing Operations



This article explains how the edit operations of the __RadDataForm__ work. They are invoked through the Add, Edit and Delete buttons.

## Edit Operation Buttons

The state of the **Add** and **Delete** buttons depends on whether the bound data source collection supports inserting and removing items. If the collection itself supports insert and delete functionality, then the DataForm will be able to add or remove an item and the buttons will be enabled.

For example they will be enabled if the underlying collection is a List, an ObservableCollection or a custom collection that implements Add and Remove methods. On the other hand, if the underlying collection is an Array or an IEnumerable, then the buttons will be disabled as those collections do not expose those two options. 
        

Here is an example on how you could extend the IEnumerable collection to a collection that supports those operations.



#### __[C#] Example 1: Extending the IEnumerable Collection  to a Collection that Supports CRUD Operations__

{{region raddataform-add-edit-delete-buttons_0}}
	
	public class MyCollection<T> : IEnumerable<Employee>
    {
        private List<Employee> employees = new List<Employee>();

        public void Add(Employee employee)
        {
            this.employees.Add(employee);
        }

        public void AddRange(IEnumerable<Employee> employees)
        {
            this.employees.AddRange(employees);
        }

        public void Remove(Employee employee)
        {
            this.employees.Remove(employee);
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return this.employees.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
	{{endregion}}

#### __[VB.NET] Example 1: Extending the IEnumerable Collection  to a Collection that Supports CRUD Operations__

{{region raddataform-add-edit-delete-buttons_1}}

    Public Class MyCollection(Of T)
        Implements IEnumerable(Of Employee)
        Private employees As New List(Of Employee)()

        Public Sub Add(employee As Employee)
            Me.employees.Add(employee)
        End Sub

        Public Sub AddRange(employees As IEnumerable(Of Employee))
            Me.employees.AddRange(employees)
        End Sub

        Public Sub Remove(employee As Employee)
            Me.employees.Remove(employee)
        End Sub

        Public Function GetEnumerator() As IEnumerator(Of Employee)
            Return Me.employees.GetEnumerator()
        End Function

        Private Function System_Collections_IEnumerable_GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.GetEnumerator()
        End Function
    End Class
	{{endregion}}


Similarly if the item is editable and the DataForm is enabled, the **Edit** button will be enabled.

>Please note that when an edit is started, the Navigation and AddNew commands get disabled, until the editing operation is committed, or cancelled. 
>For more information on the behaviour of the **OK** and **Cancel** buttons you could check the article on [AutoCommit Settings]({%slug raddataform-auto-commit%})

## Cancel Button

RadDataForm supports editing of types that does not implement the IEditableObject or INotifyPropertyChange interfaces. Still, please note that in this case you cannot take advantage of the cancel edit feature and the **Cancel** button will not be enabled. 
        

>You can find a detailed explanation on how to implement the IEditableObject in this: [msdn article](http://msdn.microsoft.com/en-us/library/system.componentmodel.ieditableobject.aspx)
