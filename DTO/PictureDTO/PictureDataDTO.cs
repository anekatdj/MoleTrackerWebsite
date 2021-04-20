using DataClasses.Domain;

namespace DataClasses.PictureDTO
{
    public class PictureDataDTO
    {
        public int PictureID { get; set; }

        //TODO denne skal lige findes en rigtig datatype til.
        public int PictureData { get; set; }
        public PictureDataDomain ToDomain()
        {
            PictureDataDomain pictureDataDomain = new PictureDataDomain()
            {
                PictureID = PictureID,
                PictureData = PictureData
            };
            return pictureDataDomain;
        }
    }
}
