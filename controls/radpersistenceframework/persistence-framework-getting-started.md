---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadPersistenceFramework {{ site.framework_name }} control.
slug: persistence-framework-getting-started
tags: getting,started
published: True
position: 2
---

# Getting Started with {{ site.framework_name }} PersistenceFramework

The __PersistenceFramework__ allows you to save the visual state of your application either in an isolated storage or in a Stream.  

## Adding Telerik Assemblies Using NuGet

To use __PersistenceFramework__ when working with NuGet packages, install the `Telerik.Windows.PersistenceFramework.for.Wpf.Xaml` package. The [package name may vary]({%slug nuget-available-packages%}) slightly based on the Telerik dlls set - [Xaml or NoXaml]({%slug xaml-vs-noxaml%})

Read more about NuGet installation in the [Installing UI for WPF from NuGet Package]({%slug nuget-installation%}) article.

>tip With the 2025 Q1 release, the Telerik UI for WPF has a new licensing mechanism. You can learn more about it [here]({%slug installing-license-key%}).

## Adding Assembly References Manually

If you are not using NuGet packages, you can add a reference to the following assemblies:

* __Telerik.Licensing.Runtime__
* __Telerik.Windows.Controls__
* __Telerik.Windows.PersistenceFramework__

You can find the required assemblies for each control from the suite in the {% if site.site_name == 'Silverlight' %}[Controls Dependencies]({%slug installation-installing-controls-dependencies%}){% else %}[Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}){% endif %} help article.

## Persisted Types

By default the __PersistenceManager__ persists properties of the following types:		

* __Primitive Types__

* __UIElement__

* __IEnumerable<UIElement>__
 
>If you want to persist more complex controls with complex properties such as **RadGridView** and its filtering, sorting and grouping descriptors, you should use a [Custom Property Provider]({%slug persistence-framework-custom-property-provider%}). Good examples of its implementation can be found in our [SDK Samples Browser]({%slug sdk-samples-browser%})

In order to persist the state of a UI component, the __PersistenceFramework__ uses serialization. This means that the framework creates a serialization string describing each persisted component and you are provided with the option to save that string in a stream or in an  isolated storage.		

## Defining PersistenceManager that stores the data in an isolated storage

In order to save the application's layout properties in an isolated storage, you need to define a __StorageId__ for the controls whose layout you need to persist. You can set the __StorageId__ through the __telerik:PersistenceManager.StorageId__ attached property. Then the __PersistenceManager__ will use the value of this property to create a new file in the isolated storage, name it accordingly to the __StorageId__ and store the control's properties in it:		

#### __XAML__
```XAML
	<telerik:RadTreeView x:Name="treeView" telerik:PersistenceManager.StorageId="treeView">
	    <telerik:RadTreeViewItem Header="Beverages">
	        <telerik:RadTreeViewItem Header="Chai" />
	        <telerik:RadTreeViewItem Header="Chang" />
	        <telerik:RadTreeViewItem Header="Ipoh Coffee" />
	        <telerik:RadTreeViewItem Header="Chartreuse verte" />
	        <telerik:RadTreeViewItem Header="Sasquatch Ale" />
	    </telerik:RadTreeViewItem>
	    <telerik:RadTreeViewItem Header="Condiments">
	        <telerik:RadTreeViewItem Header="Aniseed Syrup" />
	        <telerik:RadTreeViewItem Header="Genen Shouyu" />
	        <telerik:RadTreeViewItem Header="Gula Malacca" />
	        <telerik:RadTreeViewItem Header="Louisiana Hot Spiced Okra" />
	        <telerik:RadTreeViewItem Header="Louisiana Fiery Hot Pepper Sauce" />
	    </telerik:RadTreeViewItem>
	    <telerik:RadTreeViewItem Header="Confections">
	        <telerik:RadTreeViewItem Header="Teatime Chocolate Biscuits" />
	        <telerik:RadTreeViewItem Header="Sir Rodney's Marmalade" />
	        <telerik:RadTreeViewItem Header="Zaanse koeken" />
	        <telerik:RadTreeViewItem Header="Chocolade" />
	        <telerik:RadTreeViewItem Header="Maxilaku" />
	        <telerik:RadTreeViewItem Header="Valkoinen suklaa" />
	    </telerik:RadTreeViewItem>
	</telerik:RadTreeView>
```

