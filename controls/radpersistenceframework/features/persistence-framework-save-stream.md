---
title: Save in a Stream
page_title: Save in a Stream
description: Check our &quot;Save in a Stream&quot; documentation article for the RadPersistenceFramework {{ site.framework_name }} control.
slug: persistence-framework-save-stream
tags: save,in,a,stream
published: True
position: 2
---

# Save in a Stream

The __PersistenceFramework__ allows you to save the layout of __UIElements__ in a stream. The __PersistenceManager__ exposes the following methods that persist the data in a stream:		

* __Save__ - this method saves the data in a stream. It should receive the __UIElement__ object which properties will be persisted. It returns the stream with the persisted data.		  

* __Load__ - this method loads the persisted data. It should receive the __UIElement__ object which properties should be restored and the stream that holds the object's persisted properties.		  

For the purpose of this tutorial, let's define the following __RadTreeView__ control:		

#### __XAML__
```XAML
	<telerik:RadTreeView x:Name="treeView">
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

In order to persist the __RadTreeView__'s properties in a stream, you need to create an instance of the __PersistenceManager__:		

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

The persisted visual state of the __RadTreeView__ control can be restored using the __PersistencaManager__.__Load__ method:		

#### __C#__
```C#
	private void Load(object sender, RoutedEventArgs e)
	{
	 PersistenceManager manager = new PersistenceManager();
	 stream.Position = 0L;
	 manager.Load(treeView, stream);
	}
```

#### __VB.NET__
```VB.NET
	Private Sub Load(sender As Object, e As RoutedEventArgs)
		Dim manager As New PersistenceManager()
	        stream.Position = 0L
		manager.Load(treeView, stream)
	End Sub
```

>tip Please keep in mind that before loading the persisted data from a stream, you need to make sure that the stream's position matches the beginning of the persisted bytes. In case when the persisted data is saved in a new stream, before loading it, you should set the __Stream.Position__ to __0L__.