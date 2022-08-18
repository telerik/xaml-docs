---
title: Fix Pixelated or Distorted Buttons
page_title: How to Fix Pixelated Buttons
description: Fix distorted buttons.
type: how-to
slug: kb-buttons-distorted-or-pixelated-buttons
position: 0
tags: distorted, pixelated, DELL, buttons
ticketid: 1544097
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2022.2 621</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadButtons for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Buttons can appear distorted or pixelated on __Dell__ machines. This behavior can also be present in some of the native WPF controls.

## Solution

1. Open the __BlackApps.dat__ that can be found on this path: __C:\ProgramData\A-Volute\DellInc.AlienwareSoundCenter\Modules\ScheduledModules\Configurator\BlackApps.dat__

2. Append the name of your process at the end of the file (for example, __MyApplication.exe__) and save it.