using System.Drawing;
using DataClasses.Domain.Collections;
using DataClasses.Domain.MISC;
using DataClasses.Domain.Picture;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface ICoordinatesLocalization
    {
        public LocationOnBody Location { get; set; }
        public Collection Collections { get; set; }
        public Bitmap ImgColorMaleBack { get; set; }
        public bool LocalizePointFemaleFront(bool PointClicked, int X, int Y);
        public bool LocalizePointFemaleBack(bool PointClicked, int X, int Y);
        public bool LocalizePointMaleFront(bool PointClicked, int X, int Y);
        public bool LocalizePointMaleBack(bool PointClicked, int X, int Y);
        public PatientData PatientData { get; set; }
    }
}