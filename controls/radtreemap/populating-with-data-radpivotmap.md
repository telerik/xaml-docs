---
title: Populating With Data RadPivotMap
page_title: Populating With Data RadPivotMap
description: Populating With Data RadPivotMap
slug: radtreemap-populating-with-data-radpivotmap
tags: populating,with,data,radpivotmap
published: True
position: 5
---

# Populating With Data RadPivotMap



## 

__RadPivotMap__ expects data in tabular format and displays a treemap with grouped data, according to the *GroupDefinition*-s set.

Assuming that you have the following class:

#### __C#__

{{region radtreemap-populating-with-data-radpivotmap_0}}
	public class TestData
	{
	     public int Value { get; set; }
	     public string Category { get; set; }
	     public string Subcategory { get; set; }
	}
	{{endregion}}



#### __VB.NET__

{{region radtreemap-populating-with-data-radpivotmap_1}}
	Private _category As String
	    Public Property Category() As String
	        Get
	            Return _Category
	        End Get
	        Set(ByVal value As String)
	            _Category = value
	        End Set
	    End Property
	Private _Value As Integer
	    Public Property Value() As Integer
	        Get
	            Return _Value
	        End Get
	        Set(ByVal value As Integer)
	            _Value = value
	        End Set
	    End Property
	Private _Subcategory As String
	    Public Property Subcategory() As String
	        Get
	            Return _subcategory
	        End Get
	        Set(ByVal value As String)
	            _Subcategory = value
	        End Set
	    End Property
	{{endregion}}



To bind the __RadPivotMap__ you should use the *__GroupDefinition__* collection and add several __GroupDefinition__-s - one for each of the properties as presented in the class. The __ValuePath__ property specifies from where the data should be taken.

#### __XAML__

{{region radtreemap-populating-with-data-radpivotmap_2}}
	<telerik:RadPivotMap Name="treeMap1" ValuePath="Value">
	                <telerik:RadPivotMap.GroupDefinitions>
	                                <telerik:GroupDefinition Member="Category" />
	                                <telerik:GroupDefinition Member="SubCategory" />
	                </telerik:RadPivotMap.GroupDefinitions>
	</telerik:RadPivotMap>
	{{endregion}}



You can bind the RadPivotMap to any source that implements one of the following interfaces:

* [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) - supports simple iteration of a collection. See the MSDN article for more on [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx). 


* [ICollection](http://msdn.microsoft.com/en-us/library/system.collections.icollection.aspx) - extends [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) and supports size, enumerator, and synchronization methods for collections. 


* [IList](http://msdn.microsoft.com/en-us/library/system.collections.ilist.aspx) - extends [ICollection](http://msdn.microsoft.com/en-us/library/system.collections.icollection.aspx) and is the base class for lists. 
