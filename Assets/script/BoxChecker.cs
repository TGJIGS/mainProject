using UnityEngine;
using System.Collections;

public class BoxChecker : MonoBehaviour {
    public AudioClip mybangfx;
    private AudioSource source = null;
	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        source.PlayOneShot(mybangfx, 0.9f);
        Destroy(this.gameObject);
    }
}
