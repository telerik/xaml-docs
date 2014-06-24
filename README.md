---
slug: read-me
title: the-read-me
publish: false
---

Writing and Publishing the Docs
====
<a id="top"></a>
This guide contains the following resources. Check regularly for updates and additions to the guide.

* [Overview](#overview)  
* [Writing Guide](#writing-guide)  
    * [The Meta Block](#meta-block)  
    * [Formatting](#formatting)  
    * [Images](#images)  
    * [Linking](#linking)  
    * [Capitalization](#capitalization)  
    * [Lists](#lists)  
    * [Product Names](#product-names)  
    * [Notes and Warnings](#notes)  
* [Publishing Guide](#publishing-guide)  
    * [Publish on Staging](#staging-publish)  
    * [Publish on Production](#production-publish)  
    * [Publishing Quirks](#publishing-quirks)  

<a id="overview"></a>
## Overview

All content is written in Markdown, stored as `MD` files in GitHub, and published in Sitefinity. When creating or editing content, make sure to keep it consistent with existing content in terms of doc structure, spelling, grammar, and formatting. For pointers, review the markdown of articles similar to the document you are currently working on.

The GitHub repository that contains all Icenium docs is <a href="https://github.com/Icenium/docs" target="_blank">https://github.com/Icenium/docs</a>.

The Sitefinity staging environment is <a href="http://testdocs.icenium.com/Sitefinity" target="_blank">http://testdocs.icenium.com/Sitefinity</a>.

The Sitefinity production environment is <a href="http://docs.icenium.com/Sitefinity" target="_blank">http://docs.icenium.com/Sitefinity</a>

When working with the Icenium documentation, you will typically follow this workflow.

1. Create a new GitHub branch of the docs repository based on the master branch.
1. Make changes locally.
1. Commit and push changes to your branch.
1. Publish on the staging environment.
1. Send your content for review and approval.
1. Make adjustments and republish.
1. Repeat steps 2-6 until the content is final.
1. Merge your branch to master.
1. Publish on the production environment.
1. Verify your changes.

[Back to top](#top)
<a id="writing-guide"></a>
## Writing Guide

<a id="meta-block"></a>
### The Meta Block

Each document must start with a meta block at the top. The most minimalistic meta block has the following syntax.

        ---
        title: Sample Title
        slug: sample-slug
        publish: true
        ---

The complete meta block that defines meta title and description, and the order of the article in the content hierarchy, has the following syntax.

        ---
        title: Sample Title
        slug: sample-slug
                meta_title: This Sample Title is Visible in the Browser Tab Title or the Browser Title Bar
        description: This description is visible to crawlers and search engines and might appear in search results. Typically, it's a helpful summary of the article.
        tags: sample, tag, another tag, useful tag
        previous_url: /old-path-to-relevant-content/deleted-relevant-content
        publish: true
        ---

The meta block contains the following meta fields. 

* **title**: (Mandatory) The title of your article as it will appear in the side bar navigation and on top of your document.
* **slug**: (Mandatory) A unique identifier for each article. Sitefinity does not handle two or more articles with duplicate slugs properly. You can use slugs for linking to internal content to reduce linking maintenance effort. For more information about slugs, see <a href="http://bladedocs.telerikservices.com/documentation/metadata-fields/Slug" target="_blank">Using the Slug Metadata Field</a>.
* **ordinal**: (Optional) A marker that determines the position of an article in the content hierarchy and in the side bar navigation within a folder. You can use positive and negative numbers, and integer and decimal numbers. You can check the current hierarchy in Sitefinity and plan ahead by signing in the backend, navigating to **Blade** -> **Doc Importer**
* **meta_title**: (Optional) The title that browsers will display in the title bar either for the corresponding tab or for the window. Used for SEO.
* **description**: (Optional) A `<meta name="description" conent="Sample Text">` element that Sitefinity will inser in the `<head>` for your article page. Used for SEO.
* **tags**: (Optional) A list of relevant key words or phrases that describe the article content. You can add multiple key words and phrases, separated by a comma. Currently, users cannot browse content by tag.
* **previous_url**: (If needed) An older URL relative to the root that users can no longer access. Used to handle redirects. You can add multiple previous URLs, separated by a comma. Make sure to set proper redirects when you move or delete content to avoid SEO issues and user frustration.
* **publish**: (Mandatory) A flag that determines if the article will be published and visible to users or if it will remain in a draft state in the backend. Accepts `true` or `false`.

[Back to top](#top)
<a id="formatting"></a>
### Formatting

* **File names, extensions, types, paths**: Use `code` formatting. For example: Navigate to the `Plugins` folder, locate `plugin.xml`, and double-click it. 
* **Buttons, menus, dialog and wizard titles**: Use **bold** formatting. For example: In the title bar, select **Run** -> **Build**. In the **Build** wizard, click **Android**.
* **Keyboard buttons or sequences**: Use `code` formatting. For example: Press `Enter`.
* **Error messages and warnings**: Use `code` formatting. For example: The following message is added to the log: `Unable to connect.`.
* **Product, framework, and plugin names**: No formatting.

[Back to top](#top)
<a id="images"></a>
### Images

* Add the new image file in an `images` folder in the location of your article. You can use `PNG` and `JPG` images.
* To include/reuse an existing image, use the following syntax.

                ! [Image Title](/docimages/file-name.jpg "Additional image description")
* Sitefinity auto-resizes larger images to fit the screen. 
* When adding an image, use the following syntax. The file path is relative to the location of the current file.
                
                ![Image Title](images/file-name.jpg "Additional image description")

[Back to top](#top)
<a id="linking"></a>
### Linking

* When linking to an external resource, always make the link open in a new tab/window. Sometimes, when linking to an untrusted resource or a competitor, use the `rel="nofollow"` property. You need to use regular HTML to achieve this task. For example:
        
                <a href="URL" target="_blank" rel="nofollow">Text</a>

* When linking to an internal resource, link by slug to reduce maintenance effort. Use the following syntax.

                [Text]({% slug article-slug %} "Alternative text")

[Back to top](#top)
<a id="capitalization"></a>
### Capitalization

* The title of an article uses title style capitalization. For example: This is a Sample Title.
* The titles of the top-level sections use title style capitalization. For example: Prerequisites, Procedure, Next Steps, Example, and See Also.
* The procedural sub-sections relevant for each client use sentence style capitalization. For example: Run app on remote devices from Icenium Graphite or Mist.

[Back to top](#top)
<a id="lists"></a>
### Lists

* Use ordered lists for steps in procedures.
* Use unordered lists for lists in which the order is irrelevant. For example: list of prerequisites or a list of available options.
* Avoid creating lists with one item.

[Back to top](#top)
<a id="product-names"></a>
### Product Names

When using a product name in the text, it is recommended to use any of the available text replacement keys. This reduces maintenance effort as when a product or client name changes, you can go and change the value of the key in the backend, reimport the content and have the change applied where needed.

To see the currently available text replacements, perform these steps. <a href="http://screencast.com/t/uxkfb4KENVX" target="_blank"><b>VIDEO</b></a>

1. Log in Sitefinity.
1. In the title bar, select **Administration** -> **Settings**.
1. In the side bar, select **Telerik Blade** -> **Text Replacement Mappings**.
1. In the side bar, click the replacement key that you want to inspect or modify.
1. If you have made any changes, click **Save Changes** and reimport the content.

[Back to top](#top)
<a id="notes"></a>
### Notes and Warnings

* Introduce notes (including important and caution) with the `>` symbol. For example:

> This is a note.

* Do not put a Note: prefix in notes.
* Avoid using Important: and Caution: prefixes. When the note is actually an important warning, use a warning sign such as in the Breaking Changes section in the Release Notes. Resize the image as needed.

[Back to top](#top)
<a id="writing-quirks"></a>
### Writing Quirks

* Sitefinity transforms `<h2>` and `<h3>` elements to anchors.
* You need to create tables with regular HTML.

[Back to top](#top)
<a id="publishing-guide"></a>
## Publishing Guide

When you want to publish your docs, follow this workflow.

1. Publish on staging, to review your doc changes and make any necessary adjustments to content and markdown. Republish as many times as needed.
1. Publish on production, to make your doc changes available to the public.

[Back to top](#top)
<a id="staging-publish"></a>
### Publish on Staging

To review your changes, send them for review to the team, or check how Sitefinity handles your markdown, always publish docs to the staging server first. 

1. Commit and push your doc changes to your branch.
1. Go to http://testdocs.icenium.com/Sitefinity and log in.
1. If needed, change the repository branch from which Sitefinity imports the docs. <a href="http://screencast.com/t/S4YVlflUUI" target="_blank"><b>VIDEO</b></a>  
        1. In the title bar, select **Administration** -> **Settings**.
        2. Click **Advanced**.
        3. In the side bar, click **Telerik Blade**.
        4. In the **GitHub Repository Branch** text box, type the name of your repository branch.
        5. Click **Save Changes**.  
1. In the title bar, select **Blade** -> **Docs Importer**.
1. If you have switched to another repository, or created, moved, or deleted files or folders, click **Clear Data**, confirm the operation, and wait for the operation to complete.<br/>A `Data cleared!` message appears at the top when the operation completes.
1. Click **Full Import** and wait for the operation to complete.<br/>An `IMPORT COMPLETE!` message appears at the top when the operation completes.
1. If Sitefinity is unable to complete the import and shows an error message, you might need to perform some additional steps and attempt a full import again.  
        1. Click **Clear Sidebar Cache**.<br/>A `Sidebar Cache Cleared!` message appears at the top when the operation completes.  
        2. Click **Clear Repository Files Cache**.<br/>A `Repository Files Cache Cleared!` message appears at the top when the operation completes.  
        3. Click **Clear Data** and confirm the operation.<br/>A `Data cleared!` message appears at the top when the operation completes.  
        4. Click **Full Import**.<br/>An `IMPORT COMPLETE!` message appears at the top when the operation completes.  
1. If Sitefinity shows warnings or errors about slug-related issues, address the issues and repeat the publishing process.
1. Go to http://testdocs.icenium.com and review your changes.
1. Do a quick search to make sure that search is working.

<a href="http://screencast.com/t/Sw3mxWzk" target="_blank"><b>VIDEO</b></a>

[Back to top](#top)
<a id="production-publish"></a>
### Publishing on Production

After you have applied changes from reviews and made your final fixes to your docs, you can go ahead and publish them on the production server.

1. Merge your branch to master.
1. Go to http://docs.icenium.com/Sitefinity and log in.
1. In the title bar, select **Blade** -> **Docs Importer**.
1. Click **Full Import** and wait for the operation to complete.<br/>An `IMPORT COMPLETE!` message appears at the top when the operation completes.
1. If Sitefinity is unable to complete the import and shows an error message, you might need to perform some additional steps and attempt a full import again.  
        1. Click **Clear Sidebar Cache**.<br/>A `Sidebar Cache Cleared!` message appears at the top when the operation completes.  
        2. Click **Clear Repository Files Cache**.<br/>A `Repository Files Cache Cleared!` message appears at the top when the operation completes.  
        3. Click **Clear Data** and confirm the operation.<br/>A `Data cleared!` message appears at the top when the operation completes.  
        4. Click **Full Import**.<br/>An `IMPORT COMPLETE!` message appears at the top when the operation completes.  
1. If Sitefinity shows warnings or errors about slug-related issues, address the issues and repeat the publishing process.
1. Go to http://docs.icenium.com and verify that your changes appear as expected.
1. Do a quick search to make sure that search is working.

<a href="http://screencast.com/t/Sw3mxWzk" target="_blank"><b>VIDEO</b></a> - the same procedure applies to http://docs.icenium.com.

[Back to top](#top)
<a id="publishing-quirks"></a>
### Quirks when Publishing

Based on your doc changes, you might need to jump through some hoops. Sitefinity configuration settings are not automatically applied to the staging and production environments. You need to make your configuration changes in both places.

* If you have made structural changes, you need to click **Clear Sidebar Cache** before doing a full import. Structural changes are any changes that modify the hierarchy of the content such as deleting or moving files, or deleting or moving folders, and others.
* If you have created or moved folders, you need to set their proper titles through the backend. <a href="http://screencast.com/t/uxkfb4KENVX" target="_blank"><b>VIDEO</b></a>  
        1. Log in Sitefinity.  
        2. In the title bar, select **Administration** -> **Settings**.  
        3. Click **Advanced**.  
        4. In the side bar, select **Telerik Blade** -> **Section Mappings**.  
        5. In the side bar, click the path that corresponds to your newly created or moved folder.  
        6. In the **Title** text box, type the correct title.<br/>Use title style capitalization.  
        7. Click **Save changes**.<br/>Title changes are applied automatically and you do not need to reimport the content.  
* If you want to rename a folder, change its title in the backend. Do not rename it in GitHub as this might cause SEO issues. <a href="http://screencast.com/t/uxkfb4KENVX" target="_blank"><b>VIDEO</b></a>  
        1. Log in Sitefinity.  
        2. In the title bar, select **Administration** -> **Settings**.  
        3. Click **Advanced**.  
        4. In the side bar, select **Telerik Blade** -> **Section Mappings**.  
        5. In the side bar, click the path that corresponds to the folder that you want to modify.  
        6. In the **Title** text box, type the correct title.<br/>Use title style capitalization.  
        7. Click **Save changes**.<br/>Title changes are applied automatically and you do not need to reimport the content.  
* If you want to rename a file, change its title in the markdown. Do not rename it in GitHub as this might cause SEO issues.  
* If you want to rearrange the subfolders in a folder in a certain order, you need to set their ordinals in the backend. <a href="http://screencast.com/t/uxkfb4KENVX" target="_blank"><b>VIDEO</b></a>  
        1. Log in Sitefinity.  
        2. (Optional) Check the current hierarchy to plan for changes in the ordinals.  
                1. In the title bar, select **Blade** -> **Docs Importer**.  
                2. Click **Display Current Section Taxonomy Ordinals**.<br/>Sitefinity shows the current hierarchy. The current ordinals for each article and folder are listed as suffixes inside square brackets.  
        3. In the title bar, select **Administration** -> **Settings**.  
        4. Click **Advanced**.  
        5. In the side bar, select **Telerik Blade** -> **Section Mappings**.  
        6. In the side bar, click the path that corresponds to the folder that you want to modify.  
        7. In the **Ordinal** text box, type the correct ordinal.<br/>You can use positive or negative numbers and integer or decimal numbers.  
        8. Click **Save changes**.<br/>Ordinal changes are not applied automatically and you need to reimport the content.  
        9. In the title bar, select **Blade** -> **Docs Importer**.  
        10. Click **Clear Sidebar Cache**.<br/>A `Sidebar Cache Cleared!` message appears at the top when the operation completes.  
        11. Click **Clear Data** and confirm the operation.<br/>A `Data cleared!` message appears at the top when the operation completes.  
        12. Click **Full Import**.<br/>An `IMPORT COMPLETE!` message appears at the top when the operation completes.  
* When publishing for a new version or a hot fix of Icenium, make sure that all text replacement mappings are up-to-date.<br/>Text replacement mappings are used to decrease the maintenance effort for mentions of product names and versions in the content. <a href="http://screencast.com/t/uxkfb4KENVX" target="_blank"><b>VIDEO</b></a>  
        1. Log in Sitefinity.  
        2. In the title bar, select **Administration** -> **Settings**.  
        3. Click **Advanced**.  
        4. In the side bar, select **Telerik Blade** -> **Text Replacement Mappings**.  
        5. In the side bar, click the replacement key that you want to modify.  
        6. In the **Default Value** text box, set the new product name or version that Sitefinity needs to show for the replacement key.<br/>For example, change the default value for `icenium-current` from `Icenium 1.9` to `Icenium 1.10`.  
        7. Click **Save changes**.<br/>Text replacement mappings changes are not applied automatically and you need to reimport the content.  
        8. In the title bar, select **Blade** -> **Docs Importer**.  
        9. Click **Full Import**.<br/>An `IMPORT COMPLETE!` message appears at the top when the operation completes.  
* When you have moved or deleted files, make sure that proper redirects are in place to avoid any SEO issues. Use the `previous_url` meta field. For more information about the `previous_url` field, see <a href="http://bladedocs.telerikservices.com/documentation/metadata-fields/UsingPreviousUrl" target="_blank">Using the Previous Url Metadata Field</a>. You need to do a full import for redirects to take effect.

[Back to top](#top)