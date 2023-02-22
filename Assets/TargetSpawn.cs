using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawn : MonoBehaviour
{
    private int maxTargets = 3;
    private Vector3 objPos;

    public GameObject targetPrefab;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.childCount <= maxTargets)
        {
            System.Random rand = new System.Random();

            objPos = new Vector3(rand.Next(-25, 25), rand.Next(-15, 15), 0);
            GameObject target = Instantiate(targetPrefab,objPos,gameObject.transform.rotation); 
            target.transform.parent = gameObject.transform;
        }
    }
}
