


using System;

namespace ConsoleApplication4
{
    class ketabejadid
    {

        public static void Main(string[] args)

        {

            list<ketab> boxKetab = new list<ketab>();
            ketab ketabha = new ketab();
            ketabha.ID = 1;
            ketabha.shabak = 1234;
            ketabha.name = "arabi";
            ketabha.nevisande = "sedighi";
            ketabha.nasher = "mohamadi";
            ketabha.maozu = "darsi";
       
          


        }


    }

    class ozvejadid
    {

        public static void Main(string[] args)

        {
            ozveKetabkgne hameafrad = new ozveKetabkgne();
            hameafrad.ID = 1;
            hameafrad.shomareOzviyat = 1;
            hameafrad.name = "sima";
            hameafrad.family = "sedighi";
            hameafrad.shomareShenasname = 384;
            hameafrad.tarikhTawalod = "21/07 /71";
            hameafrad.mahaleSodur = "baneh";
            hameafrad.Shoghl = "daneshju";
            hameafrad.Adress = "tohid";
            hameafrad.mobail = 9180116748;
            hameafrad.tarikhOzviyat = "00/07/04";
        




            }

    }
    public class tamdidOzviyat
    {
        public int? jarime { get; set; }
        public static void Main(string[] args)

        {
            
            ozveKetabkgne tamdid = new ozveKetabkgne();
            tamdid.ID = 1;
            tamdid.shomareOzviyat = 1;
            tamdid.name = "sima";
            tamdid.family = "sedighi";
            tamdid.shomareShenasname = 384;
            tamdid.tarikhTawalod = "21/07 /71";
            tamdid.mahaleSodur = "baneh";
            tamdid.Shoghl = "daneshju";
            tamdid.Adress = "tohid";
            tamdid.mobail = 9180116748;
            tamdid.tarikhOzviyat = "00/07/04";
            tamdid.jarime =0;





        }

    }
    public class ketabhayeAmanti
    {
     
        public static void Main(string[] args)

        {

            ketab amanati = new ketab();
            amanati.ID = 1;
            amanati.name = "";
     





        }

    }
}
