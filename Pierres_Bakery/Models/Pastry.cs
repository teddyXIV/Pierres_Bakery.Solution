namespace Pierres_Bakery.Models
{
    public class Pastry
    {
        public int Num { get; set; }

        public Pastry(int num)
        {
            Num = num;
        }

        public int CalculatePrice(int freeItem)
        {
            return (Num * 2) - ((this.Num / freeItem) * 2);
        }
    }
}