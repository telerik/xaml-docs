---
name: assign-component-metadata
description: "Use when assigning or validating components metadata in Markdown frontmatter for documentation articles. Processes one component folder at a time, supports dry runs, detects conflicts, and validates the resulting diff."
---

# Assign Component Metadata

Use this skill to add the repository's `components` frontmatter field to articles belonging to one component folder. This is an agent-driven Markdown edit workflow; it does not require Ruby, a script, or another runtime.

## Workflow

1. Identify exactly one component folder, such as `controls/grid`. The component value is the folder name, `grid` in this example.
2. Recursively list Markdown files below that folder. Exclude image/template directories and do not process files outside the requested folder.
3. Read the frontmatter of every candidate file before editing anything.
4. Build a dry-run report with these groups: eligible files, files already containing the requested component, files with another `components` value, malformed or missing frontmatter, and excluded files.
5. Stop and ask for guidance if any file has another component, a non-array `components` value, malformed/missing frontmatter, or unclear ownership.
6. For eligible files only, add exactly this line immediately after `slug`:

   ```yaml
   components: ["grid"]
   ```

7. Do not change article body text, existing frontmatter values, formatting outside the inserted line, or files outside the requested component folder.
8. Re-read every changed file and verify that it has exactly one requested component entry.
9. Inspect the diff and report the changed-file list. Never commit or push unless explicitly requested.

Process components in separate batches. Do not process the repository root or shared folders without an explicit component mapping.