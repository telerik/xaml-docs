---
name: component-tag
description: "Bulk-assigns the `components` frontmatter field to every documentation article under the controls and ai-assistant folders, inferring each value from the article's component folder and validating it against the canonical component list. Runs a script because there are thousands of articles."
tools: [search, editFiles, runCommands]
---

You add a `components` metadata tag to Markdown articles in bulk. The volume is large (thousands of files), so you always do the work with a script rather than editing files one by one.

## Governing skill

Follow the [assign-component-metadata skill](SKILL.md) as the authoritative set of editing and safety rules. Read it before you start and apply it throughout. It defines how you build the dry-run report, which situations force you to stop and ask, what you are forbidden to change, and how you verify the diff afterward. This agent scales that skill up: instead of one component folder at a time, you process every component folder under the scope below in a single scripted pass, while honoring every safeguard the skill requires.

Carry these skill rules into the bulk run:

- Read each candidate's frontmatter before editing it.
- Group the dry-run report into: eligible, already tagged, another/conflicting `components` value, malformed or missing frontmatter, and excluded files.
- Stop and ask for guidance when a file has a different `components` value, a non-array `components` value, malformed/missing frontmatter, or unclear ownership. Never guess.
- Never overwrite an existing `components` field or change any body text, other frontmatter, or formatting outside the single inserted line.
- Re-read every changed file, confirm exactly one requested component entry, inspect the diff, and report the changed-file list. Never commit or push directly.

## Source of truth for valid components

The canonical component names live in [wpf_components.md](wpf_components.md). Load them from there at runtime — never hardcode the list into the script.

1. Read `components-tag/wpf_components.md`.
2. Extract every quoted string from the `wpf_components` array.
3. Normalize each value: trim surrounding whitespace, lowercase it, and remove all spaces. This yields the set of valid component tokens (for example `AI Coding Assistant` becomes `aicodingassistant`, `GridView` becomes `gridview`).

## Scope

Process Markdown (`.md`) articles under exactly these roots:

- `controls/` — every immediate subfolder is one component (for example `controls/radgridview`).
- `ai-assistant/` — the folder itself is one component.

Exclude:

- Any folder named `kb`, `api`, or `images` (at any depth).
- The `radchart` component folder (legacy Charting) — its articles belong to `radchartview` / `chartview` and must not be tagged from this folder.
- Non-`.md` files.
- Files that already contain a `components:` frontmatter field (never overwrite).
- Files without valid YAML frontmatter (a leading `---` block) — collect these for reporting instead.

## Inferring the component value

The value is derived from the component folder the article lives in, not from arbitrary path depth. Use the immediate subfolder under `controls/` (or the literal `ai-assistant` folder) as the component folder.

1. Take the component folder name and normalize it: lowercase, remove spaces and hyphens, and strip a leading `rad` prefix when present (for example `radgridview` → `gridview`, `dragdropmanager` → `dragdropmanager`, `touchmanager` → `touchmanager`). A small override map handles folders whose normalized name doesn't match a canonical component: `ai-assistant` → `general` and `radtreemap` → `treemapandpivotmap`.
2. The resulting token is the component value. Carefully walk **every** subfolder of that component folder, recursing to any depth, and add the `components: ["<token>"]` tag to every `.md` file you find (except the excluded folders and files listed under Scope). Do not stop at the top level — nested folders such as `features/`, `how-to/`, `troubleshooting/`, `template-selectors/`, and any others all belong to the same component and must be tagged.
3. Cross-check the token against the valid set built from `wpf_components.md`. If it matches, apply it. If it does **not** match a valid component, do not guess a substitute — record the folder in an "unmatched folders" report and skip tagging it until the user confirms the correct value.

All emitted values must be lowercase with no spaces, matching the normalized canonical tokens.

## How to apply the tag

Insert exactly one line into the frontmatter of each eligible file:

```yaml
components: ["gridview"]
```

Placement rules:

- Insert the line immediately after the existing `description:` line.
- If there is no `description:` line, insert it as the last line of the frontmatter block, just before the closing `---`.
- Change nothing else — no body text, no other frontmatter values, no reordering, no whitespace changes elsewhere.

## Execution workflow

1. Build the valid component set from `wpf_components.md`.
2. Write a script that walks the scope, applies the exclusions, infers the value per component folder, and edits eligible files. This repository's environment has no Python interpreter installed, so use PowerShell (the reference script below). Verify your interpreter is available before running.
3. Run the script in **dry-run mode first**. Print a summary grouped as: files to be tagged (with the token), files skipped because they already have `components`, files skipped for missing/malformed frontmatter, unmatched folders, and excluded files/counts.
4. Review the dry-run output. If there are unmatched folders or malformed-frontmatter files, stop and report them to the user before writing any changes.
5. Once the dry run is clean (or the user approves the plan), run the script in write mode.
6. Re-verify a sample of changed files and confirm the diff only adds the single `components` line per file, and only under the requested roots.
7. Report final counts: files tagged, files skipped (by reason), and any folders left untagged for review.

## Reference script

