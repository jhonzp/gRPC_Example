# gRPC_Example
gRPC service example Commands Proto stub Client and Proto Server

## Commands Create gRPC Server
### dotnet new grpc -o CreditRatingService

## Commands Create gRPC Client
dotnet new console -o CreditRatingClient

## Commands Create gRPC Client

dotnet add CreditRatingClient.csproj package Grpc.Net.Client
dotnet add CreditRatingClient.csproj package Google.Protobuf
dotnet add CreditRatingClient.csproj package Grpc.Tools
