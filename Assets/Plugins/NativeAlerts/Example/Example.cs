using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour {

	public void OnButtonClick() {
		#if UNITY_EDITOR
		UnityEditor.EditorUtility.DisplayDialog("title", "message", "ok");
		#endif
	}
}
