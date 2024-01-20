namespace Pierres_Bakery.Models
{
    public abstract class BakedGood
    {
        public static int CalculatePrice(int itemNum, int price, int discountedItem)
        {
            return (itemNum * price) - (itemNum / discountedItem * price);
        }

        public static float CalculatePrice(int itemNum, int price, int discountedItem, float discount)
        {
            return ((float)itemNum * price) - ((float)itemNum / discountedItem * (price * discount));
        }
    }
}