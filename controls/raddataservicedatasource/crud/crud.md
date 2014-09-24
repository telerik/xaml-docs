---
title: CRUD
page_title: CRUD
description: CRUD
slug: raddataservicedatasource-crud
tags: crud
published: True
position: 0
---

# CRUD



## 

There is nothing special that needs to be done for CRUD operations. You can simply add, edit or remove entities contained in the DataView of RadDataServiceDataSource. You can do that either programmatically or leave the job to RadGridView by binding its ItemsSource to the DataView. In order to submit the changes you need to call the __SubmitChanges__ method of the control. In order to reject the changes and reload the original data from the server you need to call the __RejectChanges__ method of the control. 
