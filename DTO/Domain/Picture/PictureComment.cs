namespace DataClasses.Domain.Picture
{
    public class PictureComment : SessionInfo
    {
        public int PictureID { get; set; }
        public string Comment { get; set; }
    }

    public class PictureData : SessionInfo
    {
        public int PictureID { get; set; }

        //TODO denne skal lige findes en rigtig datatype til.
        public int PicData { get; set; }
    }
}