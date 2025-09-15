---
title: Keyboard Command Provider
page_title: Keyboard Command Provider
description: Check our &quot;Keyboard Command Provider&quot; documentation article for the RadVirtualGrid {{ site.framework_name }} control.
slug: virtualgrid-commands-keyboard-command-provider
tags: commands, keyboard, command, provider
published: True
position: 2
---

# Keyboard Command Provider

__RadVirtualGrid__ executes a certain set of commands for a given navigation scenario. This default consequences of commands can be altered by either implementing the __IKeyboardCommandProvider__ interface or by inheriting the __DefaultKeyboardCommandProvider__ object. The first approach would be quite laborious, as all commands will have to be predefined. When only a certain keyboard scenario needs to be modified, utilizing the __DefaultKeyboardCommandProvider__ would be more appropriate.  

The following code snippet illustrates a possible implementation of such custom KeyboardCommandProvider.

__Example 1: Defining a custom KeyboardCommandProvider__
```C#
	public class CustomKeyboardCommandProvider: DefaultKeyboardCommandProvider
    {
        private RadVirtualGrid dataControl;

        public CustomKeyboardCommandProvider(RadVirtualGrid dataControl)
            :base(dataControl)
        {
            this.dataControl = dataControl;
        }

        public override IEnumerable<System.Windows.Input.ICommand> ProvideCommandsForKey(System.Windows.Input.Key key)
        {
            List<ICommand> commandsToExecute = base.ProvideCommandsForKey(key).ToList();

            if (key == Key.Right)
            {
                commandsToExecute.Clear();
                commandsToExecute.Add(RadVirtualGridCommands.MoveNext);
                commandsToExecute.Add(RadVirtualGridCommands.BeginEdit);
            }

            return commandsToExecute;
        }
    }
```

The final step is to apply the custom KeyboardCommandProvider to __RadVirtualGrid__ through its __KeyboardCommandProvider__ property.

__Example 2: Applying the custom KeyboardCommandProvider__
```C#
	this.VirtualGrid.KeyboardCommandProvider = new CustomKeyboardCommandProvider(this.VirtualGrid);
```

## See Also

* [Overview]({%slug virtualgrid-commands-overview%})

* [Implementation]({%slug virtualgrid-commands-implementation%})
