---
title: Installing UI for WPF from NuGet Package
page_title: Installing UI for WPF from NuGet Package
description: "How to install Telerik UI for WPF using nuget packages."
slug: nuget-installation
tags: restoring,ui,for,wpf,from,a,nuget,package,ci
published: True
position: 0
---

# Installing UI for WPF from NuGet Package

Telerik UI for WPF provides a set of nuget packages that can be used to easily install and upgrade Telerik projects.

This article describes how to set-up and use the nuget packages.

## Step 1: Adding NuGet Package Source 

The Telerik NuGet packages are available as downloadable `.nupkg` files that can be used in a local package source, and they also can be installed from the online Telerik NuGet server. The following articles show how to setup a  local and online package sources:

This example shows how to install Telerik packages using the online server. This requires you to have an account in telerik.com and also a licensed (or trial) version of the product.

1. Navigate to the Package Manager Settings menu in Visual Studio.
1. Add a new source in the Package Sources section.
1. In the Source field fill the address of the Telerik NuGet Server and click Update. The address is: [https://nuget.telerik.com/v3/index.json](https://nuget.telerik.com/v3/index.json)
1. The Telerik Server is added and ready to use.

## Step 2: Installing NuGet Packages

The following steps show how to search and install nuget packages in the Telerik package source.

1. Select your solution or project and click on the Manage NuGet Packages menu.
1. Set the Telerik server as the current package source. This will prompt you to log into your telerik.com account. Enter user credentials and search for the needed package.
1. Install the package. Some packages depend on other ones in the server, so they will be isntalled automatically if needed.

>tip The NuGet server provides different types of packages for the Telerik components. Read more in the [Available Packages]({%slug %}) article.

## Next Steps

* Getting Started


## See Also


