namespace DataClasses.Domain
{
    public class LocationOnBody
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }

        public bool IsFrontFacing { get; set; }
        public string BodyPart { get; set; }
        public string BodyPartSide { get; set; }
    }
}