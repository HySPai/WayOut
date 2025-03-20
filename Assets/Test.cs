using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public TestDuckBO[] testDuckBO;
    // Start is called before the first frame update
    void Start()
    {
        testDuckBO = GetComponentsInChildren<TestDuckBO>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
