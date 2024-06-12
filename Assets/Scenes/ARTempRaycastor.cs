using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARTempRaycastor : MonoBehaviour
{
    public ARRaycastManager Manager_ARRaycast;
    public GameObject Prefab_Object;


    private void UpdateCenterObject()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        Manager_ARRaycast.Raycast(screenCenter, hits, TrackableType.Planes);
    }
}
