using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class Key_cfg
{
    public List<bool> _alt = new List<bool>();
    public List<bool> _ctrl = new List<bool>();
    public List<bool> _shift = new List<bool>();
    public List<int> _key = new List<int>();
}

public class CustomInputSaveLoad : MonoSingleton<CustomInputSaveLoad>
{
    public Key_cfg keycfg { get; private set; }

    private string SAVE_DATA_DIRECTORY;
    private string SAVE_FILENAME;

    public override void Start()
    {
        base.Start();
        SAVE_DATA_DIRECTORY = Application.dataPath + "/Save/";
        if (!Directory.Exists(SAVE_DATA_DIRECTORY))
        {
            Directory.CreateDirectory(SAVE_DATA_DIRECTORY);
        }

        LoadCustomKeycode();
    }

    public void SaveCustomKeycode() {
        SAVE_FILENAME = "/Key.cfg";
        keycfg = new Key_cfg();

        for(int i = 0; i < CustomInputManager.Instance.keyinfor.Length; i++)
        {
            keycfg._alt.Add(CustomInputManager.Instance.keyinfor[i]._alt);
            keycfg._ctrl.Add(CustomInputManager.Instance.keyinfor[i]._ctrl);
            keycfg._shift.Add(CustomInputManager.Instance.keyinfor[i]._shift);
            keycfg._key.Add(CustomInputManager.Instance.keyinfor[i]._key);
        }

        string json = JsonUtility.ToJson(keycfg);

        File.WriteAllText(SAVE_DATA_DIRECTORY + SAVE_FILENAME, json);
    }

    public void LoadCustomKeycode()
    {
        SAVE_FILENAME = "/Key.cfg";
        if (File.Exists(SAVE_DATA_DIRECTORY + SAVE_FILENAME))
        {
            string loadJson = File.ReadAllText(SAVE_DATA_DIRECTORY + SAVE_FILENAME);
            keycfg = JsonUtility.FromJson<Key_cfg>(loadJson);

            CustomInputManager.Instance.Keyinfor_Load();
        }
        else
        {
            ResetCustomKeycode();
        }
    }

    public void ResetCustomKeycode()
    {
        SAVE_FILENAME = "/BaseKey.cfg";
        if (File.Exists(SAVE_DATA_DIRECTORY + SAVE_FILENAME))
        {
            string loadJson = File.ReadAllText(SAVE_DATA_DIRECTORY + SAVE_FILENAME);
            keycfg = JsonUtility.FromJson<Key_cfg>(loadJson);

            CustomInputManager.Instance.Keyinfor_Load();
        }
        else
        {
            BasekeyInit();
        }
    }

    void BasekeyInit()
    {
        keycfg = new Key_cfg();
        for (int i = 0; i < CustomInputManager.Instance.keyinfor.Length; i++)
        {
            keycfg._alt.Add(false);
            keycfg._ctrl.Add(false);
            keycfg._shift.Add(false);
        }
        keycfg._key.Add(32);
        keycfg._key.Add(119);
        keycfg._key.Add(101);
        keycfg._key.Add(114);
        keycfg._key.Add(273);
        keycfg._key.Add(276);
        keycfg._key.Add(274);
        keycfg._key.Add(275);

        string json = JsonUtility.ToJson(keycfg);

        File.WriteAllText(SAVE_DATA_DIRECTORY + SAVE_FILENAME, json);

        CustomInputManager.Instance.Keyinfor_Load();
    }
}
