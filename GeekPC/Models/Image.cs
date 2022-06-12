namespace GeekPC.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string FileData { get; set; }
        public int ItemID { get; set; }
        public Item Item { get; set; }
    }
}
