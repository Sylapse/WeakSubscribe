# WeakSubscribe

Weak subscription code taken from the MvvmCross codebase and provided on its own.


Standard event args
```
IDisposable _subscription = objWithEvent.WeakSubscribe("MyEvent", (sender, e) => {});
```
or
```
IDisposable _subscription = typeof(objWithEvent)
                      .GetEvent("MyEvent")
                      .WeakSubscribe(objWithEvent, (sender, e) => {});
```

Custom event args
```
IDisposable _subscription = objWithEvent.WeakSubscribe<MyEventArgs>("MyEvent", (sender, e) => {});
```
or
```
IDisposable _subscription = typeof(objWithEvent)
                      .GetEvent("MyEvent")
                      .WeakSubscribe<MyEventArgs>(objWithEvent, (sender, e) => {});
```

## Nuget

https://www.nuget.org/packages/Sylapse.WeakSubscribe
