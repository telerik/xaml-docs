---
title: Styling the Other Elements
page_title: Styling the Other Elements
description: Styling the Other Elements
slug: raddatapager-styles-and-templates-styling-the-other-elements
tags: styling,the,other,elements
published: True
position: 4
---

# Styling the Other Elements


As the __RadDataPager__ doesn't expose __Style__ properties for its other elements, such as __First, Last, Previous, Next__ buttons, or the __TextBox__ and its labels, you have to create the needed styles and set them to the respective controls via the __ControlTemplate__ of the __DataPagerPresenter__ element.  In order to get to the __ControlTemplate__ of the __DataPager__ presenter you have to generate the default style of the __RadDataPager__ and after that the default style for the __DataPagerPresenter__. To see how read [this topic]({%slug raddatapager-styles-and-templates-styling-the-raddatapager%}).

After that bring the template for the __DataPagerPresenter__ in edit mode and manually create or generate the default style for the desired controls.

>tip You might find it useful to get familiar with the [Template Structure of the DataPagerPresenter](http://penev/devtools/wpf/controls/raddatapager/styles-and-templates/template-structure#datapagerpresenter).

# See Also

 * [Template Structure]({%slug raddatapager-styles-and-templates-template-structure%})

 * [Styling the RadDataPager]({%slug raddatapager-styles-and-templates-styling-the-raddatapager%})

 * [Styling the Numeric Buttons]({%slug raddatapager-styles-and-templates-styling-the-numeric-buttons%})
