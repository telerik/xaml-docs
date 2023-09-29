---
title: FileDialogs Demos Not Available in WPF Control Examples App
description: "How to run FileDialogs WPF Demos application." 
type: how-to
page_title: How to run FileDialogs WPF Demos.
slug: kb-filedialogsdemos-notavailable
position: 0
tags: filedialogs, demos
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

How to run `FileDialogs Demos` in `WPF Control Examples` application. 
This often happens when you have an older installation of the `WPF Demos` application and you install the latest one. It is related to cache in the [ClickOnce]({%kb-sdk-samples-browser-cannot-be-installed-or-run%}) files of the application.

## Solution

1) You can delete the application manually from the [AppData folder]({%installing-wpf-demos%}).
2) After that, you download and install it again.
