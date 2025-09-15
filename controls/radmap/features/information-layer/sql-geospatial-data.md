---
title: SQL Geospatial Data
page_title: SQL Geospatial Data
description: Check our &quot;SQL Geospatial Data&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-features-sql-geospatial-data
tags: sql,geospatial,data
published: True
position: 14
---

# SQL Geospatial Data

RadMap supports binding to SQL Geospatial data. The control allows generating map shapes from any *IEnumerable* instance (for example a row collection) which contains a property with geospatial data in __Wkt__ (Well known text) or __Wkb__ (Well known binary) format. The __Source__ property and the __GeospatialPropertyName__ property are used to specify the *IEnumerable* instance and the name of the property which contains the Geospatial data.        

The __SqlGeospatialDataReader__ supports the following geometry types:        

* Point 

* LineString 

* Polygon 

* Triangle 

* MultiPoint 

* MultiLineString 

* MultiPolygon 

* GeometryCollection          

The coordinates for geometries may be 2D (x, y), 3D (x, y, z), 4D (x, y, z, m) with an m value that is part of a linear referencing system or 2D with an m value (x, y, m). However the __SqlGeospatialDataReader__ uses the x and y coordinates only, so that the z and m coordinates will be ignored. The __SqlGeospatialDataReader__ can be used in the InformationLayer.Reader property the same way as the MapShapeReader. The sample code is below:        

#### __XAML__
```XAML
	<telerik:InformationLayer x:Name="informationLayer">
	    <telerik:InformationLayer.Reader>
	        <telerik:SqlGeospatialDataReader x:Name="sqlGeospatialDataReader" 
	                   ExtendedPropertySet="Area,string Latitude,double Longitude,double"
	                   Source="{Binding Source={StaticResource domainServiceContext}, Path=LocationsWKTs}"
	                   GeospatialPropertyName="Point" ToolTipFormat="Area" PreviewReadCompleted="reader_PreviewReadCompleted" />
	    </telerik:InformationLayer.Reader>
	</telerik:InformationLayer>
```

It allows using the __ClearLayer__, __ExtendedPropertySet__, __ToolTipFormat__, __ToolTipTemplate__, __ToolTipStyle__ and __CoordinateConverter__ properties the same way they are used in MapShapeReader. Also it supports the PreviewReadCompleted and ReadCompleted events which are used in MapShapeReader.        

The __SqlGeospatialDataReader__ class allows using the following data sources:        

* Domain Service

* Wcf Data Service 

* ADO.NET Entity Data Model

* Linq to SQL 

* DataSet

* Telerik OpenAccess Domain Model

Also the __SqlGeospatialDataReader__ can use any custom data class which implements the IEnumerable interface and contains a property with geospatial data in __Wkt__ (Well known text) or __Wkb__ (Well known binary) format. In this case the geospatial property should be a string, byte array or any other type which allows to get geospatial data in Wkt using the ToString() method. Note, the data models in __Visual Studio 2010__ (except the Telerik OpenAccess Domain Model) do not allow to use native SQL geospatial field types. You will need to create for example appropriate views on the SQL server which converts the native geospatial field to WKT or WKB formatted field. It could be done using the __STAsText__ and __STAsBinary__ stored procedures. A sample view definition is shown:        

#### __SQL__
```SQL
	SELECT        id, Area, Latitude, Longitude, GeoLocation.STAsBinary() AS Point
	FROM            dbo.Locations
```

{% if site.site_name == 'WPF' %}
If you use *Entity Data Model*, *Linq to SQL* or *Telerik OpenAccess Domain Model* in your WPF application, then you can use the following sample XAML code to display your geospatial data: 
{% endif %}

#### __XAML__
```XAML
	<Window x:Class="EntityDataModelTest.MainWindow"
	        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	        xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	        xmlns:local="clr-namespace:EntityDataModelTest"
	        Title="MainWindow" Height="350" Width="525">
		<Window.Resources>
			<local:Database1Entities x:Key="dataBase" />
		</Window.Resources>
		<Grid x:Name="LayoutRoot">
			<telerik:RadMap x:Name="radMap"
				Center="40,-100"
				ZoomLevel="3">
				<telerik:RadMap.Provider>
					<telerik:OpenStreetMapProvider />
				</telerik:RadMap.Provider>
				<telerik:InformationLayer x:Name="informationLayer">
					<telerik:InformationLayer.Reader>
						<telerik:SqlGeospatialDataReader x:Name="sqlGeospatialDataReader" 
											 GeospatialPropertyName="Point"
											 Source="{Binding Source={StaticResource dataBase}, Path=LocationsWKB}"
											 ToolTipFormat="{}{Area} ({Latitude} : {Longitude})"
											 PreviewReadCompleted="reader_PreviewReadCompleted" />
					</telerik:InformationLayer.Reader>
				</telerik:InformationLayer>
			</telerik:RadMap>
		</Grid>
	</Window>
```

