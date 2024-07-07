using System.Linq;
using WpfAppSelectedItemPreviousItem.DAL.Context;
using WpfAppSelectedItemPreviousItem.DAL.Entityes;
using Microsoft.EntityFrameworkCore;

namespace WpfAppSelectedItemPreviousItem.DAL
{
    class DealsRepository : DbRepository<Deal>
    {
        public override IQueryable<Deal> Items => base.Items;

        public Deal GetById(int id)
        {
            return base.Get(id);
        }
        


        public DealsRepository(cntxDBWpfAppSelectedItemPreviousItem db) : base(db) { }
    }
}