---
title: Application Crash on Load with RadWebCam - MFCreateDeviceSource failed: WIN32_ERROR_NOT_FOUND
description: Resolving application crash when upgrading to RadWebCam with error MFCreateDeviceSource failed: WIN32_ERROR_NOT_FOUND.
type: troubleshooting
page_title: RadWebCam Crash on Load Due to MFCreateDeviceSource Error
meta_title: RadWebCam Crash on Load Due to MFCreateDeviceSource Error
slug: radwebcam-mfcreatedevicesource-error
tags: webcam, ui-for-wpf, radwebcam, mfcreatedevicesource, skia-sharp, package-config, win32-error
res_type: kb
ticketid: 1708478
---

## Environment
<table>
<tbody>
<tr>
<td> Product </td>
<td> UI for WPF RadWebCam </td>
</tr>
<tr>
<td> Version </td>
<td> 2025.4.1321 </td>
</tr>
</tbody>
</table>

## Description

I encountered an issue where my application crashes immediately on load after upgrading to the new [RadWebCam](https://docs.telerik.com/devtools/wpf/controls/radwebcam/overview) control from the SharpDX version. The error message displayed is `MFCreateDeviceSource failed: WIN32_ERROR_NOT_FOUND`. The crash occurs before any source code execution, and troubleshooting steps such as validating the webcam functionality and permissions, creating a fresh test app, and revising NuGet dependencies did not resolve the issue.

## Cause

The crash occurs due to the project's package management format being set to `PackageReference`, which leads to incomplete functionality of the Telerik NuGet package for the RadWebCam control. Additionally, the `libSkiaSharp.dll` file may not be correctly included during the publishing process.

## Solution

To resolve the issue, follow these steps:

1. Change the project's NuGet package management format from `PackageReference` to `Packages.config`.
2. Ensure all required Telerik and SkiaSharp dependencies are correctly added to the project.
3. Verify the presence of `libSkiaSharp.dll` in the `bin\x64` folder.
4. Manually include `libSkiaSharp.dll` in the publishing process, if necessary.

## See Also

- [RadWebCam Overview](https://docs.telerik.com/devtools/wpf/controls/radwebcam/overview)
- [Telerik UI for WPF Documentation](https://docs.telerik.com/devtools/wpf/introduction)
