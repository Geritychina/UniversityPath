package com.example.HRContacts;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.method.BaseKeyListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class UpdateDelete extends DBActivity {

    protected EditText editName, editTel, editEmail, editPosition;
    protected Button btnUpdate,btnDelete;
    protected String ID;

    private void BackToMain(){
        finishActivity(200);
        Intent i = new Intent(UpdateDelete.this,
                MainActivity.class);
        startActivity(i);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_update_delete);
        editName = findViewById(R.id.editName);
        editTel = findViewById(R.id.editTel);
        editEmail = findViewById(R.id.editEmail);
        editPosition = findViewById(R.id.editPosition);
        btnUpdate = findViewById(R.id.btnUpdate);
        btnDelete = findViewById(R.id.btnDelete);
        Bundle b = getIntent().getExtras();
        if(b!=null){
            ID = b.getString("ID");
            editName.setText(b.getString("Name"));
            editTel.setText(b.getString("Tel"));
            editEmail.setText(b.getString("Email"));
            editPosition.setText(b.getString("Position"));
        }

        btnDelete.setOnClickListener(view->{
            try{
                ExecSQL("DELETE FROM CONTACTS WHERE " +
                                "ID = ?",
                        new Object[]{ID},
                        () -> Toast.makeText(getApplicationContext(),
                                "Delete Successful", Toast.LENGTH_LONG).show()
                        );
                BackToMain();
            }catch(Exception exception){
                Toast.makeText(getApplicationContext(),
                        "Delete Error" + exception.getLocalizedMessage(),
                        Toast.LENGTH_LONG).show();
            }finally {
                BackToMain();
            }

        });

        btnUpdate.setOnClickListener(view->{
            try{
                validation(editEmail,editTel);
                ExecSQL("UPDATE CONTACTS SET " +
                                "Name = ?, " +
                                "Tel = ?, " +
                                "Email = ?, " +
                                "Position = ?" +
                                "WHERE ID = ?",
                        new Object[]{
                                editName.getText().toString(),
                                editTel.getText().toString(),
                                editEmail.getText().toString(),
                                editPosition.getText().toString(),
                                ID},
                        () -> Toast.makeText(getApplicationContext(),
                                "Update Successful", Toast.LENGTH_LONG).show()
                );
                BackToMain();
            }catch(Exception exception){
                Toast.makeText(getApplicationContext(),
                        "Update Error" + exception.getLocalizedMessage(),
                        Toast.LENGTH_LONG).show();
            }finally {
                BackToMain();
            }

        });



    }
}