using HotChocolate.AspNetCore;
using HotChocolateIDict;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Configure the HTTP request pipeline.
_ = builder.Services
    .AddGraphQLServer()
    .BindRuntimeType<IDictionary<string, object>, AnyType>()
    .AddQueryType<RootQuery>();

WebApplication app = builder.Build();
app.UseRouting();
_ = app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapGraphQL()
        .WithOptions(new GraphQLServerOptions { EnableGetRequests = false, Tool = { Enable = true } });
});

app.Run();