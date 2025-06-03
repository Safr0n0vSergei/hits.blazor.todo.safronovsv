namespace BlazorItemApp.Models
{
    public class PackageItem : Item
    {
        public int QuantityPerPackage { get; set; }

        public override decimal CalculateDiscount()
        {
            return OriginalPrice * 0.10m;
        }

        public override string GetDetails()
        {
            return $"{Name} (Набор из {QuantityPerPackage})";
        }
    }
}