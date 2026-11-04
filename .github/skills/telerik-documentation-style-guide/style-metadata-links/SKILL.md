---
name: style-metadata-links
description: "Use this skill when writing or reviewing Telerik UI for WPF article metadata, taxonomy, navigation, slug cross-references, external links, SEO descriptions, or Knowledge Base metadata."
---

# Metadata, Cross-References, and Links

Use this skill for metadata and link conventions in the `xaml-docs` repository. The repository's `docs-builder.yml` defines the WPF product path and Liquid rendering. Check neighboring articles and folder metadata before changing frontmatter or navigation.

## Frontmatter

WPF articles use YAML frontmatter delimited by `---`. Preserve existing keys and their order when editing an article. Do not invent fields or normalize historical metadata without an explicit request.

Common fields include:

| Field | Repository use |
|---|---|
| `title` | Navigation label. It can be shorter than the article heading. |
| `page_title` | Browser and search title. Follow the established pattern in the same section. |
| `description` | Search summary. Keep it specific, grammatical, accurate, and consistent with the article. |
| `components` | Existing product taxonomy array, for example `['gridview']` or `['general']`. Check neighboring files. |
| `slug` | Stable article identifier used for Liquid cross-references. Preserve existing slugs. |
| `tags` | Existing comma-separated tags. Follow local casing and vocabulary. |
| `position` | Navigation order where the section uses it. Check nearby files. |
| `published` | Existing publication flag in sections that use it. Do not add it by default. |
| `type`, `res_type`, `ticketid` | Knowledge Base metadata. Preserve the local article type and existing support traceability. |
| `previous_url` | Redirect metadata when an authorized move or rename requires it. Preserve existing redirects. |

Do not assume every page has identical required metadata fields. Standard documentation articles must have exactly one source H1, independently of metadata. All Knowledge Base articles must omit source H1 headings and use their generated titles. Inspect the same article type and folder before adding, removing, or renaming metadata; neighboring pages cannot override these H1 rules.

For routine editing of an existing article, change only the requested metadata field, usually `description`. Report other metadata concerns rather than changing URLs, navigation, taxonomy, or support identifiers without authorization.

## Descriptions and Titles

Write a distinct, accurate description that names the control or task and tells readers what they can accomplish. Use the character limit or template required by the relevant page template; do not assume MAUI's metadata limit applies to every WPF article. Avoid keyword stuffing, trademark symbols, markup, and unsupported compatibility claims.

Use the neighboring WPF pages as the authority for `page_title` format. A navigation `title`, descriptive source heading, and `page_title` can differ, but they must refer to the same topic. Preserve established historical wording when only editing body content.

## Internal Links

Use the repository's Liquid slug syntax for documentation cross-references:

```markdown
See the [RadGridView overview]({%slug gridview-overview2%}) for the control's main features.
```

Use a slug that exists in this repository. Verify fragments against the actual heading or anchor. Prefer descriptive link text that explains the destination. Avoid "click here," "this article," and bare URLs in prose.

The repository also uses relative paths for local images and assets. Keep those paths relative to the article and verify that the referenced file exists. Do not replace slug links with hard-coded site URLs during routine edits.

## External Links

Use HTTPS when the destination supports it. Link to the correct WPF documentation, API reference, Microsoft WPF documentation, or Telerik sample source. Confirm the destination is relevant to the specific control and Telerik release. Do not substitute documentation for another Telerik UI product.

Do not require links to open in a new tab unless the repository explicitly requires it. State when an external destination could not be checked.

## Navigation and Knowledge Base Content

For a new control article, check `components`, `position`, sibling files, and any local `_meta.yml` or `docs-builder.yml` rules. Do not assume frontmatter alone controls navigation.

For a Knowledge Base article, preserve its existing `type`, `res_type: kb`, component taxonomy, slug, ticket traceability, and generated-title pattern. Follow [style-kb-faq](../style-kb-faq/SKILL.md) for article structures. Security content must follow approved security-team guidance and must not invent affected versions or mitigations.

## Quick Checklist

- [ ] Standard articles have one source H1; KB articles have none, including after metadata or link fixes.
- [ ] Every image has an immediate approved introduction; heading-only and bold-only labels are reported or corrected when authorized.
- [ ] Frontmatter follows the neighboring WPF article pattern and contains no duplicate keys.
- [ ] Existing slugs, redirects, support IDs, and navigation metadata remain stable unless changes were requested.
- [ ] `components`, `tags`, `position`, and Knowledge Base fields match local conventions.
- [ ] Titles and descriptions match the article's actual WPF subject and verified scope.
- [ ] Internal links use valid `{%slug ...%}` references and verified fragments.
- [ ] Anchor text describes the destination; image and asset paths resolve.
- [ ] External links point to relevant WPF or Microsoft sources and unavailable checks are disclosed.
- [ ] Metadata fields are not added based on conventions from another Telerik product repository.
