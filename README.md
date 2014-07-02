# Documentation Base

This repository contains the common infrastructure for building markdown documentation with [Jekyll](http://jekyllrb.com/).

## Getting started

1. Install Ruby 1.9.x (2.x may or may not work).
2. Open a terminal or "Git Bash" if on Windows.
3. `cd` to the directory where your markdown documentation repository is.
4. Add a new git remote to the docs-base repository. This will be used to merge any new features and fixes from the documentation base repository.

         git remote add base git@github.com:telerik/docs-base.git
5. Fetch the "base" remote. This will retrieve the latest files.
      
         git fetch base
6. Merge the "base/master" branch to your documentation repository branch. 
         
         git merge --no-ff base/master
7. Resolve any conflicts (available via `git status`) and commit `git commit`. Make sure you don't remove any customizations you have made to some of the base files.
8. Open the "_config.yml" file and set the `baseurl` and `url` attributes. The first is used for resolving the path to images and hyperlinks. The second is the online URL of the documentation and is used for creating `sitemap.xml`.
         
         url: "http://docs.telerik.com/devtools/ios"
         baseurl: "/devtools/ios"

9. Create a Google Custom Search Engine (or ask one to be created for you). Set the `google_custom_search` attribute in "_config.yml". If you forget this step the search results will be from the Kendo UI documentation.
10. Run `bundle install`. If the `bundle` command is not found run `gem install bundler`. This will install Jekyll and all other required packages.
11. Run `jekyll serve`. After a while jekyll build the documentation and start a web server at `http://0.0.0.0:4000/<baseurl>` e.g. `http://0.0.0.0:4000/devtools/ios`. You can now view the documentation in your browser.
12. Exclude the `_site` directory from git by adding `_site` to your `.gitignore`.
 
Jekyll builds a static HTML site in the `_site` directory. This contents of this directory can be deployed on a live server. 

> Important: Jekyll creates .html pages by default. However the documentation creates links without .html extension. A `web.config` with rewrite rules is included out of the box. 

## Some Jekyll info

Jekyll is a tool for creating static html web sites. It supports markdown which makes it a good fit for our needs.

### Directory structure

#### _plugins

Contains [Jekyll plugins](http://jekyllrb.com/docs/plugins/) (Ruby classes) which are needed for producing the final output. The following plugins are available:

* breadcrumb.rb - renders breadcrumb navigation
* markdown_processor.rb - creates HTML from Markdown using [html-pipeline](https://github.com/jch/html-pipeline). We are not using the default markdown conversion as we need to tweak the output to our needs.
* navigation_generator.rb - creates a JSON TOC file used for the left-hand treeview navigation.
* redirect_generator.rb - creates IIS redirect rules in the `web.config` to handle the `previous_url` attribute. 
* sitemap_generator.rb - creates sitemap.xml which is used by search engines for crawling.
* slug.rb - gets the URL of a help article from its slug.

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

<a id="overview"></a>
## Overview

All content is written in Markdown, stored as `.md` files in GitHub, and published in Sitefinity. When creating or editing content, make sure to keep it consistent with existing content in terms of doc structure, spelling, grammar, and formatting. For pointers, review the markdown of articles similar to the document you are currently working on.

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
