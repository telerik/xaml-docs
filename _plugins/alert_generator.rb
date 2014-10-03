module Reading
  class Generator < Jekyll::Generator
    def generate(site)
	    @converter = site.getConverterImpl(Jekyll::Converters::Markdown)
		puts @converter
        site.pages.each do |p|			
			createAlert("tip", p.content)
			createAlert("important", p.content)
			createAlert("caution", p.content)
		end
    end
	
	def createAlert(alertType, content)
		sub_string = content.scan(/(>#{alertType})(.*)/)		  
		if sub_string.count == 0
			puts "no " + alertType + "s"
		else
			sub_string.each do |s|
				block ="<blockquote class='#{alertType}'>" +  @converter.convert(s[1]) + "</blockquote>"
				content.sub!(s[0]+s[1], block)
			end
		end
	end
  end
end

