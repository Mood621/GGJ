using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtonContro_2 : MonoBehaviour
{
    public Button button_2;
    public TextMeshProUGUI text_2;

    private void Start()
    {
        button_2.onClick.AddListener(ButtonOnClick);
    }

    public void ButtonOnClick()
    {
        text_2.text = "Quit";
    }
}
