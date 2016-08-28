using System;
using System.Reflection;

namespace Sylapse.WeakSubscribe {
    public static class WeakSubscribenExtensions {
        public static MvxGeneralEventSubscription WeakSubscribe(this object obj, string eventName, EventHandler<EventArgs> eventHandler) {
            return WeakSubscribe(obj.GetType().GetEvent(eventName), obj, eventHandler);
        }

        public static MvxGeneralEventSubscription WeakSubscribe(this EventInfo eventInfo, object source, EventHandler<EventArgs> eventHandler) {
            return new MvxGeneralEventSubscription(source, eventInfo, eventHandler);
        }

        public static MvxGeneralEventSubscription<TEventArgs> WeakSubscribe<TEventArgs>(this object obj, string eventName, EventHandler<TEventArgs> eventHandler)
            where TEventArgs : EventArgs {

            return WeakSubscribe(obj.GetType().GetEvent(eventName), obj, eventHandler);
        }

        public static MvxGeneralEventSubscription<TEventArgs> WeakSubscribe<TEventArgs>(this EventInfo eventInfo, object source, EventHandler<TEventArgs> eventHandler)
            where TEventArgs : EventArgs {

            return new MvxGeneralEventSubscription<TEventArgs>(source, eventInfo, eventHandler);
        }
    }
}

