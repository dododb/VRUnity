using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntityInformation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private static float lifePoint = 100.0f;
    [SerializeField] private float initalLifePoint = 100.0f;
    [SerializeField] private static bool isDead = false;
    public bool IsDead {get => isDead;set => isDead = value;}
    [SerializeField] private Slider healthPoint;

    void Start()
    {
        healthPoint.maxValue = initalLifePoint;
        healthPoint.value = initalLifePoint;
        lifePoint = initalLifePoint;
    }

    public void receiveDamage(float amountDamage)
    {
        lifePoint -= amountDamage;
        healthPoint.value = lifePoint;
        isDead = lifePoint <= 0;
    }
}
