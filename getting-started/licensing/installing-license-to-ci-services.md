---
title: Adding License Key to CI Services
page_title: Installing License Key to CI Services
description: The article describes how to install a license key for the Telerik UI for WPF product to CI Services.
slug: installing-license-to-ci-services
tags: installing,ui,for,wpf,file,license,key,ci,service,continuous,integration,cd,cicd
published: True
position: 2
---

# Adding the License Key to CI/CD Services

This article describes how to set up and activate your Telerik UI for WPF [license key]({%slug installing-license-key%}) across a few popular CI/CD services by using environment variables.

When working with CI/CD platforms, always add the `Telerik.Licensing` NuGet package as a project dependency. This package activates the Telerik UI for WPF components at build time by using the provided license key.

> If you cannot use NuGet packages in your project, you can add the license key as an assembly attribute as shown in the [Installing License Key]({%slug installing-license-key%}#adding-a-license-key-to-projects-without-nuget-references) article.

The license activation process in a CI/CD environment involves the following steps:

1. [Download a license key]({%slug installing-license-key%}#downloading-the-license-key) from your [Telerik account](https://www.telerik.com/account/your-licenses/license-keys).

1. Add the `Telerik.Licensing` NuGet package as a project dependency: `<PackageReference Include="Telerik.Licensing" Version="1.*" />`

1. [Create an environment variable](#creating-an-environment-variable) named `TELERIK_LICENSE` and add your UI for WPF license key as a value.

## Creating an Environment Variable

The recommended approach for providing your license key to the `Telerik.Licensing` NuGet package is to use environment variables. Each CI/CD platform has a different process for setting environment variables and this article lists only some of the most popular examples.

### Azure Pipelines (YAML)

1. Create a new [User-defined Variable](https://docs.microsoft.com/en-us/azure/devops/pipelines/process/variables?view=azure-devops&tabs=yaml%2Cbatch) named `TELERIK_LICENSE`.

1. Paste the contents of the license key file as a value.

### Azure Pipelines (Classic)

1. Create a new [user-defined variable](https://docs.microsoft.com/en-us/azure/devops/pipelines/process/variables?view=azure-devops&tabs=classic%2Cbatch) named `TELERIK_LICENSE`. 

1. Paste the contents of the license key file as a value.

### GitHub Actions

1. Create a new [Repository Secret](https://docs.github.com/en/actions/reference/encrypted-secrets#creating-encrypted-secrets-for-a-repository) or an [Organization Secret](https://docs.github.com/en/actions/reference/encrypted-secrets#creating-encrypted-secrets-for-an-organization).

1. Set the name of the secret to `TELERIK_LICENSE` and paste the contents of the license file as a value.

1. After running `npm install` or `yarn`, add a build step to activate the license:

	#### __[YML]__
	{{region installing-license-to-ci-services-0}}
```YAML
env:
    TELERIK_LICENSE: ${{ secrets.TELERIK_LICENSE }}
```
	{{endregion}}

## See Also  
* [License Activation Errors and Warnings]({%slug license-activation-errors-and-warnings%})
* [Setting Up Your License Key]({%slug installing-license-key%}}
* [Frequently Asked Questions about Your UI for WPF License Key]({%slug license-frequently-asked-questions%})
