---
title: Section
page_title: Section
description: Section
slug: radwordsprocessing-model-section
tags: section
published: True
position: 1
---

# Section



__Section__ is a BlockContainer element which can contain other block elements. You can customize its layout through its
        properties.
      

* [Inserting a Section](#inserting-a-section)

* [Modifying a Section](#modifying-a-section)

* [Operating with a Section](#operating-with-a-section)

## Inserting a Section

You can use the following code snippet to create a __Section__ element and add it to a
          [RadFlowDocument]({%slug radwordsprocessing-model-radflowdocument%}):
        

#### __C#__

{{region radwordsprocessing-model-section_0}}
	            Section section = new Section(document);
	            document.Sections.Add(section);
	{{endregion}}



You can also use the __AddSection()__ method of the __Sections__ collection of a document. The
          method creates a new Section element, adds it to the document and returns it:
        

#### __C#__

{{region radwordsprocessing-model-section_1}}
	            Section section = document.Sections.AddSection();
	{{endregion}}



## Modifying a Section

The __Section__ exposes several properties that allow you to customize the layout of the elements placed underneath it.
        

* __PageMargins__: Represents the margin towards the edges of the page.
            

#### __C#__

{{region radwordsprocessing-model-section_2}}
	            section.PageMargins = new Padding(10, 10, 5, 5);
	{{endregion}}



* __PageOrientation__: Specifies if the pages in the section should be in Portrait or in Landscape orientation.
            

#### __C#__

{{region radwordsprocessing-model-section_3}}
	            section.PageOrientation = PageOrientation.Landscape;
	{{endregion}}



* __PageSize__: Specifies the size of the pages in the section. The __PaperTypeConverter__ class and the
              [PaperTypes](http://www.telerik.com/help/wpf/t_telerik_windows_documents_model_papertypes.html)
              enumeration provide convenient API and predefined sizes out of the box.
            

#### __C#__

{{region radwordsprocessing-model-section_4}}
	            section.PageSize = PaperTypeConverter.ToSize(PaperTypes.A4);
	{{endregion}}



* __Headers and Footers__: Each Section has three Headers and three Footers - __Default__ (used all through the section),
              __First__ (used on the first page of the section) and __Even__ (used on even pages of the
              document). The three Headers are contained in the Headers class accessible through the __Section.Headers__ property.
              The three Footers are contained in the Footers class accessible through the __Section.Footers__ property.
            Here is a how you can create default Header:
            

#### __C#__

{{region radwordsprocessing-model-section_5}}
	            Header header = section.Headers.Add();
	            Paragraph paragraph = header.Blocks.AddParagraph();
	            paragraph.TextAlignment = Alignment.Right;
	            paragraph.Inlines.AddRun("This is a sample header.");
	{{endregion}}



>tipMore information on how to work with the different types of headers and footer can be found in the
                [Headers and Footers]({%slug radwordsprocessing-model-headers-footers%}) article.
              

* __SectionType__: Defines the section types:
            

* __NextPage__ - specifies that the section starts on the next page.
                

* __EvenPage__ - specifies that the section starts on the next page.
                

* __OddPage__ - specifies that the section starts on the next odd page.
                

* __Continuous__ - specifies that the section starts on the same page.
                

* __NextColumn__ - specifies that the section starts on the next column on the page.
                

* __Properties__: Gets all section properties as __SectionProperties__ object. More info on how
              to use section properties can be found in [ Style Properties]({%slug radwordsprocessing-concepts-style-properties%}) article.
            

## Operating with a Section

Section derives
          [BlockContainerBase](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_documents_flow_model_blockcontainerbase.html)
          , inheriting Blocks property of BlockCollection type. You can add [Paragraph]({%slug radwordsprocessing-model-paragraph%})  and
          [Table]({%slug radwordsprocessing-model-table%}) objects to that collection:
        

#### __C#__

{{region radwordsprocessing-model-section_6}}
	            Paragraph paragraph = section.Blocks.AddParagraph();
	            Table table = section.Blocks.AddTable();
	{{endregion}}



# See Also[Section API Reference](http://www.telerik.com/help/wpf/allmembers_t_telerik_windows_documents_flow_model_section.html)

 * [Headers and Footers]({%slug radwordsprocessing-model-headers-footers%})

 * [Paragraph]({%slug radwordsprocessing-model-paragraph%})

 * [Table]({%slug radwordsprocessing-model-table%})
