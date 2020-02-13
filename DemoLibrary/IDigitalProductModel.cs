using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}
