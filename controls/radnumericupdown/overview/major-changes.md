---
title: Major Changes since 2009 Q2 SP1
page_title: Major Changes since 2009 Q2 SP1
description: Major Changes since 2009 Q2 SP1
slug: radnumericupdown-major-changes
tags: major,changes,since,2009,q2,sp1
published: False
position: 3
---

# Major Changes since 2009 Q2 SP1



With our __2009 Q2 Service Pack 1 release__, we introduce a complete change set for __RadNumericUpDown__ both in __Silverlight 3__ and __WPF__that should resolve most of the little issues the __2009 Q2__ version has. 

##  
What is new?

One of the major features introduced in our service pack is the __NULL__ value support, which has been an issue for a lot of people using nullable data items. Along with that we have included a __NullValue__ property that defines the way __RadNumericUpDown__ represents the null value, e.g. “Null” or ”Empty”.

__RadNumericUpDown__ has a powerful formatting model that relies on the __NumberFormatInfo__ class. However, being able to format complicated data and work in advanced scenarios, the __NumberFormatInfo__ class is not the most convenient way of adjusting the number of decimal digits to represent integer values. That is why, we have introduced a new __IsInteger__ property that will automatically correct the number of decimal digits independently of the value format of your __RadNumericUpDown__.

After we implemented the __ShowButtons__ property there were several inquiries for having a __ShowTextBox__ property which in fact transformed the __RadNumericUpDown__ control into what we called the __RadUpDown__. To make the things even simpler and more straight-forward the __RadUpDown__ control will be marked as obsolete in one of our next releases, and you will be prompted to use the __RadNumericUpDown__ control with a __ShowTextBox__ set to true.

__Validation__ support is another cornerstone features included in our __RadNumericUpDown__ control. Three visual states have been added to the control template: __Valid__, __InvalidUnfocused__, and __InvalidFocused__.

One of most cool features is the ability of __RadNumericUpDown__ to interact with the __RangeAttribute__ and adjust its properties in accordance to it. For example, if you have a property Age with a Range attribute from 18 to 30 such as:



#### __C#__

{{region radnumericupdown-major-changes_0}}
	[Range(0, 20)] 
	        public int? Age 
	        { 
	            set; 
	            get; 
	        }
	{{endregion}}



the __RadNumericUpDown__ control will set its values to the one specified in the attribute. However, if you explicitly set the __Maximum__ or __Minimum__ property in your class they will have higher priority.

Also we have improved the decimal input support for Mac, and laptops running on Windows that experience problems with the virtual keycode table and __Silverlight__.

##  
What is changed?

There is a significant change in the default values of RadNumericUpDown that will affect the behavior of your current implementation. Here is a quick list of what has been changed.
-    Default value of __Maximum__ is changed from 1 to double.MaxValue
-    Default value of __Minimum__ is changed from 0 to double.MinValue
-    Default value of __SmallChange__ is changed from 0.1 to 1
-    Default value of __LargeChange__ is changed from 1 to 10
-    Default value of __Delay__ is changed from 250 to 150
-    Type of Value is changed from double to __Nullable<double__> | __breaking change__
-    RoutedPropertyChangedEventArgs<double> is changed to__RadRangeBaseValueChangedEventArgs | breaking change__

##  
What is fixed?

-    Disabled visual state is now available in Silverlight

##  
What is removed?

-    __ChangeAcceleration__ is marked as obsolete.

-    __NumericUnit__ is marked as obsolete, use __CustomUnit__ instead.
