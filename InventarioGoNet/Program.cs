using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioGoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            IInventario inventario = new Cetes(1, "Cete", 50, "Contraparte_1", DateTime.Now, "DealName_1");
            Console.WriteLine("Inventario.DealName: " + inventario.GetDealName());
            Console.WriteLine("Inventario.LocalId: " + inventario.GetLocalId());
            Console.WriteLine("Inventario.Titles: " + inventario.GetTitles());
            Console.WriteLine("Inventario.AvailableSince: " + inventario.GetAvailableSince());

            Console.WriteLine("");

            inventario = new ReverseRepo(2, "ReverseRepo", 65, "Contraparte_2", DateTime.Now, DateTime.Now, "DealName_2");
            Console.WriteLine("Inventario.DealName: " + inventario.GetDealName());
            Console.WriteLine("Inventario.LocalId: " + inventario.GetLocalId());
            Console.WriteLine("Inventario.Titles: " + inventario.GetTitles());
            Console.WriteLine("Inventario.AvailableSince: " + inventario.GetAvailableSince());

            Console.ReadKey();
        }
    }
}
