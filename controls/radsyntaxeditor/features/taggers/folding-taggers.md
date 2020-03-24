---
title: Folding Taggers
page_title: Folding Taggers
description: This article explains the use of folding taggers in the RadSyntaxEditor control.
slug: radsyntaxeditor-features-folding-taggers
tags: folding,taggers,radsyntaxeditor
position: 2
---

# Folding Taggers

The folding taggers are used when you want to create collapsible (foldable) sections of code in a document. The base class responsible for this functionality is the **FoldingTaggerBase** class with concrete implementations provided out of the box being the **BracketFoldingTagger**, **CSharpFoldingTagger**, **VisualBasicFoldingTagger** and **XMLFoldingTagger**.

#### __[C#] Example 1: Registering a folding tagger__
{{region cs-radsyntaxeditor-features-folding-taggers-1}}
    this.foldingTagger = new CSharpFoldingTagger(this.syntaxEditor);
    this.syntaxEditor.TaggersRegistry.RegisterTagger(this.foldingTagger);
{{endregion}}

#### Figure 1: RadSyntaxEditor with a registered CSharpFoldingTagger

![RadSyntaxEditor with a registered CSharpFoldingTagger](images/syntaxeditor-taggers-folding-taggers.png)

## FoldingTaggerBase

**FoldingTaggerBase** is the class responsible for generating the collapsible code regions. You can inherit this class and add **FoldingRegionDefinitions** to define the start and end matching rules of a collapsible section.

### Key Properties

* __FoldingRegionDefinitions__: An __IList__ collection property of __FoldingRegionDefinition__ that gets the definitions that this tagger will use for matching the collapsible regions in the document.

* __IsMatchingCaseSensitive__: A __boolean__ property that gets or sets whether the matching between the start and end folding tags is case sensitive.

#### __[C#] Example 2: Adding FoldingRegionDefinitions__
{{region cs-radsyntaxeditor-features-folding-taggers-2}}
    public CustomFoldingTagger(ITextDocumentEditor editor) : base(editor)
    {
        this.FoldingRegionDefinitions.Add(new FoldingRegionDefinition("FUNCTION", "END"));
        this.FoldingRegionDefinitions.Add(new FoldingRegionDefinition("IF", "END IF"));
    }
{{endregion}}

In addition, you may also want to override the **BuildStartRegionBlockPattern** and **BuildEndRegionBlockPattern** and return a custom regular expression to match the start and end.

#### __[C#] Example 3: Default implementation of the BuildStartRegionBlockPattern and BuildEndRegionBlockPattern methods__
{{region cs-radsyntaxeditor-features-folding-taggers-3}}
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

## Styling the Folding Button

If you want to change the appearance of the folding buttons which appear next to each folding region, you can create an appropriate style targeting the **FoldingToggleButton** element.

#### __[XAML] Example 1: Styling the FoldingToggleButton__
{{region xaml-radsyntaxeditor-features-palettes-2}}
    <!-- If you are using the NoXaml binaries, you will have to base the style on the default one for the theme like so: 
    <Style TargetType="syntaxEditor:FoldingToggleButton" BasedOn="{StaticResource FoldingToggleButtonStyle}">--> 
    <Style xmlns:syntaxEditor="clr-namespace:Telerik.Windows.Controls.SyntaxEditor.UI;assembly=Telerik.Windows.Controls.SyntaxEditor" TargetType="syntaxEditor:FoldingToggleButton">
        <Setter Property="Foreground" Value="Red" />
    </Style>
{{endregion}}

## See Also

* [UI Layers]({%slug radsyntaxeditor-features-layers%})
* [Custom Tagger]({%slug radsyntaxeditor-features-custom-tagger%})
