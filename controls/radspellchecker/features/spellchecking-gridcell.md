---
title: SpellChecking GridCell
page_title: SpellChecking GridCell
description: Check our &quot;SpellChecking GridCell&quot; documentation article for the RadSpellChecker {{ site.framework_name }} control.
slug: radspellchecker-spellchecking-gridcell
tags: spellchecking,gridcell
published: True
position: 1
---

# SpellChecking GridCell

>tip For a quick review of the basics you can take a look at the [Getting Started]({%slug radspellchecker-getting-started%}) topic.

Basically, there are two ways to spellcheck a grid cell:

* [Using XAML](#using-xaml)

* [Using Code Behind](#using-code-behind)

## Using XAML

If you choose this approach you can spellcheck only cells which contain a control implementing IControlSpellChecker.

After that you can set the attached property telerik:RadGridViewSpellCheckHelper.IsSpellCheckingEnabled="True", which resides in the telerik namespace to the column and grid in which the cell is placed. Here is an example:

<snippet id='radspellchecker-features-spellchecking-gridcell-block_1-xaml' />

After this is done, every time you try to leave edit mode when in a cell, the spellchecking will be triggered and the CheckAllAtOnce dialog will show up with the contents of the control in the cell. You can perform all the spellchecking you want and when you click OK the text will be transferred back to the cell.

## Using Code Behind

This approach is a little more complex than the former one. Here we can use different panels in the data template of the cell, and choose to spellcheck a certain control in this panel. To do that you need an ordinary button and an attached event handler to it in which you call the appropriate method:

<snippet id='radspellchecker-features-spellchecking-gridcell-block_2-cs' />

>The example above shows how to perform this check on a RadGridView, if you want to do it on __DataGrid__, use __DataGridSpellCheckHelper__ instead of RadGridViewSpellCheckHelper.

As you see, the first argument is the data grid in which we perform the spellchecking, and the second one is the name of the control we want to spellcheck. From then on, things are pretty much the same as in the first scenario – the check-all-at-once window pops-up and does the job.

Here is an example of the XAML:

<snippet id='radspellchecker-features-spellchecking-gridcell-block_3-xaml' />