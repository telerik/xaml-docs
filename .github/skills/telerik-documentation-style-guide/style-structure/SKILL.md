---
name: style-structure
description: "Use this skill when authoring, reviewing, auditing, or remediating Telerik UI for WPF documentation structure, headings, lists, and images. Defines mandatory standard-article H1, KB no-H1, and immediate image-introduction validation and automated fixes."
---

# WPF Article Structure, Headings, and Lists

Use this skill to organize Telerik UI for WPF documentation while preserving the repository's rendering and navigation conventions. The mandatory rules below apply to content generation, reviews, audits, accessibility and quality scoring, Markdown remediation, and automated content fixes. They override conflicting H1 or image-introduction advice in templates, neighboring articles, and other skills. Follow neighboring articles for structure not governed by these rules.

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

### Mandatory H1 Rules

Classify the article before validating or editing. Treat an article under `knowledge-base/`, or identified by KB metadata such as `res_type: kb`, as a KB article. A FAQ section does not make a standard article a KB article. If the article type is unresolved, report that uncertainty before proposing an H1 change; never guess and add an H1 to a possible KB article.

Count actual article headings, not heading-like text inside frontmatter, fenced or indented code, comments, or literal examples. Recognize equivalent Setext and HTML H1 forms so they cannot bypass validation. Standard articles must use exactly one Markdown `# Heading` as their title; KB articles must contain zero H1 headings of any form. A metadata title does not satisfy the standard article's source-H1 requirement. A KB may begin at H2 because its title is generated; this is not a skipped-level violation.

| Article type | Validation and review | Remediation and generation |
|---|---|---|
| Standard documentation | Exactly one H1. Report a missing H1 or multiple H1 headings. | Recommend one appropriate H1 if absent; add it when authoring or when fixes are authorized. Retain the article title and convert additional H1 headings to H2 or a deeper level appropriate to their parent section. |
| Knowledge Base | No H1. Flag every H1, including a duplicate of the metadata-generated title. | Never add an H1, even if a template requests one. Recommend removal of a redundant title or conversion of a real section to the appropriate lower heading level; apply that correction when fixes are authorized. |

Preserve section meaning, nesting, and valid headings. When demoting a heading, adjust its descendants only as needed to preserve their relative hierarchy; do not flatten the outline or mechanically demote every heading. Recheck heading counts and hierarchy after every fix.

Use a logical heading hierarchy. Do not skip levels, use headings for visual emphasis or image introductions, or leave empty headings. Add useful context between a heading and its first subheading. Keep headings concise and specific to the WPF task. Preserve headings that are already valid unless the request or a mandatory rule requires a change.

Use title case where it matches the surrounding section. Existing WPF content contains legacy casing and punctuation; do not mechanically normalize unrelated headings. Keep sibling headings parallel when writing a new section. FAQ headings can be questions when the surrounding content uses that convention.

### Heading Examples

Compliant standard article (section bodies omitted):

```markdown
# Configure the Scheduler

## Prerequisites

## Configuration
```

Compliant KB article (section bodies omitted):

```markdown
## Environment

## Description

## Solution
```

Non-compliant standard article: convert `Additional Information` to H2, or a deeper level if its parent requires it.

```markdown
# Configure the Scheduler

# Additional Information
```

Non-compliant KB article: remove the duplicate title, or convert it to a section heading only if it represents a genuine section.

```markdown
# Error When Loading Data

## Symptoms

## Resolution
```

## Lists and Figures

Use numbered lists for sequential steps and bulleted lists for unordered items. Introduce a list with a sentence that explains its purpose. Keep list items parallel and use consistent capitalization and punctuation. Avoid one-item lists and excessive nesting.

### Mandatory Image Introductions

Every image must have either a meaningful introductory sentence or a caption block immediately before it. This includes Markdown images, reference-style or linked images, and HTML images. Alt text is required independently and is not an introduction. Blank separator lines are allowed, but no unrelated prose, heading, list, code block, or other content may intervene between the introduction and the image. For consecutive images, check each image separately.

