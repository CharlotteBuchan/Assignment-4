

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/// <summary>
/// Script untuk setiap tombol pada menu Utama
/// </summary>

public class MenuButtonsScript : MonoBehaviour
{

	void Start ()
	{
		GameParent.alphabetIndex = 0;
	}

	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
	
	public void OnUpperButtonClick (int i)
	{
		switch (i) {
		case 1:
			{
				SubmenuControl.menuType = SubmenuControl.SubMenuType.LearntoRead;
				SubmenuControl.gotoScene = "Learn to Read";
                    SceneManager.LoadScene("Submenu Select");
			}
			break;
		case 2:
			{
				SubmenuControl.menuType = SubmenuControl.SubMenuType.LearntoWrite;
				SubmenuControl.gotoScene = "Learn to Write";
                    SceneManager.LoadScene("Submenu Select");
			}
			break;
		case 3:
			{
				SubmenuControl.menuType = SubmenuControl.SubMenuType.Pattern;
				SubmenuControl.gotoScene = "Patterns";
                    SceneManager.LoadScene("Submenu Select");
			}
			break;
		default:
			break;
		}
		//randomChanceInterstitial();
	}

	public void OnLowerButtonClick (int i)
	{
		switch (i) {
		case 4:
                SceneManager.LoadScene("Find the Answer");
			break;
		case 5:
                SceneManager.LoadScene("Puzzle");
			break;
		case 6:
                SceneManager.LoadScene("Quiz");
			break;
		}
		//randomChanceInterstitial();
	}

	private void randomChanceInterstitial ()
	{
//		int rnd = Random.Range (0, 100);
//		if (rnd >= 20)
//			AdmobManager.RequestInterstitial ();
	}
}
