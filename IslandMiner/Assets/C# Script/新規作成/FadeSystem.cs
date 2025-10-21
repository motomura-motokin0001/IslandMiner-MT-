using DG.Tweening;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class SceneLoadSystem : MonoBehaviour
{

    public static SceneLoadSystem instance;
    [SerializeField] private Image _fadeImage;
    [SerializeField] private float FadeTime = 1.0f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        _fadeImage.gameObject.SetActive(false);

    }

    public void FadeIn(string NextSceneName)
    {
        _fadeImage.gameObject.SetActive(true);
        Debug.Log("Fade In");
        _fadeImage.DOFade(1, FadeTime).OnComplete(() =>
        {
            SceneLoad(NextSceneName);
        });
    }

    void FadeOut()
    {
        Debug.Log("Fade Out");
        _fadeImage.DOFade(0, FadeTime).OnComplete(() =>
        {
            _fadeImage.gameObject.SetActive(false);
        });
        
    }

    void SceneLoad(string NSN)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(NSN);
        FadeOut();
    }
}
