using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{

    [SerializeField] int stars = 100;
    Text starText;

    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }
    private void UpdateDisplay() {

        starText.text = stars.ToString();
        }

    public bool HaveEnoughStars(int amount) {
        return stars >= amount;
    }

    public void AddStars(int count) {
        
        stars += count;
        UpdateDisplay();
        }

    public void SpendingStars(int count) {
        
        if (stars >= count) {

            stars -= count;
            UpdateDisplay();
            }

        }

}
