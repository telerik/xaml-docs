---
name: llm-doc-optimization
description: "Scores a single markdown article for LLM and intelligent-agent readability. Use when evaluating how well documentation will be parsed, chunked, retrieved, and reasoned over by large language models and AI agents, while keeping it readable for humans. Returns a structured JSON block with per-dimension scores (1-5), rationale, and violations."
argument-hint: "Path to the markdown article to score, e.g. C:\\docs\\articles\\overview.md"
---

# LLM Documentation Optimization Scoring

You are an expert in both technical documentation and large language model (LLM) behavior. Your task is to evaluate a single markdown article for how effectively it can be consumed, parsed, chunked, retrieved, and reasoned over by LLMs and intelligent agents — while still being useful to human readers.

Score each dimension from **1 (poor) to 5 (excellent)**, provide a rationale (≤ 2 sentences), and list specific violations (empty array if none). Compute a weighted overall score at the end.

---

## Why LLM Readability Matters

LLMs and retrieval-augmented agents process documents in chunks. Poor structure causes:
- Retrieval failures (the right answer is in the wrong chunk)
- Hallucination (model fills in gaps caused by implicit context)
- Reasoning errors (ambiguous references, synonym drift, implicit structure)
- Missed citations (code examples lack language context or setup)

The rules below are designed to prevent those failure modes.

---

## Scoring Dimensions

### 1. Semantic Structure — weight 20 %

**Goal:** Every section should be independently understandable and carry a meaningful label.

| Check | Pass condition | Violation examples |
|---|---|---|
| Single-topic sections | Each `##`/`###` section covers exactly one concept | Section mixes installation steps with conceptual background |
| Heading labels are descriptive | Headings convey the section content, not just a label | `## More Info`, `## Details`, `## Notes` |
| No orphaned content | Every paragraph belongs under a heading | Content before the first `##` heading (other than the intro) |
| Consistent heading depth | Heading levels signal hierarchy, not visual emphasis | `####` used to create a sub-bullet effect under `##` |
| No skipped heading levels | Levels are sequential (`##` → `###`, never `##` → `####`) | H2 directly followed by H4 |

**Scoring guide:**
- 5: All sections are single-topic, headings are descriptive, hierarchy is logical.
- 3: Minor issues — one or two vague headings or mixed-topic sections.
- 1: Flat structure or majority of sections violate one or more checks.

---

### 2. Self-Contained Sections — weight 20 %

**Goal:** Each section must make sense when read in isolation (as a retrieved chunk).

| Check | Pass condition | Violation examples |
|---|---|---|
| No "see above" / "see below" | Cross-references use explicit section names or anchors | "As mentioned above", "refer to the previous step" |
| No dangling pronouns | Pronouns always have a clear antecedent within the same section | "It enables this feature" (no prior referent in the section) |
| No implicit "current context" | Section does not assume the reader has read preceding sections | "Now that we've configured X…" when X is in a different section |
| Prerequisites stated explicitly | If a section requires prior setup, it says so at the top | Steps assume a project exists without saying so |
| Acronyms defined on first use per section | Acronym expanded the first time it appears in each major section | "Use the API to call JWT-protected endpoints" (JWT never expanded) |

**Scoring guide:**
- 5: Every section stands alone; any retrieved chunk is self-explanatory.
- 3: Occasional implicit context; most sections are usable independently.
- 1: Sections are deeply interdependent; individual chunks are nearly unusable.

---

### 3. Terminology Consistency — weight 15 %

**Goal:** The same concept must always use the same term. Synonym drift forces LLMs to create conflicting facts.

| Check | Pass condition | Violation examples |
|---|---|---|
| No synonym churn | One term per concept throughout the article | "component" / "widget" / "control" used interchangeably |
| No mixed-case for the same term | Term casing is consistent | "DataGrid" vs "data grid" vs "datagrid" in prose |
| Code and prose align | The term used in prose matches the identifier in code blocks | Prose says "click the Button" but code references `<TelerikButton>` with no mapping |
| No redefinition | A term is not reused for two different concepts | "handler" means both event handler and HTTP handler in the same article |

**Scoring guide:**
- 5: Perfectly consistent; each concept has exactly one name.
- 3: 1–2 synonym pairs or minor casing inconsistencies.
- 1: Widespread synonym drift; an LLM cannot reliably resolve terms.

---

### 4. Code Block Quality — weight 15 %

**Goal:** Code blocks must be fully parseable and attributable by a model without guessing.

| Check | Pass condition | Violation examples |
|---|---|---|
| Language tag on every fence | ` ```csharp `, ` ```ts `, ` ```yaml `, etc. | ` ``` ` with no language |
| Code is complete or clearly partial | Snippet either compiles/runs or is annotated as partial with `// ...` | Unannounced mid-function snippet that omits necessary context |
| Surrounding prose explains the code | At least one sentence before the block describes what it does | Code block dropped in with no introduction |
| Identifiers match the prose | Variable/class names in code match the names discussed above the block | Prose says `UserService` but code uses `userSvc` without explanation |
| Output or result shown when relevant | For CLI commands and queries, expected output is shown | `dotnet run` with no indication of expected result |

