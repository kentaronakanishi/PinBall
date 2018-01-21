using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//パブリッククラスのScoreControllerを宣言
public class ScoreController : MonoBehaviour {

	//スコアを表示するテキスト (型　クラス　変数)
	private GameObject scoreText;
	private GameObject scoreText2;


	//タグによって得点を変える
	private int sstar;
	private int lstar;
	private int scloud;
	private int lcloud;
	//スコア用の変数を宣言
	private double i;
	private double lim;
	private double gap;
	private double p;
	private double ss;
	private double ssi;
	private double ls;
	private double lsi;
	private double sc;
	private double sci;
	private double lc;
	private double lci;
	private string s;
	private string s2;


	// Use this for initialization
	void Start () {
		//シーン中のScoreTextオブジェクトを取得
		scoreText = GameObject.Find("ScoreText");
		scoreText2 = GameObject.Find("ScoreTextPlus");
	}



	// Update is called once per frame
	void Update () {
		//得点計算
		//各タグのオブジェクトに当たった数だけ乗算する
		for (ssi = ssi; ssi <= sstar; ssi++) {
			ss = ss + sstar * sstar;
		}
		for (lsi = lsi; lsi <= lstar; lsi++) {
			ls = ls + lstar * lstar;
		}
		for (sci = sci; sci <= scloud; sci++) {
			sc = sc + scloud * scloud;
		}
		for (lci = lci; lci <= lcloud; lci++) {
			lc = lc + lcloud * lcloud;
		}
		//
		lim = (ss + ls + sc + lc);
		p = 1 +lim/1000;
			if(i >= lim){i=lim;
		}else{i = i + p;}

		s = i.ToString("F0");
		//シーン中のScoreTextを表示
		scoreText.GetComponent<Text> ().text = s;

		gap = lim - i;
		s2 = gap.ToString("F0");
		//シーン中のScoreTextPlusを表示
		scoreText2.GetComponent<Text> ().text ="+ "+ s2;

}


	//衝突判定を持つ。
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "SmallStarTag") {
			sstar += 1;
			Debug.Log("小スターにヒット　現在"+sstar+"回ヒット");
		} else if (other.gameObject.tag == "LargeStarTag") {
			lstar += 1;
			Debug.Log("大スターにヒット　現在"+lstar+"回ヒット");

		}else if(other.gameObject.tag == "SmallCloudTag") {
			scloud += 1;
			Debug.Log("小雲にヒット　現在"+scloud+"回ヒット");

		}else if(other.gameObject.tag == "LargeCloudTag") {
			lcloud += 1;
			Debug.Log("大雲にヒット　現在"+lcloud+"回ヒット");

		}			

			
		}

	}