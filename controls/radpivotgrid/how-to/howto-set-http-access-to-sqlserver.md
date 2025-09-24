---
title: Set HTTP access to SQL Server
page_title: Set HTTP access to SQL Server
description: Check our &quot;Set HTTP access to SQL Server&quot; documentation article for the RadPivotGrid {{ site.framework_name }} control.
slug: radpivotgrid-howto-set-http-access-to-sqlserver
tags: set,http,access,to,sql,server
published: True
position: 0
---

# Set HTTP access to SQL Server

In this article we will show you how to setup HTTP access to your Microsoft SQL Analysis Service which is needed if you intend to use XmlaDataProvider.

>As a prerequisite you must have installed Microsoft SQL Server and at least one OLAP Cube to be deployed there.

## Communication between client and server

__RadPivotGrid__ can communicate with OLAP Cube by using Extensible Markup Language for Analysis (XMLA). XMLA communication is over HTTP protocol where __RadPivotGrid__ is the client and SQL Analysis Service is the server. Analysis Service provides an XMLA listener compontent that handles all XMLA communications between Analysis Services and its clients. Analysis Service uses Internet Information Services (IIS) as a middleware component to enable access to data via HTTP. The communication is executed as follows:        

1. RadPivotGrid sends an HTTP post request to IIS using the IIS servername and path to service component (msmdpump.dll) as url.            

1. IIS receives the request, authenticates the sender, and creates a security context in which the pump will be executed.            

1. IIS starts pump and uses Internet Server Application Programming Interface ([ISAPI](http://en.wikipedia.org/wiki/Internet_Server_Application_Programming_Interface)) to communicate with pump.            

1. The pump connects to Analysis Service via TCP/IP and sends data received from RadPivotGrid without any change.            

1. Analysis Service executes the request and sends response to pump which passes response to __RadPivotGrid__.            

## Configuring Internet Information Services (IIS)

If you have not installed Internet Information Services(IIS) you can do it as described below:        

* Open "Control Panel" and select "Programs".            

* From "Programs and Features" menu choose "Turn Windows features on or off":

![Rad Pivot Grid How To Set Http Access To Cube 1](images/RadPivotGrid_HowTo_SetHttpAccessToCube_1.png)

* In the opened window find the folder Internet Information Services where you can find the features we need. The easiest and most suitable solution is to install everything and this way get things out of trouble, but the only mandatory things are: Web Management Tools, .NET Extensibility, ASP.NET, ISAPI Extensions, Basic Authentication and Windows Authentication.

![Rad Pivot Grid How To Set Http Access To Cube 2](images/RadPivotGrid_HowTo_SetHttpAccessToCube_2.png)

* When you click OK, IIS will be installed.            

It is time to configure our Internet Information Service (IIS). To do it start Internet Information Services Manager (just write IIS in the Start menu search and you will find it).        

1. In the IIS Manager right-click on Application Pools and click on Add New Application Pool. In the new window set this configuration:

	![Rad Pivot Grid How To Set Http Access To Cube 3](images/RadPivotGrid_HowTo_SetHttpAccessToCube_3.png)

	![Rad Pivot Grid How To Set Http Access To Cube 4](images/RadPivotGrid_HowTo_SetHttpAccessToCube_4.png)

1. Create folder called OLAP under C:\inetpub\wwwRoot.       

1. Copy the files msmdpump.dll, msmdpump.ini from "*Installation Folder*\Microsoft SQL Server\MSAS10_50.MSSQLSERVER\OLAP\bin\isapi to C:\inetpub\wwwRoot\OLAP folder.

	>The path may be slightly different based on the installed version of MS SQL Server.

1. Go to IIS and find OLAP folder under Default Web Site. Right Click on it and choose Convert to Application. Click OK to complete the operation.

1. Go to Handler Mappings option and double-click it (or use the "Open Feature" Action in the top right corner) then select "Edit Feature Permission" and make sure the directoy has "Read" and "Script" permissions.

	![Rad Pivot Grid How To Set Http Access To Cube 5](images/RadPivotGrid_HowTo_SetHttpAccessToCube_5.png)

	![Rad Pivot Grid How To Set Http Access To Cube 6](images/RadPivotGrid_HowTo_SetHttpAccessToCube_6.png)

1. In the top right coner of the "Handler Mappings" screen, click "Add Script Map...". And add following information.

	![Rad Pivot Grid How To Set Http Access To Cube 7](images/RadPivotGrid_HowTo_SetHttpAccessToCube_7.png)

1. When you click OK a warning message will be raised - click yes to confirm that you want to allow ISAPI extension.

	![Rad Pivot Grid How To Set Http Access To Cube 8](images/RadPivotGrid_HowTo_SetHttpAccessToCube_8.png)

1. After that on IIS go to "Application Pool" and select "ISAPI and CGI Restrictions" under security.

	![Rad Pivot Grid How To Set Http Access To Cube 9](images/RadPivotGrid_HowTo_SetHttpAccessToCube_9.png)

1. Find the item with the Path to your OLAP application (msmdpump.dll) and double-click it to add a description:

	![Rad Pivot Grid How To Set Http Access To Cube 10](images/RadPivotGrid_HowTo_SetHttpAccessToCube_10.png)

	![Rad Pivot Grid How To Set Http Access To Cube 11](images/RadPivotGrid_HowTo_SetHttpAccessToCube_11.png)

1. The last thing we have to set is the Authentication mode. From the OLAP virtual directory choose "Authentication". There are several different modes that you may use. More information about them can be found [here](http://msdn.microsoft.com/en-us/library/aa292114(v=vs.71).aspx). There most important thing that you have to remember is that the default user used by IIS is __IUSR__. There are two common problems you may face:            

	* Change the authentication mode in IIS and give access to other users instead of IUSR - this is okay for your security restrictions, but you have to apply your changes in the Analysis Services as well.                

	* Use the default authentication mode - this way IUSR user will be used to connect to Analysis Service. It is mandatory to give this user privileges in the Analysis Service. 

	To grant access to a specific user in your Analysis Service open a connection to your cube with Microsoft SQL Server Management Studio and add a new Role:

	![Rad Pivot Grid How To Set Http Access To Cube 12](images/RadPivotGrid_HowTo_SetHttpAccessToCube_12.png)

	![Rad Pivot Grid How To Set Http Access To Cube 13](images/RadPivotGrid_HowTo_SetHttpAccessToCube_13.png)

	>importantIn the General Tab above you can set database permissions for this role. Your users will need at least Read permissions.                

	After applying this you should be able to use XmlaDataProvider in your __RadPivotGrid__ to access the data from your Cube.	

## See Also

 * [Getting Started]({%slug radpivotgrid-getting-started%})

 * [RadPivotFieldList]({%slug radpivotgrid-fieldlist%})

 * [Using XmlaDataProvider]({%slug radpivotgrid-data-xmla%})
