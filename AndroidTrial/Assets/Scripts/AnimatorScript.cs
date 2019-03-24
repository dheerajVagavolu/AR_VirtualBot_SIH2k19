using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Talk()
    {
        int switchcase = UnityEngine.Random.Range(1, 4);
        string aa = "Talking2";
        switch (switchcase)
        {
            case 1:
                aa = "Talking2";
                break;

            case 2:
                aa = "Talking3";
                break;

            case 3:
                aa = "Talking4";
                break;
        }
        anim.Play(aa, -1, 0.5f);
    }
}
