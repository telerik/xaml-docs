---
title: WPF Controls Demos Not Available in WPF Control Examples App
description: "WPF controls Demos application not available." 
type: troubleshooting
page_title: Run WPF Controls Demos.
slug: kb-controlsdemos-notavailable
position: 0
tags: controls, demos
ticketid: 1615001
res_type: kb
---

## Environment

<table>
    <tbody>
        <tr>
            <td>Product Version</td>
            <td>2023.2.718</td>
        </tr>
        <tr>
            <td>Product</td>
            <td>RadFileDialogs for WPF</td>
        </tr>
    </tbody>
</table>


## Description

The control examples are not loading in the WPF Controls Examples application.
This often happens when you have an older installation of the `WPF Demos` application and you install the latest one. It is related to cache in the [ClickOnce]({%slug kb-sdk-samples-browser-cannot-be-installed-or-run%}) files of the application located in C:\Users\\&lt;your_user&gt;\AppData\Local\Apps\2.0.
![WPF RadHeatMap Overview](images/WPFControls-NotAvailable.png)

## Solution

1) Close the WPF Demos application.
2) You can delete the application manually from the [AppData folder]({%slug installing-wpf-demos%}) located in the.
3) After that, you download and install it again.
