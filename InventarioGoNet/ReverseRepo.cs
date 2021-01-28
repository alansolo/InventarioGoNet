using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioGoNet
{
    public class ReverseRepo: IInventario
    {
        public int LocalId { get; set; }
        public string Titles { get; set; }
        public decimal Price { get; set; }
        public string Counterparty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DealName { get; set; }
        public ReverseRepo()
        {

        }
        public ReverseRepo(int LocalId, string Titles, decimal Price, string Counterparty, DateTime StartDate, DateTime EndDate, string DealName)
        {
            this.LocalId = LocalId;
            this.Titles = Titles;
            this.Price = Price;
            this.Counterparty = Counterparty;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.DealName = DealName;
        }
        public DateTime GetAvailableSince()
        {
            return this.StartDate;
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
            return this.Titles;
        }
    }
}
