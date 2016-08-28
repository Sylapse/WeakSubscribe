using System;
using System.Reflection;

namespace Sylapse.WeakSubscribe {
    public class MvxGeneralEventSubscription : MvxWeakEventSubscription<object, EventArgs> {
        public MvxGeneralEventSubscription(object source, EventInfo eventInfo, EventHandler<EventArgs> eventHandler) : base(source, eventInfo, eventHandler) {
        }

        protected override Delegate CreateEventHandler() {
            return new EventHandler(this.OnSourceEvent);
        }
    }

    public class MvxGeneralEventSubscription<TEventArgs> : MvxWeakEventSubscription<object, TEventArgs>
        where TEventArgs : EventArgs {

        public MvxGeneralEventSubscription(object source, EventInfo eventInfo, EventHandler<TEventArgs> eventHandler)
            : base(source, eventInfo, eventHandler) {
        }

        protected override Delegate CreateEventHandler() {
            return new EventHandler<TEventArgs>(this.OnSourceEvent);
        }
    }
}

