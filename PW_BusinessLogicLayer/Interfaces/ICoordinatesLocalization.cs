namespace PW_BusinessLogicLayer.Interfaces
{
    public interface ICoordinatesLocalization
    {
        public bool LocalizePointFemaleFront(bool PointClicked, int X, int Y);
        public bool LocalizePointFemaleBack(bool PointClicked, int X, int Y);
    }
}