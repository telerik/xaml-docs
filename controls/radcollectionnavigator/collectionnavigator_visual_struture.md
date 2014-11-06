---
title: Visual Structure
page_title: Visual Structure
description: Visual Structure
slug: collectionnavigator_visual_struture
tags: visual,structure
published: True
position: 3
---

# Visual Structure


__RadCollectionNavigator__ displays two sets of buttons, separated into two groups according to the purpose of their commands: Navigation and Editing.
        

The  __navigation buttons__ come as it follows:
        

* Move to first item
          

* Move to previous item
          

* Move to next item
          

* Move to last item
          

And the __editing buttons__:
        

* Add new item
          

* Edit current item
          

* Delete item
          



![collectionnavigator 01](images/collectionnavigator_01.png)

The Visibility for the buttons is controlled by the FlaggedEnum CommandButtonsVisibility property, which is by default set to:

__CommandButtonsVisibility.Add | CommandButtonsVisibility.Delete | CommandButtonsVisibility.Navigation__



The “Edit” button is initially hidden, as RadCollectionNavigator does not provide interface for editing.
        

>RadCollectionNavigator is independent from any DataVisualization controls that are used in combination with it. However, this button can be used in custom solutions if such editing UI is provided.
          
