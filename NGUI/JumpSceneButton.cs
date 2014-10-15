using UnityEngine;
using System.Collections;

public class JumpSceneButton : MonoBehaviour
{
  [SerializeField] string sceneName;

  void OnClick()
  {
    Application.LoadLevel(sceneName);
  }
}
