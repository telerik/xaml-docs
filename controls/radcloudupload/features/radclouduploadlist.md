---
title: RadCloudUploadList
page_title: RadCloudUploadList
description: RadCloudUploadList
slug: radcloudupload-radclouduploadlist
tags: radclouduploadlist
published: True
position: 7
---

# RadCloudUploadList





## 

The __RadCloudUploadList__ is simply an __ItemsControl__ with no additional features or properties. It can be used to visualize the __Items__, __ValidItems__ or __InvalidItems__ collections of the __RadCloudUpload__ control. In order to populate this ItemsControl you can use ElementName binding to the corresponding properties of the __RadCloudUpload__ control.
      

#### __XAML__
    <telerik:RadCloudUploadList ItemsSource="{Binding InvalidItems, ElementName=MyRadCloudUploadName}" />
    <telerik:RadCloudUploadList ItemsSource="{Binding ValidItems, ElementName=MyRadCloudUploadName}" />
    <telerik:RadCloudUploadList ItemsSource="{Binding Items, ElementName=MyRadCloudUploadName}" />



# See Also
