using Home_work_2.Abstractions;

namespace Home_work_2.Rewards.Ruby;

public class RubyGenerator : ItemGenerator
{
    public override IGameItem CreateItem()
    {
        return new RubyRewards();
    }
}