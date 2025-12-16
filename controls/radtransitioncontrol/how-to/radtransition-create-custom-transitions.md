---
title: Create Custom Transitions
page_title: Create Custom Transitions
description: Check our &quot;Create Custom Transitions&quot; documentation article for the RadTransitionControl {{ site.framework_name }} control.
slug: radtransition-how-to-create-custom-transitions
tags: create,custom,transitions
published: True
position: 2
---

# Create Custom Transitions


The __RadTransitionControl__ provides you with several built-in transition effects, but you are allowed to create your custom ones by using the __Transition Effects API__. This tutorial will explain you the steps, needed to create a custom transition. Here they are:

* [Create Shader Effects](#create-shader-effects)

* [Wrap Shader Effects within Transition Effects](#wrap-shader-effects-within-transition-effects)

* [Wrap Transition Effects within Transition Providers](#wrap-transition-effects-within-transition-providers)

* [Pass Parameters to the Shader Effect](#pass-parameters-to-the-shader-effect)

* [Use Custom Transitions](#use-custom-transitions)

## Create Shader Effects

The __Shader Effects__ are written in the __HLSL__ language and get compiled via the __DirectX__ library. To learn more about creating and compiling __Shader Effects__ read this [MSDN topic](http://msdn.microsoft.com/en-us/library/bb509635%28v=VS.85%29.aspx).

There is also a [library for sample HLSL effects for WPF and Silverlight](http://wpffx.codeplex.com/) available. There you can find a list of ready for use __Shader Effects__.

## Wrap Shader Effects within Transition Effects

After getting your .ps shader effect file, the next step is to create a __Transition Effect__ class which wraps the __Shader Effect__. In this tutorial, a __CircleRevealTransitionEffect__ will be used. 

The class that wraps the shader effect should inherit the __BaseTransitionEffect__ class and you should override its __LoadShader()__ method. Here is a sample code:



```C#
	public class CircleRevealTransitionEffect : BaseTransitionEffect
	{
	    protected override PixelShader LoadShader()
	    {
	        return new PixelShader();
	    }
	}
```

In the override for the __LoadShader()__ method you have to create a __PixelShader__ instance and link it to the __Shader Effect__. Here it is:

>Note the __PackUri<T>()__ method of the __TransitionEffect__ class. It builds an absolute path to the __Shader Effect__ file based on the parameter __T__ that you've passed and the relative path passed as an argument. The first part of the absolute path is the assembly in which the shader effect file is placed. This is the assembly, in which the __T__ type is located. For example, if the class __CircleRevealTransitionEffect__ is placed in the __CustomTransitions__ assembly, the first part of the Uri will be __"/CustomTransitions;component/"__. The relative path passed to the method will be then concatenated to it - __"/CustomTransitions;component/CustomTransitions/CircleRevealTransitionEffect.ps"__.



```C#
	public class CircleRevealTransitionEffect : BaseTransitionEffect
	{
	    protected override PixelShader LoadShader()
	    {
	        PixelShader pixelShader = new PixelShader();
	        pixelShader.UriSource = TransitionEffect.PackUri<CircleRevealTransitionEffect>("CustomTransitions/CircleRevealTransitionEffect.ps");
	        return pixelShader;
	    }
	}
```

## Wrap Transition Effects within Transition Providers

As the Transition is of type __TransitionProvider__, you have to wrap your __Transition Effect__ class inside a class that inherits the __Transition Provider__.



```C#
	public class CircleRevealTransition : ShaderTransitionProvider
	{
	}
```

In it you have to override the __CreateTransitionEffect()__ method and return an instance of your __Transition Effect__ class.



```C#
	public class CircleRevealTransition : ShaderTransitionProvider
	{
	    protected override TransitionEffect CreateTransitionEffect()
	    {
	        return new CircleRevealTransitionEffect();
	    }
	}
```

## Pass Parameters to the Shader Effect

The __Shader Effect__ can also have some constants that can be passed through the wrapper. For example, the previously used __CircleRevealTransitionEffect__ accepts a fuzzy amount constant, which value can make the transition smoother.

>tip In order to pass arguments to the Shader Effect you must be familiar with it. It is important to pass the correct constants with the correct values.

In order to pass the fuzzy amount constant create an appropriate __DependencyProperty__ in your __CircleRevealTransitionEffect__ class.



```C#
	public static readonly DependencyProperty FuzzyAmountProperty =
	    DependencyProperty.Register("FuzzyAmount",
	                                    typeof(double),
	                                    typeof(CircleRevealTransitionEffect),
	                                    new PropertyMetadata(0.1, ShaderEffect.PixelShaderConstantCallback(1)));
	public double FuzzyAmount
	{
	    get
	    {
	        return (double)this.GetValue(FuzzyAmountProperty);
	    }
	    set
	    {
	        this.SetValue(FuzzyAmountProperty, value);
	    }
	}
```

In order to link the __DependencyProperty__ with the appropriate __Shader Effect__ constant you have to use the __PixelShaderConstantCallback()__ static method of the __ShaderEffect__ class. For its parameter you have to pass the index of the constant in the context of the __Shader Effect__. In this case the fuzzy amount is the first and the only constant that can be passed to the effect. If you have more than one constant just increment the index for the next ones (2, 3, 4 etc).

You also have to force an update of the __Shader Effect__ constant, when your __TransitionEffect__ class is instantiated. This ensures that the effect's constant has evaluated the default value of the dependency property, in case the __FuzzyAmountProperty__ doesn't get set. This can be done in the constructor via the __UpadteShaderValue()__ method of the base __BaseTransitionEffect__ class.



```C#
	public CircleRevealTransitionEffect()
	{
	    base.UpdateShaderValue(FuzzyAmountProperty);
	}
```

The next step is to add a __FuzzyAmount__ property in the __CircleRevealTransition__ class, so you can pass the constants via the __Transition__ instance.



```C#
	public double FuzzyAmount
	{
	    get;
	    set;
	}
```

In order to pass the value of the __FuzzyAmount__ to the __CircleRevealTransitionEffect__ use the override for the __CreateTransitionEffect__() method.



```C#
	protected override ShaderEffect CreateTransitionEffect()
	{
	    CircleRevealTransitionEffect effect = new CircleRevealTransitionEffect();
	    effect.FuzzyAmount = this.FuzzyAmount;
	    return effect;
	}
```

## Use Custom Transitions

In order to use the custom transition that you have just created, you have to declare the namespace in which the __CircleRevealTransition__ class is located. For example:



```XAML
	xmlns:customTransitions="clr-namespace:Controls.CustomTransitions;assembly=CustomTransitions"
```

Now you can use it as any of the built-in transition effects.



```XAML
	<telerik:RadTransitionControl x:Name="radTransitionControl">
	    <telerik:RadTransitionControl.Transition>
	        <customTransitions:CircleRevealTransition FuzzyAmount="0.2" />
	    </telerik:RadTransitionControl.Transition>
	</telerik:RadTransitionControl>
```

## See Also

 * [Working with the RadTransitionControl]({%slug radtransition-features-working-with-radtransitioncontrol%})

 * [Transitions]({%slug radtransition-features-transitions%})

 * [Data Binding]({%slug radtransition-features-data-binding%})
