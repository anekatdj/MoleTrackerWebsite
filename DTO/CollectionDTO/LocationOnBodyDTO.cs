using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.CollectionDTO
{
    public class LocationOnBodyDTO
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }

        public bool IsFrontFacing { get; set; }
        public string BodyPart { get; set; }
        public string BodyPartSide { get; set; }
    }
}
