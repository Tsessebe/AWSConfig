# AWSConfig

Dot net core API Configuration demo.
Specifically around using custom configuration, and using AWS Secrets Manager as a configuration provider.

## On-line Resources

* [Google](https://www.google.com) - Use it, till you love it!
* [Configuration Providers](https://learn.microsoft.com/en-us/dotnet/core/extensions/configuration-providers)

## Nuget Packages
* Kralizek.Extensions.Configuration.AWSSecretsManager - https://www.nuget.org/packages/Kralizek.Extensions.Configuration.AWSSecretsManager
```powershell
	Install-Package Kralizek.Extensions.Configuration.AWSSecretsManager -Version 1.7.0
```
* AWSSDK.SecretsManager - https://www.nuget.org/packages/AWSSDK.SecretsManager
```powershell
	Install-Package AWSSDK.SecretsManager -Version 3.7.2.107
```

## Gotcha's

* Environment Variables
When changes are made to environment variables, the IDE needs to be restarted. When Visual Studio opens, it caches the current environment variables.

