namespace DataClasses.Domain.Collections
{
    public class ChangeCollectionName : SessionInfo
    {
        public int CollectionID { get; set; }
        public string CollectionName { get; set; }
    }
}