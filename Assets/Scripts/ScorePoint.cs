using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScorePoint : MonoBehaviour
{
    public LevelManager levelManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ball")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            levelManager.WinLevel();
        }
    }
}
