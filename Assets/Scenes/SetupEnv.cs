using CandyCoded.env;
using UnityEngine;

public class SetupEnv : MonoBehaviour
{
    private readonly string filename = "dev";

    private void Awake()
    {
        env.SetFilename(filename);
    }

    void Start()
    {

        if (env.TryParseEnvironmentVariable("API_HOST", out string host))
        {
            Debug.Log($"Host is: {host}");
        }

        if (env.TryParseEnvironmentVariable("API_PORT", out string port))
        {
            Debug.Log($"Port is: {port}");
        }

        if (env.TryParseEnvironmentVariable("DEBUG", out bool isDebug))
        {
            Debug.Log($"Debug Mode is: {(isDebug ? "ON" : "OFF")}");
        }
    }
}