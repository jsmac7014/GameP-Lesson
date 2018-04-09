using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour {

    public GameObject arrowPrefab; //프리팹을 넣기위한 변수 선언
    float span = 1.0f; //1초가 지났는지를 비교ㄷ
    float delta = 0; // time.deltaTime이 누적

	// Use this for initialization
	void Start () {
        this.delta += Time.deltaTime;
        if (this.delta > this.span) {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
