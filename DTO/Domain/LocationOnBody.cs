namespace DataClasses.Domain
{
    public class LocationOnBody
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }

        public bool IsFrontFacing { get; set; }

        private enum Orientation
        {
            Nedre,
            Øvre,
            Højre,
            Venstre
        }

        private enum BodyPart
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