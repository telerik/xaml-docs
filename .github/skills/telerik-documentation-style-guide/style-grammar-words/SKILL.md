---
name: style-grammar-words
description: "Use this skill when checking grammar, word choice, contractions, pronouns, numbers, punctuation, or vocabulary in Telerik UI for WPF documentation. Covers modal verbs, singular and plural usage, numeric API values, version notation, Oxford comma, ranges, prepositions, and simpler alternatives. Use when asked to 'fix grammar', 'simplify vocabulary', 'check word choice', or 'review punctuation'; preserve XAML, C#, WPF feature names, and technical meaning."
---

# Grammar, Word Choice, and Punctuation

This skill defines the grammar, vocabulary, and punctuation rules for Telerik UI for WPF documentation. Apply these rules to every article you write, edit, or review. Preserve exact XAML and C# identifiers, package names, UI labels, diagnostics, and version strings.

## Modal Verbs

Modal verb choice matters because it controls the strength of recommendations and the reader's sense of obligation.

| Use | Instead of | Reason |
|-----|-----------|--------|
| **must**, **have to**, **need to** | should for an actual requirement | State verified prerequisites unambiguously |
| **can** | could for an established capability | Do not convert a possibility into guaranteed support |
| **will** | would for a definite future outcome | Preserve conditions and uncertainty when they matter |

- Use **"must"** or **"have to"** for requirements.
- Use **"can"** for capabilities or permissions.
- Use **"will"** for outcomes that definitely happen.
- Keep "should" for recommendations and "might" for uncertain outcomes. Never turn optional MVVM patterns, platform-dependent behavior, or an untested workaround into a requirement or guarantee.

## Contractions

Contractions make documentation feel conversational but some forms sound awkward in technical writing.

### Acceptable Contractions

Use these freely: **aren't**, **can't**, **didn't**, **don't**, **doesn't**, **haven't**, **hasn't**, **hadn't**, **isn't**, **wasn't**, **weren't**, **shouldn't**, **couldn't**, **wouldn't**, **I'm**

### Unacceptable Contractions

Do not use these — they sound too informal or create ambiguity:

**you'll**, **you're**, **you'd**, **you've**, **what's**, **where's**, **when's**, **how's**, **won't**, **I'll**, **I've**, **I'd**, **it's**, **that's**, **there's**, **here's**, **they'll**, **they've**, **they'd**, **we'll**, **we're**, **we've**, **we'd**

Write the expanded form instead: "you will" not "you'll", "it is" not "it's", "they have" not "they've".

## Singular vs. Plural

Use **plural nouns** when describing general actions or capabilities. Plural sounds more natural and avoids awkward "a/an" constructions.

| ❌ Singular | ✅ Plural |
|---|---|
| The DataGrid displays a record. | The DataGrid displays records. |
| The TreeView displays a node. | The TreeView displays nodes. |
| The Scheduler displays an appointment. | The Scheduler displays appointments. |

Use singular for a specific instance or a task that creates one control: "Add a DataGrid to the page." Do not pluralize an instruction if doing so changes the sample's behavior.

## Numbers

### Spell Out 0–9, Use Digits for 10+

| ❌ Wrong | ✅ Correct |
|---|---|
| The method accepts 3 parameters. | The method accepts three parameters. |
| There are fifteen columns. | There are 15 columns. |
| Add 1 item to the RadGridView. | Add one item to the RadGridView. |

### Exceptions — Always Use Digits For:

- Measurements and units: 5 device-independent units, 8 MB, 3 seconds; do not call WPF layout units physical pixels
- Version numbers: preserve exact Telerik package, .NET SDK, OS, and target-framework versions
- Code-adjacent values: set the value to 0, index 5
- Percentages: 5%, 99%
- Negative numbers: -1, -5

### Ranges

Use an **en dash** (–) without spaces for number ranges: items 10–25. List tested Telerik and .NET versions explicitly; a range or a trailing `+` must not imply unverified future compatibility.

## Punctuation

### Oxford Comma (Serial Comma)

Always use the Oxford comma — place a comma before "and" or "or" in a list of three or more items.

| ❌ No Oxford comma | ✅ With Oxford comma |
|---|---|
| The suite includes DataGrid, TreeView and Scheduler. | The suite includes DataGrid, TreeView, and Scheduler. |
| You can sort, filter or group DataGrid items. | You can sort, filter, or group DataGrid items. |

### Periods

