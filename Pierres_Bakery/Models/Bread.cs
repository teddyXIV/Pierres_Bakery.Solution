namespace Pierres_Bakery.Models
{
    public class Bread : BakedGood
    {
        public int SourdoughNum { get; set; }
        public int FocacciaNum { get; set; }


        public Bread(int sourdough, int focaccia)
        {
            SourdoughNum = sourdough;
            FocacciaNum = focaccia;
        }

    }
}