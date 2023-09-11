namespace GTR_Assignment.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string UnitName { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string ParentCode { get; set; } = string.Empty;
        public string ProductBarcode { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string BrandName { get; set; } = string.Empty;
        public string SizeName { get; set; } = string.Empty;
        public string ColorName { get; set; } = string.Empty;
        public string ModelName { get; set; } = string.Empty;
        public string VariantName { get; set; } = string.Empty;
        public double OldPrice { get; set; }
        public double Price { get; set; }
        public double CostPrice { get; set; }
        public List<object> WarehouseList { get; set; } = new List<object>();
        public double Stock { get; set; }
        public double TotalPurchase { get; set; }
        public string LastPurchaseDate { get; set; } = string.Empty;
        public string LastPurchaseSupplier { get; set; } = string.Empty;
        public double TotalSales { get; set; }
        public string LastSalesDate { get; set; } = string.Empty;
        public string LastSalesCustomer { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public double CommissionAmount { get; set; }
        public double CommissionPer { get; set; }
        public double PCTN { get; set; }
    }
}
