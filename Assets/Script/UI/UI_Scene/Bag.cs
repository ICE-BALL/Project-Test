using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class Bag : UI_Scene
{
    enum Images
    {
        Item_Sword,
    }

    void Start()
    {
        Bag_Init();
    }

    public override void Bag_Init()
    {
        base.Bag_Init();

        Bind<Image>(typeof(Images));

        //GameObject.Find("Item_Sword").gameObject.BindEvent(ClickEvent, Define.UIEvent.Click);
        GetImage((int)Images.Item_Sword).gameObject.BindEvent(ClickEvent, Define.UIEvent.Click);
    }

    void ClickEvent(PointerEventData data)
    {
        if (Define.Bag == false)
        {
            Define.Bag = true;
            Managers.UI.ShowPopupUI<UI_Inven>();
            //Managers.UI.ShowPopupUI<Ice_Canvas>();
            //Managers.UI.ShowPopupUI<Iron_Canvas>();
        }
        else
        {
            Define.Bag = false;
            Managers.UI.CloseAllPopupUI();
        }
    }
}
