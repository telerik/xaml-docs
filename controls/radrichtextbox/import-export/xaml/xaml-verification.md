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

Since R2 2023 SP1 the `XamlFormatProvider` automatically verifies the types used in the imported XAML. It makes sure that all used types are from for the trusted assemblies. This mechanism prevents any unknown types loading and is enabled by default. 

If the XAML cannot be verified the `UnverifiedXamlException` is thrown.

The verification can be disabled or extended with custom assemblies and types that are added via the `ImportSettings` settings of the `XamlFormatProvider`.

## Disabling the Default Verification

If you are sure that the imported XAML content can be trusted, you can disable the default verification by handling the `PreProcessingXaml` event of the `ImportSettings` class.

#### __[C#] Disable the default XAML validation__
{{region c#-radrichtextbox-import-export-xaml-verification_1}}
	XamlFormatProvider provider = new XamlFormatProvider();
    provider.ImportSettings.PreProcessingXaml += (s, args) => { 
    
        args.SkipXamlValidation = true;
    };
{{endregion}}

## Adding Custom Assemblies to the Allowed Assemblies 
 
To add custom assemblies to the collection with allowed assemblies, use the `AllowedAssemblies` property of the `XamlFormatProvider.ImportSettings`.

#### __[C#] Add assemblies to the AllowedAssemblies collection__
{{region c#-radrichtextbox-import-export-xaml-verification_2}}
	XamlFormatProvider provider = new XamlFormatProvider();
    provider.ImportSettings.AllowedAssemblies.Add("MyAssemblyName");
	provider.ImportSettings.AllowedAssemblies.Add("PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");
	provider.ImportSettings.AllowedAssemblies.Add("PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");
{{endregion}}

The custom assemblies verification can be extended by checking also the public token of the assembly. To enable this, you can add the token in the `AssembliesTokens` dictionary of the `XamlFormatProvider.ImportSettings`.

#### __[C#] Add an assembly public key to the AssembliesTokens collection__
{{region c#-radrichtextbox-import-export-xaml-verification_3}}
	XamlFormatProvider provider = new XamlFormatProvider();
    provider.ImportSettings.AllowedAssemblies.Add("PresentationFramework");
    provider.ImportSettings.AssembliesTokens["PresentationFramework"] = "31bf3856ad364e35";
{{endregion}}

## Adding Custom Types to the Allowed Types

To add custom types to the collection with allowed types, use the `AllowedTypes` property of the `XamlFormatProvider.ImportSettings`.

#### __[C#] Add types to the AllowedTypes collection__
{{region c#-radrichtextbox-import-export-xaml-verification_4}}
	XamlFormatProvider provider = new XamlFormatProvider();
    provider.ImportSettings.AllowedTypes.Add(typeof(System.Windows.Controls.Label));
	provider.ImportSettings.AllowedTypes.Add(typeof(ScaleTransform));
	provider.ImportSettings.AllowedTypes.Add(typeof(NullExtension));
{{endregion}}

## See Also

 * [Settings]({%slug radrichtextbox-import-export-xaml-settings%})
 * [Using XamlFormatProvider]({%slug radrichtextbox-import-export-using-xamlformatprovider%})