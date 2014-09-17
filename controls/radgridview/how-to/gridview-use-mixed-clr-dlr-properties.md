---
title: Have mixed CLR and DLR properties
page_title: Have mixed CLR and DLR properties
description: Have mixed CLR and DLR properties
slug: gridview-how-to-use-mixed-clr-dlr-properties
tags: have,mixed,clr,and,dlr,properties
published: True
position: 12
---

# Have mixed CLR and DLR properties



## Using Common Language Runtime (CLR) properties together with the Dynamic Language Runtime (DLR) properties

When you have mixed CLR properties with dynamic properties in a dynamic object, you would have to include some additional logic to your implementation in order for the RadGridView to be able to work with your dynamic object. 

For example if the CLR property is named "IsReadOnly", you should add code similar to:

#### __C#__

{{region gridview-how-to-use-mixed-clr-dlr-properties_0}}
	public override bool TryGetMember(GetMemberBinder binder, out object result)
	{
	    if (binder.Name == "IsReadOnly")
	    {
	        result = this.IsReadonly;
	        return true;
	    }
	     
	    if (this.dynamicFields.ContainsKey(binder.Name))
	    {
	        result = dynamicFields[binder.Name];
	        return true;
	    }
	    else
	    {
	        result = null;
	        return false;
	    }
	}
	{{endregion}}



You can check
          {% if site.site_name == 'Silverlight' %}[the Various Data Sources](http://demos.telerik.com/silverlight/#GridView/DataSources){% endif %}{% if site.site_name == 'WPF' %}[the Various Data Sources](http://demos.telerik.com/wpf){% endif %}
          demo for an example of binding to dynamic data.
      

# See Also