The above definition will prepare the __RadTreeView__ control and all its UI related properties to be persisted. The __PersistenceManager__ uses the __IsolatedStorageProvider__ to store and load data to and from an isolated storage. This is why in order to save the __RadTreeView__'s UI properties, you can use the __IsolatedStorageProvider.SaveToStorage()__ method:

#### __C#__
```C#
	IsolatedStorageProvider isoProvider = new IsolatedStorageProvider();
	isoProvider.SaveToStorage();
```

#### __VB.NET__
```VB.NET
	Dim isoProvider As New IsolatedStorageProvider()
	isoProvider.SaveToStorage()
```

And in order to restore the saved __RadTreeView__ layout, you can call the __IsolatedStorageProvider.LoadFromStorage()__ method:		

## Defining PersistenceManager that stores the layout data in a stream

If you want to save the layout of a UI control in a stream, you can take advantage of the __PersistenceManager Save()__ and __Load()__ methods. The __PersistenceManager.Save(object obj)__ method saves the object's properties in a stream. The __PersistenceManager.Load(object obj, Stream stream)__ method restores the properties from the stream, and if possible applies them to the object. So if you have a __RadTreeView__ definition:		

#### __XAML__
```XAML
	<telerik:RadTreeView x:Name="treeView" >
	    <telerik:RadTreeViewItem Header="Beverages">
	        <telerik:RadTreeViewItem Header="Chai" />
	        <telerik:RadTreeViewItem Header="Chang" />
	        <telerik:RadTreeViewItem Header="Ipoh Coffee" />
	        <telerik:RadTreeViewItem Header="Chartreuse verte" />
	        <telerik:RadTreeViewItem Header="Sasquatch Ale" />
	    </telerik:RadTreeViewItem>
	    <telerik:RadTreeViewItem Header="Condiments">
	        <telerik:RadTreeViewItem Header="Aniseed Syrup" />
	        <telerik:RadTreeViewItem Header="Genen Shouyu" />
	        <telerik:RadTreeViewItem Header="Gula Malacca" />
	        <telerik:RadTreeViewItem Header="Louisiana Hot Spiced Okra" />
	        <telerik:RadTreeViewItem Header="Louisiana Fiery Hot Pepper Sauce" />
	    </telerik:RadTreeViewItem>
	    <telerik:RadTreeViewItem Header="Confections">
	        <telerik:RadTreeViewItem Header="Teatime Chocolate Biscuits" />
	        <telerik:RadTreeViewItem Header="Sir Rodney's Marmalade" />
	        <telerik:RadTreeViewItem Header="Zaanse koeken" />
	        <telerik:RadTreeViewItem Header="Chocolade" />
	        <telerik:RadTreeViewItem Header="Maxilaku" />
	        <telerik:RadTreeViewItem Header="Valkoinen suklaa" />
	    </telerik:RadTreeViewItem>
	</telerik:RadTreeView>
```

you can save the __treeView__ properties in a stream like so:		

#### __C#__
```C#
	private Stream stream;
	private void Save(object sender, RoutedEventArgs e)
	{
	 PersistenceManager manager = new PersistenceManager();
	 stream = manager.Save(treeView); 
	}
```

#### __VB.NET__
```VB.NET
	Private stream As Stream
	
	Private Sub Save(sender As Object, e As RoutedEventArgs)
		Dim manager As New PersistenceManager()
		stream = manager.Save(treeView)
	End Sub
```

Later the layout of the __RadTreeView__ can be restored through the __Load()__ method:		

#### __C#__
```C#
	private void Load(object sender, RoutedEventArgs e)
	{
	 stream.Position = 0L;
	 PersistenceManager manager = new PersistenceManager();
	 manager.Load(treeView, stream);
	}
```

#### __VB.NET__
```VB.NET
	Private Sub Load(sender As Object, e As RoutedEventArgs)
		stream.Position = 0L
		Dim manager As New PersistenceManager()
		manager.Load(treeView, stream)
	End Sub
```

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Learning Resources

* [Telerik UI for WPF PersistenceFramework Component](https://www.telerik.com/products/wpf/persistenceframework.aspx)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Installation]({%slug installation-installing-which-file-do-i-need%})
* [Telerik UI for WPF and WinForms Integration]({%slug winforms-integration%})
* [Telerik UI for WPF Visual Studio Templates]({%slug visual-studio-templates%})
* [Setting a Theme with Telerik UI for WPF]({%slug styling-apperance-implicit-styles-overview%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF License Agreement](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s)
{% endif %}

