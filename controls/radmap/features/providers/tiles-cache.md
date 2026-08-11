---
title: Tiles Cache
page_title: Tiles Cache
description: RadMap allows you to cache the tile images downloaded by the map provider.
slug: radmap-features-providers-tiles-cache
tags: providers,overview,cache,caching
published: True
position: 7
---

# Tiles Cache

RadMap allows you to cache the tile images downloaded by the map provider.

The tiles caching is disabled by default. To enable it, set the `IsTileCachingEnabled` property of the map provider to `true`. The default cache storage is the file system and the original location should look something like this: `C:\Users\<username>\AppData\Local\TelerikMapCache\OpenStreetMapProvider`

RadMap providers use the `FileSystemCache` class to enable the tiles caching. Additionally, there are two more built-in caching implementations - `MemoryCache` and `IsolatedStorageCache` - which can be set via the `CacheStorage` property of the provider.

## FileSystemCache

`FileSystemCache` saves the requested tiles to the file system. This type of cache allows you to define few settings like max size of the storage, an expiration date-time for the tiles and also the file system directory where the tiles are saved.

__Example 1: Setting FileSystemCache and changing the default path__
<snippet id='radmap-features-providers-tiles-cache-block_1-xaml' />

 `FileSystemCache` is the default storage object that is automatically created when the `CacheStorage` property of the provider is not assigned. When the file system cache is atuomatically created its `CachePath` is assigned to the ApplicationData folder on the OS: `C:\Users\<username>\AppData\Local\TelerikMapCache\<providername>`.

## MemoryCache

`MemoryCache` saves each tile in a byte array stored in memory.

__Example 2: Replacing the default FileSystemCache with MemoryCache__
<snippet id='radmap-features-providers-tiles-cache-block_2-xaml' />

## IsolatedStorageCache

`IsolatedStorageCache` saves the requested tiles into the [isolated storage](https://docs.microsoft.com/en-us/dotnet/standard/io/isolated-storage).

__Example 3: Replacing the default FileSystemCache with IsolatedStorageCache__
<snippet id='radmap-features-providers-tiles-cache-block_3-xaml' />

## Custom Cache Storage

Besides the built-in cache storages, a custom storage can be created by implementing the `ICacheStorage` interface. This allows to introduce a saving mechanism different then the originally provided ones. The interface requests to implement `Load`, `LoadAsync` and `Save` methods.

__Example 4: Creating custom cache storage__
<snippet id='radmap-features-providers-tiles-cache-block_4-cs' />

__Example 5: Using the custom cache storage__
<snippet id='radmap-features-providers-tiles-cache-block_5-xaml' />

## Request Cache Level

The `RadMap` control uses the [built-in .NET caching mechanism](https://docs.microsoft.com/en-us/dotnet/api/system.net.cache.requestcachelevel?view=netcore-3.1) for downloading map tiles. The tiled providers expose a `RequestCacheLevel` property which is used to control the current caching level. The default level is `System.Net.Cache.RequestCacheLevel.CacheIfAvailable`. 

__Example 6: Setting the RequestCacheLevel__
<snippet id='radmap-features-providers-tiles-cache-block_6-xaml' />

## See Also
 * [Providers Overview]({%slug radmap-features-providers%})
 * [Empty provider]({%slug radmap-features-empty-provider%})
 * [UriImageProvider]({%slug radmap-features-uriimageprovider%})