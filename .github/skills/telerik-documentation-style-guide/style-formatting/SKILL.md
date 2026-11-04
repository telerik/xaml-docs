---
name: style-formatting
description: "Use this skill when formatting Telerik UI for WPF documentation: UI labels, API references, keyboard shortcuts, paths, menus, admonitions, XAML and C# examples, external snippets, screenshots, and command-line instructions. Covers code context, WPF namespaces, accessible visuals, and platform-specific captures. Use when asked to 'format the article', 'fix formatting', 'add a note', 'add a screenshot', or 'check code blocks'."
---

# Element Formatting, Admonitions, and Visual Content

This skill defines how to format inline elements, admonitions (notes, tips, cautions), code blocks, screenshots, and command-line instructions in Telerik UI for WPF documentation. Preserve the repository's rendering syntax and each sample's technical meaning.

## Mandatory Structure and Image Checks

Read and apply [style-structure](../style-structure/SKILL.md), including its compliant/non-compliant examples and review/automated-fix acceptance criteria, during authoring, formatting reviews, audits, and Markdown remediation.

- [ ] Standard articles have exactly one `# Heading`; flag missing or multiple H1s and recommend one appropriate title or hierarchy-aware demotion of extras.
- [ ] KB articles (`knowledge-base/` or KB metadata) have zero H1s. Never add one; flag any H1 and recommend removing a duplicate generated title or demoting a genuine section. A KB starting at H2 is valid.
- [ ] Every image has a meaningful sentence or exact `>caption Description` block immediately before it, with only optional blank lines between. Flag missing, heading-only, bold-only, and heading-plus-caption-only introductions.

Report source locations and corrections without editing on review-only requests. When fixes are authorized, replace image-only headings and bold labels with prose or `>caption`, preserve sufficient introductions, image paths, alt text, genuine sections and anchors, and heading hierarchy. Rerun all checks and disclose unresolved cases. These rules override general bold-label or legacy screenshot-placement advice, but do not change code-example or table caption formatting.

## Why Consistent Formatting Matters

Consistent formatting acts as a visual language — readers learn to recognize bold as a UI element, monospace as code, and italic as a new term. Breaking these conventions forces readers to re-evaluate what each piece of text means.

## Inline Element Formatting

### UI Elements — Bold

Format all **user interface element names** in bold. This includes button labels, menu names, dialog box titles, tab names, checkbox labels, field names, and window titles.

```markdown
Select **Add** in the sample app to add an item to the RadGridView.
In Visual Studio, select **Project** > **Manage NuGet Packages**.
In the sample app, clear the **Show Details** checkbox.
```

**Bold syntax**: Always use asterisks to format bold text (`**bold text**`). Do not use the underscore syntax (`__bold text__`), which renders identically but reduces source readability and is inconsistent with the rest of the codebase.

| ❌ Wrong | ✅ Correct |
|---|---|
| `__Add__` | `**Add**` |
| `__Manage NuGet Packages__` | `**Manage NuGet Packages**` |

### Code References — Monospace

Format code elements in `monospace` (backticks). This includes **any mention of an API type, method, property, or member**, as well as enum values, parameters, file names, file extensions, XML/HTML tags, API endpoints, namespaces, and inline code expressions. Every API reference — no matter how brief — must appear in monospace.

```markdown
Declare the Telerik XML namespace in the XAML file that uses the control.
Set the `ItemsSource` property to your collection.
The `RadGridView` class displays tabular data.
Open the `MainWindow.xaml` file.
Set the window's `DataContext` before evaluating its bindings.
```

| ❌ Wrong | ✅ Correct |
|---|---|
| The RadGridView control displays items. | The `RadGridView` control displays items. |
| The RadGridView control displays items. | The `RadGridView` control displays items. |
| Set DataContext to the viewmodel. | Set `DataContext` to the viewmodel. |

### New Terms — Italic

Format a term in *italic* on its first occurrence in an article when introducing it as a concept. Do not italicize the term on subsequent occurrences.

```markdown
A *binding context* supplies the source object for bindings on a view.
An item template typically uses the item as its binding context.
```

### Keyboard Keys — Monospace

Format individual keyboard keys in monospace. Use `+` to combine keys in a keyboard shortcut. Do not add spaces around `+`.

```markdown
Press `Enter` to confirm.
Press `Ctrl`+`S` to save the XAML file in Visual Studio on Windows.
Press `Ctrl`+`Shift`+`P` to open the command palette.
```

### File Paths — Monospace

Format file paths in monospace:

```markdown
Open `MainWindow.xaml` in the WPF project.
Application-wide resources can be declared in `App.xaml`.
```

### Menu Sequences — Bold with Angle Brackets

