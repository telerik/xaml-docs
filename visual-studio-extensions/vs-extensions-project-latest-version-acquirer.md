---
title: Download New Version
page_title: Download New Version
description: Download New Version
slug: radcontrols-vs-extensions-project-latest-version-acquirer
tags: latest,version,acquirer,tool
published: True
position: 6
---

# Download New Version



## 

With the Telerik Visual Studio Extensions you keep your projects in an up-to-date state. The __Latest Version Acquirer__ tool automatically retrieves the freshest UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} distribution, available on the Telerik website. Running the {% if site.site_name == 'Silverlight' %}[Upgrade Wizard]({%slug radcontrols-for-silverlight-vs-extensions-upgrading%}){% endif %}{% if site.site_name == 'WPF' %}[Upgrade Wizard]({%slug radcontrols-for-wpf-vs-extensions-upgrading%}){% endif %} as a next step makes the task of latest UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} package utilization extremely easy.
        

Once a day, upon Visual Studio launch, the Telerik {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} VSExtensions queue the Telerik website for a new version of UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}. A dialog gets displayed when a new version is discovered:
		

{% if site.site_name == 'Silverlight' %}![extensions acquirertool sl 1](images/extensions_acquirertool_sl_1.png){% endif %}{% if site.site_name == 'WPF' %}![extensions acquirertool wpf 1](images/extensions_acquirertool_wpf_1.png){% endif %}

>If you've disabled the notifications, you can use the [Options Dialog]({%slug radcontrols-vs-extensions-options%}) to activate them again.

Clicking the __Get Now__ button starts the Latest Version Acquirer tool, prompting for your Telerik credentials and the type of license you own in its first page. If you do not have a [www.telerik.com](http://www.telerik.com/) account, you can create one through the __Register__ link.
        

{% if site.site_name == 'Silverlight' %}![extensions acquirertool sl 2](images/extensions_acquirertool_sl_2.png){% endif %}{% if site.site_name == 'WPF' %}![extensions acquirertool wpf 2](images/extensions_acquirertool_wpf_2.png){% endif %}

{% if site.site_name == 'Silverlight' %}You can check the additional information about the release by clicking the __Release Notes__ link. This will start a browser, navigated to a page with the release notes related to the specific version.{% endif %}
       	

You can use the __Save my password__ checkbox to save having to enter your Telerik credentials multiple times. The persistance is done in a secure manner and credentials are saved in a per-user context. This way other users on the machine that do not have access to your user data from downloading through your account.
       	

If your subscription has expired, you could either proceed with downloading a trial distribution or you could renew it and initiate the download again.
		

{% if site.site_name == 'Silverlight' %}![extensions acquirertool sl 3](images/extensions_acquirertool_sl_3.png){% endif %}{% if site.site_name == 'WPF' %}![extensions acquirertool wpf 3](images/extensions_acquirertool_wpf_3.png){% endif %}

{% if site.site_name == 'WPF' %}You can check the additional information about the release by clicking the __Release Notes__ link. This will start a browser, navigated to a page with the release notes related to the specific version.{% endif %}

{% if site.site_name == 'Silverlight' %}![extensions acquirertool sl 4](images/extensions_acquirertool_sl_4.png){% endif %}{% if site.site_name == 'WPF' %}![extensions acquirertool wpf 4](images/extensions_acquirertool_wpf_4.png){% endif %}

{% if site.site_name == 'Silverlight' %}![extensions acquirertool sl 5](images/extensions_acquirertool_sl_5.png){% endif %}{% if site.site_name == 'WPF' %}![extensions acquirertool wpf 5](images/extensions_acquirertool_wpf_5.png){% endif %}

Once the download succeeds, the latest version of the Telerik UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} will be available for use in the {% if site.site_name == 'Silverlight' %}[Upgrade Wizard]({%slug radcontrols-for-silverlight-vs-extensions-upgrading%}){% endif %}{% if site.site_name == 'WPF' %}[Upgrade Wizard]({%slug radcontrols-for-wpf-vs-extensions-upgrading%}){% endif %} and the {% if site.site_name == 'Silverlight' %}[New Project Wizard]({%slug radcontrols-for-silverlight-vs-extensions-project-configuration%}){% endif %}{% if site.site_name == 'WPF' %}[New Project Wizard]({%slug radcontrols-for-wpf-vs-extensions-project-configuration%}){% endif %}.
        

>tipThe Download buttons of the {% if site.site_name == 'Silverlight' %}[Upgrade Wizard]({%slug radcontrols-for-silverlight-vs-extensions-upgrading%}){% endif %}{% if site.site_name == 'WPF' %}[Upgrade Wizard]({%slug radcontrols-for-wpf-vs-extensions-upgrading%}){% endif %} and the and the {% if site.site_name == 'Silverlight' %}[New Project Wizard]({%slug radcontrols-for-silverlight-vs-extensions-project-configuration%}){% endif %}{% if site.site_name == 'WPF' %}[New Project Wizard]({%slug radcontrols-for-wpf-vs-extensions-project-configuration%}){% endif %} launch the Latest Version Acquirer tool too. 
        

>The Latest Version Acquirer tool actually downloads the hotfix zip files, containing the latest Telerik binaries and any resources vital for the Telerik project creation. These get unpacked to the %appdata%\Telerik\Updates folder. If you find the list of packages offered too long and you don't need the older versions, you can close Visual Studio and use Windows Explorer to delete these distributions.
		
