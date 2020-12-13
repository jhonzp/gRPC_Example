# gRPC_Example
gRPC service example Commands Proto stub Client and Proto Server

## Commands Create gRPC Server
dotnet new grpc -o CreditRatingService

## Commands Create gRPC Client
dotnet new console -o CreditRatingClient

## Commands Create gRPC Client

dotnet add CreditRatingClient.csproj package Grpc.Net.Client <br />
dotnet add CreditRatingClient.csproj package Google.Protobuf <br />
dotnet add CreditRatingClient.csproj package Grpc.Tools <br />

## Test exmaple.
Please do dotnet run in GrpcServices (server). 
Review the port is the same on program.cs of client project.
dotnet run in GrpcClient. 


