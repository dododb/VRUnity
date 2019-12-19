using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private EntityInformation entityInformation;
    void Start()
    {
        entityInformation = gameObject.GetComponent<EntityInformation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(entityInformation.IsDead){
            entityInformation.IsDead = false;
            Destroy(gameObject);
        } 
    }
}
