using UnityEngine;
using UnityEngine.UI;

public class KnightStats : MonoBehaviour
{
    [SerializeField]
    private Text KnightName; // 1
    [SerializeField]
    private Text description; // 2
    [SerializeField]
    private Image icon; // 3
    [SerializeField]
    private Text health; // 4
    [SerializeField]
    private Text attackDamage; // 5
    [SerializeField]
    private Text defense; // 5

    public void UpdateDisplayUI(KnghtData knightdata)
    {
        KnightName.text = knightdata.KnightType;
        Debug.Log(knightdata.KnightType);
        icon.sprite = knightdata.Icon;
        health.text = knightdata.Health.ToString();
        attackDamage.text = knightdata.AttackDamage.ToString();
        defense.text = knightdata.Defense.ToString();
    }
}
