using Home_work_2.Abstractions;

namespace Home_work_2.Rewards.Gold;

public class GoldGenerator : ItemGenerator
{
    public override IGameItem CreateItem()
    {
        return new GoldRewards();
    }
}