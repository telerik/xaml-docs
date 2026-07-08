---
title: Unable to Load the Service Index for Source https://nuget.telerik.com/v3/index.json
description: Resolve the unable to load service index error for the Telerik NuGet source.
page_title: Fix Unable to Load Service Index for Telerik NuGet Source
type: troubleshooting
slug: kb-installation-unable-load-service-index-telerik-nuget-feed
position: 0
tags: installation, nuget, service index, source, connectivity
res_type: kb
---

## Environment

<table>
    <tbody>
        <tr>
            <td>Product</td>
            <td>UI for WPF</td>
        </tr>
    </tbody>
</table>

## Description

Package restore may fail with the following message:

`Unable to load the service index for source https://nuget.telerik.com/v3/index.json`

## Solution

This error can occur when the Telerik NuGet service is temporarily unavailable.

1. Check the Telerik status page at [https://status.telerik.com/](https://status.telerik.com/).

1. If there is an active incident affecting NuGet services, wait until it is resolved and then retry restore.

1. If the status page reports no issues, verify authentication and network access:

   * [Error 401 (Logon failed) When Connecting to Telerik NuGet Feed]({%slug kb-installation-fix-401-logon-failed-telerik-nuget-feed%})
   * [Troubleshoot Network Access to Telerik NuGet Feed]({%slug kb-installation-troubleshoot-network-access-telerik-nuget-feed%})

## See Also

* [Error 503 (Service Unavailable) with Telerik NuGet Packages]({%slug kb-installing-nuget-fix-503-service-unavailable-error-telerik-nuget-packages%})
* [Troubleshooting]({%slug nuget-troubleshooting%})
