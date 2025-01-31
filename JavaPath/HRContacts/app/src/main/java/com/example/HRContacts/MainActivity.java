package com.example.HRContacts;

import androidx.annotation.CallSuper;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;

public class MainActivity extends DBActivity {
    protected EditText editName, editTel, editEmail, editPosition;
    protected Button btnInsert;
    protected ListView simpleList;
    protected void FillListView() throws Exception{
        final ArrayList<String> listResults=
                new ArrayList<>();
        SelectSQL(
                "SELECT * FROM CONTACTS ORDER BY Name",
                null,
                (ID,Name,Tel,Email,Position) ->{
                    listResults.add(ID+"\t"+Name+"\t"+Email+"\t"+Position+"\t"+Tel+"\n");
                }
        );
        simpleList.clearChoices();
        ArrayAdapter<String> arrayAdapter=new ArrayAdapter<>(
                getApplicationContext(),
                R.layout.activity_listview,
                R.id.textView,
                listResults
        );
        simpleList.setAdapter(arrayAdapter);
    }


    @Override
    @CallSuper
    protected  void onActivityResult(int requestCode, int resultCode, Intent data){
        super.onActivityResult(requestCode, resultCode, data);

        try {
            FillListView();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        editName = findViewById(R.id.editName);
        editTel = findViewById(R.id.editTel);
        editEmail = findViewById(R.id.editEmail);
        editPosition = findViewById(R.id.editPosition);
        btnInsert = findViewById(R.id.btnInsert);
        simpleList = findViewById(R.id.simpleList);


        simpleList.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                TextView clickedText = view.findViewById(R.id.textView);
                String selected = clickedText.getText().toString();
                String [] elements = selected.split("\t");
                String ID = elements[0];
                String Name = elements[1];
                String Email = elements[2];
                String Position = elements[3];
                String Tel = elements[4].trim();
                Intent intent = new Intent(MainActivity.this,
                        UpdateDelete.class
                        );
                Bundle b = new Bundle();
                b.putString("ID",ID);
                b.putString("Name",Name);
                b.putString("Email",Email);
                b.putString("Position",Position);
                b.putString("Tel",Tel);
                intent.putExtras(b);
                startActivityForResult(intent,200,b);


            }
        });


        try {
            initDB();
            FillListView();
        } catch (Exception e) {
            e.printStackTrace();
        }
        btnInsert.setOnClickListener(view -> {
            try{
                validation(editEmail, editTel);

                ExecSQL(
                        "INSERT INTO CONTACTS(Name, Tel, Email, Position)" +
                                "VALUES(?,?,?,?)",
                        new Object[]{
                                editName.getText().toString(),
                                editTel.getText().toString(),
                                editEmail.getText().toString(),
                                editPosition.getText().toString()
                        },
                        () -> Toast.makeText(getApplicationContext(),
                                "Record Inserted!", Toast.LENGTH_LONG).show()

                );
                FillListView();

            }catch(Exception e){
                Toast.makeText(getApplicationContext(),
                        "Insert Failed: " + e.getLocalizedMessage()
                        , Toast.LENGTH_SHORT).show();
            }

        });

    }



}