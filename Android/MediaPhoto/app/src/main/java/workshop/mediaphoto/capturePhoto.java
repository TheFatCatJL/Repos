package workshop.mediaphoto;

import android.app.Activity;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.net.Uri;
import android.os.Bundle;
import android.os.Environment;
import android.provider.MediaStore;
import android.util.Log;
import android.view.View;
import android.widget.ImageView;

import java.io.BufferedOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.InputStream;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Locale;

public class capturePhoto extends Activity {

    final int CAPTURE_IMAGE_ACTIVITY_REQUEST_CODE=101;
    final int CAPTURE_IMAGE_ACTIVITY_REQUEST_CODE2=102;
    String path = null;
    String path2 = null;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_capture_photo);
        setContentView(R.layout.activity_capture_photo);
        restoreInstanceState(savedInstanceState);
        showPictures();
    }


    public void capturePhoto(View view) {
        Intent intent = new Intent(MediaStore.ACTION_IMAGE_CAPTURE);
        startActivityForResult(intent, CAPTURE_IMAGE_ACTIVITY_REQUEST_CODE);
    }

    public void capturePhoto2(View view) {
        Intent intent = new Intent(MediaStore.ACTION_IMAGE_CAPTURE);
        path2 = makeFilename();
        Uri imageUri = Uri.fromFile(new File(path2));
        intent.putExtra(android.provider.MediaStore.EXTRA_OUTPUT, imageUri);
        startActivityForResult(intent, CAPTURE_IMAGE_ACTIVITY_REQUEST_CODE2);
    }

    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        if (requestCode == CAPTURE_IMAGE_ACTIVITY_REQUEST_CODE) {
            if (resultCode == RESULT_OK) {
                Bitmap bitmap = (Bitmap) data.getExtras().get("data");
                path = makeFilename();
                savePicture(bitmap, path);
                recreate();
            }
        }
        if (requestCode == CAPTURE_IMAGE_ACTIVITY_REQUEST_CODE2) {
            if (resultCode == RESULT_OK) {
                recreate();
            }
        }
    }

    @Override
    public void onSaveInstanceState(Bundle outState) {
        outState.putString("path", path);
        outState.putString("path2", path2);
        super.onSaveInstanceState(outState);
    }

    private void restoreInstanceState(Bundle state) {
        if (state != null && state.containsKey("path"))
            path = state.getString("path");
        if (state != null && state.containsKey("path2"))
            path2 = state.getString("path2");
    }

    void showPicture(String p, int resource) {
        if (p != null) {
            ImageView v = (ImageView) findViewById(resource);
            Bitmap bitmap = resize(loadPicture(p), 600);
            v.setImageBitmap(bitmap);
        }
    }

    void showPictures() {
        showPicture(path, R.id.imageView1);
        showPicture(path2, R.id.imageView2);
    }

    String makeFilename() {
        String timeStamp = new SimpleDateFormat("yyyyMMddHHmmss", Locale.US).format(new Date());
        String p = String.format("%s/IMG_%s.jpg",
                Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_PICTURES),
                timeStamp);
        return p;
    }

    void savePicture(Bitmap bitmap, String path) {
        try {
            FileOutputStream f = new FileOutputStream(path);
            BufferedOutputStream bos = new BufferedOutputStream(f);
            bitmap.compress(Bitmap.CompressFormat.JPEG, 90, bos);
            bos.close();
            f.close();
        } catch (Exception e) {
            Log.i("savePicture() error", e.toString());
        }
    }

    Bitmap resize(Bitmap bitmap, int size) {
        if (bitmap.getHeight() > size*2 && bitmap.getWidth() > size*2) {
            double ratio = size*1.0/bitmap.getHeight();
            Bitmap b = Bitmap.createScaledBitmap(bitmap,
                    (int) (bitmap.getWidth()*ratio),
                    (int) (bitmap.getHeight()*ratio), false);
            bitmap = b;
        }
        return bitmap;
    }

    Bitmap loadPicture(String p) {
        Bitmap bitmap = null;
        try {
            InputStream fis = new FileInputStream(p);
            bitmap = BitmapFactory.decodeStream(fis);
            fis.close();
        } catch (Exception e) {
            Log.i("readPicture()", "read error");
        }
        return bitmap;
    }
}
