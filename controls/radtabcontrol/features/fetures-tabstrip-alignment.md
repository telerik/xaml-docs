---
title: Tabstrip Alignment
page_title: Tabstrip Alignment
description: Check our &quot;Tabstrip alignment&quot; documentation article for the RadTabControl {{ site.framework_name }} control.
slug: radtabcontrol-fetures-tabstrip-alignment
tags: tabstrip,alignment
published: True
position: 7
---

# Tabstrip Alignment

The RadTabControl exposes an __Align__ property of type __TabStripAlign__ enumeration. It controls the alignment of the control's tabstrip. You can choose between the following options:		

* `Left` (default)

![radtabcontrol-align-left](images/radtabcontrol-align-left.png)

* `Right`

![radtabcontrol-align-right](images/radtabcontrol-align-right.png)

* `Center`

![radtabcontrol-align-center](images/radtabcontrol-align-center.png)

* `Justify`&mdash;This mode scales all RadTabItems so that all the available space is filled.  

![radtabcontrol-align-justify](images/radtabcontrol-align-justify.png)

If there is not enough space available, the RadTabItems arrangement defaults to e behavior similar to the `Justify` alignment. Hence, parts of the items can be clipped. In such cases you can consider using [multi-line tabs]({%slug radtabcontrol-features-multiline-tabs%}).		  

## See Also 
 * [Visual Structure]({%slug radtabcontrol-visual-structure%})
