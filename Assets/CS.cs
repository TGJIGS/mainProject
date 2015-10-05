using UnityEngine;
using System.Collections;

public class CS : MonoBehaviour {
    public GameObject circle = null;
    float size_circle = 1f;
    public float speedtobig = 3;
	public float maxsize = 25;
	public bool ischeck = false;
	public AudioSource effect = null;
	// Use this for initialization
	void Start () {
		speedtobig += Random.Range (-1, 3);
	}
	
	// Update is called once per frame
	void Update () {
        circle.transform.localScale = new Vector3 (size_circle, size_circle, 1);
        /*size_circle += Time.deltaTime*speedtobig;
        if (size_circle < 1)
        {
            size_circle = 1;
        }

        if(size_circle > 25)
        {
            size_circle = 25;
        }*/
		if (size_circle < maxsize) {
			size_circle += Time.deltaTime*speedtobig;
		}
	}
    void OnMouseDown()
    {
		//effect.PlayOneShot;
        circle.gameObject.SetActive(false);
		//Destroy (this);
		ischeck = true;
		Debug.Log ("isCheck is " + ischeck);
    }
}
