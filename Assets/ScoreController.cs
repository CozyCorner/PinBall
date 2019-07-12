using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
	private int score;
	private GameObject scoreText;

	// Use this for initialization
	void Start () {
		score = 0;

		this.scoreText = GameObject.Find("ScoreText");
		this.scoreText.GetComponent<Text> ().text = "Score " + score + "pt";
	}

	// Update is called once per frame
	void Update () {
	}


	//衝突時に呼ばれる関数
	private void OnCollisionEnter(Collision other) {
		Debug.Log("Collision");

		if (other.gameObject.tag == "SmallStarTag") {
			score += 10;
			Debug.Log("SmallStarTag");
		}

		else if (other.gameObject.tag == "LargeStarTag") {
			score += 30;
			Debug.Log("LargeStarTag");
		}
			
		else if (other.gameObject.tag == "SmallCloudTag") {
			score += 20;
			Debug.Log("SmallCloudTag");
		}

		else if (other.gameObject.tag == "LargeCloudTag") {
			score += 50;
			Debug.Log("LargeCloudTag");
		}

		Debug.Log(score);

		this.scoreText.GetComponent<Text> ().text = "Score " + score + "pt";
	}


}
