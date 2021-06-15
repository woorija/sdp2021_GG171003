using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeUI : Observer
{
    int life;
    Text _text;
    public override void OnNotify(eObserverEvent observerEvent, int value)
    {
        if (observerEvent == eObserverEvent.Life)
        {
            life -= value;
            _text.text = life.ToString();
        }
    }
}
