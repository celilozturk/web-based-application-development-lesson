namespace NetCore8MVC4.Models
{
    public static class UrunDb
    {
        public static List<Urun> UrunListesi()
        {
            var urunler = new List<Urun>()
            {
                new Urun(){ Id=1, Ad="Xiaomi Redmi 9T", Stok=100},
                new Urun(){ Id=2, Ad="Samsung Z Fold5", Stok=20},
                new Urun(){ Id=3, Ad="Samsung Galaxy A15", Stok=100},
                new Urun(){ Id=4, Ad="Dell Inspiron", Stok=100},
                new Urun(){ Id=5, Ad="Asus Zenbook 14X", Stok=100},
                new Urun(){ Id=6, Ad="Lenovo Thinkpad E14", Stok=100},
                new Urun(){ Id=7, Ad="Asus VivoBook 15", Stok=100}
            };
            return urunler;
        }
    }
}
