---
name: style-writing-tone
description: "Use this skill when writing, editing, or reviewing Telerik UI for WPF documentation for tone, voice, and writing style. Covers active voice, imperative instructions, tense, direct body text, sentence and paragraph length, global audiences, and inclusivity. Use when asked to 'fix the tone', 'simplify the language', 'make it more direct', or 'check the writing style' in control guides, installation steps, accessibility guidance, or troubleshooting articles."
---

# Writing Tone and Voice

This skill defines the tone, voice, and writing-style rules for Telerik UI for WPF documentation. Apply these rules to every documentation article you write, edit, or review. Use the canonical product name and terminology defined in [style-brand-terms](../style-brand-terms/SKILL.md).

## Why Tone Matters

Documentation is a conversation with the reader. A consistent, direct tone builds trust, reduces ambiguity, and helps readers from any background find information quickly. The rules below exist because readers scan documentation under time pressure — every unnecessary word or indirect construction slows them down.

## Voice: Always Active

Use **active voice** — the subject performs the action. Active voice is shorter, clearer, and easier to translate.

| ❌ Passive | ✅ Active |
|---|---|
| The items are displayed by the DataGrid. | The DataGrid displays the items. |
| The date can be selected by tapping the Calendar. | Tap a date in the Calendar. |
| The viewmodel is assigned by the page. | The page assigns the viewmodel to its `DataContext`. |

Passive voice is acceptable only when the actor is genuinely unknown or irrelevant: "The log file is created during installation."

## Mood: Imperative for Instructions

Use **imperative mood** (direct commands) when telling the reader what to do. Imperative sentences start with a verb and address the reader directly.

| ❌ Avoid | ✅ Imperative |
|---|---|
| You can configure the settings in the dialog box. | Configure the settings in the dialog box. |
| The user should register the Telerik controls first. | Register the Telerik controls first. |
| It is recommended to update the package. | Update the package. |

## Tense: Simple Present

Use **simple present tense** as the default. It is the most direct and universal tense.

| ❌ Avoid | ✅ Simple present |
|---|---|
| The method will return a list. | The method returns a list. |
| The DataForm was showing an error. | The DataForm shows an error. |
| The Calendar is going to display the selected date. | The Calendar displays the selected date. |

Use future tense only when describing something that genuinely happens later in a sequence: "After the data request completes, the app will update the RadGridView."

## Gerunds (-ing Forms) in Body Text

Prefer direct verbs over unnecessary **-ing constructions** in body text. Preserve established technical terms such as data binding, styling, templating, trimming, and dependency injection. Do not change API names or feature names to satisfy a grammar rule.

| ❌ Gerund in body text | ✅ Direct form |
|---|---|
| Tapping the date selects it. | Tap the date to select it. |
| Displaying items requires a data source. | To display items, set `ItemsSource`. |
| The application is loading the data. | The application loads the data. |

**Exception — headings**: -ing forms are acceptable and often preferred in headings and titles: "Binding Data to the RadGridView", "Styling the DataGrid".

## Sentence Length

Keep sentences **25 words or fewer**. Long sentences force the reader to re-read and make translation harder.

- If a sentence exceeds 25 words, split it into two sentences.
- Each sentence should convey one idea.
- Avoid chains of subordinate clauses.

| ❌ Too long | ✅ Split |
|---|---|
| The application loads the appointments that you retrieve from the service and then displays them in the Scheduler that appears on the page for the selected date. | The application retrieves appointments from the service. The Scheduler displays the appointments for the selected date. |

## Paragraph Length

Keep paragraphs **2–4 sentences** long, and never longer than **6 lines** of rendered text.

- A wall of text discourages scanning.
- Short paragraphs create visual breathing room.
- Each paragraph should cover a single point.

## Words and Phrases to Avoid

These words and phrases weaken documentation or patronize the reader:

| ❌ Avoid | Why | ✅ Alternative |
|---|---|---|
| simply, just, easily | Implies the task is trivial; frustrates readers who struggle | Remove the word entirely |
| please | Unnecessary politeness in technical writing | Use imperative directly |
| please note, note that | Filler phrase; if the information matters, state it directly | State the information or use a `>note` block as defined in the formatting skill |
| in order to | Verbose | to |
| let's | Too casual; ambiguous audience | Use imperative or "you can" |
| as well as | Verbose | and |
| make sure | Vague | Verify, Confirm, Ensure |
| a number of | Vague | Several, Many, or a specific count |
| it is important to note | Filler | Remove; state the point directly |

## Writing for Global Audiences

Documentation reaches readers worldwide, many reading in a second language. Follow these rules:

1. **No Latin abbreviations** — Write the full phrase instead.
   - ❌ e.g. → ✅ for example
   - ❌ i.e. → ✅ that is
   - ❌ etc. → ✅ and so on, or list all items
   - ❌ vs. → ✅ compared to, or versus (in full)

2. **No culture-specific references** — Avoid idioms, sports metaphors, holidays, or humor that depends on cultural context.
   - ❌ "hit a home run" → ✅ "succeed"
   - ❌ "out of the box" → ✅ "by default" or "without configuration"

3. **No jargon without explanation** — If a technical term is essential, define it on first use or link to a glossary.

4. **Short, common words** — Prefer everyday words over formal or Latinate alternatives. See the `style-grammar-words` skill for the full replacement table.

5. **Explicit platform scope** — Name the affected platform and input method. Do not turn a verified Windows keyboard workflow into a claim about all platforms.

6. **Evidence-based claims** — Describe the tested .NET and Telerik versions. Do not promise accessibility compliance, identical native behavior, or future platform support without evidence.

## Inclusivity and Pronouns

- Use **gender-neutral language**. Prefer "they/them" as a singular pronoun when the gender is unknown.
  - ❌ "The user should save his file." → ✅ "The user should save their file." or better: "Save your file."
- Address the reader as **"you"** in instructional content.
- Avoid **"we"** unless referring to a specific team or company action. Never use "we" to mean the reader.

## Second Person ("You")

Address the reader directly as "you" in instructional and conceptual content. This creates a conversational, direct tone.

| ❌ Third person | ✅ Second person |
|---|---|
| The developer can use the API to... | You can use the API to... |
| Users need to configure... | Configure... (imperative) or You need to configure... |

## Quick Checklist

When reviewing an article for tone and voice, verify:

- [ ] All instructions use imperative mood
- [ ] Body text uses active voice (passive only when actor is unknown)
- [ ] Simple present tense is the default
- [ ] Direct body text without unnecessary -ing constructions; WPF feature names remain intact
- [ ] Sentences are 25 words or fewer
- [ ] Paragraphs are 2–4 sentences, ≤6 lines
- [ ] No "simply", "just", "easily", "please", "let's", "note that"
- [ ] No Latin abbreviations (e.g., i.e., etc., vs.)
- [ ] No culture-specific references or idioms
- [ ] Gender-neutral language throughout
- [ ] Reader addressed as "you" in instructional content
- [ ] Canonical product and control names match the terminology skill
- [ ] Platform, version, accessibility, and runtime claims retain their verified scope
