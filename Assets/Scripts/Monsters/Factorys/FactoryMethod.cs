using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryMethod : MonoBehaviour
{
    Factory factory;

    public Factory Select_Factory(int _num)
    {
        switch (_num)
        {
            case 0:
                factory = GetComponent<MonsterAFactory>();
                break;
            case 1:
                factory = GetComponent<MonsterBFactory>();
                break;
        }
        return factory;
    }
}
