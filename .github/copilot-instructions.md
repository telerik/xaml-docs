# Copilot Instructions for xaml-docs

This repository contains the Markdown source for the Telerik UI for WPF documentation. Copilot acts as a reviewer of pull requests that change documentation articles (`*.md`) with YAML front matter.

## Review-Only Mode

When acting as a pull request reviewer, Copilot must not create, modify, delete, commit, or push repository files. All findings must be delivered through review comments and review summaries.

- Report every verified rule violation found by the repository skills as a pull request review comment.
- Propose fixes only inside review comments. The PR author decides whether to apply them.
- Do not open new pull requests.

Outside of pull request reviews, Copilot can produce reports, analyses, audit summaries, or remediation plans when the user explicitly requests them. Deliver this output in the chat response unless the user explicitly asks for a file.

## Skill-First Workflow

Repository skills live in `.github/skills/<skill-name>/SKILL.md`. They are the primary source of guidance for documentation work in this repository.

Before performing any significant task:

1. Search `.github/skills/` for skills that apply to the task. Do not rely only on the inventory below; new skills can be added at any time.
2. Read the full `SKILL.md` of every matching skill before acting.
3. Use the matching skills as the primary source of guidance. Repository skills take precedence over generic Copilot behavior and general writing conventions whenever they are relevant.
4. If multiple skills apply, combine them. Apply each skill's checks within its own scope, and resolve conflicts with the precedence rules in [Combining Skills](#combining-skills).
5. When producing reviews, analyses, or fix suggestions, explicitly follow the rules, scoring dimensions, and weights defined by the relevant skills, and deliver the results as PR review comments. State which skills you applied.

A significant task includes any of the following:

- Reviewing a pull request that adds or changes one or more articles
- Reviewing changes to front matter, headings, links, images, tables, code blocks, or callouts
- Reviewing new articles or substantial rewrites
- Reviewing bulk sweeps or cleanups across multiple articles

Skill discovery rules:

