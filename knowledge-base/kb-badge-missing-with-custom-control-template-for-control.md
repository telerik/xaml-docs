---
title: Badge is Missing When a Control has a Custom Control Template
page_title: Control with Custom Control Template Does Not Display a RadBadge that is Set to it
description: The RadBadge is not present when a control has a custom control template set to it.
type: how-to
slug: kb-badge-missing-with-custom-control-template-for-control
position: 0
tags: badge, missing, control template,
ticketid: 1588541
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.3.1109</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadBadge for WPF</td>
		</tr>
	</tbody>
</table>

## Description

`RadBadge` is not displayed when it is set on a control with custom control template.

## Solution

The RadBadge control requires an `AdornerLayer`, in order to be displayed. When creating a custom ControlTemplate for a control, you could wrap the root element with an `AdornerDecorator` instance to apply an AdornerLayer onto its child elements in the visual tree. 

__Wrapping the root element of a ControlTemplate with an AdornerDecorator__
```XAML
    <Window.Template>
        <ControlTemplate TargetType="{x:Type Window}">
            <AdornerDecorator>
                <Grid x:Name="rootElement">
                    <!--ControlTemplate's structure-->
                </Grid>
            </AdornerDecorator>
        </ControlTemplate>
    </Window.Template>
```