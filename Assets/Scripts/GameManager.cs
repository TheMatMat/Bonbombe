using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

  public int points = 0;

  public static GameManager instance;

  private void Awake()
  {
    if(instance != null)
    {
      return;
    }
    instance = this;
  }

}
