using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
public class Widgets : MonoBehaviour {

	public Text time;
	public Text date;
	public Text time1;
	public Text date1;
	void Start (){	

	}

	void Update(){

	}

	void OnGUI() {
//		var TimeStyle = new GUIStyle ();
//		
//		TimeStyle.fontSize = 30;
//		TimeStyle.normal.textColor = Color.red;
//		TimeStyle.font = (Font)Resources.Load("Fonts/trench", typeof(Font));
//		GUI.Label (new Rect (350, 300, 100, 20), DateTime.Now.ToString ("h:mm:ss tt"), TimeStyle);
		time.text = DateTime.Now.ToString("hh:mm:ss");
		date.text = DateTime.Now.ToString("yyyy-M-d dddd");
		time1.text = DateTime.Now.ToString("hh:mm:ss");
		date1.text = DateTime.Now.ToString("yyyy-M-d dddd");
	}
}