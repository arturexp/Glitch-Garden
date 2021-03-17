using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour {
    
    private void OnMouseOver()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons) {

            button.GetComponent<SpriteRenderer>().color = new Color32(114, 114, 114, 255);

        }
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
