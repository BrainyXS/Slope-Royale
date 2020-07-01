using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public GameObject[] GameObjects;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(GameObjects[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
