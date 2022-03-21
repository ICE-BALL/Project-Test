using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_Inven : UI_Popup
{
    Inventory_Item_Type Type_Item = new Inventory_Item_Type();
    public static Define.ItemType Item_Type = Define.ItemType.Food;

    public static string[] Food_Inventory = new string[27];
    public static string[] Weapon_Inventory = new string[27];
    public static string[] Upbringing_Inventory = new string[27];

    enum GameObjects
    {
        // Inven
        Inven,
        // Food
        Food,
        food,
        // Weapon
        Weapon,
        weapon,
        // Upbringing
        Upbringing,
        upbringing,
    }

    private void Start()
    {
        Init();
    }

    public override void Init()
    {
        base.Init();

        Bind<GameObject>(typeof(GameObjects));

        GetObject((int)GameObjects.Food).gameObject.BindEvent(Inventory_TypeToFood, Define.UIEvent.Click);
        GetObject((int)GameObjects.Weapon).gameObject.BindEvent(Inventory_TypeToWepon, Define.UIEvent.Click);
        GetObject((int)GameObjects.Upbringing).gameObject.BindEvent(Inventory_TypeToUpbringing, Define.UIEvent.Click);

        Load_Path(Food_Inventory, Define.ItemType.Food);
    }

    public static int Inven_Empty_idx(string[] array)
    {
        for (int i = 0; i < 27; i++)
        {
            if (array.GetValue(i) == null)
                return i;
        }

        return 0;
    }

    public void Inventory_TypeToFood(PointerEventData data)
    {
        Debug.Log("Inventory_TypeToFood");
        Item_Type = Define.ItemType.Food;
        Load_Path(Food_Inventory, Define.ItemType.Food);
    }

    public void Inventory_TypeToWepon(PointerEventData data)
    {
        Debug.Log("Inventory_TypeToWepon");
        Item_Type = Define.ItemType.Weapon;
        Load_Path(Weapon_Inventory, Define.ItemType.Weapon);
    }

    public void Inventory_TypeToUpbringing(PointerEventData data)
    {
        Debug.Log("Inventory_TypeToUpbringing");
        Item_Type = Define.ItemType.Upbringing;
        Load_Path(Upbringing_Inventory, Define.ItemType.Upbringing);
    }

    public void Inventory_Load(string[] type, string path = null)
    {
        GameObject Inven = Get<GameObject>((int)GameObjects.Inven);
        foreach (Transform child in Inven.transform) // 모든 아이템 슬롯들 파괴 (미리 파괴하고 시작)
            Managers.Resource.Destroy(child.gameObject);
            

        for (int i = 0; i < 27; i++)
        {
            GameObject item;
            if (type[i] == "Apple")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.apple_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.apple_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.apple_path);
                }
            }
            else if (type[i] == "Armor")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.armor_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.armor_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.armor_path);
                }
            }
            else if (type[i] == "Bag")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.bag_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.bag_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.bag_path);
                }
            }
            else if (type[i] == "Axe")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.axe_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.axe_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.axe_path);
                }
            }
            else if (type[i] == "Belts")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.belts_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.belts_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.belts_path);
                }
            }
            else if (type[i] == "Book")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.book_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.book_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.book_path);
                }
            }
            else if (type[i] == "Boots")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.boots_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.boots_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.boots_path);
                }
            }
            else if (type[i] == "Bracers")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.bracers_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.bracers_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.bracers_path);
                }
            }
            else if (type[i] == "B_t_01")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.b_t_01_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.b_t_01_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.b_t_01_path);
                }
            }
            else if (type[i] == "Cloaks")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.cloaks_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.cloaks_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.cloaks_path);
                }
            }
            else if (type[i] == "Coins")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.coins_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.coins_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.coins_path);
                }
            }
            else if (type[i] == "Gem")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.gem_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.gem_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.gem_path);
                }
            }
            else if (type[i] == "Gloves")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.gloves_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.gloves_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.gloves_path);
                }
            }
            else if (type[i] == "Helmets")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.helmets_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.helmets_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.helmets_path);
                }
            }
            else if (type[i] == "Hp")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.hp_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.hp_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.hp_path);
                }
            }
            else if (type[i] == "Ingots")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.ingots_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.ingots_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.ingots_path);
                }
            }
            else if (type[i] == "Meat")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.Meat_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.Meat_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.Meat_path);
                }
            }
            else if (type[i] == "Mp")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.mp_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.mp_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.mp_path);
                }
            }
            else if (type[i] == "Neaklace")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.neaklace_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.neaklace_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.neaklace_path);
                }
            }
            else if (type[i] == "Pants")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.pants_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.pants_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.pants_path);
                }
            }
            else if (type[i] == "Rings")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.rings_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.rings_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.rings_path);
                }
            }
            else if (type[i] == "Scroll")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.scroll_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.scroll_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.scroll_path);
                }
            }
            else if (type[i] == "Shield")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.shield_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.shield_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.shield_path);
                }
            }
            else if (type[i] == "Shoulders")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.shoulders_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.shoulders_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.shoulders_path);
                }
            }
            else if (type[i] == "Sword")
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                Color color = item.GetComponent<Image>().color;
                color.a = 230f;
                item.GetComponent<Image>().color = color;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type, Type_Item.sword_path);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type, Type_Item.sword_path);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type, Type_Item.sword_path);
                }
            }

            else
            {
                item = Managers.UI.MakeSubItem<UI_Inven_Item>(Inven.transform, "Inven_Item").gameObject;
                UI_Inven_Item invenItem = item.GetOrAddComponent<UI_Inven_Item>();
                if (Item_Type == Define.ItemType.Food)
                {
                    invenItem.SetInfo($"{Food_Inventory[i]}", Item_Type);
                }
                else if (Item_Type == Define.ItemType.Weapon)
                {
                    invenItem.SetInfo($"{Weapon_Inventory[i]}", Item_Type);
                }
                else if (Item_Type == Define.ItemType.Upbringing)
                {
                    invenItem.SetInfo($"{Upbringing_Inventory[i]}", Item_Type);
                }
            }
        }
    }

    public void Load_Path(string[] array_type, Define.ItemType ItemType)
    {
        if (ItemType == Define.ItemType.Food)
        {
            Inventory_Load(array_type, "Apple");
            Inventory_Load(array_type, "Hp");
            Inventory_Load(array_type, "Meat");
            Inventory_Load(array_type, "Mp");
        }

        if (ItemType == Define.ItemType.Weapon)
        {
            Inventory_Load(array_type, "Armor");
            Inventory_Load(array_type, "Axe");
            Inventory_Load(array_type, "B_t_01");
            Inventory_Load(array_type, "Belts");
            Inventory_Load(array_type, "Boots");
            Inventory_Load(array_type, "Bracers");
            Inventory_Load(array_type, "Cloaks");
            Inventory_Load(array_type, "Gloves");
            Inventory_Load(array_type, "Helmets");
            Inventory_Load(array_type, "Neaklace");
            Inventory_Load(array_type, "Pants");
            Inventory_Load(array_type, "Rings");
            Inventory_Load(array_type, "Shield");
            Inventory_Load(array_type, "Shoulders");
            Inventory_Load(array_type, "Sword");
        }

        if (ItemType == Define.ItemType.Upbringing)
        {
            Inventory_Load(array_type, "Bag");
            Inventory_Load(array_type, "Coins");
            Inventory_Load(array_type, "Gem");
            Inventory_Load(array_type, "Ingots");
            Inventory_Load(array_type, "Scroll");
        }
    }

    public static void Set_Item_Drop(string name, string[] type)
    {
        type.SetValue(name, Inven_Empty_idx(type));
    }
}
