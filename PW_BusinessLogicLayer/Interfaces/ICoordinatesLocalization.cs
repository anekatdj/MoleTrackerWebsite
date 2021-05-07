using DataClasses.Domain.Collections;
using DataClasses.Domain.Picture;

namespace PW_BusinessLogicLayer.Interfaces
{
    public interface ICoordinatesLocalization
    {
        public LocationOnBody Location { get; set; }
        public Collection Collections { get; set; }
        public bool LocalizePointFemaleFront(bool PointClicked, int X, int Y);
        public bool LocalizePointFemaleBack(bool PointClicked, int X, int Y);
    }
}