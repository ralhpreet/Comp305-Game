/*
 * Source File Name: SapceController.cs
 * Author: Lovepreet Ralh
 * Last Modified by: Lovepreet ralh
 * Date Last Modified: 5th Feb,2016
 * Program Description: Controls the speed of scrolling as well as the direction of scrolling 
 * Revision History:version 1.0
 * 
 */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    //Private instance variables
    private int _scoreValue;
    private int _livesValue;

    [SerializeField]// To make it visible in inspector
    private AudioSource _gameOverSound;
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
            if (this._scoreValue >= 300)
            {
                Instantiate(monster.gameObject);
            }
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
            if (this._livesValue <= 0)
            {
                this._endGame();
            }
            else
            {
                this.LivesLabel.text = "Lives:" + this._livesValue;
            }
            
        }
    }
    
    
    
    //Public instance variables
    public int fireBallNumber=3;
    public FireBallController  fireBalls;
    public IronManController ironMan;
    public HeartController heart;
    public Text LivesLabel;
    public Text Scorelabel;
    public Text GameOverLabel;
    public Text HighscoreLabel;
    public Button RestartButton;
    public MonsterController monster;
    

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
        this.GameOverLabel.enabled = false;
        this.HighscoreLabel.enabled = false;
        this.RestartButton.gameObject.SetActive(false);

        for (int fireBallCount = 0; fireBallCount < this.fireBallNumber; fireBallCount++)
        {
            Instantiate(fireBalls.gameObject);
        }
    }

    private void _endGame()
    {
        this.HighscoreLabel.text = "High Score:" + this._scoreValue;
        this.GameOverLabel.enabled = true;
        this.LivesLabel.enabled = false;
        this.Scorelabel.enabled = false;
        this.HighscoreLabel.enabled = true;
        this.heart.gameObject.SetActive(false);
        this.ironMan.gameObject.SetActive(false);
        this._gameOverSound.Play();
        //this.RestartButton.enabled = true;
        this.RestartButton.gameObject.SetActive(true);

    }

    public void RestartButtonClick()
    {
        Application.LoadLevel("Main");
    }
}
