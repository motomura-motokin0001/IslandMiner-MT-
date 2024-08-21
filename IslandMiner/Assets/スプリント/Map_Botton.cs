using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button_game_start_c : MonoBehaviour
{
        void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(osu);
    
    }
    void osu()
    {

        SceneManager.LoadScene("MAP");

    }
}
