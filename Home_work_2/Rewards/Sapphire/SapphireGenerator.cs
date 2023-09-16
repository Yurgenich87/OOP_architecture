using Home_work_2.Abstractions;

namespace Home_work_2.Rewards.Sapphire;

public class SapphireGenerator : ItemGenerator
{
    public override IGameItem CreateItem()
    {
        return new SapphireRewards();
    }
}