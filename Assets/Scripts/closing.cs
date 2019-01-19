using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

     	// メディアスキャン
		scanFile(Application.persistentDataPath+"/","text/plane");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void scanFile( string path, string mimeType )
    {
        if( Application.platform != RuntimePlatform.Android )
             return;
#if UNITY_ANDROID
        using( AndroidJavaClass jcUnityPlayer = new AndroidJavaClass( "com.unity3d.player.UnityPlayer" ) )
        using( AndroidJavaObject joActivity = jcUnityPlayer.GetStatic<AndroidJavaObject>( "currentActivity" ) )
        using( AndroidJavaObject joContext = joActivity.Call<AndroidJavaObject>( "getApplicationContext" ) )
        using( AndroidJavaClass jcMediaScannerConnection = new AndroidJavaClass( "android.media.MediaScannerConnection" ) )
        using( AndroidJavaClass jcEnvironment = new AndroidJavaClass( "android.os.Environment" ) )
        using( AndroidJavaObject joExDir = jcEnvironment.CallStatic<AndroidJavaObject>( "getExternalStorageDirectory" ) )
        {
            Debug.Log( "scanFile:" + path );
            var mimeTypes = ( mimeType != null ) ? new string[] { mimeType } : null;
            jcMediaScannerConnection.CallStatic( "scanFile", joContext, new string[] { path }, mimeTypes, null );
        }
        Handheld.StopActivityIndicator();
#endif
    }

}
