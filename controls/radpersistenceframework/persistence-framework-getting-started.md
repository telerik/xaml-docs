---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: persistence-framework-getting-started
tags: getting,started
published: True
position: 3
---

# Getting Started



The __PersistenceFramework__allows you to save the visual state of your application either in an isolated storage or in a Stream.
	  

>In order to use the __PersistenceFramework__in your application, you need to add a reference to the following assemblies:
		

* __Telerik.Windows.Controls__

* __Telerik.Windows.PersistenceFramework__You can find more info
		  {% if site.site_name == 'Silverlight' %}[here](http://www.telerik.com/help/silverlight/installation-installing-controls-dependencies.html).
		  {% endif %}{% if site.site_name == 'WPF' %}[here](http://www.telerik.com/help/wpf/installation-installing-controls-dependencies-wpf.html).
		  {% endif %}

## Persisted Types

By default the __PersistenceManager__ persists properties of the following types:
		

* __Primitive Types__

* __UIElement__

* __IEnumerable<UIElement>__

In order to persist the state of a UI component, the __PersistenceFramework__ uses serialization. This means that the framework creates a serialization string describing each persisted component and you are provided with the option to save that string in a stream or in an  isolated storage.
		

## Defining PersistenceManager that stores the data in an isolated storage

In order to save the application's layout properties in an isolated storage, you need to define a __StorageId__ for the controls whose layout you need to persist. You can set the __StorageId__ through the __telerik:PersistenceManager.StorageId__ attached property. Then the __PersistenceManager__ will use the value of this property to create a new file in the isolated storage, name it accordingly to the __StorageId__ and store the control's properties in it:
		

#### __XAML__

{{region persistence-framework-getting-started_0}}
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
	{{endregion}}



The above definition will prepare the __RadTreeView__control and all its UI related properties to be persisted. The __PersistenceManager__ uses the __IsolatedStorageProvider__ to store and load data to and from an isolated storage. This is why in order to save the __RadTreeView__'s UI properties, you can use the __IsolatedStorageProvider.SaveToStorage()__ method__:__

#### __C#__

{{region persistence-framework-getting-started_1}}
	IsolatedStorageProvider isoProvider = new IsolatedStorageProvider();
	isoProvider.SaveToStorage();
	{{endregion}}



#### __VB.NET__

{{region persistence-framework-getting-started_2}}
	Dim isoProvider As New IsolatedStorageProvider()
	isoProvider.SaveToStorage()
	{{endregion}}



And in order to restore the saved __RadTreeView__ layout, you can call the __IsolatedStorageProvider.LoadFromStorage()__ method:
		

## Defining PersistenceManager that stores the layout data in a stream

If you want to save the layout of a UI control in a stream, you can take advantage of the __PersistenceManager____Save()__ and __Load()__ methods. The __PersistenceManager.Save(object obj)__method saves the object's properties in a stream. The __PersistenceManager.____Load(object obj, Stream stream)__ method restores the properties from the stream, and if possible applies them to the object. So if you have a __RadTreeView__ definition:
		

#### __XAML__

{{region persistence-framework-getting-started_5}}
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
	{{endregion}}



you can save the __treeView__ properties in a stream like so:
		

#### __C#__

{{region persistence-framework-getting-started_6}}
	private Stream stream;
	private void Save(object sender, RoutedEventArgs e)
	{
	 PersistenceManager manager = new PersistenceManager();
	 stream = manager.Save(treeView); 
	}
	{{endregion}}



#### __VB.NET__

{{region persistence-framework-getting-started_7}}
	Private stream As Stream
	
	Private Sub Save(sender As Object, e As RoutedEventArgs)
		Dim manager As New PersistenceManager()
		stream = manager.Save(treeView)
	End Sub
	{{endregion}}



Later the layout of the __RadTreeView__ can be restored through the __Load()__ method:
		

#### __C#__

{{region persistence-framework-getting-started_8}}
	private void Load(object sender, RoutedEventArgs e)
	{
	 stream.Position = 0L;
	 PersistenceManager manager = new PersistenceManager();
	 manager.Load(treeView, stream);
	}
	{{endregion}}



#### __VB.NET__

{{region persistence-framework-getting-started_9}}
	Private Sub Load(sender As Object, e As RoutedEventArgs)
		stream.Position = 0L
		Dim manager As New PersistenceManager()
		manager.Load(treeView, stream)
	End Sub
	{{endregion}}