Format menu navigation sequences with bold for each element and `>` as separator:

```markdown
In Visual Studio on Windows, select **Project** > **Manage NuGet Packages**.
In the SDKBrowser app, select **RadGridView** > **Getting Started**.
```

### Parameter Names in Instructions

When documenting command-line tools, use **bold** for literal parts (type exactly as shown) and *italic* for placeholders (user-supplied values):

```markdown
**dotnet** **add** **package** *package-name* **--version** *version-number*
```

For a command the reader can run, use a fenced shell block. Identify the working directory and replaceable values in the surrounding text. Never include a real license key or NuGet feed credential.

## Admonitions (Notes, Tips, Cautions)

Admonitions highlight important information that stands apart from the main text. Use the blockquote-based syntax specific to this documentation platform.

### Note

Use for supplementary information the reader should be aware of:

```markdown
> A note provides additional context that may be useful but is not critical to the task.
```

The repository also uses `>note` for explicitly labeled notes. Use the existing article's supported form; do not introduce GitHub alert syntax.

### Tip

Use for helpful suggestions that improve the reader's experience:

```markdown
>tip A tip provides a useful suggestion or shortcut.
```

Use the site's tip rendering rather than a custom HTML callout.

### Important / Caution

Use for warnings about potential issues, data loss, or breaking changes:

```markdown
>important An important note warns about potential issues or required prerequisites.
```

Use `>caution` or `>warning` only where supported by the documentation renderer and appropriate to the risk. Do not promise a particular label color or use color alone to communicate severity.

### Admonition Rules

- Place admonitions **after** the paragraph they relate to, not before.
- Do not stack multiple admonitions consecutively — separate them with regular text.
- Keep admonition text concise — one to three sentences.
- Do not use admonitions for routine information that belongs in the main text.
- A note that applies to every reader is probably not a note — it is main content.

## Code Blocks

### Fenced Code Blocks with Language

Always specify the language identifier after the opening triple backticks. WPF articles use `XAML` for markup and `C#` for application code; retain supported aliases such as `xml` and `csharp` when already used:

````markdown
```XAML
<telerik:RadGridView x:Name="dataGrid" />
```
````

Common language identifiers: `XAML`, `C#`, `csharp`, `xml`, `json`, `powershell`, `bash`. Use other languages only when the WPF scenario actually requires them.

### Code Block Rules

1. **Complete examples or explicit fragments** — State the filename, prerequisites, and insertion point. A full sample needs matching XAML and C# classes, models, data, resources, and handlers. Label partial examples as fragments.
2. **No line numbers in markdown** — The rendering engine adds line numbers if needed.
3. **No trailing whitespace** — Remove trailing spaces from code lines.
4. **Consistent indentation** — Use 4 spaces for new C# examples and consistent indentation for XAML/XML/JSON. Preserve the indentation of shared source snippets.
5. **Meaningful variable names** — Use descriptive names, not single letters (except loop counters).

### WPF Sample Context

For a window example, first establish the package or assembly references, license activation, and Xaml or NoXaml theme setup. The following `MainWindow.xaml` and code-behind fragments use the standard WPF presentation namespaces and assume the application has configured resources for its selected theme flavor:

```XAML
<Window x:Class="WpfDocs.MainWindow"
	xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
	Title="RadGridView sample"
	Height="450"
	Width="800">
	<Grid>
		<telerik:RadGridView x:Name="gridView" />
	</Grid>
</Window>
```

```C#
using System.Windows;

namespace WpfDocs;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
	}
}
```

Validate XAML against the actual WPF control APIs. Check namespace declarations, `x:Class`, named elements, resource keys, theme dictionaries, and supported properties. XML parsing alone cannot prove XAML compilation or binding correctness. For MVVM examples, verify `DataContext`, item contexts, notifications, `ICommand` parameters, and any toolkit or dependency-injection registration.

### Shared Snippet References

Keep external snippet placeholders intact unless the source change is part of the task. Resolve WPF documentation code placeholders from the canonical source root configured through `DOCS_CODE_ROOT_URL`, not from the `xaml-docs/snippets` folder. Search the configured root recursively by exact snippet ID or read the exact source path and region from the placeholder. An explicitly supplied local snippets folder can override the remote source.

```xml
<snippet id='snippet-id-from-article'/>
```

Verify the referenced code, not just the placeholder. If the configured source is unavailable or the exact snippet cannot be found, mark the reference unresolved and report the reason. Continue formatting work that does not depend on the missing code, but skip claims about code accuracy, behavior, or compilation. Do not invent snippet IDs or imply that an unresolved sample was verified. When showing markdown that contains fenced code, use a longer outer fence so the inner code remains inside the example.

