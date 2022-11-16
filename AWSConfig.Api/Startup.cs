using AWSConfig.Api.Models.Config;

namespace AWSConfig.Api;

public class Startup
{
    private readonly IConfiguration configuration;
    private readonly IHostEnvironment hostingEnvironment;
    private readonly WebApiConfig config;


    public Startup(
        IConfiguration configuration,
        IHostEnvironment hostingEnvironment)
    {
        this.configuration = configuration;
        this.hostingEnvironment = hostingEnvironment;

        // Bind Config to object
        this.config = new WebApiConfig();
        configuration.Bind(this.config);
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton(this.config);

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddControllers();

        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
            {
                builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseRouting();
        app.UseCors();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers()
                .RequireCors("CorsPolicy");
        });
    }
}