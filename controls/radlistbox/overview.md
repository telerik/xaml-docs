---
title: Overview
page_title: Overview
description: Explore WPF RadListBox selection, autocomplete, keyboard support, drag-and-drop configuration, themes, and links to setup and data binding.
components: ["listbox"]
slug: radlistbox-overview
tags: overview
published: True
position: 0
CTAControlName: RadListBox
---

# {{ site.framework_name }} ListBox Overview

`RadListBox`, part of Progress® Telerik® UI for WPF, displays a list of items from which users can choose.

The control supports multiple selection, autocomplete, keyboard shortcuts, drag and drop, and customization. To set up the control, follow the [RadListBox Getting Started guide]({%slug radlistbox-getting-started%}).

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

>caption `RadListBox` displaying a list of Telerik controls

![List of Telerik controls with RadWindow selected](images/RadListBox_Overview_02_WPF.png)

## Key Features:

`RadListBox` provides the following features:

* Selection&mdash;`RadListBox` provides three selection modes: `Single`, `Multiple`, and `Extended`. See the [Selection]({%slug radlistbox-features-selection%}) article.

* Autocomplete&mdash;When the control has focus, it selects the first matching item as you type. See the [Autocomplete]({%slug radlistbox-features-autocomplete%}) article.

* Drag and Drop&mdash;Configure drag-and-drop support to reorder items or move them between `RadListBox` controls. Statically declared items support reordering, but not transfer between controls. See the [Drag and Drop]({%slug radlistbox-features-dragdrop%}) article for configuration and limitations.

* Keyboard Support&mdash;`RadListBox` supports keyboard shortcuts for common tasks. See the [Keyboard Support]({%slug radlistbox-features-keyboard-support%}) article.

* Theming&mdash;`RadListBox` supports different themes. See the [Styling and Appearance]({%slug styling-apperance-implicit-styles-overview%}) section.

>caution If you use [NoXaml binaries]({%slug implicit-styles-styling-the-controls%}) with a custom `Style` targeting `RadListBoxItem`, base it on the control's default style. Example 1 demonstrates this approach.

**Example 1: Implicit Style with `BasedOn` property set**
<snippet id='radlistbox-overview-block_1-cs' />

>tip Follow the [RadListBox Getting Started guide]({%slug radlistbox-getting-started%}) for a basic usage scenario.

Explore the [Telerik UI for WPF demos](https://demos.telerik.com/wpf/).

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Support and Learning Resources

Use these resources for product information, support, and training:

* [Telerik UI for WPF ListBox Homepage](https://www.telerik.com/products/wpf/listbox.aspx)
* [Telerik UI for WPF API Reference](https://docs.telerik.com/devtools/wpf/api/)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf)
* [Telerik UI for WPF ListBox Forums](https://www.telerik.com/forums/wpf)
* [Telerik UI for WPF Knowledge Base](https://docs.telerik.com/devtools/wpf/knowledge-base)
{% endif %}

## See Also

* [RadListBox Data Binding]({%slug radlistbox-populating-with-data-binding-support-overview%})
* [RadListBox Events]({%slug radlistbox-events%})