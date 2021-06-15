using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAFactory : Factory
{
    Queue<GameObject> MonsterA_pool;
    [SerializeField] GameObject MonsterA;
    int _count = 10;

    private void Start()
    {
        MonsterA_pool = new Queue<GameObject>(_count);
        for (int i = 0; i < _count; i++)
        {
            GameObject temp = Instantiate(MonsterA, transform);
            MonsterA_pool.Enqueue(temp);
            temp.GetComponent<MonsterA>().SetFactory(this);
            temp.SetActive(false);
        }
    }

    public override GameObject MakeMonster()
    {
        GameObject temp = MonsterA_pool.Dequeue();
        temp.SetActive(true);
        return temp;
    }

    public override void DeleteMonster(GameObject _obj)
    {
        MonsterA_pool.Enqueue(_obj);
        _obj.SetActive(false);
    }
}
