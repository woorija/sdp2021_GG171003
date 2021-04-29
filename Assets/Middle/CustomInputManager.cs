using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInfor
{
    public bool _alt;
    public bool _ctrl;
    public bool _shift;
    public int _key;

    public void Set_Null()
    {
        _alt = false;
        _ctrl = false;
        _shift = false;
        _key = 0;
    }

    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        KeyInfor objAsPart = obj as KeyInfor;
        if (objAsPart == null) return false;
        else return Equals(objAsPart);
    }
    public override int GetHashCode()
    {
        int a = _alt ? 1 : 0;
        int b = _ctrl ? 2 : 0;
        int c = _shift ? 4 : 0;
        return _key + a + b + c;
    }
    public bool Equals(KeyInfor other)
    {
        if (other == null) return false;

        if (_alt != other._alt) return false;
        if (_ctrl != other._ctrl) return false;
        if (_shift != other._shift) return false;
        if (_key != other._key) return false;
        return true;
    }
}

public class CustomInputManager : MonoSingleton<CustomInputManager>
{

    public bool isKeychange { get; private set; } = false;
    int key_number;

    [SerializeField] KeySettingIcon[] keys;
    [SerializeField] GameObject keychangeUI;
    public KeyInfor[] keyinfor { get; private set; } = new KeyInfor[13];

    public override void Start()
    {
        base.Start();
        for (int i = 0; i < keyinfor.Length; i++)
        {
            keyinfor[i] = new KeyInfor();
        }
    }

    private void OnGUI()
    {
        Event e = Event.current;
        if (isKeychange)
        {
            if (e.isKey)
            {
                if (KeycodeCheck(e))
                {
                    KeyChange(key_number, e);
                    StartCoroutine(Keychange_false());
                    keychangeUI.SetActive(false);
                }
            }
        }
    }

    IEnumerator Keychange_false() // 키변경 즉시 커맨드 입력이 되지 않게 하기위한 1프레임 이후 모드변경
    {
        yield return null;
        isKeychange = false;
    }

    public void Keyinfor_Load()
    {
        for (int i = 0; i < keyinfor.Length; i++)
        {
            keyinfor[i]._alt = CustomInputSaveLoad.Instance.keycfg._alt[i];
            keyinfor[i]._ctrl = CustomInputSaveLoad.Instance.keycfg._ctrl[i];
            keyinfor[i]._shift = CustomInputSaveLoad.Instance.keycfg._shift[i];
            keyinfor[i]._key = CustomInputSaveLoad.Instance.keycfg._key[i];
        }
        UI_Settings();
    }

    public void UI_Settings()
    {
        for (int i = 0; i < keyinfor.Length; i++)
        {
            UI_Setting(i);
        }
    }

    public void UI_Setting(int _index)
    {
        keys[_index].Get_KeyEvent(keyinfor[_index]._alt, keyinfor[_index]._ctrl, keyinfor[_index]._shift, keyinfor[_index]._key);
    }

    bool KeycodeCheck(Event _e)
    {
        if((int)_e.keyCode >= 48 && (int)_e.keyCode <= 57 || (int)_e.keyCode >= 97 && (int)_e.keyCode <= 122) // 숫자와 영문자리만
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void KeyChange(int _index, Event _e)
    {
        keyinfor[_index]._alt = _e.alt;
        keyinfor[_index]._ctrl = _e.control;
        keyinfor[_index]._shift = _e.shift;
        keyinfor[_index]._key = (int)_e.keyCode;
        UI_Setting(_index);
        KeyCheck(_index);
    }

    void KeyCheck(int _index)
    {
        for(int i = 0; i < keyinfor.Length; i++)
        {
            if (i == _index) continue;

            if (keyinfor[_index].Equals(keyinfor[i]))
            {
                keyinfor[i].Set_Null();
                UI_Setting(i);
            }
        }
    }

    public void SetKeyChange_btn(int _num)
    {
        isKeychange = true;
        keychangeUI.SetActive(true);
        key_number = _num;
    }


    bool ModifiersCheck(int _index)
    {
        bool _alt = Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt);
        bool _ctrl = Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);
        bool _shift = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

        if (keyinfor[_index]._alt != _alt) return false;
        if (keyinfor[_index]._ctrl != _ctrl) return false;
        if (keyinfor[_index]._shift != _shift) return false;
        return true;
    }

    public bool GetKeyDown(int _index)
    {
        if (keyinfor[_index]._key == 0) return false;
        if (!ModifiersCheck(_index)) return false;
        if (Input.GetKeyDown((KeyCode)keyinfor[_index]._key)) return true;
        return false;
    }
}
