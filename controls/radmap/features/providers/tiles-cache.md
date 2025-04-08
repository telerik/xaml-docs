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

#### __[XAML] Example 1: Setting FileSystemCache and changing the default path__
{{region xaml-radmap-features-providers-tiles-cache-0}}
	<telerik:RadMap>
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider IsTileCachingEnabled="True">
				<telerik:OpenStreetMapProvider.CacheStorage>
					<telerik:FileSystemCache CachePath="C:\temp\OSMCache" />
				</telerik:OpenStreetMapProvider.CacheStorage>
			</telerik:OpenStreetMapProvider>
		</telerik:RadMap.Provider>
	</telerik:RadMap>	
{{endregion}}

 `FileSystemCache` is the default storage object that is automatically created when the `CacheStorage` property of the provider is not assigned. When the file system cache is atuomatically created its `CachePath` is assigned to the ApplicationData folder on the OS: `C:\Users\<username>\AppData\Local\TelerikMapCache\<providername>`.

## MemoryCache

`MemoryCache` saves each tile in a byte array stored in memory.

#### __[XAML] Example 2: Replacing the default FileSystemCache with MemoryCache__
{{region xaml-radmap-features-providers-tiles-cache-1}}
	<telerik:RadMap>
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider IsTileCachingEnabled="True">
				<telerik:OpenStreetMapProvider.CacheStorage>
					<telerik:MemoryCache />
				</telerik:OpenStreetMapProvider.CacheStorage>
			</telerik:OpenStreetMapProvider>
		</telerik:RadMap.Provider>
	</telerik:RadMap>	
{{endregion}}

## IsolatedStorageCache

`IsolatedStorageCache` saves the requested tiles into the [isolated storage](https://docs.microsoft.com/en-us/dotnet/standard/io/isolated-storage).

#### __[XAML] Example 3: Replacing the default FileSystemCache with IsolatedStorageCache__
{{region xaml-radmap-features-providers-tiles-cache-2}}
	<telerik:RadMap>
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider IsTileCachingEnabled="True">
				<telerik:OpenStreetMapProvider.CacheStorage>
					<telerik:IsolatedStorageCache />
				</telerik:OpenStreetMapProvider.CacheStorage>
			</telerik:OpenStreetMapProvider>
		</telerik:RadMap.Provider>
	</telerik:RadMap>	
{{endregion}}

## Custom Cache Storage

Besides the built-in cache storages, a custom storage can be created by implementing the `ICacheStorage` interface. This allows to introduce a saving mechanism different then the originally provided ones. The interface requests to implement `Load`, `LoadAsync` and `Save` methods.

#### __[C#] Example 4: Creating custom cache storage__
{{region cs-radmap-features-providers-tiles-cache-3}}
	public class CustomCacheStorage : ICacheStorage
    {
        public Stream Load(string fileName)
        {
            // Load the tile using the 'fileName' as an unique identifier to retrieve the corresponding tile.
        }

        public void LoadAsync(string fileName, Action<byte[]> callback)
        {
            // Load the tile (a byte array) using the 'fileName' as an unique identifier to retrieve the corresponding tile.
            // Pass it to the callback that will be called to return a tile if it is available.

            // callback(tile);
        }

        public void Save(string fileName, DateTime expirationDate, byte[] tile)
        {
            // Save the tile using:
            // the 'fileName' as an unique identifier, 
            // the 'expirationDate' as the date until when the tile will be cached and
            // the 'tile' as the body of the tile image
        }
    }
{{endregion}}

#### __[XAML] Example 5: Using the custom cache storage__
{{region xaml-radmap-features-providers-tiles-cache-4}}
	<telerik:RadMap>
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider IsTileCachingEnabled="True">
				<telerik:OpenStreetMapProvider.CacheStorage>
					<local:CustomCacheStorage />
				</telerik:OpenStreetMapProvider.CacheStorage>
			</telerik:OpenStreetMapProvider>
		</telerik:RadMap.Provider>
	</telerik:RadMap>	
{{endregion}}

## Request Cache Level

The `RadMap` control uses the [built-in .NET caching mechanism](https://docs.microsoft.com/en-us/dotnet/api/system.net.cache.requestcachelevel?view=netcore-3.1) for downloading map tiles. The tiled providers expose a `RequestCacheLevel` property which is used to control the current caching level. The default level is `System.Net.Cache.RequestCacheLevel.CacheIfAvailable`. 

#### __[XAML] Example 6: Setting the RequestCacheLevel__
{{region xaml-radmap-features-providers-tiles-cache-5}}
	<telerik:RadMap>
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider RequestCacheLevel="Revalidate" />
		</telerik:RadMap.Provider>
	</telerik:RadMap>	
{{endregion}}

## See Also
 * [Empty provider]({%slug radmap-features-empty-provider%})
 * [BingRestMapProvider]({%slug radmap-features-providers-bing-rest-map%}) 
 * [UriImageProvider]({%slug radmap-features-uriimageprovider%})
