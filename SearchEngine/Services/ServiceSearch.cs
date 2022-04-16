using SearchEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine.Services
{
    public class ServiceSearch
    {
        List<Search> results = new()
        {
            new Search
            {
                Id=1,
                Title= "KURSLAR.AZ - KURSLAR ve Telimler, Online kurslar",
                Desc= "KURSLAR , Telimler, Online kurslar. Bakida hazirliq kurslari 2021. Xarici dil kurslari, Suruculuk kurslari , Hazirliq kurslari ve diger kurslar",
                Url= "https://kurslar.az"
            },
            new Search
            {
                Id = 2,
                Title = "2.KURSLAR.AZ - KURSLAR ve Telimler, Online kurslar",
                Desc = "2.KURSLAR , Telimler, Online kurslar. Bakida hazirliq kurslari 2021. Xarici dil kurslari, Suruculuk kurslari , Hazirliq kurslari ve diger kurslar",
                Url = "https://kurslar.az"
            },
            new Search
            {
                Id = 3,
                Title = "3.KURSLAR.AZ - KURSLAR ve Telimler, Online kurslar",
                Desc = "3.KURSLAR , Telimler, Online kurslar. Bakida hazirliq kurslari 2021. Xarici dil kurslari, Suruculuk kurslari , Hazirliq kurslari ve diger kurslar",
                Url = "https://kurslar.az"
            },
            new Search
            {
                Id = 4,
                Title = "Discord | Your Place to Talk and Hang Out",
                Desc = "Discord is the easiest way to talk over voice, video, and text. Talk, chat, hang out, and stay close with your friends and communities.",
                Url = "https://discord.com"
            },


        };   

        public List<Search> Searching(string Name)
        {   
            var res=results.Where(x=>x.Title.Contains(Name) || x.Desc.Contains(Name)).ToList();
            return res;

        }



    }
}
