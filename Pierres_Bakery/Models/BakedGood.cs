namespace Pierres_Bakery.Models
{
    public abstract class BakedGood
    {
        public int CalculatePrice(int itemNum, int price, int discount)
        {
            return (itemNum * price) - (itemNum / discount * price);
        }

        public float CalculatePrice(int itemNum, int price, float discount)
        {
            return (itemNum * price) - (itemNum / 2 * (price * discount));
        }
    }
}