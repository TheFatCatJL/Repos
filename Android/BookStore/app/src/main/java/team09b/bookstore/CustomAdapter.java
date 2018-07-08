package team09b.bookstore;

import android.app.Application;
import android.content.Context;
import android.content.res.Resources;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.Drawable;
import android.media.Image;
import android.support.v4.content.ContextCompat;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import java.net.URL;
import java.util.List;

class CustomAdapter extends ArrayAdapter<Book>
{
    List<Book> objects = null;
    public CustomAdapter(Context context, List<Book> objects) {
        super(context, R.layout.row2, objects); //set the layout that contains your views (not the one with the ListView)
        this.objects = objects;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {

        LayoutInflater inflater = LayoutInflater.from(getContext());
        View view = inflater.inflate(R.layout.row2, parent, false); //same here.

        TextView textView1 = (TextView) view.findViewById(R.id.text1st);
        TextView textView2 = (TextView) view.findViewById(R.id.text2nd);
        TextView textView3 = (TextView) view.findViewById(R.id.text3rd);
        ImageView image = (ImageView) view.findViewById(R.id.image);
        String StringGenerated = "i"+objects.get(position).get("ISBN");
        Context c = getContext();
        int i = c.getResources().getIdentifier(StringGenerated, "drawable", c.getPackageName());
        textView1.setText(objects.get(position).get("Title"));
        textView2.setText(objects.get(position).get("Author"));
        textView3.setText("Price: $" + objects.get(position).get("Price") + "    Stock: "+ objects.get(position).get("Stock"));
        image.setImageResource(i);
        return view;
    }

    @Override
    public int getCount() {
        return objects.size();
    }

    @Override
    public Book getItem(int position) {
        return objects.get(position);
    }

    @Override
    public long getItemId(int position) {
        return position;
    }



}
