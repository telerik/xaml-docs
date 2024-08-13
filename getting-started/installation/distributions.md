---
title: .NET Version Distributions
page_title: Version Distributions
description: This article lists the .NET versions supported by Telerik UI for WPF.
slug: installation-distributions
tags: distributions,versions
published: True
position: 3
---

# Telerik .NET Version Distributions

The Telerik UI for WPF product provides several different sets of assemblies (distributions) built against different .NET versions. This article lists the versions used to build the Telerik dlls and in what .NET runtime versions you can use them.

## Supported Versions

| .NET distribution | Release | End of support | Supported runtime |
|----|----|----|----|
| .NET Framework 4.6.2 | 2024 Q2 | N/A | .NET Framework 4.6.2 and later |
| .NET 6 | R3 2021 SP1 | N/A | .NET 6 and later	|
| .NET 7 | R3 2022 SP2 | 2024 Q4 | .NET 7, NET 8 and later |

### Out of Support Versions

| .NET distribution | Release | End of support | Supported runtime |
|----|----|----|----|
| .NET Framework 4.0 | Q2 2010 | 2024 Q2 | .NET Framework 4.0 and later |
| .NET Framework 4.5 | Q3 2012 | 2024 Q2 | .NET Framework 4.5 and later |
| .NET Core 3.1 | R1 2019 | 2024 Q2 | .NET Core 3.1 and later |
| .NET 5 | R2 2020 | R3 2022 SP2 | .NET 5 and later |

#### Terms used in the tables

* __.NET distribution__&mdash;The .NET version which the Telerik dlls are built against.
* __Release__&mdash;This is the Telerik release when the corresponding .NET version was first introduced. In other words, the release when the Telerik dlls were built agains the corresponding .NET version for the first time.
* __End of support__&mdash;This is the first release when the Telerik dlls with the corresponding .NET version are no longer distributed. For example, in 2024 Q2 the Telerik UI for WPF product no longer distributes dlls built against .NET Framework 4.0.
* __Supported runtime__&mdash;The supported .NET rintimes where you can use the corresponding Telerik assemblies. This is common information related to the .NET backward compatibility. For example, the .NET 6 dlls can be used in a project that targets .NET 8.

## See Also  
* [Embracing the Future: Product Update for Enhanced Performance and Security](https://www.telerik.com/blogs/embracing-future-product-update-enhanced-performance-and-security)
* [Microsoft Guide for Migrating to .NET Framework 4.6.2 and later](https://learn.microsoft.com/en-us/dotnet/framework/migration-guide)
