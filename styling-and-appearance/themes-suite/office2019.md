---
title: Office2019 Theme
page_title: Office2019 Theme
description: Familiarize yourself with the Office2019 theme, inspired by the well-known Microsoft Office productivity suite and its latest version.
slug: common-styling-appearance-Office2019-theme
tags: Office2019,theme,glyphs,fontsize,fontfamily
published: True
position: 3
---

<style>
.theme-palette-color {
	width:20px;
	height:20px;
	margin: auto;
	border: 1px solid black;
}

.Office2019theme-accentbackgroundbrush{
	background: #106EBE;
}
.Office2019theme-accentborderbrush{
	background: #106EBE;
}
.Office2019theme-accentmouseoverbackgroundbrush{
	background: #D4E8F8;
}
.Office2019theme-accentmouseoverborderbrush{
	background: #2F96ED;
}
.Office2019theme-accentpressedbackgroundbrush{
	background: #A1CDED;
}
.Office2019theme-alternativebackgroundbrush{
	background: #F1F1F1;
}
.Office2019theme-basebackgroundbrush{
	background: #DFDFDF;
}
.Office2019theme-buttonbackgroundbrush{
	background: #E5E5E5;
}
.Office2019theme-checkedforegroundbrush{
	background: #FFFFFF;
}
.Office2019theme-disabledbackgroundbrush{
	background: #F1F1F1;
}
.Office2019theme-disabledborderbrush{
	background: #D6D6D6;
}
.Office2019theme-headerbackgroundbrush{
	background: #106EBE;
}
.Office2019theme-headerforegroundbrush{
	background: #FFFFFF;
}
.Office2019theme-highlightedforegroundbrush{
	background: #2F2F2F;
}
.Office2019theme-iconbrush{
	background: #606060;
}
.Office2019theme-mainbackgroundbrush{
	background: #FFFFFF;
}
.Office2019theme-mainborderbrush{
	background: #ACACAC;
}
.Office2019theme-mainforegroundbrush{
	background: #000000;
}
.Office2019theme-mouseoverbackgroundbrush{
	background: #C8C7C4;
}
.Office2019theme-pressedbackgroundbrush{
	background: #B3AFAD;
}
.Office2019theme-readonlybackgroundbrush{
	background: #FFFFFF;
}
.Office2019theme-readonlyborderbrush{
	background: #ACACAC;
}
.Office2019theme-secondarybackgroundbrush{
	background: #D6D5D5;
}
.Office2019theme-secondaryforegroundbrush{
	background: #000000;
}
.Office2019theme-validationbrush{
	background: #E43E00;
}
/* New brushes since R3 2021 */
.Office2019theme-disabledcheckedforegroundbrush{
	background: #FFFFFF;
}
.Office2019theme-disabledforegroundbrush{
	background: #000000;
}
.Office2019theme-disablediconbrush{
	background: #606060;
}
.Office2019theme-iconwrapperbrush{
	background: transparent;
}
.Office2019theme-selectedunfocusedbackgroundbrush{
	background: #E5E5E5;
}
.Office2019theme-tertiarybackgroundbrush{
	background: #F1F1F1;
}

/* Gray variation */
.Office2019theme-accentbackgroundbrush-gray{
	background: #106EBE;
}
.Office2019theme-accentborderbrush-gray{
	background: #106EBE;
}
.Office2019theme-accentmouseoverbackgroundbrush-gray{
	background: #D4E8F8;
}
.Office2019theme-accentmouseoverborderbrush-gray{
	background: #2F96ED;
}
.Office2019theme-accentpressedbackgroundbrush-gray{
	background: #A1CDED;
}
.Office2019theme-alternativebackgroundbrush-gray{
	background: #CBCBCB;
}
.Office2019theme-basebackgroundbrush-gray{
	background: #767272;
}
.Office2019theme-buttonbackgroundbrush-gray{
	background: #BFBFBF;
}
.Office2019theme-checkedforegroundbrush-gray{
	background: #FFFFFF;
}
.Office2019theme-disabledbackgroundbrush-gray{
	background: #CBCBCB;
}
.Office2019theme-disabledborderbrush-gray{
	background: #BEBEBE;
}
.Office2019theme-headerbackgroundbrush-gray{
	background: #106EBE;
}
.Office2019theme-headerforegroundbrush-gray{
	background: #FFFFFF;
}
.Office2019theme-highlightedforegroundbrush-gray{
	background: #2F2F2F;
}
.Office2019theme-iconbrush-gray{
	background: #333333;
}
.Office2019theme-mainbackgroundbrush-gray{
	background: #E2E2E2;
}
.Office2019theme-mainborderbrush-gray{
	background: #A6A6A6;
}
.Office2019theme-mainforegroundbrush-gray{
	background: #000000;
}
.Office2019theme-mouseoverbackgroundbrush-gray{
	background: #ACACAC;
}
.Office2019theme-pressedbackgroundbrush-gray{
	background: #918E8D;
}
.Office2019theme-readonlybackgroundbrush-gray{
	background: #E2E2E2;
}
.Office2019theme-readonlyborderbrush-gray{
	background: #A6A6A6;
}
.Office2019theme-secondarybackgroundbrush-gray{
	background: #B6B3B1;
}
.Office2019theme-secondaryforegroundbrush-gray{
	background: #FFFFFF;
}
.Office2019theme-validationbrush-gray{
	background: #E43E00;
}
/* New brushes since R3 2021 */
.Office2019theme-disabledcheckedforegroundbrush-gray{
	background: #FFFFFF;
}
.Office2019theme-disabledforegroundbrush-gray{
	background: #000000;
}
.Office2019theme-disablediconbrush-gray{
	background: #333333;
}
.Office2019theme-iconwrapperbrush-gray{
	background: transparent;
}
.Office2019theme-selectedunfocusedbackgroundbrush-gray{
	background: #BFBFBF;
}
.Office2019theme-tertiarybackgroundbrush-gray{
	background: #CBCBCB;
}

