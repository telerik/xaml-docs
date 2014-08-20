module Reading
  class Generator < Jekyll::Generator
    def generate(site)
	    converter = site.getConverterImpl(Jekyll::Converters::Markdown)
		puts converter
        site.pages.each do |p|
			sub_string = p.content.scan(/(>tip)(.*)/)
		  
			if sub_string.count == 0
				puts "no tips"
			else
		
				sub_string.each do  |s|
			 	puts converter.convert(s[1])
                block ="<blockquote class='tip'>"+  converter.convert(s[1]) +"</blockquote>"
				p.content.sub!(s[0]+s[1],block )
				end
			end
			sub_string = p.content.scan(/(>important)(.*)/)
		  
			if sub_string.count == 0
				puts "no important"
			else
				sub_string.each do  |s|
			 
                block ="<blockquote class='important'>"+  converter.convert(s[1])+"</blockquote>"
				p.content.sub!(s[0]+s[1], block)
				end
			end
		end
    end
  end
end

