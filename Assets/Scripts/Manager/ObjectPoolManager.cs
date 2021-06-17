using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PoolType
{
    MonsterA = 1,
    MonsterB,
    MonsterC,
    Bullet,
    Missile,
    Arrow,
    BossBullet
}

public class ObjectPoolManager : MonoSingleton<ObjectPoolManager>
{
    Queue<GameObject> Pool_MonsterA, Pool_MonsterB, Pool_MonsterC, Pool_BulletA, Pool_BulletB, Pool_BulletC, Pool_BossBullet;

    [SerializeField] GameObject MonsterA, MonsterB, MonsterC, BulletA, BulletB, BulletC, BossBullet;
    [SerializeField] int[] counts; 
    public override void Start()
    {
        base.Start();
        PoolInit();
    }

    void PoolInit()
    {
        Pool_MonsterA = new Queue<GameObject>(counts[0]);
        Pool_MonsterB = new Queue<GameObject>(counts[1]);
        Pool_MonsterC = new Queue<GameObject>(counts[2]);
        Pool_BulletA = new Queue<GameObject>(counts[3]);
        Pool_BulletB = new Queue<GameObject>(counts[4]);
        Pool_BulletC = new Queue<GameObject>(counts[5]);
        Pool_BossBullet = new Queue<GameObject>(counts[6]);


        for (int i = 0; i < counts[0]; i++)
        {
            GameObject temp = Instantiate(MonsterA);
            Pool_MonsterA.Enqueue(temp);
            temp.SetActive(false);
        }

        for (int i = 0; i < counts[1]; i++)
        {
            GameObject temp = Instantiate(MonsterB);
            Pool_MonsterB.Enqueue(temp);
            temp.SetActive(false);
        }

        for (int i = 0; i < counts[2]; i++)
        {
            GameObject temp = Instantiate(MonsterC);
            Pool_MonsterC.Enqueue(temp);
            temp.SetActive(false);
        }

        for (int i = 0; i < counts[3]; i++)
        {
            GameObject temp = Instantiate(BulletA);
            Pool_BulletA.Enqueue(temp);
            temp.SetActive(false);
        }
        for (int i = 0; i < counts[4]; i++)
        {
            GameObject temp = Instantiate(BulletB);
            Pool_BulletB.Enqueue(temp);
            temp.SetActive(false);
        }
        for (int i = 0; i < counts[5]; i++)
        {
            GameObject temp = Instantiate(BulletC);
            Pool_BulletC.Enqueue(temp);
            temp.SetActive(false);
        }
        for (int i = 0; i < counts[6]; i++)
        {
            GameObject temp = Instantiate(BossBullet);
            Pool_BossBullet.Enqueue(temp);
            temp.SetActive(false);
        }
    }

    public void DeleteObj(int _type, GameObject _obj)
    {
        switch (_type)
        {
            case 1:
                Pool_MonsterA.Enqueue(_obj);
                break;
            case 2:
                Pool_MonsterB.Enqueue(_obj);
                break;
            case 3:
                Pool_MonsterC.Enqueue(_obj);
                break;
            case 4:
                Pool_BulletA.Enqueue(_obj);
                break;
            case 5:
                Pool_BulletB.Enqueue(_obj);
                break;
            case 6:
                Pool_BulletC.Enqueue(_obj);
                break;
            case 7:
                Pool_BossBullet.Enqueue(_obj);
                break;
        }
        _obj.SetActive(false);
    }

    public GameObject MakeObj(int _type)
    {
        GameObject temp;
        switch (_type)
        {
            case 1:
                temp = Pool_MonsterA.Dequeue();
                break;
            case 2:
                temp = Pool_MonsterB.Dequeue();
                break;
            case 3:
                temp = Pool_MonsterC.Dequeue();
                break;
            case 4:
                temp = Pool_BulletA.Dequeue();
                break;
            case 5:
                temp = Pool_BulletB.Dequeue();
                break;
            case 6:
                temp = Pool_BulletC.Dequeue();
                break;
            case 7:
                temp = Pool_BossBullet.Dequeue();
                break;
            default:
                temp = Pool_BossBullet.Dequeue();
                break;
        }
        temp.SetActive(true);
        return temp;
    }
}
