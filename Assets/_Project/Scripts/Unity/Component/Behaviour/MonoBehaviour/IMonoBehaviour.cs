using System.Collections;
using UnityEngine;

namespace TheRamanEffect.UnityEngineExtensions
{
    public interface IMonoBehaviour : IBehaviour
    {
        Coroutine StartCoroutine(IEnumerator routine);
        void StopCoroutine(Coroutine routine);
        void StopCoroutine(IEnumerator routine);
        void StopAllCoroutines();
    }
}