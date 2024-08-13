---
title: Making RadCalculatorPicker Recognize Period or Comma Key as Decimal
description: Learn how to configure the RadCalculatorPicker in WPF to recognize the period or comma key as a decimal separator.
type: how-to
page_title: Configuring RadCalculatorPicker to Accept Period or Comma as Decimal Separator in WPF
slug: kb-calculator-recognize-period-comma-decimal
tags: radcalculator, wpf, keydown, decimal separator
res_type: kb
ticketid: 1642565
---

## Environment

| Product | Version |
| --- | --- |
| RadCalculator for WPF | Current |

## Description

When using the RadCalculatorPicker on a device without a numeric keypad, the decimal key does not work as expected. This article demonstrates how to make RadCalculatorPicker recognize the period or comma key as a decimal separator. 

## Solution

To make RadCalculatorPicker recognize the period (.) or comma (,) key as the decimal separator, subscribe to the `KeyDown` event and execute the `RadCalculatorCommands.UpdateInput` command.

#### __[C#]__
{{region kb-calculator-recognize-period-comma-decimal-0}}
	private void RadCalculatorPicker_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
	{
		if (e.Key == System.Windows.Input.Key.OemPeriod)
		{
			RadCalculatorCommands.UpdateInput.Execute(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
		}
	}
{{endregion}}
