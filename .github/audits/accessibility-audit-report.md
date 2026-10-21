# Accessibility Audit Report – Telerik UI for WPF Documentation

**Audit date:** October 21, 2026  
**Repository:** [telerik/xaml-docs](https://github.com/telerik/xaml-docs)  
**Documentation site:** [Telerik UI for WPF documentation](https://www.telerik.com/documentation/wpf)

## Executive Summary

The repository contains useful accessibility-related material, including keyboard instructions, UI Automation configuration, and a Section 508 support matrix. However, coverage is fragmented, some compliance statements are difficult to verify, and repeated Markdown patterns can make content harder to navigate with assistive technology.

No critical issue was confirmed in this source review. The highest risks are unqualified product-compliance claims and gaps in discoverable, control-specific guidance for assistive technology, high contrast, and focus behavior. Separately, empty image alternatives and inconsistent heading/link patterns create direct barriers in individual documentation pages.

This report evaluates the accessibility of the documentation content and the discoverability of WPF accessibility guidance. It does not test Telerik controls, the rendered site, or embedded videos with assistive technology. The findings are evidence-based leads for remediation, not a product-conformance determination.

### Method and scope

The repository skill at `.github/skills/accessibility-doc-optimization/SKILL.md` was used as the primary checklist: heading structure, alternative text, link purpose, tables, plain language, formatting independence, callouts, and code blocks. Representative pages were reviewed from common information, component documentation, getting-started tutorials, knowledge-base articles, and embedded-media content. A text scan covered 3,327 Markdown files outside `.github`; automated counts below identify candidates for follow-up and are not a substitute for checking rendered output.

The scan found:

- 9 empty-alt Markdown images in 3 articles.
- 1,088 heading-level jumps in 668 articles.
- 684 links with short generic anchors such as “here” or “this article” in 407 articles.
- 21 fenced code blocks without a language label in 9 articles, out of 1,907 fenced blocks scanned.

The heading and link counts are rule-based candidates. Template syntax and valid context-dependent uses can affect them; review each candidate before changing it.

## Documentation Accessibility Findings

### Compliance claims need scope, evidence, and maintenance context

**Severity:** High

**Description**  
The Section 508 article assigns “Fully Supported,” “Partially Supported,” and “Not Supported” statuses, but does not explain the test scope, supported product versions, exceptions, or date of the assessment. It also cites the legacy Section 1194 criteria without explaining their relationship to current guidance. For example, it describes keyboard and focus support as partial, while other rows make broad “fully supported” claims. Readers cannot determine what was tested or whether a claim applies to their control and version.

**Affected Files/Pages**

- `common-information/section_508_compliance.md` — criteria tables and status statements.
- `common-information/common-ui-automation.md` — states that all controls were tested with Accessibility Insights for Windows, without identifying versions, test coverage, results, or known exceptions.

**Impact**  
Developers may treat a general support statement as a guarantee for a particular control, workflow, or assistive technology. This can lead to inaccessible applications and misplaced confidence in compliance.

**Recommendation**  
Document the assessment date, product versions, tools and test procedures, control-specific exceptions, and limits of the results. Link each status to supporting control guidance. Explain which regulatory or technical standard is being used and avoid implying that automated UI Automation checks alone establish overall accessibility conformance.

**Examples**  
`common-information/section_508_compliance.md` marks keyboard support and focus support as partially supported, while its UI Automation and color/contrast rows make broader statements. The article does not identify the exceptions behind those partial statuses.

### Accessibility guidance is fragmented and difficult to discover

**Severity:** High

**Description**  
Accessibility-related information is spread across the Section 508 matrix, UI Automation, Coded UI, and separate keyboard-support pages. There is no central WPF accessibility guide that connects these resources or lets customers find control-specific support, limitations, and validation instructions. The Section 508 page does not link to the UI Automation or Coded UI articles, although those two articles cross-link to each other.

**Affected Files/Pages**

- `common-information/section_508_compliance.md`
- `common-information/common-ui-automation.md`
- `common-information/coded-ui-support.md`
- Examples of control-level keyboard documentation: `controls/radcombobox/features/keyboard-support.md`, `controls/radmenu/features/keyboard-navigation.md`
- `controls/radtreeview/overview2.md` — advertises UI Automation and links to the general UI Automation article.

**Impact**  
Customers may not find relevant support or caveats when implementing controls. They must infer control coverage from scattered feature pages and broad suite-level statements.

**Recommendation**  
Create a discoverable accessibility overview that links the existing material and summarizes, by control, keyboard support, UI Automation/screen-reader notes, focus behavior, high-contrast considerations, and known limitations. Add reciprocal links from the Section 508, UI Automation, and Coded UI pages, and link the relevant guidance from component overviews.

### Informative tutorial screenshots have empty alternative text

**Severity:** Medium

**Description**  
Nine Markdown images in three tutorial or troubleshooting articles use empty alt text. The surrounding instructions refer to screenshots as steps or results, so these images appear to convey information rather than serve only as decoration.

**Affected Files/Pages**

- `controls/radtabbedwindow/getting-started.md` — four empty-alt screenshots, including “Add new WPF Window” and figures showing the resulting window.
- `knowledge-base/kb-upgrade-migrate-to-net.md` — four empty-alt screenshots embedded in migration steps.
- `knowledge-base/kb-installation-could-not-load-file-or-assembly-demos.md` — an empty-alt image of the reported error.

**Impact**  
Screen-reader users do not receive the visible steps, selections, or error details. In procedural content, this can leave them unable to complete or troubleshoot the task.

**Recommendation**  
Add concise, context-specific alt text describing the relevant screen, selected setting, or error. If an image is purely decorative, retain empty alt text and ensure the surrounding content does not depend on it.

### Heading hierarchy includes skipped levels and figure captions used as headings

**Severity:** Medium

**Description**  
A repository scan identified heading-level jumps in many articles. Some figure captions are formatted as level-four headings directly under level-two sections, which inserts misleading levels into the screen-reader heading outline.

**Affected Files/Pages**

- `knowledge-base/kb-gridview-style-column-resizer.md` — `#### Figure 1: The modified column resizers` follows `## Solution`.
- `knowledge-base/kb-diagram-custom-connection.md` — `#### Figure 1: Result` follows `## Solution`.
- Scan candidates: 1,088 heading jumps in 668 files; validate against rendered pages before bulk changes.

**Impact**  
Readers navigating by headings may encounter a confusing outline or miss the relationship between a caption and the section it illustrates.

**Recommendation**  
Use sequential heading levels for actual sections. Format figure captions as captions or ordinary emphasized text rather than headings. Add a Markdown-aware heading check to review submissions, while allowing documented exceptions where the publishing system supplies a page title.

### Generic link labels do not identify destinations out of context

**Severity:** Medium

**Description**  
Many pages use short link labels such as “here” or “this article.” These labels are unclear in a screen-reader links list and provide little information when scanned visually.

**Affected Files/Pages**

- `README.md` — “click here” for the license agreement.
- `common-information/coded-ui-support.md` — “here” for the Microsoft Coded UI reference.
- Additional scan candidates: 684 generic-anchor matches in 407 files.

**Impact**  
People navigating by links cannot reliably distinguish destinations, and all readers have to use surrounding text to understand where a link leads.

**Recommendation**  
Replace generic anchors with destination names, such as “Telerik UI for WPF license agreement” or “Microsoft Coded UI test guidance.” Recheck all links with the same anchor text to ensure the destination is clear and consistent.

### Embedded video pages do not provide a text alternative in the article

**Severity:** Medium

**Description**  
`getting-started/video-onboarding.md` embeds two YouTube videos with descriptive iframe titles, but the page does not provide transcripts or link to a text equivalent. The repository source does not establish whether captions are available or accurate for either video.

**Affected Files/Pages**

- `getting-started/video-onboarding.md` — “Course Overview” and “Project Overview” embeds.

**Impact**  
Deaf or hard-of-hearing readers may not have access to spoken content if captions are absent or inaccurate. A transcript also helps readers who cannot access or operate the video player and supports search.

**Recommendation**  
Verify caption availability and quality for both videos. Link a transcript or provide one on the page, and ensure any visual-only demonstration is described in the transcript or adjacent instructions.

### Tables and callouts use inconsistent or incomplete patterns

**Severity:** Low

**Description**  
The Section 508 tables contain blank comment cells, leaving the table structure without an explicit value. In component documentation, callout styling varies between designated forms such as `>tip`, plain blockquotes, and text beginning with “Note”; `common-information/common-ui-automation.md` also contains `>importantCreating` without a space.

**Affected Files/Pages**

- `common-information/section_508_compliance.md` — blank “Additional Comments” cells in the criteria tables.
- `controls/radcombobox/features/keyboard-support.md` — uses both `>tip` and a plain `>Note` blockquote.
- `common-information/common-ui-automation.md` — malformed-looking `>importantCreating` callout at the AutomationMode section.

**Impact**  
Blank cells can be announced without a clear value, and inconsistent or malformed callouts may not be presented as intended by the publishing system.

**Recommendation**  
Use “Not applicable” or “None” where a table cell has no comment, or restructure the content as prose. Standardize callouts on the publishing platform’s supported syntax, verify the rendered result, and include a lint or preview check for callout formatting.

### Plain-language and code annotation need consistent review

**Severity:** Low

**Description**  
Some sampled prose uses promotional or indirect wording, and a small number of fenced blocks lack language labels. These patterns are not consistent across the repository, but they can increase reading effort or prevent language-aware presentation.

**Affected Files/Pages**

- `controls/radtreeview/overview2.md` — the opening “Do you have need of building complicated navigation systems which perform with the speed of light?” uses an indirect, promotional construction.
- Repository scan: 21 unlabeled fenced blocks in 9 files; candidates include installation and getting-started articles.

**Impact**  
Long or indirect prose can increase cognitive load. An unlabeled code block may lack syntax highlighting and context for language-aware tools.

**Recommendation**  
Prefer direct, concise wording and define unfamiliar terms on first use. Label code fences with their language where applicable; use a clear label such as `text` for output or plain-text examples.

## Accessibility Documentation Coverage Assessment

### Compliance and standards

**Affected Components:** Telerik UI for WPF suite-wide  
**Current State:** `common-information/section_508_compliance.md` maps Section 1194 criteria to support statuses.  
**Missing Information:** Assessment date, supported product versions, test methodology, exceptions, and a clear explanation of the standards’ scope and currency.  
**Recommendation:** Update the support matrix with evidence, versions, explicit limitations, and links to affected controls. Separate documented test results from general support claims.

### UI Automation and screen readers

**Affected Components:** Suite-wide, with specific details not mapped by control  
**Current State:** `common-information/common-ui-automation.md` describes automation peers, `AutomationMode`, and `UseDefaultHelpText`. `controls/radtreeview/overview2.md` links to this article and claims UI Automation support.  
**Missing Information:** Per-control support and limitations, supported automation properties/patterns, practical screen-reader verification procedures, and the tested screen readers and application scenarios. The current mention of Accessibility Insights does not describe the test matrix or results.  
**Recommendation:** Add a tested support matrix and step-by-step guidance for inspecting names, roles, values, states, and focus with UI Automation and screen readers. Distinguish automated checks from manual assistive-technology testing.

### Keyboard navigation and focus

**Affected Components:** Individual controls with keyboard-support pages, including RadComboBox and RadMenu  
**Current State:** Some controls document keys and navigation behavior in standalone feature pages. Section 508 notes partial keyboard and focus support at suite level.  
**Missing Information:** A unified index, control-by-control coverage, consistent focus-indicator guidance, known exceptions, and an explanation of expected behavior for keyboard-only users.  
**Recommendation:** Link keyboard guidance from each component overview and publish a navigation matrix. Document focus entry, movement, restoration, visible indicators, and escape behavior for relevant controls.

### High contrast, themes, and color

**Affected Components:** Suite themes and controls generally  
**Current State:** The Section 508 article says the controls do not override system contrast settings and can be customized. Theme pages describe appearance and customization.  
**Missing Information:** A search of the repository did not surface a dedicated high-contrast configuration or verification guide, nor control-specific contrast limitations. This is a documentation gap; it does not establish a product failure.  
**Recommendation:** Explain how customers can honor Windows contrast preferences, identify relevant theme behavior and limitations, and verify that status and instructions are not conveyed by color alone.

### Accessibility APIs, examples, and limitations

**Affected Components:** Suite-wide and control-specific APIs  
**Current State:** UI Automation examples cover global configuration. Individual change logs and knowledge-base entries mention automation peers, including `knowledge-base/kb-common-net8-automationpeers-issue.md`.  
**Missing Information:** An indexed API/example collection, practical control-level configuration examples, and a maintained list of accessibility caveats and platform/runtime dependencies.  
**Recommendation:** Link API and workaround topics from the accessibility overview and relevant control pages. Record the affected runtime versions, workaround limits, and whether the issue is resolved.

## Repository-Wide Improvement Opportunities

- **Global content fixes:** Add meaningful alt text to informative screenshots; replace generic link anchors; correct verified heading skips; fill blank data-table cells; standardize callout syntax.
- **Authoring guideline updates:** Add checks for one meaningful page heading, sequential section levels, contextual image alternatives, descriptive link text, table headers/values, labeled code fences, and text equivalents for media. Explain when empty alt text is appropriate for decorative images.
- **Review process:** Include an accessibility pass in content reviews. Review the rendered page, not only the Markdown source, especially for tables, callouts, embedded media, and template-generated headings.
- **Automated validation:** Add repository checks for empty image alternatives, generic link labels, heading-level jumps, unlabeled fenced blocks, and malformed callout syntax. Treat results as review candidates to avoid false positives from templates and valid context-dependent links.
- **Reusable templates:** Provide templates for keyboard-support articles, accessibility/API notes, troubleshooting articles with screenshots, and video pages with caption/transcript links.
- **Discoverability:** Add a central accessibility overview to common information and connect it to component overviews, keyboard pages, UI Automation, compliance, and testing guidance.

## Positive Findings

- `common-information/common-ui-automation.md` documents the `AutomationMode` and `UseDefaultHelpText` properties and includes C# examples.
- `common-information/coded-ui-support.md` cross-links to UI Automation support and includes historical support details and limitations.
- Keyboard guidance exists for controls such as RadComboBox and RadMenu and describes key behavior in text rather than relying only on screenshots.
- Many tutorial images already have descriptive alternatives. For example, `controls/radmenu/features/keyboard-navigation.md` labels its image as a RadMenu keyboard-navigation example.
- `getting-started/video-onboarding.md` gives its iframes descriptive titles, and its learning modules are also listed in text.
- The repository contains a skill with explicit accessibility authoring checks, providing a foundation for a repeatable review process.

## Prioritized Remediation Plan

### Immediate Actions

1. Clarify and substantiate the Section 508 and UI Automation claims, including dates, versions, methodology, exceptions, and evidence.
2. Add descriptive alternatives to the nine informative screenshots identified in the three affected articles.
3. Publish a central accessibility guide and link the existing compliance, UI Automation, keyboard, and Coded UI material.
4. Verify captions for the onboarding videos and add transcripts or accessible text equivalents.

### Short-Term Improvements

1. Triage heading-jump and generic-link scan results; remediate confirmed cases, beginning with figure captions and links such as “here.”
2. Standardize callouts and replace blank table values with explicit content.
3. Add control-level navigation, focus, UI Automation, screen-reader, and high-contrast notes where applicable.
4. Update contribution guidance with the accessibility checklist and reusable article patterns.

### Long-Term Improvements

1. Maintain a tested, versioned accessibility support matrix for controls and assistive technologies.
2. Add accessibility review checkpoints and automated Markdown checks to the documentation contribution workflow.
3. Schedule periodic reviews of compliance claims, runtime-specific caveats, transcripts, and links to external standards.
4. Validate the rendered documentation site with keyboard-only navigation and representative screen readers; this source audit did not perform those tests.
