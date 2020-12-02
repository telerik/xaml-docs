---
title: SDK Samples Browser Cannot Be Installed or Crashes
page_title: Errors when Installing or Running the SDK Samples Browser
description: This article lists the possible errors when installing and running the SDK Samples Browser and provides possible solutions for them.
type: troubleshooting
slug: kb-sdk-samples-browser-cannot-be-installed-or-run
position: 0
tags: sdk, samples, browser, cannot, install, run
ticketid: 1483719
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
			<td>Progress® Telerik® UI for WPF</td>
		</tr>
	</tbody>
</table>

## Description

The SDK Samples Browser cannot be installed or crashes when you run it.

## Errors during Installation

If you're unable to install the ClickOnce application and receive the following error message:

"Your administrator has blocked this application because it potentially poses a security risk to your computer."

This is means that you do not have the required permissions to install ClickOnce applications on the machine and need to [configure the ClickOnce trust prompt](https://docs.microsoft.com/en-us/visualstudio/deployment/how-to-configure-the-clickonce-trust-prompt-behavior?view=vs-2019) and ensure the current user has the necessary permissions.

## Errors when Running the Browser

One possible error when running the browser is the following:

"The deployment identity does not match the subscription."

If you receive this error when running the ClickOnce application, this may mean that there are some remnants (cache) of previous installations or that the application did not install correctly. What you can do in this case is to follow the next troubleshooting steps:

**1.** Uninstall the Telerik SDK Samples Browser application.

**2.** Delete the contents of the "C:\Users\{username}\AppData\Local\Apps\2.0" folder to make sure that there aren't any cached files.

**3.** Install the SDK Samples Browser application again. 

## See Also

* [SDK Samples Browser]({%slug sdk-samples-browser%})