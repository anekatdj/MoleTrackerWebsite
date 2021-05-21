using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DTO;

namespace DataClasses.Domain.Picture
{
    public class LocationOnBody : SessionInfo
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }

        public bool IsFrontFacing { get; set; }
        public string BodyPartSide { get; set; }
        public BodyPart BodyParts { get; set; }
        public Orientation Orientations { get; set; }

        public enum Orientation
        {
            Nedre,
            Øvre,
            Højre,
            Venstre,
            Ingen
        }

        public enum BodyPart
        {
            
            Kind,
            Pande,
            Næse,
            Læber,
            Hage,
            Øre,
            Hals,
            Skulder,
            Bryst,
            Mave,
            Overarm,
            Underarm,
            Håndflade,
            Tommelfinger,
            Finger,
            Håndryg,
            Underliv,
            Lår,
            Knæ,
            Underben,
            Fod,
            Baghoved,
            Nakke,
            Bagskulder,
            Ryg,
            Balle,
            Baglår,
            Knæhase,
            Læg,
            Venstre_ben,
            Højre_ben,
            Venstre_arm,
            Højre_arm,
            Hoved,
            Overkrop
        }

        public LocationOnBodyDTO ToDTO(LocationOnBody.BodyPart bodyPart)
        {
            LocationOnBodyDTO locationOnBodyDTO = new LocationOnBodyDTO()
            {
                xCoordinate = xCoordinate,
                yCoordinate = yCoordinate,
                IsFrontFacing = IsFrontFacing,
                BodyPart = bodyPart.ToString(),
                BodyPartSide = BodyPartSide
            };
            return locationOnBodyDTO;
        }
    }
}