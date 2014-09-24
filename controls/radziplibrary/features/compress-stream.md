---
title: Compressing a Stream
page_title: Compressing a Stream
description: Compressing a Stream
slug: radziplibrary-compress-stream
tags: compressing,a,stream
published: True
position: 0
---

# Compressing a Stream



Have you ever wondered how to compress a stream that you need to send over the internet? Telerik __Zip Library__ can significantly facilitate your efforts in implementing such scenarios.

Telerik __Zip Library__ provides two classes that are designed to compress and decompress streams - __ZipOutputStream__ and __ZipInputStream__.

## Compressing a Stream

The __ZipOutputStream__ class allows you to compress a stream.

You can create a compressed stream by initializing a new instance of the __ZipOutputStream__ class and passing the uncompressed stream as a parameter.

#### __C#__

{{region radziplibrary-compress-stream_0}}
	ZipOutputStream zipOutputStream = new ZipOutputStream(memoryStream);
	{{endregion}}



#### __VB.NET__

{{region radziplibrary-compress-stream_1}}
	Dim zipOutputStream As New ZipOutputStream(memoryStream)
	{{endregion}}



While initializing an instance of the __ZipOutputStream__ class, you can also pass as a parameter a __ZipCompression__ method. 

#### __C#__

{{region radziplibrary-compress-stream_2}}
	ZipOutputStream zipOutputStream = new ZipOutputStream(memoryStream, ZipCompression.Deflate64);
	{{endregion}}



#### __VB.NET__

{{region radziplibrary-compress-stream_3}}
	Dim zipOutputStream As New ZipOutputStream(memoryStream, ZipCompression.Deflate64)
	{{endregion}}



The __ZipCompression__ method defines the level of compression to be used during the initialization of the compressed stream. 

##  ZipOutputStream properties

The __ZipOutputStream__ class derives from the __Stream__ class and therefore it supports all __Stream__ class properties. However, it also exposes a set of properties that provide further information about the compressed stream:

* __BaseStream__ - gets the stream that is compressed. This property is of type __Stream__.

* __Checksum__- gets the checksum of the compressed stream. This property is of type __int__.

* __CompressedSize__- gets the compressed size of the stream. This property is of type __int__.

* __UncompressedSize__- gets the uncompressed size of the stream. This property is of type __int__.

## ZipOutputStream methods

Since the __ZipOutputStream__ class derives from the __Stream__ class its support all __Stream__ class methods. It also exposes a __Cancel()__ method that can be used to stop the compression.

## Decompressing a Stream

The __ZipInputStream__ class allows you to decompress a stream. In order to decompress a __Stream__ object, you can create a new instance of the __ZipInputStream__ class passing the compressed stream as a parameter.

#### __C#__

{{region radziplibrary-compress-stream_4}}
	ZipInputStream inputStream = new ZipInputStream(compressedStream);
	{{endregion}}



#### __VB.NET__

{{region radziplibrary-compress-stream_5}}
	Dim inputStream As New ZipInputStream(compressedStream)
	{{endregion}}



## ZipInputStream properties

The __ZipInputStream__ class derives from the __Stream__ class and therefore it supports all __Stream__ class properties. However, it also exposes a set of properties that provide further information about the decompressed stream:

* __BaseStream__ - gets the stream that is decompressed. This property is of type __Stream__.

* __CompressedSize__- gets the compressed size of the stream. This property is of type __int__.

* __UncompressedSize__- gets the uncompressed size of the stream. This property is of type __int__.
