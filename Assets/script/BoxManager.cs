using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BoxManager : MonoBehaviour {
    public GameObject myobj = null;
    public int MAXNUM_LIMIT = 50;
    public int poskey = 0;
    Vector2 posvec = new Vector2 (0,0);
    public float maxtime = 8;
    float timetemp = 0;
    public float timeCounter = 0;
    public Text mytxt = null;
	// Use this for initialization
	void Start () {
        maxtime *= 60;
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i <= MAXNUM_LIMIT; i++) {
            timetemp += Time.deltaTime;
            timeCounter += Time.deltaTime/60;
        if (maxtime - timetemp <= 0)
            {
                Maker();
                timetemp = 0;
            }
        }
        string newstring = timeCounter.ToString("N2");
        mytxt.text = "Time is " + newstring;
	}
    public void Maker()
    {
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

    public void OnButtonCheck()
    {
        Application.LoadLevel("2_game");
    }
}
