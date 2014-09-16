---
title: What is a Row? What is a Column?
page_title: What is a Row? What is a Column?
description: What is a Row? What is a Column?
slug: radspreadsheet-model-working-with-rows-and-columns-what-is-row-column
tags: what,is,a,row?,what,is,a,column?
published: False
position: 0
---

# What is a Row? What is a Column?



This article will help you get familiar with the concepts of rows and columns.
      

## What is a Row? What is a Column?

Rows in the document model of __RadSpreadsheet__ are groups of cells that are on the same horizontal line. Each row is identified 
          with a number. For example the first row has an index 1, the second – 2 and the last – 1048576. Similarly, a column is a group of cells that are 
          vertically stacked and appear on the same vertical line. Columns in __RadSpreadsheet__ are identified by a letter or a 
          combination of letters. For example, the first column is called A, the second – B and the last column is XFD.
        

## 

Rows in __RadSpreadsheet__'s document model offer several approaches for determining their height:
        

* __Default Height__ - each row has a default height of 20. When the row does not have an explicitly set height it appears with 
              its default height.
            

* __Height__ - the height property allows you to make a given set of rows appear with a fixed height.
            

* __Auto Fit__ - the auto fit feature sets the height of a specific row based on the content of all cells in the row. The 
              height of the row is determined by the cell containing the highest content.
            

Similarly, columns expose several ways to set their width:
        

* __Default Width__ - each column has a default with of 65. When the column does not have an explicit width set it appears 
              with its default width.
            

* __Width__ - the width property allows you to make a given set of columns appear with a fixed width.
            

* __Auto Fit__ - the auto fit feature sets the width of a specified column based on the content of all cells in the column. 
              The width of the column is determined by the cell containing the widest content.
            

More information about setting row's height and column's is available in the [Resizing Rows and Columns]({%slug radspreadsheet-model-working-with-rows-and-columns-resizing%}) article.
        

# See Also
