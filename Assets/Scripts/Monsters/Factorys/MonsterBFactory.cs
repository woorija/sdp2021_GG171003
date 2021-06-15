using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBFactory : Factory
{
    Queue<GameObject> MonsterB_pool;
    [SerializeField] GameObject MonsterB;
    int _count = 10;

    private void Start()
    {
        MonsterB_pool = new Queue<GameObject>(_count);
        for (int i = 0; i < _count; i++)
        {
            GameObject temp = Instantiate(MonsterB, transform);
            MonsterB_pool.Enqueue(temp);
            temp.SetActive(false);
        }
    }

    public override GameObject MakeMonster()
    {
        GameObject temp = MonsterB_pool.Dequeue();
        temp.SetActive(true);
        return temp;
    }

    public override void DeleteMonster(GameObject _obj)
    {
        MonsterB_pool.Enqueue(_obj);
        _obj.SetActive(false);
    }
}