using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAFactory : Factory
{
    public override GameObject MakeMonster()
    {
        GameObject temp = ObjectPoolManager.Instance.MakeObj((int)PoolType.MonsterA);
        temp.SetActive(true);
        return temp;
    }
}
