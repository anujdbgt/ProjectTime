using System;
using System.Collections.Generic;
using UnityEngine;

namespace TheRamanEffect.UnityEngineExtensions
{
    public interface IComponent : IObject
    {
        GameObject gameObject { get; }
        Transform transform { get; }
        
        string tag { get; set; }
        bool CompareTag(string tag);

        Component GetComponent(Type type);
        T GetComponent<T>();

        Component GetComponentInChildren(Type t, bool includeInactive);
        T GetComponentInChildren<T>(bool includeInactive);
        Component GetComponentInChildren(Type t);
        T GetComponentInChildren<T>();

        Component GetComponentInParent(Type t);
        T GetComponentInParent<T>();

        Component[] GetComponents(Type type);
        T[] GetComponents<T>();
        void GetComponents(Type type, List<Component> results);
        void GetComponents<T>(List<T> results);

        Component[] GetComponentsInChildren(Type t, bool includeInactive);
        T[] GetComponentsInChildren<T>(bool includeInactive);
        Component[] GetComponentsInChildren(Type t);
        T[] GetComponentsInChildren<T>();
        void GetComponentsInChildren<T>(bool includeInactive, List<T> result);
        void GetComponentsInChildren<T>(List<T> results);

        Component[] GetComponentsInParent(Type t, bool includeInactive);
        T[] GetComponentsInParent<T>(bool includeInactive);
        Component[] GetComponentsInParent(Type t);
        T[] GetComponentsInParent<T>();
        void GetComponentsInParent<T>(bool includeInactive, List<T> results);
    }
}