---
title: Not auto-generate a column for a specific property
page_title: Not auto-generate a column for a specific property
description: Not auto-generate a column for a specific property
slug: gridview-prevent-column-autogenerate
tags: not,auto-generate,a,column,for,a,specific,property
published: True
position: 9
---

# Not auto-generate a column for a specific property

As you know, if __AutoGenerateColumns="True"__ (which is by default), RadGridView creates a column for each property of the underlying business object. This article shows __how to not auto generate a column for a specific property__.

There are two ways to accomplish this:

1. Using [DataAnnotations](http://msdn.microsoft.com/en-us/library/system.componentmodel.dataannotations.aspx?appId=Dev10IDEF1&l=EN-US&k=k(SYSTEM.COMPONENTMODEL.DATAANNOTATIONS.DISPLAYATTRIBUTE.AUTOGENERATEFIELD);k(AUTOGENERATEFIELD);k(TargetFrameworkMoniker-)).

Apllying this approach you need to add a reference to the __System.ComponentModel.DataAnnotations__ assembly and mark your property with __[Display(AutoGenerateField = false)]__ attribute.

#### __[C#] Example 1: Using DataAnnotations.__

{{region gridview-prevent-column-autogenerate_0}}

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
{{endregion}}

Now, RadGridView will not generate a column for the Players property. 

2. Canceling __AutoGeneratingColumn__ event for a particular column.

#### __[C#] Example 2: Canceling adding a column in AutoGeneratingColumn event__

{{region gridview-prevent-column-autogenerate_1}}

	private void clubsGrid_AutoGeneratingColumn(object sender, GridViewAutoGeneratingColumnEventArgs e)
	{
	   if (e.Column.UniqueName == "Players")
	   {
	      e.Cancel = true;
	   }
	}
{{endregion}}

# See Also

 * [Show/Hide Columns outside of RadGridView]({%slug radgridview-how-to-show-hide-columns-outside-of-the-radgridview%})






