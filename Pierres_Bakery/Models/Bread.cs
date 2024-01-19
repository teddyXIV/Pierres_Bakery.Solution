namespace Pierres_Bakery.Models
{
    public class Bread : BakedGood
    {
        public int BreadNum { get; set; }


        public Bread(int num)
        {
            BreadNum = num;
        }

    }
}