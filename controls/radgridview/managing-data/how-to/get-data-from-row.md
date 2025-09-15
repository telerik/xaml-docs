---
title: Get the data from a row
page_title: Get the data from a row
description: Check out two scenarios for obtaining data from a row - getting the data from the selected row and getting the data from any row in Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-how-to-get-data-from-row
tags: get,the,data,from,a,row
published: True
position: 3
---

# Get the data from a row

This article shows how to obtain the data from a row of RadGridView.

We will consider two scenarios - getting the data from the selected row and getting the data from any GridViewRow. 

* The __SelectedItem__ property of RadGridView returns an object which can be cast to your business object. So, it is very easy to get the underlying data from the selected item:

#### __C#__

```C#
	private void Button1_Click(object sender, RoutedEventArgs e)
	{
	    Club club = this.clubsGrid.SelectedItem as Club;
	    string message = string.Format("Name: {0} \n Established: {1} \n Capacity: {2}", club.Name,
	                         club.Established,
	                         club.StadiumCapacity);
	    MessageBox.Show(message);
	}
```

#### __VB.NET__

```VB.NET
	Private Sub Button2_Click(sender As Object, e As RoutedEventArgs)
	    Dim club As Club = TryCast(Me.clubsGrid.SelectedItem, Club)
	    Dim message As String = String.Format("Name: {0} " & vbLf & " Established: {1} " & vbLf & " Capacity: {2}", club.Name, club.Established, club.StadiumCapacity)
	    MessageBox.Show(message)
	End Sub
```

* Getting the data from an __arbitrary GridViewRow__ is almost the same - you just need to cast its __DataContext__ or __Item__ property to your business object:

#### __C#__

```C#
	void clubsGrid_RowActivated(object sender, Telerik.Windows.Controls.GridView.RowEventArgs e)
	{
	    var row = e.Row as GridViewRow;
	    Club club = row.Item as Club;
	    string message = string.Format("Name: {0} \n Established: {1} \n Capacity: {2}", club.Name,
	                         club.Established,
	                         club.StadiumCapacity);
	    MessageBox.Show(message);
	}
```

#### __VB.NET__

```VB.NET
	Private Sub clubsGrid_RowActivated(sender As Object, e As Telerik.Windows.Controls.GridView.RowEventArgs)
	    Dim row = TryCast(e.Row, GridViewRow)
	    Dim club As Club = TryCast(row.Item, Club)
	    Dim message As String = String.Format("Name: {0} " & vbLf & " Established: {1} " & vbLf & " Capacity: {2}", club.Name, club.Established, club.StadiumCapacity)
	    MessageBox.Show(message)
	End Sub
```




