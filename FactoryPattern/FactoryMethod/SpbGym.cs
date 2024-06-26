using FactoryPattern.FactoryMethod.Enums;
using FactoryPattern.FactoryMethod.GymSubscriptions;
using FactoryPattern.FactoryMethod.GymSubscriptions.SpbSubscriptions;

namespace FactoryPattern.FactoryMethod
{
    internal sealed class SpbGym : Gym
    {
        protected override GymSubscription CreateSubscription(SubscriptionTypeEnum type)
        {
            switch (type)
            {
                case SubscriptionTypeEnum.Classic:
                    return new ClassicSubscriptionSbp();
                case SubscriptionTypeEnum.Premium:
                    return new PremiumSubscriptionSbp();
                case SubscriptionTypeEnum.Extra:
                    return new ExtraSubscriptionSbp();
                default: return null;
            }
        }
    }
}