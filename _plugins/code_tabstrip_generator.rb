module Reading
  class TabbedCodeGenerator < Jekyll::Generator
		def generate(site)				
			@headerSearchPattern = /#### __\[?(VB|VB.NET|C#|XAML)\]?\s*.*/ 
			@snippetSearchPattern = /#### __\[?(VB|VB.NET|C#|XAML)\]?\s*.*\n*\r*{{region\s.*}}\n*\r*((?!{{endregion}}).*\n*\r*\s*)*{{endregion}}/ # gets the whole snippet portion - header + region tags + code snippet
			@regionsPattern = /{{region\s.*}}\n*\r*((?!{{endregion}}).*\n*\r*)*{{endregion}}/ # gets the region tags and the content between them
			@regionStartPattern = /{{region\s.*}}/
			@regionEndPattern = /{{endregion}}/
			@tabstripStartTag = "<div class='tabbedCode'>"
			@tabstripEndTag = "</div>"
			@headingStartTag = "<h4><strong>"
			@headingEndTag = "</strong></h4>"
			
			@converter = site.getConverterImpl(Jekyll::Converters::Markdown)
			
			site.pages.each do |p|				
				createTabbedCode(p)				
			end
		end
		
		def createTabbedCode(p)
			content = p.content
			
			regionTagsCount = content.scan(@regionStartPattern).size
			regionEndTagsCount = content.scan(@regionEndPattern).size
			
			if regionTagsCount != regionEndTagsCount
				Jekyll.logger.warn "Tab strip generation canceled for page: #{p.path}. Missing 'region' or 'endregion' tag. Please check if the 'region' tag is properly closed.\nregionStartCount: #{regionTagsCount}\nregionEndCount: #{regionEndTagsCount}\n"
				return
			end			
			
			vbCodeInsertIndex = 0
			startIndex = 0;
			endIndex = 0;
			language = ""			
						
			while true do				
				currentMatch = @snippetSearchPattern.match(content, endIndex)				
				if currentMatch.nil?				
					break;
				end				
				
				currentMatch = currentMatch[0]				
				
				startIndex = content.index(currentMatch)
				endIndex = startIndex + currentMatch.length;	
				
				header = @headerSearchPattern.match(currentMatch)
				if !header.nil?
					language = getLanguageFromHeader(header[0])					
					# trim the language part from the header. leave only the "Example 1: something something" part
					header = getTrimmedHeader(header[0])
				else
					Jekyll.logger.warn "Something wrong with a code snippet header in file: #{p.path}"
				end
				
				# get code between region tags
				regionContent = currentMatch[@regionsPattern]				
				
				# convert code snippet to html
				codeSnippetHtml = getRegionsSnippetHtml(regionContent)
				
				# add language to the pre tag of the generated html
				codeSnippetHtml = addLanguage(codeSnippetHtml, language)
				
				# clear the original content of the discovered match
				content[startIndex..endIndex] = ""
				
				# insert the generated html at the original content start position
				if language.include? "VB"
					 content = content.insert(vbCodeInsertIndex, codeSnippetHtml)					
					 endIndex = vbCodeInsertIndex + codeSnippetHtml.length + @tabstripEndTag.length
				else
					htmlHeader = ""
					if !header.nil?
						htmlHeader = @headingStartTag + header + @headingEndTag
					end		
					
					# wrap the html snippet in a tabstrip container
					newTabStripContent = htmlHeader + @tabstripStartTag + codeSnippetHtml + @tabstripEndTag										
					content = content.insert(startIndex, newTabStripContent)
					
					endIndex = startIndex + newTabStripContent.length					
					vbCodeInsertIndex = startIndex + @tabstripStartTag.length + codeSnippetHtml.length
				end
			end			
		end
		
		def getLanguageFromHeader(header)			
			headerLangPattern = /__\[?(VB.NET|VB|C#|XAML)\]?/  # gets the language part of the header (no white spaces). Examples: '__[XAML]' or '__[C#]' or '__XAML', etc.
			languageString = header[headerLangPattern];
			if !languageString.nil?							
				languageString = languageString.gsub("__", "")
				languageString = languageString.gsub("[", "")
				languageString = languageString.gsub("]", "")
				return languageString
			end
			return ""
		end
		
		def getTrimmedHeader(header)			
			headerLangPattern = /#### __\[?(VB.NET|VB|C#|XAML)\]?\s*/ # gets the language part of the header (including white spaces). Examples: '__[XAML] ' or '__[C#] ' or '__XAML ', etc. 
			languageString = header[headerLangPattern];
			 if !languageString.nil?					
				header = header.gsub(languageString, "")				
				header = header.chomp("__")				
			 end
			return header
		end
		
		def getRegionsSnippetHtml(regionSnippet)
			regionMatch = regionSnippet[@regionStartPattern]					
			codeSnippetStartIndex = regionSnippet.index(@regionStartPattern) + regionMatch.length
			codeSnippetEndIndex = regionSnippet.index(@regionEndPattern);
			codeSnippet = regionSnippet[codeSnippetStartIndex..codeSnippetEndIndex - 1]
			
			htmlBlock = encodeLiquid(codeSnippet)
			htmlBlock = @converter.convert(htmlBlock)			
			htmlBlock = encodeNewLines(htmlBlock)
			
			return htmlBlock
		end	
		
		def encodeNewLines(content)
			content = content.gsub("\n","&#13;")
		end
		
		def encodeLiquid(content)
		  content = content.gsub("{{", "{{ '{{' }}")
		end
		
		def addLanguage(block, language)					
			prePattern = /<pre>/					
			block = block.sub(prePattern, "<pre lang='#{language}'>")			
			return block
		end
	end
end 