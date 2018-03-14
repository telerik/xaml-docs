---
title: Blob Storage
page_title: Blob Storage
description: Blob Storage
slug: cloud-integration-azure-blob-storage
tags: cloud,integration, radcloudupload,azureprovider
published: True
position: 4
---

# Blob Storage

This article will demonstrate how to connect the [RadCloudUpload]({%slug radcloudupload-overview%}) control with an Azure storage account.

## Set up storage account

For the purposes of this article, you will have to create an [Azure storage account](https://docs.microsoft.com/en-us/azure/storage/common/storage-create-storage-account).

## Implementing a CustomAzureProvider

All that is needed to connect an Azure storage account with the RadCloudUpload control is to set its **Provider** property to a class implementing the [ICloudUploadProvider](https://docs.telerik.com/devtools/wpf/api/html/t_telerik_windows_cloud_iclouduploadprovider.htm) interface. The logic for uploading the data has to be implemented in the **UploadFileAsync** method.

> For an example implentation of an AzureProvider, you can check out the [CustomAzureProvider](https://github.com/telerik/xaml-sdk/tree/master/CloudUpload/CustomAzureProvider) SDK.

## See Also

* [Get started with Azure Blob storage using .NET](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet)
* [Azure Storage samples using .NET](https://docs.microsoft.com/en-us/azure/storage/common/storage-samples-dotnet?toc=%2fazure%2fstorage%2fblobs%2ftoc.json)