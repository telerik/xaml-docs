---
title: Open and Compare the XML Contents of Word Documents (.docx)
description: How to open the XML of Word .docx documents and compare their contents using Visual Studio
type: how-to
page_title: Diff the XML Content of DOCX Files
slug: kb-common-compare-docx-xml-content
position: 0
tags: groupdescriptors, changes, collectionview, cardview
res_type: kb
---

## Environment

<table>
    <tbody>
        <tr>
            <td>Product Version</td>
            <td>2024.2.524</td>
        </tr>
        <tr>
            <td>Product</td>
            <td>Telerik UI for WPF</td>
        </tr>
    </tbody>
</table>

## Description

How to get the XML of Word (.docx) documents and compare their contents using Visual Studio.

## Solution

The .docx file format is an archive that can be unzipped. This gives several folders and files with the document contents, styles and other settings. To access the content, you can find and open the __document.xml__ file. Then, you can compare the text in the __document.xml__ files of the corresponding files.

This article describes how to do this using the [Open XML Package Editor for Modern Visual Studios](https://marketplace.visualstudio.com/items?itemName=bsivanov.OpenXMLPackageEditorforVisualStudio) extension tool for easier access to the files of the .docx file, without the need to unzip it. Visual Studio built-in diff tool can be used to compare the extracted XML contents.

1. Install the [Open XML Package Editor for Modern Visual Studios](https://marketplace.visualstudio.com/items?itemName=bsivanov.OpenXMLPackageEditorforVisualStudio) Visual Studio extension. This will allow you to open the __.docx__ files content directly in Visual Studio.

2. [Create a new Blank Solution](https://learn.microsoft.com/en-us/visualstudio/get-started/tutorial-projects-solutions?view=vs-2022#create-a-solution) in Visual Studio. This is required in order to use the Visual Studio's [Compare Selection](https://learn.microsoft.com/en-us/visualstudio/ide/compare-with?view=vs-2022) feature.

3. Include the two __.docx__ files that will be compared in the solution.
	
	![A picture showing the Visual Studio Add Existing Item menu option](images/kb-common-compare-docx-xml-content-0.png)  
	![A picture showing two Word documents added in the Visual Studio solution](images/kb-common-compare-docx-xml-content-1.png)
	
4. Create two new empty __.xml__ files in the solution. 

	![A picture showing the Visual Studio Add New Item menu option](images/kb-common-compare-docx-xml-content-2.png)
	![A picture showing the New File window in Visual Studio with the XML File selected](images/kb-common-compare-docx-xml-content-3.png)
	![A picture showing the two empty XML files added in the Visual Studio solution](images/kb-common-compare-docx-xml-content-4.png)

5. Double click the first __.docx__ file in the solution and open the __/word/documents.xml__ file. 
	
	![A picture showing the contents of the docx file opened by the Open XML Package Editor extension](images/kb-common-compare-docx-xml-content-5.png)
	![A picture showing the contents of the documents.xml file](images/kb-common-compare-docx-xml-content-6.png)
	
	If the file is not formatted you can do that by using the __Edit-->Advanced-->Format Selection__ option. The default shortcut for this action is __Ctrl+K, Ctrl+F__.
	
	![A picture showing the Format Selection menu option](images/kb-common-compare-docx-xml-content-7.png)
	
6. Copy the content of the __documents.xml__ file to one of the empty __.xml__ files and save it.

	![A picture showing the documents.xml contents moved in the newly created xml file](images/kb-common-compare-docx-xml-content-8.png)

7. Repeat __step 5__ also for the other __.docx__ file and copy its XML contents to the other empty __.xml__ file, and then save it.

8. Select the __.xml__ files in the Solution Explorer and right click on any of the files to display the context menu. From the menu select the [Compare Selection](https://learn.microsoft.com/en-us/visualstudio/ide/compare-with?view=vs-2022) option.

	![A picture showing the Compare Selection menu option in Visual Studio](images/kb-common-compare-docx-xml-content-9.png)

This will open a new diff view showing the comparison between the two __.xml__ files

![A picture showing the diff tool of Visual Studio comparing the two .xml files](images/kb-common-compare-docx-xml-content-10.png)

