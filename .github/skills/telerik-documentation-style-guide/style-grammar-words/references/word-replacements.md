# Word Replacement Table

This reference lists simpler prose alternatives for Telerik UI for WPF documentation. Apply replacements only when they preserve technical meaning. Do not rewrite XAML, C#, API identifiers, UI labels, quoted diagnostics, package names, or version strings. Use the [grammar skill](../SKILL.md) with the [WPF terminology skill](../../style-brand-terms/SKILL.md).

Preserve established terms such as data binding, commands, behaviors, triggers, resource dictionaries, Shell Navigation, and dependency injection. The tables guide editing decisions; they are not unconditional lint replacements.

## Table of Contents

- [Formal Words → Simple Alternatives](#formal-words)
- [Verbose Phrases → Concise Alternatives](#verbose-phrases)
- [Ambiguous or Problematic Terms](#ambiguous-terms)

## Formal Words

| ❌ Avoid | ✅ Use instead | Notes |
|---|---|---|
| abort | stop, cancel | |
| additional | more, extra | |
| adjacent | next to | |
| allocate | assign, give | |
| anticipate | expect | |
| apparent | clear, obvious | |
| approximately | about, around | |
| assist | help | |
| cease | stop | |
| cognizant | aware | |
| commence | start, begin | |
| component | part | Unless a specific UI or code term |
| comprise | include, contain | |
| consequently | so, as a result | |
| construct | build, create | Unless a specific code term |
| consume | use | Unless a specific code term (API consumption) |
| currently | now | |
| demonstrate | show | |
| depress (a key) | press | |
| designate | name, assign | |
| desire | want | |
| determine | find, find out | |
| disclose | show, reveal | |
| discontinue | stop | |
| disseminate | distribute, share | |
| elect | choose | |
| employ | use | |
| enable | let, allow, turn on | Context-dependent |
| encounter | find, experience | |
| endeavor | try | |
| enumerate | list | Unless a specific code term |
| establish | set up, create | |
| facilitate | help, enable | |
| finalize | finish, complete | |
| frequently | often | |
| functionality | feature, capability | |
| furnish | give, provide | |
| however | but | At sentence start, "However," is acceptable |
| illuminate | explain, clarify | |
| implement | build, create, set up | Unless a specific code term |
| indicate | show, display, point to | |
| initiate | start, begin | |
| inquire | ask | |
| instantiate | create | Unless specific code context |
| leverage | use | |
| locate | find | |
| methodology | method | |
| modify | change, update | |
| monitor | watch, check | |
| necessitate | need, require | |
| notify | tell, alert | |
| numerous | many | |
| obtain | get | |
| operate | run, use | |
| optimal | best | |
| parameters | settings, values | Unless specific code context |
| perform | do, run | |
| permit | let, allow | |
| populate | fill, fill in | |
| portion | part | |
| possess | have | |
| preceding | previous, before | |
| previously | before, earlier | |
| principal | main | |
| proceed | go, continue | |
| procure | get | |
| provide | give | |
| purchase | buy | |
| regarding | about | |
| relocate | move | |
| remainder | rest | |
| render | draw, display | Preserve precise WPF graphics or PdfProcessing rendering terminology |
| request | ask for | |
| require | need | |
| reside | live, be | |
| retain | keep | |
| retrieve | get, fetch | |
| select | choose, pick | Exception: UI action "select" — see brand-terms skill |
| specify | enter, type, set | |
| submit | send | |
| subsequent | next, later | |
| subsequently | then, next | |
| sufficient | enough | |
| terminate | stop, end, close | |
| therefore | so | |
| transmit | send | |
| upon | on, after | |
| usage | use | |
| utilize, utilization | use | |
| validate | check, verify | Unless specific code context |
| verbose | detailed | Unless specific code context |
| verify | check, confirm | All three are acceptable; do not cycle between equivalent replacements |
| via | through, with, by using | |
| whereas | but, while | |
| whilst | while | |

## Verbose Phrases

| ❌ Avoid | ✅ Use instead |
|---|---|
| a large number of | many |
| a number of | several, some |
| a small number of | a few |
| as a consequence of | because of |
| as a result of | because of |
| as well as | and |
| at the present time | now |
| at this point in time | now |
| be advised that | (remove — state the point directly) |
| by means of | with, by, through |
| due to the fact that | because |
| for the purpose of | to, for |
| for the reason that | because |
| has the ability to | can |
| has the capacity to | can |
| in accordance with | by, following, per |
| in addition to | besides, also |
| in an effort to | to |
| in close proximity to | near |
| in lieu of | instead of |
| in order to | to |
| in regard to | about |
| in the event that | if |
| in the process of | (remove — use the verb directly) |
| is able to | can |
| is required to | must |
| it is important to note that | (remove — state the point) |
| it is necessary to | you must, you need to |
| it is possible that | (something) might, can |
| it should be noted that | (remove — state the point) |
| make sure | verify, confirm, ensure |
| not unlike | like, similar to |
| on a daily basis | daily |
| on the grounds that | because |
| pertaining to | about, for |
| please note that | (remove — state the point directly) |
| prior to | before |
| provided that | if |
| take into consideration | consider |
| with reference to | about |
| with regard to | about |
| with respect to | about, for |
| with the exception of | except |

## Ambiguous Terms

These terms have specific issues beyond being verbose:

| Term | Issue | Replacement |
|---|---|---|
| since, as of | Ambiguous — temporal or causal? | Use "because" for cause, "starting with" for time |
| older, newer | Ambiguous for software versions | Use "earlier" or "later" |
| lower, higher | Ambiguous for software versions | Use "earlier" or "later" |
| above, below | Fragile document references | Use specific references: "the previous section", "the following example" |
| disabled, grayed out | Can be imprecise or visual-only | Use "unavailable" for general UI prose; retain "disabled" for a precise accessibility state and preserve `IsEnabled` |
| click on | Redundant preposition | Use "click" (no "on") |
| e.g. | Latin abbreviation | Use "for example" |
| i.e. | Latin abbreviation | Use "that is" |
| etc. | Latin abbreviation | Use "and so on" or list all items |
| vs. | Latin abbreviation | Use "compared to" or "versus" |
| N/A | Abbreviation | Use "not applicable" |
| ASAP | Abbreviation | Use "as soon as possible" |
