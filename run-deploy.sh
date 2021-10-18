#!/bin/bash

git stash

git pull origin master

docker-compose -f docker-compose.prod.yml down

docker-compose -f docker-compose.prod.yml up --build -d
