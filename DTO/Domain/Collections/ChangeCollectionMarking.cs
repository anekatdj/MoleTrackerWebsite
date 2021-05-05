namespace DataClasses.Domain.Collections
{
    public class ChangeCollectionMarking : SessionInfo
    {
        public int CollectionID { get; set; }
        public bool IsMarked { get; set; }
    }
}