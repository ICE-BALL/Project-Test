using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Item : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "unitychan")
        {
            UI_Inven.Set_Item_Drop("Hp", UI_Inven.Food_Inventory);
            UI_Inven.Set_Item_Drop("Sword", UI_Inven.Weapon_Inventory);
            UI_Inven.Set_Item_Drop("Shield", UI_Inven.Weapon_Inventory);
            UI_Inven.Set_Item_Drop("Apple", UI_Inven.Food_Inventory);

            Destroy(gameObject);
        }
    }
}
