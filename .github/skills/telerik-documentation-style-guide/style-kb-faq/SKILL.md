---
name: style-kb-faq
description: "Use this skill when writing, editing, or reviewing Telerik UI for WPF Knowledge Base articles and FAQs. Covers WPF troubleshooting evidence, XAML and C# samples, theme flavors, security advisories, customer-data sanitization, and concise answers."
---

# Knowledge Base and FAQ Articles

Use this skill for WPF Knowledge Base articles and FAQ sections. KB pages document a specific task, failure, or approved security issue. Follow the article type and rendering pattern used by neighboring pages. Use [style-metadata-links](../style-metadata-links/SKILL.md) for metadata and taxonomy.

## Mandatory Structure and Image Checks

Read and apply [style-structure](../style-structure/SKILL.md), including its heading and image examples, validation, and automated-fix acceptance criteria, for all KB authoring, article reviews, audits, and Markdown remediation.

- [ ] KB articles under `knowledge-base/` or identified by KB metadata contain zero H1s. Never add one, even if a template requests it. Flag every H1 and recommend removal of a duplicate generated title or conversion of a genuine section to the appropriate lower heading level.
- [ ] A FAQ within a standard article follows the standard rule: exactly one `# Heading`. Flag missing or multiple H1s, recommend one title if absent, and demote extras according to hierarchy.
- [ ] Every image has a meaningful sentence or exact `>caption Description` block immediately before it, with only optional blank lines between. Flag missing, heading-only, bold-only, and heading-plus-caption-only introductions.

In review-only mode, report each issue with a source location and correction. For authorized fixes, replace image-only headings or bold labels with prose or `>caption`, preserve sufficient introductions and genuine section anchors, and preserve the document hierarchy. Never remediate a KB by inserting an H1. Revalidate H1 counts and each image introduction after fixes; do not claim compliance with unresolved issues.

## Existing WPF KB Conventions

WPF KB pages commonly use frontmatter fields such as `title`, `description`, `components`, `type`, `page_title`, `slug`, `position`, `tags`, `ticketid`, and `res_type: kb`. Preserve existing field names and values. All KB articles must have no source H1; their title is generated from metadata. They may begin with `## Environment` without a skipped-level violation. Templates and neighboring articles cannot override the no-H1 rule.

A common environment section uses an HTML table:

```markdown
## Environment
<table>
    <tr>
        <td>Product Version</td>
        <td>TESTED_TELERIK_VERSION</td>
    </tr>
    <tr>
        <td>Product</td>
        <td>Progress® Telerik® UI for WPF</td>
    </tr>
    <tr>
        <td>Target Framework</td>
        <td>TESTED_TARGET_FRAMEWORK</td>
    </tr>
    <tr>
        <td>Windows Version</td>
        <td>TESTED_WINDOWS_VERSION</td>
    </tr>
</table>
```

Use only fields relevant to the reproduction and supported by evidence. Do not copy MAUI fields such as mobile platform, workload, or device into a WPF template. Record the .NET target framework, Telerik version, Windows version, build configuration, and Xaml or NoXaml flavor when they affect the issue.

## How-To Articles

State the task and provide a complete solution or clearly labeled fragment. Follow the legacy article's `## Description` and `## Solution` pattern unless the surrounding section uses another template.

Include the minimum WPF context needed to apply the example: the file or resource dictionary, insertion point, project references, XML namespace, theme setup, and required data or viewmodel. Use `MainWindow.xaml` and its code-behind only when appropriate. Do not describe a `ContentPage`, `MauiProgram.cs`, `UseTelerik()`, or MAUI bindings.

For Xaml and NoXaml projects, give the correct setup for the selected flavor. NoXaml examples may require theme assemblies or merged theme dictionaries; Xaml examples use styles included in the control assemblies and their documented theme-selection API. Verify the setup against the target release.

## Troubleshooting Articles

Describe the observed symptom and exact environment. Separate confirmed causes from possible causes. Do not present a guess as a root cause.

A troubleshooting article should include the relevant sections from this pattern:

```markdown
## Environment

## Description

## Cause

## Solution

## See Also
```

Provide a minimal reproduction or code fragment that matches the actual WPF API. Check XAML namespaces, assembly references, `DataContext`, binding paths, item notifications, resource dictionaries, theme flavor, and layout constraints as relevant. State the expected result and the verification performed. Distinguish a workaround from a product fix and document known limitations.

## Security Articles

Follow approved security-team templates and advisory language. Use the exact CVE identifier, severity, affected and fixed versions, and mitigation from the approved source. Describe impact without adding exploit instructions. Do not infer a vulnerability from an exception or reuse an advisory for another product.

## Technical Accuracy and Privacy

- Verify class names, namespaces, properties, events, command contracts, package IDs, file paths, and code against the target WPF release.
- Label snippets as fragments when they omit required context. Name the containing file and insertion point.
- If a placeholder-backed sample cannot be retrieved, mark its source as `unresolved`, identify the placeholder and reason, and skip code-dependent accuracy or compilation claims. Continue with unrelated KB edits and state which checks remain unverified.
- Preserve the exact Xaml or NoXaml flavor, theme resources, target framework, and build configuration that the example requires.
- `ObservableCollection<T>` reports collection changes; item-property changes require property-change notifications.
- Test the reproduction and solution on the stated Windows and .NET configuration. If testing is unavailable, state what remains unverified.
- Check keyboard interaction, focus order, accessible names, and screen-reader behavior when relevant. Do not claim accessibility compliance from code review alone.
- Request only sanitized logs and minimal reproductions. Remove customer names, email addresses, company names, credentials, license keys, tokens, and sensitive data.

## FAQ Sections

Use question headings when the surrounding WPF article uses an FAQ structure. Keep answers direct and self-contained. Link to a detailed WPF article when it covers the full procedure. Do not refer to another FAQ answer as "above" or "below."

```markdown
## How Do I Bind Data to RadGridView?

Set `ItemsSource` to a collection and set the appropriate `DataContext` for the bindings.
See the [RadGridView overview]({%slug gridview-overview2%}) for the control context.
```

Retain the heading capitalization and punctuation convention of the surrounding repository content when editing an existing FAQ.

## Quick Checklist

- [ ] Frontmatter preserves the local WPF KB conventions and stable identifiers.
- [ ] KB articles have zero H1s; no generation or remediation adds one. Standard articles containing FAQs have exactly one H1.
- [ ] All H1 violations are reported or fixed without damaging section hierarchy.
- [ ] Every image has an immediate sentence or exact `>caption` block, never a heading or bold-only introduction.
- [ ] Missing introductions and image-only heading/bold labels are corrected when authorized; sufficient introductions are preserved.
- [ ] Post-fix validation repeats these checks and discloses unresolved issues.
- [ ] Environment details identify the tested Telerik version, target framework, Windows version, and Xaml or NoXaml flavor where relevant.
- [ ] Description, confirmed cause, solution, expected result, and limitations are clear.
- [ ] WPF XAML, C# APIs, binding sources, theme resources, and project references are accurate.
- [ ] Examples are complete or explicitly labeled as fragments with insertion points.
- [ ] Security claims follow approved advisories and do not speculate.
- [ ] Accessibility and runtime claims are supported by the checks described.
- [ ] Customer information and secrets are removed.
- [ ] Internal slugs and external links are accurate.
