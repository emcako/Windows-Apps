using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop2_Exelent_.ViewModels
{
    public interface IPageViewModel
    {
        string Title { get; }

        IContentViewModel ContentViewModel { get; set; }
    }
}
