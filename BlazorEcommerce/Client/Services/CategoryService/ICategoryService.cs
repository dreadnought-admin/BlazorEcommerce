namespace BlazorEcommerce.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task GetCategories(); // set the categories within this method
    }
}
