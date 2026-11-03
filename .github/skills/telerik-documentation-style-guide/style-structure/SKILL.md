---
name: style-structure
description: "Use this skill when structuring Telerik UI for WPF articles, headings, lists, and figures. Covers control guides, installation, fundamentals, data binding, styling, theming, accessibility, troubleshooting, and KB organization."
---

# WPF Article Structure, Headings, and Lists

Use this skill to organize Telerik UI for WPF documentation while preserving the repository's rendering and navigation conventions. Follow neighboring articles of the same type; do not impose one page structure on every WPF article.

## Article Types

Choose structure based on the reader's task:

| Article type | Typical content |
|---|---|
| Getting started | Prerequisites, package or assembly setup, licensing, XAML namespace, minimal control markup, sample data, and expected result. |
| Installation | Supported .NET targets and tools, NuGet or assembly setup, license activation, and verification. Never include credentials. |
| Fundamentals | XAML, C#, binding, commands, events, resources, themes, templates, and application patterns relevant to the topic. |
| Control overview | Control purpose, supported features, API identity, limitations, and links to setup and feature articles. |
| Data binding | Data model, `ItemsSource`, `DataContext`, binding paths, item contexts, and notifications. |
| Styling and theming | Xaml or NoXaml flavor, theme resources, resource dictionaries, supported setters, target types, and theme selection. |
| Troubleshooting | Symptom, tested environment, evidence, confirmed cause when known, scoped fix or workaround, limitations, and verification. |
| Knowledge Base | Existing WPF KB metadata and section pattern. See [style-kb-faq](../style-kb-faq/SKILL.md). |

These are guidance, not new folder or taxonomy requirements. Reuse shared setup and system-requirement articles instead of copying volatile version matrices.

## Headings and Rendering

Inspect the current article and its neighbors before adding or removing headings. Many WPF control articles use a source H1. Many WPF KB articles use metadata-generated titles and start with `## Environment`, with no source H1. Preserve the established pattern for that article type.

Use a logical heading hierarchy. Do not skip levels, use headings for visual emphasis, or leave empty headings. Add useful context between a heading and its first subheading. Keep headings concise and specific to the WPF task. Preserve headings that are already valid unless the request or a clear rule requires a change.

Use title case where it matches the surrounding section. Existing WPF content contains legacy casing and punctuation; do not mechanically normalize unrelated headings. Keep sibling headings parallel when writing a new section. FAQ headings can be questions when the surrounding content uses that convention.

## Lists and Figures

Use numbered lists for sequential steps and bulleted lists for unordered items. Introduce a list with a sentence that explains its purpose. Keep list items parallel and use consistent capitalization and punctuation. Avoid one-item lists and excessive nesting.

Introduce images in the surrounding text. Use descriptive alt text and preserve the repository's existing image path and rendering syntax. A screenshot does not prove keyboard, accessibility, binding, or runtime behavior. Identify Windows, theme, scaling, and Telerik-version context when those affect the image.

## WPF Example Structure

A complete WPF example identifies the relevant project or file, XAML namespace, code-behind or viewmodel context, package or assembly references, and theme setup. Label fragments and state where they belong. Verify whether the sample uses Xaml or NoXaml assemblies before describing its resources.

For data examples, distinguish `DataContext` from `ItemsSource` and explain item-property notifications when relevant. For theme examples, identify the theme assembly or merged dictionaries and preserve their required order. Avoid generic instructions that presume every control or project uses the same startup code.

## Quick Checklist

- [ ] The structure matches the WPF article type and neighboring renderer conventions.
- [ ] Source H1 behavior is correct for the article type; generated KB titles are not duplicated.
- [ ] Headings are descriptive, nonempty, and hierarchical without skipped levels.
- [ ] Setup and examples use verified WPF namespaces, APIs, references, and theme flavor.
- [ ] Binding sources, item contexts, commands, events, and notifications are explained where relevant.
- [ ] Lists are introduced, parallel, and consistently punctuated.
- [ ] Images have descriptive alt text and do not stand in for behavior or accessibility evidence.
- [ ] Version, Windows, Xaml or NoXaml, and accessibility claims match verified evidence.
