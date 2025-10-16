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


```C#
    public class MyValidationRule:ValidationRule
    {
      public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
      {
          var fileName = (string)value;
          if (fileName.Contains("_"))
          {
              return new ValidationResult(false, "You can not upload files containing underscore ('_') in their name.");
          }
          return new ValidationResult(true, null);
      }
    }
```
```VB.NET
    Public Class MyValidationRule
        Inherits ValidationRule
        Public Overrides Function Validate(value As Object, cultureInfo As System.Globalization.CultureInfo) As ValidationResult
            Dim fileName = DirectCast(value, String)
            If fileName.Contains("_") Then
                Return New ValidationResult(False, "You can not upload files containing underscore ('_') in their name.")
            End If
            Return New ValidationResult(True, Nothing)
        End Function
    End Class
```

Once this class is creted, you need to include it into the ValidationRules of the RadCloudUpload control. This can be done in XAML like this:


```XAML
    <telerik:RadCloudUpload>
      <telerik:RadCloudUpload.ValidationRules>
          <local:MyValidationRule />
      </telerik:RadCloudUpload.ValidationRules>
      ...
    </telerik:RadCloudUpload>
```