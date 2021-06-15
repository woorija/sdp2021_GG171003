using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryMethodUse : MonoBehaviour
{
    FactoryMethod factoryMethod;
    Factory factory;
    private void Start()
    {
        factoryMethod = GetComponent<FactoryMethod>();
        SelectFactory(0);
        StartCoroutine(SpawnStart());
    }

    public void SelectFactory(int _num)
    {
        factory = factoryMethod.Select_Factory(_num);
    }

    IEnumerator SpawnStart()
    {
        yield return null;
        for(int i = 0; i < 5; i++)
        {
            Spawn(new Vector3(Random.Range(-6f, 6f), 8, 0));
            yield return new WaitForSeconds(1f);
        }
        SelectFactory(1);
        for (int i = 0; i < 5; i++)
        {
            Spawn(new Vector3(Random.Range(-6f, 6f), 8, 0));
            yield return new WaitForSeconds(1f);
        }
    }

    void Spawn()
    {
        factory.MakeMonster();
    }

    void Spawn(Vector3 _pos)
    {
        GameObject temp = factory.MakeMonster();
        temp.transform.position = _pos;
    }
}
