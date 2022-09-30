using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInstantiation : MonoBehaviour
{
    //Ten Cubes 5 Spaces Apart

    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);

        //var i declares it [i] within the for loop
        for (var i = 0; i < 10; i++) {
            Instantiate(cube, new Vector3(i * 5.0f, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
