# grpc_asynclogger4net


#### Dependencies

- [Async log4net Wrapper](https://github.com/NimaAra/Easy.Logger)
- [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet)

```powershell
dotnet add package Easy.Logger -v 4.0.0
dotnet add package BenchmarkDotNet
```

Loggs are currently exported to path:
```
.\grpc_asynclogger4net\bin\Debug\net7.0\Logs
```

To enable Grpc server reflection we need additional nuget
```csharp
<PackageReference Include="Grpc.AspNetCore.Server.Reflection" Version="2.51.0" />
```
```powershell
dotnet add package Grpc.AspNetCore.Server.Reflection
```

Additionaly these DI code configurations are needed
```csharp
//Services
builder.Services.AddGrpcReflection();
//Http Pipeline middleware
app.MapGrpcService<BenchmarkingService>();
```
> With server reflection configured we can pull protobuff schema defitnitions to Postman
![image](https://user-images.githubusercontent.com/32032778/213866486-980b37b8-6f8f-4a40-918c-0edbd8506d86.png)

#### Json transcoding 
> This enables our clients to call our api either through Grpc or Http 

```powershell
dotnet add package Microsoft.AspNetCore.Grpc.JsonTranscoding
```
Additional Service configurations can be found here
- https://learn.microsoft.com/en-us/aspnet/core/grpc/json-transcoding?view=aspnetcore-7.0#usage

#### Usefull docs
https://learn.microsoft.com/en-us/aspnet/core/fundamentals/host/web-host?view=aspnetcore-7.0
https://benchmarkdotnet.org/articles/guides/getting-started.html
https://nimaara.com/2016/01/01/high-performance-logging-using-log4net.html
https://learn.microsoft.com/en-us/dotnet/core/extensions/logging?tabs=command-line
https://blog.hackajob.co/how-to-log-in-asp-net-core-web-apps-using-log4net/

#### Demos
https://www.youtube.com/watch?v=et_2NBk4N4Y,
https://www.youtube.com/watch?v=hp5FTB7PI9s

#### Http2 middleware Perf fix (replacement for locks = queue)
https://youtu.be/et_2NBk4N4Y?t=781

