package com.example.androidchat;

import androidx.room.AutoMigration;
import androidx.room.Database;
import androidx.room.RoomDatabase;

import com.example.androidchat.Models.Contact;
import com.example.androidchat.Models.Message;
import com.example.androidchat.Models.User;

// if we change the models in the future, we will have to increment the version by 1
@Database(
        entities = {User.class, Contact.class, Message.class},
        version = 2,
        autoMigrations = {
                @AutoMigration(from = 1, to = 2)
        }
)

public abstract class AppDB extends RoomDatabase {
    public abstract ChatDao chatDao();


}
