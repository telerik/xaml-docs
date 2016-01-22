---
title: Copy a Worksheet
page_title: Copy a Worksheet
description: Iterate through Worksheets
slug: radspreadprocessing-working-with-worksheets-copy-worksheet
tags: copy,worksheet
published: True
position: 5
---

# Copy a worksheet
<<Comment: This article was not consistent with capitalization of the words worksheet and workbook. I think these are general terms and do not need to be capitalized. For comparison, I looked at documentation in Microsoft Excel and they do not capitalize these words.>>
	<Workbook and worksheet are both general terms and class names in our API. I've used the capitalized, bold version where the context of the sentence implies the API member, and the lower case where the general term is implied. Looking through the content, I could make it consistent by using the bold, capitalized version everywhere but I've intentionally not done so as I don't want the emphasis of all sentences to be on those words. Does that make sense to you and do you think I should remove the general terms?>

There are scenarios in which you may need to copy a specific worksheet and apply a modification to it. For those cases, in Q1 2016 we introduced an API in the __Worksheet__ class allowing you to copy a sheet to the same or another __Workbook__. <<Comment: At the end of the previous sentence, why is Workbook bold and capitalized? If you just generally mean a workbook, no capital letter required.>>


The __CopyFrom(Worksheet source)__ method of a worksheet will copy the passed _source_ sheet into the one the method is called for. This will clone all content and formatting from the source.


__Example 1__ illustrates how to copy a specific worksheet from a source workbook into a new sheet in the desired target workbook.


#### __[C#] Example 1: Copy Worksheet__
{{region radspreadprocessing-working-with-worksheets-copy-worksheet_0}}
    Worksheet clonedSheet = target.Worksheets.Add();
    clonedSheet.CopyFrom(source.Sheets[0] as Worksheet);
{{endregion}}


#### __[VB.NET] Example 1: Copy Worksheet__
    Dim clonedSheet As Worksheet = target.Worksheets.Add()
    clonedSheet.CopyFrom(TryCast(source.Sheets(0), Worksheet))


>If the sheet that you're copying is in a document where a [DocumentTheme]({%slug radspreadprocessing-features-styling-document-themes%}) has been applied, the theme will not be copied. Themes are information preserved in the __Workbook__ and you may need to transfer them additionally.  <<Comment: As in previous comments, I think workbook is lower case, no capital required.>>


Copying a worksheet can be done both in a newly created worksheet and an existing one. If you are copying the content into an existing worksheet, all previously available content in the target will be removed and replaced with the copied one. The sole exception to this rule is that the [Name]({%slug radspreadprocessing-working-with-worksheets-rename-worksheet%}) of the sheet will not be transferred.

__Example 2__ demonstrates a slightly more complex scenario in which a sheet is copied into an existing workbook. If the workbook contains a worksheet with the same name, the sheet to clone is copied into it. Otherwise, a new worksheet is created and its Name is copied from the source document.  <<Commment: To me, this seems to contradict the last sentence in the previous paragraph where you said the Name of a worksheet is not tranferred.>>
	<Name is not transferred by default, but the snippet in Example 2 shows how this can be implemented by the user. Would adding "out of the box" at the end of the previous sentence make this clear?>
        

#### __[C#] Example 2: Copy to existing workbook__
{{region radspreadprocessing-working-with-worksheets-copy-worksheet_1}}
	bool containsSameName = false;
	
	foreach (var worksheet in targetWorkbook.Worksheets)
	{
	    if (worksheet.Name == sheetToClone.Name)
	    {
	        containsSameName = true;
	        break;
	    }
	}
	
	if (containsSameName)
	{
	    targetWorkbook.Worksheets[sheetToClone.Name].CopyFrom(sheetToClone);
	}
	else
	{
	    Worksheet clonedSheet = targetWorkbook.Worksheets.Add();
	    clonedSheet.CopyFrom(sheetToClone);
	    clonedSheet.Name = sheetToClone.Name;
	}
{{endregion}}


#### __[VB.NET] Example 2: Copy to existing workbook__
    Dim containsSameName As Boolean = False

    For Each worksheet As var In targetWorkbook.Worksheets
        If worksheet.Name = sheetToClone.Name Then
            containsSameName = True
            Exit For
        End If
    Next

    If containsSameName Then
        targetWorkbook.Worksheets(sheetToClone.Name).CopyFrom(sheetToClone)
    Else
        Dim clonedSheet As Worksheet = targetWorkbook.Worksheets.Add()
        clonedSheet.CopyFrom(sheetToClone)
        clonedSheet.Name = sheetToClone.Name
    End If


## See Also

* [Iterate through Worksheets]({%slug radspreadprocessing-working-with-worksheets-iterate-through-worksheets%})
* [Rename a Worksheet]({%slug radspreadprocessing-working-with-worksheets-rename-worksheet%})
* [Add and Remove Worksheets]({%slug radspreadprocessing-working-with-worksheets-add-remove-worksheets%})
