---
title: Worksheet Protection
page_title: Worksheet Protection
description: Worksheet Protection
slug: radspreadprocessing-features-protection-worksheet
tags: worksheet,protection
published: True
position: 1
---

# Worksheet Protection



__Worksheet__ protection is designed to restrict the user from modifying the content and structure of the worksheet. When a worksheet is protected the user can edit the contents only of the cells that were explicitly marked as unlocked. Additionally, the model offers protection options that let you choose a set of commands that will be available to the user when protection is enabled.
      

You can enforce worksheet protection with or without a password and you can always unprotect the workbook as needed. You can also let the user remove the protection by entering the correct password.
      

## How to Protect and Unprotect a Worksheet

The __Worksheet__ class exposes a __Protect()__ method that takes two parameters: the password string and the worksheet protection options.
        

__Example 1__ sets the __IsLocked__ property of cell A1 to false and protects the worksheet using a password and the default protection options. Since by default all cells are locked, after the sheet is protected, the user will be able to edit the value only in cell A1 as it is explicitly marked as unlocked.
        

#### __[C#] Example 1: Protect a Worksheet__

{{region radspreadprocessing-features-protection-worksheet_0}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            worksheet.Cells[0, 0].SetIsLocked(false);
	
	            worksheet.Protect("telerik", WorksheetProtectionOptions.Default);
	
	{{endregion}}



Use the __Unprotect(string)__ method of the Worksheet class to remove the protection. The method returns a Boolean value that indicates whether the sheet is successfully unprotected.
        

__Example 2__ demonstrates how to unprotect a worksheet:
        

#### __[C#] Example 2: Unprotect a Worksheet__

{{region radspreadprocessing-features-protection-worksheet_1}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            worksheet.Protect("telerik", WorksheetProtectionOptions.Default);
	
	            worksheet.Unprotect("telerik");
	
	{{endregion}}



## Protection options

The worksheet protection feature lets specify a set of options that will be available to the user when protection is enforced. For example, you may want to allow the user to insert and delete rows, but restrict the insertion and deletion of columns.
        

To achieve that, you need to pass a __WorksheetProtectionOptions__ instance as the second argument of the Protect() method.
        

__Example 3__ demonstrates how to protect a worksheet using WorksheetProtectionOptions.
        

#### __[C#] Example 3: Protect Worksheet with WorksheetProtectionOptions__

{{region radspreadprocessing-features-protection-worksheet_2}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            WorksheetProtectionOptions options = new WorksheetProtectionOptions(allowInsertRows: true, allowDeleteRows: true);
	            worksheet.Protect("telerik", options);
	
	{{endregion}}



The __WorksheetProtectionOptions__ class exposes the following options:
        

* Insert columns

* Insert rows

* Delete columns

* Delete rows

# See Also

 * [What is a Worksheet?]({%slug radspreadprocessing-working-with-worksheets-what-is-worksheet%})

 * [Workbook Protection]({%slug radspreadprocessing-features-protection-workbook%})
