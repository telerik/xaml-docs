using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radtransition-how-to-create-custom-transitions_0
public class CircleRevealTransitionEffect : BaseTransitionEffect
{
    protected override PixelShader LoadShader()
    {
    }
}
#endregion

#region radtransition-how-to-create-custom-transitions_1
public class CircleRevealTransitionEffect : BaseTransitionEffect
{
    protected override PixelShader LoadShader()
    {
        PixelShader pixelShader = new PixelShader();
        pixelShader.UriSource = TransitionEffect.PackUri<CircleRevealTransitionEffect>( "CustomTransitions/CircleRevealTransitionEffect.ps" );
        return pixelShader;
    }
}
#endregion

#region radtransition-how-to-create-custom-transitions_2
public class CircleRevealTransition : ShaderTransitionProvider
{
}
#endregion

#region radtransition-how-to-create-custom-transitions_3
public class CircleRevealTransition : ShaderTransitionProvider
{
    protected override TransitionEffect CreateTransitionEffect()
    {
        return new CircleRevealTransitionEffect();
    }
}
#endregion

#region radtransition-how-to-create-custom-transitions_4
public static readonly DependencyProperty FuzzyAmountProperty = 
    DependencyProperty.Register( "FuzzyAmount", 
                                    typeof( double ), 
                                    typeof( CircleRevealTransitionEffect ), 
                                    new PropertyMetadata( 0.1, ShaderEffect.PixelShaderConstantCallback( 1 ) ) );
public double FuzzyAmount
{
    get
    {
        return ( double )this.GetValue( FuzzyAmountProperty );
    }
    set
    {
        this.SetValue( FuzzyAmountProperty, value );
    }
}
#endregion

#region radtransition-how-to-create-custom-transitions_5
public CircleRevealTransitionEffect()
{
    base.UpdateShaderValue( FuzzyAmountProperty );
}
#endregion

#region radtransition-how-to-create-custom-transitions_6
public double FuzzyAmount
{
    get;
    set;
}
#endregion

#region radtransition-how-to-create-custom-transitions_7
protected override ShaderEffect CreateTransitionEffect()
{
    CircleRevealTransitionEffect effect = new CircleRevealTransitionEffect();
    effect.FuzzyAmount = this.FuzzyAmount;
    return effect;
}
#endregion
}
