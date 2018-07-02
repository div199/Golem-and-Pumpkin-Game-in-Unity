using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pumpkinscript : MonoBehaviour {

	// Use this for initialization
	void Update () {
        if (transform.position.y < -3f)
            Destroy(gameObject);	
	}

    // Update is called once per frame
    private void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "Golem")
        {
            Destroy(target.gameObject);
            Time.timeScale = 0f;
        }
    }
}