{% if site.site_name == 'Silverlight' %}
If you use *Wcf Data Service* or *Domain Service* in your Silverlight application, then their instances cannot be used directly to get the geospatial table data for the __SqlGeospatialDataReader__. Source property. In this case the geospatial data is retrieved asynchronously. So, you should use the __Completed__ event to set the *SqlGeospatialDataReader.Source*. It will be useful to use the small proxy class like to the following sample class for *Domain Service*:
{% endif %}

#### __C#__
```C#
	public class DomainServiceContext : INotifyPropertyChanged
	{
	  private DomainService1 domainService1Context = new DomainService1();
	  private IEnumerable locationsWKTs;
	  public new IEnumerable LocationsWKTs
	  {
	   get
	  {
	    if (this.locationsWKTs == null)
	  {
	    var loadOp = this.domainService1Context.Load(this.domainService1Context.GetLocationsWKTsQuery());
	    loadOp.Completed += new EventHandler(loadOp_Completed);
	  }
	return this.locationsWKTs;
	}
	　set
	  {
	   this.locationsWKTs = value;
	   this.OnPropertyChanged("LocationsWKTs");
	   }
	}　
	private void loadOp_Completed(object sender, EventArgs e)
	   {
	    var loadOp = sender as LoadOperation;
	    if (loadOp != null)
	     {
	      this.LocationsWKTs = loadOp.Entities;
	     }
	  }
	
	　public event PropertyChangedEventHandler PropertyChanged;
	
	private void OnPropertyChanged(string name)
	 {
	   PropertyChangedEventHandler handler = PropertyChanged;
	  if (handler != null)
	   {
	     handler(this, new PropertyChangedEventArgs(name));
	    }
	  }
	}
```

#### __VB.NET__
```VB.NET
	Public Class DataBaseContext
	      Inherits Database1Entities1
	      Implements INotifyPropertyChanged
		Public Sub New()
			  MyBase.New(New Uri("http://localhost:6838/WcfDataService1.svc"))
		End Sub
		Private locationsWKBs_Renamed As IEnumerable
		Public Shadows Property LocationsWKBs() As IEnumerable
			  Get
					If Me.locationsWKBs_Renamed Is Nothing Then
						  Dim query = MyBase.LocationsWKBs
						  Me.RunDataServiceQuery(query)
					End If

					Return Me.locationsWKBs_Renamed
			  End Get

			  Set(ByVal value As IEnumerable)
					Me.locationsWKBs_Renamed = value
					Me.OnPropertyChanged("LocationsWKBs")
			  End Set
		End Property

		Public Sub RunDataServiceQuery(Of T)(ByVal query As IQueryable(Of T))
			  Dim entity = New DataServiceCollection(Of T)()

			  AddHandler entity.LoadCompleted, AddressOf entity_LoadCompleted
			  entity.LoadAsync(query)
		End Sub

		Private Sub entity_LoadCompleted(ByVal sender As Object, ByVal e As LoadCompletedEventArgs)
			  Me.LocationsWKBs = TryCast(sender, IEnumerable)
		End Sub

		Public Event PropertyChanged As PropertyChangedEventHandler

		Private Sub OnPropertyChanged(ByVal name As String)
			  Dim handler As PropertyChangedEventHandler = PropertyChangedEvent
			  If handler IsNot Nothing Then
					handler(Me, New PropertyChangedEventArgs(name))
			  End If
		End Sub
	End Class
```

>tip In our {% if site.site_name == 'Silverlight' %}[SDK examples repository](https://github.com/telerik/xaml-sdk/tree/master/Map/Silverlight/SQLGeospatialData){% else %}[SDK examples repository](https://github.com/telerik/xaml-sdk/tree/master/Map/WPF/SQLGeospatialData){% endif %} you can find a runnable example showing how to define a Wkt reader that loads sample data from a collection of Wkt based objects. 