Preserve existing introductions that provide sufficient context. When adding one, briefly explain the image's content, purpose, or what the reader should observe, using concise, reader-focused language. Do not invent details that the asset or context cannot support. If an asset cannot be inspected and its purpose is unclear, report the unresolved issue instead of fabricating a description.

The caption syntax is exactly `>caption Description`, without a space between `>` and `caption`. A heading, a bold-only label (`**...**` or `__...__`, including HTML equivalents), a distant paragraph, or text after the image is not an acceptable introduction. Bold UI names inside a meaningful sentence are allowed. Never use both a caption and a heading solely to introduce an image; a genuine section heading may remain when the section has independent content and an approved introduction immediately precedes the image.

When editing or automatically fixing Markdown, replace a heading or bold-only label used solely as an image introduction with a meaningful sentence or `>caption` block. Preserve its useful wording and the image path, alt text, and rendering syntax. Do not remove a genuine section heading or a referenced anchor blindly: retain or repair the section hierarchy and internal references, then add an approved introduction. Report ambiguous cases for review. Leave code-example and table captions under their own rules; do not convert them merely because they are bold.

Compliant introductory sentence:

```markdown
The following image shows the Data Source Configuration dialog.

![Data Source Configuration](images/data-source.png)
```

Compliant caption block:

```markdown
>caption Data Source Configuration dialog

![Data Source Configuration](images/data-source.png)
```

Non-compliant heading introduction (also invalid when followed by a caption solely for this image):

```markdown
### Data Source Configuration

![Data Source Configuration](images/data-source.png)
```

Non-compliant bold introduction:

```markdown
**Data Source Configuration**

![Data Source Configuration](images/data-source.png)
```

Use descriptive alt text and preserve the repository's existing image path and rendering syntax. A screenshot does not prove keyboard, accessibility, binding, or runtime behavior. Identify Windows, theme, scaling, and Telerik-version context when those affect the image.

## Review and Automated-Fix Acceptance

For every article, report missing standard-article H1s, multiple standard-article H1s, any KB H1, missing image introductions, heading-only introductions, and bold-only introductions with a source location and specific correction. A review or scoring-only request reports and recommends; it does not edit content. An authorized remediation must apply the scoped fixes above, preserve unrelated content and frontmatter, then rerun the same checks. New content must satisfy these rules before delivery. Do not declare an article compliant or a fix complete while any of these violations remains; disclose unresolved cases and unverified checks. Preserve each scoring skill's output schema and weights, placing findings in its relevant dimension rather than silently marking these rules not applicable.

## WPF Example Structure

A complete WPF example identifies the relevant project or file, XAML namespace, code-behind or viewmodel context, package or assembly references, and theme setup. Label fragments and state where they belong. Verify whether the sample uses Xaml or NoXaml assemblies before describing its resources.

For data examples, distinguish `DataContext` from `ItemsSource` and explain item-property notifications when relevant. For theme examples, identify the theme assembly or merged dictionaries and preserve their required order. Avoid generic instructions that presume every control or project uses the same startup code.

## Quick Checklist

- [ ] The structure matches the WPF article type and neighboring renderer conventions.
- [ ] Article type is identified: standard articles have exactly one `# Heading`; KB articles have no H1 and never receive one.
- [ ] Missing or multiple standard H1s and every KB H1 are reported with corrections; fixes preserve heading hierarchy.
- [ ] Headings are descriptive, nonempty, and hierarchical without skipped levels.
- [ ] Setup and examples use verified WPF namespaces, APIs, references, and theme flavor.
- [ ] Binding sources, item contexts, commands, events, and notifications are explained where relevant.
- [ ] Lists are introduced, parallel, and consistently punctuated.
- [ ] Every image has a meaningful sentence or exact `>caption` block immediately before it, with only optional blank lines between.
- [ ] No image relies on a heading, bold-only label, or heading-plus-caption solely for its introduction.
- [ ] Existing sufficient introductions, image paths, alt text, genuine sections, and anchors are preserved or repaired.
- [ ] Images have descriptive alt text and do not stand in for behavior or accessibility evidence.
- [ ] Post-fix validation repeats all H1 and image-introduction checks; unresolved findings are disclosed.
- [ ] Version, Windows, Xaml or NoXaml, and accessibility claims match verified evidence.
