---
title: Resizing RadRating Item Visuals in Telerik Themes with Glyph Icons
description: Learn how to customize the size of rating visuals in the RadRating control for WPF applications.
type: how-to
page_title: How to Resize Rating Item Symbols in RadRating for WPF
slug: kb-rating-resize-item-symbols
tags: radrating, wpf, resize, ratingitem, glyph, fontsize, style
res_type: kb
ticketid: 1652842
---

## Environment

| Product | Version |
| --- | --- |
| RadRating for WPF | 2024.2.514 |

## Description

How to resize the star shapes in RadRating in newer Telerik themes (Material and later). In these themes, the rating visuals uses `RadGlyph` visuals. This article shows how to change their `FontSize`.

## Solution

To change the size of the stars in `RadRating`, you can use a custom attached property that finds the `RadGlyph` elements and sets their `FontSize`. The property can be assigned to the `RadRatingItem` elements using an implicit style.

__Defining the attached property__
```C#
     public static class RadGlyphUtilities
    {
        public static double GetFontSize(DependencyObject obj)
        {
            return (double)obj.GetValue(FontSizeProperty);
        }

        public static void SetFontSize(DependencyObject obj, double value)
        {
            obj.SetValue(FontSizeProperty, value);
        }
                
        public static readonly DependencyProperty FontSizeProperty =
            DependencyProperty.RegisterAttached(
                "FontSize",
                typeof(double), 
                typeof(RadGlyphUtilities), 
                new PropertyMetadata(-1d, OnFontSizeChanged));

        private static void OnFontSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {            
            if (d is RadGlyph)
            {
                ((RadGlyph)d).FontSize = (double)e.NewValue;
                return;
            }
            
            var element = (FrameworkElement)d;
            if (element.IsLoaded)
            {
                SetGlyphsFontSize(element, (double)e.NewValue);
            }
            else
            {
                element.Loaded += Element_Loaded;
            }
        }

        private static void Element_Loaded(object sender, RoutedEventArgs e)
        {
            var element = (FrameworkElement)sender;
            SetGlyphsFontSize(element, GetFontSize(element));
            element.Loaded -= Element_Loaded;
        }

        private static void SetGlyphsFontSize(FrameworkElement parent, double fontSize)
        {
            var glyphs = parent.ChildrenOfType<RadGlyph>();
            foreach (RadGlyph glyph in glyphs)
            {
                glyph.SetCurrentValue(RadGlyph.FontSizeProperty, fontSize);
            }
        }
    }
```

__Using the attached property__
```XAML
	<Window.Resources>
		<Style TargetType="{x:Type telerik:RadRatingItem}">
			<Setter Property="MaxWidth" Value="15" />
			<Setter Property="local:RadGlyphUtilities.FontSize" Value="14" />
		</Style>
	</Window.Resources>
```



