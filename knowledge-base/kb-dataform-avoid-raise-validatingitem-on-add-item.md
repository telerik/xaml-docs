---
title: Avoid Raising ValidatingItem on Add Button Click
page_title: Prevent Validating Property When Add New Item
description: Create custom command provider to avoid calling ValidatingItem event when creating new item.
type: how-to
slug: kb-dataform-avoid-raise-validatingitem-on-add-item
position: 0
tags: validatingitem,commandprovider
ticketid: 1418079
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product Version</td>
	    	<td>2018.3.1016</td>
	    </tr>
	    <tr>
	    	<td>Product</td>
	    	<td>RadDataForm for WPF</td>
	    </tr>
    </tbody>
</table>

## Description

How to avoid raising validation when the Add button of RadDataForm gets clicked.

## Solution

Create a custom __DataFormCommandProvider__ and override its __AddNew__ method. In the method call only the __AddNewItem__ method of RadDataForm.


```C#
	public class CustomCommandProvider : DataFormCommandProvider
	{
		public CustomCommandProvider() : base(null)
		{
		}
		public CustomCommandProvider(RadDataForm dataForm)
				: base(dataForm)
		{
			this.DataForm = dataForm;
		}
	 
		protected override void AddNew()
		{
			if (this.DataForm != null)
			{
				this.DataForm.AddNewItem();
			}
		}
	}
```

Then assign the custom provider to the __CommandProvider__ property of RadDataForm.


```C#
	this.radDataForm.CommandProvider = new CustomCommandProvider(this.radDataForm);
```

## See Also  
* [Customizing Commands]({%slug raddataform-customize-commands%})