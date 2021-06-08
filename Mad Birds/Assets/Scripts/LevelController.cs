using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private Enemy[] _enemies;
    [SerializeField] private int _nextLevelIndex;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Enemy enemy in _enemies)
        {
            if (enemy != null)
            {
                return;
            }
        }
        
        string nextLevelName = "level" + _nextLevelIndex;
            
        SceneManager.LoadScene(nextLevelName);
    }
}
