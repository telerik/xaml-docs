---
title: Corrupted Extended Selection
page_title: Corrupted Extended Selection
description: Corrupted Extended Selection
slug: gridview-troubleshooting-corrupted_extended-selection
tags: corrupted,extended,selection
published: True
position: 20
---

# Corrupted Extended Selection



## 

__PROBLEM__

When you have set SelectionMode="Extended", then selection is corrupted if RadGridView looses focus during extended selection.
          

__CAUSE__

That is how RadGridView handles the Drag selection. It keeps selecting until the Mouse Button is released. Unfortunately there is no way to know if the Mouse button has been released over the displayed Popup. 
          

__SOLUTION__

Solution 1: Set RadGridView's property __DragElementAction to None__.
          

Solution 2: You can disable the user selection right after you have entered the event handler. After your logic is executed you have to re-enable the user selection. This can be controlled through setting __RadGridView.CanUserSelect__ property.
          

# See Also
