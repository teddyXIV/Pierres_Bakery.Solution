namespace Pierres_Bakery.Models
{
    public class Pastry : BakedGood
    {
        public int DonutNum { get; set; }
        public int CroissantNum { get; set; }

        public Pastry(int donut, int croissant)
        {
            DonutNum = donut;
            CroissantNum = croissant;
        }

    }
}