using System.Linq;
using WpfAppSelectedItemPreviousItem.DAL.Context;
using WpfAppSelectedItemPreviousItem.DAL.Entityes;
using Microsoft.EntityFrameworkCore;

namespace WpfAppSelectedItemPreviousItem.DAL
{
    class PicturesRepository : DbRepository<Picture>
    {
        public override IQueryable<Picture> Items => base.Items;

        public PicturesRepository(cntxDBWpfAppSelectedItemPreviousItem db) : base(db) { }
    }
}