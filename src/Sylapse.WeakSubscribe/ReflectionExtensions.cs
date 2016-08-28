using System;
using System.Reflection;

namespace Sylapse.WeakSubscribe {
    public static class ReflectionExtensions {
        public static MethodInfo GetAddMethod(this EventInfo eventInfo, bool nonPublic = false) {
            if (eventInfo.AddMethod == null || (!nonPublic && !eventInfo.AddMethod.IsPublic))
            {
                return null;
            }

            return eventInfo.AddMethod;
        }

        public static MethodInfo GetRemoveMethod(this EventInfo eventInfo, bool nonPublic = false) {
            if (eventInfo.RemoveMethod == null || (!nonPublic && !eventInfo.RemoveMethod.IsPublic))
            {
                return null;
            }

            return eventInfo.RemoveMethod;
        }

        public static EventInfo GetEvent(this Type type, string name) {
            return type.GetRuntimeEvent(name);
        }
    }
}

