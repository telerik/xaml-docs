---
title: Worksheet Protection
page_title: Worksheet Protection
description: Worksheet Protection
slug: radspreadsheet-model-features-protection-worksheet
tags: worksheet,protection
publish: False
position: 1
---

# Worksheet Protection



__Worksheet__ protection is designed to restrict the user from modifying the content and structure of the worksheet. When a worksheet is protected the user can edit the contents only of the cells that were explicitly marked as unlocked. Additionally, the model of RadSpreadsheet offers protection options that let you choose a set of commands that will be available to the user when protection is enabled.
      

You can enforce worksheet protection with or without a password and you can always unprotect the workbook as needed. That said, you can also let the user remove the protection by entering the correct password.
      

## How to protect and unprotect a worksheet?

The __Worksheet__ class exposes a __Protect()__ method that takes two parameters: the password string and the worksheet protection options. The following sample snippet sets the __IsLocked__ property of the A1 cell to false and protects the worksheet using a password and the default protection options. Since by default all cells are locked, after the sheet is protected, the user will be able to edit the value only in cell A1 as it was explicitly marked as unlocked.
        

#### __C#__

{{region radspreadsheet-model-features-protection-worksheet_0}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            worksheet.Cells[0, 0].SetIsLocked(false);
	
	            worksheet.Protect("telerik", WorksheetProtectionOptions.Default);
	
	{{endregion}}



Use the __Unprotect(string)__ method of the Worksheet class to remove the protection. The method returns a Boolean value that indicates whether the sheet is successfully unprotected.
        

The following snippet demonstrates how to unprotect a worksheet:
        

#### __C#__

{{region radspreadsheet-model-features-protection-worksheet_1}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            worksheet.Protect("telerik", WorksheetProtectionOptions.Default);
	
	            worksheet.Unprotect("telerik");
	
	{{endregion}}



## Protection options

The worksheet protection feature lets specify a set of options that will be available to the user when protection is enforced. For example, you may want to allow the user to insert and delete rows, but restrict the insertion and deletion of columns.
        

To achieve that, you need to pass a __WorksheetProtectionOptions__ instance as the second argument of the Protect() method.
        

#### __C#__

{{region radspreadsheet-model-features-protection-worksheet_2}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	            WorksheetProtectionOptions options = new WorksheetProtectionOptions(allowInsertRows: true, allowDeleteRows: true);
	            worksheet.Protect("telerik", options);
	
	{{endregion}}



Currently, the __WorksheetProtectionOptions__ class exposes the following options:
        

* Insert columns

* Insert rows

* Delete columns

* Delete rows

# See Also
