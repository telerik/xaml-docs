---
title: Backward Compatibility
page_title: Backward Compatibility
description: Backward Compatibility
slug: radziplibrary-backward-compatibility
tags: backward,compatibility
published: True
position: 1
---

# Backward Compatibility



This article lists the breaking changes and how they can be fixed when upgrading from a specific version of the controls to the next one.

## What's Different in 2015 Q1 - 2015.1.0225


### Changed

The __Telerik.Windows.Zip.ZipPackage__ class is obsolete.


### What to do now

Use the [__Telerik.Windows.Zip.ZipArchive__]({%slug radziplibrary-gettingstarted%}) class instead.            


### Changed

The __Telerik.Windows.Zip.ZipPackageEntry__ class is obsolete.


### What to do now

Use the [__Telerik.Windows.Zip.ZipArchiveEntry__]({%slug radziplibrary-gettingstarted%}) class instead.


### Changed

The __Telerik.Windows.Zip.ZipOutputSrteam__ and __Telerik.Windows.Zip.ZipInputSrteam__ classes are obsolete.


### What to do now

Use the [__Telerik.Windows.Zip.CompressedStream__]({%slug radziplibrary-compress-stream%}) class instead.


## What's Different in 2014 Q1 - 2014.1.0226

### Changed

The __Telerik.Windows.Zip.LZMA.LzmaEncoder__ class is removed as it is intended for internal use only.
            

### Changed

The __Telerik.Windows.Zip.ZipInputStream(System.IO.Stream, System.Boolean)__ constructor is removed.
            

### What to do now

Use the __Telerik.Windows.Zip.ZipInputStream(System.IO.Stream)__ constructor instead.
            

### Changed

The __System.Void Telerik.Windows.Zip.ZipPackage::Add(System.String[])__ method is removed.
            

### What to do now

You can use the __System.Void Telerik.Windows.Zip.ZipPackage::Add(System.Collections.Generic.IEnumerable<string>)__   method instead.
            

### Changed

The __System.Void Telerik.Windows.Zip.ZipPackage::Add(System.String[])__ method is removed.
            

### What to do now

You can use the __System.Void Telerik.Windows.Zip.ZipPackage::Add(System.Collections.Generic.IEnumerable<string>)__  method instead.
            

### Changed

The __System.Void Telerik.Windows.Zip.ZipPackage::AddStream(System.String, System.IO.Stream)__ method is removed.
            

### What to do now

You can use the __System.Void Telerik.Windows.Zip.ZipPackage::AddStream(System.IO.Stream, System.String)__ method instead.
            

### Changed

The __System.Void Telerik.Windows.Zip.ZipPackage::AddStream(Telerik.Windows.Zip.ZipCompression, System.String, System.IO.Stream, System.DateTime)__ method is removed.
            

### What to do now

You can use the __System.Void Telerik.Windows.Zip.ZipPackage::AddStream(System.IO.Stream, System.String, Telerik.Windows.Zip.ZipCompression, System.DateTime)__ method instead.
            

### Changed

The __Telerik.Windows.Zip.ZipPackage Telerik.Windows.Zip.ZipPackage::Open(System.IO.Stream, System.IO.FileAccess)__ method is removed.
            

### What to do now

You can use the __Telerik.Windows.Zip.ZipPackage Telerik.Windows.Zip.ZipPackage::Open(System.IO.Stream)__ method instead.
            
