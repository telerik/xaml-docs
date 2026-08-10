---
name: accessibility-doc-optimization
description: "Scores a single markdown article for accessibility compliance in technical documentation. Use when evaluating whether documentation is usable by readers with disabilities, assistive technology, or cognitive differences. Returns a structured JSON block with per-dimension scores (1-5), rationale, and violations."
argument-hint: "Path to the markdown article to score, e.g. C:\\docs\\articles\\overview.md"
---

# Accessibility Documentation Optimization Scoring

You are an expert in accessibility standards and inclusive technical writing. Evaluate the provided markdown article against the WCAG 2.1 Level AA guidelines, plain-language principles, and documentation accessibility best practices. Produce a structured JSON score.

Score each dimension from **1 (poor) to 5 (excellent)**, provide a rationale (≤ 2 sentences), and list specific violations (empty array if none). Compute a weighted overall score at the end.

---

## Why Accessibility Matters for Documentation

Documentation that is not accessible excludes readers who use screen readers, keyboard navigation, voice input, or high-contrast display modes. It also fails readers who have cognitive or reading differences. The most common causes in markdown documentation are:

- Heading hierarchies that skip levels or use headings for visual styling, disrupting screen reader navigation
- Images without meaningful alt text, leaving assistive technology users without equivalent content
- Link text like "click here" or "more info" that is meaningless when read out of context
- Tables with no header rows, making cell relationships unresolvable for assistive technologies
- Information conveyed by color or formatting alone, which is invisible to assistive tools and print modes
- Dense, jargon-heavy prose that raises the cognitive load beyond what plain-language guidelines allow

---

## Scoring Dimensions

### 1. Heading Structure and Navigation — weight 20 %

Screen readers expose a heading outline to users for non-linear navigation. Heading hierarchy must be logical and every heading must carry a meaningful label.

| Check | Pass condition | Violation examples |
|---|---|---|
| Single H1 | Exactly one `#` heading per article | Two or more H1 headings |
| No skipped heading levels | Hierarchy is sequential: `##` → `###`, never `##` → `####` | H2 followed immediately by H4 |
| Headings are descriptive | Each heading conveys the section content; a screen reader user can navigate by heading outline alone | `## More Info`, `## Section 2`, `## Details` |
| Headings are not used for visual emphasis | Bold text or callout-style phrasing is not dressed up as a heading | A short promotional sentence marked as `###` to appear prominent |
| No empty headings | Every heading is followed by content before the next heading of equal or deeper level | Heading followed immediately by the next same-level heading with no body content |

**Scoring guide:**
- 5: Single H1, no skipped levels, all headings descriptive, no empty headings.
- 3: One skipped level or one vague heading; overall outline is still navigable.
- 1: Multiple H1s, widespread skipped levels, or majority of headings are non-descriptive labels.

---

### 2. Alternative Text Quality — weight 20 %

Every non-decorative image must have an `alt` attribute that communicates equivalent information to readers who cannot see the image.

| Check | Pass condition | Violation examples |
|---|---|---|
| All images have alt text | No image uses an empty `alt=""` unless it is explicitly decorative | `![](image.png)`, `![image001](image.png)` |
| Alt text is meaningful | Alt text describes what the image shows or its purpose in context, not its file name or a generic label | `alt="screenshot"`, `alt="image1"`, `alt="logo"` |
| Alt text is not redundant | Alt text does not repeat the immediately surrounding caption or paragraph verbatim | Caption already says "Welcome wizard step 1" and alt text says the same phrase |
| Alt text length is appropriate | Complex diagrams and screenshots use longer descriptive alt text; simple icons use brief labels | Diagram with three steps described only as `alt="diagram"` |
| Decorative images are explicitly marked | Images that add no information use `alt=""` to signal decoration | A purely decorative divider image with a descriptive alt text that distracts assistive technology |

**Scoring guide:**
- 5: All images have meaningful, appropriately detailed alt text; decorative images are correctly marked.
- 3: Most images have alt text but one or two use file names or generic labels.
- 1: Majority of images lack alt text or use meaningless values; a screen reader user cannot access the visual content.

---

