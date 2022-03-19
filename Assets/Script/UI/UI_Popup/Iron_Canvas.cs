using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Iron_Canvas : UI_Popup
{
    static public Action Iron = null;

    enum Buttons
    {
        Iron,
    }

    enum Texts
    {
        Text_Iron,
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

        GetButton((int)Buttons.Iron).gameObject.BindEvent(Change_Sword, Define.UIEvent.Click);
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
        if (Iron != null)
            Iron.Invoke();
    }
}
