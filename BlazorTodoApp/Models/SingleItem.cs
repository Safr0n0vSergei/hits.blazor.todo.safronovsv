namespace BlazorItemApp.Models
{
    public class SingleItem : Item
    {
        public string UnitMeasure { get; set; } = string.Empty;

        public override string GetDetails()
        {
            return base.GetDetails() + $", Единицы измерения: {UnitMeasure}";
        }
    }
}
