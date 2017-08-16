---
title: Upgrade Project
page_title: Upgrade Project
description: Upgrade Project
slug: radcontrols-for-wpf-vs-extensions-upgrading
tags: upgrading,to,a,new,ui,for,wpf,distribution
published: True
position: 4
site_name: WPF
---

# Upgrade Project



##

An important feature in the Visual Studio Extensions is the __Project Upgrade Wizard__.

The Upgrade Wizard (started by using the __Telerik > UI for WPF > Upgrade Wizard__ menu item) is used to change the version of __UI for WPF__ your project uses.

In addition to the pure assembly reference change, the upgrade wizard provides several important features:

* Check if a new version of __UI for WPF__ is available on the Telerik website.

* Download of a newly discovered version.

* Visual Studio toolbox update.

* Project themes upgrade (when using [implicit styles]({%slug styling-apperance-implicit-styles-overview%})).

* Current project backup.

On the first step the wizard provides basic update process information  

![VSExtentions WPF Upgrade Wizard Initial Page](images/VSExtentions_WPF_UpgradeWizardInitialPage.png)


You can choose which projects will be updated (it is recommended to upgrade all projects to the chosen version, not just part of them) and the version which they will be upgraded to and whether or not all binaries should get copied to your solution folder (useful when utilizing a build server or working on a project collaboratively). The Compatibility button will invoke the [Upgrade API Analyzer tool](http://docs.telerik.com/devtools/wpf/upgrade-api-analyzer):

![VSExtentions WPF Upgrade Wizard](images/VSExtentions_WPF_UpgradeWizard.png)

The next screen allows you to update the Visual Studio Toolbox with the newly selected controls, so that you avoid accidental reference change during a control drag and drop, as well as creating a backup of your project:

![VSExtentions WPF Upgrade Wizard Toolbox](images/VSExtentions_WPF_UpgradeWizardOptions.png)

Notes:

* The distribution selection screen lists all the UI for WPF versions that can be detected automatically. These are versions, installed by using the Windows Installer MSI package, versions, downloaded by the Upgrade Wizard and versions. Hotfixes, downloaded manually cannot be detected.

* You can use the __GET LATEST__ button to access the Latest Version Acquirer and download the latest available version on our website.

* The distribution, downloaded by the Upgrade Wizard contains only the "hotfix" files, e.g. the barebone files, needed for a project to run correctly. It does not contain the documentation or the Live Examples.

	![VSExtensions Themes Folder](images/VSExtensions_WPF_ThemeFilesUnderNamedFolder.png)

* A Visual Studio restart will be required in order to update your toolbox. If the automatic restart fails, a restart should be initiated manually in order to complete the toolbox upgrade.


## See Also

 * [Configure Project]({%slug radcontrols-for-wpf-vs-extensions-project-configuration%})

 * [Automatic Dependency Resolving]({%slug radcontrols-for-wpf-vs-extensions-automatic-resolving%})

 * [Download New Version]({%slug radcontrols-vs-extensions-project-latest-version-acquirer%})
