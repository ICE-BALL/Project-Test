using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    static public bool Bag = false;
    static public bool Sword = false;

    public enum UIEvent
    {
        Click,
        Drag,
        Down,
    }

    public enum ItemType
    {
        Food,
        Weapon,
        Upbringing,
    }
}
