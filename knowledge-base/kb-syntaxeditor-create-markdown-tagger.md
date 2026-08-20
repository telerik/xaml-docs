---
title: Create a Custom Markdown Tagger for RadSyntaxEditor
page_title: Highlight Markdown Syntax with a Custom Tagger
description: Highlight Markdown syntax elements in RadSyntaxEditor by creating and registering a custom classification tagger.
type: how-to
slug: kb-syntaxeditor-create-markdown-tagger
position: 0
tags: radsyntaxeditor, markdown, markdownviewer, tagger, syntax highlighting, classification
res_type: kb
---

## Environment

| Version | Product | Author | 
| ---- | ---- | ---- | 
| 2026.3.812| RadSyntaxEditor |[Desislava Yordanova](https://www.telerik.com/blogs/author/desislava-yordanova)| 

## Description

Create a custom classification tagger for the __RadSyntaxEditor__ that highlights common Markdown syntax elements, including headings, bold and italic text, inline code, fenced code blocks, links, blockquotes, list markers, and horizontal rules.

This approach provides a viewer-style presentation of Markdown source text in __RadSyntaxEditor__ with syntax highlighting. It does not render Markdown as a formatted HTML or rich-text document.

## Solution

Create a class that inherits from `TaggerBase<ClassificationTag>`. The tagger examines the text in each requested snapshot span, matches Markdown syntax with regular expressions, and returns classification tag spans for the matching text.

__Example 1: Creating a custom MarkdownTagger__
```C#
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Telerik.Windows.SyntaxEditor.Core.Editor;
using Telerik.Windows.SyntaxEditor.Core.Tagging;
using Telerik.Windows.SyntaxEditor.Core.Text;

namespace WPFSample
{
    public class MarkdownTagger : TaggerBase<ClassificationTag>
    {
        private static readonly Regex HeadingPattern = new(@"^#{1,6}\s", RegexOptions.Compiled);
        private static readonly Regex BoldPattern = new(@"\*\*.+?\*\*|__.+?__", RegexOptions.Compiled);
        private static readonly Regex ItalicPattern = new(@"(?<!\*)\*(?!\*).+?(?<!\*)\*(?!\*)|(?<!_)_(?!_).+?(?<!_)_(?!_)", RegexOptions.Compiled);
        private static readonly Regex CodePattern = new(@"`[^`]+`", RegexOptions.Compiled);
        private static readonly Regex LinkPattern = new(@"\[.+?\]\(.+?\)", RegexOptions.Compiled);
        private static readonly Regex BlockquotePattern = new(@"^>\s", RegexOptions.Compiled);
        private static readonly Regex ListPattern = new(@"^(\s*[-*+]|\s*\d+\.)\s", RegexOptions.Compiled);
        private static readonly Regex HorizontalRulePattern = new(@"^(---|\*\*\*|___)\s*$", RegexOptions.Compiled);
        private static readonly Regex CodeBlockPattern = new(@"^```", RegexOptions.Compiled);

        public MarkdownTagger(ITextDocumentEditor editor) : base(editor)
        {
        }

        public override IEnumerable<TagSpan<ClassificationTag>> GetTags(NormalizedSnapshotSpanCollection spans)
        {
            foreach (var span in spans)
            {
                var snapshot = span.Snapshot;
                var startLine = snapshot.GetLineFromPosition(span.Start);
                var endLine = snapshot.GetLineFromPosition(span.End);

                bool inCodeBlock = false;

                for (int i = startLine.LineNumber; i <= endLine.LineNumber; i++)
                {
                    var line = snapshot.GetLineFromLineNumber(i);
                    var lineText = line.GetText();

                    // Toggle fenced code block
                    if (CodeBlockPattern.IsMatch(lineText))
                    {
                        yield return CreateTagSpan(snapshot, line.Span, ClassificationTypes.Keyword);
                        inCodeBlock = !inCodeBlock;
                        continue;
                    }

                    if (inCodeBlock)
                    {
                        yield return CreateTagSpan(snapshot, line.Span, ClassificationTypes.StringLiteral);
                        continue;
                    }

                    // Headings
                    if (HeadingPattern.IsMatch(lineText))
                    {
                        yield return CreateTagSpan(snapshot, line.Span, ClassificationTypes.Keyword);
                        continue;
                    }

                    // Horizontal rules
                    if (HorizontalRulePattern.IsMatch(lineText))
                    {
                        yield return CreateTagSpan(snapshot, line.Span, ClassificationTypes.Comment);
                        continue;
                    }

                    // Blockquotes
                    if (BlockquotePattern.IsMatch(lineText))
                    {
                        yield return CreateTagSpan(snapshot, line.Span, ClassificationTypes.Comment);
                        continue;
                    }

                    // List markers
                    var listMatch = ListPattern.Match(lineText);
                    if (listMatch.Success)
                    {
                        yield return CreateTagSpan(snapshot,
                            new Span(line.Span.Start, listMatch.Length), ClassificationTypes.Keyword);
                    }

                    // Inline patterns
                    foreach (var tagSpan in MatchInline(snapshot, line, lineText, BoldPattern, ClassificationTypes.Keyword))
                        yield return tagSpan;

                    foreach (var tagSpan in MatchInline(snapshot, line, lineText, ItalicPattern, ClassificationTypes.Identifier))
                        yield return tagSpan;

                    foreach (var tagSpan in MatchInline(snapshot, line, lineText, CodePattern, ClassificationTypes.StringLiteral))
                        yield return tagSpan;

                    foreach (var tagSpan in MatchInline(snapshot, line, lineText, LinkPattern, ClassificationTypes.Comment))
                        yield return tagSpan;
                }
            }
        }

        private static IEnumerable<TagSpan<ClassificationTag>> MatchInline(
            TextSnapshot snapshot, TextSnapshotLine line, string lineText,
            Regex pattern, ClassificationType classificationType)
        {
            foreach (Match match in pattern.Matches(lineText))
            {
                yield return CreateTagSpan(snapshot,
                    new Span(line.Span.Start + match.Index, match.Length), classificationType);
            }
        }

        private static TagSpan<ClassificationTag> CreateTagSpan(
            TextSnapshot snapshot, Span span, ClassificationType classificationType)
        {
            return new TagSpan<ClassificationTag>(
                new TextSnapshotSpan(snapshot, span),
                new ClassificationTag(classificationType));
        }
    }
}
```

The tagger uses the built-in `ClassificationTypes` values. The editor can use the corresponding classification format definitions to render the resulting colors.

Register the tagger after assigning the document to the editor. The following example creates a Markdown document, inserts sample content, and registers the custom tagger:

__Example 2: Registering the MarkdownTagger__
````C#
            SyntaxEditor.Document = new TextDocument();
            SyntaxEditor.Document.Insert(0, "# Markdown Sample\n\nThis is a **bold** and *italic* text demo.\n\n## Features\n\n- Item one\n- Item two\n- Item three\n\n> This is a blockquote\n\n`inline code` and [a link](https://example.com)\n\n```\nvar x = 42;\nConsole.WriteLine(x);\n```\n\n---\n\n### Done!");
            SyntaxEditor.TaggersRegistry.RegisterTagger(new MarkdownTagger(this.SyntaxEditor));
````

The tagger applies the following classifications:

* Headings, list markers, and bold text use `ClassificationTypes.Keyword`.
* Italic text uses `ClassificationTypes.Identifier`.
* Inline code and fenced code blocks use `ClassificationTypes.StringLiteral`.
* Links, blockquotes, and horizontal rules use `ClassificationTypes.Comment`.

This example is a lightweight syntax highlighter. It does not parse the complete CommonMark specification, and nested or escaped Markdown expressions may require additional parsing rules.

#### Figure 1: Markdown syntax highlighted in RadSyntaxEditor

![RadSyntaxEditor displaying highlighted Markdown headings, emphasis, lists, blockquotes, links, inline code, and a fenced code block](images/custom-markdown-tagger-in-syntaxeditor.png)

## See Also

* [Custom Tagger]({%slug radsyntaxeditor-features-custom-tagger%})
* [Taggers]({%slug radsyntaxeditor-features-taggers%})
* [SyntaxEditor Overview]({%slug radsyntaxeditor-overview%})
