---
title: Styling and Appearance
page_title: Styling and Appearance
description: Styling and Appearance
slug: coverflow-styling-and-appearance-overview
tags: styling,and,appearance
published: True
position: 3
---

# Styling and Appearance

This section is intended to give you broad understanding of the possible ways by which you can change the visual appearance of __RadCoverFlow__. There is also comprehensive information about the Control Template and it's required parts. You will need this information if you want to customize the appearance of __RadCoverFlow__. 

You can modify the look of __RadCoverFlow__ either by changing some of the brushes exposed by the API, or change the Control Template. In the control template you are allowed to reorder the template parts and your own objects. However, in changing the control template you should be careful to include all required parts.

>Note that in changing the Control Template you should include all required parts. Even thought your code will compile some of the functionality may be subject to impact due to the omission of the required parts. 

RadCoverFlow is designed to be a simple items control that relies on the __CoverFlowPanel__ to arrange its children. The control template consists only of a single __ItemsPresenter__ and the __ItemsPanel__- CoverFlowPanel. You are free to modify the control template in order to introduce a navigation scrollbar or anything you like.

__RadCoverFlowItem__ can be customized by the __ItemTemplate__ property part of the CoverFlow control. You can take look at our __HowTo__ section that demonstrates a sample use of the ItemTemplate.
