import java.awt.EventQueue;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.JSlider;
import javax.swing.JComboBox;
import javax.swing.DefaultComboBoxModel;
import javax.swing.event.ChangeListener;
import javax.swing.event.ChangeEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.ItemListener;
import java.awt.event.ItemEvent;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;


public class main extends JFrame {

	private JPanel contentPane;
	private static Player ap =  new Player();
	private static JFrame me;
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					main frame = new main();
					frame.setVisible(true);
					me = frame;
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public main() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 461, 212);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		final JLabel lblNewLabel_1 = new JLabel("0.00/0.00");
		lblNewLabel_1.setBounds(383, 63, 55, 14);
		contentPane.add(lblNewLabel_1);
		
		final JLabel lblNewLabel = new JLabel("Open Audiobook");
		lblNewLabel.setBounds(20, 11, 316, 14);
		contentPane.add(lblNewLabel);
		
		JButton btnNewButton = new JButton("Browse");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				ap.openFileDialog(me,lblNewLabel);
			}
		});
		btnNewButton.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent arg0) {
				System.out.println("d");
			}
		});
		btnNewButton.setBounds(346, 7, 89, 23);
		contentPane.add(btnNewButton);
		
		JSlider slider = new JSlider();
		slider.addChangeListener(new ChangeListener() {
			public void stateChanged(ChangeEvent arg0) {
				System.out.println("d");
			}
		});
		slider.setValue(0);
		slider.setBounds(65, 56, 318, 26);
		contentPane.add(slider);
		
		JButton btnNewButton_1 = new JButton("Stop");
		btnNewButton_1.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				System.out.println("d");
			}
		});
		btnNewButton_1.setBounds(82, 93, 89, 23);
		contentPane.add(btnNewButton_1);
		
		JButton btnNewButton_2 = new JButton("Play");
		btnNewButton_2.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				System.out.println("d");
			}
		});
		btnNewButton_2.setBounds(181, 93, 89, 23);
		contentPane.add(btnNewButton_2);
		
		JButton btnNewButton_3 = new JButton("Pause");
		btnNewButton_3.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				System.out.println("d");
			}
		});
		btnNewButton_3.setBounds(280, 93, 89, 23);
		contentPane.add(btnNewButton_3);
		
		JButton btnNewButton_4 = new JButton("Goto Bookmark");
		btnNewButton_4.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				System.out.println("d");
			}
		});
		btnNewButton_4.setBounds(163, 139, 126, 23);
		contentPane.add(btnNewButton_4);
		
		JButton btnNewButton_5 = new JButton("Set Bookmark");
		btnNewButton_5.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				System.out.println("d");
			}
		});
		btnNewButton_5.setBounds(20, 139, 126, 23);
		contentPane.add(btnNewButton_5);
		
		JComboBox comboBox = new JComboBox();
		comboBox.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent arg0) {
				System.out.println("d");
			}
		});
		comboBox.setModel(new DefaultComboBoxModel(new String[] {"Set Sleep Time", "Sleep in 30 mins", "Sleep in 1 hour", "Sleep in 2 hours"}));
		comboBox.setBounds(309, 140, 126, 20);
		contentPane.add(comboBox);
	}
}
