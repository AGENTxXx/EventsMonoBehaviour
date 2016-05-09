using UnityEngine;
using System.Collections;

public class EventScript : MonoBehaviour {


    public bool isVisible;
    public bool isDestroy;

    public float waitTime = 1;

    void Awake()
    {
        isVisible = false;
        isDestroy = false;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
        isDestroy = true;
        isVisible = false;
        Debug.Log("Destroy");
    }

    IEnumerator WaitAndSetIsVisible()
    {
        yield return new WaitForSeconds(waitTime);
        isVisible = true;
    }

    void OnBecameVisible()
    {
        Debug.Log("Visible");
        StartCoroutine(WaitAndSetIsVisible());
    }

    // Use this for initialization
    void Start () {
        var valTorque = Random.Range(100f, 200f);
        gameObject.GetComponent<Rigidbody2D>().AddTorque(valTorque);
    }
	
	// Update is called once per frame
	void FixedUpdate ()
	{
	    gameObject.transform.localScale += new Vector3(0.02F, 0.02F, 0);
    }
}
