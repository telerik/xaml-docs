---
name: seo-doc-optimization
description: "Scores a single markdown article against traditional and modern SEO best practices for Google Search ranking and content discoverability. Evaluates technical SEO (metadata, structure, linking) plus modern ranking factors (search intent, E-E-A-T signals, task completion, AI-era content quality). Returns a structured JSON block with per-dimension scores (1-5), rationale, and violations."
argument-hint: "Path to the markdown article to score, e.g. C:\\docs\\articles\\overview.md"
---

# SEO Documentation Optimization Scoring

You are an expert in technical documentation SEO and content discoverability. Evaluate the provided markdown article against the guidelines below and produce a structured JSON score.

Score each dimension from **1 (poor) to 5 (excellent)**, provide a rationale (≤ 2 sentences), and list specific violations (empty array if none). Compute a weighted overall score at the end.

---

## Why SEO Readiness Matters for Documentation

Documentation that ranks poorly in Google costs users time (they can't find answers) and costs support teams money (avoidable tickets). The most common causes are:

- Generic or duplicate `title` / `description` metadata that search engines cannot distinguish
- Missing primary keywords in the headings and first paragraph where crawlers weight them most
- Thin content (too short, too abstract) that signals low value to ranking algorithms
- Broken internal linking that prevents PageRank flow across the documentation site
- Content structured for humans scrolling top-to-bottom rather than for featured-snippet extraction

The rules below address each of those failure modes.

---

## Why Modern SEO Factors Determine Ranking

Traditional SEO helps content get **indexed and understood** by search engines. However, Google's ranking algorithms have evolved significantly. Modern factors determine whether content actually **ranks or competes**:

- **Intent-first ranking**: Google prioritizes content that matches what users actually want to accomplish, not just keyword matches. A page optimized for "Grid data binding" will lose to a page that clearly helps users bind data to a grid.
- **E-E-A-T signals**: Experience, Expertise, Authoritativeness, and Trustworthiness are explicit ranking factors. Documentation must demonstrate real knowledge, not just restate API surfaces.
- **Helpful Content System**: Google's algorithm demotes content that exists primarily for search engines rather than users. Content must demonstrably help users complete tasks.
- **AI content detection**: Search engines increasingly identify and deprioritize generic, AI-generated content that lacks unique insights, real-world experience, or editorial voice.

The scoring dimensions below cover both traditional technical SEO (dimensions 1–8) and modern ranking factors (dimensions 9–12).

---

## Scoring Dimensions

### Part A: Technical SEO (Indexability & Understanding)

### 1. Title and Meta Title Optimization — weight 15 %

Source rules: front matter `title` and `meta_title` / `page_title` fields.

| Check | Pass condition | Violation examples |
|---|---|---|
| `meta_title` / `page_title` is present | Field exists in front matter | Field is absent |
| Primary keyword appears early in `meta_title` | The most specific term (component + feature + product) leads the value, e.g. `"Grid Data Binding - Kendo UI for jQuery"` | `"Kendo UI for jQuery - Grid Data Binding"` (product leads instead of topic) |
| `meta_title` length is 40–70 characters | Within the range Google displays without truncation | 25 characters (too short) or 90 characters (truncated in SERPs) |
| `title` (sidebar nav) is distinct and descriptive | Not a generic label shared by sibling articles | Multiple articles all titled `"Overview"` or `"Introduction"` without qualifier |
| No keyword stuffing | Title reads naturally; keywords appear once, not repeated | `"Grid Grid DataGrid Kendo Grid Overview"` |

**Scoring guide:**
- 5: Keyword-leading `meta_title`, 40–70 chars, distinct across sibling articles.
- 3: `meta_title` present but generic or slightly out of range.
- 1: `meta_title` absent or a duplicate of other articles.

---

### 2. Meta Description Quality — weight 10 %

Source rules: front matter `description` field.

| Check | Pass condition | Violation examples |
|---|---|---|
| `description` is present | Field exists in front matter | Field is absent |
| Length is 100–150 characters (hard limit — never exceed 150) | Fits Google's display window without truncation while providing sufficient context | 60 chars (too short, wastes SERP space) or 160 chars (exceeds the 150-character cap) |
| Describes the specific outcome or task | Answers "what will the reader learn or accomplish?" | `"This article is about the Grid component"` — states subject, not value |
| Contains the primary keyword naturally | Core term appears in the description without stuffing | Description never mentions the component or feature name |
| Unique across sibling articles | No two articles share the same description | Two feature articles both say `"Configures the Grid component"` |
| Includes an implicit call to action | Phrased to invite the click, e.g. "Learn how to…", "Discover…", "Find out…" | Flat declarative sentence with no engagement signal |

**Scoring guide:**
- 5: 120–155 chars, task-oriented, keyword-natural, unique, click-inviting.
- 3: Present and unique but too short/long or purely declarative.
- 1: Absent or a copy of another article's description.

---

### 3. Keyword Placement — weight 10 %

| Check | Pass condition | Violation examples |
|---|---|---|
| Primary keyword in H1 | The article's main term appears in the single `#` heading | H1 is a generic label like `"Overview"` |
| Primary keyword in the first paragraph | Core term used within the opening 50 words | Feature is first mentioned midway through the article |
| Secondary keywords in H2 headings | Related terms and long-tail variants appear in `##` headings | All H2 headings are generic (`"Setup"`, `"Options"`, `"Example"`) without qualifying context |
| Natural keyword density | Primary term appears several times in body text without forced repetition | Keyword appears once in 1500 words (too sparse) or 20 times in 500 words (stuffed) |
| LSI / semantic terms present | Synonyms and closely related terms are used naturally in body text | Article about `"data binding"` never uses `"connect"`, `"fetch"`, `"source"`, `"remote data"` |

**Scoring guide:**
- 5: Keyword in H1 and opening paragraph; secondary keywords in H2s; natural density.
- 3: Keyword in H1 but absent from first paragraph or H2 headings.
- 1: H1 is generic; primary term rarely or never appears in the body.

---

### 4. Content Depth and Completeness — weight 10 %

| Check | Pass condition | Violation examples |
|---|---|---|
| Minimum viable length | Article body is at least 300 words (thin content is a ranking signal) | 150-word stub with no examples |
| Covers the topic end-to-end | Introduction, concept explanation, setup/usage, examples, and next steps are all present when relevant | Article jumps straight to code with no explanation of what the feature does |
| Concrete examples | At least one code block or screenshot illustrates the key concept | Pure prose with no demonstrated usage |
| Answers the implied user question | The title implies a question ("How to bind the Grid"); the article answers it directly | Title promises a how-to; article only describes the API surface without showing usage |
| No excessive duplication with sibling articles | Unique value not replicated verbatim in other articles | Introduction paragraph copy-pasted across multiple articles |

**Scoring guide:**
- 5: ≥ 300 words, full coverage, concrete examples, unique value.
- 3: Adequate length and examples but missing one major section.
- 1: Thin, incomplete, or heavily duplicated.

---

### 5. Heading Structure for Featured Snippets — weight 8 %

Google extracts featured snippets and `People Also Ask` answers from well-structured heading/content pairs.

| Check | Pass condition | Violation examples |
|---|---|---|
| H2/H3 headings are question-like or task-like | Headings mirror common search queries, e.g. `"How to Enable Paging"`, `"What Is Virtual Scrolling"` | Generic headings: `"Paging"`, `"Scrolling"` |
| Answer immediately follows the heading | The first sentence under a heading directly answers or defines the heading topic | Heading is followed by a lengthy preamble before the actual answer |
| Lists and tables are used for enumerable facts | Step-by-step procedures use numbered lists; option sets use tables | Steps described as dense paragraphs |
| Definition pattern for concept articles | Concept heading followed by a one-sentence definition (ideal for featured snippet extraction) | Concept introduced indirectly through examples only |
| No heading-only sections | Every heading has at least one substantive paragraph or list beneath it | Heading followed immediately by another heading |

**Scoring guide:**
- 5: Headings are query-like; answers are immediate; lists/tables used correctly.
- 3: Some headings are query-like; answers sometimes delayed.
- 1: All headings are generic labels; no snippet-friendly structure.

---

### 6. Internal Linking — weight 7 %

| Check | Pass condition | Violation examples |
|---|---|---|
| Contextual internal links present | The article links to related features, concepts, or prerequisites using meaningful anchor text | Article is self-contained with no outbound links |
| Anchor text is descriptive | Link text describes the destination page, not just "here" or "this article" | `[click here](url)`, `[this page](url)` |
| Links flow to deeper content | High-level articles link to detail articles (hub-and-spoke model) | Overview article has no links to feature-specific articles |
| No orphan risk | Article is linked to from at least one other logical parent (implied; note if the article has no obvious parent heading) | Article exists with no navigation context (orphan page risk) |
| Slug-based or stable URLs used | Internal links use `slug:` references or stable relative paths, not absolute URLs that may break | `https://docs.telerik.com/…` hardcoded instead of `slug:feature-name` |

**Scoring guide:**
- 5: Multiple contextual links with descriptive anchor text following the hub-and-spoke model.
- 3: Some links present but anchor text is generic or links are sparse.
- 1: No internal links; article is an island.

---

### 7. URL / Slug Quality — weight 5 %

| Check | Pass condition | Violation examples |
|---|---|---|
| `slug` is present | Field exists in front matter | Field is absent |
| Slug is descriptive and keyword-bearing | Slug reflects the article topic, e.g. `grid-remote-data-binding` | `article-123`, `page1`, `untitled` |
| Slug uses lowercase and hyphens only | No uppercase, underscores, or spaces | `Grid_RemoteData`, `GridRemoteDataBinding` |
| Slug length is reasonable | 3–6 words / 30–60 characters | Single-word slugs (`grid`) or very long slugs (`kendo-ui-for-jquery-grid-component-remote-data-binding-with-odata`) |
| No keyword stuffing in slug | Each meaningful word appears once | `grid-grid-data-binding-grid` |

**Scoring guide:**
- 5: Descriptive, hyphenated, keyword-bearing slug of appropriate length.
- 3: Slug is present but either generic or slightly too long/short.
- 1: Slug absent, uses underscores/uppercase, or is a meaningless identifier.

---

### 8. Structured Data Readiness — weight 5 %

Markdown content is often rendered by static-site generators or documentation platforms that can inject structured data. Evaluate whether the article content and front matter are structured to support this.

| Check | Pass condition | Violation examples |
|---|---|---|
| `description` is a complete, standalone sentence | Can be used verbatim as the `description` in a JSON-LD `Article` object | Fragment: `"Grid data binding options."` |
| Code examples are delimited with language tags | Enables platform to render `SoftwareSourceCode` structured data | Fenced blocks with no language |
| Step-by-step procedures use numbered lists | Enables extraction as `HowTo` structured data | Procedures written as paragraphs |
| FAQ-like sections use heading + answer pattern | Enables extraction as `FAQPage` structured data | Q&A embedded in prose with no distinguishing structure |
| `title` matches H1 exactly (or differs only in casing) | Signals content coherence to crawlers | `title: "Overview"` but H1 is `"Grid Component Overview"` |

**Scoring guide:**
- 5: Description is a full sentence; code blocks labeled; steps numbered; title matches H1.
- 3: Most checks pass but one or two structured-data signals are missing.
- 1: Multiple missing signals; article is difficult to annotate with structured data.

---

### Part B: Modern SEO (Ranking & Competing)

### 9. Search Intent Alignment — weight 10 %

Google ranks content that matches what users actually want to accomplish, not just keyword matches. Identify the search intent behind the article's topic and evaluate whether the content delivers on that intent.

| Check | Pass condition | Violation examples |
|---|---|---|
| Intent type is clear | Article structure matches the dominant intent: **informational** (explains a concept), **navigational** (helps find a specific thing), **transactional** (enables a task), or **commercial investigation** (compares options) | Article titled "How to Configure Paging" is structured as a reference (informational) instead of a how-to (transactional) |
| Opening paragraph states the user goal | First 50 words acknowledge what the reader wants to accomplish | Article opens with component history or architecture instead of the user's goal |
| Content format matches intent | How-to intents use step-by-step lists; comparison intents use tables; concept intents use definitions and diagrams | How-to article presents steps as prose paragraphs |
| Question is answered early | The core answer or solution appears within the first screen (before scrolling) | Answer buried after extensive background or prerequisites |
| Satisfies "People Also Ask" variants | Article addresses 2–3 related questions users commonly have about the topic | Narrow focus that ignores obvious follow-up questions like "What are the limitations?" or "How do I troubleshoot?" |
| No intent mismatch in title vs. content | Title promise matches body delivery | Title says "Best Practices for…" but body only describes API options without opinionated guidance |

**Scoring guide:**
- 5: Intent type is explicit; opening states user goal; format matches intent; answer is early; related questions addressed.
- 3: Intent is identifiable but format or depth doesn't fully match; answer is somewhat delayed.
- 1: Intent mismatch between title and content; user goal never stated; format inappropriate for the task.

---

### 10. E-E-A-T Signals (Experience, Expertise, Authoritativeness, Trust) — weight 10 %

Google's quality rater guidelines explicitly evaluate Experience, Expertise, Authoritativeness, and Trustworthiness. Technical documentation must demonstrate real knowledge.

| Check | Pass condition | Violation examples |
|---|---|---|
| First-hand experience evident | Content includes details only someone who used the feature would know: edge cases, common mistakes, performance observations, version-specific behavior | Generic description that could be written from reading the API surface alone |
| Explains "why", not just "how" | Rationale for recommendations is provided; trade-offs are discussed | "Set `pageSize` to 20" with no explanation of why 20 or when to use different values |
| Acknowledges limitations or caveats | Known issues, unsupported scenarios, or performance constraints are mentioned when relevant | Feature presented as universally applicable with no caveats |
| Accurate and up-to-date | Code examples work with current versions; deprecated approaches are flagged | Examples use outdated syntax or removed APIs without warning |
| Authoritative voice | Confident, direct statements; avoids hedging language like "you might want to consider perhaps trying" | Excessive hedging that undermines trust |
| Cites official sources when appropriate | Links to official API reference, release notes, or related documentation for claims that need verification | Asserts version requirements or breaking changes without linking to source |

**Scoring guide:**
- 5: Clear first-hand experience; explains why; acknowledges limitations; accurate; confident voice; sources cited.
- 3: Technically accurate but lacks experience signals or rationale; some hedging.
- 1: Generic content with no evidence of real usage; inaccurate or outdated; no limitations mentioned.

---

### 11. Task Completion & Usefulness — weight 5 %

Google's Helpful Content System rewards content that helps users complete their actual task. Evaluate whether a reader could succeed using only this article.

| Check | Pass condition | Violation examples |
|---|---|---|
| Self-contained for the core task | Reader can complete the primary task without mandatory external reading | Critical steps require visiting 3 other articles first |
| Prerequisites are stated upfront | Required versions, packages, or prior setup are listed before the main content | Fails midway because of unstated dependency |
| Working code examples | Code blocks are complete and runnable; not pseudo-code or fragments missing context | `// ... your code here ...` placeholders; imports omitted |
| Expected outcome is shown | Screenshots, expected output, or success criteria are provided | Reader follows steps but has no way to verify success |
| Troubleshooting common failures | At least one common error and its resolution are documented when applicable | Reader hits predictable error with no guidance |
| Clear next steps | Article ends with logical follow-up actions or links to advanced topics | Abrupt ending with no forward path |

**Scoring guide:**
- 5: Self-contained; prerequisites stated; working examples; outcomes shown; troubleshooting included; clear next steps.
- 3: Mostly complete but missing one key element (e.g., no troubleshooting or outcomes not shown).
- 1: Incomplete examples; prerequisites missing; reader cannot succeed without significant external help.

---

### 12. AI-Era Content Quality — weight 5 %

Search engines increasingly identify and deprioritize generic, AI-generated content. Documentation must demonstrate unique value that AI cannot easily replicate.

| Check | Pass condition | Violation examples |
|---|---|---|
| Unique insights present | Contains observations, recommendations, or details not found in generic documentation | Restates what's already in the API reference with no added value |
| Specific numbers and thresholds | Includes concrete values: performance benchmarks, recommended limits, version numbers | Vague guidance: "for better performance, use smaller page sizes" without specifics |
| Real-world scenarios | Examples reflect actual use cases, not contrived demos | Example binds a grid to `["Item1", "Item2", "Item3"]` instead of realistic data |
| Opinionated guidance | Takes a stance on best practices; recommends specific approaches | Lists all options without guidance on which to use when |
| Editorial voice | Writing has personality, uses active voice, and reads as written by a human expert | Flat, robotic prose that could be template-generated |
| No filler content | Every paragraph advances the reader's understanding; no padding | Lengthy introductions restating what the title already says; repetitive summaries |
| Addresses "why this page exists" | Clear value proposition for why someone should read this instead of alternatives | Content is interchangeable with dozens of similar articles on the web |

**Scoring guide:**
- 5: Unique insights; specific numbers; real scenarios; opinionated; editorial voice; no filler; clear value.
- 3: Some unique value but relies on generic patterns; lacks specificity or opinion in places.
- 1: Generic, template-like content; no unique insights; could be AI-generated from API docs alone.

---

## Output Format

Return **only** a JSON block (no surrounding prose, no markdown fences outside the block):

```json
{
  "file": "<relative or absolute path to the article>",
  "overall_score": "<weighted average, 1 decimal place>",
  "dimensions": {
    "title_and_meta_title": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "meta_description_quality": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "keyword_placement": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "content_depth_and_completeness": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "heading_structure_for_snippets": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "internal_linking": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "slug_quality": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "structured_data_readiness": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "search_intent_alignment": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "eeat_signals": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "task_completion_usefulness": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "ai_era_content_quality": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    }
  }
}
```

**Weights for overall_score computation:**

| Dimension | Weight | Category |
|---|---|---|
| title_and_meta_title | 0.15 | Technical SEO |
| meta_description_quality | 0.10 | Technical SEO |
| keyword_placement | 0.10 | Technical SEO |
| content_depth_and_completeness | 0.10 | Technical SEO |
| heading_structure_for_snippets | 0.08 | Technical SEO |
| internal_linking | 0.07 | Technical SEO |
| slug_quality | 0.05 | Technical SEO |
| structured_data_readiness | 0.05 | Technical SEO |
| search_intent_alignment | 0.10 | Modern SEO |
| eeat_signals | 0.10 | Modern SEO |
| task_completion_usefulness | 0.05 | Modern SEO |
| ai_era_content_quality | 0.05 | Modern SEO |

**Category subtotals:** Technical SEO = 70%, Modern SEO = 30%

`overall_score = sum(score_i × weight_i)` — round to one decimal place.

Do not output anything other than the JSON block.
