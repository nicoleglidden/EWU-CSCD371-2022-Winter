namespace Lecture
{
    public class InMemoryStore : IStore
    {
        public void Save(ISavable item)
        {
            Item = item??throw new NotImplementedException(nameof(item));
        }

        public ISavable? Item { get; private set; }
    }

    public class DiskStore : IStore
    {

    }
}