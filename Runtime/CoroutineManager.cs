using UnityEngine;
using System.Collections;

namespace ARRT
{
    /// <summary>
    /// Responsible for launching coroutines from anywhere.
    /// </summary>
    public class CoroutineManager : Singleton<CoroutineManager>
    {
        public static Coroutine Start(IEnumerator routine)
        {
            return instance.StartCoroutine(routine);
        }

        public static Coroutine Start(string methodName)
        {
            return instance.StartCoroutine(methodName);
        }

        public static Coroutine Start(string methodName, object value)
        {
            return instance.StartCoroutine(methodName, value);
        }

        public static void Stop(IEnumerator routine)
        {
            instance.StopCoroutine(routine);
        }

        public static void Stop(Coroutine routine)
        {
            instance.StopCoroutine(routine);
        }

        public static void Stop(string methodName)
        {
            instance.StopCoroutine(methodName);
        }

        public static void StopAll()
        {
            instance.StopAllCoroutines();
        }
    }
}
