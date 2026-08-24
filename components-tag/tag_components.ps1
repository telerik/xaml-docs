param([switch]$Write)

$root = $PSScriptRoot | Split-Path -Parent
$excluded = @('kb', 'api', 'images', 'radchart')

# Folder-name overrides for folders whose normalized name doesn't match a canonical component.
$overrides = @{ 'ai-assistant' = 'general'; 'radtreemap' = 'treemapandpivotmap' }

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
