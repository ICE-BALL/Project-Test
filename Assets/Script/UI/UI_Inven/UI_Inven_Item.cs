using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Inven_Item : UI_Base
{
    Inventory_Item_Type Item = new Inventory_Item_Type();

    enum GameObjects
    {
        Item,
        Item_Name,
    }

    private void Start()
    {
        Init();
    }

    public override void Init()
    {
        Bind<GameObject>(typeof(GameObjects));
        Get<GameObject>((int)GameObjects.Item_Name).GetComponent<Text>().text = Item.Item_Name;

        Get<GameObject>((int)GameObjects.Item).BindEvent((PointerEventData) => { Debug.Log($"{UI_Inven.Item_Type} 아이템 클릭! {Item.Item_Name}"); }, Define.UIEvent.Click);
    }

    public void SetInfo(string name, Define.ItemType type, string path = null)
    {
        if (string.IsNullOrEmpty(path))
            path = "RPG_inventory_icons/f";

        gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(path);

        Item.Item_Name = name;
        Item.Item_Type = type;

        
        //Get<GameObject>((int)GameObjects.Item).gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(path);
    }
}
