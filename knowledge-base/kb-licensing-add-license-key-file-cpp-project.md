---
title:  Adding License Key File (TelerikLicense) in a Managed CPP Project loading Telerik WPF Controls Module
description: Include License Key File (TelerikLicense) in a Managed C++ Project loading Telerik WPF Controls Module
type: how-to
page_title: Creating License Script Key File (TelerikLicense) in a Managed CPP Solution
slug: kb-licensing-add-license-key-file-cpp-project
tags: licensing, assembly, subdirectories, wpf, telerik, cpp,c++,managed
res_type: kb
ticketid: 1691691
---

## Environment
<table>
<tbody>
<tr>
<td> Product </td>
<td> Progress® Telerik® UI for WPF </td>
</tr>
<tr>
<td> Version </td>
<td> 2025.2.707 </td>
</tr>
</tbody>
</table>

## Description

How to add the license script key file in your project, when Telerik WPF components are loaded through a CPP/C++ project.

## Solution

In this case, you should add a TelerikLicense.cs file in the C# project that defines the Telerik controls and another TelerikLicense.cpp file in the CPP project that loads the Telerik-related code.

```xml
    <ClCompile Include="TelerikLicense.cpp" />
```

The content of the TelerikLicense.cpp file should look like this:

```cpp
    #include "pch.h"
    using namespace Telerik::Licensing;
    [assembly:EvidenceAttribute("  <my key>  ")];
```


