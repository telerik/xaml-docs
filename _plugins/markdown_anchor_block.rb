module Jekyll
  class MarkdownAnchorBlock < Liquid::Block
    def initialize(tag_name, markup, tokens)		
      super
    end

    def render(context)
      contents = super
	  content = Liquid::Template.parse(contents).render context
		
		anchorText = content[/\[.*\]/]		
		if !anchorText.nil?
			anchorText = anchorText.sub("\[", "")
			anchorText = anchorText.sub("\]", "")
		end
		
		anchor = content[/\(.*\)/]		
		if !anchorText.nil?
			anchor = anchor.sub("\(", "")
			anchor = anchor.sub("\)", "")
		end
		# Jekyll.logger.warn "TEST: #{anchor}" 
		
		output = "<a href=\"#{anchor}\">#{anchorText}</a>"
    end
  end
end
Liquid::Template.register_tag('mdslug', Jekyll::MarkdownAnchorBlock)