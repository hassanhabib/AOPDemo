using System;
using System.Reflection;

namespace AOPDemo
{
    public class StudentServiceDispatch<T> : DispatchProxy
    {
        public T Target { get; set; }

        public static T Create<T>(T target) where T : class
        {
            var proxy = Create<T, StudentServiceDispatch<T>>()
                as StudentServiceDispatch<T>;

            proxy.Target = target;

            return proxy as T;
        }

        protected override object? Invoke(
            MethodInfo? targetMethod,
            object?[]? args)
        {
            Console.WriteLine("Hello, Proxy Student!");

            return targetMethod.Invoke(Target, args);
        }
    }
}
