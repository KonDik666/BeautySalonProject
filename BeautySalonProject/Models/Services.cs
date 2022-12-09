using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BeautySalonProject.Models
{
    public class Services
    {

            public int id { get; set; }
            public string title { get; set; }
            public float cost { get; set; }
            public int durationInSeconds { get; set; }
            public string description { get; set; }
            public float discount { get; set; }
            public string mainImagePath { get; set; }
            public int categoryId { get; set; }
            public object category { get; set; }
            public object[] clientServices { get; set; }
            public object[] servicePhotos { get; set; }

           
            public float sale
            {
           

            get
            {
                if (discount==0.0)
                {
                    return 0;
                }
                else
                {
                    return cost - cost / 100 * discount;
                }
                    
               
            }


        }

        public Visibility VisibilityBlock
        {
            get
            {
                if (sale == 0)
                {
                    return Visibility.Hidden;
                }
                else
                {
                    return Visibility.Visible;
                }

            }
           
        }




    }
}
