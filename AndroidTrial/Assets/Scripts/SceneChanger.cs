using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scan()
    {
        
        Application.LoadLevel(1);
    }

    public void Quit()
    {
        print("Exiting");
        Application.Quit();
    }
}
