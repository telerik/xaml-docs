---
title: Deployment and Application Do Not Have Matching Security Zones - Error When Launching Demos
page_title: Deployment Error When Starting WPF Demo Application
description: Cannot install Color Theme Generator solution because of no matching security zones error occurs.
type: troubleshooting
slug: kb-cannot-install-wpf-demos-error
position: 0
tags: error,cannot,install,colorthemegenrator
ticketid: 1423997
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2019.2.618</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>Progress® Telerik® UI for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

"Deployment and Application Do Not Have Matching Security Zones" appears when launching Telerik WPF demos. This error may occur when launching the WPF Demos application, the ColorThemeGenerator, or any other ClickOnce packaged application from the Telerik UI for WPF suite.

ERROR SUMMARY  

Below is a summary of the errors, details of these errors are listed later in the log.
- Activation of C:\Users\<user>\Downloads\ColorThemeGenerator.application resulted in exception. Following failure messages were detected:
- Deployment and application do not have matching security zones.

## Solution 1

When go to the demo download page make sure that you click on the __Install button__. If you click on the "launch" link the error may appear.

## Solution 2

Re-install the application using the following steps:

1. Uninstall the demo application (example: Color Theme Generator).

2. Delete the contents of the following folder - "C:\Users\your user here\AppData\Local\Apps\2.0\Data". Note that this will delete all the ClickOnce applications.

3. Download the setup file of the demo application. Do this via the "Install" button.

4. Install the application again.