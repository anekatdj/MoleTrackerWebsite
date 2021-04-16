using DataClasses.Domain;

namespace DataClasses.CollectionDTO
{
    public class LocationOnBodyDTO
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }

        public bool IsFrontFacing { get; set; }
        public string BodyPart { get; set; }
        public string BodyPartSide { get; set; }

        public LocationOnBodyDomain ToDomain()
        {
            LocationOnBodyDomain locationOnBodyDomain = new LocationOnBodyDomain()
            {
                xCoordinate = xCoordinate,
                yCoordinate = yCoordinate,
                IsFrontFacing = IsFrontFacing,
                BodyPart = BodyPart,
                BodyPartSide = BodyPartSide
            };
            return locationOnBodyDomain;
        }
    }
}
