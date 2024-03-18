using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entityes
{
    public class Material : Page
    {
        public int DirectoryId { get; set; }
        public Dir Directory { get; set; }
    }
}
