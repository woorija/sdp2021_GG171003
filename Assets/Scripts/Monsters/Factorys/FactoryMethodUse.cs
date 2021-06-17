using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryMethodUse : MonoBehaviour
{
    FactoryMethod factoryMethod;
    Factory factory;

    [SerializeField] GameObject Boss;

    Coroutine Cor_Spawn;
    private void Start()
    {
        factoryMethod = GetComponent<FactoryMethod>();
    }

    public void SelectFactory(int _num)
    {
        factory = factoryMethod.Select_Factory(_num);
    }

    public void Stage_Start(int _stage)
    {
        switch (_stage)
        {
            case 1:
                Stage1_Start();
                break;
            case 2:
                Stage2_Start();
                break;
            case 3:
                Stage3_Start();
                break;
            case 4:
                Stage4_Start();
                break;
            case 5:
                Stage5_Start();
                StopSpawn();
                break;
        }
    }

    void Stage1_Start()
    {
        Cor_Spawn = StartCoroutine(Stage1_spawn());
    }

    void Stage2_Start()
    {
        Cor_Spawn = StartCoroutine(Stage2_spawn());
    }
    void Stage3_Start()
    {
        Cor_Spawn = StartCoroutine(Stage3_spawn());
    }
    void Stage4_Start()
    {
        Cor_Spawn = StartCoroutine(Stage4_spawn());
    }

    void Stage5_Start()
    {
        Boss.SetActive(true);
    }

    public void StopSpawn()
    {
        StopCoroutine(Cor_Spawn);
    }

    IEnumerator Stage1_spawn()
    {
        SelectFactory(0);
        yield return null;

        while (true)
        {
            Spawn(new Vector3(Random.Range(-5f, 5f), 8, 0));
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator Stage2_spawn()
    {
        yield return null;

        while (true)
        {
            SelectFactory(0);
            for (int i = 0; i < 5; i++)
            {
                Spawn(new Vector3(Random.Range(-5f, 5f), 8, 0));
                yield return new WaitForSeconds(1f);
            }
            SelectFactory(1);
            for (int i = 0; i < 5; i++)
            {
                Spawn(new Vector3(Random.Range(-5f, 5f), 8, 0));
                yield return new WaitForSeconds(1f);
            }
        }
    }

    IEnumerator Stage3_spawn()
    {
        SelectFactory(1);
        yield return null;

        while (true)
        {
            Spawn(new Vector3(Random.Range(-5f, 5f), 8, 0));
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator Stage4_spawn()
    {
        yield return null;
        while (true)
        {
            SelectFactory(1);
            Spawn(new Vector3(Random.Range(-5f, 5f), 8, 0));
            yield return new WaitForSeconds(1f);
            SelectFactory(2);
            Spawn(new Vector3(Random.Range(-5f, 5f), 8, 0));
            yield return new WaitForSeconds(1f);
        }
    }

    void Spawn(Vector3 _pos)
    {
        GameObject temp = factory.MakeMonster();
        temp.transform.position = _pos;
    }
}
