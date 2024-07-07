using WpfAppSelectedItemPreviousItem.DAL.Entityes;
using Microsoft.EntityFrameworkCore;

namespace WpfAppSelectedItemPreviousItem.DAL.Context
{
    public class cntxDBWpfAppSelectedItemPreviousItem : DbContext
    {
        public DbSet<Deal> Deals { get; set; }        
        
        public DbSet<Picture> Pictures { get; set; }        

        public cntxDBWpfAppSelectedItemPreviousItem(DbContextOptions<cntxDBWpfAppSelectedItemPreviousItem> options) : base(options)
        {
            
        }
    }
}
