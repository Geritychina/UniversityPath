package com.example.HRContacts;

import androidx.appcompat.app.AppCompatActivity;

import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.widget.EditText;
import android.widget.Toast;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class DBActivity extends AppCompatActivity {

    protected interface OnQuerySuccess{
        public void OnSuccess();
    }

    protected interface OnSelectSuccess{
        public void OnElementSelected(
                String ID,String Name, String Tel, String Email,String Position
        );
    }

    protected boolean matchString(String string_, String regexp){
        final String regex = regexp;
        final String string = string_;

        final Pattern pattern = Pattern.compile(regex);
        final Matcher matcher = pattern.matcher(string);

        while (matcher.find()) {
            return true;
        }
        return false;
    }

    protected void validation(EditText editEmail, EditText editTel) throws Exception {
        if(!matchString(editEmail.getText().toString(),"^[\\w\\.\\-]+@[\\w\\.\\-]+$")){
            throw new Exception("Invalid E-mail Address");
        }

        if(!matchString(editTel.getText().toString(),"^(\\+|00)?\\d+(\\/\\d+)?$")){
            throw new Exception("Invalid Phone Number");
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

    }

    protected void SelectSQL(String SelectQ,
                             String [] args,
                             OnSelectSuccess success
    )
            throws Exception
    {
        SQLiteDatabase db = SQLiteDatabase
                .openOrCreateDatabase(getFilesDir().getPath() + "/CONTACTS.db",null);
        Cursor cursor=db.rawQuery(SelectQ,args);
        while(cursor.moveToNext()){
            String ID=cursor.getString(cursor.getColumnIndexOrThrow("ID"));
            String Name=cursor.getString(cursor.getColumnIndexOrThrow("Name"));
            String Tel=cursor.getString(cursor.getColumnIndexOrThrow("Tel"));
            String Email=cursor.getString(cursor.getColumnIndexOrThrow("Email"));
            String Position=cursor.getString(cursor.getColumnIndexOrThrow("Position"));
            success.OnElementSelected(ID,Name,Tel,Email,Position);
        }
        db.close();
    }

    protected void ExecSQL(String SQL, Object [] args, OnQuerySuccess success)
            throws Exception
    {
        SQLiteDatabase db=SQLiteDatabase
                .openOrCreateDatabase(getFilesDir().getPath() + "/CONTACTS.db",null);
        if(args != null)
            db.execSQL(SQL,args);
        else
            db.execSQL(SQL);


        db.close();
        success.OnSuccess();

    }

    protected void initDB() throws Exception{
        ExecSQL(
                "CREATE TABLE if not exists CONTACTS( " +
                        "ID integer PRIMARY KEY AUTOINCREMENT," +
                        "Name text not null," +
                        "Tel text not null," +
                        "Email text not null," +
                        "Position text not null," +
                        "unique(Name,Tel)"+
                        ")",
                null,
                () -> Toast.makeText(getApplicationContext(),
                        "DB Init Successful",Toast.LENGTH_LONG).show()
        );
    }
}