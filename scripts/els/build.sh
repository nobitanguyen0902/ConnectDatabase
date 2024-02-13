docker buildx create --name mybuilder --bootstrap --use
docker buildx build --platform linux/amd64,linux/arm64  -t nobitanguyen0902/mybusiness:8.11.0 --push .
docker buildx rm