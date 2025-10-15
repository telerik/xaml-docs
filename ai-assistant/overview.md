---
title: Overview
page_title: Telerik UI for WPF AI Tooling Overview
description: Learn about the AI-powered developer tools that integrate with your IDE or code editor for greater productivity and enhanced developer experience.
slug: ai-overview
tags: telerik,wpf,ai,coding assistant
position: 0
---

# Telerik UI for WPF AI Coding Assistant

The Telerik UI for WPF __AI Coding Assistant__ enhances your developer experience and increases productivity when building WPF applications with Telerik UI for WPF components.

The coding assistant is an AI code generator that provides specialized context to AI models, enabling them to produce higher-quality code samples using the [Telerik UI for WPF components](https://www.telerik.com/products/wpf/overview.aspx) and APIs.

## Available Tools

The Telerik AI Coding Assistant is available through:

* [Telerik WPF GitHub Copilot Extension]({%slug ai-copilot-extension%})

  > [Microsoft is sunsetting GitHub Copilot extensions](https://github.blog/changelog/2025-09-24-deprecate-github-copilot-extensions-github-apps) on November 10, 2025, in favor of the Model Context Protocol (MCP) standard.
  >
  > From that date, the Telerik and Kendo UI AI Coding Assistants will be available exclusively through our [MCP servers](slug:ai-mcp-server). You can enjoy the same powerful capabilities that are delivered by a modern, open, and officially recommended standard.
   
* [Telerik WPF MCP Server]({%slug ai-mcp-server%})

### Key Differences

| Feature                | MCP Server                                                                | GitHub Copilot Extension                                   |
|------------------------|---------------------------------------------------------------------------|------------------------------------------------------------|
| Prompt Handling        | Handles complex, multi-step prompts                                       | Offers shorter, focused code snippets                      |
| Client Compatibility   | Works with MCP-enabled clients (e.g. Copilot Agent mode)         		 | Integrated as a Copilot extension                          |
| Code Suggestions       | Can directly suggest changes and rebuild applications to verify code      | Provides detailed explanations alongside code suggestions  |
| Response Focus         | Primarily code-focused                                                    | Better for learning and understanding implementation       |

## Getting Started

To use the Telerik WPF AI Coding Assistant, you need:

@[template](/_contentTemplates/ai-coding-assistant.md#getting-started)
* @[template](/_contentTemplates/ai-coding-assistant.md#number-of-requests)

## Supported Components

@[template](/_contentTemplates/ai-coding-assistant.md#supported-components)

## Recommendations

Consider the following recommendations when working with the AI Coding Assistant:

* Add NuGet packages/referenced assemblies for the Telerik UI for WPF product.
* Ser the __.sln__ as a context.
* When switching between tasks and files, start a new session in a new chat window to avoid polluting the context with irrelevant or outdated information.
* At the time of publishing, **Claude Sonnet 4** and **GPT-4.1** produce optimal results.

## Usage Limits

Access to the AI Coding Assistant depends on your [Telerik license type](https://www.telerik.com/purchase/faq/licensing-purchasing):

### Subscription License

* A Subscription is the primary license that grants full access to the AI Coding Assistant.
* Includes a virtually unlimited number of requests, with a fair use threshold of __300 requests per day__.
* Best for ongoing and high-volume usage.

### Perpetual License (Limited Access)

* Perpetual licenses include limited access of __50 requests per year__.
* Intended for exploring and trying out the AI Coding Assistant.
* For continued or higher-volume access, upgrade to a Subscription license.

### Trial License

* Trial licenses include __300 requests per trial per year__ (does not reset with new trial activations) .
* Reactivating the same trial for a new release does not grant additional requests.
* Designed for evaluating the feature before purchasing.

> All Telerik AI tools share a single request quota for your Telerik account. Usage from the [Telerik Copilot extension]({%slug ai-copilot-extension%}) and [Telerik MCP server]({%slug ai-mcp-server%}) counts toward the same limit. Complex prompts in the MCP server may consume multiple requests.

## Privacy

The Telerik WPF AI Coding Assistant operates under strict privacy guidelines:

Data Access:
* No access to your workspace and application code.
* Exception: when using the Telerik MCP server (or any other MCP server), the LLM generates parameters for the MCP server request, which may include parts of your application code.

Data Usage:
* Your prompts are not used to train Telerik AI models.
* Does not generate or access AI responses.
* Provides enhanced context to improve responses from your chosen AI model (GPT, Gemini, Claude, etc.).

Data Storage:
* Prompts and context are anonymized and stored only for statistical analysis and troubleshooting.
* No association between prompts and your Telerik user account.
* Usage metrics are collected to ensure [license compliance](#usage-limits).

> Make sure also to review the terms and privacy policies of your selected AI model and AI client.

## Telerik Document Processing AI Coding Assistant

You can also use the AI Coding Assistant for Telerik Document Processing to generate high-quality code samples and speed up your development.
Read the full guide in the dedicated [DPL AI Coding Assistant article](https://docs.telerik.com/devtools/document-processing/ai-coding-assistant/overview). 

## Next Steps

* Install the [Telerik WPF GitHub Copilot Extension]({%slug ai-copilot-extension%}).
* Configure the [Telerik WPF MCP Server]({%slug ai-mcp-server%}) with an MCP-enabled client.
* Explore the [Telerik UI for WPF Prompt Library]({%slug ai-prompt-library%}).
