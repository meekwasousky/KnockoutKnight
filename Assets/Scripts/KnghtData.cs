using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Knight Data", menuName = "Knight Data", order = 51)]
public class KnghtData : ScriptableObject
{

    [SerializeField]
    private string knightType;
    [SerializeField]
    private string description;
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private int heatlth;
    [SerializeField]
    private int attackDamage;
    [SerializeField]
    private int defense;
}
