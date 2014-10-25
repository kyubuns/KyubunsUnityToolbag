using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SequenceTweenAnimation : MonoBehaviour
{
  [SerializeField] GameObject original;
  [SerializeField] float interval;
  [SerializeField] List<GameObject> targets;

  void Awake()
  {
    if(!original)
    {
      Debug.LogWarning("missing original game object.");
      return;
    }

    for(int i=0; i<targets.Count; ++i)
    {
      var copyTween = targets[i].AddComponent<CopyTween>();
      copyTween.original = original;
      copyTween.delay = interval * (i+1);
    }
  }
}
