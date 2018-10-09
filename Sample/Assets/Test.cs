using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int hp = 0;
        if (hp == 0)
        {
            Debug.Log("ただの屍のようだ");
        }
        else if(hp <= 50)
        {
            Debug.Log("先に行け…");
        }
        else if(hp >= 200)
        {
            Debug.Log("攻!");
        }
        else
        {
            Debug.Log("防!");
        }

        }
}