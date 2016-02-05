using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    //Private instance variables
    private int _scoreValue;
    private int _livesValue;

    //Public access methods
    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }
        set
        {
            this._scoreValue = value;
            this.Scorelabel.text="Score:"+this._scoreValue;
        }
    }

    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }
        set
        {
            this._livesValue = value;
            this.LivesLabel.text = "Lives:" + this._livesValue;
        }
    }
    
    
    
    //Public instance variables
    public int fireBallNumber=3;
    public FireBallController  fireBalls;
    public Text LivesLabel;
    public Text Scorelabel;
	// Use this for initialization
	void Start () {
        this._initialize();
        
	}
	


	// Update is called once per frame
	void Update () {
	
	}

    //Private Methods###########
    private void _initialize(){
        this.ScoreValue = 0;
        this.LivesValue = 5;
        for (int fireBallCount = 0; fireBallCount < this.fireBallNumber; fireBallCount++)
        {
            Instantiate(fireBalls.gameObject);
        }
    }
}
