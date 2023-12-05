using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class FoodPackageResource
    {
        public int Id { get; set; }
        public FoodResource Food { get; set; }
        public PackageResource Package { get; set; }
    }
}