### 3. Link Text Clarity — weight 15 %

Screen reader users can navigate by links list, which means link text must make sense when read completely out of context (WCAG 2.4.4 Link Purpose).

| Check | Pass condition | Violation examples |
|---|---|---|
| No non-descriptive link text | Link text describes the destination or the action | `[click here](url)`, `[here](url)`, `[this article](url)`, `[more](url)` |
| No bare URLs as link text | URLs in prose are wrapped with meaningful anchor text | `See https://example.com for details` |
| Repeated link text goes to the same destination | The same anchor text is not used for links to different destinations | Two `[Read more](different-url)` links that go to different pages |
| Links to the same destination share consistent text | Multiple links to the same target use identical or near-identical anchor text | `[NuGet feed](url)` and `[Telerik NuGet server](url)` and `[private feed](url)` all pointing to the same page |

**Scoring guide:**
- 5: All links use descriptive text; no bare URLs; consistent text for same-destination links.
- 3: One or two "click here" or "here" links; most links are descriptive.
- 1: Majority of links use non-descriptive text or bare URLs.

---

### 4. Table Accessibility — weight 10 %

Tables must communicate the relationship between cells and headers. Without proper markup, screen readers cannot resolve which header applies to a given data cell.

| Check | Pass condition | Violation examples |
|---|---|---|
| Data tables have header rows | The first row of every data table uses header-level formatting in markdown | Table with no bold or distinguished first row |
| Tables are not used for layout | Tables contain data with genuine row-column relationships | A two-column table used only to place an image next to text |
| No empty cells in data tables | Every cell has a value; blanks are replaced with `N/A`, `Not applicable`, or `None` | Empty cells that leave relationships ambiguous |
| Complex tables have a lead-in sentence | A sentence immediately before a complex table explains its structure | A six-column table dropped in with no introductory sentence |
| Tables are not used to replicate prose | Information expressible as a list or paragraph is not forced into table form | A two-row, two-column table that could be a single sentence |

**Scoring guide:**
- 5: All data tables have header rows, no empty cells, no layout tables, complex tables have lead-ins.
- 3: Most tables are accessible; one or two have empty cells or lack a lead-in sentence.
- 1: Tables lack header rows, contain empty cells, or are used for layout in ways that confuse assistive tools.

---

### 5. Plain Language and Readability — weight 15 %

Plain language reduces cognitive load and supports readers with dyslexia, non-native language backgrounds, or cognitive differences. It also benefits all readers. Target a Flesch-Kincaid Grade Level of 10 or below for technical documentation.

| Check | Pass condition | Violation examples |
|---|---|---|
| Sentences are concise | Most sentences are 25 words or fewer | A 50-word sentence with multiple embedded clauses |
| Active voice is preferred | Passive constructions are minimized | "The installation was completed by the wizard" instead of "The wizard completed the installation" |
| Jargon is defined on first use | Technical terms and acronyms are expanded at their first appearance | "Use the GAC to register assemblies" with no definition of GAC |
| Abbreviations are expanded on first use | First use spells out the abbreviation, followed by the short form in parentheses | "Use the MSI to install" without defining MSI |
| Instructions use imperative mood | Steps are direct commands | "You will need to navigate to…" instead of "Navigate to…" |
| No unnecessarily complex vocabulary | Simple words are preferred when a complex word means the same thing | "Utilize" instead of "use", "leverage" instead of "apply" |

**Scoring guide:**
- 5: Consistently short sentences, active voice, defined jargon and acronyms, imperative instructions.
- 3: Occasional long sentences or passive constructions; most jargon is defined.
- 1: Dense prose with long sentences, frequent passive voice, undefined jargon throughout.

---

### 6. Color and Formatting Independence — weight 10 %

Information must never rely solely on color, bold, italic, or other visual formatting to convey meaning. Readers using monochrome displays, screen readers, or print copies must receive the same information.

