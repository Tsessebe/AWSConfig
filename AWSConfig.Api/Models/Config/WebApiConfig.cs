namespace AWSConfig.Api.Models.Config;

public class WebApiConfig
{
    public AwsConfig Aws { get; set; } = new AwsConfig();

    public string EnvironmentSpecific { get; set; } = string.Empty;

    public string AppSecret { get; set; } = string.Empty;
}