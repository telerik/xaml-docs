---
title: License File
page_title: License File
description: License File.
slug: license-file
tags: license
published: True
position: 2
---

# License File
 

As of Q1 2015, the Telerik UI for WPF suite uses the standard .NET licensing mechanism, which means that using the controls in design-time may cause Visual Studio to add a [license.licx](https://docs.microsoft.com/en-us/dotnet/framework/tools/lc-exe-license-compiler) to the __Properties__ folder of the project. This file is used only in design-mode and is not needed for deployment explicitly. 

Having this license file is not expected to bring any performance/compilation issues and __you can ignore it__. 

In case your project __build fails__ with errors pointing to the license file, you can delete it and rebuild.

If you are working under __source control__, once the file is created, it will be detected as a change by your source control system. We would suggest that you check-in this file initially. Then, when it is checked-out again during your work, it is up to you to decide whether to check it in, or discard the changes.
