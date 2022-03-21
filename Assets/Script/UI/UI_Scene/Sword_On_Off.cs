using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Sword_On_Off : UI_Scene
{
    enum Images
    {
        Sword,
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
        GetImage((int)Images.Sword).gameObject.BindEvent(ClickEvent, Define.UIEvent.Click);
    }

    void ClickEvent(PointerEventData data)
    {
        if (Define.Sword == false)
        {
            Define.Sword = true;
            Managers.UI.ShowPopupUI<Ice_Canvas>();
            Managers.UI.ShowPopupUI<Iron_Canvas>();
        }
        else
        {
            Define.Sword = false;
            Managers.UI.CloseAllPopupUI();
        }
    }
}
