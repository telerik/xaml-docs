---
title: Data Binding Tips
page_title: Data Binding Tips
description: What to have in mind when using the PersistanceFramework to save/load data bound properties.
slug: persistence-framework-data-binding-tips
tags: databinding, mvvm, tricks, loaded
published: True
position: 7
---

# Data Binding Tips

This articles describes what to have in mind when using the PersistanceFramework to save/load data bound properties.

## Preserve Data Bindings on Load

When you load the preserved layout of a control, the PersistenceFramework goes through the saved properties and sets them on the control. This is a local setting. This means that it has a higher priority than a **OneWay** binding to the same property. And the values of all properties with OneWay bindings will be overridden by the values loaded from the persistence manager.

To avoid this and use both data bindings and PersistanceFramework, you can use the TwoWay [binding mode](https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.binding.mode?view=netframework-4.8), which has a higher priority than the local setting. Or you can use the [SerializationOptions]({%slug persistence-framework-defining-properties%}) and exclude the OneWay data bound properties from the save/load process.

> Read more about property setting priorities in the [Dependency Property Value Precendence](https://docs.microsoft.com/en-us/dotnet/framework/wpf/advanced/dependency-property-value-precedence) MSDN article.

## Preserve Persisted Values

In some situations, the serialized data bound properties could get overridden by the properties from the viewmodel currently in memory. This happens when you call the load method before the data bindings are evaluated.

To avoid this, make sure that the load method is called after the data bindings are evaluated. For example, you can do this in the **Loaded** event handler of the view.

__Example 1: Load the persisted UI in the Loaded event handler__
```C#
	public class MyUserControl : UserControl
	{
		public MyUserControl()
		{
			InitializeComponent();
			this.Loaded += MyUserControl_Loaded;
		}

		private void MyUserControl_Loaded(object sender, RoutedEventArgs e)
		{
			PersistenceManager manager = new PersistenceManager();
			manager.Load(myControl, mySavedStream);
		}
	}
```

## See Also
* [Getting Started]({%slug persistence-framework-getting-started%})
* [Events]({%slug persistence-framework-events%})
