# Rotativa.AspNetCore

Rotativa for .Net 6

## Development version
This is the first version of Rotativa for .Net 6

Install with nuget.org:

https://www.nuget.org/packages/Rotativa.AspNetCore


## Needs configuration
Basic configuration done in Program.cs:

```csharp
RotativaConfiguration.Setup(app.Environment);
```

Make sure you have a folder with the wkhtmltopdf.exe file accessible by the process running the web app. By default it searches in a folder named "Rotativa" in the root of the web app. If you need to change that use the optional parameter to the Setup call `RotativaConfiguration.Setup(env, "path/relative/to/root")`


## rotativa.io

[rotativa.io](https://rotativa.io) is an API (SaaS) version of Rotativa, hosted on Azure. Works with just a HTTP call, no need to host the process on your server. You can register for free.
