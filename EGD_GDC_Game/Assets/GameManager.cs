using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    public static GameManager instance = null;
    private bool Movement = false;
    // Use this for initialization
    void Start () {
		
	}

    public void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            DontDestroyOnLoad(gameObject);
    }
    public bool getMovement()
    {
        return Movement;
    }
    public void setMovement(bool state)
    {
        Movement = state;
    }
    void Update()
    {
        
    }
}
