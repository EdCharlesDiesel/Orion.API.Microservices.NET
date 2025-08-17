using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Orion.Admin.Models.Packages;

namespace Orion.Admin.Models.Packages
{
    public class PackagesListViewModel
    {
        public IEnumerable<PackageInfosViewModel> Items { get; set; }
    }
}
