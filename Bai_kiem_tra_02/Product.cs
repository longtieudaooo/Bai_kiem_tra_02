using System;

namespace Bai_kiem_tra_02
{
    public class Product
    {
        public string ProductId { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; } = string.Empty; // Đường dẫn file ảnh

        public decimal TotalValue => Price * Quantity; // Tổng giá trị sản phẩm

        public Product() { }

        public Product(string productId, string productName, string category, decimal price, int quantity, string imagePath)
        {
            ProductId = productId;
            ProductName = productName;
            Category = category;
            Price = price;
            Quantity = quantity;
            ImagePath = imagePath;
        }

        // Chuyển đối tượng thành dòng định dạng CSV
        public string ToCsvRow()
        {
            return $"{ProductId},{ProductName},{Category},{Price},{Quantity},{ImagePath}";
        }

        // Tạo đối tượng từ một dòng CSV
        public static Product FromCsvRow(string csvLine)
        {
            string[] parts = csvLine.Split(',');
            if (parts.Length >= 6)
            {
                return new Product(
                    parts[0].Trim(),
                    parts[1].Trim(),
                    parts[2].Trim(),
                    decimal.Parse(parts[3].Trim()),
                    int.Parse(parts[4].Trim()),
                    parts[5].Trim()
                );
            }
            return new Product();
        }
    }
}