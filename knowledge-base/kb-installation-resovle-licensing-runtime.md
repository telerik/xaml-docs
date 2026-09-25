---
title: Resolve Telerik.Licensing.Runtime Binding Redirect Errors in .NET Framework
description: Add a binding redirect when a .NET Framework app uses a different Telerik.Licensing.Runtime version than the Telerik UI for WPF assemblies.
components: ["licensing"]
page_title: Resolve Telerik.Licensing.Runtime Binding Redirect Errors in .NET Framework
type: troubleshooting
slug: kb-installation-resovle-licensing-runtime
position: 0
tags: licensing, telerik.licensing.runtime, binding redirect, .net framework, assembly version
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2025.1.211 and later</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

A .NET Framework application can build successfully but throw a `FileLoadException` at runtime when the referenced `Telerik.Licensing.Runtime` assembly version differs from the version expected by the Telerik UI for WPF assemblies. Modern .NET applications do not require this configuration because the runtime resolves this dependency without application configuration binding redirects.

This may occur after you upgrade to 2025 Q1 or later, which use the [Telerik licensing mechanism]({%slug installing-license-key%}) and require a reference to `Telerik.Licensing.Runtime`.

## Cause

The .NET Framework loader uses the assembly version recorded in the Telerik UI for WPF assembly reference. Installing a newer `Telerik.Licensing` NuGet package or manually referencing a newer `Telerik.Licensing.Runtime.dll` changes the available licensing version, but it does not automatically make that newer version satisfy the original assembly reference when binding redirects are disabled or absent. Modern .NET projects handle this dependency resolution without an application configuration binding redirect.

## Solution

Add a binding-redirect to your project when using a different `Telerik.Licensing` package version in a .NET Framework application. Enable automatic binding-redirect generation. This adds the required redirect to the generated application configuration file.

1. Remove `<AutoGenerateBindingRedirects>false</AutoGenerateBindingRedirects>` from the project file, or set it to `true`:

```XML
<PropertyGroup>
  <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>
</PropertyGroup>
```

2. Clean and rebuild the application, then verify that the generated `<application>.exe.config` file contains a binding redirect for `Telerik.Licensing.Runtime` to the version installed in the project.

For .NET Framework applications that manage redirects manually, add the redirect to the application configuration file. This example redirects requests through version `1.9.2.0` to the `Telerik.Licensing.Runtime` version installed in the application:

```XML
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="Telerik.Licensing.Runtime" publicKeyToken="98bb5b04e55c09ef" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-1.9.2.0" newVersion="1.9.2.0" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
</configuration>
```

Set `oldVersion` and `newVersion` to the `Telerik.Licensing.Runtime` version installed in your application. This binding redirect is only required for .NET Framework projects. For more information, see the [.NET Framework binding redirect guidance](https://learn.microsoft.com/en-us/dotnet/framework/configure-apps/how-to-enable-and-disable-automatic-binding-redirection).

## See Also

* [Set Up Your License Key]({%slug installing-license-key%})
* [How the Runtime Locates Assemblies](https://learn.microsoft.com/en-us/dotnet/framework/deployment/how-the-runtime-locates-assemblies)
