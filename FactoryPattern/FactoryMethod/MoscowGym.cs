using FactoryPattern.FactoryMethod.Enums;
using FactoryPattern.FactoryMethod.GymSubscriptions;
using FactoryPattern.FactoryMethod.GymSubscriptions.MoscowSubscriptions;

namespace FactoryPattern.FactoryMethod
{
    internal sealed class MoscowGym : Gym
    {
        protected override GymSubscription CreateSubscription(SubscriptionTypeEnum type)
        {
            switch (type)
            {
                case SubscriptionTypeEnum.Classic:
                    return new ClassicSubscriptionMoscow();
                case SubscriptionTypeEnum.Premium:
                    return new PremiumSubscriptionMoscow();
                case SubscriptionTypeEnum.Extra:
                    return new ExtraSubscriptionMoscow();
                default: return null;
            }
        }
    }
}