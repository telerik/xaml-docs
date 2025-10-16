---
title: Download New Version
page_title: Download New Version
description: With the Progress Telerik Visual Studio Extension you keep your projects in an up-to-date state.
slug: radcontrols-vs-extensions-project-latest-version-acquirer
tags: latest,version,acquirer,tool
published: True
position: 6
---

# Download New Version

With the Progress Telerik UI for {{ site.framework_name }} Extension you keep your projects in an up-to-date state. The __Latest Version Acquirer__ tool automatically retrieves the most fresh Telerik UI for {{ site.framework_name }} distribution, available on the Telerik website. Running the [Upgrade Wizard]({%slug radcontrols-for-wpf-vs-extensions-upgrading%}) as a next step makes the task of latest Telerik UI for {{ site.framework_name }} package utilization extremely easy.

When a solution containing a Telerik UI for WPF project is loaded in Visual Studio, the Progress Telerik UI for WPF Extension queue the Telerik website for a new version of Telerik UI for {{ site.framework_name }}. A dialog gets displayed when a new version is discovered:

![extensions acquirertool wpf 1](images/extensions_acquirertool_wpf_1.png)

>If you've disabled the notifications, you can use the [Options Dialog]({%slug radcontrols-vs-extensions-options%}) to activate them again.

Clicking the __Update Now__ button starts the Latest Version Acquirer tool, prompting for your Telerik credentials and the type of license you own in its first page. If you do not have a [www.telerik.com](http://www.telerik.com/) account, you can create one through the __Create an account for free__ link.

![extensions acquirertool wpf 2](images/extensions_acquirertool_wpf_2.png)

You can use the __Save my password__ checkbox to save having to enter your Telerik credentials multiple times. The persistance is done in a secure manner and credentials are saved in a per-user context. This way other users on the machine that do not have access to your user data from downloading through your account.

If your subscription has expired, you could either proceed with downloading a trial distribution or you could renew it and initiate the download again.

![extensions acquirertool wpf 3](images/extensions_acquirertool_wpf_3.png)

You can check the additional information about the release by clicking the __Release Notes__ link. This will start a browser, navigated to a page with the release notes related to the specific version.

![extensions acquirertool wpf 4](images/extensions_acquirertool_wpf_4.png)

![extensions acquirertool wpf 5](images/extensions_acquirertool_wpf_5.png)

Once the download succeeds, the latest version of the Telerik UI for {{ site.framework_name }} will be available for use in the [Upgrade Wizard]({%slug radcontrols-for-wpf-vs-extensions-upgrading%}) and the [New Project Wizard]({%slug radcontrols-for-wpf-vs-extensions-project-configuration%}).

The Download buttons of the [Upgrade Wizard]({%slug radcontrols-for-wpf-vs-extensions-upgrading%}) and the [New Project Wizard]({%slug radcontrols-for-wpf-vs-extensions-project-configuration%}) launch the Latest Version Acquirer tool too.

The Latest Version Acquirer tool downloads the zip files, containing the latest Telerik binaries and any resources vital for the Telerik project creation. These get unpacked to the %appdata%\Telerik\Updates folder. If you find the list of packages offered too long and you don't need the older versions, you can close Visual Studio and use Windows Explorer to delete these distributions.
