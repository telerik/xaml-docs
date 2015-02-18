---
title: License File
page_title: License File
description: License File
slug: license-file
tags: license
published: True
position: 2
---

# License File
 

As of Q1 2015, the Telerik UI for WPF suite uses the standard .NET licensing mechanism, which means that using the controls in design-time causes Visual Studio to add a __license.licx__ to the solution. This file is used only in design-mode and is not needed for deployment explicitly. The .NET framework (lc.exe) will embed it in the assembly your when your application is built for deployment.

The license file is maintained by Visual Studio and contains information about all licensed components in the application (including non-Telerik products). Thus, you may consider to avoid adding the license.licx file to your source control.

Having this license file is not expected to bring any performance/compilation issues and you can ignore it.
In case your project build fails with errors pointing to the license file, you can delete it and rebuild.