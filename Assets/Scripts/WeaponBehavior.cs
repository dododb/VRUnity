using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float damage = 5;
    [SerializeField] private int weaponType;
    private Rigidbody rigidbody;
    private Collider collider;
    private GameObject Hit;
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        collider = gameObject.GetComponent<Collider>();
        weaponType = gameObject.layer;
    }

    void OnTriggerEnter(Collider other)
    {
        Hit = other.gameObject;
        if (weaponType == LayerMask.NameToLayer("Sharpness") && Hit.layer == LayerMask.NameToLayer("Flesh"))
        {
            collider.isTrigger = true;
            Hit.GetComponent<EntityInformation>().receiveDamage(damage);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (Hit == other.gameObject)
        {
            Hit = null;
            collider.isTrigger = false;
        }
    }
}