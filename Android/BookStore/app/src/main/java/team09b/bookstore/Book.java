package team09b.bookstore;


import org.json.JSONArray;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

public class Book extends java.util.HashMap<String,String> {

    final static String host = "http://192.168.1.130/BookstoreAPI";

    public Book (String bookid, String title, String catid, String ISBN, String Author, String Stock, String Price, String discount) {
        put("BookID", bookid);
        put("Title", title);
        put("CategoryID", catid);
        put("ISBN", ISBN);
        put("Author", Author);
        put("Stock", Stock);
        put("Price", Price);
        put("BookDiscount", discount);

    }

    public Book (){}

    public static List<Book> listBook() {
        Book book1 = null;
        List<Book> list = new ArrayList<Book>();
        try {
            JSONArray a = JSONParser.getJSONArrayFromUrl(host+"/api/books");

            for (int i=0; i<a.length(); i++) {
                JSONObject c = a.getJSONObject(i);
                book1 = new Book(c.getString("BookID"),
                        c.getString("Title"),
                        c.getString("CategoryID"),
                        c.getString("ISBN"),
                        c.getString("Author"),
                        c.getString("Stock"),
                        c.getString("Price"),
                        c.getString("BookDiscount")
                );
                list.add(book1);
            }
        } catch (Exception e) {
        }
        return list;
    }

    public static Book getBook(String id) {
        Book book1 = null;
        try {
            JSONObject c = JSONParser.getJSONFromUrl(host+"/api/books/"+id);
            book1 = new Book(c.getString("BookID"),
                    c.getString("Title"),
                    c.getString("CategoryID"),
                    c.getString("ISBN"),
                    c.getString("Author"),
                    c.getString("Stock"),
                    c.getString("Price"),
                    c.getString("BookDiscount")
                    );
        } catch (Exception e) {
        }
        return book1;
    }

    public static void updateBook(Book book) {
        JSONObject jbook = new JSONObject();
        String id = book.get("BookID");
        try {
            jbook.put("BookID", book.get("BookID"));
            jbook.put("Title", book.get("Title"));
            jbook.put("CategoryID", book.get("CategoryID"));
            jbook.put("ISBN", book.get("ISBN"));
            jbook.put("Author", book.get("Author"));
            jbook.put("Stock", book.get("Stock"));
            jbook.put("Price", book.get("Price"));
            jbook.put("BookDiscount", book.get("BookDiscount"));
        } catch (Exception e) {
        }
        String result = JSONParser.postStream(host+"/api/books/"+id, jbook);
    }
}
