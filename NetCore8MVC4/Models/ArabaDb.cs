namespace NetCore8MVC4.Models
{
    public static class ArabaDb
    {
        public static List<Araba> ArabaListesi()
        {
            var arabalistesi = new List<Araba>()
            {
                new Araba() { Id=1,Marka="Mercedes",Model="E200D", Renk="Mavi",Yil=2023},
                new Araba() { Id=2,Marka="BMW",Model="520", Renk="Mavi",Yil=2012},
                new Araba() { Id=3,Marka="Peugeot",Model="RCZ", Renk="Beyaz",Yil=2000},
                new Araba() { Id=4,Marka="Mercedes",Model="E2000", Renk="Mavi",Yil=1992}
            };
            return arabalistesi;
        }
    }
}
