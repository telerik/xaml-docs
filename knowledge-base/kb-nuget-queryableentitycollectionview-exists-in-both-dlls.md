---
title: The Type QueryableEntityCollectionView&lt;T&gt; Exists in Both Telerik.Windows.Controls.EntityFramework and Telerik.Windows.Controls.EntityFramework60 Error
description: The type QueryableEntityCollectionView&lt;T&gt; exists in both Telerik.Windows.Controls.EntityFramework and Telerik.Windows.Controls.EntityFramework60 error appears when the nuget package with all Telerik WPF controls is added.
page_title: QueryableEntityCollectionView Exists in Both Telerik.Windows.Controls.EntityFramework Assemblies Error When Nuget Package is Referenced
type: troubleshooting
slug: kb-nuget-queryableentitycollectionview-exists-in-both-dlls
position: 0
tags: nuget,qcv,qecv,entityframework,error
ticketid: 1479111
res_type: kb
---

## Environment

<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2020.2.617</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>Telerik UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

An error "The type QueryableEntityCollectionView<T> exists in both Telerik.Windows.Controls.EntityFramework and Telerik.Windows.Controls.EntityFramework60" is shown when installing the __Telerik.UI.for.Wpf__ nuget that contains all Telerik UI for WPF dlls.

## Solution

This happens because the QueryableEntityCollectionView<T> dll is defined in both the Telerik.Windows.Controls.EntityFramework and Telerik.Windows.Controls.EntityFramework60 dlls. To resolve this you will need to __remove one of the two dlls__ (based on the EntityFramework version you are using - 5 or 6+). If you're using NuGet packages, you need to use [separate nuget packages]({%slug nuget-installation%}) to avoid this error.
