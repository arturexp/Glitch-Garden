using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;
    private void OnMouseDown()
    {
        SpawnDefener(GetSqureClicked());
    }

    private Vector2 GetSqureClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return worldPos;
    }

    private void SpawnDefener(Vector2 coord)
    {
        GameObject newDefender = Instantiate(defender, coord, Quaternion.identity) as GameObject;
    }
}