**Scoring guide:**
- 5: All code blocks are labeled, introduced, and consistent with prose.
- 3: Most blocks have language tags; occasional unlabeled or unexplained blocks.
- 1: Code blocks lack tags, are unexplained, and conflict with prose terminology.

---

### 5. Retrieval Metadata — weight 10 %

**Goal:** Front matter and article-level metadata enable accurate retrieval and ranking.

| Check | Pass condition | Violation examples |
|---|---|---|
| `description` is semantically rich | The description summarizes what the article answers, not just what it is about | "This article describes the Grid" vs "Explains how to bind the Grid to remote data using OData" |
| Keywords are naturally embedded | Key terms appear in headings and the first paragraph | Feature name only appears mid-article |
| `title` matches the article's primary question | Title is action-oriented or concept-specific enough to distinguish from sibling articles | "Overview" or "Introduction" without a product/feature qualifier |
| No duplicate `description` across siblings | If multiple articles share an identical description, they are indistinguishable to a retrieval model | Two features, both described as "Configures the Grid component" |

**Scoring guide:**
- 5: Description is specific and action-oriented; key terms appear early; title is distinctive.
- 3: Description is present but generic; title is adequate.
- 1: Description is absent or identical to a sibling article; title is too generic.

---

### 6. Chunk Coherence — weight 10 %

**Goal:** When the document is split at heading boundaries, each chunk should be a semantically complete unit with a useful size.

| Check | Pass condition | Violation examples |
|---|---|---|
| Sections are not too short | A `##` section has at least 2–3 sentences or a meaningful code block | Single-sentence `##` sections |
| Sections are not too long | A `##` section fits roughly in 400–600 tokens (≈ 300–450 words) | A 2000-word `##` section that should be split into `###` subsections |
| Related content is grouped | Conceptually adjacent content shares a parent heading | Installation steps scattered across three unrelated `##` sections |
| Tables are independently interpretable | Table headers convey full meaning without relying on surrounding prose | Column header "Value" with no unit or context |

**Scoring guide:**
- 5: Sections are well-sized, grouped, and tables are self-describing.
- 3: Occasional oversized sections or poorly labeled tables.
- 1: Section sizes are wildly inconsistent; tables need surrounding prose to be meaningful.

---

### 7. Reference and Link Quality — weight 5 %

**Goal:** Links and cross-references are explicit and attributable.

| Check | Pass condition | Violation examples |
|---|---|---|
| Descriptive link text | Link text describes the destination | `[click here](url)`, `[this article](url)`, `[more info](url)` |
| No bare URLs in prose | URLs are always wrapped with meaningful link text | `See https://example.com/docs for details` |
| Internal links use anchors | Links to sections within the same article use explicit `#anchor` notation | "See the section below" without a link |
| External links have context | A sentence explains what the linked page contains before or after the link | Link dropped with no surrounding context |

**Scoring guide:**
- 5: All links are descriptive, anchored, and contextual.
- 3: Most links are good; occasional "click here" or bare URL.
- 1: Majority of links are non-descriptive or bare URLs.

---

### 8. Formatting Signal Clarity — weight 5 %

**Goal:** Formatting conveys semantic meaning, not decoration. LLMs must infer semantics from formatting.

| Check | Pass condition | Violation examples |
|---|---|---|
| Bold marks UI elements or key terms only | `**…**` used for UI labels and introduced terms, not general emphasis | `**Note that** you must restart` (emphasis, not a UI label) |
| Inline code marks exact identifiers | `` `…` `` used for code, file names, and system values — not regular words | `` `simply` `` or `` `important` `` styled as code for visual effect |
| Callouts use a consistent pattern | Notes, warnings, tips use a consistent block format (`> **Note:**`) | Mixing `> Note:`, `**Note:**`, `NOTE:`, and plain paragraphs |
| No all-caps for emphasis | Capitalized words used only for acronyms or proper names | `Do NOT run this command` — `NOT` in all-caps for stress |

**Scoring guide:**
- 5: Formatting is semantically consistent; a model can reliably infer meaning from marks.
- 3: Occasional bold-for-emphasis or mixed callout styles.
- 1: Formatting is used decoratively; semantic meaning cannot be inferred reliably.

---

## Output Format

Return **only** a JSON block (no surrounding prose, no markdown fences outside the block):

```json
{
  "file": "<relative or absolute path to the article>",
  "overall_score": "<weighted average, 1 decimal place>",
  "dimensions": {
    "semantic_structure": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "self_contained_sections": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "terminology_consistency": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "code_block_quality": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "retrieval_metadata": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "chunk_coherence": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "reference_and_link_quality": {
      "score": "<1-5>",
      "rationale": "<≤ 2 sentences>",
      "violations": ["<violation 1>", "..."]
    },
    "formatting_signal_clarity": {
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
| semantic_structure | 0.20 |
| self_contained_sections | 0.20 |
| terminology_consistency | 0.15 |
| code_block_quality | 0.15 |
| retrieval_metadata | 0.10 |
| chunk_coherence | 0.10 |
| reference_and_link_quality | 0.05 |
| formatting_signal_clarity | 0.05 |

`overall_score = sum(score_i × weight_i)` — round to one decimal place.

Do not output anything other than the JSON block.
