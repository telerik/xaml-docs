---
title: Compressing a Stream
page_title: Compressing a Stream
description: Compressing a Stream
slug: radziplibrary-compress-stream
tags: compressing,a,stream
published: True
position: 2
---

# Compressing a Stream



Telerik __RadZipLibrary__ can significantly facilitate your efforts in compress a stream, for example to send it over the internet. The library provides __CompressedStream__ class that is designed to compress and decompress streams.
      

This article covers the following topics:
      

* [API Overview](#api-overview)

* [Compressing a Stream](#compressing-a-stream)

* [Decompressing a Stream](#decompressing-a-stream)

* [CompressedStream Properties](#compressedstream-properties)

## API Overview

__CompressedStream__ class allows you to compress and decompress a stream. You need to initialize the class using one of the constructor overloads.
        

* __CompressedStream(Stream baseStream, StreamOperationMode mode, CompressionSettings settings)__

* __CompressedStream(Stream baseStream, StreamOperationMode mode,CompressionSettings settings, bool useCrc32, EncryptionSettings encryptionSettings)__

The parameters accepted by the constructors serve the following functions:
        

* __Stream baseStream__: A reference to a stream where the compressed result will be written when compressing data or the compressed stream that needs to be decompressed when decompressing data.
            

* __StreamOperationMode mode__: Specifies the operation mode of the compressed stream – __Write__ for compressing data and __Read__ for decompressing.
            

* __CompressionSettings settings__: The settings used for the compression. The compression settings can be of type DeflateSettings, LzmaSettings and StoreSettings. You can read more on the topic in the [Compression Settings]({%slug radziplibrary-compression-settings%}) article.
            

* __bool useCrc32__: Indicates whether to use CRC32 (true) or Adler32 (false) checksum algorithm.
            

* __EncryptionSettings encryptionSettings__: Specifies the encryptions settings that will be used. If __null__ value is passed, encryption is not performed. More information on the topic is available in the [Protect ZipArchive]({%slug radziplibrary-protect-ziparchive%}) article.
            

## Compressing a Stream

You can create a compressed stream by initializing new instance of the __CompressedStream__ class and passing as a parameter the stream in which the compressed data will be written. You need to specify the operation mode to __Wrtie__ and the compression settings that should be used.
        

#### __[C#] Example 1: Write to Compressed Stream__

{{region radziplibrary-compress-stream_0}}
	            using (CompressedStream compressedStream = new CompressedStream(outputStream, StreamOperationMode.Write, new DeflateSettings()))
	            {
	                // write to compressed stream
	            }
	{{endregion}}



#### __[VB.NET] Example 1: Write to Compressed Stream__

{{region radziplibrary-compress-stream_0}}
				Using compressedStream As New CompressedStream(outputStream, StreamOperationMode.Write, New DeflateSettings())
					' write to compressed stream
				End Using
	{{endregion}}



If you want to compress a specific stream (*inputStream*), you need to copy it to the compressed stream that you've created.
        

#### __[C#] Example 2: Write Stream to Compressed Stream__

{{region radziplibrary-compress-stream_1}}
	            using (CompressedStream compressedStream = new CompressedStream(outputStream, StreamOperationMode.Write, new DeflateSettings()))
	            {
	                inputStream.CopyTo(compressedStream);
	                compressedStream.Flush();
	            }
	{{endregion}}



#### __[VB.NET] Example 2: Write Stream to Compressed Stream__

{{region radziplibrary-compress-stream_1}}
				Using compressedStream As New CompressedStream(outputStream, StreamOperationMode.Write, New DeflateSettings())
					inputStream.CopyTo(compressedStream)
					compressedStream.Flush()
				End Using
		{{endregion}}



## Decompressing a Stream

Decompressing a stream is just as simple as compressing it. All you need to do is to create new instance of __CompressedStream__ class and pass it the stream from which the compressed data will be extracted, operation mode __Read__, and the compression settings that need to be used.
        

#### __[C#] Example 3: Decompressed Stream__

{{region radziplibrary-compress-stream_2}}
	            using (CompressedStream compressedStream = new CompressedStream(inputStream, StreamOperationMode.Read, new DeflateSettings()))
	            {
	                compressedStream.CopyTo(outputStream);
	            }
	{{endregion}}



#### __[VB.NET] Example 3: Decompressed Stream__

{{region radziplibrary-compress-stream_2}}
				Using compressedStream As New CompressedStream(inputStream, StreamOperationMode.Read, New DeflateSettings())
					compressedStream.CopyTo(outputStream)
				End Using
	{{endregion}}



## CompressedStream Properties

The CompressedStream class derives from the Stream class and therefore it supports all its properties. However, it also exposes a set of properties that provide further information about the compressed stream.
        

* __BaseStream__: Property is of type
              [Stream](http://msdn.microsoft.com/en-us/library/system.io.stream(v=vs.110).aspx)
              which obtains the stream that is compressed.
            

* __Checksum__: Numeric value representing the checksum of the compressed stream.
            

* __CompressedSize__: The size of the compressed stream.
            

* __Length__: The uncompressed size of the stream.
            

# See Also

 * [Protect ZipArchive]({%slug radziplibrary-protect-ziparchive%})

 * [Compression Settings]({%slug radziplibrary-compression-settings%})
