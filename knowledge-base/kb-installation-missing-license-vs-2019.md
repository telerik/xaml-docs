---
title: No License Key Found Warning in Visual Studio 2019 When License Key is Present
description: No license key found error shown in Visual Studio 2019 .NET Framework project even when license key is installed.
page_title: No Product Reference Detected Licensing Error Shown in .NET Framework Project
type: troubleshooting
slug: kb-installation-missing-license-vs-2019
position: 0
tags: installation, telerik, licensing, license, key, not, found
res_type: kb
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
			<td>UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The following licensing warnings occur when building a .NET Framework project using Visual Studio 2019, when a license key is installed.

* `No Telerik or Kendo UI product references detected in project. Consult the product documentation or contanct support at progress.com`

* `No license key found`

## Solution

The error manifests because of a limitation in the licensing implementation when loaded in the specific setup. You can safely ignore it. Alternatively, use Visual Studio 2022.