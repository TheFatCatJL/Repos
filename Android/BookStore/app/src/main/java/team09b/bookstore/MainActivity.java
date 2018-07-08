package team09b.bookstore;

import android.app.ListActivity;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.AsyncTask;
import android.os.Bundle;
import android.preference.PreferenceManager;
import android.view.View;
import android.widget.Adapter;
import android.widget.ListAdapter;
import android.widget.ListView;
import android.widget.SimpleAdapter;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends ListActivity {

    String searchparams;
    String priceparams;
    String finalparams;
    int flag;

    protected void preferenceRead(SharedPreferences pref) {

        searchparams = pref.getString("searchpara","");
        priceparams = pref.getString("pricepara","0");
        if(searchparams.isEmpty() && priceparams.isEmpty()) {
            finalparams = "";
            flag = 0;
        }
        else if (searchparams.isEmpty() && priceparams !="0") {
            finalparams = priceparams;
            flag=2;
        }
        else
        {
            finalparams = searchparams;
            flag=1;
        }
    }

    List<Book> manipulateBookList(List<Book> booklist, int flag)
    {
        finalparams = finalparams.toLowerCase();
        List<Book> mylist = new ArrayList<Book>();
        if (flag == 0)
            return booklist;
        if (flag == 1) {
            for (Book x : booklist) {
                String x1 = x.get("Title").toLowerCase();
                String x2 = x.get("Author").toLowerCase();
                String x3 = x.get("ISBN").toLowerCase();
                if (x1.contains(finalparams))
                    mylist.add(x);
                else if (x2.contains(finalparams))
                    mylist.add(x);
                else if (x3.contains(finalparams))
                    mylist.add(x);

            }
            return mylist;
        }
        if (flag == 2) {
            for (Book x : booklist) {
                if (Float.parseFloat(x.get("Price").toString())<=Float.parseFloat(finalparams))
                    mylist.add(x);
            }
            return mylist;
        }
        return booklist;
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        SharedPreferences pref = PreferenceManager.getDefaultSharedPreferences(getApplicationContext());
        preferenceRead(pref);
        new AsyncTask<Void, Void, List<Book>>() {
            @Override
            protected List<Book> doInBackground(Void... params) {
                return Book.listBook();
            }
            @Override
            protected void onPostExecute(List<Book> result) {
                List<Book> newresult = manipulateBookList(result,flag);
                setContentView (R.layout.rowlist);
                CustomAdapter adapter = new CustomAdapter(getApplicationContext(), newresult); //place your String array in place of MyString
                ListView lv = (ListView) findViewById(android.R.id.list); //the ID you set your ListView to.
                lv.setAdapter(adapter);

//                setListAdapter(new SimpleAdapter
//                        (getApplicationContext(), newresult, R.layout.row,
//                                new String[]{"Title","Price"},
//                                new int[]{ R.id.text1st, R.id.text2nd}));

//                ArrayAdapter<String> adapter =
//                        new ArrayAdapter<String>(getApplicationContext(),
//                                R.layout.row, R.id.textView, list1);
//                setListAdapter(adapter);

//                ArrayAdapter<String> adapter2 =
//                        new ArrayAdapter<String>(getApplicationContext(),
//                                R.layout.row, R.id.textView2, list2);
//                setListAdapter(adapter2);
            }
        }.execute();
    }


    @Override
    protected void onListItemClick(ListView l, View v,
                                   int position, long id) {
        Book book = (Book) l.getAdapter().getItem(position);
        String bookstr = book.get("BookID");
        Intent intent = new Intent(this, DetailsActivity.class);
        intent.putExtra("Id", bookstr);
        startActivity(intent);    }

}
