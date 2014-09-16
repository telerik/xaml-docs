---
title: Data Annotations
page_title: Data Annotations
description: Data Annotations
slug: raddatafilter-features-data-annotations
tags: data,annotations
publish: True
position: 0
---

# Data Annotations



## 

By default the __RadDataFilter__ will use each of the fields provided by the underlying business object and will directly use the name of the member. If you have a scenario in which to allow the user to filter the data only by specific members and also to give them user friendly names, you have to use data annotations.

>In order to use the data annotations you have to add a reference to the __System.ComponentModel.DataAnnotations.dll__in your project.

In this case you can use the __Display__ attribute and set the __AutoGenerateFilter__ and __ShortName__ data annotations in it. Here is an example for a __Person__ class, which exposes __Name__, __CompanyName__ and __Title__ properties. In this case the user is allowed only to filter by the __CompanyName__and the __Title__ properties. Its display name is also changed to 'Company's Name'.

#### __[C#] Example 1: Defining class Person__

{{region raddatafilter-features-data-annotations_0}}
	public class Person
	{
	    [Display( AutoGenerateFilter = false )]
	    public string Name
	    {
	        get;
	        set;
	    }
	    [Display( ShortName = "Company's Name" )]
	    public string CompanyName
	    {
	        get;
	        set;
	    }
	    public string Title
	    {
	        get;
	        set;
	    }
	}
	{{endregion}}



#### __[VB] Example 1: Defining class Person__

{{region raddatafilter-features-data-annotations_1}}
	Public Class Person
	 <Display(AutoGenerateFilter = False)> _
	 Public Property Name() As String
	  Get
	   Return m_Name
	  End Get
	  Set
	   m_Name = Value
	  End Set
	 End Property
	 Private m_Name As String
	 <Display(ShortName = "Company's Name")> _
	 Public Property CompanyName() As String
	  Get
	   Return m_CompanyName
	  End Get
	  Set
	   m_CompanyName = Value
	  End Set
	 End Property
	 Private m_CompanyName As String
	 Public Property Title() As String
	  Get
	   Return m_Title
	  End Get
	  Set
	   m_Title = Value
	  End Set
	 End Property
	 Private m_Title As String
	End Class
	{{endregion}}



If you filter a collection of __Person__ objects via the __RadDataFilter__ control, in the DropDown for the Data Members you should see the following:

Figure 1: RadDataFilter displaying all the members to filter on.![](images/RadDataFilter_Features_DataAnnotations_01.png)

You can customize Members shown in the ComboBox with available members to filter on (PART_SimpleFilterMemberComboBox) by specifying whether a property should be displayed or not via __BrowsableAttribute__.

For example, you can apply the attribute like so:
        

#### __[C#] Example 2: Setting a property to not be displayed __

{{region raddatafilter-features-data-annotations_2}}
	
	[Browsable(false)]
	[Display(ShortName = "Company's Name")]
	public string CompanyName
	{
	    get;
	    set;
	}
	{{endregion}}



Figure 2: RadDataFilter displaying the Browsable members.![Rad Data Filter Features Data Annotations 02](images/RadDataFilter_Features_DataAnnotations_02.png)

# See Also

 * [Getting Started]({%slug datafilter-getting-started%})

 * [Source and Filtered Source]({%slug raddatafilter-features-source-and-filtered-source%})

 * [Unbound Mode]({%slug raddatafilter-features-unbound-mode%})
