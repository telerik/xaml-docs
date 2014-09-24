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
		#region radexpander-howto-animation_1
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
		#endregion
	}


}
