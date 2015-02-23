---
title: Expander Animation
page_title: Expander Animation
description: Expander Animation
slug: radexpander-howto-animation
tags: expander,animation
published: True
position: 1
---

# Expander Animation

## Animating the RadExpander control.

To enable or disable the animation you can use the __IsAnimationEnabled__ attached property of the __AnimationManager__ class. By default the __Animation__ is enabled for the __RadExpander__. Below are code-snippets for XAML and C#:

#### __XAML__
{{region radexpander-howto-animation_0}}
    <StackPanel Orientation="Horizontal">
        <!--  DISABLE the Animation:  -->
        <telerik:RadExpander telerik:AnimationManager.IsAnimationEnabled="False" />
        <!--  ENABLE the Animation:  -->
        <telerik:RadExpander telerik:AnimationManager.IsAnimationEnabled="True" />
    </StackPanel>
{{endregion}}

#### __C#__
{{region radexpander-howto-animation_1}}
    using Telerik.Windows.Controls.Animation;
    private void SetAnimation()
    {
        if (this.radExpander != null)
        {
            AnimationManager.SetIsAnimationEnabled(this.radExpander, false);
            // some code...
            AnimationManager.SetIsAnimationEnabled(this.radExpander, true);
            // some code...
        }
    }
{{endregion}}

#### __VB.NET__
{{region radexpander-howto-animation_2}}
    Imports Telerik.Windows.Controls.Animation
    Private Sub SetAnimation()
        If Me.radExpander IsNot Nothing Then
            AnimationManager.SetIsAnimationEnabled(Me.radExpander, False)
            ' some code...'
            AnimationManager.SetIsAnimationEnabled(Me.radExpander, True)
            ' some code...'
        End If
    End Sub
{{endregion}}

You can further edit the default animations of the __RadExpander__ using the __AnimationSelector__ attached property of the __AnimationManager__ class. By default the following animations are defined for the __RadExpander__ control:				

#### __XAML__
{{region radexpander-howto-animation_3}}
    <Style x:Key="RadExpanderStyle" TargetType="telerik:RadExpander">
          ...  
        <Setter Property="telerik:AnimationManager.AnimationSelector">
            <Setter.Value>
                <telerik:AnimationSelector>
                    <telerik:ExpanderExpandCollapseAnimation AnimationName="Expand" 
                                                             Direction="In"
                                                             TargetElementName="Content" />
                    <telerik:ExpanderExpandCollapseAnimation AnimationName="Collapse" 
                                                             Direction="Out"
                                                             TargetElementName="Content" />
                </telerik:AnimationSelector>
            </Setter.Value>
        </Setter>
    </Style>
{{endregion}}

You can control the speed of the animations through the __SpeedRatio__ property:				

#### __XAML__
{{region radexpander-howto-animation_4}}
    <Style x:Key="RadExpanderStyle" TargetType="telerik:RadExpander">
          ...  
        <Setter Property="telerik:AnimationManager.AnimationSelector">
            <Setter.Value>
                <telerik:AnimationSelector>
                    <telerik:ExpanderExpandCollapseAnimation AnimationName="Expand" 
                                                             Direction="In"
                                                             SpeedRatio="0.2"
                                                             TargetElementName="Content" />
                    <telerik:ExpanderExpandCollapseAnimation AnimationName="Collapse" 
                                                             Direction="Out"
                                                             SpeedRatio="0.2"
                                                             TargetElementName="Content" />
                </telerik:AnimationSelector>
            </Setter.Value>
        </Setter>
    </Style>
{{endregion}}