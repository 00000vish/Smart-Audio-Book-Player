import java.awt.FileDialog;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javafx.scene.media.Media;
import javafx.scene.media.MediaPlayer;

public class Player {
	
	private static String selectedFile = "";
	private static int currentLoc = 0;
	
	//Default constructor
	public Player(){
		//TODO... this is how to basically play a file
		String bip = "bip.mp3";
		Media hit = new Media(new File(bip).toURI().toString());
		MediaPlayer mediaPlayer = new MediaPlayer(hit);
		mediaPlayer.play();
	}
	
	protected void openFileDialog(JFrame hwn, JLabel label){
		FileDialog fd = new FileDialog(hwn, "Choose a file", FileDialog.LOAD);
		fd.setDirectory("C:\\");
		fd.setFile("*.*");
		fd.setVisible(true);
		String fileName = fd.getFile();
		if (fileName != null)
		selectedFile = fd.getDirectory() + fileName;	
		label.setText(fileName);
	}
	
}
