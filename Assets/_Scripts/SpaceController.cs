/*
 * Source File Name: SapceController.cs
 * Author: Lovepreet Ralh
 * Last Modified by: Lovepreet ralh
 * Date Last Modified: 5th Feb,2016
 * Program Description: Controls the speed of scrolling as well as the direction of scrolling 
 * Revision History:version 1.1
 * 
 */

using UnityEngine;
using System.Collections;

public class SpaceController : MonoBehaviour {
    //Public instance variables
    // Fix the speed of scrolling
    public float speed = 5f;

    //Private Instace Variables
    private Vector2 _currentPosition;
    private Transform _transform;
	
    // Use this for initialization
	void Start () {
        //Make a reference with transform component
	    this._transform=gameObject.GetComponent<Transform>();
        //Reset the space sprite to the top
        this.Reset();
	}
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed,0);
        this._transform.position = this._currentPosition;
        if (this._currentPosition.x <= -480)
        {
            this.Reset();
        }
	}

    //public method
    public void Reset()
    {
        this._transform.position = new Vector2(480f, 0);
    }
}
