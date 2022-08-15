---
title: Setting the NuGet Package Source
page_title: Setting the NuGet Package Source
description: "Telerik UI for WPF provides .nupkg files and also an online NuGet package source for downloading the Telerik dlls."
slug: nuget-package-source-setup
tags: restoring,ui,for,wpf,packagesource,from,a,nuget,package,ci
published: True
position: 1
---

# Setting the NuGet Package Source

The Telerik NuGet packages are available as `.nupkg` files that can be downloaded in a local package source, and also can be installed from the online Telerik NuGet server. 

## Using the Telerik NuGet Server as Package Source

The Telerik server is an online package source that can be accessed through Visual Studio's Nuget Package Manager in order to easily install and upgrade Telerik assemblies. The NuGet server resides at: [https://nuget.telerik.com/v3/index.json](https://nuget.telerik.com/v3/index.json). 

> The old https://nuget.telerik.com/nuget server will be deprecated and we encourage our clients to switch to the v3 API. The new v3 API is faster, lighter, and reduces the number of requests from NuGet clients.

The following steps show how to setup the package source in Visual Studio. 

1. Navigate to the Package Manager Settings menu in Visual Studio.
1. Add a new source in the Package Sources section.
1. In the Source field fill the address of the Telerik NuGet Server and click Update. The address is: [https://nuget.telerik.com/v3/index.json](https://nuget.telerik.com/v3/index.json)
1. The Telerik Server is added and ready to use. 

Selecting the Telerik's source as the __Package source__ in Visual Studio will prompt you to enter your __telerik.com credentials__.

Using this approach you can only use versions from __2016.3.1024 and later__. If you need to use a previous version of the suite you will need to create a [local package source](#using-local-package-source).

## Using a Local Package Source

The Telerik packages are available as `.nupkg` packages that can be downloaded from your telerik.com account. The following steps describe what to download and how to setup the package source:

1. Go to the [UI for WPF Downloads](https://www.telerik.com/account/product-download?product=RCWPF) page.
1. Download the .zip file with the NuGet packages and extract it into the folder where your package source will be hosted.

	You will find 4 .zip files with nuget packages on the download page. These contains two different package types (full and separate) each containing two different types of Telerik dlls ([Xaml and NoXaml]({%xaml-vs-noxaml%})).
	
	* `Telerik_UI_for_WPF_{version}NuGet{Xaml/NoXaml}_Dev.zip` are available for the supported .NET versions and combine all UI for WPF assemblies in one NuGet.
	* `Telerik_UI_for_WPF_{version}NuGet_Separate_Packages{Xaml/NoXaml}_Dev.zip` contains the separate NuGet packages of all UI for WPF assemblies. These are useful if you don't want to include all Telerik assemblies in your project, but only the ones you are referencing.	
	
1. Navigate to the Package Manager Settings menu.
1. Add a new source in the Package Sources section.
1. In the __Source__ field use the path to the folder where you extracted the .zip file with the .nupkg files (step 2). Then click Update.
1. The Telerik Server is added and ready to use. 

## Selecting the Package Source in Visual Studio

Once you created the package source as described in the previous sections of this article, you will need to select it in the Visual Studio's NuGet Package Manager.

1. Open your project in Visual Studio and select it.
1. Click on the Manage NuGet Packages menu.
1. 







This article provides an overview of the most popular approaches for using token-based authentication to restore Telerik NuGet packages in your CI (Continuous Integration) workflow.

The Telerik NuGet server allows you to authenticate by using two methods:

* Basic authentication by providing your Telerik user name and password.
* Token-based authentication by providing a NuGet Key.

When you need to restore Telerik NuGet packages as part of your CI, using NuGet keys is the more secure way to authenticate. This method does not require you to provide your Telerik username and password anywhere in the CI workflow.

Unlike your Telerik credentials, a NuGet Key has a limited scope and can be used only with the Telerik NuGet server. If any of your NuGet keys is compromised, you can quickly delete it and create a new one.

## Generating NuGet Keys

1. Go to the [**Manage NuGet Keys**](https://www.telerik.com/account/downloads/nuget-keys) page in your Telerik account.

1. Select the **DOWNLOADS** tab and then **Manage NuGet Keys**.

    ![Manage NuGet Keys](images/installation-manage-nuget-keys.png)

1. To create a new key, select the **Generate New Key** button.

1. Enter a name for the NuGet Key, and then select **Generate Key**.

1. To copy the key, select **Copy and Close**. Once you close the window, you can no longer copy the generated key. For security reasons, the **NuGet Keys** page displays only a portion of the key.

    ![Copy Generated NuGet Key](images/installation-copy-nuget-key.png)

## Storing a NuGet Key

> Never check in a NuGet Key with your source code or leave it publicly visible in plain text, for example, as a raw key value in a `nuget.config` file. A NuGet Key is valuable as bad actors can use it to access the NuGet packages that are licensed under your account. A potential key abuse could lead to a review of the affected account.

To protect the NuGet Key, store it as a secret environment variable. The exact steps depend on your workflow:

* In GitHub Actions, save the key as a GitHub Actions Secret. Go to **Settings** > **Security** > **Secrets** > **Actions** > **Add new secret**.

* In Azure DevOps Classic, save the key as a secret pipeline variable. Go to the **Variables** tab and then select **Pipeline variables**.

* In Azure DevOps YAML pipelines, save the key as a secret variable as well. Click the YAML editor's **Variables** button and complete the **New variable** form.

If you use Azure DevOps Service connection instead of secret environment variables, enter `api-key` in the username filed and the NuGet Key as the password in the **New NuGet service connection** form editor.

For more details on storing and protecting your NuGet Key, check the [Announcing NuGet Keys](https://www.telerik.com/blogs/announcing-nuget-keys) blog post by Lance McCarthy.

## Using a NuGet Key

There are two popular ways to use the Telerik NuGet server in a build:

* [Using a nuget.config file with your projects](#using-a-nugetconfig-file-with-your-projects)

* [Using only CLI commands](#using-only-cli-commands)

For more information on how to use NuGet keys in a build, check the [Announcing NuGet Keys](https://www.telerik.com/blogs/announcing-nuget-keys) blog post by Lance McCarthy.

### Using a nuget.config File with Your Projects

1. In your `nuget.config` file, set the `Username` value to `api-key` and the `ClearTextPassword` value to an environment variable name:

    #### __[XML]__
    {{region installation-nuget-keys-0}}
        <configuration>
            <packageSources>
                <clear/>
                <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
                <add key="MyTelerikFeed" value="https://nuget.telerik.com/v3/index.json" protocolVersion="3"/>
            </packageSources>
            <packageSourceCredentials>
                <MyTelerikFeed>
					<add key="Username" value="api-key" />
					<add key="ClearTextPassword" value="%MY_API_KEY%" />
                </MyTelerikFeed>
            </packageSourceCredentials>
            ...
        </configuration>
    {{endregion}}

1. Set the `MY_API_KEY` environment variable by using the value of your pipeline/workflow secret.

The exact steps to set the `MY_API_KEY` environment variable depend on your workflow. For more details, refer to the [Announcing NuGet Keys](https://www.telerik.com/blogs/announcing-nuget-keys) blog post by Lance McCarthy.

### Using Only CLI Commands

You can use the CLI `add source` (or `update source`) command to set the credentials of a package source. This CLI approach is applicable if your CI system doesn't support default environment variable secrets or if you do not use a custom `nuget.config`.

* To set the credentials in Azure DevOps:

    __Powershell__  
		
		dotnet nuget add source 'MyTelerikFeed' --source 'https://nuget.telerik.com/v3/index.json' --username 'api-key' --password '$(TELERIK_NUGET_KEY)' --configfile './nuget.config' --store-password-in-clear-text    

* To set the credentials in GitHub Actions:

    __Powershell__  
        
		dotnet nuget add source 'MyTelerikFeed' --source 'https://nuget.telerik.com/v3/index.json' --username 'api-key' --password '${{ secrets.TELERIK_NUGET_KEY }}' --configfile './nuget.config' --store-password-in-clear-text

## Additional Resources

If you just start using the Telerik NuGet server in your CI or inter-department workflows, check the two blog posts below. You will learn about the various use cases and find practical implementation details.

* [Azure DevOps and Telerik NuGet Packages](https://www.telerik.com/blogs/azure-devops-and-telerik-nuget-packages)

* [Announcing NuGet Keys](https://www.telerik.com/blogs/announcing-nuget-keys)

## See Also

 * [Which File Do I Need to Install?]({%slug installation-installing-which-file-do-i-need%})

 * [Installing UI for Silverlight from MSI File]({%slug installation-installing-from-msi%})

 * [Installing UI for Silverlight from ZIP File]({%slug installation-installing-from-zip%})