/* Dark variation */
.Office2019theme-accentbackgroundbrush-dark{
	background: #106EBE;
}
.Office2019theme-accentborderbrush-dark{
	background: #106EBE;
}
.Office2019theme-accentmouseoverbackgroundbrush-dark{
	background: #D4E8F8;
}
.Office2019theme-accentmouseoverborderbrush-dark{
	background: #2F96ED;
}
.Office2019theme-accentpressedbackgroundbrush-dark{
	background: #A1CDED;
}
.Office2019theme-alternativebackgroundbrush-dark{
	background: #3C3C3C;
}
.Office2019theme-basebackgroundbrush-dark{
	background: #151515;
}
.Office2019theme-buttonbackgroundbrush-dark{
	background: #3D3D3D;
}
.Office2019theme-checkedforegroundbrush-dark{
	background: #FFFFFF;
}
.Office2019theme-disabledbackgroundbrush-dark{
	background: #3F3E3C;
}
.Office2019theme-disabledborderbrush-dark{
	background: #4F4F4F;
}
.Office2019theme-headerbackgroundbrush-dark{
	background: #106EBE;
}
.Office2019theme-headerforegroundbrush-dark{
	background: #FFFFFF;
}
.Office2019theme-highlightedforegroundbrush-dark{
	background: #2F2F2F;
}
.Office2019theme-iconbrush-dark{
	background: #A6A6A6;
}
.Office2019theme-mainbackgroundbrush-dark{
	background: #2F2F2F;
}
.Office2019theme-mainborderbrush-dark{
	background: #606060;
}
.Office2019theme-mainforegroundbrush-dark{
	background: #F1F1F1;
}
.Office2019theme-mouseoverbackgroundbrush-dark{
	background: #B3AFAD;
}
.Office2019theme-pressedbackgroundbrush-dark{
	background: #767676;
}
.Office2019theme-readonlybackgroundbrush-dark{
	background: #2F2F2F;
}
.Office2019theme-readonlyborderbrush-dark{
	background: #606060;
}
.Office2019theme-secondarybackgroundbrush-dark{
	background: #2B2B2B;
}
.Office2019theme-secondaryforegroundbrush-dark{
	background: #F1F1F1;
}
.Office2019theme-validationbrush-dark{
	background: #E43E00;
}
/* New brushes since R3 2021 */
.Office2019theme-disabledcheckedforegroundbrush-dark{
	background: #FFFFFF;
}
.Office2019theme-disabledforegroundbrush-dark{
	background: #F1F1F1;
}
.Office2019theme-disablediconbrush-dark{
	background: #A6A6A6;
}
.Office2019theme-iconwrapperbrush-dark{
	background: transparent;
}
.Office2019theme-selectedunfocusedbackgroundbrush-dark{
	background: #3D3D3D;
}
.Office2019theme-tertiarybackgroundbrush-dark{
	background: #3C3C3C;
}

/* HighContrast variation */
.Office2019theme-accentbackgroundbrush-highcontrast{
	background: #1AEBFF;
}
.Office2019theme-accentborderbrush-highcontrast{
	background: #1AEBFF;
}
.Office2019theme-accentmouseoverbackgroundbrush-highcontrast{
	background: #FFFF00;
}
.Office2019theme-accentmouseoverborderbrush-highcontrast{
	background: #1AEBFF;
}
.Office2019theme-accentpressedbackgroundbrush-highcontrast{
	background: #1AEBFF;
}
.Office2019theme-alternativebackgroundbrush-highcontrast{
	background: #000000;
}
.Office2019theme-basebackgroundbrush-highcontrast{
	background: #000000;
}
.Office2019theme-buttonbackgroundbrush-highcontrast{
	background: #000000;
}
.Office2019theme-checkedforegroundbrush-highcontrast{
	background: #000000;
}
.Office2019theme-disabledbackgroundbrush-highcontrast{
	background: #808080;
}
.Office2019theme-disabledborderbrush-highcontrast{
	background: #FFFFFF;
}
.Office2019theme-headerbackgroundbrush-highcontrast{
	background: #37006E;
}
.Office2019theme-headerforegroundbrush-highcontrast{
	background: #FFFFFF;
}
.Office2019theme-highlightedforegroundbrush-highcontrast{
	background: #000000;
}
.Office2019theme-iconbrush-highcontrast{
	background: #FFFFFF;
}
.Office2019theme-mainbackgroundbrush-highcontrast{
	background: #000000;
}
.Office2019theme-mainborderbrush-highcontrast{
	background: #FFFFFF;
}
.Office2019theme-mainforegroundbrush-highcontrast{
	background: #FFFFFF;
}
.Office2019theme-mouseoverbackgroundbrush-highcontrast{
	background: #1AEBFF;
}
.Office2019theme-pressedbackgroundbrush-highcontrast{
	background: #1AEBFF;
}
.Office2019theme-readonlybackgroundbrush-highcontrast{
	background: #008000;
}
.Office2019theme-readonlyborderbrush-highcontrast{
	background: #FFFFFF;
}
.Office2019theme-secondarybackgroundbrush-highcontrast{
	background: #37006E;
}
.Office2019theme-secondaryforegroundbrush-highcontrast{
	background: #FFFFFF;
}
.Office2019theme-validationbrush-highcontrast{
	background: #EB0300;
}
/* New brushes since R3 2021 */
.Office2019theme-disabledcheckedforegroundbrush-highcontrast{
	background: #808080;
}
.Office2019theme-disabledforegroundbrush-highcontrast{
	background: #00FF00;
}
.Office2019theme-disablediconbrush-highcontrast{
	background: #00FF00;
}
.Office2019theme-iconwrapperbrush-highcontrast{
	background: #000000;
}
.Office2019theme-selectedunfocusedbackgroundbrush-highcontrast{
	background: #808080;
}
.Office2019theme-tertiarybackgroundbrush-highcontrast{
	background: #37006E;
}

