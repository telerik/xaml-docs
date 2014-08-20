module Jekyll
  module AssetFilter 
        def Alert(input)
		 #puts "in" + input
		  #input.search('blockquote').each do |block|
              puts "das#{input}"
           # end

        "smile#{input}"
           
        end

  end
end

Liquid::Template.register_filter(Jekyll::AssetFilter)
