import javax.swing.*;
import javax.swing.text.DefaultCaret;
import javax.swing.event.*;
import java.awt.*;
import java.awt.event.*;


public class CharBreaker extends JFrame implements CaretListener, ActionListener
{
	JTextField textField = null;
	JButton button = null;
	
	public CharBreaker()
	{
		Font font = new Font("Times New Roman", Font.PLAIN, 20);
		textField = new JTextField(20);
		textField.setFont(font); // this won't work!
		textField.setHorizontalAlignment(JTextField.LEFT);
		textField.addCaretListener(this);
		
		button = new JButton("Calculate Character Boundaries");
		button.setActionCommand("calculate");
		button.addActionListener(this);
		
        // textField.setComponentOrientation(ComponentOrientation.RIGHT_TO_LEFT);
		JPanel p = new JPanel();
        p.add(textField);
        p.add(button);

        this.getContentPane().add(p);

        this.pack();
        this.setVisible(true);
	}

	public void calculateMetrics()
	{
		textField.requestFocus();
		
		DefaultCaret c = (DefaultCaret)textField.getCaret();
		if(c != null)
		{
			first_char_offset = 0;
			s = textField.getText();
			number_of_chars = s.length();
			// enter calc_mode
			calc_mode = true;
			c.setDot(0);
			
		/*	for(int i = 0; i < number_of_chars; i++)
			{
				c.setDot(i);
				c = (DefaultCaret)textField.getCaret();
				c.moveDot(i+1);
				//textField.setCaretPosition(i);
				System.out.println(c.toString() + ", " + s.charAt(i) + " " + c.getX() + ":" + c.getY());
				try {Thread.sleep(250);} catch (Exception e) {}
				c.getMark();
			}
		*/
		}
	}

	boolean calc_mode = false;
	double first_char_offset = 0;
	String s = "";
	int number_of_chars = 0;
	
	public void caretUpdate(CaretEvent e) 
	{
		DefaultCaret c = (DefaultCaret)textField.getCaret();
		System.out.println(c.getDot() + " " + c.getX());
		System.out.println(e.toString());
		if(calc_mode == true)
		{
			int i = c.getDot();
			if(i == 0 )
			{
				first_char_offset = c.getX();
			}
			
			double x = c.getX() - first_char_offset;
			
			System.out.println(s.charAt(i) + ":" + x);
			// process the caret
			System.out.println(i + " " + c.getX() + ":" + c.getY());
			if(i == number_of_chars)
			{
				calc_mode = false;
				c.setDot(i);
			}
			else
			{
				c.setDot(i+1);
				c.moveDot(i+2);
			}
		}
	}

	public void actionPerformed(ActionEvent e)
	{
		if("calculate".equals(e.getActionCommand()))
		{
			calculateMetrics();
		}
	}

	public static void main(String[] args) {
		JFrame w = new CharBreaker();
		//System.exit(0);
	}

}