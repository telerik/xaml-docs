---
title: Breaking Changes
page_title: Telerik UI for WPF RadButtons Breaking Changes - Hyperlink Navigation
description: Review Telerik UI for WPF RadButtons breaking changes, including RadHyperlinkButton URL validation and launch behavior.
components: ["buttons"]
slug: radbuttons-breaking-changes
tags: breaking changes, backward compatibility, buttons, RadHyperlinkButton, hyperlinks, URL validation, navigation, Telerik UI for WPF
published: True
position: 14
---

# Breaking Changes

This article lists breaking changes introduced in the RadButtons component and explains how to update your application.

## 2026 Q4

* `RadHyperlinkButton` now launches only absolute HTTP, HTTPS, and mailto URLs that pass the URL pattern and scheme checks. Other URLs are not launched by default. To allow an application-approved URL, set `IsTrustedUrl` to `true` in the `HyperlinkClicked` event handler after validating the destination. See [Handling hyperlink navigation in RadHyperlinkButton]({%slug radbuttons-features-hyperlink-button%}).
