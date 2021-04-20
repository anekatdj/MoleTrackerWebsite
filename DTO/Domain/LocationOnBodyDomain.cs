
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
        public string BodyPart { get; set; }
        public string BodyPartSide { get; set; }
        public LocationOnBodyDTO ToDTO()
        {
            LocationOnBodyDTO locationOnBodyDTO = new LocationOnBodyDTO()
            {
                xCoordinate = xCoordinate,
                yCoordinate = yCoordinate,
                IsFrontFacing = IsFrontFacing,
                BodyPart = BodyPart,
                BodyPartSide = BodyPartSide
            };
            return locationOnBodyDTO;
        }
    }
}
