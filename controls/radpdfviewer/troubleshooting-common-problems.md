---
title: Troubleshooting Common Problems
page_title: Troubleshooting Common Problems
description: Check our &quot;Troubleshooting Common Problems&quot; documentation article for the RadPdfViewer {{ site.framework_name }} control.
slug: radpdfviewer-troubleshooting-common-problems
tags: troubleshooting,common,problems
published: True
position: 12
---

# Troubleshooting Common Problems

This article describes common problems that can be encountered when using RadPdfViewer and their solutions.

## PDF retrieved from database is not shown correctly

There are several perquisites that have to be fulfilled in order for a PDF file to be loaded correctly. Some of them are listed [here]({%slug radpdfviewer-showing-a-file%}), along with the ways to show a file.
        
When retrieving a file as a byte array from database and creating a __MemoryStream__ from it, there are cases when the retrieved file is not shown correctly. This is usually due to additional NULL(0) bytes appended to the end of the document when it was stored in the database.
        
PDF files have to end with __%%EOF__ marker, so this essentially makes the document invalid and __RadPdfViewer__ is unable to show it. __RadPdfViewer__ is looking for this marker in the last 1024 bytes and if it does not find it, throws an exception.
        
In order to fix the issue, you can manually trim the additional (null) bytes. 

## Poor Performance

**RadPdfViewer** visualizes the documents in parts - while the user scrolls in it - and this optimization is lost when the control is placed in a container without a specified size, which measures its children in *Infinity*. As the document pages themselves should be measured and visualized all at once, loading a bigger document takes much time. Make sure that RadPdfViewer is not placed inside such a contained (ScrollViewer, for example).
