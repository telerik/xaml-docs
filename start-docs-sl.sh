#!/bin/bash

config_file="_config.yml"	
if [ ! -z "$1" ]	
  then 	
    echo "Using configuration file: $1"	
    config_file=$1	
fi

rm -rf _site/ && rm -rf .sass-cache && rm -rf .jekyll-cache && rm -rf .asset-cache
#docker pull tmitev/docs-seed:site
#docker build -t tmitev/docs-seed:site .
docker run --rm --env CONFIG_FILE="_config.yml,_silverlight.yml" --env JEKYLL_COMMAND="serve" --env JEKYLL_EXTRA="--watch --incremental --host 0.0.0.0" --name docs_site -t -v "/c:\work\git\xaml-docs:/app_root" -p 4000:4000 -t tmitev/docs-seed:site
