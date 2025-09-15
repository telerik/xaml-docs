---
title: Programmatic Paging
page_title: Programmatic Paging
description: Check our &quot;Programmatic Paging&quot; documentation article for the RadDataServiceDataSource {{ site.framework_name }} control.
slug: raddataservicedatasource-paging-programmatic-paging
tags: programmatic,paging
published: True
position: 1
---

# Programmatic Paging

Programmatic paging could be done with the help of the public paging API that __RadDataServiceDataSource.DataView__ provides. The __DataView__ property implements the __IPagedCollectionView__ interface which contains all paging methods and properties.

__Example 1: The IPagedCollectionView interface__

```C#
    public interface IPagedCollectionView
    {
        bool CanChangePage { get; }
        bool IsPageChanging { get; }
        int ItemCount { get; }
        int PageIndex { get; }
        int PageSize { get; set; }
        int TotalItemCount { get; }

        event EventHandler<EventArgs> PageChanged;
        event EventHandler<PageChangingEventArgs> PageChanging;

        bool MoveToFirstPage();
        bool MoveToLastPage();
        bool MoveToNextPage();
        bool MoveToPage(int pageIndex);
        bool MoveToPreviousPage();
    }
```
```VB.NET
	Public Interface IPagedCollectionView
		ReadOnly Property CanChangePage() As Boolean
		ReadOnly Property IsPageChanging() As Boolean
		ReadOnly Property ItemCount() As Integer
		ReadOnly Property PageIndex() As Integer
		Property PageSize() As Integer
		ReadOnly Property TotalItemCount() As Integer

		Event PageChanged As EventHandler(Of EventArgs)
		Event PageChanging As EventHandler(Of PageChangingEventArgs)

		Function MoveToFirstPage() As Boolean
		Function MoveToLastPage() As Boolean
		Function MoveToNextPage() As Boolean
		Function MoveToPage(ByVal pageIndex As Integer) As Boolean
		Function MoveToPreviousPage() As Boolean
	End Interface
```

__Example 2__ shows how to use the **DataView** in order to set the last page as the current page.

__Example 2: Moving to the last page__

```C#
    private void MoveToLastPage(RadDataServiceDataSource dataSource)
    {
        dataSource.DataView.MoveToLastPage();
    }
```
```VB.NET
	Private Sub MoveToLastPage(ByVal dataSource As RadDataServiceDataSource)
		dataSource.DataView.MoveToLastPage()
	End Sub
```

When a page change is requested, a trip to the server will be made regardless of the __AutoLoad__ setting. When filtering, sorting or grouping occurs, a trip to the server is made, the __DataView__ is re-created and always returns to the first page.  

## See Also

* [Creating the Data-bound Controls]({%slug raddataservicedatasource-getting-started-creating-the-data-bound-controls%})
* [Manual vs. Auto Loading]({%slug raddataservicedatasource-loading-manual-auto-loading%})