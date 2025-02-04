---
title: Could not Load File Or Assembly Telerik.Licensing.Runtime, Version 1.4.4.0 Runtime Error
description: FileNotFoundException thrown at runtime when the version of the referenced Telerik.Licensing.Runtime dll is mismatched.
page_title: FileNotFoundException Exception Cannot Load Telerik.Licensing.Runtime Assembly
type: how-to
slug: kb-installation-cannot-load-licensing-assembly
position: 0
tags: installation, telerik, licensing, license, key, load, exception
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2025.1.213</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

`FileNotFoundException` is thrown at runtime, which states that the `Telerik.Licensing.Runtime` assembly cannot be loaded. The error message is something like this:

`FileNotFoundException: Could not load file or assembly 'Telerik.Licensing.Runtime, Version=1.4.4.0, Culture=neutral, PublicKeyToken=tokenhere'. The system cannot find the file specified.`

This may happen if you upgrade to 2025 Q1 from an older version. With 2025 Q1, a new [licensing mechanism]({%slug installing-license-key%}) was introduced, which requires you to reference the `Telerik.Licensing.Runtime` dll.

## Solution

The exception means that the version of the `Telerik.Licensing.Runtime` dll mismatches the version of the version expected by the other Telerik UI for WPF dlls. This may happen if the project references the Telerik dlls containing the component/controls from one version and the `Telerik.Licensing.Runtime` dll from another version of Telerik UI for WPF.

To resolve the problem, make sure that all Telerik controls are referenced from the same installation place, thus using the same release version.