using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GetPoint : MonoBehaviour {
	public int addPoint;

	//ポイントを表示するテキスト
	private GameObject showPoint;

	// Use this for initialization
	void Start () {
		//シーン中のGameOverTextオブジェクトを取得
		this.showPoint = GameObject.Find("PointText");
	}
	// Update is called once per frame
	void Update () {		
	}

	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other) {
		// タグによって追加の点数を変える
		if (tag == "SmallStarTag") {
			addPoint = 10;
		} else if (tag == "LargeStarTag") {
			addPoint = 20;
		} else if (tag == "SmallCloudTag") {
			addPoint = 30;
		} else if (tag == "LargeCloudTag") {
			addPoint = 50;
		}

		this.showPoint.GetComponent<ShowPoint>().point += addPoint;

	}

}
	