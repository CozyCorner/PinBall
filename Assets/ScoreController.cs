using UnityEngine;
using System.Collections;
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

		if (tag == "SmallStarTag") {
			score += 10;
			Debug.Log("SmallStarTag");
		}

		else if (tag == "LargeStarTag") {
			score += 30;
			Debug.Log("LargeStarTag");
		}
			
		else if (tag == "SmallCloudTag") {
			score += 20;
			Debug.Log("SmallCloudTag");
		}

		else if (tag == "LargeCloudTag") {
			score += 50;
			Debug.Log("LargeCloudTag");
		}

		Debug.Log(score);
		this.scoreText.GetComponent<Text> ().text = "Score " + score + "pt";
	}


}
