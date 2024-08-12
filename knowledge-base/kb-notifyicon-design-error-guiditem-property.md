---
title: Design-Time Error is Displayed when Setting the GuidItem Property in XAML
description: This article shows how to resolve a design-time error that is displayed when setting the GuidItem property in XAML.
type: troubleshooting
page_title: Resolve Design-Time Error that is Displayed when Using the GuidItem Property in XAML
slug: kb-notifyicon-design-error-guiditem-property
tags: notifyicon, design-time, guiditem, guid, item
ticketid: 1655464
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2024.3.806</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>RadNotifyIcon for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Setting the `GuidItem` property of the `RadNotifyIcon` control displays a design-time error.

## Solution

The design-time error can come from setting a value to the GuidItem property, which is not of the type of `Guid`.

To prevent the error from being raised, you can define the value as a resource and use a converter to convert it to a new Guid instance.

The following example showcases this approach:

#### __[XAML] Defining the Guid value as a resource__
{{region kb-notifyicon-design-error-guiditem-property-0}}
    <Grid>
        <Grid.Resources>
            <local:StringToGuidConverter x:Key="StringToGuidConverter"/>
            <sys:String x:Key="MyGuidString">6e39f786-db66-42ad-987a-628e1bcb3376</sys:String>
        </Grid.Resources>
        <telerik:RadNotifyIcon GuidItem="{Binding Source={StaticResource MyGuidString}, Converter={StaticResource StringToGuidConverter}}"/>
    </Grid>
{{endregion}}

#### __[C#] Implementing the converter__
{{region kb-notifyicon-design-error-guiditem-property-1}}
    public class StringToGuidConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Guid.Parse(value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
{{endregion}}
