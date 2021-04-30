using DataClasses.Domain;
using PW_BusinessLogicLayer.Interfaces;
using PW_DataAccessLayer;
using PW_DataAccessLayer.Interfaces;

namespace PW_BusinessLogicLayer
{
    public class ViewCollectionController : IViewCollectionController
    {
        private IViewCollectionDatabaseManager viewCollectionDatabaseManager;

        public ViewCollectionController()
        {
            viewCollectionDatabaseManager = new ViewCollectionDatabaseManager();
        }

        public Collection HandleCollection()
        {
            return viewCollectionDatabaseManager.GetCollection();
        }
    }
}