import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

//singleton actionlistener format
public class HelloWorld extends JFrame {
    int count=0;

    public HelloWorld() {
        super("HelloWorld");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(150, 200);
        JLabel label = new JLabel("Hello World");
        JButton button = new JButton("click me");
        button.addActionListener((e)->{
            count++;
            System.out.printf("Button Click %d\n", count);
        });

        JButton button2 = new JButton("click me2");
        button2.addActionListener((e)->{
            count++;
            System.out.printf("Button2 Click %d\n", count);
        });

        JPanel c = new JPanel();
        getContentPane().add(c);
        c.add(label);
        c.add(button);
        c.add(button2);
        setVisible(true);
    }
    public static void main(String[] args) {
        new HelloWorld();
    }
}