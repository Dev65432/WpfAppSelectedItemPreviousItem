using WpfAppSelectedItemPreviousItem.DAL.Entityes.Base;

namespace WpfAppSelectedItemPreviousItem.DAL.Entityes
{
    public class Picture : NamedEntity
    {
        // Свойства Id, Name находятся в базоввом классе.

        public int? DealId { get; set; }
        
        public Deal Deal { get; set; }
    }
}
