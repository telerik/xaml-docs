---
title: Not auto-generate a column for a specific property
page_title: Not auto-generate a column for a specific property
description: Not auto-generate a column for a specific property
slug: gridview-prevent-column-autogenerate
tags: not,auto-generate,a,column,for,a,specific,property
publish: True
position: 1
---

# Not auto-generate a column for a specific property



## 

As you know, if the __AutoGenerateColumns="True"__ (which is by default), RadGridView will create a column for each property of the underlying business object. This article shows __how to not auto generate a column for a specific property__.

There are two methods to accomplish this:

1. Feasible for {% if site.site_name == 'Silverlight' %}Silverlight 4{% endif %}{% if site.site_name == 'WPF' %}WPF 4{% endif %} and above - using [DataAnnotations](http://msdn.microsoft.com/en-us/library/system.componentmodel.dataannotations.aspx?appId=Dev10IDEF1&l=EN-US&k=k(SYSTEM.COMPONENTMODEL.DATAANNOTATIONS.DISPLAYATTRIBUTE.AUTOGENERATEFIELD);k(AUTOGENERATEFIELD);k(TargetFrameworkMoniker-).

In this approach you need to add a reference to the __System.ComponentModel.DataAnnotations__ assembly and mark your property with the [Display(AutoGenerateField = false)]




Here is an example:

#### __C#__

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



Now, RadGridView will not create a column for the Players property. 



2. Canceling the __AutoGeneratingColumn__ event for the particular column:

#### __C#__

{{region gridview-prevent-column-autogenerate_1}}
	private void clubsGrid_AutoGeneratingColumn(object sender, GridViewAutoGeneratingColumnEventArgs e)
	{
	   if (e.Column.UniqueName == "Players")
	   {
	      e.Cancel = true;
	   }
	}
	{{endregion}}