- End all complete sentences with a period, including list items that are complete sentences.
- Do not use a period after sentence fragments, headings, or UI labels.

### Colons

- Use a colon to introduce a list, code block, or explanation.
- The introductory sentence before a list must end with a colon.
- Capitalize the first word after a colon only if it starts a complete sentence.

### Semicolons

Avoid semicolons in documentation. Split into two sentences instead.

### Hyphens and Dashes

| Symbol | Name | Usage |
|--------|------|-------|
| `-` | Hyphen | Compound modifiers before a noun: "well-known method", "read-only property" |
| `–` | En dash | Number ranges: "pages 10–25". Use `&ndash;` in HTML |
| `—` | Em dash | Parenthetical statements — use sparingly |

### Quotation Marks

- Use **straight double quotes** (`"`) for direct quotes. Format UI labels in bold according to [style-formatting](../style-formatting/SKILL.md); do not change quotation marks inside copied code or diagnostics.
- Place periods and commas **inside** closing quotation marks (US English style).
- Place colons and semicolons **outside** closing quotation marks.

## Prepositional Phrases

Use the correct preposition for each context:

| Context | Correct preposition | Example |
|---------|---------------------|---------|
| Dialog boxes | **in** | In the **Manage NuGet Packages** dialog box |
| Pages, screens | **on** | On the Settings page |
| Menus | **on** | On the File menu |
| Tabs | **on** | On the General tab |
| Command line | **at** | At the command line |
| Lists, panels | **in** | In the Properties panel |
| Toolbars | **on** | On the toolbar |
| Applications | **in** | In the application |

## Prefixes

Most prefixes do **not** require a hyphen. Attach them directly to the root word:

| ❌ Hyphenated | ✅ No hyphen |
|---|---|
| non-zero | nonzero |
| pre-defined | predefined |
| re-use | reuse |
| co-exist | coexist |
| multi-threaded | multithreaded |

**Exceptions — use a hyphen when:**
- The prefix ends with the same letter the root word starts with: re-enter, co-opt
- The root word is capitalized: non-English, pre-Windows
- The root word is a number: pre-2020
- Omitting the hyphen causes confusion: re-cover (cover again) vs. recover

## Word Replacement Table

Replace complex, formal, or verbose prose with simpler alternatives when technical meaning stays intact. For the full table, read [word replacements](./references/word-replacements.md). Use [style-brand-terms](../style-brand-terms/SKILL.md) as the authority for product vocabulary and interaction verbs. Do not simplify data binding, commands, behaviors, triggers, resource dictionaries, or accessibility state names into different concepts.

Key replacements (most common):

| ❌ Avoid | ✅ Use instead |
|---|---|
| utilize, utilization | use |
| via | through, with, by using |
| leverage | use |
| in order to | to |
| prior to | before |
| subsequent, subsequently | next, after, later |
| commence | start, begin |
| terminate | stop, end |
| facilitate | help, enable |
| indicate | show, display, point to |
| functionality | feature, capability |
| upon | on, after |
| whereas | but, while |
| whilst | while |
| furthermore | also |
| however | but (at sentence start, "However," is acceptable) |
| therefore | so |
| additional | more, extra |
| regarding | about |
| numerous | many |
| sufficient | enough |
| obtain | get |
| provide | give |
| perform | do, run, carry out |
| demonstrate | show |
| currently | now |
| previously | before |
| subsequently | then, next |
| ensure | verify, confirm |
| enable | let, allow |
| disable | turn off |
| specify | enter, type, set |
| select | choose, pick (except for UI actions — see brand-terms skill) |
| component | part, except for a specific UI or API concept |

## Quick Checklist

When reviewing an article for grammar and word choice, verify:

- [ ] Modal verbs distinguish requirements, recommendations, capabilities, and uncertain outcomes
- [ ] No unacceptable contractions (you'll, it's, won't, etc.)
- [ ] Plural nouns for general descriptions; singular only for specific instances
- [ ] Numbers 0–9 spelled out; 10+ as digits
- [ ] Oxford comma in all lists of three or more items
- [ ] En dash for ranges, hyphens for compound modifiers
- [ ] Correct prepositions (in a dialog, on a page, at the command line)
- [ ] No unnecessary hyphens with prefixes
- [ ] Complex prose simplified without changing WPF concepts, identifiers, labels, or accessibility states
- [ ] Periods and commas inside quotation marks
- [ ] Layout units, target frameworks, and tested Telerik/.NET versions remain technically precise
