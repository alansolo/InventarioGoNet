using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioGoNet
{
    public class Cetes : IInventario
    {
        public int LocalId { get; set; }
        public string Titulos { get; set; }
        public decimal Precio {get; set;}
        public string Contraparte { get; set; }
        public DateTime SettlementDate { get; set; }
        public string DealName { get; set; }

        public Cetes()
        {
        }
        public Cetes(int LocalId, string Titulos, decimal Precio, string Contraparte, DateTime SettlementDate, string DealName)
        {
            this.LocalId = LocalId;
            this.Titulos = Titulos;
            this.Precio = Precio;
            this.Contraparte = Contraparte;
            this.SettlementDate = SettlementDate;
            this.DealName = DealName;
        }
        public DateTime GetAvailableSince()
        {
            return this.SettlementDate;
        }

        public string GetDealName()
        {
            return this.DealName;
        }

        public int GetLocalId()
        {
            return this.LocalId;
        }

        public string GetTitles()
        {
            return this.Titulos;
        }
    }
}
