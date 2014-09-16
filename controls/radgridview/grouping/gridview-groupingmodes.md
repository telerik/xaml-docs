---
title: Grouping Modes
page_title: Grouping Modes
description: Grouping Modes
slug: gridview-grouping-groupingmodes
tags: grouping,modes
publish: True
position: 1
---

# Grouping Modes



As of __Q3 2012__ we have introduced a new property of the RadGridView - __GroupRenderMode__. It has two options:
      

__Nested Mode__: It is the default one and it will nest __GridViewGroupRows__ into one another when you have grouping on many levels. This may lead to a poor performance when the grid is grouped on several levels and has a lot of data. The visual element representing the grouped row is __GridViewGroupRow__.
      

__Flat Mode__: This mode represents our new virtualization mechanism with a completely new item container generator. It simply renders rows one below the other.  This leads to a very good perfromance when the grid is grouped on several levels and has a lot of data. The visual element representing the grouped row is __GroupHeaderRow__.
      



>tipFor compatibility reasons, the old render mode is also preserved, but it is recomended to use the new one.
        

>Please note that when you use the __Flat Mode__, you should work with __GroupHeaderRow__, not __GridViewGroupRow__.
        
