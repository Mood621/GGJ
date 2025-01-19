using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtonContro_l : MonoBehaviour
{
    public Button button_1;
    public TextMeshProUGUI text_1;

    private void Start()
    {
        button_1.onClick.AddListener(ButtonOnClick);
    }

    public void ButtonOnClick()
    {
        text_1.text = "Start";
    }
}
