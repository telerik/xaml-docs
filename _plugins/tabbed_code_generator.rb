module Reading
  class TabbedCodeGenerator < Jekyll::Generator
		def generate(site)	
			@site = site
			@converter = site.getConverterImpl(Jekyll::Converters::Markdown)	
			site.pages.each do |p|							
				replaceHeaders(p.content)
				createTabbedCode(p)
			end
		end
	
		def replaceHeaders(content)
			# This searches for header + region. Example: #### __[C#] Example 1: This is a header__ <here we have some empty spaces, tabs and new lines> {{region
			headerSearchPattern = /#### __\[*(VB|VB.NET|C#|XAML)\]*(.*)__(\s*){{region/				
			# This searches for header. Example: #### __[C#] Example 1: This is a header__
			headerPattern = /#### __\[*(VB|VB.NET|C#|XAML)\]*(.*)__/
			# This searches for the language 'tag' in the header. Examples: [XAML] or [C#] or [VB]
			headerLanguageTagPattern = /__\[*(VB.NET|VB|C#|XAML)\]*(\s*)/
			# This holds the index from which we should start to look for a match in the content string
			searchIndex = 0			
			currentMatch = headerSearchPattern.match(content, searchIndex)
			
			while !currentMatch.nil?
				matchContent = currentMatch[0]
				startIndex = content.index(matchContent)	
				
				headerContent = matchContent[headerPattern]
				originalHeaderLength = headerContent.length
			  
				if ((headerContent.include? "VB.NET") || (headerContent.include? "VB"))	
					headerContent = ""	
				else
					headerContent = headerContent.sub(headerLanguageTagPattern, "__")
					
					# This if-block handles the scenario where the header is empty. 
					# The code was designed to handle specifically the following case: "#### __[XAML]__". The "XAML" word is not that important, it could be also "C#" or "VB.NET".
					# When we remove the lanugage tag the result is "#### ____", which is visualized as "____" in the final HTML output.
					if (headerContent.include? "____")
						headerContent = ""						
					end
				end						
				
				# This is the offset between the lengths of the original header and the updated header
				# This is used to recalculate the searchIndex
				searchIndexOffset = originalHeaderLength - headerContent.length;
				
				# Replacing the original header with the updated one
				content[startIndex..startIndex + originalHeaderLength] = headerContent + "  \n"		
						  
				searchIndex = currentMatch.end(0) - searchIndexOffset				
				currentMatch = headerSearchPattern.match(content, searchIndex)
			end
		end			
		
		def createTabbedCode(page)		 
			content = page.content
			insertIndex = 0
			previousSnippetLang = ""
			
			regionPattern = /{{region(.*)}}/
			endRegionPattern = "{{endregion}}"
			tabstripStartTag = "<div class='tabbedCode'>"
			tabstripEndTag = "</div>"
			
			currentIndex = 0;
						
			while true do				
				snippetStartIndex = content.index(regionPattern, currentIndex);	
				snippetEndIndex = content.index(endRegionPattern, currentIndex);
				
				if snippetStartIndex.nil?				
					break
				end								
				if snippetEndIndex.nil?
					Jekyll.logger.warn " - WARNING: Missing closing region tag in #{page.path}. This could result in wrong layout of the page."
					break
				end				
				snippetEndIndex += endRegionPattern.length
				
				# Getting the snippet
				snippet = content[snippetStartIndex..snippetEndIndex] 				
				# Getting the snippet language				
				language = getLanguage(snippet)
				
				# Removing the region tags
				snippet = removeRegions(snippet)				
				
				# Converting the MarkDown content to HTML
				block = encodeLiquid(snippet)
				block = @converter.convert(block) 					
				block = addLanguage(block, language);
										
				# Wrapping the HTML snippet in a tabstrip container
				if language == "VB.NET" && previousSnippetLang == "C#"	
					# Removing the VB.NET markdown code snippet from the content
					content[snippetStartIndex..snippetEndIndex] = ""
					# Inserting the VB.NET code snippet HTML in the previously created tabstrip container					
					content = content.insert(insertIndex, block)					
				else				
					# Wrapping the markdown code snippet into a tabstrip container (HTML element)
					content[snippetStartIndex..snippetEndIndex] =  tabstripStartTag + block + tabstripEndTag					
				end		
								
				previousSnippetLang = language				
				insertIndex = snippetStartIndex + tabstripStartTag.length + block.length
				currentIndex += tabstripStartTag.length + block.length + tabstripEndTag.length;
			end
		end
		
		def encodeLiquid(content)
		  content = content.gsub("{{", "{{ '{{' }}")
		end
		
		def removeRegions(block)		
			startPattern = /{{region(.*)}}/
			endRegion = /{{endregion}}/			
			block = block.gsub(startPattern, '')
			block = block.gsub(endRegion, '')			
			return block
		end		
		
		def addLanguage(block, language)					
			prePattern = /<pre>/					
			block = block.sub(prePattern, "<pre lang='#{language}'>")			
			return block
		end
		
		def getLanguage(snippet)
			languagePattern = /\s+?(vb|cs|xaml)-/
			languageString = snippet[languagePattern]
			 if !languageString.nil?							
				languageString = languageString.sub(/\s+?/, "")
				languageString = languageString.sub(/-/, "")					
				case languageString
				  when "vb"
					languageString = "VB.NET"
				  when "cs"
					languageString = "C#"
				  when "xaml"
					languageString = "XAML"
				end
				return languageString
			 end
			return ""					
		end
	end
end