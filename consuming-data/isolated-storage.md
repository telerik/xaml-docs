---
title: Isolated Storage
page_title: Isolated Storage
description: Isolated Storage
slug: consuming-data-isolated-storage
tags: isolated,storage
published: False
position: 7
site_name: Silverlight
---

# Isolated Storage



This tutorial will show you how to use the user isolated storage to read data for your Silverlight application.  

>tip__Silverlight__ uses __Isolated Storage__ as a virtual file system to store data in a hidden folder on your machine. It breaks up the data into two separate sections: Section #1 contains administrative information such as disk quota and section #2 contains the actual data. Each Silverlight application is allocated its own portion of the storage with the current quota set to be 1 MB per application.

## Reading Data from Isolated Storage

In order to read data for your application from the isolated storage, you need to perform the following steps:

* Obtain the user-scoped isolated storage:

#### __C#__

{{region consuming-data-isolated-storage_0}}
	IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication();
	{{endregion}}



#### __VB.NET__

{{region consuming-data-isolated-storage_1}}
	Dim isf As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
	{{endregion}}



* Create an instance of the __IsolatedStorageFileStream__class: 

#### __C#__

{{region consuming-data-isolated-storage_2}}
	IsolatedStorageFileStream isfs = new IsolatedStorageFileStream( fileName, FileMode.Open, isf );
	{{endregion}}



#### __VB.NET__

{{region consuming-data-isolated-storage_3}}
	Dim isfs As New IsolatedStorageFileStream(fileName, FileMode.Open, isf)
	{{endregion}}



* Read the data: 

#### __C#__

{{region consuming-data-isolated-storage_4}}
	using ( StreamReader sr = new StreamReader( isfs ) )
	{
	    string lineOfData = String.Empty;
	    while ( ( lineOfData = sr.ReadLine() ) != null )
	        data += lineOfData;
	}
	{{endregion}}



#### __VB.NET__

{{region consuming-data-isolated-storage_5}}
	Using sr As New StreamReader(isfs)
	    Dim lineOfData As String = sr.ReadLine()
	    While lineOfData IsNot Nothing
	        data += lineOfData
	        lineOfData = sr.ReadLine()
	    End While
	End Using
	{{endregion}}



Here is a complete code snippet showing how to read data from the isolated storage: 

#### __C#__

{{region consuming-data-isolated-storage_6}}
	private string LoadData( string fileName )
	{
	    string data = String.Empty;
	    using ( IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication() )
	    {
	        using ( IsolatedStorageFileStream isfs = new IsolatedStorageFileStream( fileName, FileMode.Open, isf ) )
	        {
	            using ( StreamReader sr = new StreamReader( isfs ) )
	            {
	                string lineOfData = String.Empty;
	                while ( ( lineOfData = sr.ReadLine() ) != null )
	                    data += lineOfData;
	            }
	        }
	    }
	    return data;
	}
	{{endregion}}



#### __VB.NET__

{{region consuming-data-isolated-storage_7}}
	Private Function LoadData(ByVal fileName As String) As String
	    Dim data As String = [String].Empty
	    Using isf As IsolatedStorageFile = IsolatedStorageFile.GetUserStoreForApplication()
	        Using isfs As New IsolatedStorageFileStream(fileName, FileMode.Open, isf)
	            Using sr As New StreamReader(isfs)
	                Dim lineOfData As String = sr.ReadLine()
	                While lineOfData IsNot Nothing
	                    data += lineOfData
	                    lineOfData = sr.ReadLine()
	                End While
	            End Using
	        End Using
	    End Using
	    Return data
	End Function
	{{endregion}}



## See Also

 * [In-Memory Data]({%slug consuming-data-in-memory-data%})

 * [Using XML]({%slug consuming-data-using-xml%})

 * [DomainDataSource Support]({%slug consuming-data-domain-datasource-support%})
