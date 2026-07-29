---
title: MVVM support
page_title: MVVM support
description: Check our &quot;MVVM support&quot; documentation article for the RadTimeline {{ site.framework_name }} control.
slug: radtimeline-mvvm-support
tags: mvvm,support
published: True
position: 1
---

# MVVM support

The __RadTimeline__ control can be used with great success with the Model-View-ViewModel (MVVM) pattern. This help topic will demonstrate how to bind the control with the pattern.

1. We'll get started with a class with two properties - Duration and Date. They will be used to represent the two types of items in the Timeline. We'll also need a method that will set values to the newly created properties and will return a collection of our business objects.            

	<snippet id='radtimeline-populating-with-data-mvvm-support-block_1-cs' />
	<snippet id='radtimeline-populating-with-data-mvvm-support-block_2-vb' />

2. Create new class that inherits the ViewModelBase abstract class. This will be your ViewModel. What we'll need to add in it - an ObservableCollection that will be used as data source. In the constructor of the class call the GetData method we created in our Product class. (check Step 1.) The parameter of the method will represent the number of items in the timeline.            

	>ViewModelBase class is part of the Telerik.Windows.Controls.dll

	<snippet id='radtimeline-populating-with-data-mvvm-support-block_3-cs' />
	<snippet id='radtimeline-populating-with-data-mvvm-support-block_4-vb' />

3. Add new RadTimeline declarations in XAML and bind the StartPath and DurationPath properties. To learn more about these properties, please check the [DataBinding]({%slug radtimeline-databinding%}) topic:            

	<snippet id='radtimeline-populating-with-data-mvvm-support-block_5-xaml' />