---
title: Open File Dialog
page_title: Open File Dialog
description: Check our &quot;Open File Dialog&quot; documentation article for the RadCloudUpload {{ site.framework_name }} control.
slug: radcloudupload-features-custom-open-file-dialog
tags: open,file,dialog
published: True
position: 4
---

# Open File Dialog

__RadCloudUpload__ allows you to open a custom dialog to browse the files for upload. To do this set the __CreateOpenFileDialog__ property. It is of type __Func&lt;Microsoft.Win32.OpenFileDialog&gt;__ and can be used to provide a function that returns an OpeFileDialog instance. This is useful to customize the dialog settings. For example, to restrict users to upload certain type of files.        

__Example 1: Defining the cloud upload control__
```XAML
	<telerik:RadCloudUpload x:Name="RadCloudUpload" />
```

__Example 2: Setting CreateOpenFileDialog. The function returns a dialog with a custom filter that allows only text files.__
```C#
    this.RadCloudUpload.CreateOpenFileDialog = () =>
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        return ofd;
    };
```

## See Also
* [OpenFileDialog](http://msdn.microsoft.com/en-us/library/microsoft.win32.openfiledialog%28v=vs.110%29.aspx)
* [Providers]({%slug radcloudupload-features-providers%})
