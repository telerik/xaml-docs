---
title: Installing UI for WPF from a NuGet package
page_title: Installing UI for WPF from a NuGet package
description: This article describes how to use the telerik NuGet server or setup a local package source to download UI for WPF dlls from NuGet packages.
slug: installation-installing-from-nuget-wpf
tags: installing,ui,for,wpf,from,a,nuget,package
published: True
position: 5
site_name: WPF
---

# Installing UI for WPF from a NuGet package

The following topic describes how you can install Telerik UI for WPF from a [NuGet package](http://www.nuget.org/).

## Available Packages

We provide separate packages for the different assemblies from the UI for WPF suite and a common NuGet package containing all the dlls. Below you can find some information about the different packages. 

* NuGet packages with the individual UI for WPF assemblies:

    These packages can be downloaded by [using the telerik NuGet server](#using-the-telerik-nuget-server) or by [using a local package source](#using-a-local-package-source) and they only download the references that the assembly depends on. Additionally, the separate nuget packages will detect the __Target Framework__ of your project and download the UI for WPF dlls with the correct version (.NET Framework dlls or .NET Core dlls (available since __R1 2019__)).

* NuGet packages with all of the UI for WPF assemblies:

    These packages make it easier to get started with the controls by installing just a single package. Note, however, that these packages are not available for download from the Telerik NuGet Server. To use them, check out the [using a local package source](#using-a-local-package-source) section. As these packages will not detect the __Target Framework__ automatically, you need to ensure you choose the correct version for your particular project.
    
    ![Common Installing From NuGet NetCore](images/Common_InstallingFromNuGet_NetCore.png)

>importantFor each NuGet package we provide two options. The NuGet packages that have __Xaml__ in their name will download the [Xaml]({%slug xaml-vs-noxaml%}#xaml-assemblies) dlls and the ones that don't, will download the [NoXaml]({%slug xaml-vs-noxaml%}#noxaml-assemblies) dlls. Mixing Xaml and NoXaml dlls in your projects is __not__ recommended.

## Using the Telerik NuGet Server

Through the Telerik NuGet Server [https://nuget.telerik.com/v3/index.json](https://nuget.telerik.com/v3/index.json) users can easily include the Telerik UI for WPF suite and update to the latest official version. 

> The old [https://nuget.telerik.com/nuget](https://nuget.telerik.com/nuget) server will be deprecated and we encourage our clients to switch to the v3 API. The new v3 API is faster, lighter, and reduces the number of requests from NuGet clients.

The following steps will demonstrate how this can be done in Visual Studio:

1.Navigate to the Package Manager Settings menu.

![](images/Common_InstallingFromNuGet_05_wpf.png)

2.Add a new source in the Package Sources section.

![](images/Common_InstallingFromNuGet_06_wpf.png)

3.In the Source field fill the address of the Telerik NuGet Server and click Update.

![](images/Common_InstallingFromNuGet_07_wpf.png)

4.The Telerik Server is added and ready to use. Click on the Manage NuGet Packages menu.

![](images/Common_InstallingFromNuGet_08_wpf.png)

5.Set the Telerik Server as a package source. Enter user credentials (from your Telerik account) when prompted and search for the needed package.

![](images/Common_InstallingFromNuGet_09_wpf.png)

>importantFor each NuGet package we provide two options. The NuGet packages that have __Xaml__ in their name will download the [Xaml]({%slug xaml-vs-noxaml%}#xaml-assemblies) dlls and the ones that don't, will download the [NoXaml]({%slug xaml-vs-noxaml%}#noxaml-assemblies) dlls. Mixing Xaml and NoXaml dlls in your projects is __not__ recommended.  

>Using this approach you can only use versions from **2016.3.1024** and later. If you need to use a previous version of the suite you will need to create a local package source as described in the next section.

## Using a Local Package Source

In order to set up a local package source, you can follow these steps:

* Go to to the [UI for WPF Downloads](https://www.telerik.com/account/product-download?product=RCWPF) page.

> You have 4 options when downloading the NuGet packages from your account. The files named __Telerik_UI_for_WPF_{version}_NuGet_{Xaml/NoXaml}_Dev.zip__ are available for the supported .NET versions and combine all UI for WPF assemblies in one NuGet. The files named __Telerik_UI_for_WPF_{version}_NuGet_Separate_Packages_{Xaml/NoXaml}_Dev.zip__ contain the separate NuGet packages of all UI for WPF assemblies.

* Download the needed NuGet .zip file(s) depending on whether you're using [Xaml or NoXaml]({%slug xaml-vs-noxaml%}) binaries and extract it into the folder where your Telerik NuGet packages are located.

* Follow steps 1-3 from the [Using the Telerik NuGet Server]({%slug installation-installing-from-nuget-wpf%}#using-the-telerik-nuget-server) section. In the 3rd step set the __Source__ field to the folder where you’ve extracted the .nupkg file (for example C://Telerik NuGet).

* Follow steps 4 and 5 from the [Using the Telerik NuGet Server]({%slug installation-installing-from-nuget-wpf%}#using-the-telerik-nuget-server) section. In the last step set your local folder as a package source. 

>tip Additionally, you can create a private NuGet Feed and deploy the Telerik NuGet packages there - for more details refer to [this blog post](http://blogs.telerik.com/careypayette/posts/13-03-11/power-your-projects-with-telerik---now-with-the-convenience-of-nuget).

You can also have a look at the following video which demonstrates how you can add the Telerik NuGet Feed to your NuGet Package Sources:

<iframe width="800" height="400" src="https://www.youtube.com/embed/c3m_BLMXNDk" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture; fullscreen"></iframe>
  
## Installing Latest Internal Build NuGet Packages

You can install and test the Latest Internal Build (LIB) dlls provided on a weekly basis, via the NuGet Package Manager. The LIB nugets are __available only as .nupkg files__ that can be downloaded from your telerik.com account. This means that you will need to create a [local package source](#using-a-local-package-source) and copy the files there. You __cannot__ download LIB dlls via the online Telerik nuget server (https://nuget.telerik.com/nuget), because they are not available there.

When you set up the package source and place the NuGet files there, you can find them in the NuGet Package Manager. To see the LIB packages you will need also to check the __Include prerelease__ option. The LIB packages have the __-hotfix__ postfix in the version field.

![](images/Common_InstallingFromNuGet_10_wpf.png)

## CI and CD Automated Builds

Often enough, you would want to set up Continuous Integration and/or Continuous Delivery (CI/CD) pipelines or builds for your project that uses the Telerik components. This is a valid scenario and the "one license per developer" license does not prevent you from doing so. The Telerik components are commercial software and as such can only be distributed through channels that are private and/or behind authentication.

There are a few common ways people implement CI/CD automated builds:

* Use the licensed account's credentials in environment variables on the build machine/runner and reference those in the `nuget.config` file's `<packageSourceCredentials>` (see Azure DevOps `nuget.config` example below)
* Add the package source, with credentials, using NuGet CLI's `nuget add source` command (before the restore or msbuild step).
* Using a Local Package source (seen above)
* Use a Service connection or Secrets storage system (see Azure DevOps and GitHub Actions below)

You must protect your credentials and/or the Telerik packages and ensure they are used only by you and not by other developers, according to the [license-per-developer policy](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s). They can by such colleagues (like other developers, QAs, designers, front-end devs, DBAs and so on) for building and running a solution, provided they do not use the Telerik components to create functionality. Of course, you must ensure that such credentials or package sources are not available to the general public (for example, in public repositories). 

#### Azure DevOps Pipelines

When using Azure pipelines, we encourage you to review the following resources on setting things up:

* Blog post: [Azure DevOps and Telerik NuGet Packages](https://www.telerik.com/blogs/azure-devops-and-telerik-nuget-packages)
* Sample Repo and Video Tutorial: [Telerik DevOpsExamples by LanceMcCarthy](https://github.com/LanceMcCarthy/DevOpsExamples)

There are a couple of common questions and issues:

* Obtaining credentials - see the points above for either using your own credentials, or using a shared package source.
* Telerik feed not being found
    * The most common reason for a problem is that the path to the `nuget.config` file is wrong (it should, by default, be at the root level). 
    * Make sure the URL to the server is correct `https://nuget.telerik.com/nuget` (HTTPS, no trailing slash)
* '401 login failed' error. See the **Troubleshooting** section below
* An `index.json not found` error can occur from many root causes. If you have successfully authenticated, this error usually means that the feed wasn't able to be searched or connected to. A common reason is an incorrect feed URL, such as including a trailing slash - Correct: `https://nuget.telerik.com/nuget` and Incorrect: `https://nuget.telerik.com/nuget/`.

A few things to double check to ensure correct setup:

* The Service connection is using Basic Authentication and the URL is correct (`https://nuget.telerik.com/nuget` exactly, no trailing slash).
* That Service Connection is selected as the credentials source.
* The credentials being used have a UI for WPF license.
* Make sure that you use the correct restore command (`dotnet restore` for .NET Core and .NET5 or `nuget restore` for msbuild+msbuild) in your pipeline step. See the [DevOpsExamples repo by Lance McCarthy](https://github.com/LanceMcCarthy/DevOpsExamples) for live examples.

#### GitHub Secrets

In some cases, [GitHub Secrets](https://docs.github.com/en/actions/configuring-and-managing-workflows/creating-and-storing-encrypted-secrets) are used to store credentials that you would later have to consume from the `nuget.config` file in order to connect to the Telerik feed in your GitHub Actions workflows.

A way to pass them along is to mark them as environment variables. You can find an example in the [DevOpsExamples repo by Lance McCarthy](https://github.com/LanceMcCarthy/DevOpsExamples). Here follow the two relevant extracts.

>caption Example of setting GitHub Secrets into Environment Variables for Telerik Login

````YAML
jobs:
  build:
    runs-on: windows-latest

    env:
      TELERIK_USERNAME: ${ { secrets.MyTelerikAccountUsername } }  # remove the space between the brackets
      TELERIK_PASSWORD: ${ { secrets.MyTelerikAccountPassword } }  # remove the space between the brackets

````
>tip Even though you are copying secrets into Environment Variables on the runner, GitHub Actions will continue to treat the values as protected string and mask the values in all output.

Finally, you need a `nuget.config` file that lists the Telerik server in the `packageSources`, as well as an accompanying `packageSourceCredentials` that uses those named environment variables for the `Username` and `ClearTextPassword` keys.

>caption Example of Using Environment Variables in NuGet.config

````XML
<packageSources>
  <clear />
  <add key="NuGet" value="https://api.nuget.org/v3/index.json" />
  <add key="TelerikFeed" value="https://nuget.telerik.com/nuget" />
</packageSources>
<packageSourceCredentials>
  <TelerikFeed>
    <add key="Username" value="%TELERIK_USERNAME%" />
    <add key="ClearTextPassword" value="%TELERIK_PASSWORD%" />
  </TelerikFeed>
</packageSourceCredentials>
````

>warning GitHub does not allow secrets to be used in workflows that have been [triggered by a pull request event](https://docs.github.com/en/actions/reference/events-that-trigger-workflows). In such a case, the runner will not be able to authenticate with the Telerik NuGet server and the job will expectedly fail.

## Troubleshooting

### '401 Logon failed' error

If you're receiving this error when connecting to Telerik NuGet Server, you could try to update your NuGet credentials through the Windows Credential Manager. Please follow the steps below:

1. Close all open Visual Studio instances (this is so that all NuGet package manager tasks are stopped).
2. Open the "Credential Manager" app on your PC.
3. Scroll through all the entries until you find any that are for `nuget.telerik.com`.
4. Once you find that entry, expand it and select "edit".
5. Make sure the username and password are the same ones you use for your Telerik account:
    1. Use the email address in the place of username
    2. Make sure any special characters are escaped (see *Handling Special Characters in Password* below)
    3. Click "Save" 
6. Make sure the URL does not have a trailing slash, it must be only `https://nuget.telerik.com/nuget`

Now you can reopen Visual Studio and access the Telerik NuGet server. 

#### Handling Special Characters in Password

If your password contains a special character, those characters need to be escaped or it may fail authentication resulting in *Error 401 login failure* from the NuGet server. A common character that needs to be escaped is the ampersand `&`, but it can be as unique as the section character `§`. There are two ways to handle this.

1. Change the password so that it only includes characters that do not need to be escaped
2. HTML encode the password so the special characters are escaped (e.g. `my§uper&P@§§word` becomes `my&sect;uper&amp;P@&sect;&sect;word`).

We **strongly** discourage entering your password into an online encoder utility, use Powershell instead. Here's one example:

```
Add-Type -AssemblyName System.Web
[System.Web.HttpUtility]::HtmlEncode('my§uper&P@§§word')
```

Result:

![Powershell Encoding](https://user-images.githubusercontent.com/3520532/93901989-13d98200-fcc5-11ea-9d36-0eaee4272453.png)

### Networking Problems

Another common problem is that your machine (PC, GitHub Actions runner or Azure DevOps agent) is behind a proxy. To check if you're experiencing a networking issue, open the following URL in your web browser:

* https://nuget.telerik.com/nuget/Search()?$filter=IsAbsoluteLatestVersion&searchTerm=%27WPF%27&includePrerelease=true&$skip=0&$top=100&semVerLevel=2.0.0. 

After you enter your Telerik.com username and password, you should see an XML search result containing a list of all the Telerik.UI.for.WPF packages available with your license.
          
## See Also

 * [Which File Do I Need to Install?]({%slug installation-installing-which-file-do-i-need%})

 * [Installing UI for WPF from MSI File]({%slug installation-installing-from-msi-wpf%})

 * [Installing UI for WPF from ZIP File]({%slug installation-installing-from-zip-wpf%})

 * [Restoring NuGet Packages in Your CI Workflow]({%slug installation-nuget-keys-wpf%})
