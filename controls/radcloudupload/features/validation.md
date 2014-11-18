---
title: Validation
page_title: Validation
description: Validation
slug: radcloudupload-features-validation
tags: validation
published: True
position: 5
---

# Validation





## 

The __RadCloudUpload__ control allows you to validate the files that the end user has selected. For this purpose you can use the __ValidationRules__ property. It is of type __List<[ValidationRule](http://msdn.microsoft.com/en-us/library/system.windows.controls.validationrule.aspx)__ and expects you to provide validation rules.
        

The __Validate()__ method of each rule will be executed providing the selected file's name. If there are no validation rules, or all rules return valid result - a valid item is created. In case there is at least one rule that returns an invalid result - an invalid item is created for this file.
        

>Validation is executed once the user selects file(s). If later you add or remove validation rules, the files will not be reevaluated.

There is a built-in validation rule that can be used to validate the size of the files. You can take advantage of it like this:

#### __XAML__
    <telerik:RadCloudUpload>
      <telerik:RadCloudUpload.ValidationRules>
        <!--10MB limit-->
        <telerik:CloudUploadFileSizeValidationRule MaxFileSize="10000000" />
      </telerik:RadCloudUpload.ValidationRules>
      ...
    </telerik:RadCloudUpload>



# See Also

 * [Open File Dialog]({%slug radcloudupload-features-custom-open-file-dialog%})
