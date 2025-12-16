---
title: Binding to a DataSet
page_title: Binding to a DataSet
description: This article demonstrates how to bind Telerik's DataGrid to a DataSet.
slug: gridview-binding-to-dataset
tags: binding, dataset, datagrid
published: True
position: 11
---

# Binding to a DataSet

This article demonstrates how to bind a __RadGridView__ to data coming from a **DataSet**.

## Setting up the ViewModel

__Example 1__ demonstrates how you can set up a ViewModel containing a DataSet in order to bind it to the RadGridView.

__Example 1: Setting up the ViewModel__

```C#
	public class MainViewModel : ViewModelBase
    {
        private DataSet dataSet;
        public DataSet DataSet
        {
            get
            {
                if (this.dataSet == null)
                {
                    this.dataSet = this.CreateDataSet();
                }

                return this.dataSet;
            }
        }

        private DataSet CreateDataSet()
        {
            DataSet dataSet = new DataSet();
            var parentTable = new DataTable("Managers");
            dataSet.Tables.Add(parentTable);

            parentTable.Columns.Add(new System.Data.DataColumn("Id", typeof(int)));
            parentTable.Columns.Add(new System.Data.DataColumn("FirstName", typeof(string)));
            parentTable.Columns.Add(new System.Data.DataColumn("LastName", typeof(string)));
            parentTable.Columns.Add(new System.Data.DataColumn("City", typeof(string)));
            parentTable.PrimaryKey = new DataColumn[] { parentTable.Columns["Id"] };

            for (int i = 1; i <= 50; i++)
            {
                var row = parentTable.NewRow();
                row["Id"] = i;
                row["FirstName"] = "FirstName " + i;
                row["LastName"] = "LastName" + i;
                row["City"] = "City " + i;
                parentTable.Rows.Add(row);
            }

            var childTable = new DataTable("Employees");
            dataSet.Tables.Add(childTable);

            childTable.Columns.Add(new System.Data.DataColumn("Id", typeof(int)));
            childTable.Columns.Add(new System.Data.DataColumn("ManagerId", typeof(int)));
            childTable.Columns.Add(new System.Data.DataColumn("FirstName", typeof(string)));
            childTable.Columns.Add(new System.Data.DataColumn("LastName", typeof(string)));
            childTable.Columns.Add(new System.Data.DataColumn("City", typeof(string)));
            childTable.PrimaryKey = new DataColumn[] { childTable.Columns["Id"] };

            DataColumn fkColumn = childTable.Columns["ManagerId"];
            DataColumn pkColumn = parentTable.Columns["Id"];

            // required to enable hierarchy
            parentTable.ChildRelations.Add(new DataRelation("ParentChildRelation", pkColumn, fkColumn));

            for (int i = 1; i <= 500; i++)
            {
                var row = childTable.NewRow();
                row["Id"] = i + 50;
                row["ManagerId"] = (i % 50) + 1;
                row["FirstName"] = "FirstName " + i;
                row["LastName"] = "LastName" + i;
                row["City"] = "City " + i;
                childTable.Rows.Add(row);
            }

            return dataSet;
        }
    }
```
```VB.NET
    Public Class MainViewModel
	Inherits ViewModelBase

		Private set As DataSet
		Public Property DataSet() As DataSet
			Get
				If Me.set Is Nothing Then
					Me.set = Me.CreateDataSet()
				End If

				Return set
			End Get
		End Property

		Private Function CreateDataSet() As DataSet
			Dim ds As New DataSet()
			Dim parentTable = New DataTable("Managers")
			ds.Tables.Add(parentTable)

			parentTable.Columns.Add(New System.Data.DataColumn("Id", GetType(Integer)))
			parentTable.Columns.Add(New System.Data.DataColumn("FirstName", GetType(String)))
			parentTable.Columns.Add(New System.Data.DataColumn("LastName", GetType(String)))
			parentTable.Columns.Add(New System.Data.DataColumn("City", GetType(String)))
			parentTable.PrimaryKey = New DataColumn() { parentTable.Columns("Id") }

			For i As Integer = 1 To 50
				Dim row = parentTable.NewRow()
				row("Id") = i
				row("FirstName") = "FirstName " & i
				row("LastName") = "LastName" & i
				row("City") = "City " & i
				parentTable.Rows.Add(row)
			Next i

			Dim childTable = New DataTable("Employees")
			ds.Tables.Add(childTable)

			childTable.Columns.Add(New System.Data.DataColumn("Id", GetType(Integer)))
			childTable.Columns.Add(New System.Data.DataColumn("ManagerId", GetType(Integer)))
			childTable.Columns.Add(New System.Data.DataColumn("FirstName", GetType(String)))
			childTable.Columns.Add(New System.Data.DataColumn("LastName", GetType(String)))
			childTable.Columns.Add(New System.Data.DataColumn("City", GetType(String)))
			childTable.PrimaryKey = New DataColumn() { childTable.Columns("Id") }

			Dim fkColumn As DataColumn = childTable.Columns("ManagerId")
			Dim pkColumn As DataColumn = parentTable.Columns("Id")

			' required to enable hierarchy
			parentTable.ChildRelations.Add(New DataRelation("ParentChildRelation", pkColumn, fkColumn))

			For i As Integer = 1 To 500
				Dim row = childTable.NewRow()
				row("Id") = i + 50
				row("ManagerId") = (i Mod 50) + 1
				row("FirstName") = "FirstName " & i
				row("LastName") = "LastName" & i
				row("City") = "City " & i
				childTable.Rows.Add(row)
			Next i

			Return ds
		End Function
    End Class
```

>important Please note that the **DataRelation** is required for RadGridView to generate the hierarchy automatically.

__Example 2__ demonstrates how the RadGridView is set up in XAML.

__Example 2: Setting up the RadGridView__

```XAML
	<Grid>
        <Grid.DataContext>
            <!-- The namespace "local" refers to the namespace where the MainViewModel class is defined-->
            <local:MainViewModel />
        </Grid.DataContext>
        <telerik:RadGridView ItemsSource="{Binding DataSet}"
                             AutoGenerateColumns="False"
                             GroupRenderMode="Flat"
                             Margin="5">
            <telerik:RadGridView.Columns>
                <telerik:GridViewDataColumn DataMemberBinding="{Binding FirstName}"/>
				<telerik:GridViewDataColumn DataMemberBinding="{Binding LastName}"/>
				<telerik:GridViewDataColumn DataMemberBinding="{Binding City}" />
			</telerik:RadGridView.Columns>
		</telerik:RadGridView>
		
	</Grid>
```

>If updates to the hierarchy are required during runtime, you can invoke RadGridView's **BuildHierarchyFromDataSet** method.

## See Also

* [Configure the Data Bindings]({%slug gridview-configuring-the-databindings%})
* [Adding new Entries]({%slug gridview-managing-data-add-new-entries%})
* [Binding to the DataView of a DataTable]({%slug gridview-binding-to-the-dataview-of-a-datatable%})