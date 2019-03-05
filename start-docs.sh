#!/bin/bash

config_file="_config.yml"	
if [ ! -z "$1" ]	
  then 	
    config_file+=",$1"
fi

echo "Using configuration from: $config_file"	

rm -rf _site/ .sass-cache .jekyll-cache .asset-cache
docker pull progressdocs/docs-seed:2.2
docker build -t progressdocs/docs-seed:2.2 .
docker run --rm -it \
  --env CONFIG_FILE=$config_file --env JEKYLL_COMMAND="serve" --env JEKYLL_EXTRA="--watch --incremental --host 0.0.0.0" \
  --env LANG=C.UTF-8 \
  --env LANGUAGE=C.UTF-8 \
  --env LC_ALL=C.UTF-8 \
  --name docs_site -t -i -v /$(pwd):/app_root -p 4000:4000 \
  -t progressdocs/docs-seed:2.2
