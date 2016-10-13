using UnityEngine;
using System.Collections;

public class SpawnCoins : MonoBehaviour {

	public GameObject coin;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawn", 2, 0.3f);
	}

	// Update is called once per frame
	void spawn () {
		Vector3 offset = GameObject.Find("CoinZone").transform.position;
		Vector3 position = new Vector3(Random.Range(-30.0F, 30.0F), 1, Random.Range(-30.0F, 30.0F));

		Instantiate (coin, position + offset, Quaternion.identity); // + Vector3(90,0,0));
	}
}
