---
title: Changes
page_title: Changes
description: Changes
slug: radziplibrary-changes
tags: changes
published: True
position: 0
---

# Changes



This topic summarizes the new functionality introduced in the library with helpful links to places in the documentation that describe in greater
        detail the new functionality and how it can be used.
      

## What's New in 2014 Q1 - 2014.1.0226

* ZIP library has been redesigned from scratch for better cross-platform compatibility (.NET, Silverlight, Windows Store Apps, Windows Phone),
              better support of the standards and better functionality.
            

* ZIP library now supports both ZIP and ZIP64 specifications, i.e. large ZIP files with more than 4GB length are supported now.
            

* New API supports password protection. For the moment only traditional PKWARE encryption is implemented.
            

* The existing ZIP library API (ZipPackage, ZipPackagerEntry, ZipInputStream, ZipOutputStream) has been changed to be a proxy to the new API.
            
