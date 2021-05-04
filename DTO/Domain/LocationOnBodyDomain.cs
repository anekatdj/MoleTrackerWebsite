﻿
using System;
using System.Collections.Generic;
using System.Text;
using DataClasses.DTO;

namespace DataClasses.Domain
{
    public class LocationOnBodyDomain
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
            Venstre
        }

        public enum BodyPart
        {
            Pande,
            Kind,
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
            Læg
        }
        public LocationOnBodyDTO ToDTO()
        {
            LocationOnBodyDTO locationOnBodyDTO = new LocationOnBodyDTO()
            {
                xCoordinate = xCoordinate,
                yCoordinate = yCoordinate,
                IsFrontFacing = IsFrontFacing,
                //BodyPart = BodyPart,
                BodyPartSide = BodyPartSide
            };
            return locationOnBodyDTO;
        }
    }
}
