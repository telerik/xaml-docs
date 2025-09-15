---
title: Validation
page_title: Validation
description: Check our &quot;Validation&quot; documentation article for the RadCloudUpload {{ site.framework_name }} control.
slug: radcloudupload-features-validation
tags: validation
published: True
position: 8
---

# Validation

The __RadCloudUpload__ control allows you to validate the files that the end user has selected. For this purpose you can use the __ValidationRules__ property. It is of type __List&lt;System.Windows.Controls.ValidationRule&gt;__ and expects you to provide validation rules.        

> You can read the [Create Custom Validation Rule]({%slug radcloudupload-howto-create-custom-validation-rule%}) help article.

The __Validate()__ method of each rule will be executed providing the selected file's name. If there are no validation rules, or all rules return valid result - a valid item is created. In case there is at least one rule that returns an invalid result - an invalid item is created for this file.        

>Validation is executed once the user selects file(s). If later you add or remove validation rules, the files will not be reevaluated.

There is a built-in validation rule (__CloudUploadFileSizeValidationRule__) that can be used to validate the size of the files. __Example 1__ demonstrates how you can use the rule.

__Example 1: Adding a validation rule__
```XAML
	<telerik:RadCloudUpload>
		<telerik:RadCloudUpload.ValidationRules>
			<!--10MB limit-->
			<telerik:CloudUploadFileSizeValidationRule MaxFileSize="10000000" />
		</telerik:RadCloudUpload.ValidationRules>
	 ...
	</telerik:RadCloudUpload>
```

## See Also
* [Create Custom Validation Rule]({%slug radcloudupload-howto-create-custom-validation-rule%})
* [Open File Dialog]({%slug radcloudupload-features-custom-open-file-dialog%})
* [ValidationRule](http://msdn.microsoft.com/en-us/library/system.windows.controls.validationrule.aspx)