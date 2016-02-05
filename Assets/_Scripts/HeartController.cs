/*
 * Source File Name: SapceController.cs
 * Author: Lovepreet Ralh
 * Last Modified by: Lovepreet ralh
 * Date Last Modified: 5th Feb,2016
 * Program Description: Controls the speed of heart as well as reset it everytime it goes off the screen
 * Revision History:version 1.0
 * 
 */
using UnityEngine;
using System.Collections;

public class HeartController : MonoBehaviour {

    //Public instance variables
    public float speed = 5f;
    //Private Instace Variables
    private Vector2 _currentPosition;
    Transform _transform;
    // Use this for initialization
    void Start()
    {
        //Make a reference with transform component
        this._transform = gameObject.GetComponent<Transform>();
        //Reset the Heart sprite to the top
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(this.speed, 0);
        this._transform.position = this._currentPosition;
        if (this._currentPosition.x <= -260)
        {
            this.Reset();
        }
    }
    void Reset()
    {
        float yPosition = Random.Range(-150f, 145f);
        this._transform.position = new Vector2(260f, yPosition);
    }
}
