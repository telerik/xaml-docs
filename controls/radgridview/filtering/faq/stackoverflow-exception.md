---
title: StackOverflowException on selecting all distinct values
page_title: StackOverflowException on selecting all distinct values
description: StackOverflowException on selecting all distinct values
slug: gridview-filtering-faq-stackoverflow-exception
tags: stackoverflowexception,on,selecting,all,distinct,values
published: True
position: 4
---

# StackOverflowException on selecting all distinct values


The __StackOverflowException__ is thrown by the .NET Framework. When you "Select All" a LINQ query is built in order to filters. The LINQ query looks something like this:

var result = sourceCollection.Where(myObject => myObject.ID == 0 || myObject.ID == 1 || ... || myObject.ID = n);

where n is the number of distinct values shown in the filter dialog. When there are more than n distinct values this expression becomes so enourmous that the .NET Framework cannot handle it and it throws exception. The only way to work around this limitation of the .NET Platform would be to limit your distinct values to n or less like explained in this [help article]({%slug gridview-filtering-howto-display-all-distinct-values%})

You should either decrease the number of distinct values shown or turn them off altogether by setting ShowDistinctFilters of the column to false.

