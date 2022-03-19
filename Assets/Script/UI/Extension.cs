using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public static class Extension
{
    static public T GetOrAddComponent<T>(this GameObject go) where T : UnityEngine.Component
    {
        return Util.GetOrAddComponent<T>(go);
    }

    static public void BindEvent(this GameObject go, Action<PointerEventData> action, Define.UIEvent type)
    {
        UI_Base.BindEvent(go, action, type);
    }
}
