namespace DataClasses.Domain
{
    public class LocationOnBody
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }

        public bool IsFrontFacing { get; set; }
        public BodyPart BodyParts = BodyPart.Hoved;
        public Orientation Orientations { get; set; }

        public enum Orientation
        {
            Nedre,
            Øvre,
            Højre,
            Venstre
        }

        public enum BodyPart
        {
            Skulder,
            Arm,
            Hånd,
            Finger,
            Lår,
            Ben,
            Fed,
            Tå,
            Balle,
            Ryg,
            Kind,
            Næse,
            Pande,
            Kæbe,
            Øre,
            Tindinge,
            Nakke,
            Hoved,
            Intet
        }
    }
}