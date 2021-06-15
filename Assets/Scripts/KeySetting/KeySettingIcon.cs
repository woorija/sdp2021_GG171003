using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeySettingIcon : MonoBehaviour
{
    Text Key_name;
    [SerializeField] GameObject alt_text, ctrl_text, shift_text;

    private void Awake()
    {
        Key_name = GetComponentInChildren<Text>();
    }

    public void Get_KeyEvent(bool _alt,bool _ctrl,bool _shift,int _keycode)
    {
        if (_keycode != 0)
        {
            if (_keycode >= 48 && _keycode <= 57)
            {
                Key_name.text = ((char)(KeyCode)_keycode).ToString();
            }
            else
            {
                Key_name.text = ((KeyCode)_keycode).ToString();
            }
        }
        else
        {
            Key_name.text = "";
        }
        alt_text.SetActive(_alt);
        ctrl_text.SetActive(_ctrl);
        shift_text.SetActive(_shift);
    }
}
