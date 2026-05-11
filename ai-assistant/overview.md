---
title: Overview
page_title: Telerik UI for WPF AI Coding Assistant - Overview, License Requirements, and Usage
description: Overview of the Telerik UI for WPF AI Coding Assistant and MCP Server. Covers license requirements for subscription, perpetual, and trial licenses, usage limits, supported components, privacy, and getting started prerequisites.
slug: ai-overview
tags: telerik,wpf,ai,coding assistant,mcp,mcp server,license,perpetual license,subscription license,trial,code generation,usage limits,intended use
position: 0
---

# Telerik UI for WPF AI Coding Assistant

The Telerik UI for WPF AI Coding Assistant is an AI-powered code generation tool available through the [Telerik WPF MCP Server]({%slug ai-mcp-server%}). It provides specialized context to AI models, enabling them to produce higher-quality code samples using [Telerik UI for WPF components](https://www.telerik.com/products/wpf/overview.aspx) and APIs.

The coding assistant is an AI code generator that provides specialized context to AI models, enabling them to produce higher-quality code samples using the [Telerik UI for WPF components](https://www.telerik.com/products/wpf/overview.aspx) and APIs.

## Available Tools

The Telerik AI Coding Assistant is available through the [Telerik WPF MCP server]({%slug ai-mcp-server%}) distributed as a NuGet package.

The major features of the AI Coding Assistant are listed in the table below.

| Feature                | MCP Server                                                                |
|------------------------|---------------------------------------------------------------------------|
| Prompt Handling        | Handles complex, multi-step prompts                                       |
| Client Compatibility   | Works with MCP-enabled clients (e.g., Cursor, Copilot Agent mode)         |
| Code Suggestions       | Can directly suggest changes and rebuild applications to verify code      |
| Response Focus         | Primarily code-focused                                                    |

## Getting Started

To use the Telerik WPF AI Coding Assistant, you need:

@[template](/_contentTemplates/ai-coding-assistant.md#getting-started)
* @[template](/_contentTemplates/ai-coding-assistant.md#number-of-requests)

## Supported Components

@[template](/_contentTemplates/ai-coding-assistant.md#supported-components)

## Recommendations

Consider the following recommendations when working with the AI Coding Assistant:

* Add NuGet packages/referenced assemblies for the Telerik UI for WPF product.
* Set the __.sln__ as a context.
* When switching between tasks and files, start a new session in a new chat window to avoid polluting the context with irrelevant or outdated information.
* At the time of publishing, **Claude Sonnet 4** and **GPT-4.1** produce optimal results.

## License Requirements

Access to the Telerik UI for WPF AI Coding Assistant depends on your [Telerik license type](https://www.telerik.com/purchase/faq/licensing-purchasing):

| License Type | AI Coding Assistant | Details |
|---|---|---|
| **Subscription License** | Yes | A Subscription is the primary license that grants full access to the AI Coding Assistant. It includes a virtually unlimited number of requests, with a fair use threshold of 300 requests per day. Best for ongoing and high-volume usage.|
| **Trial License** | Yes | Trial access is designed for evaluating the feature before purchasing. Reactivating the same trial for a new release does not grant additional requests. |
| **Perpetual License** | No* | Perpetual license holders have no access to the AI Coding Assistant. Start a [30-day trial](https://www.telerik.com/try/ui-for-wpf) or convert Perpetual license to a Subscription license. |

\* Perpetual license holders can access the AI Coding Assistant through a [30-day AI Tools trial](https://www.telerik.com/try/ui-for-wpf) or a [Telerik UI for WPF trial](https://www.telerik.com/try/ui-for-wpf). After the trial expires, access is no longer available unless the Perpetual license is converted to a Subscription license.

> All Telerik AI tools share a single request quota for your Telerik account. Usage from the [Telerik MCP server]({%slug ai-mcp-server%}) counts toward the same limit. Complex prompts in the MCP server may consume multiple requests.

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
* Usage metrics are collected to ensure [license compliance](#license-requirements).

> Make sure also to review the terms and privacy policies of your selected AI model and AI client.

## Telerik Document Processing AI Coding Assistant

You can also use the AI Coding Assistant for Telerik Document Processing to generate high-quality code samples and speed up your development.
Read the full guide in the dedicated [DPL AI Coding Assistant article](https://docs.telerik.com/devtools/document-processing/ai-coding-assistant/overview). 

## Next Steps

* Configure the [Telerik WPF MCP Server]({%slug ai-mcp-server%}) with an MCP-enabled client.
* Explore the [Telerik UI for WPF Prompt Library]({%slug ai-prompt-library%}).
