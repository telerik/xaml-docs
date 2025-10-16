---
title: Validation Error Indicator Remains
page_title: Validation Error Indicator Remains
description: Learn how to troubleshoot when you correct a value but the error indicator is still being displayed by RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-troubleshooting-validation-stays
tags: validation,errors,not,cleared,indicator,remains
published: True
position: 19
---

# Validation Error Indicator Remains

__PROBLEM__

You apply a row-level validation setting a custom **ValidationResult** when invoking the [RowValidating]({%slug gridview-managing-data-validation%}#validating-data-on-a-row-level) event. Then you correct the value, but the error indicator is still displayed.
      
__CAUSE__

The problem comes from the fact that you are introducing some user errors when validating RadGridView through the RowValidating event.
        
__SOLUTION__

With __Q3 2013__ official release we have introduced a new property for __GridViewRowEditEndedEventArgs__ - __UserDefinedErrors__. It contains all user errors for the row being edited. By handling the **RowEditEnded** event you can clear these errors and restore the valid state of the row.
     
**Example 1** shows how the property can be used.
    
__Example 1: Clearing user-defined errors__

```C#
	private void rgvTest_RowEditEnded(object sender, GridViewRowEditEndedEventArgs e)
	{
	    if (e.EditAction == GridViewEditAction.Cancel)
	    {
	        e.UserDefinedErrors.Clear();
	    }
	}
```
```VB.NET
	Private Sub rgvTest_RowEditEnded(ByVal sender As Object, ByVal e As GridViewRowEditEndedEventArgs)
		If e.EditAction = GridViewEditAction.Cancel Then
			e.UserDefinedErrors.Clear()
		End If
	End Sub
```

## See Also

 * [Getting Started]({%slug gridview-getting-started2%})

 * [Validating]({%slug gridview-managing-data-validation%})
