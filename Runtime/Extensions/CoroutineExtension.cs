using System.Collections;
using UnityEngine;

namespace ARRT
{
    public static class CoroutineExtension
    {
        public static Coroutine Start(this IEnumerator routine)
        {
            return CoroutineManager.Start(routine);
        }

        public static void Stop(this Coroutine routine)
        {
            CoroutineManager.Stop(routine);
        }
    }
}
