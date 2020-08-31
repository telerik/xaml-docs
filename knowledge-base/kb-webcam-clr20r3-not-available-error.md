---
title: DllNotFoundException - CLR20r3 Error When Using RadWebCam on Windows 10 Pro N
description: Unable to load DLL mfplat.dll - The specified module could not be found error appears when you start the webcam control on a operating system with limited media packages installed.
page_title: Unable to load DLL mfplat.dll When Opening RadWebCam
type: how-to
slug: kb-webcam-clr20r3-not-available-error
position: 0
tags: clr20r3, windows, mfplat, dllnotfound
ticketid: 1480299
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2018.2.515</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadWebCam for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

"DllNotFoundException - Unable to load DLL mfplat.dll - The specified module could not be found" is thrown when starting the RadWebCam control on Windows 10 Pro N.

## Solution

This happens because the Windows 10 Pro N version doesn't have installed the Media Feature Pack. To resolve this, open the __optional features__ Windows application and install the __Media Feature Pack__.