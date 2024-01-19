namespace Pierres_Bakery.Models
{
    public abstract class BakedGood
    {
        public static int CalculatePrice(int itemNum, int price, int discount)
        {
            return (itemNum * price) - (itemNum / discount * price);
        }

        public static float CalculatePrice(int itemNum, int price, int discountedItem, float discount)
        {
            return (itemNum * price) - (itemNum / discountedItem * (price * discount));
        }
    }
}