---
title: Working with ZipPackage
page_title: Working with ZipPackage
description: Working with ZipPackage
slug: radziplibrary-zippackage
tags: working,with,zippackage
published: True
position: 3
---

# Working with ZipPackage



When you want to work with Telerik ZipLibrary, you need to create a __ZipPackage__ object. In order to do so, you can take advantage of the __ZipPackage__ class static methods that allow you to create or open a zip package:
      

## ZipPackage Class Static Methods

* __Create(Stream stream)__ - this method is used to create a __ZipPackage__ from a stream. It returns a __ZipPackage__ object.
          

* __CreateFile(string fileName)__ - this method is used to create a __ZipPackage__ with a given fileName. It returns a __ZipPackage__ object.
          

* __IsZipFile(string fileName)__ - this method evaluates the file with the given *fileName* to check if it is a zip file.
          

* __IsZipFile(Stream stream)__ - this method evaluates the file with the given *stream* to check if it is a zip file.
          

* __Open(Stream stream, FileAccess access)__ - this method is used to open a __ZipPakcage__ from a stream. It returns a __ZipPackage__ object.
          

* __OpenFile(string fileName, FileAccess access)__ - this method is used to open a __ZipPackage__ with a given file name. It returns a __ZipPackage__ object.
          

## ZipPackage object 

When you create a __ZipPackage__ object using the above methods, it populates its __ZipPackageEntries__ collection of __ZipPackageEntry__ elements. You can further manipulate the __ZipPackage__ and its __ZipPackageEntries__ collection using the following methods:
        

* __Add(string fileName)__ -  this method adds a file with the passed file name in a __ZipPackage.__

* __Add(string[] fileNames)__ - this method adds the files from the array of file names in a __ZipPackage__.
          

* __Add(string fileName, string fileNameInZip)__ - this method adds a file with the given *fileName* in a __ZipPackage__ and associates it with a given *fileNameInZip*.
          

* __Add(string fileName, string fileNameInZip, DateTime dateTime)__ - this method adds a file with the given *fileName* in a __ZipPackage__, associates it with a given *fileNameInZip *and sets a __DateTime__ value for the entry.
          

* __AddStream(string fileNameInZip, Stream stream)__ - this method adds a stream in the __ZipPackage__ and associates it with a given *fileNameInZip*.
          

* __AddStream(ZipCompression method, string fileNameInZip, Stream stream, DateTime dateTime)__ - this method adds a stream in a __ZipPackage__, compresses it with a given compress method, associates it with a given *fileNameInZip *and sets a __DateTime__ value for the entry.
          

* __Close(bool shouldCloseStream)__ - this method closes a __ZipPackage__. If the *shouldCloseStream* value is set to false, the method only resets the internal values.
          

* __IndexOf(string fileNameInZip)__ - this method gets the index of the entry in the list of entries of a __ZipPackage__

* __RemoveEntry(ZipPackageEntry zipPackageEntry)__ - this method removes a given __ZipPackageEntry__ from a __ZipPackage__.
          

If you need to get the file name of a __ZipPackage__, you can use the __ZipPackage__ object __FileName__ property.
        

## ZipPackageEntry

The __ZipPackageEntry__ class describes each file archived in the __ZipPackage__ object. It exposes the following properties:
        

* __Attributes__ - this property is of type __FileAttributes__ and it gets the attributes that describe the entry.
            

* __CompressedSize__- this property is of type __int__and it gets the compressed size of the entry
            

* __FileNameInZip -__this property is of type __string__ and it gets the file name under which the entry is added in the __ZipPackage__

* __UncompressedSize__- this property is of type __int__and it gets the uncompressed size of the entry
            

If you want to get the stream that represents the __ZipPackageEntry__, you can take advantage of the __ZipPackageEntry.OpenInputStream()__method which returns the decompressed stream of the entry.
        

>tipYou can use the __ZipPackageEntry.OpenInputStream()__method, when an entry contains a compressed version of a string input. In such a scenario, you can get the original string, by using a __StreamReader__ to read the decompressed stream of the entry as follows:
          

	
StreamReader streamReader = new StreamReader(entry.OpenInputStream());
string originalText = streamReader.ReadToEnd();
		  



	
Dim streamReader As New StreamReader(entry.OpenInputStream())
Dim originalText As String = streamReader.ReadToEnd()
		  



##  Load data from existing Zip files

In order to load data from existing ZIP files you can take advantage of the __ZipPackage__ class and its methods.
        

For the purpose of this example, let's create a __RadButton__ to browse for a __zip__ file:
        

#### __XAML__

{{region radziplibrary-gettingstarted_0}}
	<telerik:RadButton x:Name="buttonOpen" Content="Read Zip File" Click="buttonOpen_Click" Margin="0 2" />
	{{endregion}}



And when the button is clicked you can use the __OpenFileDialog__ to browse and open a __zip__ file:
        

#### __C#__

