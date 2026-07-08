---
title: CI and CD Automated Builds
page_title: CI and CD Automated Builds
description: "How to use Continuous Integration and Continuous Delivery pipelines with Telerik NuGet server."
slug: installation-automated-builds
tags: ci,cd,automated,builds
published: True
position: 4
---

# CI and CD Automated Builds

Often enough, you would want to set up Continuous Integration and/or Continuous Delivery (CI/CD) pipelines or builds for your project that uses the Telerik components. This is a valid scenario and the "one license per developer" license does not prevent you from doing so. The Telerik components are commercial software and as such can only be distributed through channels that are private and/or behind authentication.

There are a few common ways people implement CI/CD automated builds:

* Use the licensed account's credentials in environment variables on the build machine/runner and reference those in the `nuget.config` file's `<packageSourceCredentials>` (see Azure DevOps `nuget.config` example below)
* Add the package source, with credentials, using NuGet CLI's `nuget add source` command (before the restore or msbuild step).
* Using a Local Package source (seen above)
* Use a Service connection or Secrets storage system (see Azure DevOps and GitHub Actions below)

You must protect your credentials and/or the Telerik packages and ensure they are used only by you and not by other developers, according to the [license-per-developer policy](https://www.telerik.com/purchase/license-agreement/wpf-dlw-s). They can by such colleagues (like other developers, QAs, designers, front-end devs, DBAs and so on) for building and running a solution, provided they do not use the Telerik components to create functionality. Of course, you must ensure that such credentials or package sources are not available to the general public (for example, in public repositories). 

## Azure DevOps Pipelines

When using Azure pipelines, we encourage you to review the following resources on setting things up:

* Blog post: [Azure DevOps and Telerik NuGet Packages](https://www.telerik.com/blogs/azure-devops-and-telerik-nuget-packages)
* Sample Repo and Video Tutorial: [Telerik DevOpsExamples by LanceMcCarthy](https://github.com/LanceMcCarthy/DevOpsExamples)

There are a couple of common questions and issues:

* Obtaining credentials - see the points above for either using your own credentials, or using a shared package source.
* Telerik feed not being found
    * The most common reason for a problem is that the path to the `nuget.config` file is wrong (it should, by default, be at the root level). 
    * Make sure the URL to the server is correct `https://nuget.telerik.com/nuget` (HTTPS, no trailing slash)
* '401 login failed' error. 
* An `index.json not found` error can occur from many root causes. If you have successfully authenticated, this error usually means that the feed wasn't able to be searched or connected to. A common reason is an incorrect feed URL, such as including a trailing slash - Correct: `https://nuget.telerik.com/nuget` and Incorrect: `https://nuget.telerik.com/nuget/`.

A few things to double check to ensure correct setup:

* The Service connection is using Basic Authentication and the URL is correct (`https://nuget.telerik.com/nuget` exactly, no trailing slash).
* That Service Connection is selected as the credentials source.
* The credentials being used have a UI for WPF license.
* Make sure that you use the correct restore command (`dotnet restore` for .NET Core and .NET5 or `nuget restore` for msbuild+msbuild) in your pipeline step. See the [DevOpsExamples repo by Lance McCarthy](https://github.com/LanceMcCarthy/DevOpsExamples) for live examples.

## GitHub Secrets

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

