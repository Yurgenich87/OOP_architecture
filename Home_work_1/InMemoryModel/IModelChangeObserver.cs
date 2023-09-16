namespace InMemoryModel
{
    // Определяем интерфейс IModelChangeObserver
    public interface IModelChangeObserver
    {
        void ApplyUpdateModel();
    }

    // Реализуем интерфейс в классе MyModelChangeObserver
    public class MyModelChangeObserver : IModelChangeObserver
    {
        public void ApplyUpdateModel()
        {
            // Реализация метода ApplyUpdateModel
        }
    }
}