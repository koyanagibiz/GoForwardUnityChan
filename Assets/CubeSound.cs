using System.Collections;
using UnityEngine;

public class CubeSound : MonoBehaviour {

	//宣言
	private AudioSource hitsound;

	void Start () {

		//コンポーネント取得
		hitsound = GetComponent<AudioSource>();


	}

	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		//判定確認用ログ
		Debug.Log ("OnCollisionEnter2D: " + other.gameObject.tag);
	
		//groundとcubeに衝突した時のみ音を鳴らす
		if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Cube") {
			hitsound.Play();
		}
	}
}
