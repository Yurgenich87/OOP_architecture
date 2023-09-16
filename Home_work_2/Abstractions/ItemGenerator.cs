namespace Home_work_2.Abstractions;

// Абстракция класса фабрики

public abstract class ItemGenerator
{
    // Метод взаимодействия с разнообразной продукцией
    // return: содержимое из разных сундуков
    public string OpenReward()
    {
        IGameItem gameItem = CreateItem();
        return gameItem.Open();
    }

    // Метод создания экземпляра продукта
    // return: экземпляр продукта
    public abstract IGameItem CreateItem();
}