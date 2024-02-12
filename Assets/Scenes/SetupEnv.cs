using CandyCoded.env;
using UnityEngine;
using UnityEngine.UI;

public class SetupEnv : MonoBehaviour
{
    private readonly string filename = "prod";

    public Text hostText;
    public Text portText;
    public Text debugText;

    private void Awake()
    {
        env.SetFilename(filename);
    }

    void Start()
    {

        if (env.TryParseEnvironmentVariable("API_HOST", out string host))
        {
            Debug.Log($"Host is: {host}");
            hostText.text = host;
        }

        if (env.TryParseEnvironmentVariable("API_PORT", out string port))
        {
            Debug.Log($"Port is: {port}");
            portText.text = port;
        }

        if (env.TryParseEnvironmentVariable("DEBUG", out bool isDebug))
        {
            Debug.Log($"Debug Mode is: {(isDebug ? "ON" : "OFF")}");
            debugText.text = isDebug ? "ON" : "OFF";
        }
    }
}