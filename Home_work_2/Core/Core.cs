using Home_work_2.Abstractions;
using Home_work_2.Rewards.Gold;
using Home_work_2.Rewards.Ruby;
using Home_work_2.Rewards.Sapphire;
using Home_work_2.Rewards.Silver;

namespace Home_work_2.Core;

public class Core
{
    // Логика игры
    
    public void Run()
    {
        List<ItemGenerator> myObject = new List<ItemGenerator>();
        myObject.Add(new GoldGenerator());
        myObject.Add(new SilverGenerator());
        myObject.Add(new RubyGenerator());
        myObject.Add(new SapphireGenerator());

        Random random = new Random();
        int randomIndex = random.Next(myObject.Count);
        ItemGenerator myItemGenerator = myObject[randomIndex];

        Console.WriteLine(myItemGenerator.OpenReward());
        

        //Console.WriteLine(myGenerators);
        
    }
}