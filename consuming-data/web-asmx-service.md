---
title: Consuming Web (asmx) Service
page_title: Consuming Web (asmx) Service
description: Consuming Web (asmx) Service
slug: consuming-data-web-asmx-service
tags: consuming,web,(asmx),service
published: True
position: 3
site_name: Silverlight
---

# Consuming Web (asmx) Service



The purpose of this tutorial is to show you how to make a call to a Web Service in the context of a {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} application. The following common tasks will be examined:

* Adding a reference.

* Creating a new instance of the service.

* Making {% if site.site_name == 'Silverlight' %}asynchronous{% endif %} call to the service.{% if site.site_name == 'Silverlight' %}

* Consuming the service result.
        {% endif %}

>The process of developing a Web Service is beyond the scope of this tutorial. For more information read [here](http://msdn.microsoft.com/en-us/library/t745kdsh.aspx).

>This tutorial will use the __Northwind__ database, which can be download it from [here](http://www.microsoft.com/downloads/details.aspx?FamilyID=06616212-0356-46A0-8DA2-EEBC53A68034&displaylang=en).

For the purpose of this tutorial will be used a service that exposes the following method:

* __LoadCategories__ - load all categories from the __Categories__ table in the Northwind database. 

## Adding A Reference

The first step is to add a new service reference to your application. In order to do that you need to perform the following steps:

* Select the "__References__" folder, right click with your mouse button and choose "__Add Service Reference...__"
![Common Consuming Data Web Service 010](images/Common_ConsumingDataWebService_010.png)

* A popup window appears, hit the __Discover__ button to find the web service or enter the service location. Press 'OK' to add it.
![Common Consuming Data Web Service 020](images/Common_ConsumingDataWebService_020.png)

>You have the ability to choose the type of the collections that the service returns. In order to do that you need to open the __Service Reference Settings__ dialog from the __Advanced__ button.
![Common Consuming Data Web Service 030](images/Common_ConsumingDataWebService_030.png)

When a service reference is added to a project, any types defined in the service are generated in the local project. In many cases, this creates duplicate types when a service uses common .NET Framework types or when types are defined in a shared library. To avoid this problem, types in referenced assemblies are shared by default. If you want to disable type sharing for one or more assemblies, you can do so in the __Service Reference Settings__ dialog.

Once the Web service is added all needed assemblies and configuration files will be included in your project automatically. 

## Creating New Instance of the Service

Creating new instance of the service is pretty simple process.

#### __C#__

{{region consuming-data-web-asmx-service_0}}
	WebService.SampleWebServiceSoapClient serviceClient = new WebService.SampleWebServiceSoapClient();
	{{endregion}}



#### __VB.NET__

{{region consuming-data-web-asmx-service_1}}
	Dim serviceClient As New WebService.SampleWebServiceSoapClient()
	{{endregion}}



>Don't forget to give a meaningful name for your Web Service namespace. In the previous example the namespace is "WebService".

## Making Asynchronous Call to the Service{% if site.site_name == 'Silverlight' %}

In Silverlight all service calls are performed asynchronously. In order to make an asynchronous call to your service you need to do the following steps:

* Attach to the event fired when the executed method completes.

* Execute the method asynchronously.

Here is a sample code showing how this can be achieved:

#### __C#__

{{region consuming-data-web-asmx-service_2}}
	serviceClient.LoadCategoriesCompleted += new EventHandler<CSharp.WebService.LoadCategoriesCompletedEventArgs>( serviceClient_LoadCategoriesCompleted );
	serviceClient.LoadCategoriesAsync();
	{{endregion}}



#### __VB.NET__

{{region consuming-data-web-asmx-service_3}}
	AddHandler serviceClient.LoadCategoriesCompleted, AddressOf serviceClient_LoadCategoriesCompleted
	serviceClient.LoadCategoriesAsync()
	{{endregion}}

{% endif %}{% if site.site_name == 'WPF' %}

In order to make a call to your service, you just need to invoke the exposed by the service method. 

#### __C#__

{{region consuming-data-web-asmx-service_4}}
	foreach( Categories c in serviceClient.LoadCategories() )
	{
	    this.Categories.Add( c );
	}
	{{endregion}}



#### __VB.NET__

{{region consuming-data-web-asmx-service_5}}
	For Each c As Categories In serviceClient.LoadCategories()
	    Me.Categories.Add(c)
	Next
	{{endregion}}

{% endif %}

# See Also

 * [Consuming WCF Service]({%slug consuming-data-wcf-service%})

 * [Consuming WCF Data Service]({%slug consuming-data-ado-net-data-service%})

 * [Consuming .NET RIA Service]({%slug consuming-data-net-ria-service%})
