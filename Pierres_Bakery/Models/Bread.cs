namespace Pierres_Bakery.Models
{
    public class Bread : BakedGood
    {
        public int SourdoughNum { get; set; }
        public int FocacciaNum { get; set; }
        public int RyeNum { get; set; }


        public Bread(int sourdough, int focaccia, int Rye)
        {
            SourdoughNum = sourdough;
            FocacciaNum = focaccia;
            RyeNum = Rye;
        }

    }
}