---
title: Folding Taggers
page_title: Folding Taggers
description: This article explains the use of folding taggers the RadSyntaxEditor control.
slug: radsyntaxeditor-features-folding-taggers
tags: folding,taggers,radsyntaxeditor
position: 2
---

# Folding Taggers

The folding taggers are used when you want to create collapsible (foldable) sections of code in a document. The base class responsible for this functionality is the **FoldingTaggerBase** class with concrete implementations provided out of the box being the **BracketFoldingTagger**, **CSharpFoldingTagger** and **VisualBasicFoldingTagger**.

#### Figure 1: RadSyntaxEditor with a registered CSharpFoldingTagger

![RadSyntaxEditor with a registered CSharpFoldingTagger](images/syntaxeditor-taggers-folding-taggers.png)

## FoldingTaggerBase

**FoldingTaggerBase** the class responsible for generating the collapsible code regions. You can override this class and add **FoldingRegionDefinitions** to define the start and end matching rules of a collapsible section.

#### __[C#] Example 1: Adding FoldingRegionDefinitions__
{{region cs-radsyntaxeditor-features-folding-taggers-1}}
    public CustomFoldingTagger(ITextDocumentEditor editor) : base(editor)
    {
        this.FoldingRegionDefinitions.Add(new FoldingRegionDefinition("FUNCTION", "END"));
        this.FoldingRegionDefinitions.Add(new FoldingRegionDefinition("IF", "END IF"));
    }
{{endregion}}

In addition, you may also want to override the **BuildStartRegionBlockPattern** and **BuildEndRegionBlockPattern** and return a custom regular expression to match the start and end.

#### __[C#] Example 2: Default implementation of the BuildStartRegionBlockPattern and BuildEndRegionBlockPattern methods__
{{region cs-radsyntaxeditor-features-folding-taggers-2}}
    protected override string BuildStartRegionBlockPattern(Dictionary<string, string> startToEndMap)
    {
        // returns \bFUNCTION\b|\bIF\b
        return string.Join("|", startToEndMap.Keys.Select(x => string.Format("\\b{0}\\b", x)));
    }

    protected override string BuildEndRegionBlockPattern(Dictionary<string, string> startToEndMap)
    {
        // returns \bEND\b|\bEND IF\b
        return string.Join("|", startToEndMap.Values.Select(x => string.Format("\\b{0}\\b", x)));
    }
{{endregion}}

Here's a full list of the overridable methods which you can use in order to create your own custom folding taggers. You can check their default implementations in the various out of the box folding taggers to get a general understanding of how to use them by {% if site.site_name == 'WPF' %}[downloading the source code]({%slug download-product-files-wpf%}){% else %}[downloading the source code]({%slug download-product-files%}){% endif %} of the UI for {{ site.framework_name }} suite.

* **string BuildStartRegionBlockPattern(Dictionary&lt;string, string> startToEndMap)**: Prepares patters for matching start of collapsible folding section. Default implementation is to join all start strings of provided collapsible sections.
* **string BuildEndRegionBlockPattern(Dictionary&lt;string, string> startToEndMap)**: Prepares patters for matching end of collapsible folding section. Default implementation is to join all end strings of provided collapsible sections.
* **string GetFoldingRegionTitle(Span foldingSpan)**: Gets the text displayed in the collapsed folding section. (**...** by default)
* **string GetFoldingRegionToolTipContent(Span foldingSpan)**: Gets the folding region's tooltip content.
* **string Span CoerceFoldingSpan(Span defaultFoldingSpan)**: Coerces the default provided folding span - span starting from the start of the region's start text and ending in the end of the region's end text.
* **string void RebuildFoldingRegions**: Rebuilds the list of all collapsible (folding) regions.
* **void InvalidateFoldingRegions**: Clears all collapsible (folding) regions and rebuilds them.

## See Also

* [UI Layers]({%slug radsyntaxeditor-features-layers%})
* [Custom Tagger]({%slug radsyntaxeditor-features-custom-tagger%})