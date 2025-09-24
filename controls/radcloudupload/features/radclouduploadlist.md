---
title: RadCloudUploadList
page_title: RadCloudUploadList
description: Check our &quot;RadCloudUploadList&quot; documentation article for the RadCloudUpload {{ site.framework_name }} control.
slug: radcloudupload-radclouduploadlist
tags: radclouduploadlist
published: True
position: 6
---

# RadCloudUploadList

The __RadCloudUploadList__ is simply an __ItemsControl__ with no additional features or properties. It can be used to visualize the __Items__, __ValidItems__ or __InvalidItems__ collections of the __RadCloudUpload__ control. In order to populate this ItemsControl you can use ElementName binding to the corresponding properties of the __RadCloudUpload__ control.      


```XAML
    <telerik:RadCloudUploadList ItemsSource="{Binding InvalidItems, ElementName=MyRadCloudUploadName}" />
    <telerik:RadCloudUploadList ItemsSource="{Binding ValidItems, ElementName=MyRadCloudUploadName}" />
    <telerik:RadCloudUploadList ItemsSource="{Binding Items, ElementName=MyRadCloudUploadName}" />
```

## See Also
* [RadCloudUploadListItem]({%slug radcloudupload-radclouduploadlistitem%})
* [Adding Files Programmatically]({%slug radcloudupload-features-adding-files-programmatically%})
* [Events]({%slug radcloudupload-features-events%})