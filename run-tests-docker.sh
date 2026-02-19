#!/bin/bash
set -e

echo "Building test container..."
docker build -t geoflow-tests -f Dockerfile.tests .

echo "Running tests inside container..."
# We mount the docker socket so Testcontainers can spin up sibling containers
docker run --rm -v /var/run/docker.sock:/var/run/docker.sock geoflow-tests