{{region radziplibrary-gettingstarted_1}}
	private void buttonOpen_Click(object sender, RoutedEventArgs e)
	{
	    OpenFileDialog dialog = new OpenFileDialog();
	    dialog.Filter = "Zip File | *.zip";
	    bool? dialogResult = dialog.ShowDialog();
	}
	{{endregion}}



#### __VB.NET__

{{region radziplibrary-gettingstarted_2}}
	Private Sub buttonOpen_Click(sender As Object, e As RoutedEventArgs)
	        Dim dialog As New OpenFileDialog()
	        dialog.Filter = "Zip File | *.zip"
	        Dim dialogResult As System.Nullable(Of Boolean) = dialog.ShowDialog()
	End Sub
	{{endregion}}



Then the __ZipPackage__ can extract the content of the selected *__zip__* file using its stream:
        

#### __C#__

{{region radziplibrary-gettingstarted_3}}
	if (dialogResult == true)
	{
	    Stream stream = dialog.File.OpenRead();
	    using (ZipPackage zipPackage = ZipPackage.Open(stream, FileAccess.Read))
	    {
	        //display the list of files compressed in the selected zip file using the zipPackage.ZipPackageEntries
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radziplibrary-gettingstarted_4}}
	If dialogResult = True Then
	        Dim stream As Stream = dialog.File.OpenRead()
	                        'display the list of files compressed in the selected zip file using the zipPackage.ZipPackageEntries
	        Using _zipPackage As ZipPackage = ZipPackage.Open(stream, FileAccess.Read)
	        End Using
	End If
	{{endregion}}



#### __C#__

{{region radziplibrary-gettingstarted_5}}
	private void buttonOpen_Click(object sender, RoutedEventArgs e)
	{
	    OpenFileDialog dialog = new OpenFileDialog();
	    dialog.Filter = "Zip File | *.zip";
	    bool? dialogResult = dialog.ShowDialog();
	    if (dialogResult == true)
	    {
	        Stream stream = dialog.OpenFile();
	        using (ZipPackage zipPackage = ZipPackage.Open(stream, FileAccess.Read))
	        {
	            //display the list of files compressed in the selected zip file using the zipPackage.ZipPackageEntries
	        }
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radziplibrary-gettingstarted_6}}
	Private Sub buttonOpen_Click(sender As Object, e As RoutedEventArgs)
	        Dim dialog As New OpenFileDialog()
	        dialog.Filter = "Zip File | *.zip"
	        Dim dialogResult As System.Nullable(Of Boolean) = dialog.ShowDialog()
	
	        If dialogResult = True Then
	                Dim stream As Stream = dialog.OpenFile()
	
	                Using _zipPackage As ZipPackage = ZipPackage.Open(stream, FileAccess.Read)
	                        'display the list of files compressed in the selected zip file using the zipPackage.ZipPackageEntries
	                End Using
	        End If
	End Sub
	{{endregion}}



The __zipPackage__ variable will hold the files that are compressed in the selected __zip__. You can access the list of these files through the __ZipPackageEntries__ collection. It holds a collection of __ZipPackageEntry__ elements - the elements that describe the files archived in the __zip__ file. You can use these elements to get the name of the compressed file, its uncompressed and compressed size and other file attributes.
        

For example if you define a __RadTreeListView__ control, you can use it to display information about the selected __zip__ file content:
        

#### __XAML__

{{region radziplibrary-gettingstarted_7}}
	<StackPanel x:Name="LayoutRoot" Background="White">
	
	    <telerik:RadButton x:Name="buttonOpen"
	                        Margin="0 2"
	                        HorizontalAlignment="Center"
	                        Click="buttonOpen_Click"
	                        Content="Read Zip File"
	                        FontWeight="Bold" />
	
	    <telerik:RadTreeListView x:Name="FileList" AutoGenerateColumns="False">
	        <telerik:RadTreeListView.Columns>
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding FileNameInZip}" Header="File name" />
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding UncompressedSize}" Header="Uncompressed size" />
	            <telerik:GridViewDataColumn DataMemberBinding="{Binding CompressedSize}" Header="Compressed size" />
	        </telerik:RadTreeListView.Columns>
	    </telerik:RadTreeListView>
	
	</StackPanel>
	{{endregion}}



#### __C#__

{{region radziplibrary-gettingstarted_8}}
	private void buttonOpen_Click(object sender, RoutedEventArgs e)
	{
	    OpenFileDialog dialog = new OpenFileDialog();
	    dialog.Filter = "Zip File | *.zip";
	    bool? dialogResult = dialog.ShowDialog();
	    if (dialogResult == true)
	    {
	        Stream stream = dialog.File.OpenRead();
	        using (ZipPackage zipPackage = ZipPackage.Open(stream, FileAccess.Read))
	        {
	            FileList.ItemsSource = zipPackage.ZipPackageEntries;
	        }
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radziplibrary-gettingstarted_9}}
	Private Sub buttonOpen_Click(sender As Object, e As RoutedEventArgs)
	        Dim dialog As New OpenFileDialog()
	        dialog.Filter = "Zip File | *.zip"
	        Dim dialogResult As System.Nullable(Of Boolean) = dialog.ShowDialog()
	
	        If dialogResult = True Then
	                Dim stream As Stream = dialog.File.OpenRead()
	
	                Using _zipPackage As ZipPackage = ZipPackage.Open(stream, FileAccess.Read)
	                        FileList.ItemsSource = _zipPackage.ZipPackageEntries
	                End Using
	        End If
	End Sub
	{{endregion}}



