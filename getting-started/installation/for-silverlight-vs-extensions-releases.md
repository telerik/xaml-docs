---
title: Major and Minor releases
page_title: Major and Minor releases
description: Major and Minor releases
slug: radcontrols-for-silverlight-vs-extensions-releases
tags: major,and,minor,releases
published: True
position: 7
site_name: Silverlight
---

# Major and Minor releases

Telerik __UI for Silverlight__ has two types of official releases – major and minor releases. Examples of major releases are __Q1 2011__, __Q3 2011__and examples of minor releases are __Q3 2011 SP1__, __Q3 2011 SP2__ and __Q1 2012 SP1__. Both major and minor releases are distributed as __msi__ installation package which follows certain upgrade logic explained below.

First, major releases can be installed in parallel on the same machine. This means that when you install new major release it doesn’t uninstall your existing major releases. An example is that you can have __Q2 2011__, __Q3 2011__ and __Q1 2012__ installed at the same time.

Minor releases on the other hand can’t be installed in parallel when they are from the same major release. This means that when you install a newer minor release it will automatically uninstall the previous version minor release which is from the same major release. An example is that if there are two minor releases for the same major release e.g. __Q1 2012 SP1__ and __Q1 2012 SP2__ for the__Q1 2012__ release then you can have only one of the specified versions.

Here are some sample scenarios:

__Parallel major releases__

1. Install Q2 2011

1. Install Q3 2011

1. Install Q1 2012

__Result:__ All three versions (__Q2 2011__, __Q3 2011__ and __Q1 2012__) are installed in parallel on the machineMinor releases from the same major release

1. Install Q1 2012

1. Install Q1 2012 SP1

1. Install Q1 2012 SP2

__Result:__ Only the latest version (__Q1 2012 SP2__) is installed on the machineMinor releases from different major releases

1. Install Q3 2011

1. Install Q3 2011 SP1

1. Install Q1 2012 SP1

__Result:__ __Q3 2011 SP1__ and __Q1 2012 SP1__ are installed on the machine

>Part of the__UI for Silverlight__are the__Visual Studio Extensions__. Since the __Visual Studio Extensions__ integrate into the __Visual Studio IDE__ they don’t support parallel versions. When newer version is installed regardless of its type (major/minor) the __Visual Studio Extensions__ get updated to the newer version.

## See Also

 * [Upgrading Telerik UI Trial to Telerik UI Developer License or Newer Version]({%slug installation-upgrading-from-trial-to-developer-license%})

 * [Upgrading to a new UI for Silverlight distribution]({%slug radcontrols-for-silverlight-vs-extensions-upgrading%})

 * [Latest Version Acquirer Tool]({%slug radcontrols-vs-extensions-project-latest-version-acquirer%})
