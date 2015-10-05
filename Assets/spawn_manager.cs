using UnityEngine;
using System.Collections;

public class spawn_manager : MonoBehaviour {
	public float timecounter = 0;
	public float spawninterval =2f;
	float temp=0;
	public GameObject circlespawn = null;
	int spawnposmanage = 0;
	Vector3 spawnpos;
	//Vector2 spawnpos[6]={(-6.14f,2.2f),(-6.14f;-2.4f),(0,-2.4f),(0,2.2f),(6.47f,2.66f),(5.78f,-2.4f)};
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timecounter += Time.deltaTime;
		temp += Time.deltaTime;
		if (spawninterval - temp <= 0) {
			spawnposmanage = Random.Range (0, 5);
			switch (spawnposmanage) {
			case 0:
				spawnpos = new Vector2 (-6.14f, 2.2f);
				break;
			case 1:
				spawnpos = new Vector2 (-6.14f, -2.4f);
				break;
			case 2:
				spawnpos = new Vector2 (0, -2.4f);
				break;
			case 3:
				spawnpos = new Vector2 (0, 2.2f);
				break;
			case 4:
				spawnpos = new Vector2 (6.47f, 2.66f);
				break;
			case 5:
				spawnpos = new Vector2 (5.78f, -2.4f);
				break;
			}
			Instantiate (circlespawn, spawnpos,new Quaternion (0,0,0,0));
			temp =Random.Range(-1,0.5f);
		}

	}

	public void OnButton_Check(){
		Application.LoadLevel(0);
	}
}
