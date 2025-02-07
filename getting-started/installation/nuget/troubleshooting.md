---
title: Troubleshooting
page_title: Troubleshooting | NuGet
description: "Troubleshooting some of the common problems when installing NuGet packages."
slug: nuget-troubleshooting
tags: nuget,troubleshooting
published: True
position: 5
---

# Troubleshooting

This article lists some of the common problems that are observed during NuGet installation.

## '401 Logon failed' error

If you're receiving this error when connecting to Telerik NuGet Server, you could try to update your NuGet credentials through the __Windows Credential Manager__.

1. Close all open Visual Studio instances (this is so that all NuGet package manager tasks are stopped).
2. Open the "Credential Manager" app on your PC.
3. Scroll through all the entries until you find any that are for `nuget.telerik.com`.
4. Once you find that entry, expand it and select "edit".
5. Make sure the username and password are the same ones you use for your Telerik account:
    1. Use the email address in the place of username
    2. Make sure any special characters are escaped (see *Handling Special Characters in Password* below)
    3. Click "Save" 
6. Make sure the URL matches `https://nuget.telerik.com/v3/index.json`
7. Reopen Visual Studio and access the Telerik NuGet server. 

## Handling Special Characters in Password

If your password contains a special character, those characters need to be escaped or it may fail authentication resulting in *Error 401 login failure* from the NuGet server. A common character that needs to be escaped is the ampersand `&`, but it can be as unique as the section character `§`. There are two ways to handle this.

* Change the password so that it only includes characters that do not need to be escaped.
* HTML encode the password so the special characters are escaped (e.g. `my§uper&P@§§word` becomes `my&sect;uper&amp;P@&sect;&sect;word`).

We **strongly** discourage entering your password into an online encoder utility, use Powershell instead.  

```
Add-Type -AssemblyName System.Web
[System.Web.HttpUtility]::HtmlEncode('my§uper&P@§§word')
```

![Powershell Encoding](images/nuget-troubleshooting-powershell-encoding.png)

## Networking Problems

Another common problem is that your machine (PC, GitHub Actions runner or Azure DevOps agent) is behind a proxy. To check if you're experiencing a networking issue, open the following URL in your web browser:

* https://nuget.telerik.com/v3/search?q=wpf

After you enter your telerik.com username and password, you should see an XML search result containing a list of all the Telerik.UI.for.WPF packages available with your license.

## Unable to Load the Service Index for Source

The following error may occur if the nuget.telerik.com server is down.

`Unable to load the service index for source https://nuget.telerik.com/v3/index.json`

If you hit that error, make sure that the Telerik NuGet Feed is live at [https://status.telerik.com/](https://status.telerik.com/).
