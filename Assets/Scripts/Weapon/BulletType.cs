using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletType : MonoBehaviour
{
    [SerializeField] PoolType _type;
    public int Get_Type()
    {
        return (int)_type;
    }
}
