---
title: Not auto-generate a column for a specific property
page_title: Prevent Column Auto-Generation
description: Learn about two ways of preventing auto-generation of a column for a specific property within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-prevent-column-autogenerate
tags: not,auto-generate,a,column,for,a,specific,property
published: True
position: 9
---

# Prevent Column Auto-Generation

As you know, if __AutoGenerateColumns="True"__ (which is by default), RadGridView creates a column for each property of the underlying business object. This article shows __how to not auto generate a column for a specific property__.

There are two ways to accomplish this:

1. Using [DataAnnotations](http://msdn.microsoft.com/en-us/library/system.componentmodel.dataannotations.aspx?appId=Dev10IDEF1&l=EN-US&k=k(SYSTEM.COMPONENTMODEL.DATAANNOTATIONS.DISPLAYATTRIBUTE.AUTOGENERATEFIELD);k(AUTOGENERATEFIELD);k(TargetFrameworkMoniker-)).

Apllying this approach you need to add a reference to the __System.ComponentModel.DataAnnotations__ assembly and mark your property with __[Display(AutoGenerateField = false)]__ attribute.

__Example 1: Using DataAnnotations.__

```C#
	private ObservableCollection<Player> players;
	
	[Display(AutoGenerateField = false)]
	public ObservableCollection<Player> Players
	{
	    get
	    {
	        if (null == this.players)
	        {
	            this.players = new ObservableCollection<Player>();
	        }
	        return this.players;
	    }
	}
```

Now, RadGridView will not generate a column for the Players property. 

2. Canceling __AutoGeneratingColumn__ event for a particular column.

__Example 2: Canceling adding a column in AutoGeneratingColumn event__

```C#
	private void clubsGrid_AutoGeneratingColumn(object sender, GridViewAutoGeneratingColumnEventArgs e)
	{
	    if (e.Column.UniqueName == "Players")
	    {
	        e.Cancel = true;
	    }
	}
```

## See Also

 * [Show/Hide Columns outside of RadGridView]({%slug radgridview-how-to-show-hide-columns-outside-of-the-radgridview%})






