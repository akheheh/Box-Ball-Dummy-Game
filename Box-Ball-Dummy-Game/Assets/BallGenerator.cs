﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallGenerator : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    [SerializeField] GameObject boxPrefab;
    [SerializeField] GameObject dummyPrefab;

    [SerializeField] GameObject Bouncer;
    
    public void spewObject(Vector2 coord, GameObject obj) {
        GameObject objCopy = Instantiate(obj);
        objCopy.transform.position = coord;
        Rigidbody2D rigidBody = objCopy.GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(0.5f,0);
    }

    void Destroyer() {
        Destroy(this.gameObject);
    }

    public void getPointer() {
        BoxCollider2D rigby = Bouncer.GetComponent<BoxCollider2D>();
        rigby.transform.position = Input.mousePosition;
    }
    public void Start() {
        
    }

    public void Update() {
        getPointer();
        
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            spewObject(Camera.main.ScreenToWorldPoint(Input.mousePosition), ballPrefab);
            
        }
        
        if(Input.GetKeyDown(KeyCode.Alpha2)) {
            spewObject(Camera.main.ScreenToWorldPoint(Input.mousePosition), boxPrefab);
        }

        if(Input.GetKeyDown(KeyCode.Alpha3)) {
            spewObject(Camera.main.ScreenToWorldPoint(Input.mousePosition), dummyPrefab);
        }



        if(Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }

    }
}
