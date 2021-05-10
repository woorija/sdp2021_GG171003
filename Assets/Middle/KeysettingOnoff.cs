using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysettingOnoff : MonoBehaviour
{
    public GameObject keysettingUI;
    bool isActive = true;

    private void Start()
    {
        Onoff();
    }

    public void Onoff()
    {
        isActive = !isActive;
        keysettingUI.SetActive(isActive);
    }
}
