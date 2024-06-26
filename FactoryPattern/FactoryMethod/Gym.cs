using FactoryPattern.FactoryMethod.Enums;
using FactoryPattern.FactoryMethod.GymSubscriptions;

namespace FactoryPattern.FactoryMethod
{
    internal abstract class Gym
    {
        internal GymSubscription BuySubscription(SubscriptionTypeEnum type)
        {
            GymSubscription subscription = CreateSubscription(type);
            return subscription;
        }

        internal void Visit(GymSubscription subscription)
        {
            subscription.DecreaseVisits();
        }

        protected abstract GymSubscription CreateSubscription(SubscriptionTypeEnum type);
    }
}