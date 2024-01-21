#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p 1a5ef013-38a8-4107-a9c6-c5fa8ffe34a8 -t
    fi
    cd ../
fi

docker-compose up -d
