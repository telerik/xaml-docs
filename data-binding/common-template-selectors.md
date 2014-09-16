---
title: Template Selectors
page_title: Template Selectors
description: Template Selectors
slug: common-data-binding-template-selectors
tags: template,selectors
publish: True
position: 6
---

# Template Selectors



The purpose of this tutorial is to give you a basic information about __Template Selectors__: 

* [What is the idea behind the template selectors](#What_is_a_Template_Selector?)

* [How to create a template selector and which are the classes involved](#How_to_Create_a_Template_Selector?)

* [How to apply a template selector](#How_to_Apply_a_TemplateSelector)

## What is a Template Selector?

The __Template Selector__ provides a way to apply data templates based on custom logic.

#### __C#__

{{region common-data-binding-template-selectors_0}}
	public class DataTemplateSelector
	{{endregion}}



#### __VB.NET (Declaration)__

{{region common-data-binding-template-selectors_1}}
	Public Class DataTemplateSelector
	{{endregion}}



#### __VB.NET (Usage)__

{{region common-data-binding-template-selectors_2}}
	Dim instance As DataTemplateSelector
	{{endregion}}



#### __XAML__

{{region common-data-binding-template-selectors_3}}
	<DataTemplateSelector .../>
	{{endregion}}



Typically, you use a template selector when you have more than one data template defined for the same type of objects. For example, use it if your binding source is a list of student objects and you want to apply a particular template to the part-time students. You can do this by creating a class that inherits from __DataTemplateSelector__ and by overriding the __SelectTemplate()__ method. Once your class is defined you can assign an instance of the class to the template selector property of your element.

For more information read further in the topic.

## How to Create a Template Selector?

To create a __TemplateSelector__ that applies a data template based on custom logic, create a subclass of the __DataTemplateSelector__ class and implement the __SelectTemplate()__ method.

#### __C#__

{{region common-data-binding-template-selectors_4}}
	public virtual DataTemplate SelectTemplate(Object item, DependencyObject container)
	{{endregion}}



#### __VB.NET__

{{region common-data-binding-template-selectors_5}}
	Public Overridable Function SelectTemplate ( _
	    item As Object, _
	    container As DependencyObject _
	) As DataTemplate
	{{endregion}}



Where the __SelectTemplate()__ method accepts the following parameters:

* item - the data object for which to select the data template.

* container - the data-bound object.

The method returns a __DataTemplate__ or a null reference (__Nothing__ in Visual Basic). The default value is a null reference (__Nothing__ in Visual Basic).

The following example shows how to define a __TemplateSelector__.

In this example, the binding source is a list of __League__ objects. Each __League__ object has a list of __Division__ objects. Each __Division__ object has a list of __Team__ objects. 

#### __C#__

{{region common-data-binding-template-selectors_6}}
	public class SampleTemplateSelector : DataTemplateSelector
	{
	    public override DataTemplate SelectTemplate( object item, DependencyObject container )
	    {
	        if ( item is League )
	            return this.LeagueTemplate;
	        else if ( item is Division )
	            return this.DivisionTemplate;
	        else if ( item is Team )
	            return this.TeamTemplate;
	        return null;
	    }
	    public DataTemplate LeagueTemplate
	    {
	        get;
	        set;
	    }
	    public DataTemplate DivisionTemplate
	    {
	        get;
	        set;
	    }
	    public DataTemplate TeamTemplate
	    {
	        get;
	        set;
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region common-data-binding-template-selectors_7}}
	Public Class SampleTemplateSelector
	    Inherits DataTemplateSelector
	    Public Overloads Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
	        If TypeOf item Is League Then
	            Return Me.LeagueTemplate
	        ElseIf TypeOf item Is Division Then
	            Return Me.DivisionTemplate
	        ElseIf TypeOf item Is Team Then
	            Return Me.TeamTemplate
	        End If
	
	        Return Nothing
	    End Function
	Private _LeagueTemplate As DataTemplate
	    Public Property LeagueTemplate() As DataTemplate
	        Get
	            Return _LeagueTemplate
	        End Get
	        Set(ByVal value As DataTemplate)
	            _LeagueTemplate = value
	        End Set
	    End Property
	Private _DivisionTemplate As DataTemplate
	    Public Property DivisionTemplate() As DataTemplate
	        Get
	            Return _DivisionTemplate
	        End Get
	        Set(ByVal value As DataTemplate)
	            _DivisionTemplate = value
	        End Set
	    End Property
	Private _TeamTemplate As DataTemplate
	    Public Property TeamTemplate() As DataTemplate
	        Get
	            Return _TeamTemplate
	        End Get
	        Set(ByVal value As DataTemplate)
	            _TeamTemplate = value
	        End Set
	    End Property
	End Class
	{{endregion}}



## How to Apply a TemplateSelector

In order to be able to apply a template selector, you should first define a resource key for it.

#### __XAML__

{{region common-data-binding-template-selectors_8}}
	<example:SampleTemplateSelector x:Key="myTemplateSelector"
	    LeagueTemplate="{StaticResource LeagueItemTemplate}"
	    DivisionTemplate="{StaticResource DivisionItemTemplate}"
	    TeamTemplate="{StaticResource TeamItemTemplate}"/>
	{{endregion}}



>Note how the particular data templates (__LeagueTemplate="{StaticResource LeagueItemTemplate}"__) are passed to the selector. If you want to use this approach you __must__ declare the data template before the selector declaration.

>The __example__ prefix maps to a CLR namespace and the corresponding assembly where the __TemplateSelector__ is defined. For more information, see [XAML Namespaces and Namespace Mapping](http://msdn.microsoft.com/en-us/library/ms747086.aspx).

The following example shows how to set the __ItemTemplateSelector__ property of a __RadTreeView__ to this __TemplateSelector__ resource.

#### __XAML__

{{region common-data-binding-template-selectors_9}}
	<telerikNavigation:RadTreeView ItemTemplateSelector="{StaticResource myTemplateSelector}"/>
	{{endregion}}


