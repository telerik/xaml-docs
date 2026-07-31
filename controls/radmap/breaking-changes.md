---
title: Breaking Changes
page_title: Breaking Changes
description: This article lists the breaking changes introduced in the RadMap for WPF component through the releases.
slug: radmap-breaking-changes
tags: breaking, changes, backward, compatibility
published: True
position: 9
---

# Breaking Changes

This article lists and describes the breaking changes introduced in the RadMap component. For a full list of changes, see the [Release History](https://www.telerik.com/support/whats-new/wpf/release-history) pages of the Telerik UI for WPF product.

## 2026 Q2

* The `BingRestMapProvider` class and its related supporting API (elevation, routing, search location, truck routing and the other Bing REST helper types used by it) have been removed. The Bing Maps REST Services are deprecated, so the provider could no longer be supported. Use the [AzureMapProvider]({%slug radmap-features-providers-azuremapprovider%}) instead.
