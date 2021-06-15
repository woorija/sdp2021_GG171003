using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : Observer
{
    int score;
    Text _text;
    public override void OnNotify(eObserverEvent observerEvent, int value)
    {
        if (observerEvent == eObserverEvent.Score)
        {
            score += value;
            _text.text = score.ToString();
        }
    }
}
