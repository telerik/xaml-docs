---
title: Style Selectors
page_title: Style Selectors
description: Style Selectors
slug: common-data-binding-style-selectors
tags: style,selectors
publish: True
position: 5
---

# Style Selectors



The purpose of this tutorial is to give you a basic information about __Style Selectors__:

* [What is the idea behind the style selectors](#What_is_a_Style_Selector?)

* [How to create a style selector and which are the classes involved](#How_to_Create_a_Style_Selector?)

* [How to apply a style selector](#How_to_Apply_a_StyleSelector)

## What is a Style Selector?

The __StyleSelector__ provides a way to apply styles based on custom logic.

#### __C#__

{{region common-data-binding-style-selectors_0}}
	public class StyleSelector
	{{endregion}}



#### __VB.NET (Declaration)__

{{region common-data-binding-style-selectors_1}}
	Public Class StyleSelector
	{{endregion}}



#### __VB.NET (Usage)__

{{region common-data-binding-style-selectors_2}}
	Dim instance As StyleSelector
	{{endregion}}



#### __XAML__

{{region common-data-binding-style-selectors_3}}
	<StyleSelector .../>
	{{endregion}}



Typically, you use a style selector when you have more than one styles defined for the same type of objects. For example, use it if your binding source is a list of student objects and you want to apply a particular style to the part-time students. You can do this by creating a class that inherits from __StyleSelector__ and by overriding the __SelectStyle()__ method. Once your class is defined you can assign an instance of the class to the style selector property of your element.

For more information read further in the topic.

## How to Create a Style Selector?

To create a __StyleSelector__ that applies a style based on custom logic, create a subclass of the __StyleSelector__ class and implement the 

__SelectStyle()__ method.

#### __C#__

{{region common-data-binding-style-selectors_4}}
	public virtual Style SelectStyle( object item, DependencyObject container );
	{{endregion}}





#### __VB.NET__

{{region common-data-binding-style-selectors_5}}
	Public Overridable Function SelectStyle ( _
	    item As Object, _
	    container As DependencyObject _
	) As Style
	{{endregion}}



Where the __SelectStyle()__ method accepts the following parameters:

* item - the data object for which to select the style.

* container - the data-bound object.

The method returns a __Style__ or a null reference (__Nothing__ in Visual Basic). The default value is a null reference (__Nothing__ in Visual Basic).

The following example shows how to define a __StyleSelector__.

In this example, the binding source is a list of __League__ objects. Each __League__ object has a list of __Division__ objects. Each __Division__ object has a list of __Team__ objects.



#### __C#__

{{region common-data-binding-style-selectors_6}}
	public class SampleStyleSelector : StyleSelector
	{
	    public override Style SelectStyle( object item, DependencyObject container )
	    {
	        if ( item is League )
	            return this.LeagueStyle;
	        else if ( item is Division )
	            return this.DivisionStyle;
	        else if ( item is Team )
	            return this.TeamStyle;
	        return null;
	    }
	    public Style LeagueStyle
	    {
	        get;
	        set;
	    }
	    public Style DivisionStyle
	    {
	        get;
	        set;
	    }
	    public Style TeamStyle
	    {
	        get;
	        set;
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region common-data-binding-style-selectors_7}}
	Public Class SampleStyleSelector
	    Inherits StyleSelector
	
	    Public Overloads Overrides Function SelectStyle(ByVal item As Object, ByVal container As DependencyObject) As Style
	        If TypeOf item Is League Then
	            Return Me.LeagueStyle
	        ElseIf TypeOf item Is Division Then
	            Return Me.DivisionStyle
	        ElseIf TypeOf item Is Team Then
	            Return Me.TeamStyle
	        End If
	
	        Return Nothing
	    End Function
	
	Private _LeagueStyle As Style
	    Public Property LeagueStyle() As Style
	        Get
	            Return _LeagueStyle
	        End Get
	        Set(ByVal value As Style)
	            _LeagueStyle = value
	        End Set
	    End Property
	
	Private _DivisionStyle As Style
	    Public Property DivisionStyle() As Style
	        Get
	            Return _DivisionStyle
	        End Get
	        Set(ByVal value As Style)
	            _DivisionStyle = value
	        End Set
	    End Property
	
	Private _TeamStyle As Style
	    Public Property TeamStyle() As Style
	        Get
	            Return _TeamStyle
	        End Get
	        Set(ByVal value As Style)
	            _TeamStyle = value
	        End Set
	    End Property
	End Class
	{{endregion}}



## How to Apply a StyleSelectorHow to Apply a StyleSelector

In order to be able to apply a style selector, you should first define a resource key for it.

#### __XAML__

{{region common-data-binding-style-selectors_8}}
	<example:SampleStyleSelector x:Key="myContainerStyleSelector"
	    LeagueStyle="{StaticResource LeagueItemContainerStyle}"
	    DivisionStyle="{StaticResource DivisionItemContainerStyle}"
	    TeamStyle="{StaticResource TeamItemContainerStyle}"/>
	{{endregion}}



>Note how the particular styles (__LeagueStyle="{StaticResource LeagueItemContainetStyle}"__) are passed to the selector. If you want to use this approach you __must__ declare the styles before the selector declaration.

>The __example__ prefix maps to a CLR namespace and the corresponding assembly where the __StyleSelector__ is defined. For more information see [XAML Namespaces and Namespace Mapping](http://msdn.microsoft.com/en-us/library/ms747086.aspx).

The following example shows how to set the __ItemContainerStyleSelector__ property of a __RadTreeView__ to this __StyleSelector__ resource.

#### __XAML__

{{region common-data-binding-style-selectors_9}}
	<telerikNavigation:RadTreeView ItemContainerStyleSelector="{StaticResource myContainerStyleSelector}"/>
	{{endregion}}


