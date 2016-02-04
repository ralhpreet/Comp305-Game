﻿using UnityEngine;
using System.Collections;

public class IronManController : MonoBehaviour {
    //Public instance variables
    public float speed = 5f;

    //Private instance variables
    private float _playerInput;
    private Transform _transform;
    private Vector2 _currentPosition;
	// Use this for initialization
	void Start () {
        this._transform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;
        this._playerInput = Input.GetAxis("Vertical");
        if (this._playerInput > 0)
        {
            this._currentPosition += new Vector2(0, this.speed);
        }
        if (this._playerInput < 0)
        {
            this._currentPosition += new Vector2(0, -this.speed);

        }
        
        this._checkBounds();
        this._transform.position = this._currentPosition;

        
	}

    //Private method to keep the Ironman in the game's boundary
    private void _checkBounds()
    {
        if (this._currentPosition.y > 170)
        {
            this._currentPosition.y = 170;
        }
        if (this._currentPosition.y < -170)
        {
            this._currentPosition.y = -170;
        }
        
    }
}