---
title: Troubleshoot Network Access to Telerik NuGet Feed
description: Verify and troubleshoot network or proxy issues when the Telerik NuGet feed is unreachable.
page_title: Troubleshoot Network or Proxy Access to Telerik NuGet Feed
type: troubleshooting
slug: kb-installation-troubleshoot-network-access-telerik-nuget-feed
position: 0
tags: installation, nuget, network, proxy, github actions, azure devops
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

NuGet restore from Telerik feed may fail when the machine is behind a proxy or a restricted network. This can affect local development machines and CI agents (for example, GitHub Actions runners or Azure DevOps agents).

## Solution

1. Open the following URL in a browser:

   `https://nuget.telerik.com/v3/search?q=wpf`

1. Sign in with your Telerik account when prompted.

1. Confirm that the page returns Telerik UI for WPF package results.

1. If the URL cannot be reached, review and adjust your proxy or firewall configuration so the environment can access `nuget.telerik.com`.

## See Also

* [NuGet Packages]({%slug nuget-installation%})
* [Troubleshooting]({%slug nuget-troubleshooting%})
