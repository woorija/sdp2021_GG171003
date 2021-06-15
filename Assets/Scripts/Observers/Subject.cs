using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    [SerializeField] Observer scoreUI, lifeUI;

    delegate void NotifyHandler(eObserverEvent ob, int value);
    NotifyHandler _notifyHandler;

    private void Start()
    {
        _notifyHandler += scoreUI.OnNotify;
        _notifyHandler += lifeUI.OnNotify;
    }

    public void UIUpdate(eObserverEvent ob, int value)
    {
        _notifyHandler(ob, value);
    }
}
