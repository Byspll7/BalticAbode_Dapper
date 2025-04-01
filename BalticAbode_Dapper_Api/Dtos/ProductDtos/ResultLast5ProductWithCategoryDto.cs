namespace BalticAbode_Dapper_Api.Dtos.ProductDtos
{
    public class ResultLast5ProductWithCategoryDto
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string Distrct { get; set; }
        public int ProductCategory { get; set; }
        public string CategoryName { get; set; }
        public DateTime Date { get; set; }
    }
}
