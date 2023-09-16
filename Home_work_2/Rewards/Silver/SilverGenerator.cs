using Home_work_2.Abstractions;

namespace Home_work_2.Rewards.Silver;

public class SilverGenerator : ItemGenerator
{
    public override IGameItem CreateItem()
    {
        return new SilverRewards();
    }
}