namespace Pierres_Bakery.Models
{
    public class Bread
    {
        public int Num { get; set; }


        public Bread(int num)
        {
            Num = num;
        }

        public int CalculatePrice()
        {
            return (this.Num * 5) - ((this.Num / 3) * 5);
        }

    }
}