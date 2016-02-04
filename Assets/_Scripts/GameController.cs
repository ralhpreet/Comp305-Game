using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    //Public instance variables
    public int fireBallNumber=30;
    public FireBallController  fireBalls;

	// Use this for initialization
	void Start () {
        this._initialize();
        //fireBalls.gameObject;
        //f
	}
	


	// Update is called once per frame
	void Update () {
	
	}

    //Private Methods###########
    private void _initialize(){
        //this.fireBallNumber = 3;
        for (int fireBallCount = 0; fireBallCount < this.fireBallNumber; fireBallCount++)
        {
            Instantiate(fireBalls.gameObject);
        }
    }
}
