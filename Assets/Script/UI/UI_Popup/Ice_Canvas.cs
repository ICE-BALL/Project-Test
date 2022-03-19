using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Ice_Canvas : UI_Popup
{
    static public Action Ice = null;

    enum Buttons
    {
        Ice,
    }

    enum Texts
    {
        Text_Ice,
    }

    private void Start()
    {
        Init();
    }

    public override void Init()
    {
        base.Init();

        Bind<Button>(typeof(Buttons));
        Bind<Text>(typeof(Texts));

        ShowOrClose();

        GetButton((int)Buttons.Ice).gameObject.BindEvent(Change_Sword, Define.UIEvent.Click);
    }

    void ShowOrClose()
    {
        if (Define.Bag == true)
            gameObject.SetActive(true);
        else
            gameObject.SetActive(false);
    }

    void Change_Sword(PointerEventData data)
    {
        if (Ice != null)
            Ice.Invoke();
    }
}
