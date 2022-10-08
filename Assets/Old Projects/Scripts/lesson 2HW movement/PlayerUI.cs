using System;
using UnityEngine;
using UnityEngine.UI;
public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Text mkeys;
    public static Action<int> KeyChanged;
    public void Start()
    {
        KeyChanged += OnKeyChanged;
    }
    private void OnKeyChanged(int keys)
    {
        mkeys.text = keys.ToString();
    }
}