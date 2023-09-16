namespace InMemoryModel
{
    public interface IModelChanger
    {
        void NotifyChange(IModelChanger sender);
    }

    public class MyModelChanger : IModelChanger
    {
        public void NotifyChange(IModelChanger sender)
        {
            
        }
    }
        
        
}