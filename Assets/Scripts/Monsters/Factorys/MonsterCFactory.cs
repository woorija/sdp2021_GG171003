using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCFactory : Factory
{
    public override GameObject MakeMonster()
    {
        GameObject temp = ObjectPoolManager.Instance.MakeObj((int)PoolType.MonsterC);
        temp.SetActive(true);
        return temp;
    }
}