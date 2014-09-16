---
title: Validation errors not cleared
page_title: Validation errors not cleared
description: Validation errors not cleared
slug: gridview-troubleshooting-validation-stays
tags: validation,errors,not,cleared
publish: True
position: 18
---

# Validation errors not cleared



## 

__PROBLEM__

You apply a row-level validation setting a custom ValidationResult when RowValidating event is invoked. Then you correct the value, but the error indicator does not go away.
        



__CAUSE__

The problem comes from the fact that you are adding some user errors when validating edit on RowValidating event. 
        



__SOLUTION__

With __Q3 2013__ official release we have introduced a new property for __GridViewRowEditEndedEventArgs__. It is named __UserDefinedErrors__ and it contains with all user errors for the last edited row. You will be able to handle RowEditEnded event and clear these errors. That way the valid state will be restored.
        

Your code should be similar to the following:
          

#### __C#__

{{region gridview-troubleshooting-validation-stays_0}}
	private void rgvTest_RowEditEnded(object sender, GridViewRowEditEndedEventArgs e)
	{
		if (e.EditAction == GridViewEditAction.Cancel)
		{
			e.UserDefinedErrors.Clear();
		}
	}
	
	{{endregion}}



# See Also

 * [Getting Started]({%slug gridview-getting-started2%})

 * [Validating]({%slug gridview-managing-data-validation%})
