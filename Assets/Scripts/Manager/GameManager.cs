using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    public delegate void MonsterDieNotify();
    public MonsterDieNotify DieNotify;

    
}
