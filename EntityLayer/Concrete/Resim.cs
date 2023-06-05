using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Resim
    {
        public int OurChocolatesid { get; set; }
        public string title { get; set; }
        public string titlesmall { get; set; }
        public string Descriptionsmall { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
        public string Price { get; set; }
    }
}