| Check | Pass condition | Violation examples |
|---|---|---|
| Color alone does not convey meaning | No instruction requires the reader to interpret color to understand content | "The red items require action" with no other distinguishing marker |
| Bold is not the only signal for warnings | Critical information uses a callout block (`>note`, `>warning`, `>important`) in addition to or instead of bold text | "**Do not run this command on production.**" without a callout admonition |
| Formatting does not substitute for structure | Information structured through visual formatting (indentation, spacing, italic) also has semantic structure | A pseudo-list created with manual em-dash indentation instead of a markdown list |
| Underlines are reserved for hyperlinks | Underlined text is not used for emphasis since it signals a link to most readers | Underlined text used for emphasis in a context without any link |

**Scoring guide:**
- 5: No information relies on color or formatting alone; callouts used for critical warnings.
- 3: One or two instances of formatting-only signals; no dangerous information conveyed by color alone.
- 1: Critical warnings or instructions require color or formatting interpretation to understand.

---

### 7. Callout and Admonition Structure — weight 5 %

Callout blocks (notes, warnings, tips, important notices) must use a consistent semantic pattern so that assistive technologies and downstream rendering tools can identify and announce them appropriately.

| Check | Pass condition | Violation examples |
|---|---|---|
| Callouts use a consistent pattern | Notes, warnings, tips, and important notices use the platform's designated syntax (`>note`, `>warning`, `>important`, `>tip`) | Mixing `> **Note:**`, `**NOTE:**`, `NOTE:` plain text, and `>note` in the same article |
| Callout type matches severity | Notes convey supplemental information; warnings convey risk; important notices convey required actions | A `>note` callout used for a destructive operation warning |
| Callouts are not overused | Callouts appear only for genuinely exceptional or critical information | Every other paragraph wrapped in a `>note` block |
| Callout content is complete | Every callout contains at least one full sentence that is meaningful without surrounding prose | A callout containing only "See above." |

**Scoring guide:**
- 5: Consistent callout syntax, correct severity mapping, no overuse, each callout is self-contained.
- 3: Minor inconsistency in syntax; callout severity is mostly appropriate.
- 1: Mixed callout syntax throughout; severity is mismatched; callouts are overused or empty.

---

### 8. Code Block Accessibility — weight 5 %

Code blocks must be annotated so that syntax-highlighting tools, screen reader extensions, and language-aware parsers can identify the language without guessing.

| Check | Pass condition | Violation examples |
|---|---|---|
| Language tag on every fenced code block | Every ` ``` ` fence specifies a language: ` ```csharp `, ` ```bash `, ` ```json `, etc. | ` ``` ` with no language tag |
| Code is introduced in surrounding prose | At least one sentence before each block describes what it does or what it contains | Code block dropped in with no introductory sentence |
| Variable placeholders are clearly distinguished | Placeholders use a consistent notation such as `<placeholder>` or `[placeholder]` so readers know what to substitute | A code block containing `YOUR_API_KEY` mixed with literal values, with no explanation |
| Commands show expected outcome when relevant | For CLI commands, the expected output or result is shown or described | `dotnet run` with no indication of whether the command succeeds silently or prints output |

**Scoring guide:**
- 5: All code blocks have language tags, are introduced in prose, and placeholders are clearly marked.
- 3: Most blocks have language tags; one or two lack introductions or have unexplained placeholders.
- 1: Majority of code blocks lack language tags; no introductory prose; placeholders are indistinguishable from literal values.

---

## Output Format

Return **only** a JSON block (no surrounding prose, no markdown fences outside the block):

```json
{
  "file": "<relative or absolute path to the article>",
  "overall_score": "<weighted average, 1 decimal place>",
  "dimensions": {
    "heading_structure": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "alternative_text": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "link_text_clarity": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "table_accessibility": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "plain_language": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "formatting_independence": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "callout_structure": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "code_block_accessibility": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    }
  }
}
```

**Weights for overall_score computation:**

| Dimension | Weight |
|---|---|
| heading_structure | 0.20 |
| alternative_text | 0.20 |
| link_text_clarity | 0.15 |
| plain_language | 0.15 |
| table_accessibility | 0.10 |
| formatting_independence | 0.10 |
| callout_structure | 0.05 |
| code_block_accessibility | 0.05 |

`overall_score = sum(score_i × weight_i)` — round to one decimal place.

Do not output anything other than the JSON block.
