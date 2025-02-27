---
title: Error 503 (Service Unavailable) with Telerik NuGet Packages
description: Learn how to resolve the "503 (Service Unavailable)" error encountered when trying to restore Telerik NuGet packages in your project.
type: troubleshooting
page_title: Resolve Error 'Retrying FindPackagesByIdAsyncCore for Source https://nuget.telerik.com/nuget/FindPackagesById()' 
slug: kb-installing-nuget-fix-503-service-unavailable-error-telerik-nuget-packages
tags: nuget, telerik, wpf, 503 error, service unavailable, package restore
res_type: kb
ticketid: 1680292
---

## Environment

<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2025.1.211</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>Telerik UI for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

When attempting to build a project that includes Telerik UI for WPF NuGetPackages, the following error is encountered during package restore process: 

`Response status code does not indicate success: 503 (Service Unavailable). Retrying FindPackagesByIdAsyncCore for Source https://nuget.telerik.com/nuget/FindPackagesById()`

## Solution

The error message occurs because the package restore process tries to access to now discounted Telerik NuGet feed version 2.0. This can be indicated by the URL in the message. The new URL is `https://nuget.telerik.com/v3/index.json`

To resolve this, make sure to adjust the NuGet package source to point to the new URL: `https://nuget.telerik.com/v3/index.json`

