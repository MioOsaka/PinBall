using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPoint : MonoBehaviour {

	//ポイントを表示するテキスト
	private GameObject showPoint;
	//ポイント初期値
	public int point = 0;
	//ポイント文字列
	private string pointStr;

	// Use this for initialization
	void Start () {
		//シーン中のGameOverTextオブジェクトを取得
		this.showPoint = GameObject.Find("PointText");

	}

	// Update is called once per frame
	void Update ()
	{
		//得点を取得した場合
		pointStr = point.ToString ();
		//PointTextに合計点を表示
		this.showPoint.GetComponent<Text>().text= pointStr;

//		Debug.Log(pointStr);

	}
}
