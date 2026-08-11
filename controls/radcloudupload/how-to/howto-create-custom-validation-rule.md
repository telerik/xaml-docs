---
title: Create Custom Validaton Rule
page_title: Create Custom Validaton Rule
description: Check our &quot;Create Custom Validaton Rule&quot; documentation article for the RadCloudUpload {{ site.framework_name }} control.
slug: radcloudupload-howto-create-custom-validation-rule
tags: create,custom,validaton,rule
published: True
position: 0
---

# Create Custom Validaton Rule

If the built-in validation rule does not cover your requirements, you can create your custom validation rule. In order to do this you need to create a class deriving from the native [ValidationRule](http://msdn.microsoft.com/en-us/library/system.windows.controls.validationrule.aspx) and override its __Validate()__ method. In that method you can implement custom logic validating the selected file. Since, you might have troubles with some cloud providers while uploading files containing underscores in their name, it might be reasonable to validate their name like this:        


<snippet id='radcloudupload-how-to-howto-create-custom-validation-rule-block_1-cs' />

<snippet id='radcloudupload-how-to-howto-create-custom-validation-rule-block_1-vb' />


Once this class is creted, you need to include it into the ValidationRules of the RadCloudUpload control. This can be done in XAML like this:


<snippet id='radcloudupload-how-to-howto-create-custom-validation-rule-block_2-xaml' />
