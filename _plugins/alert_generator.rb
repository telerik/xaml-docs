module Reading
  class Generator < Jekyll::Generator
    def generate(site)	
		@site = site
	    @converter = site.getConverterImpl(Jekyll::Converters::Markdown)	
        site.pages.each do |p|			
			createAlert("tip", p.content)
			createAlert("important", p.content)
			createAlert("caution", p.content)
		end
    end
	
	def createAlert(alertType, content)
		sub_string = content.scan(/(>#{alertType})(.*)/)		  
		if sub_string.count == 0
			##puts "no " + alertType + "s"
		else
			sub_string.each do |s|			
				block ="<blockquote class='#{alertType}'>" +  @converter.convert(s[1]) + "</blockquote>"
				slugsInBlock = block.scan(/.*?(%7[Bb]%slug%20([\w-]+)%{2}7[Dd])/)				
				if	slugsInBlock.count > 0				
					slugsInBlock.each do |slug|								
						targetPage = @site.pages.find {|p| p.data['slug'] == slug[1]}			
						if targetPage
							block.sub!(slug[0], targetPage.url.sub('.html', ''))					
						end
					end
				end				
				content.sub!(s[0]+s[1], block)
			end
		end
	end
  end
end

