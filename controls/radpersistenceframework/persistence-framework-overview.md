---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadPersistenceFramework {{ site.framework_name }} control.
slug: persistence-framework-overview
tags: overview
published: True
position: 0
CTAControlName: RadPersistenceFramework
---

# {{ site.framework_name }} PersistenceFramework Overview

__PersistenceFramework__ allows you to easily save and restore your UI. The framework persists the properties of any {{ site.framework_name }} control in a memory stream or directly into a file, so that you can retrieve their values later. This way you can easily store the layout of your application thus keeping your users' preferences.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

## Key Features

* __Easy saving mechanism__: You can save or load the layout using a single method call. Read more about this in the [Isolated Storage]({%slug persistence-framework-isolated-storage%}) article.

* __Fully customizable saving and loading__: Implement one of the property provider interfaces in order to write custom logic for saving and loading properties. Read more about this in the [CustomPropertyProviders]({%slug persistence-framework-custom-property-provider%}) article.  

* __Serialization options__: Use the PersistenceFramework attached properties to define a set of conditions that can be used to restrict the serialization. Read more about this in the [Serialization Options]({%slug persistence-framework-defining-properties%}) article.

>tip Get started with the PersistanceFramework with its [Getting Started]({%slug persistence-framework-getting-started%}) help article that shows how to use it in a basic scenario.

> Check out the online demo at {% if site.site_name == 'Silverlight' %}[demos.telerik.com](https://demos.telerik.com/silverlight/#PersistenceFramework/FirstLook){% else %}[demos.telerik.com](https://demos.telerik.com/wpf/){% endif %}

## See Also
* [Data Binding Tips]({%slug persistence-framework-data-binding-tips%})
* [Events]({%slug persistence-framework-events%})
