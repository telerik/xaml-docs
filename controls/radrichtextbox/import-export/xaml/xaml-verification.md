---
title: XAML Verification
page_title: XAMLVerification
description: This article shows how the default XAML verification works. 
slug: radrichtextbox-import-export-xaml-verification
tags: XAML
published: True
position: 4
---

# XAML Verification

Since R2 2023 SP1 the __XamlFormatProvider__ automatically verifies the types used in the imported XAML. It makes sure that all used types are from for the trusted assemblies. This mechanism prevents any unknown types loading and is enabled by default. 

### Disable the default verification

If you are sure that the imported XAML can be trusted for example it comes internally form your organization you can disable the default verification. This can be achieved by using the __PreProcessingXaml__ event.

#### __[C#] Example 1: Disable the default XAML validation__
{{region c#-radrichtextbox-import-export-xaml-verification_1}}

	XamlFormatProvider provider = new XamlFormatProvider();
    provider.ImportSettings.PreProcessingXaml += (s, args) => { 
    
        args.SkipXamlValidation = true;
    };

{{endregion}}

### Add custom assembly to the allowed assemblies.  
 
If you have a custom types that are saved in your XAML you can include them in the allowed assemblies collection. This way the verification process will succeed. 

#### __[C#] Example 2: Add assemblies to the AllowedAssemblies collection__
{{region c#-radrichtextbox-import-export-xaml-verification_2}}

	XamlFormatProvider provider = new XamlFormatProvider();
    provider.ImportSettings.AllowedAssemblies.Add("MyAssemblyName");

{{endregion}}

## See Also

 * [Settings]({%slug radrichtextbox-import-export-xaml-settings%})
 * [Using XamlFormatProvider]({%slug radrichtextbox-import-export-using-xamlformatprovider%})