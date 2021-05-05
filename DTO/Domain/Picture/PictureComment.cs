namespace DataClasses.Domain.Picture
{
    public class PictureComment : SessionInfo
    {
        public int PictureID { get; set; }
        public string Comment { get; set; }
    }
}