/*
 * Source File Name: IronManController.cs
 * Author: Lovepreet Ralh
 * Last Modified by: Lovepreet ralh
 * Date Last Modified: 5th Feb,2016
 * Program Description: Controls the speed of scrolling as well as the direction of scrolling 
 * Revision History:version 1.1
 * 
 */
using UnityEngine;
using System.Collections;

public class IronmanCollider : MonoBehaviour {
    //Private Instance Variables
    private AudioSource[] _audioSources;
    private AudioSource _fireBallSound;
    private AudioSource _heartSound;


    //Public Instance Variables
    public GameController gameController;
	// Use this for initialization
	void Start () {
        //Initialize the audioSources array
        this._audioSources = gameObject.GetComponents<AudioSource>();
        this._fireBallSound = this._audioSources[1];
        this._heartSound = this._audioSources[2];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D otherGameObject)
    {   
        //Play the fireball sound if Ironman collides with fireball
        if (otherGameObject.gameObject.CompareTag("FireBall"))
        {
            this._fireBallSound.Play();
            this.gameController.LivesValue -= 1;
        }
        //Play the heart sound if Ironman collides with fireball
        if (otherGameObject.gameObject.CompareTag("Heart"))
        {
            this._heartSound.Play();
            this.gameController.ScoreValue += 100;
        }
    }
}
