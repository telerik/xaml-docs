---
title: Open Street Maps Provider
page_title: Open Street Maps Provider
description: This article describes the support Open Street Maps services support in RadMap.
slug: radmap-features-providers-osm-provider
tags: providers,osm, openstreetmapprovider
published: True
position: 20
---

# Open Street Maps Provider

`RadMap` supports displaying tile data from the [Open Street Map](https://www.openstreetmap.org/) services via the `OpenStreetMapProvider` class. You have the option of passing an API key to it. This key is needed for the Transport and Cycle maps, which come from [ThunderForest](https://www.thunderforest.com/). You can check the [following page](https://www.thunderforest.com/docs/apikeys/) in order to learn how to obtain an API key.

__OpenStreetMapProvider with API key in Xaml__
<snippet id='radmap-features-providers-osm-provider-block_1-xaml' />

__OpenStreetMapProvider set in code__
<snippet id='radmap-features-providers-osm-provider-block_2-cs' />
<snippet id='radmap-features-providers-osm-provider-block_3-vb' />

## Attribution Copyright Label

When using the OpenStreetMapProvider, you have to display an attribution copyright label to the Open Street Map services. To learn more about the accurate copyright label's content, please refer to the [OpenStreetMap Attribution Guideline](https://osmfoundation.org/wiki/Licence/Attribution_Guidelines) article.

>tip To learn how to customize the RadMap to allocate space for displaying an element containing a sample attribution copyright label, check this [article]({%slug kb-map-copyright-label%}).

## Setting a User-Agent

The OpenStreetMapProvider class provides the option of passing a User-Agent header, which will be used in the web request for downloading the tiles from the Standard tile layer. This allows for compliance with the [OpenStreetMaps Tile Usage Policy](https://operations.osmfoundation.org/policies/tiles/). 

>important If a User-Agent is not provided, the Standard layer tiles will not be downloaded.

The following two examples demonstrate how you can pass such a User-Agent.

__Setting StandardModeUserAgent in Xaml__
<snippet id='radmap-features-providers-osm-provider-block_4-xaml' />

__Setting StandardModeUserAgent in code__
<snippet id='radmap-features-providers-osm-provider-block_5-cs' />
<snippet id='radmap-features-providers-osm-provider-block_6-vb' />