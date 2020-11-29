using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float speed;
	private float waktuTunggu;
	public float startWaktuTunggu;

	public Transform moveSpot;
	public float minX;
	public float maxX;
	public float minY;
	public float maxY;
	public float minZ;
	public float maxZ;

	// Use this for initialization
	void Start () {
		waktuTunggu = startWaktuTunggu;

		moveSpot.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, moveSpot.position, speed = Time.deltaTime);

		if(Vector3.Distance(transform.position, moveSpot.position) < 0.2f){
			if(waktuTunggu <= 0){
				moveSpot.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
				waktuTunggu = startWaktuTunggu;
			} else
			{
				waktuTunggu -= Time.deltaTime;
			}
		}
	}
}