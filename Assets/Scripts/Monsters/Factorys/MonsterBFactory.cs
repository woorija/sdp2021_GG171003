using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBFactory : Factory
{
    public override GameObject MakeMonster()
    {
        GameObject temp = ObjectPoolManager.Instance.MakeObj((int)PoolType.MonsterB);
        temp.SetActive(true);
        return temp;
    }
}