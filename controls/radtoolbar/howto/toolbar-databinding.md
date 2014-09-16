---
title: How To Databind RadToolBar 
page_title: How To Databind RadToolBar 
description: How To Databind RadToolBar 
slug: toolbar-databinding
tags: how,to,databind,radtoolbar,
publish: True
position: 2
---

# How To Databind RadToolBar 



## 

The __RadToolBar__is an __ItemsControl__and can be databound to any 
        __IEnumerable.__However, it is best to bind it to a collection that implements the 
        __INotifyCollectionChanged__interface, like an __ObservableCollection__. 

Also, it is important to note that the __RadToolBar__control may contain variety of other controls.
        Therefore in databinding scenarios a __DataTemplateSelector__class must be used to determine how to 
        display these controls.

Fore more information, please follow [this link](http://blogs.telerik.com/silverlightteam/posts/10-09-28/how-to-databind-telerik-s-toolbar.aspx).
