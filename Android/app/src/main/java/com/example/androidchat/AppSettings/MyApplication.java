package com.example.androidchat.AppSettings;

import android.app.Application;
import android.content.Context;

import androidx.lifecycle.MutableLiveData;

import com.example.androidchat.Adapters.MessageListAdapter;

import java.util.List;

public class MyApplication extends Application {
    /** User Settings **/
    public static final String PREFERENCES = "preferences";
    public static final String CUSTOM_THEME = "customTheme";
    public static final String LIGHT_THEME = "lightTheme";
    public static final String DARK_THEME = "darkTheme";
    public static String customTheme;

    /** App Settings **/
    public static Context context;
    public static String jwtToken;
    public static String firebaseToken;
    public static String connected_user;



    /** static vars for firebase **/
    public static MessageListAdapter messageListAdapter;
    public static MutableLiveData<List<String>> newMessageData;

    @Override
    public void onCreate() {
        super.onCreate();
        context = getApplicationContext();
    }
}
