using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Factory : MonoBehaviour
{
    public abstract GameObject MakeMonster();
    public abstract void DeleteMonster(GameObject _obj);
}
