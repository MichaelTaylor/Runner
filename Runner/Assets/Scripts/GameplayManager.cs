using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour {

    public static GameplayManager instance;

	// Use this for initialization
	void Start ()
    {
		
	}

    private void Singleton()
    {
        if (GameplayManager.instance == null)
        {
            GameplayManager.instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

	// Update is called once per frame
	void Update ()
    {
		
	}
}