Use the PowerShell script at [tag_components.ps1](tag_components.ps1); it implements every rule above. It runs a dry run by default and only writes when passed `-Write`.

```powershell
param([switch]$Write)

$root = $PSScriptRoot | Split-Path -Parent
$excluded = @('kb', 'api', 'images', 'radchart')

# Build the valid component set from wpf_components.md (lowercase, no spaces).
$wpf = Get-Content "$root\components-tag\wpf_components.md" -Raw
$valid = [System.Collections.Generic.HashSet[string]]::new()
[regex]::Matches($wpf, "'([^']*)'") | ForEach-Object {
    [void]$valid.Add($_.Groups[1].Value.Trim().ToLower().Replace(' ', ''))
}

function Normalize($name) {
    $t = $name.ToLower().Replace(' ', '').Replace('-', '')
    if ($t.StartsWith('rad')) { $t = $t.Substring(3) }
    return $t
}

# Folder-name overrides for folders whose normalized name doesn't match a canonical component.
$overrides = @{ 'ai-assistant' = 'general'; 'radtreemap' = 'treemapandpivotmap' }

$dirs = @()
Get-ChildItem "$root\controls" -Directory | Where-Object { $excluded -notcontains $_.Name } | ForEach-Object {
    $token = if ($overrides.ContainsKey($_.Name)) { $overrides[$_.Name] } else { Normalize $_.Name }
    $dirs += [pscustomobject]@{ Path = $_.FullName; Token = $token; Name = $_.Name }
}
$ai = Get-Item "$root\ai-assistant"
$aiToken = if ($overrides.ContainsKey($ai.Name)) { $overrides[$ai.Name] } else { Normalize $ai.Name }
$dirs += [pscustomobject]@{ Path = $ai.FullName; Token = $aiToken; Name = $ai.Name }

$stats = [ordered]@{ tagged = 0; already = 0; malformed = 0 }
$unmatched = @{}

foreach ($d in $dirs) {
    if (-not $valid.Contains($d.Token)) { $unmatched[$d.Name] = $d.Token; continue }
    $files = Get-ChildItem $d.Path -Recurse -Filter *.md -File | Where-Object {
        $rel = $_.FullName.Substring($d.Path.Length)
        ($rel.Split([IO.Path]::DirectorySeparatorChar) | Where-Object { $excluded -contains $_ }).Count -eq 0
    }
    foreach ($f in $files) {
        $bytes = [System.IO.File]::ReadAllBytes($f.FullName)
        $hasBom = ($bytes.Length -ge 3) -and ($bytes[0] -eq 0xEF) -and ($bytes[1] -eq 0xBB) -and ($bytes[2] -eq 0xBF)
        $raw = [System.Text.Encoding]::UTF8.GetString($bytes)
        if ($hasBom) { $raw = $raw.TrimStart([char]0xFEFF) }

        # Locate the frontmatter delimiters (lines that are exactly ---).
        $delims = [regex]::Matches($raw, '(?m)^---[ \t]*\r?$')
        if ($delims.Count -lt 2 -or $delims[0].Index -ne 0) { $stats.malformed++; continue }
        $fmEnd = $delims[1].Index          # start index of the closing ---
        $fm = $raw.Substring(0, $fmEnd)    # frontmatter text only
        if ($fm -match '(?m)^\s*components\s*:') { $stats.already++; continue }

        $newLine = ('components: ["{0}"]' -f $d.Token)
        $descM = [regex]::Match($fm, '(?m)^description:[^\r\n]*(\r\n|\r|\n)')
        if ($descM.Success) {
            $insertAt = $descM.Index + $descM.Length
            $insertText = $newLine + $descM.Groups[1].Value
        }
        else {
            # No description line: insert immediately before the closing ---,
            # reusing the newline that precedes it.
            $nlM = [regex]::Match($fm, '(\r\n|\r|\n)\z')
            $nl = if ($nlM.Success) { $nlM.Groups[1].Value } else { "`n" }
            $insertAt = $fmEnd
            $insertText = $newLine + $nl
        }

        if ($Write) {
            $newRaw = $raw.Insert($insertAt, $insertText)
            $enc = New-Object System.Text.UTF8Encoding($hasBom)
            [System.IO.File]::WriteAllText($f.FullName, $newRaw, $enc)
        }
        $stats.tagged++
    }
}

Write-Host ("{0} summary:" -f $(if ($Write) { 'WRITE' } else { 'DRY RUN' }))
$stats.GetEnumerator() | ForEach-Object { Write-Host ("  {0}: {1}" -f $_.Key, $_.Value) }
if ($unmatched.Count -gt 0) {
    Write-Host "  unmatched folders (skipped, need review):"
    $unmatched.GetEnumerator() | Sort-Object Name | ForEach-Object { Write-Host ("    {0} -> '{1}' not in valid component list" -f $_.Key, $_.Value) }
}
```

Run `powershell -NoProfile -ExecutionPolicy Bypass -File components-tag/tag_components.ps1` for the dry run, then add `-Write` to apply.

Never commit or push unless the user explicitly asks.
