using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioGoNet
{
    public interface IInventario
    {
        string GetDealName();
        int GetLocalId();
        string GetTitles();
        DateTime GetAvailableSince();
    }
}
