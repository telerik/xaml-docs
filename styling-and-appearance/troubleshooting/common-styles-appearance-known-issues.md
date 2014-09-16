---
title: General Known Issues
page_title: General Known Issues
description: General Known Issues
slug: common-styles-appearance-troubleshooting-known-issues
tags: general,known,issues
publish: True
position: 1
---

# General Known Issues



## 

Here is a list of the general issues that has been reported to us and also an information on how to resolve them:
        {% if site.site_name == 'WPF' %}

* 
              Issue with .Net 4.0 WPF cascading style and resource dictionary problem. The issue has been reported
              [here.](
                  http://social.msdn.microsoft.com/Forums/en-US/wpf/thread/f1231b5c-9fd2-40b7-8398-ebf7af8c0d2f/
                )
              A solution has been suggested
              [here.](
                  http://stackoverflow.com/questions/3419543/adding-a-merged-dictionary-to-a-merged-dictionary/4113594#4113594
                ){% endif %}{% if site.site_name == 'Silverlight' %}

* If you use __Windows8__ or __Windows8Touch__ theme by defining the ApplicationTheme with StyleManager or by merging dictionaries in
                App.xaml, and you define your own implicit style (style without x:Key, defined in the resources) in which you are using Binding for the FontSize property, it will not
                be applied and the FontSize will be 0. 
                This is a bug in Silverlight Framework. There are two solutions of the problem:
              

* Define a key for your implicit style and set the controls to use this static resource.
                  

* Do not define the FontSize in your implicit style - set it directly on the controls.
                  {% endif %}
