namespace Pierres_Bakery.Models
{
    public abstract class BakedGood
    {
        public int CalculatePrice(int itemNum, int price, int discount)
        {
            return (itemNum * price) - (itemNum / discount * price);
        }
    }
}