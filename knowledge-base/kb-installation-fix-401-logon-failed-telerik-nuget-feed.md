---
title: Error 401 (Logon failed) When Connecting to Telerik NuGet Feed
description: Resolve the Error 401 (Logon failed) issue when authenticating to the Telerik NuGet feed.
page_title: Fix Error 401 (Logon failed) for Telerik NuGet Feed
type: troubleshooting
slug: kb-installation-fix-401-logon-failed-telerik-nuget-feed
position: 0
tags: installation, nuget, authentication, 401, credential manager, password
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

When connecting to the Telerik NuGet feed, package restore or package source validation may fail with an authentication error similar to:

`Error 401: Logon failed`

## Solution

1. Close all Visual Studio instances.

1. Open Windows Credential Manager.

1. Find the entry for `nuget.telerik.com`, then edit it.

1. Verify the credentials:

   * Use your Telerik account email as the username.
   * Use your Telerik account password.
   * Verify the source URL is `https://nuget.telerik.com/v3/index.json`.

1. Save the changes and reopen Visual Studio.

If the password contains special characters, HTML-encode it before using it in the NuGet credential entry.

>important Do not use online tools to encode your password. Use PowerShell locally.

```powershell
Add-Type -AssemblyName System.Web
[System.Web.HttpUtility]::HtmlEncode('my&super&P@ssword')
```

For example, `my&super&P@ssword` becomes `my&amp;super&amp;P@ssword`.

## See Also

* [NuGet Packages]({%slug nuget-installation%})
