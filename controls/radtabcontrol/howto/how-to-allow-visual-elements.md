---
title: Configure the RadTabControl when Bound to a Collection of Visual Elements
page_title: Configure the RadTabControl when Bound to a Collection of Visual Elements
description: Configure the RadTabControl when Bound to a Collection of Visual Elements
slug: radtabcontrol-how-to-allow-visual-elements
tags: configure,the,radtabcontrol,when,bound,to,a,collection,of,visual,elements
publish: True
position: 15
---

# Configure the RadTabControl when Bound to a Collection of Visual Elements



The __RadTabControl__ is designed to allow databinding scenarios out-of-the-box. 
      However, by default the control implementation expects the __ItemsSource__ collection to be a business collection 
      where no visual elements are defined.

Basically in databinding scenarios the control allows you to choose whether you want to use one 
      __ContentPresenter__ for all __RadTabItems__ or use multiple 
      __ContentPresenters__ - one for each __RadTabItem__, in order to keep each item's state while 
      changing the selection ([read more]({%slug radtabcontrol-how-to-keep-content%})).

If you set the __RadTabControl.IsContentPreserved__ property to __True__, 
      then each __RadTabItem__ will have a __ContentTemplate__. In this case you will be able to bind
      the control to a collection of visual elements as well.

If you, on the other hand, use the default implementation of the control in which the 
      __RadTabControl.IsContentPreserved__ property is set to __False__, there will be one
      __ContentPresenter__ for all __RadTabItems__. Then when the selection is changed, the 
      __ContentPresenter.ControlTemplate__ will be reapplied over and over for each newly selected item. This will raise 
      an exception when your business objects contain visual elements since you cannot place the same visual element twice in the visual tree.
      

## SupressSelectedContentTemplateReapplying property

In order to get over this limitation, the __RadTabControl__ exposes a property that allows you to control 
        its internal logic in such scenarios - __SupressSelectedContentTemplateReapplying__. By default the
        __SupressSelectedContentTemplateReapplying__ property is set to __False__ along with the 
        __IsContentPreserved__ property. That means that the default implementation of the 
        __RadTabControl__ keeps one __ContentPresenter__ for all its Items and reapplies its
        __ContentPresenter.ContentTemplate__ on each selection change.

But if you set the __SupressSelectedContentTemplateReapplying__ property to __True__, 
        then the __RadTabControl__ will still have one __ContentPresenter__ but it won't reset its 
        __ContentTemplate__ whenever the selection is changed and this will allow you to place visual elements in the 
        __RadTabControl.ItemsSource__ collection.

>

Please keep in mind that if you set the __SupressSelectedContentTemplateReapplying__ property to 
            __True__ the same __RadTabControl.ContentTemplate__ is applied to all
            __RadTabItems.__And if the __ControlTemplate__elements aren't databound, the same values 
            will be displayed in all __RadTabItems__. 
