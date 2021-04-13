using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashFade : MonoBehaviour
{
	public Image splashImage;
	public Text splashText;
	public string loadLevel;

	IEnumerator Start()
	{
		splashImage.canvasRenderer.SetAlpha(0.0f);
		splashText.canvasRenderer.SetAlpha(0.0f);

		FadeIn();
		yield return new WaitForSeconds(0.5f);
		FadeOut();
		yield return new WaitForSeconds(0.5f);
		SceneManager.LoadScene(loadLevel);
	}

	void FadeIn()
	{
		splashImage.CrossFadeAlpha(0.0f, 0.5f, false);
		splashText.CrossFadeAlpha(0.0f, 0.5f, false);
	}

	void FadeOut()
	{
		splashImage.CrossFadeAlpha(0.0f, 0.5f, false);
		splashText.CrossFadeAlpha(0.0f, 0.5f, false);
	}
}