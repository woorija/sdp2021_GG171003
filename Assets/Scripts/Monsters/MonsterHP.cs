using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHP : MonoBehaviour
{
    [SerializeField] int maxhp;
    public int hp { get; private set; }

    public void HPInit()
    {
        hp = maxhp;
    }

    public bool Hit(int _damage)
    {
        hp -= _damage;
        if (hp <= 0) return true;
        return false;
    }
}
