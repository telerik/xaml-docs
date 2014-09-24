using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{	
	public partial class DataBindingSample
	{
	

#region radgauge-features-data-binding_1
public DataBindingSample()
{
    InitializeComponent();
    ObservableCollection<double> values = new ObservableCollection<double>()
    { 
        10,
        15,
        25,
        17,
        40,
        50,
        60,
        70,
        25,
        15,
        5,
        10,
        12,
        18,
        29,
        37,
        92,
    };
    this.radialBar.ValueSource = values;
}
#endregion

#region radgauge-features-data-binding_3
private void StartPlayback()
{
    this.radialBar.StartPlayback();
}
#endregion

#region radgauge-features-data-binding_5
private void StopPlayback()
{
    this.radialBar.StopPlayback();
}
#endregion

#region radgauge-features-data-binding_7
private void MoveNext()
{
    this.radialBar.MoveNext();
}
#endregion

#region radgauge-features-data-binding_9
private void MovePrevious()
{
    this.radialBar.MovePrevious();
}
#endregion

#region radgauge-features-data-binding_11
public DataBindingSample()
{
    InitializeComponent();
    List<PlaybackData> values = new List<PlaybackData>
    {
        new PlaybackData() {Value= 10, Duration=TimeSpan.FromMilliseconds(500.0)},
        new PlaybackData() {Value= 15, Duration=TimeSpan.FromMilliseconds(1000.0)},
        new PlaybackData() {Value= 25, Duration=TimeSpan.FromMilliseconds(250.0)},
        new PlaybackData() {Value= 17, Duration=TimeSpan.FromMilliseconds(250.0)},
        new PlaybackData() {Value= 40, Duration=TimeSpan.FromMilliseconds(250.0)},
        new PlaybackData() {Value= 50, Duration=TimeSpan.FromMilliseconds(250.0)},
        new PlaybackData() {Value= 60, Duration=TimeSpan.FromMilliseconds(500.0)},
        new PlaybackData() {Value= 70, Duration=TimeSpan.FromMilliseconds(125.0)},
        new PlaybackData() {Value= 25, Duration=TimeSpan.FromMilliseconds(125.0)},
        new PlaybackData() {Value= 15, Duration=TimeSpan.FromMilliseconds(500.0)},
        new PlaybackData() {Value= 5, Duration=TimeSpan.FromMilliseconds(1000.0)},
        new PlaybackData() {Value= 10, Duration=TimeSpan.FromMilliseconds(500.0)},
        new PlaybackData() {Value= 12, Duration=TimeSpan.FromMilliseconds(500.0)},
        new PlaybackData() {Value= 18, Duration=TimeSpan.FromMilliseconds(250.0)},
        new PlaybackData() {Value= 93, Duration=TimeSpan.FromMilliseconds(250.0)},
        new PlaybackData() {Value= 66, Duration=TimeSpan.FromMilliseconds(500.0)},
        new PlaybackData() {Value= 30, Duration=TimeSpan.FromMilliseconds(500.0)},
    };
    this.radialBar.ValueSource = values;
}
#endregion
    }
}
