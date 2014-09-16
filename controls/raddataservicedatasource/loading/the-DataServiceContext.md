---
title: The DataServiceContext
page_title: The DataServiceContext
description: The DataServiceContext
slug: raddataservicedatasource-loading-the-dataservicecontext
tags: the,dataservicecontext
publish: True
position: 0
---

# The DataServiceContext



RadDataServiceDataSource requires a DataServiceContext and a DataServiceQuery<T> in order to connect to a remote server. 

## The DataServiceContext

A class that derives from the DataServiceContext class will be automatically generated for you when you add the Service Reference to your project. It can be located in the generated code-behind file of your Service Reference. You might need to select the Show All Files option in Solution Explorer in order to see the code-behind file. 

{% if site.site_name == 'WPF' %}


				 
			![](images/RadDataServiceDataSource_GeneratedClientCode_WPF.png){% endif %}{% if site.site_name == 'Silverlight' %}


				 
			![](images/RadDataServiceDataSource_GeneratedClientCode_SL.png){% endif %}

A typical auto-generated DataServiceContext class will look like this:

#### __C#__

{{region raddataservicedatasource-loading-the-DataServiceContext_0}}
	public partial class NorthwindEntities : global::System.Data.Services.Client.DataServiceContext
	{{endregion}}



#### __VB.NET__

{{region raddataservicedatasource-loading-the-DataServiceContext_1}}
	Partial Public Class NorthwindEntities Inherits Global.System.Data.Services.Client.DataServiceContext
	{{endregion}}



## Setting DataServiceContext in code-behind

In order to create an instance of the DataServiceContext class, you need to specify the WCF Data Service Uri in its constructor. The simply assign to the respective property on RadDataServiceDataSource:

#### __C#__

{{region raddataservicedatasource-loading-the-DataServiceContext_2}}
	Uri serviceUri = new Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute);
	NorthwindEntities northwindContext = new NorthwindEntities(serviceUri);
	this.radDataServiceDataSource.DataServiceContext = northwindContext;
	{{endregion}}



#### __VB.NET__

{{region raddataservicedatasource-loading-the-DataServiceContext_3}}
	Dim serviceUri As New Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute)
	Dim northwindContext As New NorthwindEntities(serviceUri)
	Me.radDataServiceDataSource.DataServiceContext = northwindContextSetting DataServiceContext in XAML
	{{endregion}}





## Setting DataServiceContext in XAML

Since the DataServiceContext class does not have a parameterless constructor, it cannot be directly instantiated in XAML. This can be worked around by creating another class with a parameterless constructor that derives from it and then hard-coding the Uri in the call to the base constructor:

#### __C#__

{{region raddataservicedatasource-loading-the-DataServiceContext_4}}
	public class MyNorthwindContext : NorthwindEntities
	{
	    public MyNorthwindContext() : base(new Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute)){}
	}
	{{endregion}}



#### __VB.NET__

{{region raddataservicedatasource-loading-the-DataServiceContext_5}}
	Public Class MyNorthwindContext
	 Inherits NorthwindEntities
	 Public Sub New()
	  MyBase.New(New Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute))
	 End Sub
	End Class
	{{endregion}}



Once you have a context class with a parameterless constructor, you can easily instantiate it in XAML:

#### __XAML__

{{region raddataservicedatasource-loading-the-DataServiceContext_6}}
	<telerik:RadDataServiceDataSource Name="customersDataSource" QueryName="Customers" AutoLoad="True">
	  <telerik:RadDataServiceDataSource.DataServiceContext>
	     <local:MyNorthwindContext/>
	  </telerik:RadDataServiceDataSource.DataServiceContext>
	</telerik:RadDataServiceDataSource>
	{{endregion}}



>The only DataServiceContext.MergeOption that is supported is MergeOption.OverwriteChanges. Setting the DataServiceContext.MergeOption to anything else will result in an error.
