using UnityEngine;
using System.Collections;

public class AndroidOnly : MonoBehaviour
{
#if !UNITY_ANDROID
  void Awake()
  {
    Destroy(gameObject);
  }
#endif
}
