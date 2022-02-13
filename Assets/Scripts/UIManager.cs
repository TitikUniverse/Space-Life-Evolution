using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text darkMaterialText;

    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateDarkMaterialTextUI(int value)
    {
        darkMaterialText.text = value.ToString();
    }
}