- New skills can be added at any time.
- Always inspect `.github/skills/` for applicable skills before acting.
- When an applicable skill exists, it takes precedence over generic documentation-review behavior.
- The [Skill Inventory](#skill-inventory) is informational only. Do not treat it as the complete list of available skills.

## Skill Inventory

This inventory lists the skills known at the time of writing. Each `SKILL.md` is the single source of truth for its dimensions, pass conditions, scoring guide, weights, and output format. Do not rely on this file for evaluation specifics.

| Skill | Purpose | Typical triggers |
|---|---|---|
| `style-guide-scoring` | Scores an article against the Progress DevTools Style Guide. | Style, grammar, tone, punctuation, lists, formatting, metadata, editorial quality. |
| `seo-doc-optimization` | Scores an article for technical SEO and modern ranking factors. | SEO, discoverability, metadata and slug quality, search intent, internal linking. |
| `llm-doc-optimization` | Scores an article for LLM and AI-agent readability. | AI/LLM readiness, retrieval and chunking quality, terminology consistency, self-contained sections. |
| `accessibility-doc-optimization` | Scores an article for accessibility and plain language. | Accessibility, alt text, link purpose, table accessibility, callouts, readability. |

In pull request reviews, use the skill output only as an internal evaluation. Do not write it to a file. Convert each violation into a review comment as described in [Review Comment Format](#review-comment-format).

## Skill Routing

Route each request to the skills below. When a request matches several rows, apply every listed skill.

| Request type | Skills to apply |
|---|---|
| Style, grammar, tone, punctuation, lists, or formatting review | `style-guide-scoring` |
| Front matter or metadata review (`title`, `page_title`, `meta_title`, `description`, `slug`, `previous_url`) | `style-guide-scoring`, `seo-doc-optimization`, `llm-doc-optimization` |
| Heading structure or table of contents review | `style-guide-scoring`, `accessibility-doc-optimization`, `llm-doc-optimization`, `seo-doc-optimization` |
| Link and cross-reference review | `accessibility-doc-optimization`, `llm-doc-optimization`, `seo-doc-optimization`, `style-guide-scoring` |
| Image, screenshot, or alt text review | `accessibility-doc-optimization`, `style-guide-scoring` |
| Table review | `accessibility-doc-optimization`, `llm-doc-optimization`, `style-guide-scoring` |
| Code block review | `llm-doc-optimization`, `accessibility-doc-optimization`, `style-guide-scoring` |
| Callout or admonition review | `accessibility-doc-optimization`, `llm-doc-optimization` |
| Readability or plain-language review | `accessibility-doc-optimization`, `style-guide-scoring` |
| SEO, discoverability, search intent, or ranking | `seo-doc-optimization` |
| AI, LLM, RAG, or agent readiness | `llm-doc-optimization` |
| Accessibility or WCAG compliance | `accessibility-doc-optimization` |
| Full article audit or overall content quality review | All four skills |
| New article or substantial rewrite in a PR | All four skills |
| Fix suggestions for reported violations | The skills that produced the findings, plus any skill covering the affected elements |

## Combining Skills

When more than one skill applies:

- Evaluate each skill independently, using its own dimension names. Do not merge dimensions or invent new ones.
- Deduplicate overlapping findings:
  - When multiple skills identify the same underlying issue, post a single review comment.
  - Reference every relevant skill and dimension in that comment.
  - Provide one unified recommendation that satisfies all applicable skills.
  - Do not post more than one comment on the same line for the same underlying issue.
- When guidance overlaps, the suggested fix must satisfy all skills at once. For example, a `description` must be 100–150 characters (hard limit) to pass both `style-guide-scoring` and `seo-doc-optimization`.
- When guidance conflicts, prefer the stricter rule. If no rule is stricter, apply this precedence: `accessibility-doc-optimization` > `style-guide-scoring` > `llm-doc-optimization` > `seo-doc-optimization`. Note the conflict in the review comment.

## Pull Request Review Workflow

1. Identify the Markdown articles added or changed in the pull request.
2. Read each changed article in full, including front matter, to understand context.
3. Select skills from [Skill Routing](#skill-routing) based on the content of the changes.
4. Evaluate each dimension exactly as defined in the skill, using its pass conditions and scoring guide.
5. Report violations only for lines added or modified in the pull request. Mention pre-existing issues in unchanged lines only when they are directly affected by the change.
6. Post one inline review comment per violation on the offending line, using the [Review Comment Format](#review-comment-format).
7. Post one summary review comment per pull request, as described in [Summary Comment](#summary-comment).

### Review Comment Format

Each inline comment must contain:

- **Skill and dimension:** the skill name and dimension that the violation belongs to, for example `style-guide-scoring › titles_and_headings`.
- **Severity:** based on the dimension weight defined in the skill: `High` for 15 % or more, `Medium` for 10 %, and `Low` for less than 10 %.
- **Violation:** the offending text and the specific skill rule or repository rule it breaks, stated concretely. Do not report vague findings.
- **Suggested fix:** the corrected text. Use a GitHub `suggestion` block when the fix replaces the commented lines directly.

Example inline comment:

````markdown
**`style-guide-scoring` › `titles_and_headings`** · Severity: High

The heading uses the gerund form while other action headings use the imperative form ("Configure the Feed"). Use one verb form for all action headings.

```suggestion
## Install the Package
```
````

### Summary Comment

The summary comment must contain:

- The list of skills applied.
- A table with the overall score per skill for each changed article.
- The highest-impact violations, prioritized by dimension weight multiplied by the score gap (5 minus the current score).
- Any conflicts between skills and how they were resolved.
- Recurring findings consolidated from inline comments, with the affected files.
- Any skills that were unavailable, as described in [Missing or Unavailable Skills](#missing-or-unavailable-skills).

## Evidence-Based Reviews

Every finding must be traceable to repository guidance.

- Report only findings that can be traced to one of these sources:
  - A rule in a repository skill
  - A rule in [Repository Conventions](#repository-conventions)
  - An explicit instruction in this file
- Do not invent requirements, style rules, accessibility criteria, SEO rules, or metadata requirements that repository guidance does not define.
- Do not report speculative issues.
- When confidence is low or evidence is insufficient, do not post a review comment.
- Each review comment must identify the specific skill rule or repository rule it is based on.

## Large Pull Requests

When a pull request changes many articles, keep the review focused and actionable.

- Prioritize `High` severity findings first.
- Do not post repetitive inline comments for an identical issue that occurs multiple times. Comment on the first occurrence, and consolidate the remaining occurrences in the summary comment.
- Focus comments on issues introduced by the current changes.
- Keep the comment volume manageable for the author. Prefer fewer, high-impact comments over exhaustive low-severity findings.

## Missing or Unavailable Skills

When a referenced skill cannot be loaded, read, or evaluated:

- Continue the review with the other applicable skills.
- Do not invent or reconstruct the rules of the missing skill.
- Mention the unavailable skill in the summary comment.
- Limit findings to rules that can be verified.

## Documentation Quality Requirements

For every article changed in a pull request, evaluate the following areas through the listed skills and report violations as review comments. The key rules below are summaries; the relevant `SKILL.md` files define the exact criteria.

| Area | Skills | Key rules |
|---|---|---|
| Markdown quality | `style-guide-scoring`, `llm-doc-optimization` | Semantic formatting, consistent callouts, labeled code fences. |
| Accessibility | `accessibility-doc-optimization` | Descriptive alt text, descriptive link text, accessible tables, plain language, no meaning conveyed by color or formatting alone. |
| Style | `style-guide-scoring` | Progress DevTools Style Guide: tone, grammar, American English, numbers, punctuation, lists, UI and code formatting. |
| Structure | `style-guide-scoring`, `accessibility-doc-optimization`, `llm-doc-optimization` | Single H1, no skipped heading levels, title case, consistent verb forms across action headings, self-contained sections. |
| Metadata | `style-guide-scoring`, `seo-doc-optimization`, `llm-doc-optimization` | `title`, `page_title`, `description` (100–150 characters), URL-safe `slug`; specific and unique across sibling articles. |
| Links | `accessibility-doc-optimization`, `seo-doc-optimization`, `llm-doc-optimization` | Descriptive anchor text, no bare URLs, stable `slug` references for internal links. |
| Content quality | `seo-doc-optimization`, `llm-doc-optimization` | Clear user intent, concrete examples, stated prerequisites, limitations, next steps, consistent terminology. |

## Repository Conventions

Report deviations from these conventions as review comments, and keep them intact in every suggested fix:

- Every article starts with YAML front matter. Common fields are `title`, `page_title`, `description`, `slug`, `tags`, `published`, and `position`. Some articles also use `components` and `previous_url`.
- Internal links use slug references: `[descriptive text]({%slug target-slug%})`. Do not suggest replacing them with absolute URLs.
- Framework-neutral text uses the `{{ site.framework_name }}` placeholder. Keep placeholders and Liquid tags intact in suggestions.
- Callouts use the platform syntax, such as `>note`, `>tip`, `>important`, and `>warning`.
- In prose, headings, and code fence tags, write **C#** and **VB.NET** (for example, ` ```C# ` and ` ```VB.NET `).
- Images are stored in `images/` folders next to the articles. Alt text must describe the image content, not the file name.
- Shared content lives in `_contentTemplates/`, and API reference assets live in `_assetsApi/` and `_assetsApiSL/`. Do not review generated API assets unless explicitly asked.

## General Rules

- During pull request reviews, never create, modify, or delete files. All output goes into review comments and the review summary.
- Flag any `slug` change as a `High` severity comment, because slugs back internal links and published URLs. When a slug changes, check that `previous_url` is added as required by the skills.
- Do not consult the external style guide at `C:\HelpMigration\tech-docs-style-guide` unless the request explicitly asks for it. When required, read only the specific files needed.
- When no skill applies to a task, follow standard best practices and state that no repository skill matched.
