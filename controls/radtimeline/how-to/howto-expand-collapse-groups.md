---
title: Expand and Collapse Timeline groups
page_title: Expand and Collapse Timeline groups
description: Check our &quot;Expand and Collapse Timeline groups&quot; documentation article for the RadTimeline {{ site.framework_name }} control.
slug: radtimeline-howto-expand-collapse-groups
tags: expand,and,collapse,timeline,groups
published: True
position: 0
---

# Expand and Collapse Timeline groups

This help topic will provide an overview of the methods for collapsing and expanding Timeline groups.

## Expand All Groups at Start

You can expand all groups of items in the RadTimeline control, using an implicit Style Setter. For example:



<snippet id='radtimeline-how-to-howto-expand-collapse-groups-block_1-xaml' />

## Expand A Group at Start

In case you want to expand a specific group initially, you can use a Converter. For example:        



<snippet id='radtimeline-how-to-howto-expand-collapse-groups-block_2-xaml' />



<snippet id='radtimeline-how-to-howto-expand-collapse-groups-block_3-cs' />
<snippet id='radtimeline-how-to-howto-expand-collapse-groups-block_4-vb' />

## Expand And Collapse Groups through binding (attached property)

There are scenarios, in which the expanded and collapsed state of the groups of timeline items depends on a certain condition In this case, you can use an attached behavior.



<snippet id='radtimeline-how-to-howto-expand-collapse-groups-block_5-xaml' />



<snippet id='radtimeline-how-to-howto-expand-collapse-groups-block_6-cs' />
<snippet id='radtimeline-how-to-howto-expand-collapse-groups-block_7-vb' />