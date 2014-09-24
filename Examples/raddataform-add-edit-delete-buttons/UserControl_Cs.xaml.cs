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

#region raddataform-add-edit-delete-buttons_0

public class MyCollection <T> : IEnumerable<Club> 
	{
		private List<Club> clubs = new List<Club>();

		public void Add(Club club)
		{
			this.clubs.Add(club);
		}

		public void AddRange(IEnumerable<Club> clubs)
		{
			this.clubs.AddRange(clubs);
		}

		public void Remove(Club club)
		{
			this.clubs.Remove(club);
		}

		public IEnumerator<Club> GetEnumerator()
		{
			return this.clubs.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

#endregion
}
