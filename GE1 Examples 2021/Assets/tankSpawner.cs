using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankSpawner : MonoBehaviour
{
    public GameObject TankPrefab;

    System.Collections.IEnumerator Drop()
    {
        int maxCount = 5;
        int i = 0;
        while(true)
        {
            
            {
                if(i<maxCount){

                    GameObject b = GameObject.Instantiate<GameObject>(TankPrefab);
                    b.transform.position = new Vector3(0, 20, 0);
                    b.AddComponent<Rigidbody>();
                    b.tag = "spawnTank";

                    i++;

                }


            }
            yield return new WaitForSeconds(1);
        }
    }

    public void OnEnable()
    {
        StartCoroutine(Drop());
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
