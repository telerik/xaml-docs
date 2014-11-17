---
title: Load Delay
page_title: Load Delay
description: Load Delay
slug: raddataservicedatasource-loading-load-delay
tags: load,delay
published: True
position: 3
---

# Load Delay



## 

When you anticipate that many rapid changes that will trigger an __AutoLoad__ may occur, you can use the __LoadDelay__ property of the control. 

Imagine that the user is typing a word in a search text-box and that this search text-box is connected with a __FilterDescriptor.Value__ on the __RadDataServiceDataSource__ control. Normally, each letter typed would send an asynchronous request to the server, but that is not very effective. A more effective approach would be to let the user type the search criteria and when he is done simply send on request to the server. 

The __LoadDelay__ property represents a time-span. The control will ___“wait”___ one __LoadDelay__ amount of time before it sends an __AutoLoad__ request to the server. Multiple changes that occur within the specified time span are aggregated into a single __Load__ operation. For every change that occurs, the delay timer is reset. This allows many changes to be combined into a single call as long as each change occurs within the specified delay from the last. Once the delay timer is allowed to elapse without a change occurring, Load will be invoked. This for example could be our user typing his last letter in the search criteria text-box and then doing nothing for a little while. 
