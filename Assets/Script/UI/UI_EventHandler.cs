using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_EventHandler : MonoBehaviour, IPointerClickHandler, IDragHandler, IPointerDownHandler
{
    public Action<PointerEventData> DragHandler = null;
    public Action<PointerEventData> ClickHandler = null;
    public Action<PointerEventData> PointerDown = null;

    public void OnDrag(PointerEventData eventData)
    {
        if (DragHandler != null)
            DragHandler.Invoke(eventData);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (ClickHandler != null)
            ClickHandler.Invoke(eventData);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (PointerDown != null)
            PointerDown.Invoke(eventData);
    }
}