### Code Comments in Examples

When code examples include comments:

- Write comments in **English**.
- Keep comments to **80 characters or fewer** per line.
- Use full sentences starting with a capital letter and ending with a period.
- Comment only what is not obvious from the code itself.

Do not add comments that narrate assignments or control creation. Explain setup and platform restrictions in the surrounding prose; preserve useful comments in resolved source snippets.

## Screenshots

Screenshots complement text but do not replace it. Every screenshot and other image must have a meaningful introductory sentence or exact `>caption` block immediately before it. Text only after an image is insufficient. Preserve an existing introduction when it explains the image's content or purpose.

### Screenshot Requirements

| Rule | Specification |
|------|--------------|
| Appearance | Default control theme and font size unless styling, dark theme, or text scaling is the subject; identify any deliberate variation |
| Background | White or the application's default background |
| Size | Maximum 1000 pixels wide |
| Format | PNG for UI screenshots, SVG for diagrams |
| Annotations | Arrows to point, boxes to surround areas of interest |
| Annotation style | Arial 16pt, primary color `#f56147` (Telerik red-orange) |
| Cropping | Show the relevant control and enough context; remove IDE, emulator, or OS chrome unless relevant |
| Personal data | Remove or redact any personal information, real email addresses, or real user names |
| Platform | Identify the Windows version and relevant display or theme settings when they affect the result |
| Accessibility | Provide a text equivalent; do not rely on color, annotation position, or a screenshot as proof of screen-reader support |

### Screenshot Placement

For a control article, use an existing image asset only when it accurately represents the documented WPF control and state:

```markdown
The RadGridView displays the sample records. Replace the image path below with an existing asset from the article's `images/` folder.

![RadGridView displaying the sample records](images/<existing-image-file>.png)
```

- Place screenshots **after** the text that describes them.
- Place a meaningful introductory sentence or exact `>caption Description` block immediately before each image, with only optional blank lines between.
- Never introduce an image with a heading or bold-only label, or a heading plus caption solely for the image. Replace image-only headings and bold labels with prose or `>caption` when fixes are authorized.
- Use descriptive alt text that explains what the screenshot shows.
- Store screenshot files in an `images/` subdirectory relative to the article.

## Tables

### When to Use Tables

Use tables for structured data with two or more columns and three or more rows. Do not use tables for simple lists or single-column data.

### Table Formatting

- Include a header row with descriptive column names.
- Align content to the left (default).
- Keep cell content concise — avoid long paragraphs in table cells.
- Introduce every table with a sentence ending in a colon or period.

```markdown
The following table distinguishes common data controls:

| Control | API Type | Data Shape |
|--------|-----------|-------------|
| GridView | `RadGridView` | Tabular data |
| TreeView | `RadTreeView` | Hierarchical items |
| ComboBox | `RadComboBox` | Selectable items |
```

## Quick Checklist

When reviewing an article for formatting, verify:

- [ ] Standard articles have exactly one H1; KB articles have zero H1s and never receive one
- [ ] Missing/multiple standard H1s and every KB H1 are reported or fixed while preserving hierarchy
- [ ] Every image has an immediate sentence or exact `>caption` block; no missing, heading-only, or bold-only introduction remains
- [ ] Existing sufficient introductions and genuine section anchors are preserved; fixes are revalidated
- [ ] UI elements (buttons, menus, tabs, fields) are in **bold**
- [ ] Bold uses `**` asterisk syntax, not `__` underscore syntax
- [ ] All API mentions (types, methods, properties, members) are in `monospace`
- [ ] Code elements (methods, classes, properties, file names) are in `monospace`
- [ ] New terms are in *italic* on first occurrence only
- [ ] Keyboard shortcuts use `Key`+`Key` format in monospace
- [ ] Menu sequences use **Menu** > **Item** format
- [ ] Notes use `>` syntax, tips use `>tip`, important items use `>important`, cautions use `>caution`, and warnings use `>warning`
- [ ] Admonitions follow related text, are concise, and are not stacked
- [ ] Code blocks specify the language identifier
- [ ] XAML namespaces, class names, resources, bindings, and control APIs match the target release
- [ ] C# examples include the required types, imports, setup, and event or command contracts
- [ ] External snippet IDs resolve to reviewed source; missing source or untested compilation is disclosed
- [ ] Nested markdown examples use longer outer fences
- [ ] Code comments are English, ≤80 chars, full sentences
- [ ] Screenshots have descriptive alt text and are ≤1000px wide
- [ ] Captures identify their platform and explain theme or scaling variations
- [ ] Text covers the workflow and accessibility details independently of screenshots and color
- [ ] Tables have header rows and introductory text
