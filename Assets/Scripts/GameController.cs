using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject monster;
    [SerializeField] private Transform Spawn1;
    [SerializeField] private Transform Spawn2;
    void Start()
    {
        //Physics.IgnoreLayerCollision(LayerMask.NameToLayer("Flesh"), LayerMask.NameToLayer("Sharpness"));
        InvokeRepeating("SpawnMonster", 0, 5);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnMonster()
    {
        if (GameObject.Find(monster.name + "(Clone)"))return;
        int spawnPointX = Random.Range((int)Spawn2.position.x, (int)Spawn1.position.x);
        int spawnPointZ = Random.Range((int)Spawn2.position.y, (int)Spawn1.position.y);
        Vector3 spawnPosition = new Vector3(spawnPointX, 2, spawnPointZ);
        Instantiate(monster, spawnPosition, Quaternion.Euler(-90,180,0));
    }
}
