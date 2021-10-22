using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

  public int points = 0;
  public int health = 3;

  public Text score;
  public Text lifeText;

  public static GameManager instance;

  private void Awake()
  {
    if(instance != null)
    {
      return;
    }
    instance = this;
  }

  void Update()
  {
      score.text = points.ToString();
      lifeText.text = health.ToString();
      if(health == 0)
      {
          FindObjectOfType<DeathCanvas>().DeathHappens();
      }
  }

}
