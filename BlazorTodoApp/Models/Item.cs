namespace BlazorItemApp.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }

        public virtual string GetDetails()
        {
            return $"ID: {ItemId}, Название: {Name}, Цена: {OriginalPrice:C}";
        }

        public virtual decimal CalculateDiscount()
        {
            return 0.1m;
        }

        public virtual void ApplyDiscount(decimal discount)
        {
            Price = OriginalPrice - discount;
        }
    }
}
