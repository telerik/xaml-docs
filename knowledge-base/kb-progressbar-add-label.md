---
title: Display Label with ProgressBar Value
description: Show label on top of the progress bar indicating the current progress.
type: how-to
page_title: Add Label in the ProgressBar Control
slug: kb-progressbar-add-label
position: 0
tags: label,text,value
ticketid: 1582159
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2022.3.912</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadProgressBar for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to add label on top of the `RadProgressBar` indicating the current progress.

## Solution

Add `TextBlock` element in a `Canvas` panel placed on top of the ProgressBar.


```XAML
	<Grid Width="250" Height="30">
		<telerik:RadProgressBar x:Name="progressBar" Minimum="0" Maximum="100" 
								Value="40" ValueChanged="RadProgressBar_ValueChanged"
								Loaded="progressBar_Loaded"/>
		<Canvas>
			<TextBlock x:Name="progressBarLabel" VerticalAlignment="Center" Canvas.Top="6"/>
		</Canvas>
	</Grid>
```

In code-behind update the `Text` and the left position of the `TextBlock` in the canvas.


```C#
	private void UpdateLabel()
	{
		double delta = progressBar.Maximum - this.progressBar.Minimum;
		double normalizedValue = this.progressBar.Value / delta;

		double offsetFromProgressValue = 5;
		double labelOffset = this.progressBar.ActualWidth * normalizedValue;
		this.progressBarLabel.Text = (normalizedValue * 100) + "%";
		Canvas.SetLeft(this.progressBarLabel, labelOffset + offsetFromProgressValue);
	}

	private void RadProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		if (this.progressBarLabel != null)
		{
			UpdateLabel();
		}            
	}
	
	private void progressBar_Loaded(object sender, RoutedEventArgs e)
	{
		this.UpdateLabel();
	}
```

![Custom ProgressBar Label](images/kb-progressbar-add-label-0.png)