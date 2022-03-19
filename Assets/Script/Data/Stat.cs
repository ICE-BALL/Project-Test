using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat
{
    protected int hp = 100;
    protected int attack = 5;
    protected float speed = 10.0f;

    public int Hp { get { return hp; } set { hp = value; } }
    public int Attack { get { return attack; } set { attack = value; } }
    public float Speed { get { return speed; } set { speed = value; } }
}
