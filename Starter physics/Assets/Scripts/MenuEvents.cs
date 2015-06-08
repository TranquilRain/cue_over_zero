using UnityEngine;
using System.Collections;

public class MenuEvents : MonoBehaviour {

	public void loadLevel(string level)
	{
		print(level);
		Application.LoadLevel(level);
	}
	
}
