using UnityEngine;
using System.Collections;

public class BGScroller : MonoBehaviour {

    public float scrollSpeed;

    private float tileSizeZ;
    private Vector3 startPosition;
    private Transform myTransform;

	// Use this for initialization
	void Start () {

        myTransform = GetComponent<Transform>();
        startPosition = myTransform.position;
        tileSizeZ = myTransform.localScale.y;
	
	}
	
	// Update is called once per frame
	void Update () {

        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        myTransform.position = startPosition + Vector3.forward * newPosition;
	
	}
}
