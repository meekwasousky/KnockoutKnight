using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    [SerializeField]
    private GameEvent OnKnightSelected; // 1

    [SerializeField]

    private KnghtData knightData; // 1

    //private void OnMouseDown() // 2
    //{
    //    Debug.Log(knightData.KnightType); // 3
    //    Debug.Log(knightData.Description); // 3
    //    Debug.Log(knightData.Icon.name); // 3
    //    Debug.Log(knightData.Health);
    //    Debug.Log(knightData.Defense); // 3
    //    Debug.Log(knightData.AttackDamage); // 3
    //}

    private void OnMouseDown()
    {
        OnKnightSelected.Raise(); // 2
        Debug.Log("event Raised");
    }
}
