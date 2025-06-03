using System;

namespace BlazorItemApp.Models
{
    public class SpecialItem : Item
    {
        public DateTime DiscountExpirationDate { get; set; }

        public override void ApplyDiscount(decimal discount)
        {
            if (DateTime.Now <= DiscountExpirationDate)
            {
                Price = OriginalPrice - discount;
            }
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $", Скидка заканчивается: {DiscountExpirationDate:d}";
        }
    }
}
