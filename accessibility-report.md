# Repository Accessibility Assessment

**Status: PROVISIONAL — automated source-level baseline.** All eligible files were processed, but semantic judgments (including image purpose, link purpose in context, table intent, and plain-language quality) require human review. This report does not evaluate rendered behavior, product functionality, UI components, code correctness, image pixels, or claim WCAG conformance.

## Average Scores

- **Articles scored:** 3,332
- **Articles excluded:** 21
- **Overall documentation accessibility score:** 4.8 / 5.0 (mean of per-article weighted scores)

| Dimension | Weight | Average score |
|---|---:|---:|
| Heading Structure | 20% | 4.9 / 5.0 |
| Alternative Text | 20% | 4.9 / 5.0 |
| Link Text Clarity | 15% | 4.6 / 5.0 |
| Plain Language | 15% | 4.6 / 5.0 |
| Table Accessibility | 10% | 5.0 / 5.0 |
| Formatting Independence | 10% | 5.0 / 5.0 |
| Callout Structure | 5% | 5.0 / 5.0 |
| Code Block Accessibility | 5% | 4.9 / 5.0 |

### Scope and exclusions

- Markdown source files discovered before path/content exclusions: 3,353.
- Included and scored: 3,332; excluded or unscored: 21.
- Exclusions are classified once using the following priority; generated API content directories are `_assetsApi/` and `_assetsApiSL/`, and hidden navigation entries are not treated as unpublished.

| Primary exclusion reason (mutually exclusive) | Files |
|---|---:|
| Excluded directories (.git, .github, node_modules, _site, bin, obj) | 16 |
| Generated API Markdown (_assetsApi and _assetsApiSL) | 2 |
| Site-configured files (README.md, copyright.md, *.score-summary.md) | 2 |
| Frontmatter publish/published: false | 0 |
| Audit outputs | 1 |

The site-configured exclusion patterns were read from `docs-builder.yml`. Markdown under hidden navigation entries remains included unless another exclusion applies. Two site-excluded files also have false publication frontmatter; they remain classified under the site exclusion to keep counts mutually exclusive. Articles with image alternatives whose purpose cannot be determined from source are listed for human review in `scores.jsonl`.

## Methodology

The audit processes frontmatter separately, ignores fenced code when checking headings and prose, and checks Markdown/HTML image and table markup, links, callouts, and fenced code. Content absent from a dimension receives 5 when no source-level violation is found. Dimension scores are integers: 5 means no detected issue, 4 Low, 3 Medium, 2 High, and 1 Critical; four or more Low instances in a dimension lower its score to 3, and six or more Medium instances lower it to 2. Image-purpose cases marked Human Review Required do not receive a severity; they set alternative-text to 3 unless another finding lowers it further. A more severe finding sets the dimension score to its corresponding value. The article score is the weighted sum using the dimensions and weights above, rounded to one decimal place; the repository score is the mean of article scores. These conservative automated thresholds are source-level indicators, not expert or conformance ratings.

## Summary

- The mean score is **4.8/5.0** across 3,332 scored articles. The strongest dimensions are **callout structure** (5.0) and **formatting independence** (5.0); the weakest are **link text clarity** (4.6) and **plain language** (4.6).
- **0** articles contain at least one Critical finding and **1** contain at least one High finding. (An article can appear in both counts.)
- Automated checks found 1,629 Medium and 1,875 Low instances across the set.
- **38 image cases** across **31 articles** are marked Human Review Required without assigning severity because image purpose cannot be determined from source.
- Recurring Medium/Low patterns (articles affected):
  - Potentially complex wording: 917 articles.
  - Inconsistent labels for same destination: 601 articles.
  - Generic link text: 468 articles.
  - Code blocks without explanatory introductions: 195 articles.
  - Sentences over 40 words: 167 articles.
  - Multiple sentences over 25 words: 138 articles.
  - Empty headings: 117 articles.
  - Vague headings: 91 articles.
  - Skipped heading levels: 81 articles.
  - Image without a meaningful immediate introduction: 73 articles.
  - Bare URLs in prose: 57 articles.
  - Empty table cells: 9 articles.
  - Color-only references: 5 articles.
  - Fenced code blocks without language identifiers: 2 articles.

### Limitations

This automated baseline checks Markdown syntax and conservative text patterns. It cannot reliably determine whether image content is informative, whether wording is clear in its product context, whether an HTML table is data or layout, or whether a link label is meaningful in the surrounding prose. Such cases are marked for human review where identified. Source-only checks do not prove accessibility or WCAG conformance. Scores are reproducible heuristic indicators, not expert judgments.

## Critical and High Issues

| Severity | Article | Line | Dimension | Issue | Recommended Fix |
|---|---|---:|---|---|---|
| High | `_contentTemplates/ai-coding-assistant.md` | 14 | table_accessibility | HTML table presents component names as a four-column grid without semantic list or table headers. | Replace the grid-like table with a semantic list; use table headers only if the content has genuine row-column relationships. |

Findings are grouped by article path in the table ordering; Critical entries precede High entries. Scores for individual articles are available only in `scores.jsonl`, not in this findings table.

## Validation

- Eligible Markdown count matches scored records: **3,332 = 3,332**.
- Article weighted scores use the specified weights (1.00 total); repository score is the mean of the per-article weighted scores, rounded to one decimal place.
- Articles not scored due to read/parse errors: **0**.
- Every eligible article was processed; no articles were skipped due to read or parsing errors.
