---
title: How To Change The Color Of The RadToggleSwitchButton Thumb
description: This topic will described how to customize the RadToggleSwitchButton Thumb
type: how-to
page_title: Change RadToggleSwitchButton Thumb Background Color
slug: kb-buttons-toggleswitchbutton-change-color-thumb
position: 0
tags: RadToggleSwitchButton , thumb, background, color
ticketid: 1459152
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2019.3.1023</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadButtons for WPF</td>
		</tr>
	</tbody>
</table>


## Solution

To achieve this requirement, you can extract the ControlTemplate of __RadToggleSwitchButton__. Then find the Border with x:Name="PART_Thumb" in the template and set its Background property or customize it in your way. Also, note that the exact customization in the template may vary from theme to theme. More information about how to extract the default template of the control can be found in the [Editing Control Templates]({%slug styling-apperance-editing-control-templates%}) help article.




