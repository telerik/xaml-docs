---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radcloudupload-getting-started
tags: getting,started
position: 2
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains __RadCloudUpload__.

* [Assembly references](#assembly-references)
* [Defining the UI](#defining-the-ui)
* [Creating the Provider](#creating-the-provider)

## Assembly References

In order to use __RadCloudUpload__, you will need to add references to the following assemblies:
* __Telerik.Windows.Controls__
* __Telerik.Windows.Cloud__
* __Telerik.Windows.Cloud.Controls__

You can find the required assemblies for each control from the suite in the [Controls Dependencies]({%slug installation-installing-controls-dependencies-wpf%}) help article.

## Defining the UI

The following example shows how to define a RadCloudUpload control and a RadCloudUploadList to show the selected files prepared for upload.

#### __[XAML] Example 1: Defining RadCloudUpload and RadCloudUploadList__
{{region radcloudupload-getting-started-1}}
	<Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto" />
            <RowDefinition />
        </Grid.RowDefinitions>        
        <telerik:RadCloudUpload x:Name="RadCloudUpload" />
        <telerik:RadCloudUploadList Grid.Row="1" ItemsSource="{Binding Items, ElementName=RadCloudUpload}"/>
    </Grid>
{{endregion}}

> The cloud upload control itself provides only a UI and an interface to execute the upload task. However, the upload process should be implemented with additional custom code. The next section shows how to set up this.

## Creating the Provider

RadCloudUpload uses a provider interface to upload files to the service of your choice. To create the provider you will need to define a class that implements the __ICloudUploadProvider__ interface. The interface exposes a single method - __UploadFileAsync__, which returns a __Task&lt;object&gt;__ object.

This secion will show you how to create a dummy provider that stores the files in a storage in memory. 

#### __[C#] Example 2: Creating a dummy storage and file classes__
{{region radcloudupload-getting-started-1}}
	public static class DummyStorage
	{
		public static ObservableCollection<StorageFile> StorageFiles { get; private set; }

		static DummyStorage()
		{
			StorageFiles = new ObservableCollection<StorageFile>();
		}
	}
	
	public class StorageFile
	{
		public string Name { get; set; }
		public long Size { get; set; }

		public StorageFile(string name, long size)
		{
			this.Name = name;
			this.Size = size;
		}
	}
{{endregion}}

#### __[C#] Example 3: Implementing a dummy ICloudUploadProvider that uploads files to the storage__
{{region radcloudupload-getting-started-2}}
	public class DummyProvider : ICloudUploadProvider
	{
		Random random = new Random();		

		public Task<object> UploadFileAsync(string fileName, Stream fileStream, CloudUploadFileProgressChanged uploadProgressChanged, CancellationToken cancellationToken)
		{
			return System.Threading.Tasks.Task.Factory.StartNew<object>(() => UploadFile(fileName, fileStream, uploadProgressChanged, cancellationToken), cancellationToken);
		}

		private object UploadFile(string fileName, Stream fileStream, CloudUploadFileProgressChanged uploadProgressChanged, CancellationToken cancellationToken)
		{			
            var fileLength = fileStream.Length;
            int uploadIterations = this.random.Next(10, 40);
            int chunkSize = (int)(fileLength / uploadIterations);

            for (int i = 0; i < uploadIterations; i++)
			{
                cancellationToken.ThrowIfCancellationRequested();
                uploadProgressChanged(i * chunkSize);
				Thread.Sleep(this.random.Next(200, 900));
			}

            uploadProgressChanged(fileLength);

            lock (DummyStorage.StorageFiles)
            {
                DummyStorage.StorageFiles.Add(new StorageFile(fileName, fileLength));
            }
			return fileName;
		}
	}
{{endregion}}

#### __[XAML] Example 4: Setting the provider__
{{region radcloudupload-getting-started-3}}
	<telerik:RadCloudUpload>
		<telerik:RadCloudUpload.Provider>
			<local:DummyProvider />
		</telerik:RadCloudUpload.Provider>
	</telerik:RadCloudUpload>
{{endregion}}

> The control doesn't have any built-in providers, but you can see how to implement one that connects to the Azure and Amazon services in the [RadCloudUpload SDK examples](https://github.com/telerik/xaml-sdk/tree/master/CloudUpload).

## See Also
* [RadCloudUploadList]({%slug radcloudupload-radclouduploadlist%})
* [Providers]({%slug radcloudupload-features-providers%})
* [Events]({%slug radcloudupload-features-events%})
* [Validation]({%slug radcloudupload-features-validation%})

