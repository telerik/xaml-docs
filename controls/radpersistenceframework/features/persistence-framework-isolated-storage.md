---
title: Isolated Storage
page_title: Isolated Storage
description: Isolated Storage
slug: persistence-framework-isolated-storage
tags: isolated,storage
published: True
position: 0
---

# Isolated Storage



The __PersistenceFramework__allows you to save the layout of __UIElements__ in an isolated storage. For that purpose the __telerik:PersistenceManager.StorageId__ attached property has to be set for each __UIElement__ that will be persisted.
	  

## 

The property is used to create a file in the isolated storage for each persisted control, where the control's properties will be kept.
		

#### __XAML__

{{region persistence-framework-isolated-storage_0}}
	<Grid x:Name="LayoutRoot" Background="White">
	    <Grid.ColumnDefinitions>
	        <ColumnDefinition Width="*" />
	        <ColumnDefinition Width="*" />
	    </Grid.ColumnDefinitions>
	    <Grid.RowDefinitions>
	        <RowDefinition Height="*" />
	        <RowDefinition Height="Auto" />
	    </Grid.RowDefinitions>
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
	    <StackPanel Orientation="Horizontal" Grid.Row="1">
	        <Button Content="Save" Click="Save" VerticalAlignment="Bottom" FontWeight="Bold" />
	        <Button Content="Load" Click="Load" VerticalAlignment="Bottom" FontWeight="Bold" />
	    </StackPanel>
	    <Border Grid.Column="1" BorderBrush="Blue" BorderThickness="1">
	        <ContentControl HorizontalContentAlignment="Stretch" telerik:PersistenceManager.StorageId="detailsControl">
	            <Grid>
	                <Grid.ColumnDefinitions>
	                    <ColumnDefinition Width="Auto" />
	                    <ColumnDefinition Width="*" />
	                </Grid.ColumnDefinitions>
	                <Grid.RowDefinitions>
	                    <RowDefinition Height="Auto" />
	                    <RowDefinition Height="Auto" />
	                </Grid.RowDefinitions>
	                <TextBlock Text="Details" Margin="2" VerticalAlignment="Center" FontWeight="Bold"
	                        Grid.ColumnSpan="2" />
	                <TextBlock Text="Add Description:" Grid.Row="1" Margin="2" VerticalAlignment="Center" />
	                <TextBox Margin="2" Grid.Row="1" Grid.Column="1" VerticalAlignment="Center"
	                        HorizontalAlignment="Stretch" />
	            </Grid>
	        </ContentControl>
	    </Border>
	</Grid>
	{{endregion}}



In order to save the persisted properties in an isolated storage, you can use the __IsolatedStorageProvider.__It exposes the following members:
		

* __SaveToStorage()__- the method that saves the __UIElement__ properties in the associated file in the isolated storage
			

* __LoadFromStorage()__ - the method that loads the persisted properties from the __UIElement's__ associated file
			

* __QuotaRequested__ - is an event. When the application requests a larger quota from the isolated storage, the user is prompted to allow or deny the request. The __QuotaRequested__ event is fired when the user makes a choice. The event receives two arguments:
			

* A __sender__ argument that receives the __IsolatedStorageProvider__that is requesting the additional quota
				

* A __QuotaRequestedEventArgs__ object that gives access to:
				

* __FileStreams__ - a dictionary that contains the names of the isolated storage files as keys, and the filestreams as values
					

* __IsSuccess__ - a property of type bool that indicates whether the user has allowed the quota increase
					

* __RequestedBytes__ - a property of type __long__ that represents the size of the requested quota
					

>When you are using the __IsolatedStorageProvider__, you can check the persistence storage
			and the controls that are persisted using the __PersistenceManager.GetStorage()__static method.
			It returns an object of type __ObjectStorage__ that exposes the following properties:
		  

* __Count__ - this property is of type __int__ and it gets the number of persisted objects.
			  

* __Items__ - this property gets the collection of persisted objects.
			  

* __Keys__ - this property gets the collection of the persisted objects' __StorageId__ values.
			  

#### __C#__

{{region persistence-framework-isolated-storage_1}}
	private void Save(object sender, RoutedEventArgs e)
	{
	 IsolatedStorageProvider isoProvider = new IsolatedStorageProvider();
	 isoProvider.SaveToStorage();
	}
	private void Load(object sender, RoutedEventArgs e)
	{
	 IsolatedStorageProvider isoProvider = new IsolatedStorageProvider();
	 isoProvider.LoadFromStorage();
	}
	{{endregion}}



#### __VB.NET__

{{region persistence-framework-isolated-storage_2}}
	Private Sub Save(sender As Object, e As RoutedEventArgs)
		Dim isoProvider As New IsolatedStorageProvider()
		isoProvider.SaveToStorage()
	End Sub
	Private Sub Load(sender As Object, e As RoutedEventArgs)
		Dim isoProvider As New IsolatedStorageProvider()
		isoProvider.LoadFromStorage()
	End Sub
	{{endregion}}



The __IsolatedStorageProvider.SaveToStorage()__ method will save the properties of all controls for which the __telerik:PersistenceManager.StorageId__ attached property is set. In the above example all properties of the __RadTreeView__ and the __ContentControl__ will be saved:
		![](images/PersistenceFramework_IsolatedStorage_Initial.png)

1. Expand Condiments and select Gula Malacca. Add description for the item in the Details ContentControl. Then hit Save:![](images/PersistenceFramework_IsolatedStorage_Save.png)

2. Now change the layout of the UserControl - for example collapse Condiments and expand Confections. Then Select Maxilaku and add description for it. ![](images/PersistenceFramework_IsolatedStorage_Change.png)

3. If you want to retrieve the previous state of the controls in your page, all you need to do is hit Load:![](images/PersistenceFramework_IsolatedStorage_Load.png)
