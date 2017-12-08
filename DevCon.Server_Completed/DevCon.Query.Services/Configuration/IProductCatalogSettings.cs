namespace DevCon.Query.Services.Configuration
{
    public interface IProductCatalogSettings
    {
        string ApiKey { get;}
        string ProductListBaseUri { get;}
        string ProductListUri { get; }
    }
}