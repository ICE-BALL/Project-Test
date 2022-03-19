using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util
{
    static public T GetOrAddComponent<T>(GameObject go) where T : UnityEngine.Component
    {
        if (go == null)
            return null;

        T Component = go.GetComponent<T>();
        if (Component == null)
            Component = go.AddComponent<T>();

        return Component;
    }

    static public GameObject FindChild(GameObject go, string name = null, bool recursive = false)
    {
        GameObject child = FindChild<GameObject>(go, name, recursive);

        if (child == null)
            return null;

        return child;
    }

    static public T FindChild<T>(GameObject go, string name = null, bool recursive = false) where T : UnityEngine.Object
    {
        if (go == null)
            return null;

        if (recursive == false)
        {
            for (int i = 0; i < go.transform.childCount; i++)
            {
                Transform transform = go.transform.GetChild(i);
                if (string.IsNullOrEmpty(name) || transform.name == name)
                {
                    T component = go.GetComponent<T>();
                    if (component != null)
                        return component;
                }
            }
        }
        else
        {
            foreach (T component in go.GetComponentsInChildren<T>())
            {
                if (string.IsNullOrEmpty(name) || component.name == name)
                    return component;
            }
        }

        return null;
    }
}
