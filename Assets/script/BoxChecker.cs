using UnityEngine;
using System.Collections;

public class BoxChecker : MonoBehaviour {
    public AudioClip mybangfx;
    private AudioSource source = null;
    public int poskey = 0;
    public GameObject myobj = null;
	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        Vector2 posvec = new Vector2(0, 0);
        source.PlayOneShot(mybangfx, 0.9f);
        Destroy(this.gameObject);
        poskey = Random.Range(0, 5);
        switch (poskey)
        {
            case 0:
                posvec = new Vector2(-6f, 3.25f);
                break;
            case 1:
                posvec = new Vector2(-6, -1.25f);
                break;
            case 2:
                posvec = new Vector2(0, 3.25f);
                break;
            case 3:
                posvec = new Vector2(6f, 3.25f);
                break;
            case 4:
                posvec = new Vector2(6, -1.25f);
                break;
            case 5:
                posvec = new Vector2(0, -1.25f);
                break;
            default:
                Debug.Log("Error!");
                break;
        }
        posvec.x += Random.Range(-3f, 3f);
        posvec.y += Random.Range(-2.25f, 2.25f);
        Instantiate(myobj, posvec, new Quaternion(0, 0, 0, 0));
    }
}
