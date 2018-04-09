using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carController : MonoBehaviour {
    public Text distance;
    public Text start;
    public GameObject overUI;
    public Transform point;

    AudioSource ad;

    float speed = 0;
    Vector2 startPos;


	// Use this for initialization
	void Start () {
        ad = GetComponent<AudioSource>();
        overUI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            start.gameObject.SetActive(false);
            this.startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButtonUp(0)){
            Vector2 endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float swipeLength = (endPos.x - startPos.x);
            Debug.Log(swipeLength);

            ad.Play();
            this.speed =  swipeLength*1.5f;      
       }
        

        transform.Translate(this.speed*Time.deltaTime, 0, 0);
        this.speed *= 0.98f;
        float dis = (point.position.x-this.transform.position.x);
        if (dis <= 0)
        {
            overUI.SetActive(true);
            Application.Quit();
        }
        distance.text = "Distance : " + dis.ToString("N2")+ "m";
	}
}
