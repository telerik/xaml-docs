---
title: Binding to the DataView of a DataTable
page_title: Binding to the DataView of a DataTable
description: This article demonstrates how to bind Telerik's {{ site.framework_name }} DataGrid to the DataView of a DataTable.
slug: gridview-binding-to-the-dataview-of-a-datatable
tags: binding, datatable, defaultview, dataview
published: True
position: 11
---

# Binding to the DataView of a DataTable

This article will demonstrate how to bind a __RadGridView__ to the DataView of a DataTable. An important thing when using a DataTable as a data source for a RadGridView is to make sure that the __ItemsSource__ property of the control is bound to the __DefaultView__ property of the DataTable, which is of type [DataView](https://docs.microsoft.com/en-us/dotnet/api/system.data.dataview?view=netframework-4.7.2).

## Binding to DataTable's DefaultView

__Example 1__ demonstrates how you can set up a ViewModel containing a DataTable in order to bind it to the RadGridView.

__Example 1: Setting up the ViewModel__

```C#
	public class MyViewModel : ViewModelBase
    {
        private DataTable datatable;
        public DataTable DataTable
        {
            get
            {
                if (this.datatable == null)
                {
                    this.datatable = this.CreateDataTable();
                }

                return this.datatable;
            }
        }

        private DataTable CreateDataTable()
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add(new System.Data.DataColumn("FirstName", typeof(string)));
            dataTable.Columns.Add(new System.Data.DataColumn("LastName", typeof(string)));
            dataTable.Columns.Add(new System.Data.DataColumn("City", typeof(string)));

            for (int i = 1; i <= 50; i++)
            {
                var row = dataTable.NewRow();
                row["FirstName"] = "FirstName " + i;
                row["LastName"] = "LastName" + i;
                row["City"] = "City " + i;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
```
```VB.NET
    Public Class MyViewModel
        Inherits ViewModelBase

            Private _datatable As DataTable
            Public ReadOnly Property DataTable() As DataTable
                Get
                    If Me._datatable Is Nothing Then
                        Me._datatable = Me.CreateDataTable()
                    End If

                    Return Me._datatable
                End Get
            End Property

            Private Function CreateDataTable() As DataTable
                Dim _datatable = New DataTable()

                _datatable.Columns.Add(New System.Data.DataColumn("FirstName", GetType(String)))
                _datatable.Columns.Add(New System.Data.DataColumn("LastName", GetType(String)))
                _datatable.Columns.Add(New System.Data.DataColumn("City", GetType(String)))

                For i As Integer = 1 To 50
                    Dim row = _datatable.NewRow()
                    row("FirstName") = "FirstName " & i
                    row("LastName") = "LastName" & i
                    row("City") = "City " & i
                    _datatable.Rows.Add(row)
                Next i

                Return _datatable
            End Function
    End Class

```

__Example 2__ demonstrates how the RadGridView is set up in XAML. Please, pay attention to the fact that the __ItemsSource__ is bound to the __DefaultView__ property of the DataTable.

__Example 2: Setting up the RadGridView__

```XAML
	<Grid>
        <Grid.DataContext>
            <!-- The namespace "my" refers to the namespace where the MyViewModel class is defined-->
            <my:MyViewModel />
        </Grid.DataContext>
        <telerik:RadGridView ItemsSource="{Binding DataTable.DefaultView}"
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

## See Also

* [Configure the Data Bindings]({%slug gridview-configuring-the-databindings%})
* [Adding new Entries]({%slug gridview-managing-data-add-new-entries%})