#### __C#__

{{region radziplibrary-gettingstarted_10}}
	private void buttonOpen_Click(object sender, RoutedEventArgs e)
	{
	    OpenFileDialog dialog = new OpenFileDialog();
	    dialog.Filter = "Zip File | *.zip";
	    bool? dialogResult = dialog.ShowDialog();
	    if (dialogResult == true)
	    {
	        Stream stream = dialog.OpenFile();
	        using (ZipPackage zipPackage = ZipPackage.Open(stream, FileAccess.Read))
	        {
	            FileList.ItemsSource = zipPackage.ZipPackageEntries;
	        }
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radziplibrary-gettingstarted_11}}
	Private Sub buttonOpen_Click(sender As Object, e As RoutedEventArgs)
	        Dim dialog As New OpenFileDialog()
	        dialog.Filter = "Zip File | *.zip"
	        Dim dialogResult As System.Nullable(Of Boolean) = dialog.ShowDialog()
	
	        If dialogResult = True Then
	                Dim stream As Stream = dialog.OpenFile()
	
	                Using _zipPackage As ZipPackage = ZipPackage.Open(stream, FileAccess.Read)
	                        FileList.ItemsSource = _zipPackage.ZipPackageEntries
	                End Using
	        End If
	End Sub
	{{endregion}}



## Save files in a zip

The __ZipPackage__ class allows you to archive a list of files in a __zip.__For the purpose of this example, let's assume that your application provides a list of __DataFiles__ in a __SelectedFiles__ collection. Each __DataFile__ entry in the __SelectedFiles__ collection contains the stream of the file and its name:
        

#### __C#__

{{region radziplibrary-gettingstarted_12}}
	public class DataFile
	{
	 public MemoryStream FileStream { get; set; }
	 public string FileName { get; set; }
	}
	{{endregion}}



#### __VB.NET__

{{region radziplibrary-gettingstarted_13}}
	Public Class DataFile
		Public Property FileStream() As MemoryStream
			Get
				Return m_FileStream
			End Get
			Set
				m_FileStream = Value
			End Set
		End Property
		Private m_FileStream As MemoryStream
		Public Property FileName() As String
			Get
				Return m_FileName
			End Get
			Set
				m_FileName = Value
			End Set
		End Property
		Private m_FileName As String
	End Class
	{{endregion}}



In this case you can use the __ZipPackage.AddStream__ method to save the files in a __zip.__

Let's start by defining a __RadButton__ to save the zip file:
        

#### __XAML__

{{region radziplibrary-gettingstarted_14}}
	<telerik:RadButton x:Name="buttonSave" Content="Save Zip File" Click="buttonSave_Click" Margin="0 2" />
	{{endregion}}



Then when the button is clicked, save the files's streams in a __zip__ using the Telerik __Zip Library ZipPackage__ class:
        

#### __C#__

{{region radziplibrary-gettingstarted_15}}
	private void buttonSave_Click(object sender, RoutedEventArgs e)
	{
	    SaveFileDialog dialog = new SaveFileDialog();                
	    dialog.Filter = "Zip File | *.zip";              
	    bool? dialogResult = dialog.ShowDialog();
	    if (dialogResult == true)
	    {
	        using (ZipPackage zipPackage = ZipPackage.Create(dialog.OpenFile()))
	        {
	            foreach (DataFile file in SelectedFiles)
	            {
	                zipPackage.AddStream(file.FileName, file.FileStream);
	            }
	        }
	    }
	}
	{{endregion}}



#### __VB.NET__

{{region radziplibrary-gettingstarted_16}}
	Private Sub buttonSave_Click(sender As Object, e As RoutedEventArgs)
		Dim dialog As New SaveFileDialog()
		dialog.Filter = "Zip File | *.zip"
		Dim dialogResult As System.Nullable(Of Boolean) = dialog.ShowDialog()
		If dialogResult = True Then
			Using zipPackage__1 As ZipPackage = ZipPackage.Create(dialog.OpenFile())
				For Each file As DataFile In SelectedFiles
					zipPackage__1.AddStream(file.FileName, file.FileStream)
				Next
			End Using
		End If
	End Sub
	{{endregion}}





# See Also

 * [How to compress and decompress a stream]({%slug radziplibrary-howto-compress-decompress-stream%})
