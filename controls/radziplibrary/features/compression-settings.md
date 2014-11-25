---
title: Compression Settings
page_title: Compression Settings
description: Compression Settings
slug: radziplibrary-compression-settings
tags: compression,settings
published: True
position: 3
---

# Compression Settings



The __RadZipLibrary__ allows you compress and decompress data in your application seamlessly. There are different settings that can be used for compression and this article discusses all of them.
      

## Deflate Settings

Deflate settings are used for compressing data using a combination of the LZ77 algorithm and Huffman coding.
        

>tipYou can find more information on the Deflate data compression algorithm
            [here](http://en.wikipedia.org/wiki/DEFLATE).
          

The __DeflateSettings__ class exposes some configurable parameters:
        

* __CompressionLevel__: Property of type CompressionLevel representing the level of compression of the algorithm.
            

* __HeaderType__: Represents the compression stream header type. The possible values are None and ZLib.
            

__Example 1__ demonstrates how to create DeflateSettings.
        

#### __[C#] Example 1: Create DeflateSettings__

{{region radziplibrary-compression-settings_0}}
	            DeflateSettings compressionSettings = new DeflateSettings();
	            compressionSettings.CompressionLevel = CompressionLevel.Best;
	            compressionSettings.HeaderType = CompressedStreamHeader.ZLib;
	{{endregion}}



#### __[VB.NET] Example 1: Create DeflateSettings__

{{region radziplibrary-compression-settings_0}}
				Dim compressionSettings As New DeflateSettings()
				compressionSettings.CompressionLevel = CompressionLevel.Best
				compressionSettings.HeaderType = CompressedStreamHeader.ZLib
	{{endregion}}


## LZMA Settings

LZMA settings are used for compressing your data using Lempel-Ziv-Markov chain algorithm (LZMA).
        

>tipYou can read more about LZMA [here](http://en.wikipedia.org/wiki/Lempel%E2%80%93Ziv%E2%80%93Markov_chain_algorithm).
          

The configurable parameters of the __LzmaSettings__ class are as follows:
        

* __DictionarySize__: The size of the used dictionary. Allowed values are in the range [0 – 27] and the default value is 23 (8MB).
            

* __PositionStateBits__: The number of position state bits. Allowed values are in the range [0 – 4]; the default value is 2.
            

* __LiteralContextBits__: The number of literal context bits. Allowed values are in the range [0 – 4]; the default value is 3.
            

* __LiteralPositionBits__: The number of literal position bits. Allowed values are in the range [0 – 4]; the default value is 3.
            

* __FastBytes__: The number of fast bytes. Allowed values are in the range [5 – 273]; the default value is 32.
            

* __MatchFinderType__: The type of the match finder. Allowed values are BT2(match finder that uses two bytes for the hash) and BT4(uses four bytes for the hash).
            

#### __[C#] Example 2: Create LzmaSettings__

{{region radziplibrary-compression-settings_1}}
	            LzmaSettings compressionSettings = new LzmaSettings();
	            compressionSettings.DictionarySize = 23;
	            compressionSettings.FastBytes = 32;
	            compressionSettings.LiteralContextBits = 3;
	            compressionSettings.LiteralPositionBits = 3;
	            compressionSettings.MatchFinderType = LzmaMatchFinderType.BT4;
	            compressionSettings.PositionStateBits = 2;
	{{endregion}}



#### __[VB.NET] Example 2: Create LzmaSettings__

{{region radziplibrary-compression-settings_1}}
				Dim compressionSettings As New LzmaSettings()
				compressionSettings.DictionarySize = 23
				compressionSettings.FastBytes = 32
				compressionSettings.LiteralContextBits = 3
				compressionSettings.LiteralPositionBits = 3
				compressionSettings.MatchFinderType = LzmaMatchFinderType.BT4
				compressionSettings.PositionStateBits = 2
	{{endregion}}



## Store Settings

Store settings are used to just store the data using no compression.
        

#### __[C#] Example 3: Create StoreSettings__

{{region radziplibrary-compression-settings_2}}
	            StoreSettings compressionSettings = new StoreSettings();
	{{endregion}}



#### __[VB.NET] Example 3: Create StoreSettings__

{{region radziplibrary-compression-settings_2}}
				Dim compressionSettings As New StoreSettings()
	{{endregion}}


# See Also

 * [Compressing a Stream]({%slug radziplibrary-compress-stream%})