article table
{
    table-layout: auto;
}
</style>

# Office2019 Theme

Inspired by the well-known Microsoft Office productivity suite and its latest version, the `Office2019` theme is here to help re-creating and delivering that fresh and smooth look and feel to your WPF apps. Explore the `Light`, `Gray` and `Dark` built-in color variations of the Office2019 theme and get off to a flying start with your WPF applications.

> With the __R3 2021__ release, we have expanded the built-in color variations with a brand-new one - the `HighContrast`. In addition to it, we extended the theme palette with several brushes. Read more in the [Default Theme Colors](#default-theme-colors) topic.

Jump to the following topics to learn about the specifics of the theme's palette and features.

* [Default Theme Colors](#default-theme-colors)
* [Default Theme Brushes](#default-theme-brushes)
* [Changing Palette Colors](#changing-palette-colors)
* [Changing Theme Variation](#changing-theme-variation)
* [Changing Font Properties](#changing-font-properties)
* [Using Glyphs](#using-glyphs)
* [Using Theme Helper](#using-theme-helper)
* [Setting White Color Variation](#setting-white-color-variation)
* [Changing Opacity](#changing-opacity)

## Default Theme Colors

The `Office2019` theme is designed to be easily modified via the exposed colors in the theme palette.
The default values of the brushes in the theme are listed below.

|Color name|   |Light|   |Gray|   |Dark|   |HighContrast|
|----------|---|-----|---|----|---|----|---|----|
|AccentBackgroundColor|#106EBE|<div class="theme-palette-color Office2019theme-accentbackgroundbrush"></div>|#106EBE|<div class="theme-palette-color Office2019theme-accentbackgroundbrush-gray"></div>|#106EBE|<div class="theme-palette-color Office2019theme-accentbackgroundbrush-dark"></div>|#1AEBFF|<div class="theme-palette-color Office2019theme-accentbackgroundbrush-highcontrast"></div>|
|AccentBorderColor|#106EBE|<div class="theme-palette-color Office2019theme-accentborderbrush"></div>|#106EBE|<div class="theme-palette-color Office2019theme-accentborderbrush-gray"></div>|#106EBE|<div class="theme-palette-color Office2019theme-accentborderbrush-dark"></div>|#1AEBFF|<div class="theme-palette-color Office2019theme-accentborderbrush-highcontrast"></div>|
|AccentMouseOverBackgroundColor|#D4E8F8|<div class="theme-palette-color Office2019theme-accentmouseoverbackgroundbrush"></div>|#D4E8F8|<div class="theme-palette-color Office2019theme-accentmouseoverbackgroundbrush-gray"></div>|#D4E8F8|<div class="theme-palette-color Office2019theme-accentmouseoverbackgroundbrush-dark"></div>|#FFFF00|<div class="theme-palette-color Office2019theme-accentmouseoverbackgroundbrush-highcontrast"></div>|
|AccentMouseOverBorderColor|#2F96ED|<div class="theme-palette-color Office2019theme-accentmouseoverborderbrush"></div>|#2F96ED|<div class="theme-palette-color Office2019theme-accentmouseoverborderbrush-gray"></div>|#2F96ED|<div class="theme-palette-color Office2019theme-accentmouseoverborderbrush-dark"></div>|#1AEBFF|<div class="theme-palette-color Office2019theme-accentmouseoverborderbrush-highcontrast"></div>|
|AccentPressedBackgroundColor|#A1CDED|<div class="theme-palette-color Office2019theme-accentpressedbackgroundbrush"></div>|#A1CDED|<div class="theme-palette-color Office2019theme-accentpressedbackgroundbrush-gray"></div>|#A1CDED|<div class="theme-palette-color Office2019theme-accentpressedbackgroundbrush-dark"></div>|#1AEBFF|<div class="theme-palette-color Office2019theme-accentpressedbackgroundbrush-highcontrast"></div>|
|AlternativeBackgroundColor|#F1F1F1|<div class="theme-palette-color Office2019theme-alternativebackgroundbrush"></div>|#CBCBCB|<div class="theme-palette-color Office2019theme-alternativebackgroundbrush-gray"></div>|#3C3C3C|<div class="theme-palette-color Office2019theme-alternativebackgroundbrush-dark"></div>|#000000|<div class="theme-palette-color Office2019theme-alternativebackgroundbrush-highcontrast"></div>|
|BaseBackgroundColor|#DFDFDF|<div class="theme-palette-color Office2019theme-basebackgroundbrush"></div>|#767272|<div class="theme-palette-color Office2019theme-basebackgroundbrush-gray"></div>|#151515|<div class="theme-palette-color Office2019theme-basebackgroundbrush-dark"></div>|#000000|<div class="theme-palette-color Office2019theme-basebackgroundbrush-highcontrast"></div>|
|ButtonBackgroundColor|#E5E5E5|<div class="theme-palette-color Office2019theme-buttonbackgroundbrush"></div>|#BFBFBF|<div class="theme-palette-color Office2019theme-buttonbackgroundbrush-gray"></div>|#3D3D3D|<div class="theme-palette-color Office2019theme-buttonbackgroundbrush-dark"></div>|#000000|<div class="theme-palette-color Office2019theme-buttonbackgroundbrush-highcontrast"></div>|
|CheckedForegroundColor|#FFFFFF|<div class="theme-palette-color Office2019theme-checkedforegroundbrush"></div>|#FFFFFF|<div class="theme-palette-color Office2019theme-checkedforegroundbrush-gray"></div>|#FFFFFF|<div class="theme-palette-color Office2019theme-checkedforegroundbrush-dark"></div>|#000000|<div class="theme-palette-color Office2019theme-checkedforegroundbrush-highcontrast"></div>|
|DisabledBackgroundColor|#F1F1F1|<div class="theme-palette-color Office2019theme-disabledbackgroundbrush"></div>|#CBCBCB|<div class="theme-palette-color Office2019theme-disabledbackgroundbrush-gray"></div>|#3F3E3C|<div class="theme-palette-color Office2019theme-disabledbackgroundbrush-dark"></div>|#808080|<div class="theme-palette-color Office2019theme-disabledbackgroundbrush-highcontrast"></div>|
|DisabledBorderColor|#D6D6D6|<div class="theme-palette-color Office2019theme-disabledborderbrush"></div>|#BEBEBE|<div class="theme-palette-color Office2019theme-disabledborderbrush-gray"></div>|#4F4F4F|<div class="theme-palette-color Office2019theme-disabledborderbrush-dark"></div>|#FFFFFF|<div class="theme-palette-color Office2019theme-disabledborderbrush-highcontrast"></div>|
|HeaderBackgroundColor|#106EBE|<div class="theme-palette-color Office2019theme-headerbackgroundbrush"></div>|#106EBE|<div class="theme-palette-color Office2019theme-headerbackgroundbrush-gray"></div>|#106EBE|<div class="theme-palette-color Office2019theme-headerbackgroundbrush-dark"></div>|#37006E|<div class="theme-palette-color Office2019theme-headerbackgroundbrush-highcontrast"></div>|
|HeaderForegroundColor|#FFFFFF|<div class="theme-palette-color Office2019theme-headerforegroundbrush"></div>|#FFFFFF|<div class="theme-palette-color Office2019theme-headerforegroundbrush-gray"></div>|#FFFFFF|<div class="theme-palette-color Office2019theme-headerforegroundbrush-dark"></div>|#FFFFFF|<div class="theme-palette-color Office2019theme-headerforegroundbrush-highcontrast"></div>|
|HighlightedForegroundColor|#2F2F2F|<div class="theme-palette-color Office2019theme-highlightedforegroundbrush"></div>|#2F2F2F|<div class="theme-palette-color Office2019theme-highlightedforegroundbrush-gray"></div>|#2F2F2F|<div class="theme-palette-color Office2019theme-highlightedforegroundbrush-dark"></div>|#000000|<div class="theme-palette-color Office2019theme-highlightedforegroundbrush-highcontrast"></div>|
|IconColor|#606060|<div class="theme-palette-color Office2019theme-iconbrush"></div>|#333333|<div class="theme-palette-color Office2019theme-iconbrush-gray"></div>|#A6A6A6|<div class="theme-palette-color Office2019theme-iconbrush-dark"></div>|#FFFFFF|<div class="theme-palette-color Office2019theme-iconbrush-highcontrast"></div>|
|MainBackgroundColor|#FFFFFF|<div class="theme-palette-color Office2019theme-mainbackgroundbrush"></div>|#E2E2E2|<div class="theme-palette-color Office2019theme-mainbackgroundbrush-gray"></div>|#2F2F2F|<div class="theme-palette-color Office2019theme-mainbackgroundbrush-dark"></div>|#000000|<div class="theme-palette-color Office2019theme-mainbackgroundbrush-highcontrast"></div>|
|MainBorderColor|#ACACAC|<div class="theme-palette-color Office2019theme-mainborderbrush"></div>|#A6A6A6|<div class="theme-palette-color Office2019theme-mainborderbrush-gray"></div>|#606060|<div class="theme-palette-color Office2019theme-mainborderbrush-dark"></div>|#FFFFFF|<div class="theme-palette-color Office2019theme-mainborderbrush-highcontrast"></div>|
|MainForegroundColor|#000000|<div class="theme-palette-color Office2019theme-mainforegroundbrush"></div>|#000000|<div class="theme-palette-color Office2019theme-mainforegroundbrush-gray"></div>|#F1F1F1|<div class="theme-palette-color Office2019theme-mainforegroundbrush-dark"></div>|#FFFFFF|<div class="theme-palette-color Office2019theme-mainforegroundbrush-highcontrast"></div>|
|MouseOverBackgroundColor|#C8C7C4|<div class="theme-palette-color Office2019theme-mouseoverbackgroundbrush"></div>|#ACACAC|<div class="theme-palette-color Office2019theme-mouseoverbackgroundbrush-gray"></div>|#B3AFAD|<div class="theme-palette-color Office2019theme-mouseoverbackgroundbrush-dark"></div>|#1AEBFF|<div class="theme-palette-color Office2019theme-mouseoverbackgroundbrush-highcontrast"></div>|
|PressedBackgroundColor|#B3AFAD|<div class="theme-palette-color Office2019theme-pressedbackgroundbrush"></div>|#918E8D|<div class="theme-palette-color Office2019theme-pressedbackgroundbrush-gray"></div>|#767676|<div class="theme-palette-color Office2019theme-pressedbackgroundbrush-dark"></div>|#1AEBFF|<div class="theme-palette-color Office2019theme-pressedbackgroundbrush-highcontrast"></div>|
|ReadOnlyBackgroundColor|#FFFFFF|<div class="theme-palette-color Office2019theme-readonlybackgroundbrush"></div>|#E2E2E2|<div class="theme-palette-color Office2019theme-readonlybackgroundbrush-gray"></div>|#2F2F2F|<div class="theme-palette-color Office2019theme-readonlybackgroundbrush-dark"></div>|#008000|<div class="theme-palette-color Office2019theme-readonlybackgroundbrush-highcontrast"></div>|
|ReadOnlyBorderColor|#ACACAC|<div class="theme-palette-color Office2019theme-readonlyborderbrush"></div>|#A6A6A6|<div class="theme-palette-color Office2019theme-readonlyborderbrush-gray"></div>|#606060|<div class="theme-palette-color Office2019theme-readonlyborderbrush-dark"></div>|#FFFFFF|<div class="theme-palette-color Office2019theme-readonlyborderbrush-highcontrast"></div>|
|SecondaryBackgroundColor|#D6D5D5|<div class="theme-palette-color Office2019theme-secondarybackgroundbrush"></div>|#B6B3B1|<div class="theme-palette-color Office2019theme-secondarybackgroundbrush-gray"></div>|#2B2B2B|<div class="theme-palette-color Office2019theme-secondarybackgroundbrush-dark"></div>|#37006E|<div class="theme-palette-color Office2019theme-secondarybackgroundbrush-highcontrast"></div>|
|SecondaryForegroundColor|#000000|<div class="theme-palette-color Office2019theme-secondaryforegroundbrush"></div>|#FFFFFF|<div class="theme-palette-color Office2019theme-secondaryforegroundbrush-gray"></div>|#F1F1F1|<div class="theme-palette-color Office2019theme-secondaryforegroundbrush-dark"></div>|#FFFFFF|<div class="theme-palette-color Office2019theme-secondaryforegroundbrush-highcontrast"></div>|
|ValidationColor|#E43E00|<div class="theme-palette-color Office2019theme-validationbrush"></div>|#E43E00|<div class="theme-palette-color Office2019theme-validationbrush-gray"></div>|#E43E00|<div class="theme-palette-color Office2019theme-validationbrush-dark"></div>|#EB0300|<div class="theme-palette-color Office2019theme-validationbrush-highcontrast"></div>|

> Additionally introduced brushes follow, which are available after the __R3 2021__.

|Color name|   |Light|   |Gray|   |Dark|   |HighContrast|
|----------|---|-----|---|----|---|----|---|----|
|DisabledCheckedForegroundColor|#FFFFFF|<div class="theme-palette-color Office2019theme-disabledcheckedforegroundbrush"></div>|#FFFFFF|<div class="theme-palette-color Office2019theme-disabledcheckedforegroundbrush-gray"></div>|#FFFFFF|<div class="theme-palette-color Office2019theme-disabledcheckedforegroundbrush-dark"></div>|#808080|<div class="theme-palette-color Office2019theme-disabledcheckedforegroundbrush-highcontrast"></div>|
|DisabledForegroundColor|#000000|<div class="theme-palette-color Office2019theme-disabledforegroundbrush"></div>|#000000|<div class="theme-palette-color Office2019theme-disabledforegroundbrush-gray"></div>|#F1F1F1|<div class="theme-palette-color Office2019theme-disabledforegroundbrush-dark"></div>|#00FF00|<div class="theme-palette-color Office2019theme-disabledforegroundbrush-highcontrast"></div>|
|DisabledIconColor|#606060|<div class="theme-palette-color Office2019theme-disablediconbrush"></div>|#333333|<div class="theme-palette-color Office2019theme-disablediconbrush-gray"></div>|#A6A6A6|<div class="theme-palette-color Office2019theme-disablediconbrush-dark"></div>|#00FF00|<div class="theme-palette-color Office2019theme-disablediconbrush-highcontrast"></div>|
|IconWrapperColor|transparent|<div class="theme-palette-color Office2019theme-iconwrapperbrush"></div>|transparent|<div class="theme-palette-color Office2019theme-iconwrapperbrush-gray"></div>|transparent|<div class="theme-palette-color Office2019theme-iconwrapperbrush-dark"></div>|#000000|<div class="theme-palette-color Office2019theme-iconwrapperbrush-highcontrast"></div>|
|SelectedUnfocusedBackgroundColor|#E5E5E5|<div class="theme-palette-color Office2019theme-selectedunfocusedbackgroundbrush"></div>|#BFBFBF|<div class="theme-palette-color Office2019theme-selectedunfocusedbackgroundbrush-gray"></div>|#3D3D3D|<div class="theme-palette-color Office2019theme-selectedunfocusedbackgroundbrush-dark"></div>|#808080|<div class="theme-palette-color Office2019theme-selectedunfocusedbackgroundbrush-highcontrast"></div>|
|TertiaryBackgroundColor|#F1F1F1|<div class="theme-palette-color Office2019theme-tertiarybackgroundbrush"></div>|#CBCBCB|<div class="theme-palette-color Office2019theme-tertiarybackgroundbrush-gray"></div>|#3C3C3C|<div class="theme-palette-color Office2019theme-tertiarybackgroundbrush-dark"></div>|#37006E|<div class="theme-palette-color Office2019theme-tertiarybackgroundbrush-highcontrast"></div>|

More information about each color and the respective brush that is created from it follows in the next topic.

__Theme colors represented in RadOutlookBar__

![Office2019 theme colors represented in RadOutlookBar](images/Office2019-theme-outlook.PNG)	

## Default Theme Brushes

### Accent Brushes

* `AccentBackgroundBrush`&mdash;Used for the background of the elements that should have accent - e.g. the background of the toggle button in its checked state.
* `AccentBorderBrush`&mdash;Used for the border color of the elements that should have accent - e.g. the border color of the toggle button in its checked state. 
* `AccentMouseOverBackgroundBrush`&mdash;Used for the background of the accent elements in their mouse over state (e.g. all buttons except the ones in the RadRibbonView).
* `AccentMouseOverBorderBrush`&mdash;Used for the border color of the accent elements in their mouse over state (e.g. all buttons except the ones in the RadRibbonView).
* `AccentPressedBackgroundBrush`&mdash;Used for the background of the accent elements in their pressed state (e.g. all buttons except the ones in the RadRibbonView). Also used for the buttons, toggling dropdown menus (opened state).

### Foreground Brushes 

* `MainForegroundBrush`&mdash;This is the default foreground of the theme.
* `SecondaryForegroundBrush`&mdash;Used for the foreground of the elements, placed over a background that would otherwise require reverting the default foreground - e.g. the BaseBackgroundBrush. It could be used as a default foreground to controls like the MS CheckBox, RadioButton, GroupBox in such scenarios. May also be considered for buttons with IsBackgroundVisible="False".
* `HighlightedForegroundBrush`&mdash;Used for the foreground of the elements when their parent is highlighted/hovered, pressed or selected/checked and hovered at once.
* `CheckedForegroundBrush`&mdash;Used for the foreground of the elements when their parent is in its selected/checked state.
* `HeaderForegroundBrush`&mdash;Used for the foreground of the header elements in a Window-based controls (e.g. RadWindow, RadTabbedWindow, FileDialogs, etc.).
* `IconBrush`&mdash;Used for the default foreground of the RadGlyph icons.

### Base Brushes 

* `BaseBackgroundBrush`&mdash;This is the recommended background to be used as an application background with this theme. It is also used as a background of the RadRichTextBox, RadSpreadsheet and RadPdfViewer controls. 
* `MainBackgroundBrush`&mdash;Used for the background the inputs and other editable elements such as RadAutocompleteBox, the content of their dropdowns/popup menus, and some child control elements like RadTaskBoard’s card, RadTileList’s tile, etc.
* `MainBorderBrush`&mdash;This is the default border color of all controls.
* `SecondaryBackgroundBrush`&mdash;Used for the background of non-editable, secondary elements - e.g. the RadCalculator's alternate buttons. Also used for the default background of the RadProgressBar's track and the RadSlider. 
* `AlternativeBackgroundBrush`&mdash;Used for the background of the RadMenu, RadOutlookBar, RadSpreadsheet specific child-controls and the footer background of its dialogs, RadRibbonView's tabs background, RadGridView's panels background (GroupPanel, SearchPanel), alternation rows background, etc. 
* `ButtonBackgroundBrush`&mdash;This is the default background of all buttons.
* `HeaderBackgroundBrush`&mdash;Used for the background of the header elements in a Window-based controls (e.g. RadWindow, RadTabbedWindow, FileDialogs, etc.).
* `MouseOverBackgroundBrush`&mdash;Used for the background of the non-accent elements in their mouse over state - e.g. the background of the RadRibbonView's buttons.
* `PressedBackgroundBrush`&mdash;Used for the background of the non-accent elements in their pressed state - e.g. the background of the RadRibbonView's buttons.
* `TertiaryBackgroundBrush`&mdash;Used for the background of the chat control's TextMessageControl and the gantt view control's SpecialSlots. 

> The `TertiaryBackgroundBrush` is not available with versions prior to the __R3 2021__ release of the UI for WPF suite.

### Special State Brushes

* `DisabledBackgroundBrush`&mdash;Used for the background of the controls in their disabled state.
* `DisabledBorderBrush`&mdash;Used for the border color of the controls in their disabled state.
* `DisabledCheckedForegroundBrush`&mdash;Used for the foreground of the elements in their disabled and checked state (RadGlyph icons included).
* `DisabledForegroundBrush`&mdash;Used for the foreground of the elements in their disabled state. 
* `DisabledIconBrush`&mdash;Used for the foreground of the RadGlyph icons in their disabled state.
* `IconWrapperBrush`&mdash;Used as a wrapper background for the images/icons when their color/foreground conflicts with the background of their parent in its mouse over state. This brush is introduced mainly for the HighContrast color variation. Its color is transparent in the other color variations. 
* `ReadOnlyBackgroundBrush`&mdash;Used for the background of the controls in their read-only state.
* `ReadOnlyBorderBrush`&mdash;Used for the border color of the controls in their read-only state.
* `SelectedUnfocusedBackgroundBrush`&mdash;Used for the background of the elements in their selected and not focused state (e.g., the GridViewRow, TreeListViewRow and the TreeViewItem). 
* `ValidationBrush`&mdash;Used for the background/border color of the controls to indicate the validation errors - for the foreground of the invalid control, or as a border for the error tooltip, border for invalid rows and cells.

> The `DisabledCheckedForegroundBrush`, `DisabledForegroundBrush`, `DisabledIconBrush`, `IconWrapperBrush` and `SelectedUnfocusedBackgroundBrush` are not available with versions prior to the __R3 2021__ release of the UI for WPF suite.

### Control Specific Brushes

* `ComparativeMeasureBrush`&mdash;Used in the BulletGraph control as a value of the ComparativeMeasureBrush property. 
* `QualityGoodBrush`&mdash;Used in the BulletGraph control as a value of the QualityGoodBrush property.
* `QualityPoorBrush`&mdash;Used in the BulletGraph control as a value of the QualityPoorBrush property.
* `QualitySatisfactoryBrush`&mdash;Used in the BulletGraph control as a value of the QualitySatisfactoryBrush property.
* `TimeBarSelectionBorderBrush`&mdash;Used for border color of the SelectionThumbHandle and the SelectionRange elements in the TimeBar control. 
* `TimelineInstantItemBrush`&mdash;Used for the background of the TimelineInstantItem (in the TimelineInstantItemControlStyle). 
* `TimelineItemBrush`&mdash;Used for the background of the TimelineItem (in the TimelineItemControlStyle). 

> All of the above brushes are not available with versions prior to the __R3 2021__ release of the UI for WPF suite.

### Other Properties

* `DisabledOpacity`&mdash;Used for the controls in their __disabled__ state.
* `HeaderBorderThickness`&mdash;Used for wrapping header elements with a border. Introduced mainly for the HighContrast color variation for which it has value 1. For all other color variations its default value is 0. Also used for the tab control's items in their mouse over state.
* `ReadOnlyOpacity`&mdash;Used for the controls in their __read-only__ state.
* `FocusThickness`&mdash;Used for the thickness of the focus border of the buttons. It is of type `Thickness` and its default value is __2, 2, 2, 2__.

> The `HeaderBorderThickness` is not available with versions prior to the __R3 2021__ release of the UI for WPF suite.

## Changing Palette Colors

The Office2019 theme provides dynamic change of the palette colors responsible for the brushes used in our controls. Their defaults are stated above. This mechanism is used to modify the color variation of the theme. 

The general naming convention is: `Office2019Palette.Palette.[name]Color` is responsible for `[name]Brush` – e.g. `Office2019Palette.Palette.AccentBackgroundColor` sets the color for `telerik:Office2019Resource ResourceKey=AccentBackgroundBrush`

Changing the colors can be achieved in code behind.

__Setting palette colors__
```C#
	Office2019Palette.Palette.AccentBackgroundColor = Color.FromRgb(255, 0, 0);
```

## Changing Theme Variation

The Office2019 theme comes with three color variations, inspired by the colors used in MS Office. The Light variation corresponds to Microsoft's Colorful Office theme, the Gray - to the Dark Gray Office2019 theme and the Dark - to the Black Office2019 theme. The following example demonstrates the ability to switch between the supported `Light`, `Gray`, `Dark` and `HighContrast` color palettes by calling the `LoadPreset()` method as shown below:

__Changing the color variation of the theme__
```C#
	//default color variation 
	Office2019Palette.LoadPreset(Office2019Palette.ColorVariation.Light);   
	
	//Gray color variation 
	Office2019Palette.LoadPreset(Office2019Palette.ColorVariation.Gray);   
	
	//Dark color variation 
	Office2019Palette.LoadPreset(Office2019Palette.ColorVariation.Dark);

	//HighContrast color variation 
	Office2019Palette.LoadPreset(Office2019Palette.ColorVariation.HighContrast);  
```

__Office2019 theme color variations__

![Office2019 theme colors represented in RadTaskBoard](images/Office2019-theme-variations.PNG)

>important All variations of the theme are designed with a specific background in mind and it is recommended to use such a background in your application when working with it - it is represented by the theme palette's `BaseBackgroundBrush`.

## Changing Font Properties

When using the `Office2019` theme you can dynamically change the `FontSize` and `FontFamily` properties of all components in the application the same way as you do in all other [Available Themes]({%slug common-styling-appearance-available-themes%}) which support ThemePalette.

The FontSize and FontFamily properties are public and can be easily modified at a single point. The most commonly used font size in the theme is with value __12__ and can be modified through the `Office2019Palette.Palette.FontSize` property in the same manner as in the other themes that support a theme palette. 

The default font used in the theme is `Segoe UI`.

>important For complex scenarios it is strongly recommend to set the FontSize properties __only before the application is initialized__. 

The following example shows the default font sizes and families.

__Default FontSize__
```C#
	Office2019Palette.Palette.FontSize = 12;
	Office2019Palette.Palette.FontSizeS = 13;
	Office2019Palette.Palette.FontSizeM = 14;
	Office2019Palette.Palette.FontSizeL = 16;
```

The following example shows how to change the default FontFamily from "Segoe UI" to "Calibri Italic" and the FontSize from __12__ to __18__.

__Changing the theme's FontSize and FontFamily__
```C#
	private void OnButtonChangeFontSizeClick(object sender, RoutedEventArgs e)
	{
		Office2019Palette.Palette.FontSize = 18;
		Office2019Palette.Palette.FontFamily = new FontFamily("Calibri Italic");
	}
```

__Setting FontSize and FontFamily__

![RadCalendar with modified FontSize and FontFamily](images/Office2019-theme-calendar-font-change.png)	

## Using Glyphs

The `Office2019` theme also uses the `Telerik Web UI` [font glyphs]({%slug common-styling-appearance-glyphs-overview%}) by default. The `RadGlyph` provides a lightweight, flexible and design-time-friendly implementation of our glyph font.  

> You can read more about the RadGlyph in the [RadGlyph Overview article]({%slug common-styling-appearance-radglyph%}) and about the range of the font glyphs in the [Font Glyphs Overview article]({%slug common-styling-appearance-glyphs-reference-sheet%}).

## Using Theme Helper

The [ThemeHelper]({%slug styling-appearance-theme-helper%}) class is used in the Office2019 theme. It exposes a set of attached properties and can be used to directly modify the appearance of a specific basic control without the need to alter its control template.

This example shows a `RadToggleButton` control with modified brushes for its different states through the `ThemeHelper` class:

__Set RadToggleButton's visual appearance through the ThemeHelper class__
```XAML
	<telerik:RadToggleButton Content="RadToggleButton" 
							 Margin="10"
							 xmlns:helpers="clr-namespace:Telerik.Windows.Controls.Theming.Helpers;assembly=Telerik.Windows.Controls"
							 helpers:ThemeHelper.MouseOverBrush="{telerik:Office2019Resource ResourceKey=AccentMouseOverBrush}"
							 helpers:ThemeHelper.PressedBrush="{telerik:Office2019Resource ResourceKey=ValidationBrush}"
							 helpers:ThemeHelper.CheckedBrush="{telerik:Office2019Resource ResourceKey=AccentMainBrush}"/>
```

__Appearance of the RadToggleButton in the different states__

![RadToggleButton States](images/Office2019-theme-togglebutton-states.png)

## Setting White Color Variation

The theme has a few built-in [color variations](#changing-theme-variation) - Light, Gray and Dark. You can customize the Light variation and make it look like Microsoft's White Office Theme by changing several color properties of the [theme palette](#changing-palette-colors).

To achieve this, first ensure that the Light [variation](#changing-theme-variation) is applied. This is the default one, so no explicit actions are required here. Then, set the following color properties:

__Applying palette colors__		
```C#
	Office2019Palette.Palette.ButtonBackgroundColor = (Color)ColorConverter.ConvertFromString("#FFFFFF");
	Office2019Palette.Palette.BaseBackgroundColor = (Color)ColorConverter.ConvertFromString("#FFFFFF");
	Office2019Palette.Palette.AlternativeBackgroundColor = (Color)ColorConverter.ConvertFromString("#FAFAFA");
	Office2019Palette.Palette.SecondaryBackgroundColor = (Color)ColorConverter.ConvertFromString("#F1F1F1");
```

## Changing Opacity 

If you need to change the opacity of the disabled and read-only elements, you can easily do so by using the `DisabledOpacity` and `ReadOnlyOpacity` properties of the Office2019Palette. The default values are __0.3__ and __0.6__ respectively. 

__Changing the opacity__		
```C#
	Office2019Palette.Palette.DisabledOpacity = 0.5;
	Office2019Palette.Palette.ReadOnlyOpacity = 0.5;
```

## Merging Modified Palette Resources With StyleManager Theming Approach

When modifying fonts, colors, or other resources from the `Office2019Palette` and `StyleManager` is used as theming mechanism, the theme's `ResourceDictionary` needs to be merged in __App.xaml__ file to apply the changes.

__Merging the theme's ResourceDictionary in App.xaml__
```XAML
	<Application.Resources> 
	    <ResourceDictionary> 
	        <ResourceDictionary.MergedDictionaries> 
	            <telerik:Office2019ResourceDictionary/> 
	        </ResourceDictionary.MergedDictionaries> 
	    </ResourceDictionary> 
	</Application.Resources>
```

## See Also  
 * [Setting a Theme (Using  Implicit Styles)]({%slug styling-apperance-implicit-styles-overview%})
 * [Style Manager]({%slug common-styling-apperance-setting-theme-wpf%})
 * [Glyphs Overview]({%slug common-styling-appearance-glyphs-overview%})
 * [Office2016 Theme]({%slug common-styling-appearance-office2016-theme%})
