using CandyCoded.env;
using UnityEngine;

public class GitEnv : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (env.TryParseEnvironmentVariable("DEVELOPMENT", out bool isDev))
        {
            Debug.Log($"Mode : {(isDev ? "Dev" : "Prod")}");

            if (env.TryParseEnvironmentVariable("API_HOST", out string host))
            {
                Debug.Log($"Host is: {host}");
            }

            if (env.TryParseEnvironmentVariable("API_PORT", out string port))
            {
                Debug.Log($"Port is: {port}");
            }
        }

        if (env.TryParseEnvironmentVariable("DEBUG", out bool isDebug))
        {
            Debug.Log($"Debug Mode is: {(isDebug ? "ON" : "OFF")}");
        }
    }
}
