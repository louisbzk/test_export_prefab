using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotation : MonoBehaviour
{
    public float baseRate = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 eulerRotation = new Vector3(baseRate, 0, 0)*Time.deltaTime;
        transform.Rotate(eulerRotation);
    }
}
