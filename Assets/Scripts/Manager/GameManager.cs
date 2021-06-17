using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{ 
    GameObject _clear, _over, _start;

    public delegate void MonsterDieNotify();
    public MonsterDieNotify DieNotify;
    FactoryMethodUse factory;

    int KillCount;
    int Stage_num;

    public override void Start()
    {
        base.Start();
        _clear = GameObject.Find("GameClear");
        _over = GameObject.Find("Gameover");
        _start = GameObject.Find("GameStart");
        _clear.SetActive(false);
        _over.SetActive(false);
        factory = FindObjectOfType<FactoryMethodUse>();
        KillCount = 0;
        Stage_num = 1;
        Time.timeScale = 0;
    }

    public void GameStart()
    {
        Time.timeScale = 1;
        factory.Stage_Start(Stage_num);
        _start.SetActive(false);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        _over.SetActive(true);
    }

    public void GameClear()
    {
        Time.timeScale = 0;
        _clear.SetActive(true);
    }

    public void kill_monster()
    {
        KillCount++;
        if(KillCount >= 10)
        {
            NextStageStart();
        }
    }

    void NextStageStart()
    {
        factory.StopSpawn();
        Stage_num++;
        KillCount = 0;
        DieNotify();
        factory.Stage_Start(Stage_num);
    }
}
