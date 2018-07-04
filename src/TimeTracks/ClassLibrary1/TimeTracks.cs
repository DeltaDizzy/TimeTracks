using System;
using System.Collections.Generic;
using UnityEngine;

namespace TimeTracks
{
    public class TimeTracks :MonoBehaviour
    {
        KerbalEVA kerb;
        Collider collider;

        private void Awake()
        {
            collider = gameObject.GetComponent<Collider>();
        }
        public void Log(string msg)
        {
            msg = String.Format(msg, "[TIMETRACKS]: ");
            Debug.Log(msg);
        }
        public void JumpTrack()
        {
            collider.enabled = false;
        }
        public void Arrive()
        {
            collider.enabled = true;
        }
    }
}
