namespace E_Commerce.Presentation.Contracts;

public static class ApiRoute
{
    public static class Products
    {
        public const string GetAll = "api/products";
        public const string Get = "api/products/{id}";
        public const string Create = "api/products";
        public const string Update = "api/products/{id}";
        public const string Delete = "api/products/{id}";
    }

    public static class Identity
    {
        public const string Register = "api/identity/register";
        public const string Login = "api/identity/login";
    }
}