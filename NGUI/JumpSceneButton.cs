using UnityEngine;
using System.Collections;

public class JumpSceneButton : MonoBehaviour
{
  [SerializeField] private string sceneName;

  void OnClick()
  {
    Application.LoadLevel(sceneName);
  }
}
