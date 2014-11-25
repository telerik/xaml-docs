---
title: Creating the Client Application
page_title: Creating the Client Application
description: Creating the Client Application
slug: raddataservicedatasource-getting-started-creating-the-client-application
tags: creating,the,client,application
published: True
position: 1
---

# Creating the Client Application



## 

Once you have created the _Server Application_, you may start developing the _Client_ one. {% if site.site_name == 'WPF' %}

To display the data from the __WCF Data Service__, create a new WPF application with a data source that is based on the service. Later in this walk-through, you will add data-bound controls to the application.

1. In __Solution Explorer__, right-click the solution node, click __Add__, and select __New Project__.

1. In the __New Project__ dialog, expand __Visual C#__ or __Visual Basic__, and then select __Windows__.

1. Select the __WPF Application__ project template.

1. In the __Name__ box, type ***NorthwindExplorer*** and click __OK__. __Visual Studio__ adds the ___NorthwindExplorer___ project to the solution.

1. On the __Data__ menu, click __Show Data Sources__. The __Data Sources__ window opens.

1. In the __Data Sources__ window, click __Add New Data Source__. The __Data Source Configuration Wizard__ opens.

1. In the __Choose a Data Source Type__ page of the wizard, select __Service__ and then click __Next__.

1. {% if site.site_name == 'WPF' %}In the __Address__ box, type {% endif %}[http://services.odata.org/Northwind/Northwind.svc](http://services.odata.org/Northwind/Northwind.svc){% if site.site_name == 'WPF' %} and then click __Go__.{% endif %}

1. __Visual Studio__ searches the specified address for available services, and adds ___NorthwindEntities___ to the list of available services in the __Services__ box.

1. In the __Namespace__ box, type ___NorthwindService___.

1. In the __Services__ box, click __NorthwindEntities__ and then click __OK__. Visual Studio downloads the service information and then returns to the __Data Source Configuration Wizard__. 

1. In the __Add Service Reference__ page, click __Finish__.  __Visual Studio__ adds nodes that represent the data returned by the service to the __Data Sources__ window. 

1. On the __Project__ menu, click __Add Class__.

1. Change the name to ___MyNorthwindContext___, and click __Add__. 

1. Replace the class declaration with the following code:{% endif %}{% if site.site_name == 'WPF' %}

#### __C#__

{{region raddataservicedatasource-getting-started-creating-the-client-application_0}}

	public class MyNorthwindContext : NorthwindEntities
	{
	 public MyNorthwindContext() : base(new Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute)){}
	}
{{endregion}}



#### __VB.NET__

{{region raddataservicedatasource-getting-started-creating-the-client-application_1}}

	Public Class MyNorthwindContext
	 Inherits NorthwindEntities
	 Public Sub New()
	  MyBase.New(New Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute))
	 End Sub
	End Class
{{endregion}}



When we added the ___Service Reference___, __Visual Studio__ generated a hidden file that contains all client-side proxy classes. You can find this file if you tell the ___Solution Explorer___ to ___“Show All Files”___ and then drill-down in the ___Service References___ node all the way to the file called ___Reference___. When you use the ___Add Service Reference___ dialog to add a data service to an application, an entity container class is created that inherits from the __DataServiceContext__ class. This class includes properties that return typed __DataServiceQuery__ instances. In this case this class is called ___NorthwindEntities___ and we have further derived from it in order to specify the __Uri__ where it should get its data from. This was done so we can easily declare __RadDataServiceDataSource.DataServiceContext__ in XAML later on.{% endif %}{% if site.site_name == 'WPF' %}

{% if site.site_name == 'WPF' %}![](images/RadDataServiceDataSource_GeneratedClientCode_WPF.png){% endif %}{% endif %}{% if site.site_name == 'Silverlight' %}

To display the data from the __WCF Data Service__, create a new __Silverlight__ application with a data source that is based on the service. Later in this walk-through, you will add data-bound controls to the application.

1. In ___Solution Explorer___, right-click the solution node, click ___Add___, and select ___New Project___.

1. In the ___New Project___ dialog, expand ___Visual C#___ or ___Visual Basic___, and then select __Silverlight__.

1. Select the ___Silverlight Application___ project template.

1. In the __Name__ box, type ___NorthwindExplorer___ and click ___OK___. The ___New Silverlight Application Wizard___ opens.

1. __Uncheck__ the __Web site__ check-box and click ___OK___. __Visual Studio__ adds the ___NorthwindExplorer___ project to the solution.
 ![Rad Data Service Data Source newsilverlightapplication 01](images/RadDataServiceDataSource_newsilverlightapplication01.PNG)

1. On the __Data__ menu, click ___Show Data Sources___. The __Data Sources__ window opens.

1. In the __Data Sources__ window, click ___Add New Data Source___. The ___Data Source Configuration Wizard___ opens.

1. In the ___Choose a Data Source Type___ page of the wizard, select __Service__ and then click __Next__.

1. In the __Address__ box, type [http://services.odata.org/Northwind/Northwind.svc](http://services.odata.org/Northwind/Northwind.svc) and then click ___Go___.
            

1. __Visual Studio__ searches the specified address for available services, and adds ___NorthwindEntities___ to the list of available services in the __Services__ box.

1. In the __Namespace__ box, type ___NorthwindService___.

1. In the __Services__ box, click ___NorthwindEntities___ and then click ___OK___. __Visual Studio__ downloads the service information and then returns to the ___Data Source Configuration Wizard___.

1. In the ___Add Service Reference___ page, click __Finish__.  __Visual Studio__ adds nodes that represent the data returned by the service to the __Data Sources__ window.

1. On the __Project__ menu, click ___Add Class___.

1. Change the name to ___MyNorthwindContext___, and click __Add__.

1. Replace the class declaration with the following code:

#### __C#__

{{region raddataservicedatasource-getting-started-creating-the-client-application_2}}

	public class MyNorthwindContext : NorthwindEntities
	{
	 public MyNorthwindContext() : base(new Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute)){}
	}
{{endregion}}



#### __VB.NET__

{{region raddataservicedatasource-getting-started-creating-the-client-application_3}}

	Public Class MyNorthwindContext
	 Inherits NorthwindEntities
	 Public Sub New()
	  MyBase.New(New Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute))
	 End Sub
	End Class
{{endregion}}



When we added the ___Service Reference___, __Visual Studio__ generated a hidden file that contains all client-side proxy classes. You can find this file if you tell the __Solution Explorer__ to ___“Show All Files”___ and then drill-down in the __Service References__ node all the way to the file called __Reference__. When you use the ___Add Service Reference___ dialog to add a data service to an application, an entity container class is created that inherits from the __DataServiceContext__ class. This class includes properties that return typed __DataServiceQuery__ instances. In this case this class is called __NorthwindEntities__ and we have further derived from it in order to specify the __Uri__ where it should get its data from. This was done so we can easily declare __RadDataServiceDataSource.DataServiceContext__ in XAML later on.{% endif %}{% if site.site_name == 'Silverlight' %}

![](images/RadDataServiceDataSource_GeneratedClientCode_SL.png){% endif %}



# See Also

[Creating the Server Application]({%slug raddataservicedatasource-getting-started-creating-the-server-application%})

[Creating the Data-bound Controls]({%slug raddataservicedatasource-getting-started-creating-the-data-bound-controls%}){% if site.site_name == 'Silverlight' %}

{% endif %}
