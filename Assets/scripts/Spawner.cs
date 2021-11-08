using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float spawnTime;
    public GameObject pipes;
    public float height;
    float dTime = 0;

    // Update is called once per frame
    void Update()
    {
        if( dTime >= spawnTime)
        {
            GameObject iPipes = GameObject.Instantiate(pipes, this.transform.position +
                new Vector3(0, Random.Range(-height, height),0), Quaternion.identity);

            Destroy(iPipes, 3);
            dTime = 0;
        }
        dTime += Time.deltaTime;
    }
}
