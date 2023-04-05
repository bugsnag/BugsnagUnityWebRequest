using System;
using UnityEngine.Events;
using UnityEngine.Networking;

namespace BugsnagNetworking
{
    public class BugsnagNetworkListener
    {
        public RequestEvent OnSend = new RequestEvent();

        public RequestEvent OnComplete = new RequestEvent();

        public RequestEvent OnAbort = new RequestEvent();
    }

    [System.Serializable]
    public class RequestEvent : UnityEvent<BugsnagUnityWebRequest>
    {
        
    }
}