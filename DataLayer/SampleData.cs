using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class SampleData
    {
        public static void InitData(EFDBContext context)
        {
            if (!context.Directory.Any())
            {
                context.Directory.Add(new Dir() { Title = "First Directory", Html = "<b>Directory Content</b>" });
                context.Directory.Add(new Dir() { Title = "Second Directory", Html = "<b>Directory Content</b>" });
                context.SaveChanges();

                context.Material.Add(new Material() { Title = "First Material", Html = "<i>MaterialContent</i>", DirectoryId = context.Directory.First().Id });
                context.Material.Add(new Material() { Title = "Second Material", Html = "<i>MaterialContent</i>", DirectoryId = context.Directory.First().Id });
                context.Material.Add(new Material() { Title = "Third Material", Html = "<i>Material Content</i>", DirectoryId = context.Directory.Last().Id});
                context.SaveChanges();
            }
        }
    }
}
